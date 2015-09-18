Public Class Personnage
    Dim m_nom As String
    Dim m_age As Integer

    Sub New()
        m_nom = "Richard Stallman"
        m_age = 62
    End Sub

    Sub New(ByVal nom As String, ByVal age As Integer)
        m_nom = nom
        m_age = age
    End Sub

    Public Property nom As String
        Get
            Return m_nom
        End Get
        Set(value As String)
            m_nom = nom
        End Set
    End Property

    Public Property age As Integer
        Get
            Return m_age
        End Get
        Set(value As Integer)
            m_age = age
        End Set
    End Property
End Class
