Imports System
Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())

        Dim a As Integer = 5
        Dim b As Integer = 67
        Console.WriteLine("before a,b > :" & a & "," & b)
        SwapByVal(a, b)
        Console.WriteLine("swap by value a,b >" & a & "," & b)
        SwapByRef(a, b)
        Console.WriteLine("swap by Ref a,b >" & a & "," & b)

        Exit Sub

        Dim word() As Char = {"a", "n", "d", "r", "e", "a", "s"}
        Dim reverseWord(word.Length) As Char
        reverseWord = ReverseArray(word)
        Console.WriteLine(word & "-" & reverseWord)

        reverseWord = ReverseSameArray(word)
        Console.WriteLine(word & "-" & reverseWord)

    End Sub


    Sub SwapByVal(ByVal a As Integer, ByVal b As Integer)
        Dim c As Integer = a
        a = b
        b = c
        Console.WriteLine("a:" & a & " b:" & b)
    End Sub


    Sub SwapByRef(ByRef a As Integer, ByRef b As Integer)
        Dim c As Integer = a
        a = b
        b = c
        Console.WriteLine("a:" & a & " b:" & b)
    End Sub


    Function ReverseArray(letters() As Char)
        Dim arraySize = letters.Length
        Dim outArray(arraySize) As Char
        For i = 0 To arraySize - 1
            outArray(arraySize - 1 - i) = letters(i)
        Next
        Return outArray
    End Function

    Function ReverseSameArray(letters() As Char)
        Dim arraySize = letters.Length
        Dim half As Integer = arraySize / 2
        Dim halfD As Integer = Math.Floor(arraySize / 2)

        For i = 0 To halfD
            letters(i) = letters(arraySize - i - 1)
        Next
        Return letters
    End Function



End Module
