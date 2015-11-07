Public Class Commande
    Dim MNom As String
    Dim MID As Integer
    Dim MPurchasedDate As String
    Dim MArticle As Integer
    Dim MFournisseur As String
    Dim MQuantite As Integer
    Dim MPrixUnitaire As Double
    Dim MPrixTotal As Double

    Public Sub New(ByVal Numero As Integer, ByRef Article As DataTable)
        MNom = Article.Rows.Find(Numero).Item(1)
        MID = -1
        MPurchasedDate = Date.Now.Date
        MArticle = Numero
        MFournisseur = Article.Rows.Find(Numero).Item(4)
        MQuantite = 1
        MPrixUnitaire = Article.Rows.Find(Numero).Item(2)
        MPrixTotal = Quantite * PrixUnitaire
    End Sub

    Public ReadOnly Property Nom As String
        Get
            Return MNom
        End Get
    End Property

    Public Property ID As Integer
        Get
            Return MID
        End Get
        Set(Value As Integer)
            MID = Value
        End Set
    End Property

    Public Property PurchasedDate As String
        Get
            Return MPurchasedDate
        End Get
        Set(Value As String)
            MPurchasedDate = Value
        End Set
    End Property

    Public ReadOnly Property Article As Integer
        Get
            Return MArticle
        End Get
    End Property

    Public ReadOnly Property Fournisseur As String
        Get
            Return MFournisseur
        End Get
    End Property

    Public Property Quantite As Integer
        Get
            Return MQuantite
        End Get
        Set(Value As Integer)
            MQuantite = Value
            MPrixTotal = Quantite * PrixUnitaire
        End Set
    End Property

    Public ReadOnly Property PrixUnitaire As Double
        Get
            Return MPrixUnitaire
        End Get
    End Property

    Public ReadOnly Property PrixTotal As Double
        Get
            Return MPrixTotal
        End Get
    End Property
End Class
