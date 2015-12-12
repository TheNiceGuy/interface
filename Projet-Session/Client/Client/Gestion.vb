Public Enum ExitReason As Integer
    ConnectionError
    Disconnect
    Failed
    Quit
End Enum

Public Class Gestion
    Dim NetworkContainer As NetworkingContainer(Of Networking)
    WithEvents ErrorHandlerContainer As ErrorHandlerContainer(Of ErrorHandler)
    Dim Utilisateur As Etudiant
    Dim Programmes As DataTable
    Dim Etudiants As DataTable
    Dim ReturnCode As ExitReason = ExitReason.Failed

    Private Delegate Sub QuickDelegate()
    Private Delegate Sub DelFormClose()
    Dim FormCloseAccess As New DelFormClose(AddressOf Close)

    Public Sub FormClose()
        If IsHandleCreated Then
            Try
                Invoke(FormCloseAccess)
            Catch ex As System.ComponentModel.InvalidAsynchronousStateException

            End Try
        End If
    End Sub

    Public Sub New(ByVal NetContainer As NetworkingContainer(Of Networking),
                   ByVal ErrContainer As ErrorHandlerContainer(Of ErrorHandler),
                   ByVal Etudiant As Etudiant)
        InitializeComponent()

        NetworkContainer = NetContainer
        ErrorHandlerContainer = ErrContainer
        Utilisateur = Etudiant

        'On initialise les contrôles.
        LabelEtudiantInfoModif.Text = vbNullString
        LabelProgrammeInfoModif.Text = vbNullString
        LabelNaissanceInfoModif.Text = vbNullString
        LabelCourrielInfoModif.Text = vbNullString
    End Sub

    Private Sub GestionFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchData()

        'On actualise les contrôles.
        LoadInformation()
    End Sub

    Private Sub GestionFormResize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        ResizeListView()
    End Sub

    Private Sub Appliquer(sender As Object, e As EventArgs) Handles ButtonAccepter.Click
        Dim Modif As Boolean = False
        Dim Etudiant As New Etudiant(Utilisateur)
        Dim Message As String = "Êtes-vous sûre de vouloir apporter les modifications suivantes?" & vbNewLine
        Dim Programme As String = Nothing
        Dim Passkey As String = Nothing
        Dim Courriel As String = Nothing
        Dim Worker As New Worker(NetworkContainer)

        'On regarde si l'utilisateur a choisie un nouveau programme.
        If Not ComboBoxProgrammeModif.SelectedIndex = -1 Then
            Programme = ComboBoxProgrammeModif.SelectedItem
            Message += "- nouveau programme" & vbNewLine
            Modif = True
        End If

        'On regarde si l'utilisateur a choisie un nouveau mot de passe.
        If TextBoxPasswordModif.Text.Trim = TextBoxPasswordVerificationModif.Text.Trim Then
            If Not TextBoxPasswordModif.Text.Trim = vbNullString Then
                Passkey = TextBoxPasswordModif.Text.Trim
                Message += "- nouveau mot de passe" & vbNewLine
                Modif = True
            End If
        Else
            MessageBox.Show("Le mot de passe de confirmation diffère de votre mot de passe.")
            TextBoxPasswordVerificationModif.Focus()
            Return
        End If

        'On regarde si l'utilisateur a choisie une nouvelle addresse courriel.
        If Not TextBoxCourrielModif.Text.Trim = vbNullString Then
            Courriel = TextBoxCourrielModif.Text.Trim
            Message += "- nouvelle addrese courriel" & vbNewLine
            Modif = True
        End If

        'On s'assure que le courriel n'est pas trop grand pour la base de données.
        If TextBoxCourrielModif.Text.Trim.Length > Config.MaxLength Then
            MessageBox.Show("L'addresse courriel entrée est trop grande.")
            TextBoxCourrielModif.Focus()
            Return
        End If

        'On effectue la modification s'il y en a eu une.
        If Modif Then
            If MessageBox.Show(Message, "Confirmation", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Etudiant.Programme = Programme
                Etudiant.Passkey = Passkey
                Etudiant.Courriel = Courriel
            Else
                Return
            End If
        Else
            MessageBox.Show("Vous n'avez entré aucune modification.")
            Return
        End If

        ButtonAccepter.Enabled = False
        ModEtudiant(Etudiant)
    End Sub

    Private Sub ModEtudiant(ByVal Etudiant As Etudiant)
        Dim Worker As New Worker(NetworkContainer)

        'On modifie l'étudiant dans la base de données.
        Worker.Work(CommandType.ModEtudiant, Etudiant)
        AddHandler Worker.JobFinished, AddressOf ModEtudiantSuccess
        AddHandler Worker.JobFailed, AddressOf ErrorHandlerContainer.ErrorHandler.WorkerFailed
    End Sub

    Private Sub ModEtudiantSuccess(ByVal Data As Object)
        Dim QuickAccessFetch As New QuickDelegate(AddressOf FetchData)
        Dim QuickAccessInformation As New QuickDelegate(AddressOf LoadInformation)

        'On update l'information.
        Utilisateur = Data
        Invoke(QuickAccessFetch)
        Invoke(QuickAccessInformation)

        MessageBox.Show("La modification fut effectué avec succès.")
    End Sub

    Private Sub ResetModification(sender As Object, e As EventArgs) Handles ButtonReset.Click
        LoadModification()
    End Sub

    Private Sub UpdateData(sender As Object, e As EventArgs) Handles ButtonActualiser.Click
        FetchData()
    End Sub

    Private Sub MenuQuit(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        ReturnCode = ExitReason.Quit
        Close()
    End Sub

    Private Sub MenuDeconnect(sender As Object, e As EventArgs) Handles DeToolStripMenuItem.Click
        ReturnCode = ExitReason.Disconnect
        Close()
    End Sub

    Private Sub ProgrammeSelected(sender As Object, e As EventArgs) Handles ComboBoxFiltreProgramme.SelectedIndexChanged
        LoadListEtudiant()
    End Sub

    Private Sub FetchData()
        Dim WorkerPro As New Worker(NetworkContainer)
        Dim WorkerEtu As New Worker(NetworkContainer)

        'On désactive les ComboBox lorsque l'on télécharge les choix.
        ComboBoxFiltreProgramme.Enabled = False
        ComboBoxProgrammeModif.Enabled = False
        ButtonAccepter.Enabled = False

        'On envoie les commandes.
        WorkerPro.Work(CommandType.ListeProgramme)
        WorkerEtu.Work(CommandType.ListeEtudiant)
        AddHandler WorkerPro.JobFinished, AddressOf FetchDataProgrammesSuccess
        AddHandler WorkerEtu.JobFinished, AddressOf FetchDataEtudiantsSuccess
        AddHandler WorkerPro.JobFailed, AddressOf ErrorHandlerContainer.ErrorHandler.WorkerFailed
        AddHandler WorkerEtu.JobFailed, AddressOf ErrorHandlerContainer.ErrorHandler.WorkerFailed
    End Sub

    Private Sub FetchDataProgrammesSuccess(ByVal Data As Object)
        Dim QuickAccessModification As New QuickDelegate(AddressOf LoadModification)
        Dim QuickAccessFiltre As New QuickDelegate(AddressOf LoadFiltre)

        Programmes = Data
        Invoke(QuickAccessModification)
        Invoke(QuickAccessFiltre)
    End Sub

    Private Sub FetchDataEtudiantsSuccess(ByVal Data As Object)
        Dim QuickAccessEtudiant As New QuickDelegate(AddressOf LoadListEtudiant)

        Etudiants = Data
        Invoke(QuickAccessEtudiant)
    End Sub

    Private Sub LoadInformation()
        'On actualise l'information sur l'utilisateur.
        LabelEtudiantInfoModif.Text = Utilisateur.Prenom & " " & Utilisateur.Nom
        LabelProgrammeInfoModif.Text = Utilisateur.Programme
        LabelNaissanceInfoModif.Text = Format(Utilisateur.Naissance, Globalization.CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern)
        LabelCourrielInfoModif.Text = Utilisateur.Courriel
    End Sub

    Private Sub LoadModification()
        'On supprime toutes modifications.
        ComboBoxProgrammeModif.SelectedIndex = -1
        ComboBoxProgrammeModif.Items.Clear()
        For Each Row In Programmes.Rows
            ComboBoxProgrammeModif.Items.Add(Row.Item(0))
        Next
        ComboBoxProgrammeModif.Enabled = True
        TextBoxPasswordModif.Clear()
        TextBoxPasswordVerificationModif.Clear()
        TextBoxCourrielModif.Clear()
        ButtonAccepter.Enabled = True
    End Sub

    Private Sub LoadListEtudiant()
        Dim NewRow As ListViewItem

        'On clear la ListView.
        ListViewEtudiants.Items.Clear()

        'On boucle sur toutes les utilisateurs.
        For Each Row In Etudiants.Rows
            If ComboBoxFiltreProgramme.SelectedItem = vbNullString Then
                NewRow = New ListViewItem(New String() {Row("Étudiant"), Row("Programme"), Row("Courriel")})
            ElseIf ComboBoxFiltreProgramme.SelectedItem = Row("Programme") Then
                NewRow = New ListViewItem(New String() {Row("Étudiant"), Row("Programme"), Row("Courriel")})
            Else
                Continue For
            End If

            'On ajoute la ligne dans le ListView.
            ListViewEtudiants.Items.Add(NewRow)
        Next

        'On resize la ListView.
        ResizeListView()
    End Sub

    Private Sub LoadFiltre()
        'On clear la ComboBox et on rajoute une ligne vide qui définie aucun filtre.
        ComboBoxFiltreProgramme.Items.Clear()
        ComboBoxFiltreProgramme.Items.Add("")

        'On boucle dans la table de programmes pour les rajouter dans la ComboBox.
        For Each Row As DataRow In Programmes.Rows
            ComboBoxFiltreProgramme.Items.Add(Row.Item(0))
        Next
        ComboBoxFiltreProgramme.Enabled = True

        'On sélection la ligne vide par défaut.
        ComboBoxFiltreProgramme.SelectedIndex = 0
    End Sub

    Private Sub ResizeListView()
        'On resize chaque colonne.
        For Each Column As ColumnHeader In ListViewEtudiants.Columns
            Column.Width = -2
        Next
    End Sub

    Public ReadOnly Property Code As ExitReason
        Get
            Return ReturnCode
        End Get
    End Property
End Class