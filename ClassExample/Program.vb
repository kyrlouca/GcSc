Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim cust1 = New BankAccount(1, "John")
        cust1.CreditAccount(200)
        cust1.DebitAccount(300)
        Dim balance = cust1.GetBalance
        Console.WriteLine($"customer {cust1.OwnerName} has balance= {cust1.GetBalance}")


        cust1.DebitAccount(100)
        cust1.OwnerName = "Mark"
        Console.WriteLine($"customer {cust1.OwnerName} balance= {cust1.GetBalance}")


        Dim car1 = New Car("Mazda", 10000, 200)
        Dim cost = car1.CalculateCarValue()

        Dim truck1 = New Truck("Volov", 20000, 100)
        Dim trCost = truck1.CalculateCarValue




    End Sub
End Module
