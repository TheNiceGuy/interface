Public Class Window
    Dim DB As New DataBase
    Dim Commande As Commande
    Dim CurrentArticleFilter As DataTable
    Dim CurrentHistoriqueFilter As DataTable

    Public Sub New()
        InitializeComponent()

        'On resize les colonnes.
        ArticleResize()
        HistoriqueResize()
    End Sub

    Private Sub Window_ResizeBegin(sender As Object, e As EventArgs) Handles Me.Resize
        'On update la taille des colonnes.
        ArticleResize()
        HistoriqueResize()
    End Sub

    Private Sub OuvrirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem1.Click
        Dim FileDialog As New OpenFileDialog

        'On demande à l'utilisateur de choisir la base de données.
        FileDialog.Filter = "Fichiers .accdb | *.accdb"
        FileDialog.ShowDialog()

        'On s'assure qu'il a selectionné un fichier.
        If FileDialog.FileName = vbNullString Then
            Return
        End If

        'On se connecte à la base de données.
        If DB.Connect(FileDialog.FileName) Then
            'On update les limites.
            UpdateLimitPrix()

            'On remplit les ListViews.
            ArticleFill()
            HistoriqueFill()

            'On donne le controle à l'utilisateur.
            TabControl.Enabled = True
            ArticleToolStripMenuItem.Enabled = True
        End If
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub AjouterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AjouterToolStripMenuItem.Click
        Dim Numero As Integer
        Dim Fenetre As New AjouterArticle(DB.Fournisseurs)

        'On demande à l'utilisateur d'entrer un nouveau article.
        Fenetre.ShowDialog()
        If Fenetre.NewArticle Is Nothing Then
            Return
        End If

        'On ajoute l'article à la base de données.
        Numero = DB.AddArticle(Fenetre.NewArticle)

        'On ajoute l'article à la ListView.
        ArticleAdd(Fenetre.NewArticle, Numero)

        'On update les limites.
        UpdateLimitPrix()
    End Sub

    Private Sub ListViewAffichage_DoubleClick(sender As Object, e As EventArgs) Handles ListViewAffichage.DoubleClick
        'On appel la même fonction qui s'assure l'ajout d'une commande.
        ButtonCommander_Click(sender, e)
    End Sub

    Private Sub ButtonCommander_Click(sender As Object, e As EventArgs) Handles ButtonCommander.Click
        'On s'assure que l'utilisateur a sélectionner un article.
        If ListViewAffichage.FocusedItem Is Nothing Then
            MessageBox.Show("Veuillez sélectionner votre choix.")
            ListViewAffichage.Focus()
            Return
        End If

        'On crée la commande.
        Commande = New Commande(ListViewAffichage.SelectedItems(0).SubItems(0).Text, DB.Articles)

        'On update l'onglet commande.
        CommandeUpdate()
        NumericUpDownQuantite.Value = Commande.Quantite

        'On sélectionne l'onglet de la commande.
        TabControl.SelectedIndex = 1
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        'On reset l'onglet commande.
        Commande = Nothing
        CommandeUpdate()

        'On sélectionne l'onglet de la list d'articles.
        TabControl.SelectedIndex = 0
    End Sub

    Private Sub ButtonConfirmer_Click(sender As Object, e As EventArgs) Handles ButtonConfirmer.Click
        Dim Numero As Integer

        'On ajoute la commande dans la base de données.
        Numero = DB.AddCommande(Commande)

        'On ajoute l'article à la ListView.
        HistoriqueAdd(Numero)

        'On reset l'onglet commande.
        Commande = Nothing
        CommandeUpdate()

        'On sélectionne l'onglet des historiques.
        TabControl.SelectedIndex = 2

        'On update les limites.
        UpdateLimitDate()
    End Sub

    Private Sub DateTimePickerCommande_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerCommande.ValueChanged
        'Dans l'éventualité que l'utilisateur laisse le programme ouvert pendant des jours.
        DateTimePickerCommande.MinDate = Date.Now.Date

        'On s'assure qu'une commande est en cours.
        If Commande Is Nothing Then
            Return
        End If

        'On update la date dans la commande.
        Commande.PurchasedDate = DateTimePickerCommande.Value.Date
    End Sub

    Private Sub DateTimePickerRecherche_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerRecherche.ValueChanged
        'On update la ListView si le type de recherche est activé.
        If CheckBoxRechercheDate.Checked Then
            HistoriqueFill()
        End If
    End Sub

    Private Sub NumericUpDownQuantite_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownQuantite.ValueChanged
        'On ignore si aucune commande n'est en création.
        If Commande Is Nothing Then
            Return
        End If

        'On modifie la quantité.
        Commande.Quantite = NumericUpDownQuantite.Value

        'On update l'onglet de la commande.
        CommandeUpdate()
    End Sub

    Private Sub NumericUpDownRecherchePrixMin_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownRecherchePrixMin.ValueChanged
        'On update les bornes possibles.
        NumericUpDownRecherchePrixMax.Minimum = NumericUpDownRecherchePrixMin.Value
        NumericUpDownRecherchePrixMin.Maximum = NumericUpDownRecherchePrixMax.Value

        'On update la ListView si le type de recherche est activé.
        If CheckBoxRecherchePrix.Checked Then
            ArticleFill()
        End If
    End Sub

    Private Sub NumericUpDownRecherchePrixMax_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDownRecherchePrixMax.ValueChanged
        'On update les bornes possibles.
        NumericUpDownRecherchePrixMin.Maximum = NumericUpDownRecherchePrixMax.Value
        NumericUpDownRecherchePrixMax.Minimum = NumericUpDownRecherchePrixMin.Value

        'On update la ListView si le type de recherche est activé.
        If CheckBoxRecherchePrix.Checked Then
            ArticleFill()
        End If
    End Sub

    Private Sub TextBoxRechercheFournisseur_TextChanged(sender As Object, e As EventArgs) Handles TextBoxRechercheFournisseur.TextChanged
        'On update la ListView si le type de recherche est activé.
        If CheckBoxRechercheFournisseur.Checked Then
            ArticleFill()
        End If
    End Sub

    Private Sub CheckBoxRecherchePrix_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRecherchePrix.CheckedChanged
        'On active/désactive les controles.
        If CheckBoxRecherchePrix.Checked Then
            NumericUpDownRecherchePrixMin.Enabled = True
            NumericUpDownRecherchePrixMax.Enabled = True
        Else
            NumericUpDownRecherchePrixMin.Enabled = False
            NumericUpDownRecherchePrixMax.Enabled = False
        End If

        'On update les limites.
        UpdateLimitPrix()

        'On update la ListView.
        ArticleFill()
    End Sub

    Private Sub CheckBoxRechercheFournisseur_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRechercheFournisseur.CheckedChanged
        'On active/désactive le controle.
        If CheckBoxRechercheFournisseur.Checked Then
            TextBoxRechercheFournisseur.Enabled = True
        Else
            TextBoxRechercheFournisseur.Enabled = False
        End If

        'On update la ListView.
        ArticleFill()
    End Sub

    Private Sub CheckBoxRechercheDate_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxRechercheDate.CheckedChanged
        'On active/désactive les controles.
        If CheckBoxRechercheDate.Checked Then
            DateTimePickerRecherche.Enabled = True
        Else
            DateTimePickerRecherche.Enabled = False
        End If

        'On update les limites.
        UpdateLimitDate()

        'On update la ListView.
        HistoriqueFill()
    End Sub

    Private Sub UpdateLimitPrix()
        Dim Min As Double
        Dim Max As Double = 0.00

        'On s'assure que la base de données utilisable.
        If DB.Articles Is Nothing Then
            Return
        End If

        'On trouve le prix le plus élevé.
        For Each Row In DB.Articles.Rows
            If Row.Item(2) > Max Then
                Max = Row.Item(2)
            End If
        Next
        Min = Max

        'On trouve le prix le plus petit.
        For Each Row In DB.Articles.Rows
            If Row.Item(2) < Min Then
                Min = Row.Item(2)
            End If
        Next

        'On update les bornes possibles.
        NumericUpDownRecherchePrixMin.Maximum = Max
        NumericUpDownRecherchePrixMax.Minimum = Min

        'On affecte les valeurs par défauts.
        NumericUpDownRecherchePrixMin.Value = Min
        NumericUpDownRecherchePrixMax.Value = Max
    End Sub

    Private Sub UpdateLimitDate()
        Dim Min As New Date
        Dim Max As New Date

        'On s'assure que la base de données utilisable.
        If DB.Articles Is Nothing Then
            Return
        End If

        'On trouve le prix le plus élevé
        For Each Row In DB.Commandes.Rows
            If Row.Item(1) > Max Then
                Max = Row.Item(1)
            End If
        Next

        'On trouve le prix le plus élevé
        Min = Max
        For Each Row In DB.Commandes.Rows
            If Row.Item(1) < Min Then
                Min = Row.Item(1)
            End If
        Next

        'On update les bornes possibles.
        DateTimePickerRecherche.MinDate = Min
        DateTimePickerRecherche.MaxDate = Max
    End Sub

    Private Sub ArticleFill()
        Dim NewRow As ListViewItem
        Dim Filter As DataTable
        Dim FilterRow As DataRow()

        'On ignore si la base de données n'est pas encore remplit.
        If DB.Articles Is Nothing Then
            Return
        End If

        'On applique le filtre de fournisseur.
        If (TextBoxRechercheFournisseur.Text & vbNullString).Trim() = vbNullString Or
        Not CheckBoxRechercheFournisseur.Checked Then
            Filter = DB.Articles
        Else
            FilterRow = DB.Articles.Select("Fournisseur LIKE '%" + TextBoxRechercheFournisseur.Text + "%'")

            'On s'assure que le filtre a retourné au moins un résultat.
            If Not FilterRow.Count = 0 Then
                Filter = FilterRow.CopyToDataTable()
            Else
                CurrentArticleFilter = Nothing
                ListViewAffichage.Items.Clear()
                Return
            End If
        End If

        'On applique le filtre de prix.
        If CheckBoxRecherchePrix.Checked Then
            FilterRow = Filter.Select("Prix >= " & NumericUpDownRecherchePrixMin.Value.ToString().Replace(",", ".") & " AND " &
                                      "Prix <= " & NumericUpDownRecherchePrixMax.Value.ToString().Replace(",", "."),
                                      "Numero ASC")

            'On s'assure que le filtre a retourné au moins un résultat.
            If Not FilterRow.Count = 0 Then
                Filter = FilterRow.CopyToDataTable()
            Else
                CurrentArticleFilter = Nothing
                ListViewAffichage.Items.Clear()
                Return
            End If
        End If

        'On vérifie si la ListView doit être actualisée.
        If Not CurrentArticleFilter Is Nothing Then
            'On s'assure que le nombre de colonnes est identique.
            If Not Filter.Rows.Count = CurrentArticleFilter.Rows.Count Then
                GoTo CHANGE_DETECTED
            End If

            'On s'assure que tous les éléments dans le tableau est identique.
            For i As Integer = 0 To Filter.Rows.Count - 1
                For j As Integer = 0 To Filter.Rows(i).ItemArray.Count - 1
                    If Not Filter.Rows(i).Item(j) = CurrentArticleFilter.Rows(i).Item(j) Then
                        GoTo CHANGE_DETECTED
                    End If
                Next
            Next

            'On quitte, car le tableau n'a pas changé.
            Return
        End If
