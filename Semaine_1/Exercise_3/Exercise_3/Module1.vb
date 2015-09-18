Module Module1
    Sub Main()
        Dim salaire As Integer
        Dim taux As Double

        Console.Write("Veuillez le salaire: ")
        salaire = Console.ReadLine()

        Select Case salaire
            Case Is < 10000
                taux = 5.0
            Case 10000 To 15000
                taux = 10.0
            Case 15000 To 18000
                taux = 12.0
            Case 18000 To 22000
                taux = 14.0
            Case Is >= 22000
                taux = 16.0
        End Select

        Console.Write("Le taux de commission est de ")
        Console.Write(taux)
        Console.WriteLine("%.")
        Console.Read()
    End Sub
End Module
