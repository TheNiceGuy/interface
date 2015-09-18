Public Class Produit
    Dim MNom As String
    Dim MCategorie As Integer
    Dim MQuantite As Integer

    Public Sub New(ByVal n As String, ByVal c As Integer, ByVal q As Integer)
        MNom = n
        MCategorie = c
        MQuantite = q
    End Sub

    Public ReadOnly Property Nom
        Get
            Return MNom
        End Get
    End Property

    Public ReadOnly Property Categorie
        Get
            Return MCategorie
        End Get
    End Property

    Public ReadOnly Property Quantite
        Get
            Return MQuantite
        End Get
    End Property
End Class
