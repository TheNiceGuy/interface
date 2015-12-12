Imports System.Threading

Public Class ErrorHandlerContainer(Of ContainedClass)
    Public ErrorHandler As ContainedClass
End Class

Public Class ErrorHandler
    Public Event DisconnectedEvent()
    Private Mutex As New Mutex

    Public Sub Disconnected()
        'L'utilisation du mutex empêche la création de plusieurs fenêtres d'erreurs.
        If Mutex.WaitOne(0) Then
            RaiseEvent DisconnectedEvent()
            MessageBox.Show("Vous avez été déconnecté.")
            Mutex.ReleaseMutex()
        End If
    End Sub

    Public Sub WorkerFailed(ByVal Err As Exception)
        Try
            Throw Err
        Catch ex As NetworkConnectionClosed
            Disconnected()
        Catch ex As NetworkConnectionLost
            Disconnected()
        Catch ex As NetworkCommandFailed
            Select Case ex.Err
                Case ErrorType.AlreadyAuthentificated
                    MessageBox.Show("Vous êtes déjà authentifié auprès du serveur.")
                Case ErrorType.DeserializationFailed
                Case ErrorType.NotAuthentificated
                Case ErrorType.OperationFailed
                    MessageBox.Show("Une erreur est survenue.")
                Case ErrorType.PrimaryKeyExist
                    MessageBox.Show("La matricule existe déjà dans la base de données. Veuillez contacter un administrateur.")
                Case ErrorType.WrongCredentials
                    MessageBox.Show("La matricule ou le mot de passe sont érronés.")
            End Select
        End Try
    End Sub
End Class
