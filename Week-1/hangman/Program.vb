Imports System

Module Program


    Sub Main(args As String())
    

        
        GuessLetter()
         


    End Sub

    Sub GuessLetter()
    dim mysteryword() As String = {"w", "e", "e", "k"}
    dim guessedarray(4) As String 
   
    'Guessing Letters
    dim counter as Integer = 0
    While counter < 6 
    Console.WriteLine("Please enter a letter to guess: ")
    dim guess as String = Console.ReadLine()
    for index as Integer = 0 to 3 
        if guess = mysteryword(index) Then
        guessedarray(index) = guess
        Else Hangman()
        counter = counter + 1


        End if
    Next 
    
    End While

    End Sub

    Sub Hangman()
    'Write out hangman


    End Sub


End Module

