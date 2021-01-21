'Laura Riley
'RCET0265
'Spring 2021
'Simple Calculator
'https://github.com/rilelaur/SimpleCalculator.git

Option Explicit On
Option Strict On

'The program will ask the user for two numbers and give them the option to
'compute the sum or the product and then display the answer
Module SimpleCalculator

    Sub Main()
        Dim numberOne As Integer
        Dim numberTwo As Integer
        'Dim userInput As Integer

        Console.WriteLine("Input a whole number and press 'Enter'" & vbCrLf)
        numberOne = Console.Read()

        Console.WriteLine("Please input a second number" & vbCrLf)
        numberTwo = Console.Read()


        'Console.WriteLine("Indicate if you want to add(1) or multiply(2) the two numbers by typing '1' or '2'")
        'userInput = Console.Read()

        'If userInput = 1 Then
        '    Console.WriteLine(numberOne + numberTwo)
        'ElseIf userInput = 2 Then
        '    Console.WriteLine(numberOne * numberTwo)
        'End If

        Console.Read()
    End Sub

End Module
