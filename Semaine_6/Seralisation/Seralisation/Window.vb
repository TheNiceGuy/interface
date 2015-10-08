Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

Public Class Window
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Client As New Client(TextBox1.Text, TextBox2.Text)

        Save(Client, "thatfile.bin")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Client As Client = Open("thatfile.bin")

        TextBox1.Text = Client.Nom
        TextBox2.Text = Client.Prenom
    End Sub

    Public Function Save(ByVal Obj As Object, ByVal File As String) As Boolean
        Dim Stream As FileStream
        Dim Serializer As New BinaryFormatter

        If Obj Is Nothing Then
            Return False
        End If

        Stream = New FileStream(File, FileMode.Create)

        Serializer.Serialize(Stream, Obj)
        Stream.Close()

        Return True
    End Function

    Public Function Open(ByVal File As String) As Object
        Dim Stream As FileStream = New FileStream(File, FileMode.Open)
        Dim Obj As Object = Nothing
        Dim Deserializer As New BinaryFormatter

        Obj = Deserializer.Deserialize(Stream)
        Stream.Close()

        Return Obj
    End Function
End Class
