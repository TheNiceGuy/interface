Public Class Main
    Public Shared Sub Main()
        Dim Args() = Environment.GetCommandLineArgs
        Dim SuperviseurShow As Boolean = True
        Dim Path As String = vbNullString
        Dim Address As String = vbNullString
        Dim Port As Integer = -1
        Dim AppEvent As New AppEvent

        AppEvent.ConfigureEvent()

        For i As Integer = 1 To Args.Count - 1 Step 1
            Select Case Args(i)
                Case "--gui"
                    SuperviseurShow = True
                Case "--nogui"
                    SuperviseurShow = False
                Case "-a"
                    Address = Args(i + 1)
                    i += 1
                Case "--address"
                    Address = Args(i + 1)
                    i += 1
                Case "-p"
                    Port = Args(i + 1)
                    i += 1
                Case "--port"
                    Port = Args(i + 1)
                    i += 1
                Case "--database"
                    Path = Args(i + 1)
                    i += 1
                Case "-d"
                    Path = Args(i + 1)
                    i += 1
                Case "-h"
                    ShowHelp()
                    Return
                Case "--help"
                    ShowHelp()
                    Return
                Case Else
                    Console.WriteLine("Unrecognized argument '" & Args(i) & "'.")
                    Return
            End Select
        Next

        If SuperviseurShow Then
            AppEvent.Superviseur.FormBorderStyle = FormBorderStyle.FixedSingle
            AppEvent.Superviseur.ShowDialog()
        Else
            'On s'assure qu'un chemin vers la base de données fut spécifié.
            If Path = vbNullString Then
                Console.WriteLine("No '--database' given.")
                Return
            End If

            'On s'assure qu'une addresse fut spécifiée.
            If Address = vbNullString Then
                Console.WriteLine("No '--address' given.")
                Return
            End If

            'On s'assure qu'un port fut spécifié.
            If Port < 0 Then
                Console.WriteLine("No '--port' given.")
                Return
            End If

            'On démarre le serveur.
            Try
                AppEvent.Server.Bootstrap(Path, Address, Port)
            Catch ex As Exception
                AppEvent.Server.StackTrace(ex)
                Return
            End Try
        End If
    End Sub

    Public Shared Sub ShowHelp()
        Console.WriteLine("Usage: Server.exe [OPTIONS...]")
        Console.WriteLine("")
        Console.WriteLine("Options:")
        Console.WriteLine(vbTab & "--gui:" & vbTab & vbTab & "start the server with the GUI [default]")
        Console.WriteLine(vbTab & "--nogui:" & vbTab & "start the server without the GUI")
        Console.WriteLine(vbTab & "-a, --address:" & vbTab & "[without GUI] the binding address")
        Console.WriteLine(vbTab & "-p, --port:" & vbTab & "[without GUI] the binding port")
        Console.WriteLine(vbTab & "-d, --database:" & vbTab & "[without GUI] the path to the database")
        Console.WriteLine(vbTab & "-h, --help:" & vbTab & "show this message")
    End Sub

End Class

Public Class AppEvent
    Dim MServer As New Server
    Dim MSuperviseur As New Superviseur

    Declare Function AttachConsole Lib "kernel32.dll" (ByVal dwProcessId As Int32) As Boolean
    Declare Function FreeConsole Lib "kernel32.dll" () As Boolean

    Public Sub ConfigureEvent()
        'Si l'on ne désire pas ouvrir l'interface, on écrit le output dans le stdout.
        AttachConsole(-1)

        AddHandler AppDomain.CurrentDomain.ProcessExit, AddressOf Shutdown
    End Sub

    Public Sub Shutdown()
        Try
            MServer.Shutdown()
        Catch ex As Exception
            'On ignore si le serveur est déjà fermé.
        End Try

        FreeConsole()
    End Sub

    Public ReadOnly Property Server
        Get
            Return MServer
        End Get
    End Property

    Public ReadOnly Property Superviseur
        Get
            Return MSuperviseur
        End Get
    End Property
End Class
