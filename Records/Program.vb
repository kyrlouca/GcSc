Imports System


Module Program

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

        Dim cust1 = New Customer()
        cust1.height = 20
        Console.WriteLine($"height:{cust1.height}")

        Dim cust2 = New Customer("John", 200, 33)
        Console.WriteLine($"height:{cust2.height}")

        Dim cust3 = cust2
        cust3.height = 1000
        Console.WriteLine($"height2:{cust2.height} heiht3:{cust3.height}")

    End Sub
End Module
