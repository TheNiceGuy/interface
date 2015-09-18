Module Module1
    Sub Main()
        Dim age As Integer
        Dim prix As Double

        Console.Write("Veuillez entrer l'âge du client: ")
        age = Console.ReadLine()

        Select Case age
            Case Is <= 8
                prix = 0.0
            Case 9 To 15
                prix = 4.5
            Case 16 To 21
                prix = 6.5
            Case 22 To 64
                prix = 8.5
            Case Is >= 65
                prix = 6.0
        End Select

        Console.Write("Le prix est de ")
        Console.Write(prix)
        Console.WriteLine("$.")
        Console.Read()
    End Sub
End Module
