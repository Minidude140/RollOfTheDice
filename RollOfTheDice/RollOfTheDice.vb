'Zachary Christensen
'RCET 2265
'Fall 2023
'Roll of the Dice
'https://github.com/Minidude140/RollOfTheDice.git

'ASSIGNMENT INSTRUCTIONS
'Write a program that rolls two six-sided dice 1,000 times And accumulates the count Of Each number rolled efficiently In an array.
'Display the results In the console In formatted columns With headers

'Header row--> the roll result numbers 2 To 12
'Data row --> the total count Of how many times Each number came up

'TODO
'[~]Create a function to Pull random number 1-6
'[~]Create main loop with quit functionality
'[~]Call function twice and assign to diceOne and diceTwo
'[~]Add two dice rolls together to diceTotal
'[~]create an array diceRollTally() where first row is possible roll totals {2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12}  ***actually one dimensional array.  First "Row" is just drawn as a header***
'[~]Create draw array Sub
'[~]second row of diceRollTally() should be the number of times the diceTotal equals the corresponding column
'[~]compare diceTotal to the possible rolls and increment corresponding array element
'[]repeat 1000 times and record totals in diceRollTally() array

Option Explicit On
Option Strict On

Module RollOfTheDice

    Dim userInput As String
    Dim diceOne As Integer
    Dim diceTwo As Integer
    Dim diceTotal As Integer
    Dim diceRollTally() As Integer = {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}


    Sub Main()
        Do
            Console.WriteLine("Press Enter to roll dice." & vbLf & "(Enter 'Q' to quit)" & vbLf)
            userInput = Console.ReadLine()
            Console.WriteLine()
            Select Case userInput
                Case = "Q", "q"
                    Exit Do
                Case Else
                    'Roll die here
                    diceOne = DiceRoll()
                    diceTwo = DiceRoll()
                    diceTotal = AddTwoIntegers(diceOne, diceTwo)

                    Console.WriteLine($"You rolled {diceOne} and {diceTwo}." & vbLf & $"The total dice roll is {diceTotal}." & vbLf)
                    'evaluate diceTotal and increment corresponding array element
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
        Console.WriteLine(StrDup(77, "-"))
        For i = LBound(header) To UBound(header)
            Console.Write(header(i).PadLeft(7))
        Next
        'Draw out diceRollTally() with borders
        Console.WriteLine(vbLf & StrDup(77, "-"))
        For i = LBound(diceRollTally) To UBound(diceRollTally)
            Dim currentTotal As String
            currentTotal = CStr(diceRollTally(i) & "  |")
            Console.Write(currentTotal.PadLeft(7))
        Next
        Console.WriteLine(vbLf & StrDup(77, "-") & vbLf)

    End Sub

End Module
