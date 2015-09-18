Module Module1
    Sub Main()
        Dim choix As Integer

        Console.WriteLine("Que voulez-vous faire?")
        Console.WriteLine("(1) somme consécutive de nombre")
        Console.WriteLine("(2) élevé un nombre à une puissance")

        Do
            Console.Write("Choix: ")
            choix = Console.ReadLine()

            If choix = 1 Then
                Somme()
            ElseIf choix = 2 Then
                Puissance()
            End If
        Loop While choix <> 1 And choix <> 2

        Console.Read()
    End Sub

    Sub Somme()
        Dim a As Integer
        Dim b As Integer
        Dim sum As Integer

        Do
            Console.Write("Premier nombre:")
            a = Console.ReadLine()

            Console.Write("Deuxième nombre:")
            b = Console.ReadLine()
            If b < a Then
                Console.WriteLine("Le deuxième nombre doit être inférieur ou égal au premier.")
            End If
        Loop While b < a

        For i As Integer = a To b
            sum += i
            Console.Write(i)
            If i <> b Then
                Console.Write("+")
            Else
                Console.Write("=")
            End If
        Next

        Console.WriteLine(sum)
    End Sub

    Sub Puissance()
        Dim b As Integer
        Dim p As Integer
        Dim res As Double = 1

        Console.Write("Base:")
        b = Console.ReadLine()

        Console.Write("Puissance:")
        p = Console.ReadLine()

        Select Case p
            Case 0
                Exit Select
            Case Is < 0
                Console.Write("1/(")
                For i As Integer = 1 To -p
                    res *= b

                    Console.Write(b)
                    If i <> -p Then
                        Console.Write("*")
                    Else
                        Console.Write(")=")
                    End If
                Next

                res = 1.0 / res
                Exit Select
            Case Is > 0
                For i As Integer = 1 To p
                    res *= b

                    Console.Write(b)
                    If i <> p Then
                        Console.Write("*")
                    Else
                        Console.Write("=")
                    End If
                Next

                Exit Select
        End Select

        Console.Write(res)
    End Sub
End Module
