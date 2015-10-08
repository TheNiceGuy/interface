<Serializable> Public Class Client
    Dim MNom As String
    Dim MPrenom As String

    Sub New(ByVal n As String, ByVal p As String)
        MNom = n
        MPrenom = p
    End Sub

    Public Property Nom As String
        Get
            Return MNom
        End Get
        Set(value As String)
            MNom = Nom
        End Set
    End Property

    Public Property Prenom As String
        Get
            Return MPrenom
        End Get
        Set(value As String)
            MPrenom = Prenom
        End Set
    End Property
End Class
