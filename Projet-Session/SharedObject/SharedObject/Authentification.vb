Imports System.Security.Cryptography

<Serializable> Public Class Authentification
    Dim MMatricule As String
    Dim MPass As String
    Dim MAuthentificated As Boolean

    Public Sub New()
        MMatricule = vbNullString
        MPass = vbNullString
        MAuthentificated = False
    End Sub

    Public Sub New(ByVal Matricule As String, ByVal Pass As String)
        MMatricule = Matricule
        MPass = Pass
        MAuthentificated = False
    End Sub

    Shared Function EncryptPassword(ByVal Key As String) As String
        Dim HashByte() As Byte
        Dim Sha512 As New SHA512Managed

        'On encrypte le mot de passe et on le convertit en base 64.
        HashByte = Sha512.ComputeHash(System.Text.Encoding.Unicode.GetBytes(Key))
        Return Convert.ToBase64String(HashByte)
    End Function

    Public ReadOnly Property Matricule As String
        Get
            Return MMatricule
        End Get
    End Property

    Public ReadOnly Property Pass As String
        Get
            Return MPass
        End Get
    End Property

    Public Property Authentificated As Boolean
        Get
            Return MAuthentificated
        End Get
        Set(value As Boolean)
            MAuthentificated = value
        End Set
    End Property
End Class
