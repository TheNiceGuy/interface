Public Class Film
    Dim MTitre As String
    Dim MGenre As String
    Dim MParution As Integer
    Dim MReserver As Boolean

    Public Sub New(ByVal t As String, ByVal g As String, ByVal p As Integer, ByVal r As Boolean)
        MTitre = t
        MGenre = g
        MParution = p
        MReserver = r
    End Sub

    Public ReadOnly Property Titre As String
        Get
            Return MTitre
        End Get
    End Property

    Public ReadOnly Property Genre As String
        Get
            Return MGenre
        End Get
    End Property

    Public ReadOnly Property Parution As Integer
        Get
            Return MParution
        End Get
    End Property

    Public ReadOnly Property Reserver As Boolean
        Get
            Return MReserver
        End Get
    End Property
End Class
