Public Class Client
    Dim MPrenom As String
    Dim MNom As String
    Dim MCourriel As String

    Public Sub New(ByVal P As String, ByVal N As String, ByVal C As String)
        MPrenom = P
        MNom = N
        MCourriel = C
    End Sub

    Public Property Prenom As String
        Get
            Return MPrenom
        End Get
        Set(ByVal value As String)
            MPrenom = value
        End Set
    End Property

    Public Property Nom As String
        Get
            Return MNom
        End Get
        Set(ByVal value As String)
            MNom = value
        End Set
    End Property

    Public Property Courriel As String
        Get
            Return MCourriel
        End Get
        Set(ByVal value As String)
            MCourriel = value
        End Set
    End Property
End Class