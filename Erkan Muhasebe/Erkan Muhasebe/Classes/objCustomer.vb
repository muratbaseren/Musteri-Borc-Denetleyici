#Region "Imports"
#End Region

Public Class objCustomer


#Region "LocalVariables"
    Private CustomerID_ As Integer
    Private CustomerName_ As String
    Private CustomerSurname_ As String
    Private CustomerPhone_ As String
    Private CustomerCompany_ As String
    Private CustomerDescription_ As String
#End Region

#Region "Properties"
    Public Property CustomerID() As Integer
        Get
            Return Me.CustomerID_
        End Get
        Set(ByVal value As Integer)
            Me.CustomerID_ = value
        End Set
    End Property
    Public Property CustomerName() As String
        Get
            Return Me.CustomerName_
        End Get
        Set(ByVal value As String)
            Me.CustomerName_ = value
        End Set
    End Property
    Public Property CustomerSurname() As String
        Get
            Return Me.CustomerSurname_
        End Get
        Set(ByVal value As String)
            Me.CustomerSurname_ = value
        End Set
    End Property
    Public Property CustomerPhone() As String
        Get
            Return Me.CustomerPhone_
        End Get
        Set(ByVal value As String)
            Me.CustomerPhone_ = value
        End Set
    End Property
    Public Property CustomerCompany() As String
        Get
            Return Me.CustomerCompany_
        End Get
        Set(ByVal value As String)
            Me.CustomerCompany_ = value
        End Set
    End Property
    Public Property CustomerDescription() As String
        Get
            Return Me.CustomerDescription_
        End Get
        Set(ByVal value As String)
            Me.CustomerDescription_ = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
    End Sub

    Public Sub New(ByVal CustomerID As Integer, ByVal CustomerName As String, ByVal CustomerSurname As String, ByVal CustomerPhone As String)
        Me.CustomerID_ = CustomerID
        Me.CustomerName_ = CustomerName
        Me.CustomerSurname_ = CustomerSurname
        Me.CustomerPhone_ = CustomerPhone
    End Sub

    Public Sub New(ByVal CustomerID As Integer, ByVal CustomerName As String, ByVal CustomerSurname As String, ByVal CustomerPhone As String, ByVal CustomerCompany As String, ByVal CustomerDescription As String)
        Me.CustomerID_ = CustomerID
        Me.CustomerName_ = CustomerName
        Me.CustomerSurname_ = CustomerSurname
        Me.CustomerPhone_ = CustomerPhone
        Me.CustomerCompany_ = CustomerCompany
        Me.CustomerDescription_ = CustomerDescription
    End Sub

#End Region

#Region "Methods"
#End Region

End Class