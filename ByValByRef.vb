Module ByValByRef

    Dim globalNumber As Integer

    Sub main()
        Dim tempNumber As Integer = 5
        Dim tempString As String

        tempString = ByValExample(tempNumber)
        tempString = ByRefExample(tempNumber)
        ByRefSub(tempNumber)

        'Console.WriteLine($"In {ByValExample(tempNumber)} write {tempNumber}...")
        'Console.WriteLine($"In {ByRefExample(tempNumber)} write {tempNumber}...")

        Console.ReadLine()
    End Sub

    Function ByValExample(ByVal aNumber As Integer) As String
        aNumber *= 2
        Return "ByVal"
    End Function

    Function ByRefExample(ByRef aNumber As Integer) As String
        aNumber *= 2
        Return "ByRef"
    End Function

    Sub ByRefSub(ByRef aNumber As Integer)
        aNumber *= 3
    End Sub


End Module
