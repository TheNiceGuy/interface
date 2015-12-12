Imports System.Threading

Public Class Worker
    Dim NetworkContainer As NetworkingContainer(Of Networking)
    Dim Thread As Thread
    Dim ReturnedData As Object

    Public Event JobFinished(ByVal Data As Object)
    Public Event JobFailed(ByVal Err As Exception)

    Public Sub New(ByVal Container As NetworkingContainer(Of Networking))
        NetworkContainer = Container
        Thread = New Thread(AddressOf Execute)
    End Sub

    Public Sub Work(ByVal Command As CommandType)
        Work(Command, Nothing)
    End Sub

    Public Sub Work(ByVal Command As CommandType, ByRef Data As Object)
        Thread.Start(New Object() {Command, Data})
    End Sub

    Private Sub Execute(ByVal Obj As Object)
        Try
            ReturnedData = NetworkContainer.Networking.ExecuteCommand(Obj(0), Obj(1))
        Catch ex As Exception
            RaiseEvent JobFailed(ex)
        End Try

        RaiseEvent JobFinished(ReturnedData)
    End Sub
End Class
