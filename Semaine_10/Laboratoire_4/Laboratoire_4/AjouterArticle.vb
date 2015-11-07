Public Class AjouterArticle
    Dim MNewArticle As Article

    Public Sub New(ByRef Fournisseur As DataTable)
        InitializeComponent()

        'On configure la ComboBox.
        ComboBoxFournisseur.DataSource = Fournisseur
        ComboBoxFournisseur.ValueMember = "NomFournisseur"
    End Sub

    Private Sub ButtonAjout_Click(sender As Object, e As EventArgs) Handles ButtonAjouter.Click
        'On s'assure que l'utilisateur a entré un nom.
        If (TextBoxNom.Text & vbNullString).Trim() = vbNullString Then
            MessageBox.Show("Veuillez entrer un nom.")
            TextBoxNom.Focus()
            Return
        End If

        'On s'assure que l'utilisateur a choisie un fournisseur.
        If ComboBoxFournisseur.SelectedIndex = -1 Then
            MessageBox.Show("Veuillez choisir un fournisseur.")
            ComboBoxFournisseur.Focus()
            Return
        End If

        'On crée l'article en tant que tel.
        MNewArticle = New Article(TextBoxNom.Text.Trim(),
                                  NumericUpDownPrix.Value,
                                  NumericUpDownQuantite.Value,
                                  ComboBoxFournisseur.SelectedValue)

        'On ferme la fenêtre.
        Me.Close()
    End Sub

    Private Sub ButtonAnnuler_Click(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        'On ferme la fenêtre sans créer un article.
        Me.Close()
    End Sub

    Public ReadOnly Property NewArticle As Article
        Get
            Return MNewArticle
        End Get
    End Property
End Class