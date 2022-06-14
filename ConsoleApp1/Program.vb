
Imports System

Module Program

    Sub Main()
        Dim myText() = {"3", "8", "5", "4"}
        Dim myNumbers() = {3, 8, 5, 4}
        Dim sorted = SelectionSort(myNumbers)

    End Sub

    Function InsertionSort(text As String()) As String()
        'text = {"3", "8", "5", "4"}
        Dim textLen = text.Length
        'Dim out(0 To textLen - 1) As String

        For i As Integer = 0 To textLen - 1 Step 1

            'out(i) = text(i)

            For j As Integer = i To 1 Step -1
                Console.WriteLine($"out :{String.Join(",", text)}")
                If (text(j) < text(j - 1)) Then
                    Swap(text(j), text(j - 1))
                End If
            Next

        Next

        Console.WriteLine($"text:{String.Join(",", text)}")
        'Console.WriteLine($"out :{String.Join(",", out)}")
        Return text
    End Function


    Sub Swap(ByRef a As String, ByRef b As String)
        Dim temp = a
        a = b
        b = temp
    End Sub


    Function SelectionSort(userNumbers As Integer()) As Integer()
        userNumbers = {4, 8, 5, 3}

        Dim userLength As Integer = userNumbers.Length

        For i As Integer = 0 To userLength - 1

            For j As Integer = i + 1 To userLength - 1
                Dim userText = $"{String.Join(",", userNumbers)}"
                If userNumbers(j) < userNumbers(i) Then
                    Swap(userNumbers(j), userNumbers(i))
                End If
            Next

        Next
        Return userNumbers
    End Function


End Module
