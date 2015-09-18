Imports System.IO

Public Class Window
    Dim Clientel As New ArrayList

    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        Dim Prenom, Nom, Courriel As String
        Dim Client As Client

        Prenom = Trim(TextBoxPrenom.Text & vbNullString)
        If Prenom = vbNullString Then
            MessageBox.Show("Veuillez entrer un prénom.")
            TextBoxPrenom.Clear()
            TextBoxPrenom.Focus()
            Return
        End If

        Nom = Trim(TextBoxNom.Text & vbNullString)
        If Nom = vbNullString Then
            MessageBox.Show("Veuillez entrer un nom.")
            TextBoxNom.Clear()
            TextBoxNom.Focus()
            Return
        End If

        Courriel = Trim(TextBoxCourriel.Text & vbNullString)
        If Courriel = vbNullString Then
            MessageBox.Show("Veuillez entrer un courriel.")
            TextBoxCourriel.Clear()
            TextBoxCourriel.Focus()
            Return
        End If

        Client = New Client(Prenom, Nom, Courriel)
        Clientel.Add(Client)

        TextBoxPrenom.Clear()
        TextBoxNom.Clear()
        TextBoxCourriel.Clear()

        TextBoxPrenom.Focus()
    End Sub

    Private Sub SauvegarderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SauvegarderToolStripMenuItem.Click
        Dim FileIO As StreamWriter
        Dim FileDialog As New SaveFileDialog

        FileDialog.ShowDialog()
        If Not FileDialog.FileName = vbNullString Then
            FileIO = New StreamWriter(FileDialog.FileName)
        Else
            Return
        End If

        For Index As Integer = 0 To Clientel.Count - 1
            FileIO.WriteLine(Clientel(Index).Prenom)
            FileIO.WriteLine(Clientel(Index).Nom)
            FileIO.WriteLine(Clientel(Index).Courriel)
        Next

        FileIO.Close()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
