<Serializable> Public Class Etudiant
    Dim MMatricule As String
    Dim MNom As String
    Dim MPrenom As String
    Dim MProgramme As String
    Dim MNaissance As Date
    Dim MPasskey As String
    Dim MCourriel As String

    Public Sub New(ByVal Etudiant As Etudiant)
        MMatricule = Etudiant.Matricule
        MNom = Etudiant.Nom
        MPrenom = Etudiant.Prenom
        MProgramme = Etudiant.Programme
        MNaissance = Etudiant.Naissance
        MPasskey = Etudiant.Passkey
        MCourriel = Etudiant.Courriel
    End Sub

    Public Sub New(ByVal Nom As String, ByVal Pre As String, ByVal Pro As String,
                   ByRef Nai As Date, ByVal Key As String, ByVal Cou As String)
        MNom = Nom
        MPrenom = Pre
        MProgramme = Pro
        Try
            MNaissance = Nai
        Catch ex As System.InvalidCastException
            MNaissance = ConvertDate(Nai)
        End Try
        MPasskey = Key
        MCourriel = Cou

        'On génère la matricule.
        GenMatricule()
    End Sub

    Private Sub GenMatricule()
        'On vide la matricule.
        MMatricule = vbNullString

        'On génère les trois premières lettres.
        For i As Integer = 0 To If(MNom.Length < 3, MNom.Length, 2)
            MMatricule += MNom.Chars(i)
        Next

        'On génère les trois premières lettres.
        For i As Integer = 0 To If(MPrenom.Length < 3, MPrenom.Length, 3) - 1
            MMatricule += MPrenom.Chars(i)
        Next

        'On ajout l'année de naissance à la matricule.
        MMatricule += Naissance.Year.ToString
        MMatricule = MMatricule.ToLower
    End Sub

    Private Function ConvertDate(ByVal StrDate As String) As DateTime
        If StrDate.Length = 5 Then
            StrDate = "0" + StrDate
        End If

        If StrDate.Length <> 6 Then
            Throw New FormatException("Invalid date format")
        End If

        Return DateTime.ParseExact(StrDate, "yyMMdd", System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat)
    End Function

    Public ReadOnly Property Matricule As String
        Get
            Return MMatricule
        End Get
    End Property

    Public Property Nom As String
        Get
            Return MNom
        End Get
        Set(value As String)
            MNom = value
        End Set
    End Property

    Public Property Prenom As String
        Get
            Return MPrenom
        End Get
        Set(value As String)
            MPrenom = value
        End Set
    End Property

    Public Property Programme As String
        Get
            Return MProgramme
        End Get
        Set(value As String)
            MProgramme = value
        End Set
    End Property

    Public Property Naissance As Date
        Get
            Return MNaissance
        End Get
        Set(value As Date)
            MNaissance = value
        End Set
    End Property

    Public Property Passkey As String
        Get
            Return MPasskey
        End Get
        Set(value As String)
            MPasskey = value
        End Set
    End Property

    Public Property Courriel As String
        Get
            Return MCourriel
        End Get
        Set(value As String)
            MCourriel = value
        End Set
    End Property
End Class
