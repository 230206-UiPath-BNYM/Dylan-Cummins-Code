Imports System
'modules in vbb are class like artifacts that contain helper methods
'every module has exactly one instance and does not need to be created or assigned to a variable
Module Program
'This is the main mathod, the starting point of the program
' Two kinds of methods in vb:
'Functions - return something
'Subs - return nothing, return void
    Sub Main(args As String())
    'Something else to note: vb has no grouping symbols like curly braces
    ' that define the scope of a code block, instead it relies on closing statments
    ' Also tabbing for documentations purposes
    'vb.net doesn't use semicolons, you get an error if you end your statements in a semicolon
        Console.WriteLine("Hello World!")
    ' variables - hold data, reference in memory, placeholder
    'With vb, we create variables using the dim keyword, 
    'the greeter function returns a string that we are passing to the greeting variable
    'dim greeting as String = greeter("casual")
    'Console.WriteLine(greeting)
    'GuessingGame(2)
    'Counter(3)
    
    GuessingGamev2()
    End Sub
    'You set the data type with the as keyword
    Function greeter(greeting_type as String) as String
        'Flow control statements, used to channel Logic based on conditions
        'Select case AKA switch
        Select Case greeting_type
            Case "casual"
                Return "'sup"
            Case "business casual"
                Return "salutations!"
            Case "full business"
                Return "to whome it may concern"
            Case Else
                Return "hello"
        End Select
    End Function

    Sub GuessingGame(guess as Integer)
        'We'll use the random class to generate a random number
        dim rnd as Random = new Random()
        dim mysteryNumber as integer = rnd.Next(1,2)
        'we use <> to represent non equality ie !=
        'if block: 
        If guess <> mysteryNumber Then
            Console.WriteLine("Wrong guess :<")
        Else Console.WriteLine("Good guess :D")
        end if

    End sub

    Sub Counter(stopping_point as Integer)
        dim start as Integer = 0
        'while loop
        While start < stopping_point
            Console.WriteLine(start)
            start = start + 1
        End While
        'for loop
        'the lower and upper bounds are included in the iteration
        For index As integer = 0 to stopping_point  
            Console.WriteLine(index)
        Next
    end Sub
    
    Sub GuessingGamev2()
        'create a new instance of the random class
        dim rnd as Random = new Random()
        dim mysteryNumber as Integer = rnd.Next(1,100)
        Console.WriteLine("Enter guess: ")
        dim guess as String = Console.ReadLine()
        'integer struct has a method called Parse that converts strings to their numeric values
        'TODO: add exception handling

        dim guessNum as Integer = 0
        Try 
            guessNum = Integer.Parse(guess)
        Catch ex As Exception
            Console.WriteLine("invalid input, try again")
        End Try

        While guessNum <> mysteryNumber
            'We want to keep guessing
            If guessNum < mysteryNumber Then
                Console.WriteLine("Too Low")
                Else Console.WriteLine("Too high")
            End If
            Console.WriteLine("Not Quite try again. Enter guess: ")
            Try 
                guessNum = Integer.Parse(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("invalid input, try again")
            End Try
            'guessNum = Integer.Parse(Console.ReadLine())

        End While
        Console.WriteLine("Cogratulations! You guessed correctly! ")

    End Sub
End Module
