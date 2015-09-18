Public Class Window
    Dim MondeIndexAjout As Integer = 0
    Dim Monde(10) As Personne

    Private Sub ButtonAjouter_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        Dim Form As New Formulaire()

        Form.ShowDialog()

        If Form.Personnage Is Nothing Then
            Return
        Else
            Monde(MondeIndexAjout) = Form.Personnage
            ListBoxPersonne.Items.Add(Form.Personnage.Prenom & " " & Form.Personnage.Nom)

            MondeIndexAjout += 1
        End If
    End Sub

    Private Sub ButtonModifier_Click(sender As Object, e As EventArgs) Handles ButtonModifier.Click
        Dim Form As New Formulaire(Monde(ListBoxPersonne.SelectedIndex))

        Form.ShowDialog()

        If Form.Personnage Is Nothing Then
            Return
        Else
            Monde(MondeIndexAjout) = Form.Personnage
            ListBoxPersonne.Items(ListBoxPersonne.SelectedIndex) = Form.Personnage.Prenom & " " & Form.Personnage.Nom
        End If
    End Sub

    Private Sub ListBoxPersonne_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxPersonne.SelectedIndexChanged
        ButtonModifier.Enabled = True
        ButtonSupprimer.Enabled = True
    End Sub

    Private Sub ButtonSupprimer_Click(sender As Object, e As EventArgs) Handles ButtonSupprimer.Click
        ListBoxPersonne.Items.RemoveAt(ListBoxPersonne.SelectedIndex)
        MondeIndexAjout -= 1

        ButtonModifier.Enabled = False
        ButtonSupprimer.Enabled = False
    End Sub
End Class
