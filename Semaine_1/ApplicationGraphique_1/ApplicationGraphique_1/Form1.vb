Public Class Form1
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = CheckBox1.Checked
        Label2.Text = CheckBox2.Checked
        Label3.Text = CheckBox3.Checked

        If MessageBox.Show("Vous allez mourir.", "Attention!", MessageBoxButtons.YesNoCancel) = DialogResult.No Then
            MessageBox.Show("Ah, cool.")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Label4.Text = "Check en ostie"
        Else
            Label4.Text = "Nope"
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            Label5.Text = "Check en ostie"
        Else
            Label5.Text = "Nope"
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            Label6.Text = "Check en ostie"
        Else
            Label6.Text = "Nope"
        End If
    End Sub
End Class
