Option Strict On

Module SpecialFunc
    Sub main()

        'promptUser("hello user")

        For i = 0 To 5
            'Console.WriteLine(RandomNumberInRange(5))
            RandomNumberInRange(5)
        Next

        'storeMessages("hello" & vbNewLine) 'chr(13) & chr(11)
        'promptUser(storeMessages(""))
        Console.Read()
    End Sub

    Sub promptUser(message As String)
        Console.WriteLine(message)
    End Sub

    Function storeMessages(message As String) As String
        Static storedMessages As String 'static extends lifetime of the variable
        storedMessages &= message
        Return storedMessages
    End Function

    Function RandomNumberInRange(maxNumber As Integer) As Single
        Dim value As Integer
        Dim temp As Single
        ' Initialize the random-number generator.
        Randomize(DateTime.Now.Millisecond)

        'value = CInt(Int((6 * Rnd()) + 1))
        temp = Rnd()
        Console.WriteLine($"Rnd:{temp} Cint:{CInt(temp)} Int:{Int(temp)}")
        Return temp

    End Function

End Module
