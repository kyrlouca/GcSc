Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello Customer Account")
        Dim cust1 = New BankAccount(1, "John")
        cust1.CreditAccount(200)
        cust1.DebitAccount(300)
        Dim balance = cust1.GetBalance
        Console.WriteLine($"customer {cust1.OwnerName} has balance= {cust1.GetBalance}")

        cust1.DebitAccount(100)
        cust1.OwnerName = "Mark"
        Console.WriteLine($"customer {cust1.OwnerName} balance= {cust1.GetBalance}")


    End Sub
End Module
