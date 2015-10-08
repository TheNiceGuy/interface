Public Class ArticleAchete
    Dim MNom As String
    Dim MPrix As Double
    Dim MQuantite As Integer
    Dim MSousTotal As Double

    Public Sub New(ByVal n As String, ByVal p As Double, ByVal q As Integer)
        MNom = n
        MPrix = p
        MQuantite = q
        MSousTotal = p * q
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

    Public Property Quantite As Integer
        Get
            Return MQuantite
        End Get
        Set(value As Integer)
            MQuantite = Quantite
        End Set
    End Property

    Public Property SousTotal As Double
        Get
            Return MSousTotal
        End Get
        Set(value As Double)
            MSousTotal = SousTotal
        End Set
    End Property
End Class
