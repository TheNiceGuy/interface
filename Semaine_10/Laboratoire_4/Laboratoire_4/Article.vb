Public Class Article
    Dim MNumero As Integer
    Dim MNom As String
    Dim MPrix As Double
    Dim MQuantite As Integer
    Dim MFournisseur As String

    Public Sub New(ByVal n As String, ByVal p As Double, ByVal q As Integer, ByVal f As String)
        MNumero = 0
        MNom = n
        MPrix = p
        MQuantite = q
        MFournisseur = f
    End Sub

    Public Property Numero As Integer
        Get
            Return MNumero
        End Get
        Set(Value As Integer)
            MNumero = Value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return MNom
        End Get
        Set(Value As String)
            MNom = Value
        End Set
    End Property

    Public Property Prix As Double
        Get
            Return MPrix
        End Get
        Set(Value As Double)
            MPrix = Value
        End Set
    End Property

    Public Property Quantite As Integer
        Get
            Return MQuantite
        End Get
        Set(Value As Integer)
            MQuantite = Value
        End Set
    End Property

    Public Property Fournisseur As String
        Get
            Return MFournisseur
        End Get
        Set(Value As String)
            MFournisseur = Value
        End Set
    End Property
End Class
