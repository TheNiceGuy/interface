Imports System.IO

Public Class Window
    Dim ClientelIndex As Integer = 0
    Dim Clientel As New ArrayList

    Private Sub ShowIndex()
        If ClientelIndex = 0 Then
            ButtonPrecedent.Enabled = False
        Else
            ButtonPrecedent.Enabled = True
        End If

        If ClientelIndex = Clientel.Count - 1 Then
            ButtonSuivant.Enabled = False
        Else
            ButtonSuivant.Enabled = True
        End If

        TextBoxPrenom.Text = Clientel(ClientelIndex).Prenom
        TextBoxNom.Text = Clientel(ClientelIndex).Nom
        TextBoxCourriel.Text = Clientel(ClientelIndex).Courriel
    End Sub

    Private Sub SauvegarderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SauvegarderToolStripMenuItem.Click
        Dim FileString() As String
        Dim FileDialog As New OpenFileDialog
        Dim ClientRead As Client

        FileDialog.ShowDialog()
        If Not FileDialog.FileName = vbNullString Then
            FileString = File.ReadAllLines(FileDialog.FileName)
        Else
            Return
        End If

        If Not FileString.Length Mod 3 = 0 Then
            MessageBox.Show("Le fichier est corrompu ou mal formatté.")
            Return
        End If

        For Index As Integer = 0 To FileString.Length - 1 Step 3
            ClientRead = New Client(FileString(Index + 0),
                                    FileString(Index + 1),
                                    FileString(Index + 2))
            Clientel.Add(ClientRead)
        Next

        ClientelIndex = 0
        ShowIndex()
    End Sub

    Private Sub ButtonPrecedent_Click(sender As Object, e As EventArgs) Handles ButtonPrecedent.Click
        If ClientelIndex > 0 Then
            ClientelIndex -= 1
            ShowIndex()
        Else
            Return
        End If
    End Sub

    Private Sub ButtonSuivant_Click(sender As Object, e As EventArgs) Handles ButtonSuivant.Click
        If ClientelIndex < Clientel.Count Then
            ClientelIndex += 1
            ShowIndex()
        Else
            Return
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
