Option Strict On
Option Explicit On

Module OneJobMethods

    Sub main()
        Dim result As Integer
        Dim testMyString As String = "Banana"
        Sum(30, 50)
        result = Sum(5, 5)
        Console.WriteLine(result)

        IsANumber(testMyString)

        Console.WriteLine($"is {testMyString} a number? {IsANumber(testMyString)}")

        For i = 0 To 9
            RunningTotal()
        Next
        Console.WriteLine(RunningTotal())
        Console.WriteLine(RunningTotal(True))

        Console.ReadLine()
    End Sub

    'returns the sum of the two argument variables
    Function Sum(firstNumber As Integer, secondNumber As Integer) As Integer
        Return firstNumber + secondNumber
    End Function

    'returns the difference of the two argument variables (firstNumber - secondNumber)
    Function Difference(firstNumber As Integer, secondNumber As Integer) As Integer
        Return firstNumber - secondNumber
    End Function

    'returns the product of the two argument variables
    Function Product(firstNumber As Integer, secondNumber As Integer) As Integer
        Return firstNumber * secondNumber
    End Function

    'returns the Integer quotient of the two argument variables. remainder is stripped
    Function Quotient(firstNumber As Integer, secondNumber As Integer) As Integer
        Return firstNumber \ secondNumber
    End Function

    'returns the Double floating point quotient of the two argument variables.
    Function Quotient(firstNumber As Double, secondNumber As Double) As Double
        Return firstNumber / secondNumber
    End Function
    'increments +1 on each call and returns count. Optional clear Boolean argument defaults to False
    Function RunningTotal(Optional clear As Boolean = False) As Integer
        Static _RunningTotal As Integer
        If Not clear Then
            _RunningTotal += 1
        Else
            _RunningTotal = 0
        End If
        Return _RunningTotal
    End Function

    Function IsANumber(stringToTest As String) As Boolean
        Dim temp As Integer
        Try
            temp = CInt(stringToTest)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Module
