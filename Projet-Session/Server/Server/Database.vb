Imports System.Data.OleDb

Public Class Database
    Dim Connexion As OleDbConnection
    Dim Adapter As OleDbDataAdapter
    Dim Builder As OleDbCommandBuilder
    Dim DataSet As New DataSet

    Public Sub Connect(ByRef Path As String)
        Dim ConnexionString As String

        ConnexionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Path
        Connexion = New OleDbConnection(ConnexionString)

        'On vérifie la connection à la base de données.
        Try
            Connexion.Open()
            Connexion.Close()
        Catch ex As System.Data.OleDb.OleDbException
            Throw New DatabaseOperationFailed("Could not open the database.", ex)
        End Try

        'On télécharge la base de données.
        Try
            Fill()
        Catch ex As System.Data.OleDb.OleDbException
            Throw New DatabaseOperationFailed("Could not download the database.", ex)
        End Try
    End Sub

    Private Sub Fill()
        'On télécharge la table Étudiants.
        Adapter = New OleDbDataAdapter("SELECT * FROM Étudiants", Connexion)
        Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Adapter.Fill(DataSet, "Étudiants")

        'On assigne la colonne matricule comme contenant les clées primaires.
        DataSet.Tables("Étudiants").PrimaryKey = New DataColumn() {DataSet.Tables("Étudiants").Columns("Matricule")}

        'On télécharge la table Programmes.
        Adapter = New OleDbDataAdapter("SELECT * FROM Programmes", Connexion)
        Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Adapter.Fill(DataSet, "Programmes")
    End Sub

    Public Sub AddEtudiant(ByRef NewEtudiant As Etudiant)
        Dim Row As DataRow = Etudiants.NewRow()

        'On l'ajoute dans le tableau de données.
        Row("Matricule") = NewEtudiant.Matricule
        Row("Nom") = NewEtudiant.Nom
        Row("Prénom") = NewEtudiant.Prenom
        Row("Programme") = NewEtudiant.Programme
        Row("Naissance") = NewEtudiant.Naissance
        Row("Hash") = Authentification.EncryptPassword(NewEtudiant.Passkey)
        Row("Courriel") = NewEtudiant.Courriel

        'On crée la requête SQL.
        Adapter = New OleDbDataAdapter("SELECT * FROM Étudiants", Connexion)
        Builder = New OleDbCommandBuilder(Adapter)

        'On ajoute l'article à la base de données.
        Try
            Etudiants.Rows.Add(Row)
            Adapter.Update(Etudiants)
        Catch ex As System.Data.ConstraintException
            Throw New DatabaseOperationFailed("Could not add a new row in the database.", ex)
        End Try
    End Sub

    Public Sub ModEtudiant(ByRef Etudiant As Etudiant)
        If Not Etudiant.Programme = Nothing Then
            Etudiants.Rows.Find(Etudiant.Matricule)("Programme") = Etudiant.Programme
        End If

        If Not Etudiant.Passkey = Nothing Then
            Etudiants.Rows.Find(Etudiant.Matricule)("Hash") = Authentification.EncryptPassword(Etudiant.Passkey)
        End If

        If Not Etudiant.Courriel = Nothing Then
            Etudiants.Rows.Find(Etudiant.Matricule)("Courriel") = Etudiant.Courriel
        End If

        'On crée la requête SQL.
        Adapter = New OleDbDataAdapter("SELECT * FROM Étudiants", Connexion)
        Builder = New OleDbCommandBuilder(Adapter)

        'On ajoute l'article à la base de données.
        Try
            Adapter.Update(Etudiants)
        Catch ex As System.Data.ConstraintException
            Throw New DatabaseOperationFailed("Could not update database.", ex)
        End Try
    End Sub

    Public ReadOnly Property Etudiants As DataTable
        Get
            Return DataSet.Tables("Étudiants")
        End Get
    End Property

    Public ReadOnly Property Programmes As DataTable
        Get
            Return DataSet.Tables("Programmes")
        End Get
    End Property
End Class
