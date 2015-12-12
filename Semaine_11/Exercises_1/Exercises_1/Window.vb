Imports System.Threading
Imports System.Math

Public Class Window
    Dim ThreadTimer As Thread
    Dim ThreadTimerRunning As Boolean = False
    Dim DelegateTimer As New LabelTimerAccess(AddressOf ChangeTimer)
    Dim CurrentTime As Integer = 0

    Private Delegate Sub LabelTimerAccess(ByVal Time As Integer)

    Private Sub ChangeTimer(ByVal Time As Integer)
        If Time = 0 Then
            LabelTimer.Text = Format(00, "00") & ":" & Format(00, "00")
        Else
            LabelTimer.Text = Format(Floor(Time / 60), "00") & ":" & Format(Time - Floor(Time / 60) * 60, "00")
        End If
    End Sub

    Private Sub Timer()
        While True
            LabelTimer.Invoke(DelegateTimer, CurrentTime)
            Thread.Sleep(1000)
            CurrentTime += 1
        End While
    End Sub

    Private Sub ButtonToggle_Click(sender As Object, e As EventArgs) Handles ButtonToggle.Click
        If Not ThreadTimerRunning Then
            ThreadTimer = New Thread(AddressOf Timer)

            ThreadTimer.Start()
            ThreadTimerRunning = True
        Else
            ThreadTimer.Abort()
            ThreadTimerRunning = False
        End If

    End Sub

    Private Sub ButtonAdd_Click(sender As Object, e As EventArgs) Handles ButtonAdd.Click
        Dim Time As Integer = NumericUpDownAdd.Value

        Interlocked.Add(CurrentTime, Time)
    End Sub

    Private Sub Window_Close(sender As Object, e As EventArgs) Handles Me.FormClosing
        If ThreadTimerRunning Then
            ThreadTimer.Abort()
            ThreadTimerRunning = False
        End If
    End Sub
End Class
