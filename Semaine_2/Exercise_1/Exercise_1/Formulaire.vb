Public Class Formulaire
    Dim p As Personnage

    Sub New()
        InitializeComponent()
    End Sub

    Private Sub ButtonConfirmer_Click(sender As Object, e As EventArgs) Handles ButtonConfirmer.Click
        If Trim(TextBoxNom.Text & vbNullString) = vbNullString Then
            TextBoxNom.Clear()
            MsgBox("Veuillez entrer un nom valide.")
            Return
        End If

        If Not IsNumeric(TextBoxAge.Text) Then
            TextBoxAge.Clear()
            MsgBox("Veuillez entrer une valeur numérique.")
            Return
        End If

        p = New Personnage(TextBoxNom.Text, TextBoxAge.Text)
        Me.Close()
    End Sub

    Public ReadOnly Property personne As Personnage
        Get
            Return p
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub
End Class