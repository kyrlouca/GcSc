Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello Classes")

        Dim car1 = New Car("Mazda", 10000, 200)
        Dim carCost = car1.CalculateTotalValue()
        Console.WriteLine($"{car1.ShowDetails} cost:{carCost}")

        Dim truck1 = New Truck("Volov", 20000, 2)
        Dim truckCost = truck1.CalculateTotalValue
        Console.WriteLine($"truck cost:{carCost}")


        Dim bmw = New LuxuryCar("BMW", 30000, 2000, 3000)
        Dim lxCost = bmw.CalculateTotalValue
        Console.WriteLine($"{bmw.ShowDetails("Luxurius ")} cost:{carCost}")


    End Sub
End Module
