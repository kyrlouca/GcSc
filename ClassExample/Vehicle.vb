'An abstract class which can NOT be instantiated
'It defines the necessary attributes and methods
'Derived classes must implement/override the methods 
'Derived classes may overload a method

'MustInherit makes the class abstract
Public MustInherit Class Vehicle
    Public ReadOnly brand As String
    Protected _basicValue As Integer

    Public Sub New(brand As String, basicValue As Integer)
        Me.brand = brand
        If basicValue < 0 Then
            _basicValue = 0
        Else
            _basicValue = basicValue
        End If

    End Sub

    Public MustOverride Function CalculateTotalValue() As Integer
    Public MustOverride Function ShowDetails() As String

End Class

'Derived class implments a constructor 
'Overrides a method 
Public Class Car
    Inherits Vehicle
    Protected _metallicPaintCost As Integer

    Overrides Function CalculateTotalValue() As Integer
        Return _basicValue + _metallicPaintCost
    End Function

    Public Overrides Function ShowDetails() As String
        Return $"brand {brand} cost:{CalculateTotalValue()}"
    End Function

    Public Sub New(brand As String, basicCost As Integer, metallicPaintCost As Integer)
        MyBase.New(brand, basicCost)
        _metallicPaintCost = metallicPaintCost
    End Sub
End Class


'Another derived class
Public Class Truck
    Inherits Vehicle
    Private _maxLoadKg As Integer

    Public Sub New(brand As String, basicCost As Integer, maxLoadKg As Integer)
        MyBase.New(brand, basicCost)
        _maxLoadKg = maxLoadKg
    End Sub

    Public Overrides Function CalculateTotalValue() As Integer
        Return _basicValue + _maxLoadKg * 100
    End Function

    Public Overrides Function ShowDetails() As String
        Return $"brand {brand} cost:{CalculateTotalValue()}"
    End Function
End Class


'Derive the class from Another Class
'Overload the method CalculateCarValue because it should include "leatherCost"
Public Class LuxuryCar
    Inherits Car
    Private _leatherCost As Integer

    Public Sub New(brand As String, basicCost As Integer, metallicPaintCost As Integer, leatherCost As Integer)
        MyBase.New(brand, basicCost, metallicPaintCost)
        _leatherCost = leatherCost
    End Sub

    Function CalculateCarValue() As Integer
        Return _basicValue + _metallicPaintCost + _leatherCost
    End Function
    Public Overrides Function ShowDetails() As String
        Return $"brand {brand} cost:{CalculateTotalValue()}"
    End Function

    Public Overloads Function ShowDetails(title As String) As String
        Return $"{title} {brand} cost:{CalculateTotalValue()}"
    End Function

End Class

