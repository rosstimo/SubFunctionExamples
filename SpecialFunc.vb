Option Strict On

Module SpecialFunc
    Sub main()
        UserMessages("new info", False)
        UserMessages("2nd message", False)
        UserMessages("3rd message", False)
        UserMessages("4th message", False)
        UserMessages("Good bye", False)

        Console.WriteLine(UserMessages("", False))

        MsgBox(UserMessages("", False))

        UserMessages("", True)

        MsgBox(UserMessages("", False))

        'Console.Read()

        'promptUser("hello user")

        'For i = 0 To 5
        '    'Console.WriteLine(RandomNumberInRange(5))
        '    RandomNumberInRange(5)
        'Next

        'storeMessages("hello" & vbNewLine) 'chr(13) & chr(11)
        'promptUser(storeMessages(""))
    End Sub

    Sub PromptUser(message As String)
        Console.WriteLine(message)
    End Sub

    Function StoreMessages(message As String) As String
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


    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        Static messages As String

        If clear = False Then
            messages &= newMessage & vbNewLine 'Chr(10) & Chr(13)    'vbCrLf     'vbNewLine
        Else
            messages = ""
        End If

        Return messages

    End Function

End Module
