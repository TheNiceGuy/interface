Imports System.IO

Public Class Form1
    Private Sub ButtonChercher_Click(sender As Object, e As EventArgs) Handles ButtonChercher.Click
        If Trim(TextBoxChercher.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer une chaîne à chercher.")
            TextBoxChercher.Clear()
            TextBoxChercher.Focus()
            Return
        End If

        If TextBoxMultiline.Text.Contains(TextBoxChercher.Text) Then
            TextBoxMultiline.SelectionStart = TextBoxMultiline.Text.IndexOf(TextBoxChercher.Text)
            TextBoxMultiline.SelectionLength = TextBoxChercher.Text.Length
            TextBoxMultiline.Select()
        End If
    End Sub

    Private Sub ButtonRemplacer_Click(sender As Object, e As EventArgs) Handles ButtonRemplacer.Click
        Dim index, length As Integer

        If Trim(TextBoxRemplacer.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer une chaîne à chercher.")
            TextBoxRemplacer.Clear()
            TextBoxRemplacer.Focus()
            Return
        End If

        If Trim(TextBoxRemplacerPar.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer une chaîne à remplacer.")
            TextBoxRemplacerPar.Clear()
            TextBoxRemplacerPar.Focus()
            Return
        End If

        Do While TextBoxMultiline.Text.Contains(TextBoxRemplacer.Text)
            index = TextBoxMultiline.Text.IndexOf(TextBoxRemplacer.Text)
            length = TextBoxRemplacer.Text.Length

            TextBoxMultiline.Text = TextBoxMultiline.Text.Remove(index, length).Insert(index, TextBoxRemplacerPar.Text)
        Loop
    End Sub

    Private Sub ButtonCompter_Click(sender As Object, e As EventArgs) Handles ButtonCompter.Click
        Dim text As String
        Dim count As Integer = 0

        If Trim(TextBoxCompter.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer une chaîne à chercher.")
            TextBoxCompter.Clear()
            TextBoxCompter.Focus()
            Return
        End If

        text = TextBoxMultiline.Text

        Do While text.Contains(TextBoxCompter.Text)
            text = text.Remove(text.IndexOf(TextBoxCompter.Text), TextBoxCompter.Text.Length)
            count += 1
        Loop

        MessageBox.Show("Il y a " & count & " " & "'" & TextBoxCompter.Text & "'")
    End Sub

    Private Sub ButtonPlusLong_Click(sender As Object, e As EventArgs) Handles ButtonPlusLong.Click
        Dim longest As String = ""
        Dim words() As String
        Dim ifs(2) As Char

        ifs(0) = "."
        ifs(1) = ","
        ifs(2) = " "

        words = TextBoxMultiline.Text.Split(ifs, StringSplitOptions.RemoveEmptyEntries)

        For index As Integer = 0 To words.Length - 1
            If words(index).Length > longest.Length Then
                longest = words(index)
            End If
        Next

        MessageBox.Show("Le mot le plus long est " & "'" & longest & "'" & ".")
    End Sub

    Private Sub ButtonTaille_Click(sender As Object, e As EventArgs) Handles ButtonTaille.Click
        MessageBox.Show("La taille de la chaîne de texte est de " & TextBoxMultiline.Text.Length &
                        " caractères.")
    End Sub

    Private Sub ButtonMajuscule_Click(sender As Object, e As EventArgs) Handles ButtonMajuscule.Click
        Dim lettre As Char
        Dim phrases(), ifs(0) As String
        Dim fichier As New StreamWriter("kek.txt")

        ifs(0) = "."

        phrases = TextBoxMultiline.Text.Split(ifs, StringSplitOptions.RemoveEmptyEntries)

        TextBoxMultiline.Clear()
        For index As Integer = 0 To phrases.Length - 1
            phrases(index) = phrases(index).Trim()
            lettre = phrases(index).Chars(0)
            lettre = lettre.ToString().ToUpper()

            phrases(index) = phrases(index).Remove(0, 1).Insert(0, lettre)
            TextBoxMultiline.Text += phrases(index) & ". "
            fichier.WriteLine(phrases(index) & ".")
        Next

        fichier.Close()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim filedialog As New OpenFileDialog
        Dim file As StreamReader

        filedialog.ShowDialog()
        file = New StreamReader(filedialog.FileName)

        TextBoxMultiline.Text = file.ReadToEnd()
    End Sub
End Class
