Public Class BankAccount
    Private ReadOnly id As Integer ' ReadOnly since we should never change the Id
    Private _ownerName As String
    Private _balance As Double

    Function GetId() As String
        Return id
    End Function

    'We could have used an attribute because there are is no checking or manipulation of the attribute
    'However, we still use an attribute bucause we may change it in the future
    Public Property OwnerName() As String
        Get
            Return _ownerName
        End Get
        Set(name As String)
            _ownerName = name
        End Set
    End Property

    'use the Me to refer to the object created in the constructor
    Public Sub New(id As Integer, ownerName As String)
        _balance = 0
        Me.id = id
        _ownerName = ownerName
    End Sub


    'the Balance is read only because we have specialized functions for credit/debit
    Public ReadOnly Property Balance() As Double
        Get
            Return _balance
        End Get
    End Property


    'specialized functions for changing the balance
    Public Function CreditAccount(Amount As Double) As Boolean
        If (Amount <= 0) Then
            Return False
        End If
        _balance = _balance + Amount
        Return True
    End Function
    Public Function DebitAccount(Amount As Double) As Boolean
        If (Amount <= 0) Then
            Return False
        End If
        If (_balance - Amount < 0) Then
            Return False
        End If
        _balance -= Amount
        Return True
    End Function


End Class
