Public Class Window
    Private Const CAdult = 40
    Private Const CEnfant = 20
    Private Const CEtudiant = 25
    Private Const CVieux = 30
    Private Const OYoga = 10
    Private Const OKarate = 30
    Private Const OEntraineur = 50
    Private Const T1_3 = 1.0
    Private Const T4_6 = 0.95
    Private Const T7_9 = 0.92
    Private Const T10_ = 0.9

    Private Sub ButtonCalculer_Click(sender As Object, e As EventArgs) Handles ButtonCalculer.Click
        Dim CoutMensuel As Double = 0

        If TypeAdulte.Checked Then
            CoutMensuel += CAdult
        ElseIf TypeEnfant.Checked Then
            CoutMensuel += CEnfant
        ElseIf TypeEtudiant.Checked Then
            CoutMensuel += CEtudiant
        ElseIf TypeVieux.Checked Then
            CoutMensuel += CVieux
        End If

        If OptionsYoga.Checked Then
            CoutMensuel += OYoga
        End If
        If OptionsKarate.Checked Then
            CoutMensuel += OKarate
        End If
        If OptionsEntraineur.Checked Then
            CoutMensuel += OEntraineur
        End If

        Select Case Convert.ToInt32(TempsText.Text)
            Case 1 To 3
                CoutMensuel *= T1_3
            Case 4 To 6
                CoutMensuel *= T4_6
            Case 7 To 9
                CoutMensuel *= T7_9
            Case Is > 10
                CoutMensuel *= T10_
        End Select
        CoutMensuelText.Text = CoutMensuel
        CoutTotalText.Text = CoutMensuel * Convert.ToInt32(TempsText.Text)
    End Sub

    Private Sub ButtonEffacer_Click(sender As Object, e As EventArgs) Handles ButtonEffacer.Click
        TypeAdulte.Checked = True
        TypeEnfant.Checked = False
        TypeEtudiant.Checked = False
        TypeVieux.Checked = False

        OptionsYoga.Checked = False
        OptionsKarate.Checked = False
        OptionsEntraineur.Checked = False

        TempsText.Text = 1

        CoutMensuelText.Text = 0
        CoutTotalText.Text = 0
    End Sub
End Class
