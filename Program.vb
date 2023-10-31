Imports System

Module Program
    Public Sub Main(args As String())
        Dim counter As Integer = 0

        Do Until counter = Convert.ToInt32(args)
            counter = counter + 1
            System.Threading.Thread.Sleep(1000)
            System.Console.WriteLine(counter)
        Loop
    End Sub
End Module
