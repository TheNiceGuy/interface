Public Class Connexion
    Dim Inscription As Inscription
    Dim Gestion As Gestion
    Dim Auth As Authentification
    Dim NetworkContainer As New NetworkingContainer(Of Networking)
    Dim Network As New Networking
    Dim OptionsContainer As New OptionsContainer(Of Options)
    Dim Options As New Options
    Dim ErrorHandlerContainer As New ErrorHandlerContainer(Of ErrorHandler)
    WithEvents ErrorHandler As New ErrorHandler
    WithEvents ConMecanism As New ConnexionMecanisme(NetworkContainer, OptionsContainer, ErrorHandlerContainer)

    Private Delegate Sub DelFormVisible(ByVal State As Boolean)
    Private Delegate Sub DelFormShow()
    Private Delegate Sub DelFormHide()
    Private Delegate Sub DelFormClose()
    Private Delegate Sub DelButtonInscription(ByVal State As Boolean)
    Private Delegate Sub DelButtonConnection(ByVal State As Boolean)
    Private Delegate Sub DelLabelConnection(ByVal Message As String)
    Dim FormShowAccess As New DelFormShow(AddressOf Show)
    Dim FormHideAccess As New DelFormHide(AddressOf Hide)
    Dim FormCloseAccess As New DelFormClose(AddressOf Close)
    Dim ButtonInscriptionAccess As New DelButtonInscription(AddressOf DelButtonInscriptionAccess)
    Dim ButtonConnexionAccess As New DelButtonConnection(AddressOf DelButtonConnexionAccess)
    Dim LabelConnectionAccess As New DelLabelConnection(AddressOf DelTextBoxLogAccess)

    Private Sub DelButtonInscriptionAccess(ByVal State As Boolean)
        ButtonInscription.Enabled = State
    End Sub

    Private Sub DelButtonConnexionAccess(ByVal State As Boolean)
        ButtonConnexion.Enabled = State
    End Sub

    Private Sub DelTextBoxLogAccess(ByVal Message As String)
        ToolStripStatusLabelConnection.Text = Message
    End Sub

    Public Sub New()
        InitializeComponent()

        'On crée les références.
        NetworkContainer.Networking = Network
        OptionsContainer.Options = Options
        ErrorHandlerContainer.ErrorHandler = ErrorHandler
    End Sub

    Private Sub ConnectionFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        'On démarre le mécanisme de connexion.
        ConMecanism.StartPeriodicConnection()
    End Sub

    Private Sub ConnectionFormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'On ferme la connexion si elle est ouverte.
        If Network.Connected Then
            Network.Shutdown()
        End If

        'On arrête le mécanisme de connection.
        ConMecanism.StopPeriodicConnection()
    End Sub

    Private Sub OpenOptions(sender As Object, e As EventArgs) Handles ButtonOptions.Click
        'On affiche la fenêtre.
        Options.ShowDialog()
    End Sub

    Private Sub OpenInscription(sender As Object, e As EventArgs) Handles ButtonInscription.Click
        Dim Worker As New Worker(NetworkContainer)

        'On regarde si le client doit se reconnecter.
        If Options.Updated Then
            Return
        End If

        'On receuille les programmes afin d'ouvrir la fenêtre.
        Worker.Work(CommandType.ListeProgramme)
        AddHandler Worker.JobFinished, AddressOf OpenInscriptionSuccess
        AddHandler Worker.JobFailed, AddressOf ErrorHandler.WorkerFailed
    End Sub

    Private Sub Disconnected() Handles ErrorHandler.DisconnectedEvent
        ConnectionEventConnectedState(False)

        'On regarde si la fenêtre de gestion a été créée.
        If Gestion Is Nothing Then
            Return
        End If

        'On ferme la fenêtre de gestion et on montre la fenêtre de connexion.
        If Gestion.IsHandleCreated Then
            Gestion.FormClose()
            Invoke(FormShowAccess)
        End If
    End Sub

    Private Sub ConnectionEventTimer(ByVal Text As String) Handles ConMecanism.EventTimer
        StatusStrip.Invoke(LabelConnectionAccess, Text)
    End Sub

    Private Sub ConnectionEventConnectedState(ByVal State As Boolean) Handles ConMecanism.EventConnectedState
        ButtonInscription.Invoke(ButtonInscriptionAccess, State)
        ButtonConnexion.Invoke(ButtonConnexionAccess, State)
    End Sub

    Private Sub OpenInscriptionSuccess(ByVal Data As Object)
        'On crée le formulaire d'inscription selon les programmes disponibles.
        Inscription = New Inscription(Data)

        'On affiche le formulaire. On peut effectuer plusieurs inscriptions en même temps.
        Inscription.ShowDialog()

        'On s'assure qu'un étudiant a été créé.
        If Inscription.Etudiant Is Nothing Then
            Return
        End If

        'On tente d'ajouer l'étudiant à la base de données.
        AddEtudiant(Inscription.Etudiant)
    End Sub

    Private Sub AddEtudiant(ByVal Etudiant As Etudiant)
        Dim Worker As New Worker(NetworkContainer)

        'On ajoute l'étudiant dans la base de données.
        Worker.Work(CommandType.AddEtudiant, Etudiant)
        AddHandler Worker.JobFinished, AddressOf AddEtudiantSuccess
        AddHandler Worker.JobFailed, AddressOf ErrorHandler.WorkerFailed
    End Sub

    Private Sub AddEtudiantSuccess(ByVal Data As Object)
        MessageBox.Show("L'étudiant avec la matricule " & Data & "  fut ajouté avec succèes.")
    End Sub

    Private Sub LoginClick(sender As Object, e As EventArgs) Handles ButtonConnexion.Click
        'On regarde si le client doit se reconnecter.
        If Options.Updated Then
            Return
        End If

        'On s'assure que l'utilisateur a entré sa matricule.
        If TextBoxMatricule.Text.Trim = vbNullString Then
            MessageBox.Show("Veuillez entrer votre matricule.")
            TextBoxMatricule.Focus()
            Return
        End If

        'On s'assure que l'utilisateur a entré son mot de passe.
        If TextBoxPassword.Text.Trim = vbNullString Then
            MessageBox.Show("Veuillez entrer votre mot de passe.")
            TextBoxPassword.Focus()
            Return
        End If

        'On crée l'authentification.
        Auth = New Authentification(TextBoxMatricule.Text, TextBoxPassword.Text)

        'On performe l'authentification auprès du serveur.
        Login(Auth)
    End Sub

    Private Sub Login(ByVal Auth As Authentification)
        Dim Worker As New Worker(NetworkContainer)

        'On ajoute l'étudiant dans la base de données.
        Worker.Work(CommandType.Authentificate, Auth)
        AddHandler Worker.JobFinished, AddressOf LoginSuccess
        AddHandler Worker.JobFailed, AddressOf ErrorHandler.WorkerFailed
    End Sub

    Public Sub LoginSuccess(ByVal Data As Object)
        'On récupère l'information sur l'utilisateur avant d'ouvrir la fenêtre.
        'Il est inutile d'ouvrir une autre thread, car cette fonction devrait 
        'être appelée par la thread d'un worker.
        Try
            Gestion = New Gestion(NetworkContainer, ErrorHandlerContainer, Network.ExecuteCommand(CommandType.RetrieveInfo))
        Catch ex As Exception
            ErrorHandler.WorkerFailed(ex)
            Return
        End Try

        'On cache la fenêtre de connexion.
        Invoke(FormHideAccess)

        'On ouvre la fenêtre de gestion.
        Try
            Gestion.ShowDialog()
        Catch ex As NetworkConnectionClosed
            ErrorHandler.Disconnected()
        Catch ex As NetworkConnectionLost
            ErrorHandler.Disconnected()
        Catch ex As NetworkCommandFailed
            Select Case ex.Err
                Case ErrorType.NotAuthentificated
                    MessageBox.Show("Veuillez vous reconnecter.")
                Case Else
                    MessageBox.Show("Une erreur s'est produite." & vbNewLine & "Code d'erreur : " & ex.Err)
            End Select
        End Try

        'On gère le code retourné par la fenêtre de gestion.
        Select Case Gestion.Code
            Case ExitReason.ConnectionError
                Invoke(FormShowAccess)
            Case ExitReason.Disconnect
                Network.ExecuteCommand(CommandType.Deauthentificate)
                Invoke(FormShowAccess)
            Case ExitReason.Failed
                Invoke(FormShowAccess)
            Case ExitReason.Quit
                Network.ExecuteCommand(CommandType.Deauthentificate)
                Invoke(FormCloseAccess)
        End Select
    End Sub
End Class
