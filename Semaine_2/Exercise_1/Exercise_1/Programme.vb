Public Class Programme
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        Dim f As New Formulaire()

        Me.Hide()
        f.ShowDialog()
        Me.Show()

        If Not f.personne Is Nothing Then
            MsgBox(f.personne.nom & ", " & f.personne.age & " ans, a été rajouter.")
        End If
    End Sub
End Class
