
Imports System

Module Program

    Sub Main()
        Dim myText() = {"3", "8", "5", "4"}
        Dim sorted = SelectionSort(myText)

    End Sub

    Function SelectionSort(text() As String) As String()
        text = {"3", "8", "5", "4"}
        Dim textLen = text.Length
        Dim out(0 To textLen - 1) As String

        For i As Integer = 0 To textLen - 1 Step 1

            out(i) = text(i)

            For j As Integer = i To 1 Step -1
                Console.WriteLine($"out :{String.Join(",", out)}")
                If (out(j) < out(j - 1)) Then
                    Swap(out(j), out(j - 1))
                End If
            Next

        Next

        Console.WriteLine($"text:{String.Join(",", text)}")
        Console.WriteLine($"out :{String.Join(",", out)}")
        Return out
    End Function


    Sub Swap(ByRef a As String, ByRef b As String)
        Dim temp = a
        a = b
        b = temp
    End Sub

End Module
