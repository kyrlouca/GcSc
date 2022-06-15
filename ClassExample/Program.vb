Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim cust1 = New CustomerAccount(1, "John")
        cust1.CreditAccount(200)
        cust1.DebitAccount(300)
        Dim balance = cust1.GetBalance
        Console.WriteLine($"customer {cust1.GetName} has balance= {cust1.GetBalance}")


        cust1.DebitAccount(100)
        Console.WriteLine($"customer {cust1.GetName} balance= {cust1.GetBalance}")

    End Sub
End Module