CHANGE_DETECTED:

        'On actualise le filtre courant.
        CurrentArticleFilter = Filter

        'On reset la ListView.
        ListViewAffichage.Items.Clear()

        'On ajoute un article à la fois dans la ListView.
        For Each Row In Filter.Rows
            'On crée une nouvelle ligne.
            NewRow = New ListViewItem(New String() {
                                   Row.Item(0),
                                   Row.Item(1),
                                   Format(Row.Item(2), "0.00") & " $",
                                   Row.Item(3),
                                   Row.Item(4)})

            'On ajoute la ligne dans le ListView.
            ListViewAffichage.Items.Add(NewRow)
        Next

        'On resize la ListView.
        ArticleResize()
    End Sub

    Public Sub ArticleResize()
        'On resize chaque colonne.
        For Each Column In ListViewAffichage.Columns
            Column.Width = -2
        Next
    End Sub

    Private Sub ArticleAdd(ByRef NewArticle As Article, ByVal Numero As Integer)
        Dim Row As ListViewItem

        'On crée une nouvelle ligne.
        Row = New ListViewItem(New String() {
                               Numero,
                               NewArticle.Nom,
                               NewArticle.Prix,
                               NewArticle.Quantite,
                               NewArticle.Fournisseur})

        'On ajoute la ligne dans le ListView.
        ListViewAffichage.Items.Add(Row)

        'On resize la ListView.
        ArticleResize()
    End Sub

    Private Sub HistoriqueFill()
        Dim NewRow As ListViewItem
        Dim Filter As DataTable
        Dim FilterRow As DataRow()

        'On ignore si la base de données n'est pas encore remplit.
        If DB.Commandes Is Nothing Then
            Return
        End If

        'On applique le filtre de date.
        If CheckBoxRechercheDate.Checked Then
            FilterRow = DB.Commandes.Select("DateCommande = '" & DateTimePickerRecherche.Value.Date & "'",
                                            "idCommande ASC")

            'On s'assure que le filtre a retourné au moins un résultat.
            If Not FilterRow.Count = 0 Then
                Filter = FilterRow.CopyToDataTable()
            Else
                CurrentHistoriqueFilter = Nothing
                ListViewHistorique.Items.Clear()
                Return
            End If
        Else
            Filter = DB.Commandes
        End If

        'On vérifie si la ListView doit être actualisée.
        If Not CurrentHistoriqueFilter Is Nothing Then
            'On s'assure que le nombre de colonnes est identique.
            If Not Filter.Rows.Count = CurrentHistoriqueFilter.Rows.Count Then
                GoTo CHANGE_DETECTED
            End If

            'On s'assure que tous les éléments dans le tableau est identique.
            For i As Integer = 0 To Filter.Rows.Count - 1
                For j As Integer = 0 To Filter.Rows(i).ItemArray.Count - 1
                    If Not Filter.Rows(i).Item(j) = CurrentHistoriqueFilter.Rows(i).Item(j) Then
                        GoTo CHANGE_DETECTED
                    End If
                Next
            Next

            'On quitte, car le tableau n'a pas changé.
            Return
        End If
