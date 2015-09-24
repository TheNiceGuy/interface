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

        FileDialog.ShowDialog()
        If Not FileDialog.FileName = vbNullString Then
            FileIO = New StreamReader(FileDialog.FileName, System.Text.Encoding.UTF7)
            Librairie.Clear()
        Else
            Return
        End If

        Line = FileIO.ReadLine()
        While Not Line Is Nothing
            LineSep = Line.Split(vbTab)

            If LineSep.Count <> 4 Then
                MessageBox.Show("Le fichier est mal formatté.")
                FileIO.Close()
                Return
            End If

            If Not IsNumeric(LineSep(2)) Then
                MessageBox.Show("L'année de parution à la ligne " & LineDebug & " est mal formattée.")
                FileIO.Close()
                Return
            End If

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

            NouveauFilm = New Film(LineSep(0), LineSep(1), LineSep(2), Reserver)
            Librairie.Add(NouveauFilm)

            LineDebug += 1
            Line = FileIO.ReadLine()
        End While

        FileIO.Close()
        UpdateInventaire()
    End Sub

    Private Sub SauvegarderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SauvegarderToolStripMenuItem.Click
        Dim Reserver As String
        Dim FileDialog As New SaveFileDialog
        Dim FileIO As StreamWriter

        FileDialog.ShowDialog()
        If Not FileDialog.FileName = vbNullString Then
            FileIO = New StreamWriter(FileDialog.FileName, False, System.Text.Encoding.UTF7)
        Else
            Return
        End If

        For Index As Integer = 0 To Librairie.Count - 1
            If Librairie(Index).Reserver = True Then
                Reserver = "oui"
            Else
                Reserver = "non"
            End If

            FileIO.WriteLine(Librairie(Index).Titre & vbTab & Librairie(Index).Genre & vbTab &
                             Librairie(Index).Parution & vbTab & Reserver)
        Next

        FileIO.Close()
    End Sub

    Private Sub UpdateInventaire()
        If LibrairieIndex = 0 Then
            ButtonIPrecedent.Enabled = False
        Else
            ButtonIPrecedent.Enabled = True
        End If

        If LibrairieIndex = Librairie.Count - 1 Then
            ButtonISuivant.Enabled = False
        Else
            ButtonISuivant.Enabled = True
        End If

        TextBoxITitre.Text = Librairie(LibrairieIndex).Titre
        TextBoxIGenre.Text = Librairie(LibrairieIndex).Genre
        TextBoxIParution.Text = Librairie(LibrairieIndex).Parution
        CheckBoxIReserve.Checked = Librairie(LibrairieIndex).Reserver
    End Sub

    Private Sub ButtonNAjouter_Click(sender As Object, e As EventArgs) Handles ButtonNAjouter.Click
        Dim Parution As Integer
        Dim NouveauFilm As Film

        If Trim(TextBoxNTitre.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer un tire au film.")
            TextBoxNTitre.Clear()
            TextBoxNTitre.Focus()
            Return
        End If

        If ComboBoxNGenre.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir une catégorie.")
            ComboBoxNGenre.Focus()
            Return
        End If

        If IsNumeric(TextBoxNParution.Text) Then
            Parution = TextBoxNParution.Text
        Else
            MessageBox.Show("Veuillez entrer une année de parution adéquate.")
            TextBoxNParution.Clear()
            TextBoxNParution.Focus()
            Return
        End If

        If Parution < 1950 Or Parution > 2015 Then
            MessageBox.Show("Veuillez entrer une année de parution entre 1950 et 2015.")
            TextBoxNParution.Clear()
            TextBoxNParution.Focus()
            Return
        End If

        NouveauFilm = New Film(TextBoxNTitre.Text, ComboBoxNGenre.Text, TextBoxNParution.Text, False)
        Librairie.Add(NouveauFilm)

        TextBoxNTitre.Clear()
        TextBoxNParution.Clear()
        ComboBoxNGenre.SelectedIndex = -1

        UpdateInventaire()
    End Sub

    Private Sub ButtonRRechercher_Click(sender As Object, e As EventArgs) Handles ButtonRRechercher.Click
        If ComboBoxRGenre.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir une catégorie.")
            ComboBoxRGenre.Focus()
            Return
        End If

        ListBoxRResultat.Items.Clear()

        For Index As Integer = 0 To Librairie.Count - 1
            If Librairie(Index).Genre.ToLower() = ComboBoxRGenre.Text.ToLower() Then
                ListBoxRResultat.Items.Add(Librairie(Index).Titre & " (" &
                                           Librairie(Index).Parution & ")")
            End If
        Next
    End Sub

    Private Sub ButtonIPrecedent_Click(sender As Object, e As EventArgs) Handles ButtonIPrecedent.Click
        LibrairieIndex -= 1
        UpdateInventaire()
    End Sub

    Private Sub ButtonISuivant_Click(sender As Object, e As EventArgs) Handles ButtonISuivant.Click
        LibrairieIndex += 1
        UpdateInventaire()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
