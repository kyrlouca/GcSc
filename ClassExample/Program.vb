Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")

        Dim car1 = New Car("Mazda", 10000, 200)
        Dim cost = car1.CalculateCarValue()

        Dim truck1 = New Truck("Volov", 20000, 100)
        Dim trCost = truck1.CalculateCarValue


    End Sub
End Module
