Module Calculator
    Sub Main()
        Dim endApp = False
        While Not endApp
            Dim a As String = " "
            Dim b As String = " "
            Dim oper As String = " "
            Dim result As Double = 0

            Console.WriteLine("Calculator")
            Console.WriteLine("Type a number:")

            a = Console.ReadLine()

            Dim cleana As Double = 0
            While Not Double.TryParse(a, cleana)
                Console.Write("This is not valid input. Please enter an integer value: ")
                a = Console.ReadLine()
            End While

            Console.WriteLine("Type in a operator:")
            oper = Console.ReadLine()

            Console.WriteLine("Type a number, and then press Enter")
            b = Console.ReadLine()

            Dim cleanb As Double = 0
            While Not Double.TryParse(b, cleanb)
                Console.Write("This is not valid input. Please enter an integer value: ")
                b = Console.ReadLine()
            End While

            Try
                result = Calculate(cleana, oper, cleanb)
                If Double.IsNaN(result) Then
                    Console.WriteLine("This operation will result in a mathematical error.")
                Else
                    Console.WriteLine("Your result: {0:0.##}\n", result)
                End If
            Catch ex As Exception
                Console.WriteLine("Oh no! An exception occurred trying to do the math.")
                Console.WriteLine("- Details: " + ex.Message)
                Throw
            End Try

            Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ")
            If (Console.ReadLine() = "n") Then endApp = True

            Console.WriteLine()
        End While
    End Sub

    Public Function Calculate(ByVal a As Double, ByVal oper As String, ByVal b As Double) As Double
        Dim result As Double = Double.NaN
        Select Case oper
            Case "+"
                result = a + b
            Case "-"
                result = a - b
            Case "*"
                result = a * b
            Case "/"
                While b = 0
                    Console.WriteLine("Enter a non - zero divisor: ")
                    b = Convert.ToDouble(Console.ReadLine())
                End While
            Case Else
        End Select
        Return result
    End Function
End Module
