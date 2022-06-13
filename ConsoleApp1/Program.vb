
Imports System

Module Program

    Sub Main()
        Dim myText() = {"1", "4", "3", "2"}
        SelectionSort(myText)

    End Sub

    Sub SelectionSort(text() As String)

        text = {"1", "4", "3", "2"}
        Dim textLen = text.Length
        Dim out(0 To textLen - 1) As String

        For i As Integer = 0 To textLen - 1 Step 1

            out(i) = text(i)

            For j As Integer = i To 1 Step -1
                Console.WriteLine($"out :{String.Join(",", out)}")
                If (out(j) < out(j - 1)) Then
                    Dim temp = out(j)
                    out(j) = out(j - 1)
                    out(j - 1) = temp
                End If
            Next

        Next

        Console.WriteLine($"text:{String.Join(",", text)}")
        Console.WriteLine($"out :{String.Join(",", out)}")

    End Sub
End Module
