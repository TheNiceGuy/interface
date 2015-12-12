Public Class Superviseur
    Dim Connections As Integer = 0
    WithEvents Server As New Server

    Private Delegate Sub DelTextBoxLog(ByVal Message As String)
    Dim TextBoxLogAccess As New DelTextBoxLog(AddressOf DelTextBoxLogAccess)

    Public Sub New()
        InitializeComponent()

        Application.EnableVisualStyles()
    End Sub

    Private Sub DelTextBoxLogAccess(ByVal Message As String)
        TextBoxLog.AppendText(Message & vbNewLine)
    End Sub

    Private Sub Superviseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ToolStripStatusLabelStatut.Text = "Déconnecté"

        TextBoxAddresseModif.Text = Config.Addresse
        NumericUpDownPortModif.Value = Config.Port
        ButtonControl.Text = "Démarrer"
    End Sub

    Private Sub Superviseur_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'On ferme le serveur s'il est ouvert.
        If Server.Status Then
            Server.Shutdown()
        End If
    End Sub

    Private Sub ButtonChoisirChemin_Click(sender As Object, e As EventArgs) Handles ButtonChoisirChemin.Click
        Dim FileDialog As New OpenFileDialog

        'On demande à l'utilisateur de choisir un fichier.
        FileDialog.Filter = "Fichiers .accdb | *.accdb"
        FileDialog.ShowDialog()
        If FileDialog.FileName = vbNullString Then
            Return
        End If

        TextBoxChemin.Text = FileDialog.FileName
    End Sub

    Private Sub ButtonControl_Click(sender As Object, e As EventArgs) Handles ButtonControl.Click
        'On regarde si on démarre ou ferme le serveur.
        If Server.Status Then
            Try
                Server.Shutdown()
            Catch ex As ServerOperationFailed
                MessageBox.Show("The server failed to shutdown.")
                Server.StackTrace(ex)
                Return
            End Try

            'On update les contrôles.
            ToolStripStatusLabelStatut.Text = "Déconnecté"
            ButtonControl.Text = "Démarrer"
        Else
            'On s'assure que l'administrateur a bien configuré le serveur.
            If Not ControlCheck() Then
                Return
            End If

            'On démarre le serveur.
            Try
                Server.Bootstrap(TextBoxChemin.Text, TextBoxAddresseModif.Text, NumericUpDownPortModif.Value)
            Catch ex As Exception
                MessageBox.Show("The server failed to bootstrap.")
                Server.StackTrace(ex)
                Return
            End Try

            'On update les contrôles.
            ToolStripStatusLabelStatut.Text = "Connecté"
            ButtonControl.Text = "Arrêter"
        End If
    End Sub

    Private Sub Server_EventLog(ByVal Message As String) Handles Server.EventLog
        TextBoxLog.Invoke(TextBoxLogAccess, Message)
    End Sub

    Private Function ControlCheck() As Boolean
        'On s'assure qu'un fichier est sélectionné.
        If TextBoxChemin.Text.Trim = vbNullString Then
            MessageBox.Show("Veuillez sélectionner votre base de données.")
            Return False
        End If

        Return True
    End Function
End Class
