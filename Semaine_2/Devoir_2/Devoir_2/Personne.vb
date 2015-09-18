Public Class Personne
    Dim m_nom As String
    Dim m_prenom As String
    Dim m_taux As Double
    Dim m_heure As Double
    Dim m_salaire As Double

    Public Sub New(ByVal p As String, ByVal n As String, ByVal t As Double, ByVal h As Double)
        m_prenom = p
        m_nom = n
        m_taux = t
        m_heure = h
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

    Public Property Taux As Double
        Get
            Return m_taux
        End Get
        Set(value As Double)
            m_taux = Taux
        End Set
    End Property

    Public Property Heure As Double
        Get
            Return m_heure
        End Get
        Set(value As Double)
            m_heure = Heure
        End Set
    End Property

    Public ReadOnly Property Salaire As Double
        Get
            Return m_taux * m_heure
        End Get
    End Property
End Class
