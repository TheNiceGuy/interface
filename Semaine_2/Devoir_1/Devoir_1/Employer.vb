Public Class Employer
    Dim m_nom As String
    Dim m_prenom As String
    Dim m_departement As String

    Sub New(ByVal n As String, ByVal p As String, ByVal d As String)
        m_nom = n
        m_prenom = p
        m_departement = d
    End Sub

    Public Property Nom As String
        Get
            Return m_nom
        End Get
        Set(value As String)
            m_nom = Nom
        End Set
    End Property

    Public Property Prenom As String
        Get
            Return m_prenom
        End Get
        Set(value As String)
            m_prenom = Prenom
        End Set
    End Property

    Public Property Departement As String
        Get
            Return m_departement
        End Get
        Set(value As String)
            m_departement = Departement
        End Set
    End Property
End Class
