Imports System.IO

Public Class Window
    Dim Inventaire As New Inventaire
    Dim Panier As New Panier
    Dim ListViewAfficherIndex As New Dictionary(Of Integer, Integer)

    Public Sub LogDebug(ByVal Message As String)
        ListBoxLog.Items.Add(Message)
    End Sub

    Private Sub LoadAffichageCategorie()
        'On enlève les catégories précédentes de la ComboBox.'
        ComboBoxAfficherCategorie.Items.Clear()

        'L'index 0 de la ComboBox ne filtre pas les catégories.'
        ComboBoxAfficherCategorie.Items.Add("toutes les catégories")

        'On rajoute dans la ComboBox toute les catégories possibles de l'inventaire.'
        For Index As Integer = 0 To Inventaire.Categorie.Count - 1
            ComboBoxAfficherCategorie.Items.Add(Inventaire.Categorie(Index))
        Next

        'Par defaut, on n'applique aucun filtre à la ListView.'
        ComboBoxAfficherCategorie.SelectedIndex = 0
    End Sub

    Private Sub LoadAfficherList()
        Dim Ligne As ListViewItem
        Dim Nom, Prix, Categorie, Quantite As String

        'On enlève les items précédents de la ListView.'
        ListViewAfficher.Items.Clear()
        ListViewAfficherIndex.Clear()

        'On boucle dans l'inventaire afin de rajouter une ligne pour chaque article dans la ListView.'
        For Each Numero In Inventaire.Items.Keys()
            Nom = Inventaire.Items(Numero).Nom
            Prix = Inventaire.Items(Numero).Prix.ToString("F2") & " $"
            Categorie = Inventaire.Items(Numero).Categorie

            'Si il y a au moins une unité de cette article dans le panier, la quantité'
            'disponible (en parenthèse).'
            Try
                Quantite = Inventaire.Items(Numero).Quantite &
                           " (" & (Inventaire.Items(Numero).Quantite - Panier.Items(Numero)) & ")"
            Catch ex As System.Collections.Generic.KeyNotFoundException
                Quantite = Inventaire.Items(Numero).Quantite &
                           " (" & (Inventaire.Items(Numero).Quantite) & ")"
            End Try

            'On crée la ligne et on l'insère dans la ListView.'
            Ligne = New ListViewItem(New String() {Numero, Nom, Prix, Categorie, Quantite})
            ListViewAfficher.Items.Add(Ligne)
            ListViewAfficherIndex.Add(Numero, ListViewAfficher.Items.Count - 1)
        Next
    End Sub

    Private Sub LoadAfficherList(ByVal CategorieFilter As String)
        Dim Ligne As ListViewItem
        Dim Nom, Prix, Categorie, Quantite As String

        'On enlève les items précédents de la ListView.'
        ListViewAfficher.Items.Clear()
        ListViewAfficherIndex.Clear()

        'On boucle dans l'inventaire afin de rajouter une ligne pour chaque article dans la ListView.'
        For Each Numero In Inventaire.Items.Keys()
            'On s'assure que l'article est dans la catégorie désirée.'
            If Inventaire.Items(Numero).Categorie = CategorieFilter Then
                Nom = Inventaire.Items(Numero).Nom
                Prix = Inventaire.Items(Numero).Prix.ToString("F2") & " $"
                Categorie = Inventaire.Items(Numero).Categorie

                'Si il y a au moins une unité de cette article dans le panier, la quantité'
                'disponible (en parenthèse).'
                Try
                    Quantite = Inventaire.Items(Numero).Quantite &
                               " (" & (Inventaire.Items(Numero).Quantite - Panier.Items(Numero)) & ")"
                Catch ex As System.Collections.Generic.KeyNotFoundException
                    Quantite = Inventaire.Items(Numero).Quantite &
                               " (" & (Inventaire.Items(Numero).Quantite) & ")"
                End Try

                'On crée la ligne et on l'insère dans la ListView.'
                Ligne = New ListViewItem(New String() {Numero, Nom, Prix, Categorie, Quantite})
                ListViewAfficher.Items.Add(Ligne)
                ListViewAfficherIndex.Add(Numero, ListViewAfficher.Items.Count - 1)
            End If
        Next
    End Sub

    Public Sub AddArticleInPanier(ByVal Numero As Integer)
        Dim Ligne As ListViewItem
        Dim Nom, Prix, Quantite As String

        'On calcul le prix contenant chaque unité de l'article.'
        Nom = Inventaire.Items(Numero).Nom
        Quantite = Panier.Items(Numero)
        Prix = (Quantite * Inventaire.Items(Numero).Prix).ToString("F2") & " $"

        'On crée la ligne et on l'insère dans la ListView.'
        Ligne = New ListViewItem(New String() {Numero, Nom, Quantite, Prix})
        ListViewPanier.Items.Add(Ligne)
    End Sub

    Private Sub UpdateItemInAfficherList(ByVal Numero As Integer)
        Dim Quantite As String

        'Si il y a au moins une unité de cette article dans le panier, la quantité disponible (en parenthèse).'
        Try
            Quantite = Inventaire.Items(Numero).Quantite &
                       " (" & (Inventaire.Items(Numero).Quantite - Panier.Items(Numero)) & ")"
        Catch ex As System.Collections.Generic.KeyNotFoundException
            Quantite = Inventaire.Items(Numero).Quantite &
                       " (" & (Inventaire.Items(Numero).Quantite) & ")"
        End Try

        'On modifie la ligne en question avec la nouvelle quantité.'
        ListViewAfficher.Items(ListViewAfficherIndex(Numero)).SubItems(4).Text = Quantite
    End Sub

    Private Sub UpdateItemInPanier(ByVal Numero As Integer)
        'On boucle sur tout les articles afin d'obtenir celui avec le bon numéro.'
        For Each Item In ListViewPanier.Items
            If Item.SubItems(0).Text = Numero Then
                'Une fois l'article identifié, on l'update dans le panier.'
                Item.SubItems(2).Text = Panier.Items(Numero)
                Item.SubItems(3).Text = (Panier.Items(Numero) * Inventaire.Items(Numero).Prix).ToString("F2") & " $"

                Return
            End If
        Next
    End Sub

    Private Sub RemoveItemInPanier(ByVal Numero As Integer)
        'On boucle sur tout les articles afin d'obtenir celui avec le bon numéro.'
        For Each Item In ListViewPanier.Items
            If Item.SubItems(0).Text = Numero Then
                'Une fois l'article identifié, on l'enlève du panier.'
                Panier.RemoveArticle(Numero)
                ListViewPanier.Items.Remove(Item)
                UpdateItemInAfficherList(Numero)

                Return
            End If
        Next
    End Sub

    Private Sub ClearPanier()
        ListViewPanier.Items.Clear()
        Panier.Clear()
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxAfficherCategorie.SelectedIndexChanged
        'Si l'index 0 est sélectioné, il n'y a aucun filtrage à faire.'
        If ComboBoxAfficherCategorie.SelectedIndex = 0 Then
            LoadAfficherList()
        Else
            LoadAfficherList(ComboBoxAfficherCategorie.SelectedItem)
        End If
    End Sub

    Private Sub ButtonAjouterPanier_Click(sender As Object, e As EventArgs) Handles ButtonAchatAjouter.Click
        Dim Numero As Integer

        Try
            Numero = ListViewAfficher.FocusedItem.SubItems(0).Text

            'Si un article du même type existe déjà dans le panier, on ne fait qu'updater le panier.'
            If Panier.AddArticle(Inventaire, Numero, TextBoxAchatQuantite.Text) Then
                AddArticleInPanier(Numero)
            Else
                UpdateItemInPanier(Numero)
            End If

            'On update la ligne de l'article dans l'inventaire.'
            UpdateItemInAfficherList(Numero)
        Catch ex As InsufficientQuantityException
            MessageBox.Show("Veuilez entrer une plus petite quantité.")
            TextBoxAchatQuantite.Focus()
        Catch ex As InvalidCastException
            MessageBox.Show("Veuillez entrer un nombre.")
            TextBoxAchatQuantite.Focus()
        Catch ex As System.NullReferenceException
            MessageBox.Show("Veuilez sélectionner un article.")
        End Try
    End Sub

    Private Sub ButtonPanierModification_Click(sender As Object, e As EventArgs) Handles ButtonPanierModification.Click
        Dim Numero As Integer

        Try
            Numero = ListViewPanier.FocusedItem.SubItems(0).Text

            'On change la quantité de l'article dans le panier.'
            Panier.ModifyArticle(Inventaire, Numero, TextBoxModificationQuantite.Text)

            'On update la ligne de l'article dans l'inventaire et le panier.'
            UpdateItemInAfficherList(Numero)
            UpdateItemInPanier(Numero)
        Catch ex As InsufficientQuantityException
            MessageBox.Show("Veuilez entrer une plus petite quantité.")
            TextBoxAchatQuantite.Focus()
        Catch ex As InvalidCastException
            MessageBox.Show("Veuillez entrer un nombre.")
            TextBoxAchatQuantite.Focus()
        Catch ex As System.NullReferenceException
            MessageBox.Show("Veuilez sélectionner un article.")
        End Try
    End Sub

    Private Sub ButtonPanierEnlever_Click(sender As Object, e As EventArgs) Handles ButtonPanierEnlever.Click
        RemoveItemInPanier(ListViewPanier.FocusedItem.SubItems(0).Text)
    End Sub

    Private Sub ButtonEffectuerAchat_Click(sender As Object, e As EventArgs) Handles ButtonEffectuerAchat.Click
        Dim FileDialog As New SaveFileDialog()
        Dim FileIO As StreamWriter

        'On demande le fichier pour écrire la facture.'
        FileDialog.Filter = "Fichiers .txt | *.txt"
        FileDialog.ShowDialog()

        'On catch l'exception s'il n'a pas choisie de fichier.'
        Try
            FileIO = New StreamWriter(FileDialog.FileName, False)
        Catch ex As System.ArgumentException
            Return
        End Try

        'On effectue l'achat, écrit la facture et vide le panier.'
        Panier.EffectuerAchat(Inventaire, FileIO)

        'On ferme le fichier.'
        FileIO.Close()

        'On update les lignes des articles achetés dans l'inventaire'
        For Each Item In Panier.Items
            UpdateItemInAfficherList(Item.Key)
        Next

        'On libère le panier de toutes articles à l'intérieur.'
        Panier.Items.Clear()
        ListViewPanier.Items.Clear()
    End Sub

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        Dim FileDialog As New OpenFileDialog()
        Dim FileIO As FileStream

        'On demande le fichier à ouvrir à l'utilisateur.'
        FileDialog.Filter = "Fichiers .kek | *.kek"
        FileDialog.ShowDialog()

        'On catch l'exception s'il n'a pas choisie de fichier.'
        Try
            FileIO = New FileStream(FileDialog.FileName, FileMode.Open)
        Catch ex As System.ArgumentException
            Return
        End Try

        'On ouvre l'inventaire.'
        Inventaire.Open(FileIO)
        FileIO.Close()
        ClearPanier()

        'À la première utilisation, on peut activer les contrôles.'
        EnregistrerToolStripMenuItem.Enabled = True
        ExporterToolStripMenuItem.Enabled = True
        TableLayoutPanier.Enabled = True
        TableLayoutAffichage.Enabled = True

        'On actualise les contrôles.'
        LoadAffichageCategorie()
        LoadAfficherList()
    End Sub

    Private Sub EnregistrerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnregistrerToolStripMenuItem.Click
        Dim FileDialog As New SaveFileDialog()
        Dim FileIO As FileStream

        'On demande le fichier à sauvegarder à l'utilisateur.'
        FileDialog.Filter = "Fichiers .kek | *.kek"
        FileDialog.ShowDialog()

        'On catch l'exception s'il n'a pas choisie de fichier.'
        Try
            FileIO = New FileStream(FileDialog.FileName, FileMode.Create)
        Catch ex As System.ArgumentException
            Return
        End Try

        'On sauvegarde l'inventaire.'
        Inventaire.Save(FileIO)
        FileIO.Close()
    End Sub

    Private Sub ImporterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImporterToolStripMenuItem.Click
        Dim FileDialog As New OpenFileDialog()
        Dim FileIO As StreamReader

        'On demande le fichier à importer à l'utilisateur.'
        FileDialog.Filter = "Fichiers .csv | *.csv"
        FileDialog.ShowDialog()

        'On catch l'exception s'il n'a pas choisie de fichier.'
        Try
            FileIO = New StreamReader(FileDialog.FileName, System.Text.Encoding.UTF7)
        Catch ex As System.ArgumentException
            Return
        End Try

        'On importe l'inventaire.'
        Inventaire.Import(FileIO)
        FileIO.Close()
        ClearPanier()

        'À la première utilisation, on peut activer les contrôles.'
        EnregistrerToolStripMenuItem.Enabled = True
        ExporterToolStripMenuItem.Enabled = True
        TableLayoutPanier.Enabled = True
        TableLayoutAffichage.Enabled = True

        'On actualise les contrôles.'
        LoadAffichageCategorie()
        LoadAfficherList()
    End Sub

    Private Sub ExporterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExporterToolStripMenuItem.Click
        Dim FileDialog As New SaveFileDialog()
        Dim FileIO As StreamWriter

        'On demande le fichier à exporter à l'utilisateur.'
        FileDialog.Filter = "Fichiers .csv | *.csv"
        FileDialog.ShowDialog()

        'On catch l'exception s'il n'a pas choisie de fichier.'
        Try
            FileIO = New StreamWriter(FileDialog.FileName, False, System.Text.Encoding.UTF7)
        Catch ex As System.ArgumentException
            Return
        End Try

        'On exporte l'inventaire.'
        Inventaire.Export(FileIO)
        FileIO.Close()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
