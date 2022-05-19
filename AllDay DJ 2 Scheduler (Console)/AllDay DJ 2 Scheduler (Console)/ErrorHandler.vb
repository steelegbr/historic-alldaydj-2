Public Class ErrorHandler

    Shared Sub errorHandler(ByVal ex As Exception)

        ' Just display an error message

        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("")
        Console.WriteLine("====================")
        Console.WriteLine("AN ERROR HAS OCURRED")
        Console.WriteLine(ex.Message)
        Console.WriteLine(ex.StackTrace)
        Console.WriteLine("====================")
        Console.WriteLine("")
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.Yellow

    End Sub

    Shared Sub errorHandler(ByVal message As String)

        ' Just display an error message

        Console.BackgroundColor = ConsoleColor.Black
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("")
        Console.WriteLine("====================")
        Console.WriteLine("AN ERROR HAS OCURRED")
        Console.WriteLine(message)
        Console.WriteLine("====================")
        Console.WriteLine("")
        Console.BackgroundColor = ConsoleColor.Blue
        Console.ForegroundColor = ConsoleColor.Yellow

    End Sub

End Class
