Imports System

Module Program
    Public Sub Main(args As String())
        Dim counter As Integer = 0

        Do Until counter = 15
            counter = counter + 1
            System.Threading.Thread.Sleep(1000)
            System.Console.WriteLine(counter)
        Loop

        Console.ReadKey()
    End Sub
End Module