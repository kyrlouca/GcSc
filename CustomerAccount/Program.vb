Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello Customer Account")
        Dim cust1 = New BankAccount(1, "John")
        cust1.CreditAccount(200)
        cust1.DebitAccount(300)
        Dim balance = cust1.Balance
        Console.WriteLine($"customer {cust1.OwnerName} has balance= {cust1.Balance}")

        cust1.DebitAccount(100)
        cust1.OwnerName = "Mark"
        Console.WriteLine($"customer {cust1.OwnerName} balance= {cust1.Balance}")


    End Sub
End Module
