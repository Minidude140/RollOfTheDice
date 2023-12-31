﻿'Zachary Christensen
'RCET 2265
'Fall 2023
'Roll of the Dice
'https://github.com/Minidude140/RollOfTheDice.git

'TODO
'[~]Create a function to Pull random number 1-6
'[~]Create main loop with quit functionality
'[~]Call function twice and assign to diceOne and diceTwo
'[~]Add two dice rolls together to diceTotal
'[~]create an array diceRollTally() where first row is possible roll totals {2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12}  ***actually one dimensional array.  First "Row" is just drawn as a header***
'[~]Create draw array Sub
'[~]second row of diceRollTally() should be the number of times the diceTotal equals the corresponding column
'[~]compare diceTotal to the possible rolls and increment corresponding array element
'[~]repeat 1000 times and record totals in diceRollTally() array

Option Explicit On
Option Strict On

Module RollOfTheDice

    Dim userInput As String
    Dim diceOne As Integer
    Dim diceTwo As Integer
    Dim diceTotal As Integer
    Dim diceRollTally() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    Dim numberOfRolls As Integer = 0


    Sub Main()
        Do
            'Prompt user for input
            Console.WriteLine("Press Enter to roll two dice 1,000 times and log their totals." & vbLf & "(Enter 'Q' to quit or 'C' to clear previous totals)" & vbLf)
            userInput = Console.ReadLine()
            Console.WriteLine()

            Select Case userInput
                Case = "Q", "q"
                    'Exits Program
                    Exit Do
                Case = "C", "c"
                    'Clears any previous total counts and number of rolls
                    ReDim diceRollTally(10)
                    numberOfRolls = 0
                    DrawDiceRolls(diceRollTally)
                Case Else
                    'Roll die 1,000 times
                    For i = 1 To 1000
                        'Rolls two dice and adds them together
                        diceOne = DiceRoll()
                        diceTwo = DiceRoll()
                        diceTotal = AddTwoIntegers(diceOne, diceTwo)

                        'evaluates diceTotal and increments corresponding array element
                        EvaluateTotal(diceTotal)
                    Next
                    'Draws Array elements and header counts total rolls
                    numberOfRolls += 1
                    DrawDiceRolls(diceRollTally)
            End Select
        Loop
    End Sub

    Function DiceRoll() As Integer
        'random number 1-6
        Dim randomNumber As Integer
        Randomize()
        randomNumber = CInt((Rnd() * (6 - 1)) + 1)
        Return randomNumber
    End Function

    Function AddTwoIntegers(numberOne As Integer, numberTwo As Integer) As Integer
        'adds two numbers and returns the total
        Dim summation As Integer
        summation = numberOne + numberTwo
        Return summation
    End Function

    Sub DrawDiceRolls(diceRollTally() As Integer)
        'create header with possible rolls
        Dim header = New String() {"2  |", "3  |", "4  |", "5  |", "6  |", "7  |", "8  |", "9  |", "10  |", "11  |", "12  |"}
        'Draw out top border and header
        Console.WriteLine(StrDup(78, "-"))
        Console.Write("|")
        For i = LBound(header) To UBound(header)
            Console.Write(header(i).PadLeft(7))
        Next
        'Draw out diceRollTally() with borders
        Console.WriteLine(vbLf & StrDup(78, "-"))
        Console.Write("|")
        For i = LBound(diceRollTally) To UBound(diceRollTally)
            Dim currentTotal As String
            currentTotal = CStr(diceRollTally(i) & "  |")
            Console.Write(currentTotal.PadLeft(7))
        Next
        Console.WriteLine(vbLf & StrDup(78, "-") & vbLf)
        'Reports the total number of rolls after array is drawn
        If numberOfRolls = 0 Then
            Console.WriteLine("Total Rolls: 0" & vbLf)
        Else
            Console.WriteLine($"Total Rolls: {numberOfRolls},000" & vbLf)
        End If

    End Sub

    Sub EvaluateTotal(diceTotal As Integer)
        'evaluates diceTotal and increments corresponding array element
        Select Case diceTotal
            Case = 2
                diceRollTally(0) += 1
            Case = 3
                diceRollTally(1) += 1
            Case = 4
                diceRollTally(2) += 1
            Case = 5
                diceRollTally(3) += 1
            Case = 6
                diceRollTally(4) += 1
            Case = 7
                diceRollTally(5) += 1
            Case = 8
                diceRollTally(6) += 1
            Case = 9
                diceRollTally(7) += 1
            Case = 10
                diceRollTally(8) += 1
            Case = 11
                diceRollTally(9) += 1
            Case = 12
                diceRollTally(10) += 1
        End Select
    End Sub

End Module
