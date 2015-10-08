Public Class NouveauMembre
    Dim Nouveau As Membre

    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        Dim Nom As String
        Dim Prenom As String
        Dim Annee As Integer

        'On vérifie si un nom est entré.'
        Nom = TextBoxNom.Text
        If (Nom & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer un nom.")
            TextBoxNom.Focus()
            Return
        End If

        'On vérifie si un prénom est entré.'
        Prenom = TextBoxPrenom.Text
        If (Prenom & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer un prénom.")
            TextBoxPrenom.Focus()
            Return
        End If

        'On vérifie si l'année de naissance est une valeur numérique.'
        Try
            Annee = TextBoxAnnee.Text
        Catch ex As InvalidCastException
            MessageBox.Show("Veuillez entrer une année de naissance valide.")
            TextBoxAnnee.Clear()
            TextBoxAnnee.Focus()
            Return
        End Try

        'On vérifie si l'année respecte les normes.'
        If Annee < 1930 Or Annee > 2015 Then
            MessageBox.Show("Veuillez une année de naissance entre 1930 et 2015.")
            TextBoxAnnee.Clear()
            TextBoxAnnee.Focus()
            Return
        End If

        'On crée le nouveau membre.'
        Nouveau = New Membre(Nom, Prenom, Annee)

        'On ferme la fenêtre.'
        Me.Close()
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub

    Public ReadOnly Property Membre As Membre
        Get
            Return Nouveau
        End Get
    End Property
End Class