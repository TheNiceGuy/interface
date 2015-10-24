Imports System.Data.OleDb

Public Class Window
    Dim Connection As OleDbConnection
    Dim ConnectionCMD As New OleDbCommand
    Dim ConnectionString As String

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim FileDialog As New OpenFileDialog

        'On demande à l'utilisateur de choisir un fichier.
        FileDialog.ShowDialog()
        If FileDialog.FileName = vbNullString Then
            Return
        End If

        'On configure la connection à la base de données.
        ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & FileDialog.FileName
        Connection = New OleDbConnection(ConnectionString)

        'On vérifie la connection à la base de données.
        Try
            Connection.Open()
            Connection.Close()
        Catch ex As System.Data.OleDb.OleDbException
            Return
        End Try

        'On télécharge la base de données.
        LoadDatabase()
        TableLayoutPanelMain.Enabled = True
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoadDatabase()
        Dim Query As String
        Dim Reader As OleDbDataReader

        Query = "SELECT ID,Prénom,Nom FROM Membres"

        'On configure de la requête SQL.
        ConnectionCMD.Connection = Connection
        ConnectionCMD.CommandText = Query

        'On execute la requête SQL.
        Connection.Open()
        Reader = ConnectionCMD.ExecuteReader()

        'On lit chaque ligne pour ajouter un élément dans la ListBox.
        Do While Reader.Read()
            ListBoxAfficher.Items.Add(Reader(0) & " " & Reader(1) & " " & Reader(2))
        Loop

        'On ferme la connection à la base de données.
        Reader.Close()
        Connection.Close()
    End Sub

    Private Sub ButtonInsert_Click(sender As Object, e As EventArgs) Handles ButtonInsert.Click
        Dim I, N, P, D, A As String
        Dim QueryAdd, QueryGet As String
        Dim Reader As OleDbDataReader

        'On s'assure que les champs requis sont valides.
        If Not CheckUp() Then
            Return
        End If

        N = TextBoxNom.Text
        P = TextBoxPrenom.Text
        D = DateTimePickerInscription.Value
        A = NumericUpDownAge.Value
        QueryAdd = "INSERT INTO Membres(Nom, Prénom, Inscription, Age) " &
                   "VALUES('" & N & "', '" & P & "', #" & D & "#, " & A & ")"
        QueryGet = "SELECT LAST(ID) FROM Membres"

        'On configure la première requête SQL qui ajoute le membre.
        ConnectionCMD.Connection = Connection
        ConnectionCMD.CommandText = QueryAdd

        'On execute la première requête SQL.
        Connection.Open()
        ConnectionCMD.ExecuteNonQuery()

        'On configure la deuxième requête SQL qui obtient l'ID du nouveau membre.
        ConnectionCMD.CommandText = QueryGet

        'On execute la deuxième requête SQL.
        Reader = ConnectionCMD.ExecuteReader()
        Reader.Read()
        I = Reader(0)

        'On ferme la connection à la base de données.
        Reader.Close()
        Connection.Close()

        'On ajoute l'élément dans la ListBox.
        ListBoxAfficher.Items.Add(I & " " & P & " " & N)
    End Sub

    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click
        Dim I, N, P, D, A As String
        Dim Query As String

        'On s'assure que les champs requis sont valides.
        If Not CheckUp() Then
            Return
        End If

        N = TextBoxNom.Text
        P = TextBoxPrenom.Text
        A = NumericUpDownAge.Value
        D = DateTimePickerInscription.Value
        I = ListBoxAfficher.SelectedItem.ToString.Split(" ")(0)
        Query = "UPDATE Membres Set Nom='" & N & "', Prénom='" & P & "', Inscription=#" & D & "#, " &
                "Age=" & A & " WHERE ID=" & I

        'On configure de la requête SQL.
        ConnectionCMD.Connection = Connection
        ConnectionCMD.CommandText = Query

        'On execute la requête SQL.
        Connection.Open()
        ConnectionCMD.ExecuteNonQuery()
        Connection.Close()

        'On actualise l'élément dans la ListBox.
        ListBoxAfficher.Items(ListBoxAfficher.SelectedIndex) = I & " " & P & " " & N
    End Sub

    Private Sub ButtonDelete_Click(sender As Object, e As EventArgs) Handles ButtonDelete.Click
        Dim I As String
        Dim Query As String

        I = ListBoxAfficher.SelectedItem.ToString.Split(" ")(0)
        Query = "DELETE FROM Membres WHERE ID=" & I

        'On configure de la requête SQL.
        ConnectionCMD.Connection = Connection
        ConnectionCMD.CommandText = Query

        'On execute la requête SQL.
        Connection.Open()
        ConnectionCMD.ExecuteNonQuery()
        Connection.Close()

        'On supprime l'élément de la ListBox.
        ListBoxAfficher.Items.RemoveAt(ListBoxAfficher.SelectedIndex)

        'On reset les champs reliés à la sélection.
        TextBoxNom.Clear()
        TextBoxPrenom.Clear()
        DateTimePickerInscription.ResetText()
        NumericUpDownAge.ResetText()

        'On désactive les boutons.
        ButtonUpdate.Enabled = False
        ButtonDelete.Enabled = False
    End Sub

    Private Sub ListBoxAfficher_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxAfficher.SelectedIndexChanged
        Dim I As String
        Dim Query As String
        Dim Reader As OleDbDataReader

        'On quitte la fonction si rien devient sélectionner.
        'Cela ce produit lorsqu'un élément de la ListBox est modifié.
        If ListBoxAfficher.SelectedIndex = -1 Then
            Return
        End If

        I = ListBoxAfficher.SelectedItem.ToString.Split(" ")(0)
        Query = "SELECT Nom,Prénom,Inscription,Age FROM Membres WHERE ID=" & I

        'On configure de la requête SQL.
        ConnectionCMD.Connection = Connection
        ConnectionCMD.CommandText = Query

        'On execute la requête SQL.
        Connection.Open()
        Reader = ConnectionCMD.ExecuteReader()
        Reader.Read()

        'On actualise les champs reliés à la sélection.
        TextBoxNom.Text = Reader(0)
        TextBoxPrenom.Text = Reader(1)
        DateTimePickerInscription.Value = Reader(2)
        NumericUpDownAge.Value = Reader(3)

        'On ferme la connection à la base de données.
        Reader.Close()
        Connection.Close()

        'On active les boutons.
        ButtonUpdate.Enabled = True
        ButtonDelete.Enabled = True
    End Sub

    Private Function CheckUp() As Boolean
        If (TextBoxNom.Text & vbNullString).Trim() = vbNullString Then
            Return False
        End If

        If (TextBoxPrenom.Text & vbNullString).Trim() = vbNullString Then
            Return False
        End If

        Return True
    End Function
End Class
