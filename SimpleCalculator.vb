'Laura Riley
'RCET0265
'Spring 2021
'Simple Calculator
'https://github.com/rilelaur/SimpleCalculator.git

Option Explicit On
Option Strict On
Option Compare Binary

'The program will ask the user for two numbers and give them the option to
'compute the sum or the product and then display the answer
Module SimpleCalculator

    Sub Main()

        Dim firstInput As Long
        Dim secondInput As Long
        Dim userInput As String = ""
        Dim Problem As Boolean = False

        'Program will ask the user for a number
        Console.WriteLine("Input a whole number and press 'Enter'")

        'Program will take the user input and store it in the variable 'firstInput'
        'Program will convert userInput to a Long
        'If the user doesn't enter a Long then it will read an error 
        'If an error is read the boolean 'problem' will then throw a true
        Try
            userInput = Console.ReadLine()
            firstInput = CInt(userInput)
        Catch ex As Exception
            Console.WriteLine($"I need a whole number. You entered the invaid character(s) {userInput}" & vbCrLf)
            Problem = True
        End Try

        'Program will ask the user for another number
        Console.WriteLine(vbCrLf & "Input a whole number and press 'Enter'")

        'Program will take the user input and store it in the variable 'secondInput'
        'Program will convert userInput to a Long
        'If the user doesn't enter a Long then it will read an error 
        'If an error is read the boolean 'problem' will then throw a true
        Try
            userInput = Console.ReadLine()
            secondInput = CInt(userInput)
        Catch ex As Exception
            Console.WriteLine($"I need a whole number. You entered the invaid character(s) {userInput}" & vbCrLf)
            Problem = True
        End Try

        'Program will check if the boolean 'problem' is true
        'If 'problem' is true then it will clear the screen and an show an error
        'If 'problem' is false then it will ask the user if they want to + or *
        If Problem = True Then
            Console.Clear()
            Console.WriteLine("Sorry try again later...")
            Console.WriteLine("Have a nice day...")
        Else
            Console.WriteLine(vbCrLf & "Indicate if you want to add(1) or multiply(2) the two numbers by typing '1' or '2'")
            userInput = Console.ReadLine()
        End If

        'If the user inputs 1 then it will add and display the two inputs
        'If the user inputs 2 then it will multiply and display the two inputs
        If userInput = "1" Then
            Console.WriteLine(vbCrLf & $"{firstInput} + {secondInput} = " & (firstInput + secondInput))
        ElseIf userInput = "2" Then
            Console.WriteLine(vbCrLf & $"{firstInput} * {secondInput} = " & (firstInput * secondInput))
        End If

        Console.Read()
    End Sub

End Module
