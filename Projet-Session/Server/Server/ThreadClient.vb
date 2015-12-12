Imports System.Net.Sockets
Imports System.Threading

Public Class ThreadClient
    Dim Authentification As New Authentification
    Dim Utilisateur As Etudiant
    Dim Parent As Server
    Dim MSocket As Socket
    Dim MThread As Thread
    Dim Mutex As New Mutex

    Private Sub Log(ByVal Message As String)
        'On écrit le message dans la console.
        Parent.Log("[" & MThread.Name & "] " & Message)
    End Sub

    Public Sub New(ByRef Server As Server, ByRef Socket As Socket, ByRef Name As String)
        Parent = Server
        MSocket = Socket
        MThread = New Thread(AddressOf Listen)
        MThread.Name = Name
    End Sub

    Public Sub Start()
        'On démarre la thread.
        MThread.Start()

        Log("New client connected from " & MSocket.RemoteEndPoint.ToString)
    End Sub

    Public Sub Abort()
        'La connexion fut terminée par le serveur.
        MThread.Abort()
        Close()
    End Sub

    Private Sub Close()
        'On ferme le socket.
        If Mutex.WaitOne(0) Then
            Try
                MSocket.Shutdown(SocketShutdown.Both)
                MSocket.Close()
                Log("Connection closed.")
            Catch ex As Exception
                Mutex.ReleaseMutex()
                Throw ex
            End Try

            'L'utilisation du mutex empêche d'effectué ses étapes deux fois (évènement rare).
            Mutex.ReleaseMutex()
        End If
    End Sub

    Private Sub Listen()
        Dim Request As DataTransfert

        'On boucle à l'infini pour effectuer le plus de communications possibles.
        While True
            'On attend une commande.
            Try
                Request = NetworkIO.Receive(MSocket)
            Catch ex As System.Runtime.Serialization.SerializationException
                Failure(ErrorType.DeserializationFailed)
                Continue While
            Catch ex As NetworkConnectionLost
                Exit While
            End Try

            'On traite la commande.
            Select Case Request.Command
                Case CommandType.Ping
                    Ping()
                Case CommandType.Authentificate
                    Authentificate(Request.Data)
                Case CommandType.Deauthentificate
                    Deauthentificate()
                Case CommandType.RetrieveInfo
                    RetrieveInfo()
                Case CommandType.AddEtudiant
                    AddEtudiant(Request.Data)
                Case CommandType.ModEtudiant
                    ModEtudiant(Request.Data)
                Case CommandType.ListeEtudiant
                    ListeEtudiant()
                Case CommandType.ListeProgramme
                    ListeProgramme()
                Case Else
                    Failure(ErrorType.UnexpectedCommand)
            End Select
        End While

        'La connexion fut terminée par une erreur ou par le client.
        Close()
        Return
    End Sub

    Private Sub Success(ByRef Data As Object)
        Dim Respond As DataTransfert

        'On envoie la réponse.
        Respond = New DataTransfert(CommandType.Success, Data)
        NetworkIO.Send(MSocket, Respond)
    End Sub

    Private Sub Failure(ByVal Err As ErrorType)
        Dim Respond As DataTransfert

        'On envoie la réponse.
        Respond = New DataTransfert(CommandType.Failure, Err)
        NetworkIO.Send(MSocket, Respond)
    End Sub

    Private Sub Ping()
        Dim Respond As DataTransfert

        'On envoie la réponse.
        Respond = New DataTransfert(CommandType.Pong)
        NetworkIO.Send(MSocket, Respond)
    End Sub

    Private Sub Authentificate(ByRef Auth As Authentification)
        Authentification = Auth
        Authentification.Authentificated = False

        'On regarde si la connection est déjà authentifiée.
        If Authentification.Authentificated Then
            Failure(ErrorType.AlreadyAuthentificated)
            Return
        End If

        'On tente l'authentification au serveur.
        Try
            Log("Trying authentification with matricule " & Auth.Matricule & "...")
            Parent.Authentificate(Authentification)

            Log("Authentification successful.")
            Authentification.Authentificated = True

            'On envoie un message en cas de réussite.
            Success(Nothing)
        Catch ex As AuthentificationFailed
            Log("Authentification failed.")
            Authentification.Authentificated = False

            'On envoie un message en cas d'erreur.
            Failure(ErrorType.WrongCredentials)
            Return
        End Try

        'On recueille l'information de l'utilisateur.
        Utilisateur = Parent.GetEtudiant(Authentification.Matricule)
    End Sub

    Public Sub Deauthentificate()
        Authentification.Authentificated = False
        Log("Deauthentification successful.")

        Success(Nothing)
    End Sub

    Private Sub RetrieveInfo()
        'On regarde si la connection est authentifiée.
        If Not Authentification.Authentificated Then
            Failure(ErrorType.NotAuthentificated)
            Return
        End If

        'On envoie l'information au client.
        Success(Utilisateur)
    End Sub

    Private Sub AddEtudiant(ByRef Data As Etudiant)
        'On tente l'ajout d'un étudiant.
        Try
            Log("Trying to add a new student.")
            Parent.AddEtudiant(Data)
        Catch ex As DatabaseOperationFailed
            Log("Failed to add student.")
            Failure(ErrorType.PrimaryKeyExist)
            Return
        End Try
        Log("Student " & Data.Prenom & " " & Data.Nom & " was added to the database.")

        'On envoie la réponse.
        Success(Data.Matricule)
    End Sub

    Private Sub ModEtudiant(ByRef Data As Etudiant)
        'On regarde si la connection est authentifiée.
        If Not Authentification.Authentificated Then
            Failure(ErrorType.NotAuthentificated)
            Return
        End If

        'On tente l'ajout.
        Try
            Log("Trying to update a profile.")
            Parent.ModEtudiant(Data)
        Catch ex As DatabaseOperationFailed
            Log("Failed to update a profile.")
            Failure(ErrorType.OperationFailed)
            Return
        End Try
        Log("Student " & Data.Prenom & " " & Data.Nom & " updated his profile.")

        'On update la copie locale.
        Utilisateur = Parent.GetEtudiant(Authentification.Matricule)

        'On envoie la réponse.
        Success(Utilisateur)
    End Sub

    Private Sub ListeEtudiant()
        Dim List As DataTable

        'On regarde si la connection est authentifiée.
        If Not Authentification.Authentificated Then
            Failure(ErrorType.NotAuthentificated)
            Return
        End If

        Try
            List = Parent.GetAllEtudiant()
        Catch ex As Exception
            Return
        End Try

        Success(List)
    End Sub

    Private Sub ListeProgramme()
        Dim Programmes As DataTable

        'On obtient les programmes disponibles.
        Programmes = Parent.GetProgrammes()

        'On envoie la réponse.
        Success(Programmes)
    End Sub

    Public ReadOnly Property IsAlive As Boolean
        Get
            Return MThread.IsAlive
        End Get
    End Property
End Class
