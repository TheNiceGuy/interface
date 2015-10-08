Public Class Achat
    Dim MNumero As Integer
    Dim MIdentifiant As String
    Dim MPanier As New ArrayList
    Dim MTotal As Double

    Public Sub New(ByVal n As Integer, ByVal i As String)
        MNumero = n
        MIdentifiant = i
    End Sub

    Public Property Numero As Integer
        Get
            Return MNumero
        End Get
        Set(value As Integer)
            MNumero = Numero
        End Set
    End Property

    Public Property Identifiant As Integer
        Get
            Return MIdentifiant
        End Get
        Set(value As Integer)
            MIdentifiant = Identifiant
        End Set
    End Property

    Public ReadOnly Property Total As Integer
        Get
            Return MTotal
        End Get
    End Property
End Class
