Public Class Server
    Dim State As Boolean = False
    Dim Database As New Database
    Dim Networking As Networking

    Public Event EventLog(ByVal Message As String)

    Public Sub Log(ByVal Message As String)
        'On écrit le message dans la console.
        Console.WriteLine(Date.Now & " : " & Message)

        'On execute l'évènement.
        RaiseEvent EventLog(Date.Now & " : " & Message)
    End Sub

    Public Sub New()
        Networking = New Networking(Me)
    End Sub

    Public Sub Bootstrap(ByRef DatabasePath As String, ByVal Addresse As String, ByVal Port As Integer)
        'On s'assure que le serveur n'est pas déjà démarré.
        If State Then
            Throw New ServerOperationFailed("The server is already running.")
        End If

        Log("Bootstrapping the server.")

        Try
            'On tente d'établier une connexion avec la base de données.
            Database.Connect(DatabasePath)

            'On ouvre la connexion au serveur.
            Networking.Start(Addresse, Port)
        Catch ex As DatabaseOperationFailed
            Throw New ServerOperationFailed("Database operation failed.", ex)
        Catch ex As NetworkingOperationFailed
            Throw New ServerOperationFailed("Networking operation error.", ex)
        End Try

        Log("Server succesfully bootstrapped.")
        State = True
    End Sub

    Public Sub Shutdown()
        'On s'assure que le serveur est démarré.
        If Not State Then
            Throw New ServerOperationFailed("The server is not running.")
        End If

        Log("Sending the shutdown signal to the server.")

        'On ferme les connections.
        Networking.Shutdown()

        Log("Server succesfully stopped.")
        State = False
    End Sub

    Public Sub Authentificate(ByRef Auth As Authentification)
        'On regarde si la matricule existe.
        If Not Database.Etudiants.Rows.Contains(Auth.Matricule) Then
            Throw New AuthentificationFailed("The matricule does not exist in the database.")
        End If

        'On regarde si le mot de passe est correcte.
        If Not Database.Etudiants.Rows.Find(Auth.Matricule)("Hash") = Authentification.EncryptPassword(Auth.Pass) Then
            Throw New AuthentificationFailed("The password is incorrect.")
        End If
    End Sub

    Public Sub AddEtudiant(ByRef Data As Etudiant)
        'On s'assure que le serveur est ouvert.
        If Not Status Then
            Throw New ServerOperationFailed("The server is closed.")
        End If

        'On ajoute l'étudiant dans la base de données.
        Database.AddEtudiant(Data)
    End Sub

    Public Sub ModEtudiant(ByRef Data As Etudiant)
        'On s'assure que le serveur est ouvert.
        If Not Status Then
            Throw New ServerOperationFailed("The server is closed.")
        End If

        Database.ModEtudiant(Data)
    End Sub

    Public Function GetProgrammes() As DataTable
        Dim Table As DataTable = GetAllEtudiant()

        'On s'assure que le serveur est ouvert.
        If Not Status Then
            Throw New ServerOperationFailed("The server Is closed.")
        End If
        Return Database.Programmes
    End Function

    Public Function GetEtudiant(ByVal Matricule As String) As Etudiant
        Dim Etudiant As New Etudiant(Database.Etudiants.Rows.Find(Matricule)("Nom"),
                                     Database.Etudiants.Rows.Find(Matricule)("Prénom"),
                                     Database.Etudiants.Rows.Find(Matricule)("Programme"),
                                     Database.Etudiants.Rows.Find(Matricule)("Naissance"),
                                     vbNullString,
                                     Database.Etudiants.Rows.Find(Matricule)("Courriel"))

        'On retourne l'informations.
        Return Etudiant
    End Function

    Public Function GetAllEtudiant() As DataTable
        Dim Table As New DataTable
        Dim Row As DataRow

        'On intègre les trois colonnes dans la table.
        Table.Columns.Add("Étudiant", GetType(String))
        Table.Columns.Add("Programme", GetType(String))
        Table.Columns.Add("Courriel", GetType(String))

        'On ajoute les colonne
        For Each Row In Database.Etudiants.Rows
            Table.Rows.Add(Row.Item("Prénom") & " " & Row.Item("Nom"), Row.Item("Programme"), Row.Item("Courriel"))
        Next

        'On retourne la table.
        Return Table
    End Function

    Public Sub StackTrace(ex As Exception)
        Dim Counter As Integer = 0

        'On écrit recursivement chaque erreur dans l'exception.
        While ex IsNot Nothing
            Log("[" & Format(Counter, "00") & "]" & " " & ex.Message)
            Counter += 1
            ex = ex.InnerException
        End While
    End Sub

    Public ReadOnly Property Status As Boolean
        Get
            Return State
        End Get
    End Property

    Public ReadOnly Property Network As Networking
        Get
            Return Networking
        End Get
    End Property
End Class
