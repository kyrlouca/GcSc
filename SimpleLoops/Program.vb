Imports System
Imports System.Globalization

Module Program
    Sub Main(args As String())
        Dim sum As Integer
        Dim grade As String
        Dim score As Integer = 0


        Do
            Console.Write("enter your grade:")
            score = Console.ReadLine()
            If (score = 100) Then
                Continue Do

            End If

            grade = AssignGrade(score)

            Console.WriteLine($"your grade is : {grade}- {score}")
            sum = sum + score
        Loop Until score >= 100

        Dim avg As Double = sum / 3
        Dim avg2 = avg.ToString("F3")

        Console.WriteLine($"avg {avg:F4}")

    End Sub

    Function AssignGrade(score As Integer) As String
        Dim grade As String
        If (score >= 9) Then
            grade = "A"
        ElseIf score >= 7 Then
            grade = "B"
        Else
            grade = "C"
        End If
        Return grade
    End Function

End Module
