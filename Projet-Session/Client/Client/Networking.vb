Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class NetworkingContainer(Of ContainedClass)
    Public Networking As ContainedClass
End Class

Public Class Networking
    Dim Socket As New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    Dim Mutex As New Mutex
    Dim NetworkConnected As Boolean = False

    Public Sub Start(ByVal Addresse As String, ByVal Port As Integer)
        Dim IP As IPAddress = IPAddress.Parse(Addresse)

        'On s'assure que la connection est fermé.
        If NetworkConnected Then
            Throw New InvalidOperationException("The connection is already opened.")
        End If

        'On établit la connection avec le server.
        Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Socket.Connect(IP, Port)

        'On marque le serveur comme connecté.
        NetworkConnected = True
    End Sub

    Public Sub Shutdown()
        'On ferme le socket.
        Socket.Disconnect(False)
        Socket.Close()

        'On marque le serveur comme déconnecté.
        NetworkConnected = False
    End Sub

    Private Function Interact(ByRef Data As DataTransfert) As DataTransfert
        Dim Respond As DataTransfert

        'On vérifie que la connexion est encore ouverte.
        If Not NetworkConnected Then
            Throw New NetworkConnectionClosed("The connection is closed.")
        End If

        'On assigne un time out.
        Socket.ReceiveTimeout = Config.TimeOut
        Socket.SendTimeout = Config.TimeOut

        Mutex.WaitOne()
        Try
            'On envoie les données au serveur.
            NetworkIO.Send(Socket, Data)

            'On attend de recevoir une réponse du serveur.
            Respond = NetworkIO.Receive(Socket)
        Catch ex As NetworkConnectionClosed
            NetworkConnected = False
            Mutex.ReleaseMutex()
            Throw ex
        Catch ex As NetworkConnectionLost
            NetworkConnected = False
            Mutex.ReleaseMutex()
            Throw ex
        Catch ex As Exception
            'On s'assure de libérer le mutex si une exception survient.
            Mutex.ReleaseMutex()
            Throw ex
        End Try
        Mutex.ReleaseMutex()

        'On gère la réponse.
        If Respond.Command = CommandType.Failure Then
            Throw New NetworkCommandFailed(Respond.Err)
        End If

        Return Respond
    End Function

    Public Function ExecuteCommand(ByVal Command As CommandType) As Object
        Return ExecuteCommand(Command, Nothing)
    End Function

    Public Function ExecuteCommand(ByVal Command As CommandType, ByRef Data As Object) As Object
        Dim Request As DataTransfert
        Dim Respond As DataTransfert

        Request = New DataTransfert(Command, Data)
        Respond = Interact(Request)

        Return Respond.Data
    End Function

    Public Sub Poll()
        Dim Ping As DataTransfert
        Dim Pong As DataTransfert

        'On envoie la requête.
        Try
            Ping = New DataTransfert(CommandType.Ping)
            Pong = Interact(Ping)
        Catch ex As NetworkCommandFailed
            'La syncronisation avec le mutex aurait mal fonctionné et
            'on obtient une erreur d'une autre commande.
            Debug.WriteLine("Ping failed...")
            Return
        End Try

        'On regarde la réponse.
        If Not Pong.Command = CommandType.Pong Then
            Debug.WriteLine("Wrong response, ignoring...")
        End If
    End Sub

    Public ReadOnly Property Connected As Boolean
        Get
            Return NetworkConnected
        End Get
    End Property
End Class
