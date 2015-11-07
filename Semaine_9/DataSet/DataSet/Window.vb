Imports System.Data.OleDb

Public Class Window
    Dim Connexion As OleDbConnection
    Dim ConnexionValid As Boolean = False
    Dim MetierLoaded As Boolean = False
    Dim DSet As System.Data.DataSet
    Dim DAdapter As OleDbDataAdapter

    Private Sub Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxSexe.SelectedIndex = 0
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim FileDialog As New OpenFileDialog
        Dim ConnexionString As String

        'On demande à l'utilisateur de choisir un fichier.
        FileDialog.ShowDialog()
        If FileDialog.FileName = vbNullString Then
            Return
        End If

        'On configure la connection à la base de données.
        ConnexionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & FileDialog.FileName
        Connexion = New OleDbConnection(ConnexionString)

        'On vérifie la connection à la base de données.
        Try
            Connexion.Open()
            Connexion.Close()

            ConnexionValid = True
        Catch ex As System.Data.OleDb.OleDbException
            Return
        End Try

        'On télécharge la base de données.
        LoadMetier()
        LoadClient()
        TableLayoutPanelMain.Enabled = True
    End Sub

    Private Sub LoadMetier()
        Dim ConnexionCMD As New OleDbCommand
        Dim DTable As DataTable

        DAdapter = New OleDbDataAdapter("SELECT Emploi FROM Métier", Connexion)
        DSet = New System.Data.DataSet("Métier")

        DAdapter.Fill(DSet, "Emploi")
        DTable = DSet.Tables("Emploi")

        'On reset le ComboBox.
        ComboBoxMetier.Items.Clear()
        ComboBoxMetier.Items.Add("")
        ComboBoxMetier.SelectedIndex = 0

        DataGridView.DataSource = DSet.Tables("Emploi")
        ComboBoxMetier.DataSource = DSet.Tables("Emploi")
        ComboBoxMetier.ValueMember = "Emploi"

        'On ferme la connexion à la base de données.
        Connexion.Close()

        'On marque les métiers comme étant setup.
        MetierLoaded = True
    End Sub

    Private Sub LoadClient()
        Dim Query As String
        Dim ConnexionCMD As New OleDbCommand
        Dim Reader As OleDbDataReader

        Query = "SELECT Emploi,Sexe,Prénom,Nom FROM Clients"

        'On configure de la requête SQL.
        ConnexionCMD.Connection = Connexion
        ConnexionCMD.CommandText = Query

        'On execute la requête SQL.
        Connexion.Open()
        Reader = ConnexionCMD.ExecuteReader()

        'On reset la ListBox.
        ListBoxClient.Items.Clear()

        'On lit chaque ligne pour ajouter un élément dans la ListBox.
        Do While Reader.Read()
            'If Not Reader(0).ToLower() = ComboBoxMetier.Items(ComboBoxMetier.SelectedIndex).ToLower() And
            '   Not ComboBoxMetier.SelectedIndex = 0 Then
            '    Continue Do
            'End If

            'If Not Reader(1).ToLower() = ComboBoxSexe.Items(ComboBoxSexe.SelectedIndex).ToLower() And
            '   Not ComboBoxSexe.SelectedIndex = 0 Then
            '    Continue Do
            'End If

            ListBoxClient.Items.Add(Reader(2) & " " & Reader(3))
        Loop

        'On ferme la connexion à la base de données.
        Reader.Close()
        Connexion.Close()
    End Sub

    Private Sub ComboBoxMetier_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxMetier.SelectedIndexChanged
        If ConnexionValid And MetierLoaded Then
            LoadClient()
        End If
    End Sub

    Private Sub ComboBoxSexe_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxSexe.SelectedIndexChanged
        If ConnexionValid Then
            LoadClient()
        End If
    End Sub
End Class
