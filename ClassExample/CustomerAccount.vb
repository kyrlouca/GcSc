Public Class CustomerAccount
    Private Balance As Double
    Private Id As Integer
    Private Owner As String

    Public Sub New(id As Integer, owner As String)
        Balance = 0
        Me.Id = id
        Me.Owner = owner
    End Sub

    Public Function GetBalance() As Double
        Return Balance
    End Function

    Public Function GetName() As String
        Return Owner
    End Function

    Function GetId() As String
        Return Id
    End Function
    Public Function CreditAccount(Amount As Double) As Boolean
        If (Amount <= 0) Then
            Return False
        End If
        Balance = Balance + Amount
        Return True
    End Function
    Public Function DebitAccount(Amount As Double) As Boolean
        If (Amount <= 0) Then
            Return False
        End If
        If (Balance - Amount < 0) Then
            Return False
        End If
        Balance = Balance - Amount
        Return True
    End Function


End Class
