Public Class Article
    Dim MNom As String
    Dim MPrix As Double

    Public Sub New(ByVal n As String, ByVal p As Double)
        MNom = n
        MPrix = p
    End Sub

    Public Property Nom As String
        Get
            Return MNom
        End Get
        Set(value As String)
            MNom = Nom
        End Set
    End Property

    Public Property Prix As Double
        Get
            Return MPrix
        End Get
        Set(value As Double)
            MPrix = Prix
        End Set
    End Property
End Class
