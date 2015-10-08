Imports System.Runtime.Serialization.Formatters.Binary
Imports System.IO

<Serializable> Public Class Inventaire
    Dim MItems As New Dictionary(Of Integer, Article)
    Dim MCategorie As New ArrayList
    Dim MLoaded As Boolean = False

    Public Sub Open(ByRef FileIO As FileStream)
        Dim DeserializedObject As New Object
        Dim Deserializer As New BinaryFormatter

        'On desérialize la classe à partir du fichier.'
        DeserializedObject = Deserializer.Deserialize(FileIO)

        MItems = DeserializedObject.Items
        MCategorie = DeserializedObject.Categorie
        MLoaded = True
    End Sub

    Public Sub Save(ByRef FileIO As FileStream)
        Dim Serializer As New BinaryFormatter

        'On sérialize la classe dans le fichier.'
        Serializer.Serialize(FileIO, Me)
    End Sub

    Public Sub Import(ByRef FileIO As StreamReader)
        Dim Numero, Quantite As Integer
        Dim Prix As Double
        Dim Nom, Categorie As String
        Dim Line As String
        Dim LineDebug As Integer = 1
        Dim LineSep() As String
        Dim Article As Article

        'On libère l'inventaire des articles précèdents.'
        Clear()
        Do
            'On line le fichier ligne par ligne.'
            Line = FileIO.ReadLine()

            Try
                'On split la ligne.'
                LineSep = Line.Split(";")

                'On performe les cast nécéssaires pour travailler sur l'information.'
                Numero = LineSep(0)
                Nom = LineSep(1)
                Prix = LineSep(2).Replace("$", vbNullChar).Trim()
                Categorie = LineSep(3).ToLower()
                Quantite = LineSep(4)
            Catch ex As InvalidCastException
                Laboratoire_3.Window.LogDebug("Import(): ligne " & LineDebug & ": mal formattée")
                LineDebug += 1
                Continue Do
            Catch ex As System.IndexOutOfRangeException
                Laboratoire_3.Window.LogDebug("Import(): ligne " & LineDebug & ": incomplète")
                LineDebug += 1
                Continue Do
            Catch ex As System.NullReferenceException
                'La dernière ligne renvoit cette exception, alors on quitte la boucle.'
                Exit Do
            End Try

            'On rajoute l'article dans l'inventaire.'
            Article = New Article(Nom, Prix, Categorie, Quantite)

            Try
                AddCategorie(Categorie)
                AddArticle(LineSep(0), Article)
            Catch ex As System.ArgumentException
                Laboratoire_3.Window.LogDebug("Import(): ligne " & LineDebug & ": le numéro de l'article est déjà prit")
                LineDebug += 1
            End Try

            LineDebug += 1
        Loop While Not Line Is Nothing

        'On marque l'inventaire comme loader.'
        MLoaded = True
    End Sub

    Public Sub Export(ByRef FileIO As StreamWriter)
        'On boucle dans tout les articles de l'inventaire.'
        For Each Numero In MItems.Keys
            'On écrit une ligne pour chaque article.'
            FileIO.WriteLine(Numero & ";" & Items(Numero).Nom & ";" & Items(Numero).Prix & ";" &
                             Items(Numero).Categorie & ";" & Items(Numero).Quantite)
        Next
    End Sub

    Public Sub Clear()
        'On clear la classe.'
        MItems.Clear()
        MCategorie.Clear()
        MLoaded = False
    End Sub

    Public Sub AddArticle(ByVal Numero As Integer, ByVal Article As Article)
        'On ajoute l'article à l'inventaire.'
        MItems.Add(Numero, Article)
    End Sub

    Public Sub AddCategorie(ByVal NewCategorie As String)
        'On boucle dans la list de catégorie afin d'éviter deux catégories identiques.'
        For Index As Integer = 0 To MCategorie.Count - 1
            If NewCategorie.ToLower() = MCategorie(Index).ToLower() Then
                Return
            End If
        Next

        'On ajoute la catégorie dans la liste de catégorie.'
        MCategorie.Add(NewCategorie.ToLower())
    End Sub

    Public Function GetArticle(ByVal Numero As Integer) As Article
        Return MItems(Numero)
    End Function

    Public ReadOnly Property Items As Dictionary(Of Integer, Article)
        Get
            Return MItems
        End Get
    End Property

    Public ReadOnly Property Categorie() As ArrayList
        Get
            Return MCategorie
        End Get
    End Property

    Public ReadOnly Property Loaded As Boolean
        Get
            Return MLoaded
        End Get
    End Property
End Class
