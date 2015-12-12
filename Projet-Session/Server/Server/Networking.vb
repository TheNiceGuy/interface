Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class Networking
    Dim Parent As Server
    Dim SocketMain As Socket
    Dim ThreadMain As Thread
    Dim ThreadList As New ArrayList

    Public Sub New(ByRef Server As Server)
        Parent = Server
    End Sub

    Public Sub Start(ByVal Addresse As String, ByVal Port As Integer)
        Dim IP As IPAddress = IPAddress.Parse(Addresse)
        Dim EndPoint As New IPEndPoint(IP, Port)

        'On configure la connexion.
        Try
            SocketMain = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
            SocketMain.Bind(EndPoint)
        Catch ex As System.Net.Sockets.SocketException
            Throw New NetworkingOperationFailed("Could not bind the main socket.", ex)
        End Try

        'On démarre la thread pour écouter les connexions.
        ThreadMain = New Thread(AddressOf Listen)
        ThreadMain.Start()
    End Sub

    Public Sub Shutdown()
        'On ferme toutes les connexions.
        For i As Integer = 0 To ThreadList.Count - 1
            'On s'assure que la connexions n'est pas déjà fermée.
            If ThreadList(i).IsAlive() Then
                ThreadList(i).Abort()
            End If
        Next

        'On ferme le socket et la thread.
        SocketMain.Close()
        ThreadMain.Join()
    End Sub

    Private Sub Listen()
        Dim Name As String

        'On boucle à l'infini pour effectuer le plus de communications possibles.
        While True
            Name = "ThreadClient" & Format(ThreadList.Count, "00")

            'On attend une connexion.
            Try
                SocketMain.Listen(1)
                ThreadList.Add(New ThreadClient(Parent, SocketMain.Accept(), Name))
            Catch ex As System.Net.Sockets.SocketException
                Exit While
            End Try

            'On démarre la thread du nouveau client.
            ThreadList(ThreadList.Count - 1).Start()
        End While
    End Sub
End Class
