Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello Classes")

        Dim car1 = New Car("Mazda", 10000, 200)
        Dim carCost = car1.CalculateTotalValue()
        Console.WriteLine($"car value {carCost}")

        Dim truck1 = New Truck("Volov", 20000, 2)
        Dim truckCost = truck1.CalculateTotalValue
        Console.WriteLine($"Truck value {truckCost}")

        Dim luxury = New LuxuryCar("BMW", 30000, 2000, 3000)
        Dim lxCost = Luxury.CalculateTotalValue
        Console.WriteLine($"BMW value {lxCost}")

    End Sub
End Module
