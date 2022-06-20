Imports System


Module Program
    'records are by VALUE. 
    'they are eliminated from the STACK when the routing finishes. A record can NOT be passed around (only a copy)
    'No inheritance
    Public Structure Customer
        Public name As String
        Public height As Integer
        Public weight As Integer
        Public Sub New(name As String, height As Integer, weight As Integer)
            Me.name = name
            Me.height = height
            Me.weight = weight
        End Sub
    End Structure

    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Dim cust0 As Customer
        cust0.height = 3
        cust0.weight = 4
        Console.WriteLine($"height:{cust0.height}")


        Dim cust1 = New Customer("John", 200, 33)
        Console.WriteLine($"height:{cust1.height}")

        'Equlity creates new record (by VALUE)
        Dim cust2 = cust1
        cust2.height = 1000
        Console.WriteLine($"height1:{cust1.height} heiht2:{cust2.height}")

    End Sub
End Module
