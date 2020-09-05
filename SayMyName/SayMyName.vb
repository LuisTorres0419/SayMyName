'Luis Torres
'RCET0265
'Fall 2020
'Say My Name Again
'https://github.com/LuisTorres0419/SayMyName.git
Option Strict On
Option Explicit On
Option Compare Text


Module SayMyName

    'Sub Main()
    '    Dim userInput As String
    '    Console.WriteLine("Hey!! What's your name stranger?")
    '    userInput = Console.ReadLine()
    '    Console.WriteLine("Really your name is " & userInput & " that was my mothers name. my name is computer. Nice to meet you!!!!!")
    '    Console.ReadLine()
    'End Sub

    Sub Main()
        Dim userInput As String

        Do

            Console.WriteLine("Hey creators can you give me your names? press q to Quit")

            userInput = Console.ReadLine()
            If userInput = "Luis" Then
                Console.WriteLine("hey " & userInput & " G.O.T. AKA (Greatest Of All Time) Man, the big cheese todays the day you accomplish all!")

            ElseIf userInput = "Joe" Then

                Console.WriteLine("hey  " & userInput & " your ok?")
            ElseIf userInput = "Emily" Then

                Console.WriteLine("hey " & userInput & " you will tak the world by storme!")
            ElseIf userInput <> "Luis" And userInput <> "Joe" And userInput <> "Emily" Then

                Console.WriteLine("Be gone  " & userInput & "pst...... take joe with you!")
            End If
            Console.ReadLine()
            Console.Clear()

        Loop Until userInput = "q"
    End Sub

End Module
