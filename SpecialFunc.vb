Module SpecialFunc
    Sub main()

        promptUser("hello user")

        For i = 0 To 5
            storeMessages("hello" & vbNewLine) 'chr(13) & chr(11)
        Next

        promptUser(storeMessages(""))
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


End Module
