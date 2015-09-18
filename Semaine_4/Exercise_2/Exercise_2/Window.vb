Imports System.IO

Public Class Window
    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        If Trim(TextBox.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer une chaîne à ajouter.")
            TextBox.Clear()
            TextBox.Focus()
            Return
        End If

        ListBox.Items.Add(TextBox.Text)
        TextBox.Clear()
        TextBox.Focus()
    End Sub

    Private Sub ListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox.SelectedIndexChanged
        ButtonSupprimer.Enabled = True
    End Sub

    Private Sub ButtonSupprimer_Click(sender As Object, e As EventArgs) Handles ButtonSupprimer.Click
        ListBox.Items.RemoveAt(ListBox.SelectedIndex)
        ButtonSupprimer.Enabled = False
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        Dim Text() As String
        Dim FileName As String
        Dim FileDialog As New OpenFileDialog

        FileDialog.ShowDialog()
        If Not FileDialog.FileName = vbNullString Then
            FileName = FileDialog.FileName
        Else
            Return
        End If

        Text = File.ReadAllLines(FileName)
        ListBox.Items.Clear()
        For Index As Integer = 0 To Text.Length - 1
            ListBox.Items.Add(Text(Index))
        Next
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim FileName As String
        Dim FileIO As StreamWriter
        Dim FileDialog As New SaveFileDialog

        FileDialog.ShowDialog()
        If Not FileDialog.FileName = vbNullString Then
            FileName = FileDialog.FileName
        Else
            Return
        End If


        FileIO = New StreamWriter(FileName)
        For Index As Integer = 0 To ListBox.Items.Count - 1
            FileIO.WriteLine(ListBox.Items(Index))
        Next

        FileIO.Close()
    End Sub

    Private Sub QuitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
