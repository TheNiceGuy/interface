Imports System.IO

Public Class Window
    Dim LibrairieIndex As Integer = 0
    Dim Librairie As New ArrayList

    Private Sub OuvrirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OuvrirToolStripMenuItem.Click
        Dim Line As String
        Dim LineDebug As Integer = 1
        Dim LineSep() As String
        Dim FileDialog As New OpenFileDialog
        Dim FileIO As StreamReader
        Dim NouveauFilm As Film
        Dim Reserver As Boolean

        ' On demande et on lit le fichier s'il y en a un de sélectionné.
        FileDialog.Filter = "Fichiers .txt | *.txt"
        FileDialog.ShowDialog()
        If Not FileDialog.FileName = vbNullString Then
            FileIO = New StreamReader(FileDialog.FileName, System.Text.Encoding.UTF7)
            Librairie.Clear()
        Else
            Return
        End If

        ' On lit ligne par ligne le fichier.
        Line = FileIO.ReadLine()
        While Not Line Is Nothing
            LineSep = Line.Split(vbTab)

            ' On ignore une ligne vide.
            If LineSep.Count = 1 Then
                If LineSep(0) = vbNullString Then
                    Line = FileIO.ReadLine()
                    LineDebug += 1
                    Continue While
                End If
            End If

            ' On ignore une ligne mal formatté tout en écrivant un message.
            If LineSep.Count <> 4 Then
                MessageBox.Show("ATTENTION: La ligne " & LineDebug & " est mal formattée. Elle sera ignorée.")
                Line = FileIO.ReadLine()
                LineDebug += 1
                Continue While
            End If

            ' On regarde si la date est bien un nombre.
            If Not IsNumeric(LineSep(2)) Then
                MessageBox.Show("ERREUR: La ligne " & LineDebug & " ne contient pas une date numérique.")
                FileIO.Close()
                Return
            End If

            ' On traduit le oui/non en boolean afin de l'enregistrer dans une variable.
            Select Case LineSep(3).ToLower()
                Case "oui"
                    Reserver = True
                Case "non"
                    Reserver = False
                Case Else
                    MessageBox.Show("Le status du livre à la ligne " & LineDebug & " est mal formatté.")
                    FileIO.Close()
                    Return
            End Select

            ' On crée le film et on le rajoute dans la librairie.
            NouveauFilm = New Film(LineSep(0), LineSep(1), LineSep(2), Reserver)
            Librairie.Add(NouveauFilm)

            'On lit une nouvelle ligne.
            Line = FileIO.ReadLine()
            LineDebug += 1
        End While

        ' On ferme le fichier et on update l'information dans le groupbox de l'inventaire.
        FileIO.Close()
        UpdateInventaire()
    End Sub

    Private Sub SauvegarderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SauvegarderToolStripMenuItem.Click
        Dim Reserver As String
        Dim FileDialog As New SaveFileDialog
        Dim FileIO As StreamWriter

        ' On demande et on lit le fichier s'il y en a un de sélectionné.
        FileDialog.Filter = "Fichiers .txt | *.txt"
        FileDialog.ShowDialog()
        If Not FileDialog.FileName = vbNullString Then
            FileIO = New StreamWriter(FileDialog.FileName, False, System.Text.Encoding.UTF7)
        Else
            Return
        End If

        ' On écrit chaque ligne dans le fichier.
        For Index As Integer = 0 To Librairie.Count - 1
            ' On traduit le boolean en oui/non afin de l'enregistrer dans le fichier.
            If Librairie(Index).Reserver = True Then
                Reserver = "oui"
            Else
                Reserver = "non"
            End If

            ' On écrit la ligne en tant que telle.
            FileIO.WriteLine(Librairie(Index).Titre & vbTab & Librairie(Index).Genre & vbTab &
                             Librairie(Index).Parution & vbTab & Reserver)
        Next

        ' On ferme le fichier.
        FileIO.Close()
    End Sub

    Private Sub UpdateInventaire()
        ' On active/désactive le button Précédent.
        If LibrairieIndex = 0 Then
            ButtonIPrecedent.Enabled = False
        Else
            ButtonIPrecedent.Enabled = True
        End If

        ' On active/désactive le button Suivant.
        If LibrairieIndex = Librairie.Count - 1 Then
            ButtonISuivant.Enabled = False
        Else
            ButtonISuivant.Enabled = True
        End If

        ' On update les entrées dans le groupbox.
        TextBoxITitre.Text = Librairie(LibrairieIndex).Titre
        TextBoxIGenre.Text = Librairie(LibrairieIndex).Genre
        TextBoxIParution.Text = Librairie(LibrairieIndex).Parution
        CheckBoxIReserve.Checked = Librairie(LibrairieIndex).Reserver
    End Sub

    Private Sub ButtonNAjouter_Click(sender As Object, e As EventArgs) Handles ButtonNAjouter.Click
        Dim Parution As Integer
        Dim NouveauFilm As Film

        ' On s'assure qu'un titre est entré.
        If Trim(TextBoxNTitre.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer un tire au film.")
            TextBoxNTitre.Clear()
            TextBoxNTitre.Focus()
            Return
        End If

        ' On s'assure qu'une catégorie est choisie.
        If ComboBoxNGenre.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir une catégorie.")
            ComboBoxNGenre.Focus()
            Return
        End If

        ' On s'assure que la date est numérique.
        If IsNumeric(TextBoxNParution.Text) Then
            Parution = TextBoxNParution.Text
        Else
            MessageBox.Show("Veuillez entrer une année de parution adéquate.")
            TextBoxNParution.Clear()
            TextBoxNParution.Focus()
            Return
        End If

        ' On s'assure que la date respecte les limites.
        If Parution < 1950 Or Parution > 2015 Then
            MessageBox.Show("Veuillez entrer une année de parution entre 1950 et 2015.")
            TextBoxNParution.Clear()
            TextBoxNParution.Focus()
            Return
        End If

        ' On crée le film et on le rajoute dans la librairie.
        NouveauFilm = New Film(TextBoxNTitre.Text, ComboBoxNGenre.Text, TextBoxNParution.Text, False)
        Librairie.Add(NouveauFilm)

        ' On clear le groupbox.
        TextBoxNTitre.Clear()
        TextBoxNParution.Clear()
        ComboBoxNGenre.SelectedIndex = -1

        ' On update la groupebox de l'inventaire dans l'éventualité que c'est le premier objet ajouté.
        UpdateInventaire()
    End Sub

    Private Sub ButtonRRechercher_Click(sender As Object, e As EventArgs) Handles ButtonRRechercher.Click
        ' On s'assure qu'une catégorie est choisie.
        If ComboBoxRGenre.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir une catégorie.")
            ComboBoxRGenre.Focus()
            Return
        End If

        ' On clear la dernière recherche.
        ListBoxRResultat.Items.Clear()

        ' On chercher dans les films et on les ajoute dans la listbox.
        For Index As Integer = 0 To Librairie.Count - 1
            If Librairie(Index).Genre.ToLower() = ComboBoxRGenre.Text.ToLower() Then
                ListBoxRResultat.Items.Add(Librairie(Index).Titre & " (" &
                                           Librairie(Index).Parution & ")")
            End If
        Next
    End Sub

    Private Sub ButtonIPrecedent_Click(sender As Object, e As EventArgs) Handles ButtonIPrecedent.Click
        ' On diminue l'index et on update la groupbox de l'inventaire.
        LibrairieIndex -= 1
        UpdateInventaire()
    End Sub

    Private Sub ButtonISuivant_Click(sender As Object, e As EventArgs) Handles ButtonISuivant.Click
        ' On augmente l'index et on update la groupbox de l'inventaire.
        LibrairieIndex += 1
        UpdateInventaire()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        ' On ferme le programme.
        Me.Close()
    End Sub
End Class
