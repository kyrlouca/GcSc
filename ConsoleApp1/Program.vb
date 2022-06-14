
Imports System

Module Program

    Sub Main()

        Dim myNumbers() = {3, 8, 5, 4}
        Dim sortedInsertion = InsertionSort(myNumbers)
        Dim sortedSelection = SelectionSort(myNumbers)
        Dim sortedBuble = BubbleSort(myNumbers)
    End Sub

    Function InsertionSort(userNumbers As Integer()) As Integer()
        userNumbers = {4, 8, 5, 3}
        Dim userLength = userNumbers.Length

        For i As Integer = 0 To userLength - 1 Step 1

            For j As Integer = i To 1 Step -1
                Dim userText = $"{String.Join(",", userNumbers)}"
                If (userNumbers(j) < userNumbers(j - 1)) Then
                    Swap(userNumbers(j), userNumbers(j - 1))
                End If
            Next

        Next
        Return userNumbers
    End Function


    Sub Swap(ByRef a As Integer, ByRef b As Integer)
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


    Function BubbleSort(userNumbers As Integer()) As Integer()
        userNumbers = {4, 8, 5, 3}

        Dim userLength As Integer = userNumbers.Length
        Dim isSwap = True

        While (isSwap)
            isSwap = False

            For i As Integer = 0 To userLength - 2
                Dim userText = $"{String.Join(",", userNumbers)}"
                If userNumbers(i + 1) < userNumbers(i) Then
                    Swap(userNumbers(i + 1), userNumbers(i))
                    isSwap = True
                End If

            Next
        End While
        Return userNumbers
    End Function



End Module
