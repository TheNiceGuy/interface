Imports System.Threading

Public Class ConnexionMecanisme
    Dim NetworkContainer As NetworkingContainer(Of Networking)
    Dim OptionsContainer As OptionsContainer(Of Options)
    Dim ErrorHandlerContainer As ErrorHandlerContainer(Of ErrorHandler)
    Public Thread As New Thread(AddressOf PeriodicExceptionCatcher)

    Public Event EventConnectedState(ByVal State As Boolean)
    Public Event EventTimer(ByVal Text As String)

    Public Sub New(ByVal NetContainer As NetworkingContainer(Of Networking),
                   ByVal OpContainer As OptionsContainer(Of Options),
                   ByVal ErrContainer As ErrorHandlerContainer(Of ErrorHandler))
        NetworkContainer = NetContainer
        OptionsContainer = OpContainer
        ErrorHandlerContainer = ErrContainer
    End Sub

    Public Sub StartPeriodicConnection()
        'On s'assure que le mécanisme de connexion n'est pas déjà en fonction.
        If Thread.ThreadState = ThreadState.Running Or
           Thread.ThreadState = ThreadState.WaitSleepJoin Then
            Return
        End If

        'On démarre la thread.
        Thread = New Thread(AddressOf PeriodicExceptionCatcher)
        Thread.Start()
    End Sub

    Public Sub StopPeriodicConnection()
        'On ferme la thread.
        Thread.Abort()
    End Sub

    Private Sub PeriodicExceptionCatcher()
        While True
            Try
                PeriodicConnection()
                PeriodicPoll()
            Catch ex As System.ObjectDisposedException
                'On ignore l'exception si un Invoke() est executé lorsque la fenêtre est fermée.
            End Try
        End While
    End Sub

    Private Sub PeriodicConnection()
        'On boucle tant et aussi longtemps que la connexion n'est pas établie.
        While Not NetworkContainer.Networking.Connected
            RaiseEvent EventConnectedState(False)
            RaiseEvent EventTimer("Trying connection...")

            'On tente la connexion.
            If TryConnection() Then
                Exit While
            End If

            'On actualise le StatusStrip.
            For Time As Integer = 5 To 1 Step -1
                RaiseEvent EventTimer("Retrying connection in " & Time & " seconds...")
                Thread.Sleep(1000)
            Next
        End While
        RaiseEvent EventTimer("Connected")
    End Sub

    Private Sub PeriodicPoll()
        'On boucle tant et aussi longtemps que la connexion est établie.
        While NetworkContainer.Networking.Connected
            'On teste la connexion.
            If Not PollConnection() Then
                Exit While
            End If

            'On attend avant de tester la connexion à nouveau.
            Thread.Sleep(5000)
        End While
    End Sub

    Private Function TryConnection() As Boolean
        'On regarde si on est connecté.
        If NetworkContainer.Networking.Connected Then
            Return True
        End If

        Try
            'On essaie de démarrer la connexion.
            NetworkContainer.Networking.Start(OptionsContainer.Options.Addresse, OptionsContainer.Options.Port)

            'On active l'inscription si la connexion au serveur est établie.
            RaiseEvent EventConnectedState(True)
            Return True
        Catch ex As System.Net.Sockets.SocketException
            'On désactive l'inscription si la connexion au serveur n'est pas établie.
            RaiseEvent EventConnectedState(False)
            Return False
        Catch ex As System.FormatException
            'On désactive l'inscription si la connexion au serveur n'est pas établie.
            RaiseEvent EventConnectedState(False)
            Return False
        End Try
    End Function

    Private Function PollConnection() As Boolean
        'On regarde si on est connecté.
        If Not NetworkContainer.Networking.Connected Then
            Return False
        End If

        'On regarde si l'utilisateur a changé les options.
        If OptionsContainer.Options.Updated Then
            NetworkContainer.Networking.Shutdown()
            OptionsContainer.Options.Updated = False
            Return False
        End If

        'On teste la connexion avec le serveur.
        Try
            NetworkContainer.Networking.Poll()
            Return True
        Catch ex As NetworkConnectionClosed
            ErrorHandlerContainer.ErrorHandler.Disconnected()
            Return False
        Catch ex As NetworkConnectionLost
            ErrorHandlerContainer.ErrorHandler.Disconnected()
            Return False
        End Try
    End Function
End Class
