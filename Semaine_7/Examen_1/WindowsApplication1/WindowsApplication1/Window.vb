Imports System.IO

Public Class Window
    Dim Inventaire As New ArrayList
    Dim Membres As New Dictionary(Of String, Membre)
    Dim Panier As New Dictionary(Of String, ArticleAchete)

    Private Function UpdateSousTotal() As Boolean
        Dim Index As Integer
        Dim Quantite As Integer

        'On récupère l'index de l'article dans l'inventaire.'
        Index = ListBoxInventaire.SelectedIndex

        'On écrit le sous-total seulement si la quantité est numérique.'
        Try
            Quantite = TextBoxQuantite.Text
            TextBoxSousTotal.Text = Inventaire(Index).Prix * Convert.ToDouble(Quantite) & " $"
            ButtonAjouter.Enabled = True
            Return True
        Catch ex As InvalidCastException
            TextBoxSousTotal.Clear()
            TextBoxSousTotal.Text = ""
            ButtonAjouter.Enabled = False
            Return False
        End Try
    End Function

    Private Sub WindowLoadInventaire()
        'On vide l'inventaire.'
        ListBoxInventaire.Items.Clear()

        'On boucle dans les articles afin de les insérer dans la ListBox.'
        For Index As Integer = 0 To Inventaire.Count - 1
            ListBoxInventaire.Items.Add(Inventaire(Index).Nom)
        Next
    End Sub

    Private Sub ImporterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImporterToolStripMenuItem.Click
        Dim FileDialog As New OpenFileDialog()
        Dim FileIO As StreamReader
        Dim Line As String
        Dim LineSep() As String
        Dim RNom As String
        Dim RPrix As Double
        Dim Article As Article

        'On demande le fichier à importer à l'utilisateur.'
        FileDialog.Filter = "Fichiers .csv | *.csv"
        FileDialog.ShowDialog()

        'On catch l'exception s'il n'a pas choisie de fichier.'
        Try
            FileIO = New StreamReader(FileDialog.FileName, System.Text.Encoding.UTF7)
        Catch ex As System.ArgumentException
            Return
        End Try

        Do
            'On lit le fichier ligne par ligne.'
            Line = FileIO.ReadLine()

            Try
                'On split la ligne.'
                LineSep = Line.Split(";")

                'On performe les cast nécéssaires pour travailler sur l'information.'
                RNom = LineSep(0)
                RPrix = LineSep(1)
            Catch ex As InvalidCastException
                MessageBox.Show("Une ligne mal formattée fut ignorée.")
                Continue Do
            Catch ex As System.IndexOutOfRangeException
                MessageBox.Show("Une ligne mal formattée fut ignorée.")
                Continue Do
            Catch ex As System.NullReferenceException
                'La dernière ligne renvoit cette exception, alors on quitte la boucle.'
                Exit Do
            End Try

            'On rajoute l'article dans l'inventaire.'
            Article = New Article(RNom, RPrix)
            Inventaire.Add(Article)
        Loop While Not Line Is Nothing
        FileIO.Close()

        'On affiche la liste d'article dans la ListBox.'
        WindowLoadInventaire()

        'On permet à l'utilisateur d'entrer un identifiant.'
        TextBoxIdentifiant.Enabled = True
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NouveauToolStripMenuItem.Click
        Dim Nouveau As New NouveauMembre

        NouveauMembre.ShowDialog()

        Try
            'On ajoute le membre dans la liste de membre.'
            Membres.Add(NouveauMembre.Membre.Identifiant, NouveauMembre.Membre)
        Catch ex As System.ArgumentException
            'On affiche un message d'erreur si un autre membre ayant le même identifant existe.'
            MessageBox.Show("Erreur! Ce membre existe déjà dans la clientèle.")
        Catch ex As System.NullReferenceException
            'On ignore l'inscription si l'utilisateur a annuler.'
            Return
        End Try
    End Sub

    Private Sub TextBoxIdentifiant_TextChanged(sender As Object, e As EventArgs) Handles TextBoxIdentifiant.TextChanged
        Dim Identifiant As String

        Identifiant = TextBoxIdentifiant.Text
        If (Identifiant & vbNullString) = vbNullString Then
            'On désactive la sélection si rien n'est entré.'
            ListBoxInventaire.Enabled = False
            TextBoxQuantite.Enabled = False
            LabelStatut.Text = "ID Invalide"
            Return
        End If

        For Each ID In Membres.Keys
            If Identifiant.ToUpper() = ID Then
                'On active la sélection si le membre existe.'
                ListBoxInventaire.Enabled = True
                LabelStatut.Text = ""
                Return
            End If
        Next

        'On désactive la sélection si le membre n'existe pas.'
        ListBoxInventaire.Enabled = False
        TextBoxQuantite.Enabled = False
        ButtonAjouter.Enabled = False
    End Sub

    Private Sub ListBoxInventaire_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxInventaire.SelectedIndexChanged
        Dim Index As Integer = ListBoxInventaire.SelectedIndex

        If Index = -1 Then
            'On désactive la sélection d'une quantité.'
            TextBoxNom.Clear()
            TextBoxPrix.Clear()
            TextBoxQuantite.Enabled = False
        Else
            'On active la sélection d'une quantité.'
            TextBoxNom.Text = Inventaire(Index).Nom
            TextBoxPrix.Text = Inventaire(Index).Prix & " $"
            TextBoxQuantite.Enabled = True
        End If

        'On update le sous-total.'
        UpdateSousTotal()
    End Sub

    Private Sub TextBoxQuantite_TextChanged(sender As Object, e As EventArgs) Handles TextBoxQuantite.TextChanged
        UpdateSousTotal()
    End Sub

    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        Dim Achat As ArticleAchete
        Dim Nom As String
        Dim Prix As Double
        Dim Quantite As Integer

        'On récupère le nom, le prix et la quantité de l'article à ajouter dans le panier.'
        Nom = TextBoxNom.Text
        Prix = TextBoxPrix.Text.Replace("$", vbNullChar).Trim()
        Quantite = TextBoxQuantite.Text

        'On crée l'article à ajouter au panier.'
        Achat = New ArticleAchete(Nom, Prix, Quantite)

        'On ajoute l'article dans le panier.'
        Try
            Panier.Add(Achat.Nom, Achat)
            ListBoxPanier.Items.Add(Nom)
        Catch ex As System.ArgumentException
            'Si l'article est déjà dans le panier, on augmente la quantité.'
            Panier(Achat.Nom).Quantite = Panier(Achat.Nom).Quantite + Quantite
        End Try

        'On active l'achat final.'
        ButtonTerminer.Enabled = True
    End Sub

    Private Sub ButtonTerminer_Click(sender As Object, e As EventArgs) Handles ButtonTerminer.Click
        Dim FileDialog As New SaveFileDialog()
        Dim FileIO As StreamWriter
        Dim Identifiant As String
        Dim ID As String = vbNullString
        Dim Nom, Prenom As String
        Dim Total As Double = 0

        'On trouve la clé relié au membre en question.'
        Identifiant = TextBoxIdentifiant.Text
        For Each Key In Membres.Keys
            If Identifiant.ToUpper() = Key Then
                ID = Key
                Exit For
            End If
        Next

        'Dans le cas ou le membre n'existe pas, on annule. (ça ne devrait pas arriver)'
        If ID = vbNullString Then
            Return
        End If

        'On récupère le nom et le prénom du membre.'
        Nom = Membres(ID).Nom
        Prenom = Membres(ID).Prenom

        'On demande le fichier à importer à l'utilisateur.'
        FileDialog.Filter = "Fichiers .txt | *.txt"
        FileDialog.ShowDialog()

        'On catch l'exception s'il n'a pas choisie de fichier.'
        Try
            FileIO = New StreamWriter(FileDialog.FileName, False)
        Catch ex As System.ArgumentException
            Return
        End Try

        'On écrit l'information du membre.'
        FileIO.WriteLine("Identifiant: " & vbTab & vbTab & Identifiant)
        FileIO.WriteLine("Nom: " & vbTab & vbTab & Nom)
        FileIO.WriteLine("Prénom: " & vbTab & vbTab & Prenom)
        FileIO.WriteLine("")

        'On écrit les headers du tableau'
        FileIO.WriteLine(String.Format("{0, -30}", "Nom") +
                         String.Format("{0, 8}", "Prix") +
                         String.Format("{0, 6}", "Qté") +
                         String.Format("{0, 10}", "Sous-Total"))

        'On écrit ligne par ligne les articles achetés.'
        For Each Key In Panier.Keys
            FileIO.WriteLine(String.Format("{0, -30}", Panier(Key).Nom +
                             String.Format("{0, 8:$#,##0.00}", Panier(Key).Prix) +
                             String.Format("{0, 6}", Panier(Key).Quantite) +
                             String.Format("{0, 10:$#,##0.00}", Panier(Key).SousTotal)))
            Total += Panier(Key).SousTotal
        Next

        'On écrit le total.'
        FileIO.WriteLine(String.Format("{0,47}", "Total") +
                         String.Format("{0, 10:$#,##0.00}", Total))

        'On ferme le fichier.'
        FileIO.Close()
    End Sub
End Class