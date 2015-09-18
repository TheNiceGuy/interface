Public Class Formulaire
    Dim MPersonne As Personne

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByRef p As Personne)
        InitializeComponent()

        TextBoxPrenom.Text = p.Prenom
        TextBoxNom.Text = p.Nom
        TextBoxTaux.Text = p.Taux
        TextBoxHeure.Text = p.Heure
    End Sub

    Private Sub ButtonConfirmer_Click(sender As Object, e As EventArgs) Handles ButtonConfirmer.Click
        If Trim(TextBoxPrenom.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer un prénom!")
            TextBoxPrenom.Clear()
            Return
        End If

        If Trim(TextBoxNom.Text & vbNullString) = vbNullString Then
            MessageBox.Show("Veuillez entrer un nom!")
            TextBoxNom.Clear()
            Return
        End If

        If Not IsNumeric(TextBoxTaux.Text) Then
            MessageBox.Show("Veuillez entrer un taux adéquat!")
            TextBoxTaux.Clear()
            Return
        End If

        If Not IsNumeric(TextBoxHeure.Text) Then
            MessageBox.Show("Veuillez entrer un nombre d'heures adéquat!")
            TextBoxHeure.Clear()
            Return
        End If

        MPersonne = New Personne(TextBoxPrenom.Text, TextBoxNom.Text, TextBoxTaux.Text, TextBoxHeure.Text)

        Me.Close()
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        Me.Close()
    End Sub

    Public ReadOnly Property Personnage
        Get
            Return MPersonne
        End Get
    End Property
End Class