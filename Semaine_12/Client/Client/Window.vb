Imports System.Net
Imports System.Net.Sockets
Imports System.Text

Public Class Window
    Dim SockSec As Socket
    Dim Connected As Boolean = False

    Private Sub ButtonConnection_Click(sender As Object, e As EventArgs) Handles ButtonConnection.Click
        Dim IP As IPAddress = IPAddress.Parse(TextBoxAddress.Text)

        SockSec = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        SockSec.Connect(IP, TextBoxPort.Text)

        Connected = True
    End Sub

    Private Sub ButtonSend_Click(sender As Object, e As EventArgs) Handles ButtonSend.Click
        Dim Message As Byte()
        Dim ReceivedBytes As Integer
        Dim Buffer(1024) As Byte

        If Not Connected Then
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
