<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.grpCustomers = New System.Windows.Forms.GroupBox()
        Me.pnlCustomers = New System.Windows.Forms.Panel()
        Me.trvCustomers = New System.Windows.Forms.TreeView()
        Me.imgList = New System.Windows.Forms.ImageList(Me.components)
        Me.sstCustomers = New System.Windows.Forms.StatusStrip()
        Me.tsslCustomerCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsCustomers = New System.Windows.Forms.ToolStrip()
        Me.btnCustomerAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnCustomerEdit = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnCustomerDelete = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.grpProducts = New System.Windows.Forms.GroupBox()
        Me.pnlProducts = New System.Windows.Forms.Panel()
        Me.trvProducts = New System.Windows.Forms.TreeView()
        Me.conProduct = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmnuProductEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuProductDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuCategoryAdd = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuCategoryEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuCategoryDel = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmnuProductMove = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmnuProductDetails = New System.Windows.Forms.ToolStripMenuItem()
        Me.sstProducts = New System.Windows.Forms.StatusStrip()
        Me.tsslProductCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsProducts = New System.Windows.Forms.ToolStrip()
        Me.btnProductAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnProductEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnProductDelete = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnProductAddCategory = New System.Windows.Forms.ToolStripButton()
        Me.btnProductEditCategory = New System.Windows.Forms.ToolStripButton()
        Me.btnProductDelCategory = New System.Windows.Forms.ToolStripButton()
        Me.Splitter2 = New System.Windows.Forms.Splitter()
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.pnlCustomerDetails = New System.Windows.Forms.Panel()
        Me.pnlCustomerDetailsList = New System.Windows.Forms.Panel()
        Me.tsCustomerDetails = New System.Windows.Forms.ToolStrip()
        Me.btnEmployeeAdd = New System.Windows.Forms.ToolStripButton()
        Me.btnEmployeeEdit = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnEmployeeDel = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.sstCustomerDetails = New System.Windows.Forms.StatusStrip()
        Me.tsslCustDetailsEmpCount = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslUSDPrice = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsslYTLPrice = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.grpCustomers.SuspendLayout()
        Me.pnlCustomers.SuspendLayout()
        Me.sstCustomers.SuspendLayout()
        Me.tsCustomers.SuspendLayout()
        Me.grpProducts.SuspendLayout()
        Me.pnlProducts.SuspendLayout()
        Me.conProduct.SuspendLayout()
        Me.sstProducts.SuspendLayout()
        Me.tsProducts.SuspendLayout()
        Me.grpCustomerDetails.SuspendLayout()
        Me.pnlCustomerDetails.SuspendLayout()
        Me.tsCustomerDetails.SuspendLayout()
        Me.sstCustomerDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCustomers
        '
        Me.grpCustomers.Controls.Add(Me.pnlCustomers)
        Me.grpCustomers.Controls.Add(Me.sstCustomers)
        Me.grpCustomers.Controls.Add(Me.tsCustomers)
        Me.grpCustomers.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpCustomers.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpCustomers.Location = New System.Drawing.Point(8, 8)
        Me.grpCustomers.Name = "grpCustomers"
        Me.grpCustomers.Padding = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.grpCustomers.Size = New System.Drawing.Size(229, 401)
        Me.grpCustomers.TabIndex = 0
        Me.grpCustomers.TabStop = False
        Me.grpCustomers.Text = "Müþteriler"
        '
        'pnlCustomers
        '
        Me.pnlCustomers.Controls.Add(Me.trvCustomers)
        Me.pnlCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCustomers.Location = New System.Drawing.Point(3, 73)
        Me.pnlCustomers.Name = "pnlCustomers"
        Me.pnlCustomers.Size = New System.Drawing.Size(223, 303)
        Me.pnlCustomers.TabIndex = 2
        '
        'trvCustomers
        '
        Me.trvCustomers.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvCustomers.ImageIndex = 0
        Me.trvCustomers.ImageList = Me.imgList
        Me.trvCustomers.Location = New System.Drawing.Point(0, 0)
        Me.trvCustomers.Name = "trvCustomers"
        Me.trvCustomers.SelectedImageIndex = 0
        Me.trvCustomers.ShowNodeToolTips = True
        Me.trvCustomers.Size = New System.Drawing.Size(223, 303)
        Me.trvCustomers.TabIndex = 0
        '
        'imgList
        '
        Me.imgList.ImageStream = CType(resources.GetObject("imgList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imgList.TransparentColor = System.Drawing.Color.Transparent
        Me.imgList.Images.SetKeyName(0, "User.ico")
        Me.imgList.Images.SetKeyName(1, "Recycle Bin(Full).ico")
        Me.imgList.Images.SetKeyName(2, "Drop-Box-32x32.png")
        '
        'sstCustomers
        '
        Me.sstCustomers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslCustomerCount})
        Me.sstCustomers.Location = New System.Drawing.Point(3, 376)
        Me.sstCustomers.Name = "sstCustomers"
        Me.sstCustomers.Size = New System.Drawing.Size(223, 22)
        Me.sstCustomers.TabIndex = 1
        Me.sstCustomers.Text = "StatusStrip1"
        '
        'tsslCustomerCount
        '
        Me.tsslCustomerCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslCustomerCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslCustomerCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsslCustomerCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.tsslCustomerCount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.tsslCustomerCount.Name = "tsslCustomerCount"
        Me.tsslCustomerCount.Size = New System.Drawing.Size(4, 17)
        '
        'tsCustomers
        '
        Me.tsCustomers.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsCustomers.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCustomerAdd, Me.btnCustomerEdit, Me.toolStripSeparator3, Me.btnCustomerDelete, Me.toolStripSeparator4})
        Me.tsCustomers.Location = New System.Drawing.Point(3, 19)
        Me.tsCustomers.Name = "tsCustomers"
        Me.tsCustomers.Size = New System.Drawing.Size(223, 54)
        Me.tsCustomers.TabIndex = 0
        Me.tsCustomers.Text = "ToolStrip1"
        '
        'btnCustomerAdd
        '
        Me.btnCustomerAdd.Image = CType(resources.GetObject("btnCustomerAdd.Image"), System.Drawing.Image)
        Me.btnCustomerAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustomerAdd.Name = "btnCustomerAdd"
        Me.btnCustomerAdd.Size = New System.Drawing.Size(61, 51)
        Me.btnCustomerAdd.Text = "Müþ. Ekle"
        Me.btnCustomerAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnCustomerEdit
        '
        Me.btnCustomerEdit.Image = CType(resources.GetObject("btnCustomerEdit.Image"), System.Drawing.Image)
        Me.btnCustomerEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustomerEdit.Name = "btnCustomerEdit"
        Me.btnCustomerEdit.Size = New System.Drawing.Size(73, 51)
        Me.btnCustomerEdit.Text = "Müþ. Düzelt"
        Me.btnCustomerEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 54)
        '
        'btnCustomerDelete
        '
        Me.btnCustomerDelete.Image = CType(resources.GetObject("btnCustomerDelete.Image"), System.Drawing.Image)
        Me.btnCustomerDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCustomerDelete.Name = "btnCustomerDelete"
        Me.btnCustomerDelete.Size = New System.Drawing.Size(52, 51)
        Me.btnCustomerDelete.Text = "Müþ. Sil"
        Me.btnCustomerDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 54)
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(237, 8)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 401)
        Me.Splitter1.TabIndex = 1
        Me.Splitter1.TabStop = False
        '
        'grpProducts
        '
        Me.grpProducts.Controls.Add(Me.pnlProducts)
        Me.grpProducts.Controls.Add(Me.sstProducts)
        Me.grpProducts.Controls.Add(Me.tsProducts)
        Me.grpProducts.Dock = System.Windows.Forms.DockStyle.Right
        Me.grpProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpProducts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpProducts.Location = New System.Drawing.Point(800, 8)
        Me.grpProducts.Name = "grpProducts"
        Me.grpProducts.Padding = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.grpProducts.Size = New System.Drawing.Size(248, 401)
        Me.grpProducts.TabIndex = 2
        Me.grpProducts.TabStop = False
        Me.grpProducts.Text = "Ürünler"
        '
        'pnlProducts
        '
        Me.pnlProducts.Controls.Add(Me.trvProducts)
        Me.pnlProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlProducts.Location = New System.Drawing.Point(3, 73)
        Me.pnlProducts.Name = "pnlProducts"
        Me.pnlProducts.Size = New System.Drawing.Size(242, 303)
        Me.pnlProducts.TabIndex = 3
        '
        'trvProducts
        '
        Me.trvProducts.AllowDrop = True
        Me.trvProducts.ContextMenuStrip = Me.conProduct
        Me.trvProducts.Dock = System.Windows.Forms.DockStyle.Fill
        Me.trvProducts.ImageIndex = 1
        Me.trvProducts.ImageList = Me.imgList
        Me.trvProducts.Location = New System.Drawing.Point(0, 0)
        Me.trvProducts.Name = "trvProducts"
        Me.trvProducts.SelectedImageIndex = 1
        Me.trvProducts.ShowNodeToolTips = True
        Me.trvProducts.Size = New System.Drawing.Size(242, 303)
        Me.trvProducts.TabIndex = 1
        '
        'conProduct
        '
        Me.conProduct.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmnuProductEdit, Me.cmnuProductDel, Me.ToolStripMenuItem1, Me.cmnuCategoryAdd, Me.cmnuCategoryEdit, Me.cmnuCategoryDel, Me.ToolStripMenuItem2, Me.cmnuProductMove, Me.cmnuProductDetails})
        Me.conProduct.Name = "conProduct"
        Me.conProduct.Size = New System.Drawing.Size(180, 170)
        '
        'cmnuProductEdit
        '
        Me.cmnuProductEdit.Image = CType(resources.GetObject("cmnuProductEdit.Image"), System.Drawing.Image)
        Me.cmnuProductEdit.Name = "cmnuProductEdit"
        Me.cmnuProductEdit.Size = New System.Drawing.Size(179, 22)
        Me.cmnuProductEdit.Text = "Ürün Düzelt"
        '
        'cmnuProductDel
        '
        Me.cmnuProductDel.Image = CType(resources.GetObject("cmnuProductDel.Image"), System.Drawing.Image)
        Me.cmnuProductDel.Name = "cmnuProductDel"
        Me.cmnuProductDel.Size = New System.Drawing.Size(179, 22)
        Me.cmnuProductDel.Text = "Ürün Sil"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(176, 6)
        '
        'cmnuCategoryAdd
        '
        Me.cmnuCategoryAdd.Image = CType(resources.GetObject("cmnuCategoryAdd.Image"), System.Drawing.Image)
        Me.cmnuCategoryAdd.Name = "cmnuCategoryAdd"
        Me.cmnuCategoryAdd.Size = New System.Drawing.Size(179, 22)
        Me.cmnuCategoryAdd.Text = "Kategori Ekle"
        '
        'cmnuCategoryEdit
        '
        Me.cmnuCategoryEdit.Image = CType(resources.GetObject("cmnuCategoryEdit.Image"), System.Drawing.Image)
        Me.cmnuCategoryEdit.Name = "cmnuCategoryEdit"
        Me.cmnuCategoryEdit.Size = New System.Drawing.Size(179, 22)
        Me.cmnuCategoryEdit.Text = "Kategori Ismi Düzelt"
        '
        'cmnuCategoryDel
        '
        Me.cmnuCategoryDel.Image = CType(resources.GetObject("cmnuCategoryDel.Image"), System.Drawing.Image)
        Me.cmnuCategoryDel.Name = "cmnuCategoryDel"
        Me.cmnuCategoryDel.Size = New System.Drawing.Size(179, 22)
        Me.cmnuCategoryDel.Text = "Kategori Sil"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(176, 6)
        '
        'cmnuProductMove
        '
        Me.cmnuProductMove.Image = CType(resources.GetObject("cmnuProductMove.Image"), System.Drawing.Image)
        Me.cmnuProductMove.Name = "cmnuProductMove"
        Me.cmnuProductMove.Size = New System.Drawing.Size(179, 22)
        Me.cmnuProductMove.Text = "Ürün Taþý"
        '
        'cmnuProductDetails
        '
        Me.cmnuProductDetails.Image = CType(resources.GetObject("cmnuProductDetails.Image"), System.Drawing.Image)
        Me.cmnuProductDetails.Name = "cmnuProductDetails"
        Me.cmnuProductDetails.Size = New System.Drawing.Size(179, 22)
        Me.cmnuProductDetails.Text = "Özellikleri"
        '
        'sstProducts
        '
        Me.sstProducts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslProductCount})
        Me.sstProducts.Location = New System.Drawing.Point(3, 376)
        Me.sstProducts.Name = "sstProducts"
        Me.sstProducts.Size = New System.Drawing.Size(242, 22)
        Me.sstProducts.TabIndex = 1
        Me.sstProducts.Text = "StatusStrip2"
        '
        'tsslProductCount
        '
        Me.tsslProductCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslProductCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslProductCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsslProductCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.tsslProductCount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.tsslProductCount.Name = "tsslProductCount"
        Me.tsslProductCount.Size = New System.Drawing.Size(4, 17)
        '
        'tsProducts
        '
        Me.tsProducts.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsProducts.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnProductAdd, Me.btnProductEdit, Me.btnProductDelete, Me.ToolStripSeparator2, Me.btnProductAddCategory, Me.btnProductEditCategory, Me.btnProductDelCategory})
        Me.tsProducts.Location = New System.Drawing.Point(3, 19)
        Me.tsProducts.Name = "tsProducts"
        Me.tsProducts.Size = New System.Drawing.Size(242, 54)
        Me.tsProducts.TabIndex = 0
        Me.tsProducts.Text = "ToolStrip2"
        '
        'btnProductAdd
        '
        Me.btnProductAdd.Image = CType(resources.GetObject("btnProductAdd.Image"), System.Drawing.Image)
        Me.btnProductAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProductAdd.Name = "btnProductAdd"
        Me.btnProductAdd.Size = New System.Drawing.Size(61, 51)
        Me.btnProductAdd.Text = "Ürün Ekle"
        Me.btnProductAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnProductEdit
        '
        Me.btnProductEdit.Image = CType(resources.GetObject("btnProductEdit.Image"), System.Drawing.Image)
        Me.btnProductEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProductEdit.Name = "btnProductEdit"
        Me.btnProductEdit.Size = New System.Drawing.Size(70, 51)
        Me.btnProductEdit.Text = "Ürün Düzet"
        Me.btnProductEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnProductDelete
        '
        Me.btnProductDelete.Image = CType(resources.GetObject("btnProductDelete.Image"), System.Drawing.Image)
        Me.btnProductDelete.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProductDelete.Name = "btnProductDelete"
        Me.btnProductDelete.Size = New System.Drawing.Size(52, 51)
        Me.btnProductDelete.Text = "Ürün Sil"
        Me.btnProductDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 54)
        '
        'btnProductAddCategory
        '
        Me.btnProductAddCategory.Image = CType(resources.GetObject("btnProductAddCategory.Image"), System.Drawing.Image)
        Me.btnProductAddCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProductAddCategory.Name = "btnProductAddCategory"
        Me.btnProductAddCategory.Size = New System.Drawing.Size(79, 51)
        Me.btnProductAddCategory.Text = "Kategori Ekle"
        Me.btnProductAddCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnProductEditCategory
        '
        Me.btnProductEditCategory.Image = CType(resources.GetObject("btnProductEditCategory.Image"), System.Drawing.Image)
        Me.btnProductEditCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProductEditCategory.Name = "btnProductEditCategory"
        Me.btnProductEditCategory.Size = New System.Drawing.Size(116, 51)
        Me.btnProductEditCategory.Text = "Kategori Ismi Düzelt"
        Me.btnProductEditCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnProductDelCategory
        '
        Me.btnProductDelCategory.Image = CType(resources.GetObject("btnProductDelCategory.Image"), System.Drawing.Image)
        Me.btnProductDelCategory.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnProductDelCategory.Name = "btnProductDelCategory"
        Me.btnProductDelCategory.Size = New System.Drawing.Size(70, 51)
        Me.btnProductDelCategory.Text = "Kategori Sil"
        Me.btnProductDelCategory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'Splitter2
        '
        Me.Splitter2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Splitter2.Location = New System.Drawing.Point(797, 8)
        Me.Splitter2.Name = "Splitter2"
        Me.Splitter2.Size = New System.Drawing.Size(3, 401)
        Me.Splitter2.TabIndex = 3
        Me.Splitter2.TabStop = False
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.Controls.Add(Me.pnlCustomerDetails)
        Me.grpCustomerDetails.Controls.Add(Me.sstCustomerDetails)
        Me.grpCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grpCustomerDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.grpCustomerDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpCustomerDetails.Location = New System.Drawing.Point(240, 8)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Padding = New System.Windows.Forms.Padding(3, 5, 3, 3)
        Me.grpCustomerDetails.Size = New System.Drawing.Size(557, 401)
        Me.grpCustomerDetails.TabIndex = 4
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Text = "Müþteri Detaylarý"
        '
        'pnlCustomerDetails
        '
        Me.pnlCustomerDetails.Controls.Add(Me.pnlCustomerDetailsList)
        Me.pnlCustomerDetails.Controls.Add(Me.tsCustomerDetails)
        Me.pnlCustomerDetails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCustomerDetails.Location = New System.Drawing.Point(3, 19)
        Me.pnlCustomerDetails.Name = "pnlCustomerDetails"
        Me.pnlCustomerDetails.Size = New System.Drawing.Size(551, 357)
        Me.pnlCustomerDetails.TabIndex = 3
        '
        'pnlCustomerDetailsList
        '
        Me.pnlCustomerDetailsList.AutoScroll = True
        Me.pnlCustomerDetailsList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlCustomerDetailsList.Location = New System.Drawing.Point(0, 54)
        Me.pnlCustomerDetailsList.Name = "pnlCustomerDetailsList"
        Me.pnlCustomerDetailsList.Size = New System.Drawing.Size(551, 303)
        Me.pnlCustomerDetailsList.TabIndex = 2
        '
        'tsCustomerDetails
        '
        Me.tsCustomerDetails.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tsCustomerDetails.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEmployeeAdd, Me.btnEmployeeEdit, Me.toolStripSeparator5, Me.btnEmployeeDel, Me.toolStripSeparator6})
        Me.tsCustomerDetails.Location = New System.Drawing.Point(0, 0)
        Me.tsCustomerDetails.Name = "tsCustomerDetails"
        Me.tsCustomerDetails.Size = New System.Drawing.Size(551, 54)
        Me.tsCustomerDetails.TabIndex = 1
        Me.tsCustomerDetails.Text = "ToolStrip1"
        '
        'btnEmployeeAdd
        '
        Me.btnEmployeeAdd.Image = CType(resources.GetObject("btnEmployeeAdd.Image"), System.Drawing.Image)
        Me.btnEmployeeAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmployeeAdd.Name = "btnEmployeeAdd"
        Me.btnEmployeeAdd.Size = New System.Drawing.Size(69, 51)
        Me.btnEmployeeAdd.Text = "Sipariþ Ekle"
        Me.btnEmployeeAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'btnEmployeeEdit
        '
        Me.btnEmployeeEdit.Image = CType(resources.GetObject("btnEmployeeEdit.Image"), System.Drawing.Image)
        Me.btnEmployeeEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmployeeEdit.Name = "btnEmployeeEdit"
        Me.btnEmployeeEdit.Size = New System.Drawing.Size(81, 51)
        Me.btnEmployeeEdit.Text = "Sipariþ Düzelt"
        Me.btnEmployeeEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 54)
        '
        'btnEmployeeDel
        '
        Me.btnEmployeeDel.Image = CType(resources.GetObject("btnEmployeeDel.Image"), System.Drawing.Image)
        Me.btnEmployeeDel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEmployeeDel.Name = "btnEmployeeDel"
        Me.btnEmployeeDel.Size = New System.Drawing.Size(60, 51)
        Me.btnEmployeeDel.Text = "Sipariþ Sil"
        Me.btnEmployeeDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 54)
        '
        'sstCustomerDetails
        '
        Me.sstCustomerDetails.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslCustDetailsEmpCount, Me.tsslUSDPrice, Me.tsslYTLPrice})
        Me.sstCustomerDetails.Location = New System.Drawing.Point(3, 376)
        Me.sstCustomerDetails.Name = "sstCustomerDetails"
        Me.sstCustomerDetails.Size = New System.Drawing.Size(551, 22)
        Me.sstCustomerDetails.TabIndex = 0
        Me.sstCustomerDetails.Text = "StatusStrip3"
        '
        'tsslCustDetailsEmpCount
        '
        Me.tsslCustDetailsEmpCount.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslCustDetailsEmpCount.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslCustDetailsEmpCount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsslCustDetailsEmpCount.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.tsslCustDetailsEmpCount.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.tsslCustDetailsEmpCount.Name = "tsslCustDetailsEmpCount"
        Me.tsslCustDetailsEmpCount.Size = New System.Drawing.Size(4, 17)
        '
        'tsslUSDPrice
        '
        Me.tsslUSDPrice.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslUSDPrice.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslUSDPrice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsslUSDPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.tsslUSDPrice.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.tsslUSDPrice.Name = "tsslUSDPrice"
        Me.tsslUSDPrice.Size = New System.Drawing.Size(4, 17)
        '
        'tsslYTLPrice
        '
        Me.tsslYTLPrice.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.tsslYTLPrice.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.tsslYTLPrice.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsslYTLPrice.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic)
        Me.tsslYTLPrice.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.tsslYTLPrice.Name = "tsslYTLPrice"
        Me.tsslYTLPrice.Size = New System.Drawing.Size(4, 17)
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Bilgi :"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 417)
        Me.Controls.Add(Me.grpCustomerDetails)
        Me.Controls.Add(Me.Splitter2)
        Me.Controls.Add(Me.grpProducts)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.grpCustomers)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Padding = New System.Windows.Forms.Padding(8)
        Me.Text = "Müþteri Sipariþ Borç Detaylarý"
        Me.grpCustomers.ResumeLayout(False)
        Me.grpCustomers.PerformLayout()
        Me.pnlCustomers.ResumeLayout(False)
        Me.sstCustomers.ResumeLayout(False)
        Me.sstCustomers.PerformLayout()
        Me.tsCustomers.ResumeLayout(False)
        Me.tsCustomers.PerformLayout()
        Me.grpProducts.ResumeLayout(False)
        Me.grpProducts.PerformLayout()
        Me.pnlProducts.ResumeLayout(False)
        Me.conProduct.ResumeLayout(False)
        Me.sstProducts.ResumeLayout(False)
        Me.sstProducts.PerformLayout()
        Me.tsProducts.ResumeLayout(False)
        Me.tsProducts.PerformLayout()
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.grpCustomerDetails.PerformLayout()
        Me.pnlCustomerDetails.ResumeLayout(False)
        Me.pnlCustomerDetails.PerformLayout()
        Me.tsCustomerDetails.ResumeLayout(False)
        Me.tsCustomerDetails.PerformLayout()
        Me.sstCustomerDetails.ResumeLayout(False)
        Me.sstCustomerDetails.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCustomers As System.Windows.Forms.GroupBox
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents grpProducts As System.Windows.Forms.GroupBox
    Friend WithEvents Splitter2 As System.Windows.Forms.Splitter
    Friend WithEvents grpCustomerDetails As System.Windows.Forms.GroupBox
    Friend WithEvents sstCustomers As System.Windows.Forms.StatusStrip
    Friend WithEvents tsCustomers As System.Windows.Forms.ToolStrip
    Friend WithEvents sstProducts As System.Windows.Forms.StatusStrip
    Friend WithEvents tsProducts As System.Windows.Forms.ToolStrip
    Friend WithEvents pnlCustomers As System.Windows.Forms.Panel
    Friend WithEvents pnlProducts As System.Windows.Forms.Panel
    Friend WithEvents pnlCustomerDetails As System.Windows.Forms.Panel
    Friend WithEvents sstCustomerDetails As System.Windows.Forms.StatusStrip
    Friend WithEvents trvCustomers As System.Windows.Forms.TreeView
    Friend WithEvents trvProducts As System.Windows.Forms.TreeView
    Friend WithEvents imgList As System.Windows.Forms.ImageList
    Friend WithEvents pnlCustomerDetailsList As System.Windows.Forms.Panel
    Friend WithEvents tsCustomerDetails As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnProductAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProductEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProductDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProductAddCategory As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnProductEditCategory As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnProductDelCategory As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCustomerAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnCustomerEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnCustomerDelete As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsslCustomerCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslProductCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslCustDetailsEmpCount As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnEmployeeAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEmployeeEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnEmployeeDel As System.Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents toolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsslUSDPrice As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents tsslYTLPrice As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents conProduct As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents cmnuProductEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuProductDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuCategoryAdd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuCategoryEdit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuCategoryDel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmnuProductMove As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmnuProductDetails As System.Windows.Forms.ToolStripMenuItem

End Class
