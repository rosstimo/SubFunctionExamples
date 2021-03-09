Module OneJobMethods

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
        End If
        Return _RunningTotal
    End Function



End Module
