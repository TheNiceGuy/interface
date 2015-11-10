Imports System.Data.OleDb

Public Class DataBase
    Dim Connection As OleDbConnection
    Dim ConnectionString As String
    Dim Adapter As OleDbDataAdapter
    Dim DataSet As New DataSet
    Dim Builder As OleDbCommandBuilder

    Public Function Connect(ByVal Path As String) As Boolean
        ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" & Path
        Connection = New OleDbConnection(ConnectionString)

        Try
            'On vérifie la connection à la base de données.
            Connection.Open()
            Connection.Close()

            'On télécharge la base de données.
            Fill()
        Catch ex As System.Data.OleDb.OleDbException
            MessageBox.Show("La base de données est soit invalide ou corrompu. Veuillez vérifier l'intégrité de votre base de données.")
            Return False
        End Try

        Return True
    End Function

    Private Sub Fill()
        'On télécharge la table Article.
        Adapter = New OleDbDataAdapter("SELECT * FROM Article", Connection)
        Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Adapter.Fill(DataSet, "Article")

        'On télécharge la table Commande.
        Adapter = New OleDbDataAdapter("SELECT * FROM Commande", Connection)
        Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Adapter.Fill(DataSet, "Commande")

        'On télécharge la table Fournisseur.
        Adapter = New OleDbDataAdapter("SELECT * FROM Fournisseur", Connection)
        Adapter.MissingSchemaAction = MissingSchemaAction.AddWithKey
        Adapter.Fill(DataSet, "Fournisseur")
    End Sub

    Public Function AddArticle(ByRef NewArticle As Article) As Integer
        Dim Row As DataRow = Articles.NewRow()

        'On l'ajoute dans le tableau de données.
        Row("Numero") = 0
        Row("Nom") = NewArticle.Nom
        Row("Prix") = NewArticle.Prix
        Row("Quantite") = NewArticle.Quantite
        Row("Fournisseur") = NewArticle.Fournisseur

        'On crée la requête SQL.
        Adapter = New OleDbDataAdapter("SELECT * FROM Article", Connection)
        Builder = New OleDbCommandBuilder(Adapter)

        'On ajoute l'article à la base de données.
        Articles.Rows.Add(Row)
        Adapter.Update(Articles)

        'On actualise la base de données afin d'obtenir la clé primaire du nouveau article.
        DataSet.Clear()
        Fill()

        'On retourne la clé primaire.
        Return Articles(Articles.Rows.Count - 1)(0)
    End Function

    Public Function AddCommande(ByRef Commande As Commande) As Integer
        Dim Row As DataRow = Commandes.NewRow()

        'On l'ajoute dans le tableau de données.
        Row("idCommande") = 0
        Row("DateCommande") = Commande.PurchasedDate
        Row("Article") = Commande.Article
        Row("Fournisseur") = Commande.Fournisseur
        Row("Quantite") = Commande.Quantite
        Row("PrixUnitaire") = Commande.PrixUnitaire
        Row("PrixTotal") = Commande.PrixTotal

        'On crée la requête SQL.
        Adapter = New OleDbDataAdapter("SELECT * FROM Commande", Connection)
        Builder = New OleDbCommandBuilder(Adapter)

        'On ajoute la commande à la base de données.
        Commandes.Rows.Add(Row)
        Adapter.Update(Commandes)

        'On actualise la base de données afin d'obtenir la clé primaire de la nouvelle commande.
        DataSet.Clear()
        Fill()

        'On retourne la clé primaire.
        Return Commandes(Commandes.Rows.Count - 1)(0)
    End Function

    Public ReadOnly Property Articles As DataTable
        Get
            Return DataSet.Tables("Article")
        End Get
    End Property

    Public ReadOnly Property Commandes As DataTable
        Get
            Return DataSet.Tables("Commande")
        End Get
    End Property

    Public ReadOnly Property Fournisseurs As DataTable
        Get
            Return DataSet.Tables("Fournisseur")
        End Get
    End Property

End Class