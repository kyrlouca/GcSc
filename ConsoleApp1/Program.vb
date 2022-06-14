
Imports System

Module Program

    Sub Main()

        Dim myNumbers() = {3, 8, 5, 4}
        Dim sortedInsertion = InsertionSort(myNumbers)
        Dim sortedSelection = SelectionSort(myNumbers)
        Dim sortedBuble = BubbleSort(myNumbers)
        Dim qsNum() = {2, 6, 8, 12, 4, 6}
        Dim xx = QuickSort(qsNum, 0, 5)
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


    Function QuickSort(ByRef userNumbers As Integer(), low As Integer, highx As Integer) As Integer()
        'userNumbers = {4, 8, 5, 3}

        Dim Mid = Partition(userNumbers, low, highx)

        If (highx <= low) Then
            Return userNumbers
        End If

        QuickSort(userNumbers, low, Mid - 1)
        QuickSort(userNumbers, Mid + 1, highx)

        Return userNumbers
    End Function

    Function Partition(ByRef userNumbers As Integer(), startPos As Integer, endPos As Integer) As Integer
        Dim pivot As Integer = userNumbers(endPos)
        Dim low = startPos
        Dim high = endPos
        Dim str = String.Join(",", userNumbers)

        While high > low
            If userNumbers(low) > pivot Then
                Swap(userNumbers(low), userNumbers(high - 1))
                high -= 1
            Else
                low += 1
            End If

        End While

        Swap(userNumbers(high), userNumbers(endPos))
        Return high
    End Function



End Module
