#Region "Imports"
#End Region

Public Class objCustomerEmployee


#Region "LocalVariables"
    Private EmployeeID_ As Integer
    Private EmployeeCustomerID_ As Integer
    Private EmployeeProductID_ As Integer
    Private EmployeeProductName_ As String
    Private EmployeeDate_ As Date
    Private EmployeeUnit_ As Integer
    Private EmployeeUnitPrice_ As String
    Private EmployeeTotal_ As String
    Private EmployeeComingTotal_ As String
    Private EmployeeIsDolar_ As Boolean
    Private EmployeeDescription_ As String
#End Region

#Region "Properties"
    Public Property EmployeeID() As Integer
        Get
            Return Me.EmployeeID_
        End Get
        Set(ByVal value As Integer)
            Me.EmployeeID_ = value
        End Set
    End Property
    Public Property EmployeeCustomerID() As Integer
        Get
            Return Me.EmployeeCustomerID_
        End Get
        Set(ByVal value As Integer)
            Me.EmployeeCustomerID_ = value
        End Set
    End Property
    Public Property EmployeeProductID() As Integer
        Get
            Return Me.EmployeeProductID_
        End Get
        Set(ByVal value As Integer)
            Me.EmployeeProductID_ = value
        End Set
    End Property
    Public Property EmployeeProductName() As String
        Get
            Return Me.EmployeeProductName_
        End Get
        Set(ByVal value As String)
            Me.EmployeeProductName_ = value
        End Set
    End Property
    Public Property EmployeeDate() As Date
        Get
            Return Me.EmployeeDate_
        End Get
        Set(ByVal value As Date)
            Me.EmployeeDate_ = value
        End Set
    End Property
    Public Property EmployeeUnit() As Integer
        Get
            Return Me.EmployeeUnit_
        End Get
        Set(ByVal value As Integer)
            Me.EmployeeUnit_ = value
        End Set
    End Property
    Public Property EmployeeUnitPrice() As String
        Get
            Return Me.EmployeeUnitPrice_
        End Get
        Set(ByVal value As String)
            Me.EmployeeUnitPrice_ = value
        End Set
    End Property
    Public Property EmployeeTotal() As String
        Get
            Return Me.EmployeeTotal_
        End Get
        Set(ByVal value As String)
            Me.EmployeeTotal_ = value
        End Set
    End Property
    Public Property EmployeeComingTotal() As String
        Get
            Return Me.EmployeeComingTotal_
        End Get
        Set(ByVal value As String)
            Me.EmployeeComingTotal_ = value
        End Set
    End Property
    Public Property EmployeeIsDolar() As Boolean
        Get
            Return Me.EmployeeIsDolar_
        End Get
        Set(ByVal value As Boolean)
            Me.EmployeeIsDolar_ = value
        End Set
    End Property
    Public Property EmployeeDescription() As String
        Get
            Return Me.EmployeeDescription_
        End Get
        Set(ByVal value As String)
            Me.EmployeeDescription_ = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
    End Sub

    Public Sub New(ByVal EmployeeID As Integer, ByVal EmployeeCustomerID As Integer, ByVal EmployeeProductID As Integer, ByVal EmployeeProductName As String, ByVal EmployeeDate As Date, ByVal EmployeeUnit As Integer, ByVal EmployeeUnitPrice As String, ByVal EmployeeTotal As String, ByVal EmployeeComingTotal As String, ByVal EmployeeIsDolar As Boolean, ByVal EmployeeDescription As String)
        Me.EmployeeID_ = EmployeeID
        Me.EmployeeCustomerID_ = EmployeeCustomerID
        Me.EmployeeProductID_ = EmployeeProductID
        Me.EmployeeProductName_ = EmployeeProductName
        Me.EmployeeDate_ = EmployeeDate
        Me.EmployeeUnit_ = EmployeeUnit
        Me.EmployeeUnitPrice_ = EmployeeUnitPrice
        Me.EmployeeTotal_ = EmployeeTotal
        Me.EmployeeComingTotal_ = EmployeeComingTotal
        Me.EmployeeIsDolar_ = EmployeeIsDolar
        Me.EmployeeDescription_ = EmployeeDescription
    End Sub

#End Region

#Region "Methods"
#End Region

End Class