Imports System.Threading

Public Class Form1
    Dim t1 As New System.Threading.Thread(AddressOf test)
    Dim t2 As New System.Threading.Thread(AddressOf test)
    Dim Del As New TextBoxConsoleAccess(AddressOf afficher)

    Private Delegate Sub TextBoxConsoleAccess(ByVal Msg As String)

    Private Sub afficher(ByVal Msg As String)
        TextBoxConsole.Text += Msg
    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Console.WriteLine(t1.Name & " thread principal: " & t1.ThreadState.ToString)
        Console.WriteLine(t2.Name & " thread principal: " & t2.ThreadState.ToString)

        t1.Name = "premier"
        t2.Name = "second"

        t1.Start()
        t2.Start()

        Console.WriteLine(t1.Name & " thread principal: " & t1.ThreadState.ToString)
        Console.WriteLine(t2.Name & " thread principal: " & t2.ThreadState.ToString)
    End Sub

    Sub test()

        Dim i As Integer = 0

        While i <= 20
            TextBoxConsole.Invoke(Del, System.Threading.Thread.CurrentThread.Name & " " & i & vbNewLine)
            i += 1
        End While

        TextBoxConsole.Invoke(Del, System.Threading.Thread.CurrentThread.Name & " dans la méthode: " &
                                   System.Threading.Thread.CurrentThread.ThreadState.ToString & vbNewLine)
    End Sub
End Class
