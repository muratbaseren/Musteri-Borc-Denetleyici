#Region "Imports"
#End Region

Public Class objProduct


#Region "LocalVariables"
    Private ProductID_ As Integer
    Private ProductName_ As String
    Private ProductCategoryID_ As Integer
    Private ProductCategoryName_ As String
    Private ProductUnit_ As Integer
    Private ProductUnitPrice_ As String
    Private ProductIsCategory_ As Boolean
    Private ProductDescription_ As String
#End Region

#Region "Properties"
    Public Property ProductID() As Integer
        Get
            Return Me.ProductID_
        End Get
        Set(ByVal value As Integer)
            Me.ProductID_ = value
        End Set
    End Property
    Public Property ProductName() As String
        Get
            Return Me.ProductName_
        End Get
        Set(ByVal value As String)
            Me.ProductName_ = value
        End Set
    End Property
    Public Property ProductCategoryID() As Integer
        Get
            Return Me.ProductCategoryID_
        End Get
        Set(ByVal value As Integer)
            Me.ProductCategoryID_ = value
        End Set
    End Property
    Public Property ProductCategoryName() As String
        Get
            Return Me.ProductCategoryName_
        End Get
        Set(ByVal value As String)
            Me.ProductCategoryName_ = value
        End Set
    End Property
    Public Property ProductUnit() As Integer
        Get
            Return Me.ProductUnit_
        End Get
        Set(ByVal value As Integer)
            Me.ProductUnit_ = value
        End Set
    End Property
    Public Property ProductUnitPrice() As String
        Get
            Return Me.ProductUnitPrice_
        End Get
        Set(ByVal value As String)
            Me.ProductUnitPrice_ = value
        End Set
    End Property
    Public Property ProductIsCategory() As Boolean
        Get
            Return Me.ProductIsCategory_
        End Get
        Set(ByVal value As Boolean)
            Me.ProductIsCategory_ = value
        End Set
    End Property
    Public Property ProductDescription() As String
        Get
            Return Me.ProductDescription_
        End Get
        Set(ByVal value As String)
            Me.ProductDescription_ = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
    End Sub

    Public Sub New(ByVal ProductID As Integer, ByVal ProductName As String, ByVal ProductCategoryID As Integer, ByVal ProductCategoryName As String, ByVal ProductUnit As Integer, ByVal ProductUnitPrice As String, ByVal ProductIsCategory As Boolean, ByVal ProductDescription As String)
        Me.ProductID_ = ProductID
        Me.ProductName_ = ProductName
        Me.ProductCategoryID_ = ProductCategoryID
        Me.ProductCategoryName_ = ProductCategoryName
        Me.ProductUnit_ = ProductUnit
        Me.ProductUnitPrice_ = ProductUnitPrice
        Me.ProductIsCategory_ = ProductIsCategory
        Me.ProductDescription_ = ProductDescription
    End Sub

#End Region

#Region "Methods"
#End Region

End Class