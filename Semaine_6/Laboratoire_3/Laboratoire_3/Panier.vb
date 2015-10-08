Imports System
Imports System.IO
Imports System.Collections.Generic

Public Class Panier
    Dim MItems As New Dictionary(Of Integer, Integer)()

    Public Function AddArticle(ByRef Inventaire As Inventaire, ByVal Numero As Integer, ByVal Quantite As Integer) As Boolean
        'On vérifie que l'inventaire contient assez de cet article.'
        If Inventaire.Items(Numero).Quantite < Quantite Then
            Throw New InsufficientQuantityException("La quantité demandée est trop grande.")
        End If

        'On essaie d'ajouter l'article dans le panier.'
        Try
            MItems.Add(Numero, Quantite)

            Return True
        Catch ex As System.ArgumentException
            'On vérifie que l'inventaire contient assez de cet article.'
            If Inventaire.Items(Numero).Quantite < MItems(Numero) + Quantite Then
                Throw New InsufficientQuantityException("La quantité demandée est trop grande.")
            End If

            'Si l'article est déjèa dans le panier, on ne fait qu'update la quantité.'
            MItems(Numero) += Quantite
            Return False
        End Try
    End Function

    Public Sub ModifyArticle(ByRef Inventaire As Inventaire, ByVal Numero As Integer, ByVal Quantite As Integer)
        'On vérifie que l'inventaire contient assez de cet article.''
        If Inventaire.Items(Numero).Quantite < Quantite Then
            Throw New InsufficientQuantityException("La quantité demandée est trop grande.")
        End If

        'On update la quantité d'article demandée.'
        MItems(Numero) = Quantite
    End Sub

    Public Sub RemoveArticle(ByVal Numero As Integer)
        'On enlève l'article du panier.'
        MItems.Remove(Numero)
    End Sub

    Public Sub Clear()
        MItems.Clear()
    End Sub

    Public Sub EffectuerAchat(ByRef Inv As Inventaire, ByRef FileIO As StreamWriter)
        Dim Numero As Integer
        Dim SousTotal, TPS, TVQ As Double
        Dim Total As Double = 0

        'On écrit les headers dans le fichier.'
        FileIO.WriteLine(String.Format("{0, -3}", "#") +
                         String.Format("{0, -60}", "Nom") +
                         String.Format("{0, 8}", "Prix") +
                         String.Format("{0, 6}", "Qté") +
                         String.Format("{0, 10}", "Total"))

        'On boucle sous tous les articles dans le panier.'
        For Index As Integer = 0 To MItems.Count - 1
            'On récupèere le numéro de l'article.'
            Numero = MItems.Keys()(Index)

            'On calcul le sous-total et le total.'
            SousTotal = Inv.Items(Numero).Prix * MItems(Numero)
            Total += SousTotal

            'On écrit une ligne pour un article.'
            FileIO.WriteLine(String.Format("{0, -3}", Numero) +
                             String.Format("{0, -60}", Inv.Items(Numero).Nom) +
                             String.Format("{0, 8:$#,##0.00}", Inv.Items(Numero).Prix) +
                             String.Format("{0, 6}", MItems(Numero)) +
                             String.Format("{0, 10:$#,##0.00}", SousTotal))

            'On change la quantité de l'article dans l'inventaire et le panier.'
            Inv.Items(Numero) = New Article(Inv.Items(Numero).Nom,
                                            Inv.Items(Numero).Prix,
                                            Inv.Items(Numero).Categorie,
                                            Inv.Items(Numero).Quantite - MItems(Numero))
            MItems(Numero) = 0
        Next

        'On calcule les taxes.'
        TPS = Total * 0.05
        TVQ = Total * 0.09975

        'On finalise l'écriture du fichier.'
        FileIO.WriteLine()
        FileIO.WriteLine(String.Format("{0,77}", "Sous-Total") +
                         String.Format("{0, 10:$#,##0.00}", Total))
        FileIO.WriteLine()
        FileIO.WriteLine(String.Format("{0,77}", "TPS") +
                         String.Format("{0, 10:$#,##0.00}", TPS))
        FileIO.WriteLine(String.Format("{0,77}", "TVQ") +
                         String.Format("{0, 10:$#,##0.00}", TVQ))
        FileIO.WriteLine()
        FileIO.WriteLine(String.Format("{0,77}", "Total") +
                         String.Format("{0, 10:$#,##0.00}", Total + TPS + TVQ))
    End Sub

    Public Property Items As Dictionary(Of Integer, Integer)
        Get
            Return MItems
        End Get
        Set(value As Dictionary(Of Integer, Integer))
            MItems = Items
        End Set
    End Property
End Class
