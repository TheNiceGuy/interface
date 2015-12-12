Public Class Inscription
    Dim NewEtudiant As Etudiant

    Public Sub New(ByRef Programmes As DataTable)
        InitializeComponent()

        'On ajoute chaque programme au ComboBox.
        ComboBoxProgramme.Items.Clear()
        For Each Row In Programmes.Rows
            ComboBoxProgramme.Items.Add(Row.Item(0))
        Next
    End Sub

    Private Sub Inscription(sender As Object, e As EventArgs) Handles ButtonAccepter.Click
        'On s'assure qu'un prénom est entré.
        If TextBoxPrenom.Text.Trim = vbNullString Then
            MessageBox.Show("Veuillez entrer un prénom.")
            TextBoxPrenom.Focus()
            Return
        End If

        'On s'assure que le prénom n'est pas trop grand pour la base de données.
        If TextBoxPrenom.Text.Trim.Length > Config.MaxLength Then
            MessageBox.Show("Le prénom entré est trop grand.")
            TextBoxPrenom.Focus()
            Return
        End If

        'On s'assure qu'un nom est entré.
        If TextBoxNom.Text.Trim = vbNullString Then
            MessageBox.Show("Veuillez entrer un nom.")
            TextBoxNom.Focus()
            Return
        End If

        'On s'assure que le nom n'est pas trop grand pour la base de données.
        If TextBoxNom.Text.Trim.Length > Config.MaxLength Then
            MessageBox.Show("Le nom entré est trop grand.")
            TextBoxNom.Focus()
            Return
        End If

        'On s'assure que l'utilisateur a choisie un programme.
        If ComboBoxProgramme.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez sélectionner un programme.")
            ComboBoxProgramme.Focus()
            Return
        End If

        'On s'assure que l'utilisateur a entré un mot de passe.
        If TextBoxPassword.Text = vbNullString Then
            MessageBox.Show("Veuillez entrer un mot de passe.")
            TextBoxPassword.Focus()
            Return
        End If

        'On s'assure que l'utilisateur a entré le mot de passe de vérification.
        If TextBoxPasswordVerification.Text = vbNullString Then
            MessageBox.Show("Veuillez confirmer votre mot de passe.")
            TextBoxPasswordVerification.Focus()
            Return
        End If

        'On s'assure que les deux mots de passe sont identique.
        If Not TextBoxPassword.Text = TextBoxPasswordVerification.Text Then
            MessageBox.Show("Le mot de passe de confirmation diffère de votre mot de passe.")
            TextBoxPasswordVerification.Focus()
            Return
        End If

        'On s'assure que l'utilisateur a entré une addresse courriel.
        If TextBoxCourriel.Text.Trim = vbNullString Then
            MessageBox.Show("Veuillez entrer une addresse courriel.")
            TextBoxCourriel.Focus()
            Return
        End If

        'On s'assure que le courriel n'est pas trop grand pour la base de données.
        If TextBoxCourriel.Text.Trim.Length > Config.MaxLength Then
            MessageBox.Show("L'addresse courriel entrée est trop grande.")
            TextBoxCourriel.Focus()
            Return
        End If

        'On crée le nouvel étudiant.
        NewEtudiant = New Etudiant(TextBoxNom.Text,
                                   TextBoxPrenom.Text,
                                   ComboBoxProgramme.SelectedItem,
                                   DateTimePickerNaissance.Value.Date,
                                   TextBoxPassword.Text,
                                   TextBoxCourriel.Text)

        'On ferme la fenêtre.
        Close()
    End Sub

    Private Sub Annuler(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        'On ferme la fenêtre sans créer l'étudiant.
        Close()
    End Sub

    Private Sub KeyPressed(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Close()
        End Select
    End Sub

    Public ReadOnly Property Etudiant As Etudiant
        Get
            Return NewEtudiant
        End Get
    End Property
End Class