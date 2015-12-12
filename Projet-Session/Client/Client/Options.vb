Public Class OptionsContainer(Of ContainedClass)
    Public Options As ContainedClass
End Class

Public Class Options
    Dim MAddresse As String
    Dim MPort As Integer
    Dim MUpdated As Boolean = False

    Public Sub New()
        InitializeComponent()

        'On assigne des paramètres par defauts.
        MAddresse = Config.Addresse
        MPort = Config.Port

        'On assigne ses options aux contrôles.
        TextBoxAdresse.Text = MAddresse
        NumericUpDownPort.Value = MPort
    End Sub

    Private Sub Accepter(sender As Object, e As EventArgs) Handles ButtonAccepter.Click
        'On s'assure qu'une addresse est entrée.
        If TextBoxAdresse.Text.Trim = vbNullString Then
            MessageBox.Show("Veuillez entrer une addresse.")
            TextBoxAdresse.Focus()
            Return
        End If

        'On assigne les options.
        MAddresse = TextBoxAdresse.Text
        MPort = NumericUpDownPort.Value

        'On ferme la fenêtre.
        MUpdated = True
        Close()
    End Sub

    Private Sub Annuler(sender As Object, e As EventArgs) Handles ButtonAnnuler.Click
        'On ferme la fenêtre sans changer les options.
        MUpdated = False
        Close()
    End Sub

    Private Sub KeyPressed(ByVal sender As Object, ByVal e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Escape
                Annuler(sender, e)
        End Select
    End Sub

    Public ReadOnly Property Addresse As String
        Get
            Return MAddresse
        End Get
    End Property

    Public ReadOnly Property Port As Integer
        Get
            Return MPort
        End Get
    End Property

    Public Property Updated As Boolean
        Get
            Return MUpdated
        End Get
        Set(value As Boolean)
            MUpdated = value
        End Set
    End Property
End Class