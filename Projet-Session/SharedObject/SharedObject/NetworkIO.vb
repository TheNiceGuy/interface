Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary

Public Class NetworkIO
    Shared Sub Send(ByRef Socket As Socket, ByRef Data As Object)
        Dim Stream As New MemoryStream
        Dim Serializer As New BinaryFormatter
        Dim Buffer() As Byte

        'On sérialize le requête.
        Serializer.Serialize(Stream, Data)
        Stream.Close()

        'On envoit la requête au serveur.
        Try
            Buffer = Stream.ToArray()
            Socket.Send(Buffer, Buffer.Length, SocketFlags.None)
        Catch ex As System.Net.Sockets.SocketException
            Throw New NetworkConnectionLost("Could not send bytes to the endpoint.", ex)
        End Try
    End Sub

    Shared Function Receive(ByRef Socket As Socket) As Object
        Dim Stream As MemoryStream
        Dim Deserializer As New BinaryFormatter
        Dim Buffer(Config.BufferLength) As Byte
        Dim Length As Integer
        Dim Respond As Object


        Try
            'On recoit la réponse du serveur.
            Length = Socket.Receive(Buffer)
            Stream = New MemoryStream(Buffer)

            'On désérialise la réponse.
            Respond = Deserializer.Deserialize(Stream)
            Stream.Close()
        Catch ex As System.Net.Sockets.SocketException
            Throw New NetworkConnectionLost("Could not receive bytes from the endpoint.", ex)
        Catch ex As System.Runtime.Serialization.SerializationException
            Throw New NetworkConnectionLost("Could not deserialize bytes from the end point.", ex)
        End Try

        Return Respond
    End Function
End Class
