Imports System

Module Program
    Sub Main(args As String())
        Dim myWord = "hello"
        Dim chr = "a"
        Dim asc1 = Asc("h")
        Dim xxx = chr.ToUpper()

        'Dim count = countLetters(myWord, "e")
        Dim len = myWord.ToUpper()
        Dim s1 = myWord.Substring(2, 2) 'llo
        Dim m1 = Mid(myWord, 2, 2) 'el
        Dim l1 = Left(myWord, 2) 'he
        Dim r1 = Right(myWord, 2) 'lo
        Console.WriteLine("Hello strings!")
    End Sub

    Function countLetters(word As String, selectedLetter As Char) As Integer
        Dim count As Integer = 0
        For I = 1 To word.Length
            Dim letter = Mid(word, I, I)
            If (letter = selectedLetter) Then
                count = count + 1
                Console.WriteLine(letter, I.ToString)
            End If

        Next
        Return count
    End Function
End Module

