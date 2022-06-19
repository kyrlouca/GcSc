Public Class BankAccount
    Private _balance As Double
    Private ReadOnly id As Integer
    Private _ownerName As String


    Public Property OwnerName() As String
        Get
            Return _ownerName
        End Get
        Set(name As String)
            _ownerName = name
        End Set
    End Property


    Public Sub New(id As Integer, ownerName As String)
        _balance = 0
        Me.id = id
        _ownerName = ownerName
    End Sub


    Public Function GetBalance() As Double
        Return _balance
    End Function


    Function GetId() As String
        Return id
    End Function
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
