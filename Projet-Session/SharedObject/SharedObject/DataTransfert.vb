<Serializable> Public Enum CommandType As Integer
    AddEtudiant
    ModEtudiant
    ListeEtudiant
    ListeProgramme
    Authentificate
    Deauthentificate
    RetrieveInfo
    Ping
    Pong
    Success
    Failure
End Enum

<Serializable> Public Enum ErrorType As Integer
    WrongCredentials
    AlreadyAuthentificated
    NotAuthentificated
    DeserializationFailed
    PrimaryKeyExist
    OperationFailed
    UnexpectedCommand
End Enum

<Serializable> Public Class DataTransfert
    Dim MData As Object
    Dim MCommand As CommandType
    Dim MErr As ErrorType

    Public Sub New(ByVal Command As CommandType)
        MData = Nothing
        MCommand = Command
        MErr = Nothing
    End Sub

    Public Sub New(ByVal Command As CommandType, ByRef Data As Object)
        MData = Data
        MCommand = Command
        MErr = Nothing
    End Sub

    Public Sub New(ByVal Command As CommandType, ByVal Err As ErrorType)
        MData = Nothing
        MCommand = Command
        MErr = Err
    End Sub

    Public ReadOnly Property Command As CommandType
        Get
            Return MCommand
        End Get
    End Property

    Public ReadOnly Property Data As Object
        Get
            Return MData
        End Get
    End Property

    Public ReadOnly Property Err As ErrorType
        Get
            Return MErr
        End Get
    End Property
End Class
