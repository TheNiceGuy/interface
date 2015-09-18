Public Class Window
    Dim PositionAjout As Integer = 0
    Dim PositionModif As Integer = -1
    Dim Personnel(10) As Employer

    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        If Trim(TextBoxAjoutNom.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer un nom.")
            Return
        End If

        If Trim(TextBoxAjoutPrenom.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer un prénom.")
            Return
        End If

        If Trim(TextBoxAjoutDepartement.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer un département.")
            Return
        End If

        If PositionAjout < Personnel.Length Then
            Personnel(PositionAjout) = New Employer(TextBoxAjoutNom.Text, TextBoxAjoutPrenom.Text,
                                                    TextBoxAjoutDepartement.Text)
            PositionAjout += 1
        Else
            ReDim Preserve Personnel(Personnel.Length * 2)
        End If

        TextBoxAjoutNom.Clear()
        TextBoxAjoutPrenom.Clear()
        TextBoxAjoutDepartement.Clear()

        If PositionModif = -1 Then
            PositionModif = 0
        End If

        UpdateModif()
    End Sub

    Private Sub UpdateModif()
        LabelQuantite.Text = PositionModif + 1 & "/" & PositionAjout

        If PositionModif = 0 Then
            ButtonPrecedent.Enabled = False
        Else
            ButtonPrecedent.Enabled = True
        End If

        If PositionModif = PositionAjout - 1 Then
            ButtonSuivant.Enabled = False
        Else
            ButtonSuivant.Enabled = True
        End If

        TextBoxModifNom.Text = Personnel(PositionModif).Nom
        TextBoxModifPrenom.Text = Personnel(PositionModif).Prenom
        TextBoxModifDepartement.Text = Personnel(PositionModif).Departement
    End Sub

    Private Sub ButtonPrecedent_Click(sender As Object, e As EventArgs) Handles ButtonPrecedent.Click
        PositionModif -= 1

        If PositionModif = 0 Then
            PositionModif = 0
        End If

        UpdateModif()
    End Sub

    Private Sub ButtonSuivant_Click(sender As Object, e As EventArgs) Handles ButtonSuivant.Click
        PositionModif += 1

        If PositionModif > PositionAjout - 1 Then
            PositionModif = PositionAjout - 1
        End If

        UpdateModif()
    End Sub
End Class