CHANGE_DETECTED:

        'On actualise le filtre courant.
        CurrentHistoriqueFilter = Filter

        'On reset la ListView.
        ListViewHistorique.Items.Clear()

        'On ajoute une commande à la fois dans la ListView.
        For Each Row In Filter.Rows
            'On crée une nouvelle ligne.
            NewRow = New ListViewItem(New String() {
                                   Row.Item(0),
                                   Row.Item(1),
                                   Row.Item(2),
                                   Row.Item(3),
                                   Row.Item(4),
                                   Format(Row.Item(5), "0.00") & " $",
                                   Format(Row.Item(6), "0.00") & " $"})

            'On ajoute la ligne dans le ListView.
            ListViewHistorique.Items.Add(NewRow)
        Next

        'On resize la ListView.
        HistoriqueResize()
    End Sub

    Public Sub HistoriqueResize()
        'On resize chaque colonne.
        For Each Column In ListViewHistorique.Columns
            Column.Width = -2
        Next
    End Sub

    Private Sub HistoriqueAdd(ByVal Numero As Integer)
        Dim Row As ListViewItem

        'On crée une nouvelle ligne.
        Row = New ListViewItem(New String() {
                               Numero,
                               Commande.PurchasedDate,
                               Commande.Article,
                               Commande.Fournisseur,
                               Commande.Quantite,
                               Format(Commande.PrixUnitaire, "0.00") & " $",
                               Format(Commande.PrixTotal, "0.00") & " $"})

        'On ajoute la ligne dans le ListView.
        ListViewHistorique.Items.Add(Row)

        'On resize la ListView.
        HistoriqueResize()
    End Sub

    Public Sub CommandeUpdate()
        If Commande Is Nothing Then
            'On reset chaque control.
            LabelNomModif.Text = vbNullString
            LabelFournisseurModif.Text = vbNullString
            LabelPrixUnitaireModif.Text = vbNullString
            LabelPrixTotalModif.Text = vbNullString
            DateTimePickerCommande.Value = Date.Now.Date
            NumericUpDownQuantite.Value = 1

            'On désactive l'onglet de la commande.
            TableLayoutPanelCommande.Enabled = False
        Else
            'On update chaque control.
            LabelNomModif.Text = Commande.Nom
            LabelFournisseurModif.Text = Commande.Fournisseur
            LabelPrixUnitaireModif.Text = Format(Commande.PrixUnitaire, "0.00") & " $"
            LabelPrixTotalModif.Text = Format(Commande.PrixTotal, "0.00") & " $"
            DateTimePickerCommande.Value = Commande.PurchasedDate
            NumericUpDownQuantite.Value = Commande.Quantite

            'On active l'onglet de la commande.
            TableLayoutPanelCommande.Enabled = True
        End If
    End Sub
End Class