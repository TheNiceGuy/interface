Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str() As String
        Dim sep(2) As Char

        sep(0) = "."
        sep(1) = ","
        sep(2) = " "

        str = TextBox1.Text.Split(sep, StringSplitOptions.RemoveEmptyEntries)

        For index As Integer = 0 To str.Length - 1
            ListBox1.Items.Add(str(index))
        Next

        If TextBox1.Text.Contains("kek") Then
            MessageBox.Show("forty kek")
        End If
    End Sub
End Class
