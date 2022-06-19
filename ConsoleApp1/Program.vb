
Imports System

Module Program

    Sub Main()

        Dim myNumbers() = {3, 8, 5, 4}
        Dim sortedInsertion = InsertionSort(myNumbers)
        Dim sortedSelection = SelectionSort({4, 8, 2, 5, 6})
        Dim sortedBuble = BubbleSort(myNumbers)
        Dim qsNum() = {2, 6, 8, 12, 4, 6}
        Dim xx = QuickSort(qsNum, 0, 5)
    End Sub


    'insert each element in its correct position in the sorted array ( use the left of the original array as the sorted array)
    'Start from the second leftomost item (since the first item is sorted)
    'before inserting the next unsorted item, iterate the sorted part of array from the right and shift larger elements the right
    ' userNumbers = {3, 8, 5, 4}
    Function InsertionSort(userNumbers As Integer()) As Integer()
        Dim userLength = userNumbers.Length

        For i As Integer = 1 To userLength - 1 'iterate for each element and "insert it" in the sorted array. Start from second item

            Dim ItemToInsert = userNumbers(i)
            Dim currentItem = i - 1

            While userNumbers(currentItem) > ItemToInsert And currentItem > 0 'if the currentItem is greated than insertedItem, then shift currentItem to the right
                userNumbers(currentItem + 1) = userNumbers(currentItem)  'if the ItemToInsert is greater than current item, SHIFT the the compared to the next position
                currentItem = currentItem - 1
            End While

            userNumbers(currentItem + 1) = ItemToInsert
        Next
        Return userNumbers
    End Function


    'iterate for each member of the array
    'in each iteration, SWAP the current item (i) with the  smallest of the remaining items (smallest)
    'userNumbers = {4, 8, 5, 2, 6}
    Function SelectionSort(userNumbers As Integer()) As Integer()
        For i As Integer = 0 To userNumbers.Length - 1
            Dim smallest = i

            For j As Integer = i To userNumbers.Length - 1
                If userNumbers(j) < userNumbers(smallest) Then
                    smallest = j
                End If
            Next

            Swap(userNumbers(i), userNumbers(smallest))
        Next
        Return userNumbers
    End Function


    'in each iteration, the largest item bubbles to the right
    'iterate as many times as needed
    Function BubbleSort(userNumbers As Integer()) As Integer()
        ' userNumbers = {4, 8, 5, 3}

        Dim userLength As Integer = userNumbers.Length
        Dim isSwap As Boolean

        Do   'keep bubbling until no swapping
            isSwap = False
            For i As Integer = 0 To userLength - 2
                If userNumbers(i) > userNumbers(i + 1) Then
                    Swap(userNumbers(i), userNumbers(i + 1))
                    isSwap = True
                End If
            Next

        Loop Until Not isSwap
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


    Sub Swap(ByRef a As Integer, ByRef b As Integer)
        Dim temp = a
        a = b
        b = temp
    End Sub

End Module
