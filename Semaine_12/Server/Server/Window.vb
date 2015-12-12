Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Window
    Dim SockMain As Socket
    Dim SockSec As Socket
    Dim Started As Boolean = False

    Dim ReceivedBytes As Integer
    Dim Buffer(1024) As Byte

    Private Sub ButtonToggle_Click(sender As Object, e As EventArgs) Handles ButtonToggle.Click
        If Started Then
            Started = False
            ServerStop()
        Else
            Started = True
            ServerStart()
        End If
    End Sub

    Private Sub ServerStart()
        Dim IP As IPAddress = IPAddress.Parse("127.0.0.1")
        Dim EndPoint As New IPEndPoint(IP, 5001)

        SockMain = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        SockMain.Bind(EndPoint)

        SockMain.Listen(1)
        SockSec = SockMain.Accept()

        TextBoxInput.Text = SockSec.RemoteEndPoint.ToString

        'While True
        ReceivedBytes = SockSec.Receive(Buffer)
        TextBoxInput.Text = Encoding.ASCII.GetString(Buffer, 0, ReceivedBytes)
        'End While
    End Sub

    Private Sub ServerStop()
        SockSec.Shutdown(SocketShutdown.Both)
        SockMain.Close()
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        Dim Message As Byte()

        If Not Started Then
            MessageBox.Show("Veuillez vous connecter.")
            Return
        End If

        If TextBoxOutput.Text.Trim = vbNullString Then
            MessageBox.Show("Veuillez écrire un message.")
            Return
        End If

        Message = System.Text.Encoding.ASCII.GetBytes(TextBoxOutput.Text)

        SockSec.Send(Message, Message.Length, SocketFlags.None)

        ReceivedBytes = SockSec.Receive(Buffer)
        TextBoxInput.Text = Encoding.ASCII.GetString(Buffer, 0, ReceivedBytes)
    End Sub
End Class
