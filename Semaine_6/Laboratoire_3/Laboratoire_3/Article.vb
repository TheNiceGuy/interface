<Serializable> Public Class Article
    Dim MNom As String
    Dim MPrix As Double
    Dim MCategorie As String
    Dim MQuantite As Integer

    Sub New(ByVal n As String, ByVal p As String, ByVal c As String, ByVal q As Integer)
        MNom = n
        MPrix = p
        MCategorie = c
        MQuantite = q
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

    Public Property Categorie As String
        Get
            Return MCategorie
        End Get
        Set(value As String)
            MCategorie = Categorie
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
End Class
