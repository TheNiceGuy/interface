Public Class Membre
    Dim MNom As String
    Dim MPrenom As String
    Dim MIdentifiant As String

    Public Sub New(ByVal n As String, ByVal p As String, ByVal y As Integer)
        MNom = n
        MPrenom = p
        MIdentifiant = GenerateID(y).ToUpper()
    End Sub

    Private Function GenerateID(ByVal y As Integer) As String
        Dim ID As String = ""

        'Si le nom à moins de 3 caractères, on ajoute des tirets dans l'identifiant.'
        If MNom.Length < 3 Then
            ID += MNom + StrDup(3 - MNom.Length, "-")
        Else
            ID += MNom.Substring(0, 3)
        End If

        'Si le prénom à moins de 3 caractères, on ajoute des tirets dans l'identifiant.'
        If MPrenom.Length < 3 Then
            ID += MPrenom + StrDup(3 - MPrenom.Length, "-")
        Else
            ID += MPrenom.Substring(0, 3)
        End If


        Return ID + y.ToString()
    End Function

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

    Public Property Identifiant As String
        Get
            Return MIdentifiant
        End Get
        Set(value As String)
            MIdentifiant = Identifiant
        End Set
    End Property
End Class
