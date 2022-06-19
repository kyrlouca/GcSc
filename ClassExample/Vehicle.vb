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

    Public MustOverride Function CalculateCarValue() As Integer

End Class

Public Class Car
    Inherits Vehicle
    Private _metallicPaintCost As Integer

    Overrides Function CalculateCarValue() As Integer
        Return _basicValue + _metallicPaintCost
    End Function



    Public Sub New(brand As String, basicCost As Integer, metallicPaintCost As Integer)
        MyBase.New(brand, basicCost)
        _metallicPaintCost = metallicPaintCost
    End Sub
End Class


Public Class Truck
    Inherits Vehicle
    Private _maxLoadKg As Integer

    Public Sub New(brand As String, basicCost As Integer, maxLoadKg As Integer)
        MyBase.New(brand, basicCost)
        _maxLoadKg = maxLoadKg
    End Sub

    Public Overrides Function CalculateCarValue() As Integer
        Return _basicValue + _maxLoadKg * 100
    End Function

End Class
