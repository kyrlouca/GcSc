Imports System
Imports System.Runtime.InteropServices

Module Program
    Sub Main(args As String())
        Dim numbers(3) As Integer
        Dim numbersb = New Integer() {2, 4, 5, 6}
        Dim numbersc() As Integer = New Integer() {2, 4, 6, 7}
        Dim cars() As String = New String() {"bmw", "ford", "lexus", "bmw"}
        Dim chosen As String = "bmw"
        Dim selectedCounter = CountCars(cars, chosen)
        Console.WriteLine("chosen car is" + chosen + " .Number of cars = " + selectedCounter.ToString)

        Dim foundFord = IsCarFoundFirst(cars, "ford")
        Dim foundLexus = IsCarFound(cars, "lexus")
        Console.WriteLine("found Ford:" + foundFord.ToString + "  found Lexus: " + foundLexus.ToString)
        Console.WriteLine("End")
    End Sub


    Function GetCars(cars() As String, selected As String) As Integer
        Dim count = 0
        For i = 0 To cars.Length - 1
            If (cars(i) = selected) Then
                count = count + 1
            End If
        Next
        Return count
    End Function


    Function CountCars(cars() As String, selected As String) As Integer
        Dim count As Integer = 0
        For I = 0 To cars.Count - 1
            If (cars(I) = selected) Then
                count = count + 1
            End If
        Next
        Return count
    End Function


    Function IsCarFoundFirst(cars() As String, selected As String) As Boolean
        Dim isFound = False
        For I = 1 To cars.Count
            If cars(I) = selected Then
                isFound = True
                Exit For
            End If
        Next
        Return isFound
    End Function

    Function IsCarFound(cars() As String, selected As String) As Boolean
        For Each car As String In cars
            If car = selected Then
                Return True
            End If
        Next

        Return False
    End Function


End Module


