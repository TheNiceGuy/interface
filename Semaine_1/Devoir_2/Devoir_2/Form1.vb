Public Class Window
    Private Sub Ajouter_Click(sender As Object, e As EventArgs) Handles Ajouter.Click
        If Trim(Produit.Text & vbNullString) = vbNullString Then
            MsgBox("Veuillez entrer un nom de produit.")
            Return
        End If

        Select Case Categorie.SelectedIndex
            Case -1
                MsgBox("Veuillez choisir une catégorie.")
                Return
            Case 0
                CategorieElectronique.Items.Add(Produit.Text)
            Case 1
                CategorieInformatique.Items.Add(Produit.Text)
            Case 2
                CategorieJeux.Items.Add(Produit.Text)
        End Select
    End Sub
End Class
