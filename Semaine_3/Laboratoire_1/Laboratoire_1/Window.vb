Public Class Window
    Private Const MAX = 9

    Dim MInventaireIndex As Integer = 0
    Dim MInventaire(MAX) As Produit

    Private Sub ButtonNAjouter_Click(sender As Object, e As EventArgs) Handles ButtonNAjouter.Click
        'vérifier si l'inventaire est plein
        If MInventaireIndex = MAX + 1 Then
            ClearNouveau()
            MessageBox.Show("L'inventaire est plein.")
            Return
        End If

        'vérifier si un nom est entré
        If Trim(TextBoxNNom.Text & vbNullString) = vbNullString Then
            TextBoxNNom.Clear()
            MessageBox.Show("Veuillez entrer un nom au produit.")
            Return
        End If

        'vérifier si une catégorie est choisie
        If ComboBoxNCategorie.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir une catégorie au produit.")
            Return
        End If

        'vérifier si la quantité est entré et valide
        If Not IsNumeric(Trim(TextBoxNQuantite.Text)) Then
            TextBoxNQuantite.Clear()
            MsgBox("Veuillez entrer une quantité numérique au produit.")
            Return
        End If

        'vérifier si la quantité est positive
        If TextBoxNQuantite.Text < 0 Then
            TextBoxNQuantite.Clear()
            MsgBox("Veuillez entrer une quantité positive.")
            Return
        End If

        'on rajoute le produit dans l'inventaire et on augmente l'index
        MInventaire(MInventaireIndex) = New Produit(TextBoxNNom.Text,
                                                    ComboBoxNCategorie.SelectedIndex,
                                                    TextBoxNQuantite.Text)
        MInventaireIndex += 1

        'préparer le formulaire pour entrer un nouveau produit
        ClearNouveau()
        TextBoxNNom.Focus()
    End Sub

    Private Sub ButtonAAfficher_Click(sender As Object, e As EventArgs) Handles ButtonAAfficher.Click
        TextBoxProduit.Clear()

        'vérifier s'il y a quelque chose dans l'inventaire
        If MInventaireIndex = 0 Then
            MessageBox.Show("Aucun élément fut trouvé dans la catégorie.")
            Return
        End If

        'on boucle dans les produits pour trouver ceux qui sont dans la catégorie choisie pour ensuite 
        'les intégrer dans la textbox
        For index As Integer = 0 To MInventaireIndex - 1
            If MInventaire(index).Categorie = ComboBoxACategorie.SelectedIndex Then
                TextBoxProduit.AppendText(MInventaire(index).Nom & vbTab &
                                          MInventaire(index).Quantite & vbNewLine)
            End If
        Next

        'vérifier si un produit fut trouvé dans la catégorie
        'si la textbox est vide, il y a nécessairement aucun produit de trouvé
        If Trim(TextBoxProduit.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Aucun élément fut trouvé dans la catégorie.")
            Return
        End If
    End Sub

    Private Sub ButtonRRechercher_Click(sender As Object, e As EventArgs) Handles ButtonRRechercher.Click
        'vérifier si un nom est entré
        If Trim(TextBoxRElement.Text & vbNullString) = vbNullString Then
            ClearRechercher()
            MessageBox.Show("Veuillez entrer un élément à rechercher.")
            Return
        End If

        'vérifier s'il y a quelque chose dans l'inventaire
        If MInventaireIndex = 0 Then
            MessageBox.Show("Il n'y a aucun produit dans l'inventaire.")
            Return
        End If

        'on boucle dans l'inventaire pour trouver le premier produit répondant au critère de recherche
        For index As Integer = 0 To MInventaireIndex - 1
            If MInventaire(index).Nom = Trim(TextBoxRElement.Text & vbNullString) Then
                Select Case MInventaire(index).Categorie
                    Case 0
                        TextBoxRCategorie.Text = "Alimentaire"
                    Case 1
                        TextBoxRCategorie.Text = "Informatique"
                    Case 2
                        TextBoxRCategorie.Text = "Sport"
                    Case 3
                        TextBoxRCategorie.Text = "Meuble"
                End Select

                TextBoxRQuantite.Text = MInventaire(index).Quantite

                Return
            End If
        Next

        'si rien n'a été trouvé, on affiche un message d'erreur
        MessageBox.Show("Aucun élément fut trouvé.")
        ClearRechercher()
    End Sub

    Private Sub ClearNouveau()
        TextBoxNNom.Clear()
        ComboBoxNCategorie.SelectedIndex = -1
        TextBoxNQuantite.Clear()
    End Sub

    Private Sub ClearRechercher()
        TextBoxRElement.Clear()
        TextBoxRCategorie.Clear()
        TextBoxRQuantite.Clear()
    End Sub

    Private Sub ComboBoxACategorie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxACategorie.SelectedIndexChanged
        ButtonAAfficher.Enabled = True
    End Sub

    Private Sub ButtonQuitter_Click(sender As Object, e As EventArgs) Handles ButtonQuitter.Click
        Close()
    End Sub
End Class
