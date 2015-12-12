Imports System.Threading

Public Class Window
    Dim Rand As New Random()
    Dim ValueMin As Integer = 0
    Dim ValueMax As Integer = 500
    Dim Value As Integer = Rand.Next(ValueMin, ValueMax)
    Dim TimerValue As Double = 0
    Dim TimerValueMax As Double = 20000
    Dim TimerThread As New Thread(AddressOf Timer)
    Dim TimerThreadQuit As Boolean = False
    Dim DelProgressBar As New ProgressBarAccess(AddressOf ProgressBarUpdate)
    Dim DelLabe As New LabelAccess(AddressOf LabelUpdate)

    Private Delegate Sub ProgressBarAccess(ByVal Progress As Double)
    Private Delegate Sub LabelAccess(ByVal Text As String)

    Private Sub ProgressBarUpdate(ByVal Progress As Double)
        ProgressBar.Value = Progress
    End Sub

    Private Sub LabelUpdate(ByVal Text As String)

    End Sub

    Private Sub Timer()
        While TimerValue < TimerValueMax
            ProgressBar.Invoke(DelProgressBar, TimerValue)
            Thread.Sleep(1)
            TimerValue += 1

            If TimerThreadQuit Then
                Exit While
            End If
        End While

        If TimerValue > TimerValueMax Then

        End If
    End Sub

    Private Sub Window_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProgressBar.Minimum = 0
        ProgressBar.Maximum = TimerValueMax
        NumericUpDown.Minimum = ValueMin
        NumericUpDown.Maximum = ValueMax

        TimerThread.Start()
    End Sub

    Private Sub Window_Quit(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        TimerThreadQuit = True
        TimerThread.Abort()
    End Sub

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        If Value < NumericUpDown.Value Then
            LabelJeu.Text = "Le nombre est plus petit."
        ElseIf Value > NumericUpDown.Value Then
            LabelJeu.Text = "Le nombre est plus grand."
        Else
            LabelJeu.Text = "Bravo, vous avez wreck la bombe."
            TimerThreadQuit = True
            Button.Enabled = False
        End If
    End Sub

    Private Sub NumericUpDown_KeyPressed(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles NumericUpDown.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button_Click(sender, e)
        End If
    End Sub
End Class
