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
'[]Create a function to Pull random number 1-6
'[]Call function twice and assign to diceOne and diceTwo
'[]Add two dice rolls together to diceTotal
'[]create an array diceRollTally() where first row is possible roll totals {2, 3, 4, 5, 6, 7, 8, 9, 10 ,11, 12}
'[]second row of diceRollTally() should be the number of times the diceTotal equals the corresponding column
'[]compare diceTotal to the possible rolls and increment corresponding array element
'[]repeat 1000 times and record totals in diceRollTally() array
'[]we might want do separate variables for each total and add them all to the array after the 1000 rolls

Option Explicit On
Option Strict On

Module RollOfTheDice

    Dim diceOne As Integer
    Dim diceTwo As Integer
    Dim diceTotal As Integer


    Sub Main()

    End Sub

End Module
