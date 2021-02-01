Option Explicit On
Option Strict On

'Dylan Nelson
'RCET0265
'Spring 2021
'Say My Name Again
'https://github.com/dylannelson58/SayMyNameAgain1

Module SayMyNameAgain

    Sub Main()

        Dim userInput As String

        Console.WriteLine("Hello, what is your name?")

        userInput = Console.ReadLine
        If userInput = "Joe" Then
            Console.WriteLine("Hello, " & userInput & ", nice to meet you!")
        End If

        If userInput = "Emily" Then
            Console.WriteLine("Hello, " & userInput & ", nice to meet you!")
        End If

        If userInput = "Dylan" Then
            Console.WriteLine("Hey, " & userInput & ", welcome back! Thanks for creating me!")
        End If

        Console.WriteLine("Have a good one!")

        Console.Read()
    End Sub

End Module
