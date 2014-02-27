<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddEmployee))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.tpCustomer = New System.Windows.Forms.TabPage
        Me.cmbCustomerName = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCustomerCompany = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCustomerPhone = New System.Windows.Forms.MaskedTextBox
        Me.txtCustomerDescription = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtCustomerSurname = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCustomerId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tpProduct = New System.Windows.Forms.TabPage
        Me.cmbProductName = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtProductDescription = New System.Windows.Forms.TextBox
        Me.txtProductUnitPrice = New System.Windows.Forms.MaskedTextBox
        Me.nudProductUnit = New System.Windows.Forms.NumericUpDown
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtProductId = New System.Windows.Forms.TextBox
        Me.tpEmployee = New System.Windows.Forms.TabPage
        Me.rdbEmployeeYTL = New System.Windows.Forms.RadioButton
        Me.rdbEmployeeUSD = New System.Windows.Forms.RadioButton
        Me.Label13 = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtEmployeeComingTotal = New System.Windows.Forms.MaskedTextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtEmployeeTotal = New System.Windows.Forms.MaskedTextBox
        Me.txtEmployeeUnitPrice = New System.Windows.Forms.MaskedTextBox
        Me.nudEmployeeCount = New System.Windows.Forms.NumericUpDown
        Me.dtpEmployeeDate = New System.Windows.Forms.DateTimePicker
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtEmployeeId = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.tpCustomer.SuspendLayout()
        Me.tpProduct.SuspendLayout()
        CType(Me.nudProductUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEmployee.SuspendLayout()
        CType(Me.nudEmployeeCount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpCustomer)
        Me.TabControl1.Controls.Add(Me.tpProduct)
        Me.TabControl1.Controls.Add(Me.tpEmployee)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(10, 10)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(278, 269)
        Me.TabControl1.TabIndex = 0
        '
        'tpCustomer
        '
        Me.tpCustomer.Controls.Add(Me.cmbCustomerName)
        Me.tpCustomer.Controls.Add(Me.Label6)
        Me.tpCustomer.Controls.Add(Me.txtCustomerCompany)
        Me.tpCustomer.Controls.Add(Me.Label5)
        Me.tpCustomer.Controls.Add(Me.txtCustomerPhone)
        Me.tpCustomer.Controls.Add(Me.txtCustomerDescription)
        Me.tpCustomer.Controls.Add(Me.Label4)
        Me.tpCustomer.Controls.Add(Me.txtCustomerSurname)
        Me.tpCustomer.Controls.Add(Me.Label3)
        Me.tpCustomer.Controls.Add(Me.Label2)
        Me.tpCustomer.Controls.Add(Me.txtCustomerId)
        Me.tpCustomer.Controls.Add(Me.Label1)
        Me.tpCustomer.Location = New System.Drawing.Point(4, 22)
        Me.tpCustomer.Name = "tpCustomer"
        Me.tpCustomer.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCustomer.Size = New System.Drawing.Size(270, 243)
        Me.tpCustomer.TabIndex = 0
        Me.tpCustomer.Text = "Müþteri Bilgisi"
        Me.tpCustomer.UseVisualStyleBackColor = True
        '
        'cmbCustomerName
        '
        Me.cmbCustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomerName.FormattingEnabled = True
        Me.cmbCustomerName.Location = New System.Drawing.Point(97, 40)
        Me.cmbCustomerName.Name = "cmbCustomerName"
        Me.cmbCustomerName.Size = New System.Drawing.Size(167, 21)
        Me.cmbCustomerName.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Müþteri Tel No :"
        '
        'txtCustomerCompany
        '
        Me.txtCustomerCompany.Location = New System.Drawing.Point(97, 119)
        Me.txtCustomerCompany.MaxLength = 30
        Me.txtCustomerCompany.Name = "txtCustomerCompany"
        Me.txtCustomerCompany.ReadOnly = True
        Me.txtCustomerCompany.Size = New System.Drawing.Size(167, 20)
        Me.txtCustomerCompany.TabIndex = 20
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Müþteri Firma :"
        '
        'txtCustomerPhone
        '
        Me.txtCustomerPhone.Location = New System.Drawing.Point(97, 93)
        Me.txtCustomerPhone.Mask = "(999) 000-0000"
        Me.txtCustomerPhone.Name = "txtCustomerPhone"
        Me.txtCustomerPhone.ReadOnly = True
        Me.txtCustomerPhone.Size = New System.Drawing.Size(167, 20)
        Me.txtCustomerPhone.TabIndex = 19
        '
        'txtCustomerDescription
        '
        Me.txtCustomerDescription.Location = New System.Drawing.Point(97, 160)
        Me.txtCustomerDescription.MaxLength = 100
        Me.txtCustomerDescription.Multiline = True
        Me.txtCustomerDescription.Name = "txtCustomerDescription"
        Me.txtCustomerDescription.ReadOnly = True
        Me.txtCustomerDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtCustomerDescription.Size = New System.Drawing.Size(167, 73)
        Me.txtCustomerDescription.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Müþteri Bilgi :"
        '
        'txtCustomerSurname
        '
        Me.txtCustomerSurname.Location = New System.Drawing.Point(97, 67)
        Me.txtCustomerSurname.MaxLength = 20
        Me.txtCustomerSurname.Name = "txtCustomerSurname"
        Me.txtCustomerSurname.ReadOnly = True
        Me.txtCustomerSurname.Size = New System.Drawing.Size(167, 20)
        Me.txtCustomerSurname.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Müþteri Soyadý :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Müþteri Adý :"
        '
        'txtCustomerId
        '
        Me.txtCustomerId.Location = New System.Drawing.Point(97, 15)
        Me.txtCustomerId.Name = "txtCustomerId"
        Me.txtCustomerId.ReadOnly = True
        Me.txtCustomerId.Size = New System.Drawing.Size(80, 20)
        Me.txtCustomerId.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Müþteri Kodu :"
        '
        'tpProduct
        '
        Me.tpProduct.Controls.Add(Me.cmbProductName)
        Me.tpProduct.Controls.Add(Me.Label7)
        Me.tpProduct.Controls.Add(Me.txtProductDescription)
        Me.tpProduct.Controls.Add(Me.txtProductUnitPrice)
        Me.tpProduct.Controls.Add(Me.nudProductUnit)
        Me.tpProduct.Controls.Add(Me.Label8)
        Me.tpProduct.Controls.Add(Me.Label9)
        Me.tpProduct.Controls.Add(Me.Label10)
        Me.tpProduct.Controls.Add(Me.Label11)
        Me.tpProduct.Controls.Add(Me.txtProductId)
        Me.tpProduct.Location = New System.Drawing.Point(4, 22)
        Me.tpProduct.Name = "tpProduct"
        Me.tpProduct.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProduct.Size = New System.Drawing.Size(270, 243)
        Me.tpProduct.TabIndex = 1
        Me.tpProduct.Text = "Ürün Bilgisi"
        Me.tpProduct.UseVisualStyleBackColor = True
        '
        'cmbProductName
        '
        Me.cmbProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductName.FormattingEnabled = True
        Me.cmbProductName.Location = New System.Drawing.Point(91, 40)
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.Size = New System.Drawing.Size(173, 21)
        Me.cmbProductName.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Bilgi :"
        '
        'txtProductDescription
        '
        Me.txtProductDescription.Location = New System.Drawing.Point(91, 118)
        Me.txtProductDescription.MaxLength = 100
        Me.txtProductDescription.Multiline = True
        Me.txtProductDescription.Name = "txtProductDescription"
        Me.txtProductDescription.ReadOnly = True
        Me.txtProductDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtProductDescription.Size = New System.Drawing.Size(173, 61)
        Me.txtProductDescription.TabIndex = 16
        '
        'txtProductUnitPrice
        '
        Me.txtProductUnitPrice.Location = New System.Drawing.Point(91, 92)
        Me.txtProductUnitPrice.Mask = "00000,00"
        Me.txtProductUnitPrice.Name = "txtProductUnitPrice"
        Me.txtProductUnitPrice.ReadOnly = True
        Me.txtProductUnitPrice.Size = New System.Drawing.Size(173, 20)
        Me.txtProductUnitPrice.TabIndex = 15
        '
        'nudProductUnit
        '
        Me.nudProductUnit.Enabled = False
        Me.nudProductUnit.Location = New System.Drawing.Point(91, 66)
        Me.nudProductUnit.Name = "nudProductUnit"
        Me.nudProductUnit.ReadOnly = True
        Me.nudProductUnit.Size = New System.Drawing.Size(94, 20)
        Me.nudProductUnit.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Ürün Br Fiyat :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 68)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Ürün Adeti :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 43)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Ürün Adý :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 17)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Ürün Kodu :"
        '
        'txtProductId
        '
        Me.txtProductId.Location = New System.Drawing.Point(91, 14)
        Me.txtProductId.Name = "txtProductId"
        Me.txtProductId.ReadOnly = True
        Me.txtProductId.Size = New System.Drawing.Size(94, 20)
        Me.txtProductId.TabIndex = 8
        '
        'tpEmployee
        '
        Me.tpEmployee.Controls.Add(Me.rdbEmployeeYTL)
        Me.tpEmployee.Controls.Add(Me.rdbEmployeeUSD)
        Me.tpEmployee.Controls.Add(Me.Label13)
        Me.tpEmployee.Controls.Add(Me.btnCancel)
        Me.tpEmployee.Controls.Add(Me.btnOK)
        Me.tpEmployee.Controls.Add(Me.txtEmployeeComingTotal)
        Me.tpEmployee.Controls.Add(Me.Label18)
        Me.tpEmployee.Controls.Add(Me.txtEmployeeTotal)
        Me.tpEmployee.Controls.Add(Me.txtEmployeeUnitPrice)
        Me.tpEmployee.Controls.Add(Me.nudEmployeeCount)
        Me.tpEmployee.Controls.Add(Me.dtpEmployeeDate)
        Me.tpEmployee.Controls.Add(Me.Label17)
        Me.tpEmployee.Controls.Add(Me.Label16)
        Me.tpEmployee.Controls.Add(Me.Label15)
        Me.tpEmployee.Controls.Add(Me.Label14)
        Me.tpEmployee.Controls.Add(Me.txtEmployeeId)
        Me.tpEmployee.Controls.Add(Me.Label12)
        Me.tpEmployee.Location = New System.Drawing.Point(4, 22)
        Me.tpEmployee.Name = "tpEmployee"
        Me.tpEmployee.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEmployee.Size = New System.Drawing.Size(270, 243)
        Me.tpEmployee.TabIndex = 2
        Me.tpEmployee.Text = "Sipariþ Detaylarý"
        Me.tpEmployee.UseVisualStyleBackColor = True
        '
        'rdbEmployeeYTL
        '
        Me.rdbEmployeeYTL.AutoSize = True
        Me.rdbEmployeeYTL.Location = New System.Drawing.Point(174, 93)
        Me.rdbEmployeeYTL.Name = "rdbEmployeeYTL"
        Me.rdbEmployeeYTL.Size = New System.Drawing.Size(45, 17)
        Me.rdbEmployeeYTL.TabIndex = 13
        Me.rdbEmployeeYTL.TabStop = True
        Me.rdbEmployeeYTL.Text = "YTL"
        Me.rdbEmployeeYTL.UseVisualStyleBackColor = True
        '
        'rdbEmployeeUSD
        '
        Me.rdbEmployeeUSD.AutoSize = True
        Me.rdbEmployeeUSD.Checked = True
        Me.rdbEmployeeUSD.Location = New System.Drawing.Point(97, 93)
        Me.rdbEmployeeUSD.Name = "rdbEmployeeUSD"
        Me.rdbEmployeeUSD.Size = New System.Drawing.Size(65, 17)
        Me.rdbEmployeeUSD.TabIndex = 13
        Me.rdbEmployeeUSD.TabStop = True
        Me.rdbEmployeeUSD.Text = "Dolar ($)"
        Me.rdbEmployeeUSD.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(62, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Para Birimi :"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(108, 214)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Kapat !"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(189, 214)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 10
        Me.btnOK.Text = "Kaydet"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtEmployeeComingTotal
        '
        Me.txtEmployeeComingTotal.Location = New System.Drawing.Point(97, 168)
        Me.txtEmployeeComingTotal.Mask = "00000,00"
        Me.txtEmployeeComingTotal.Name = "txtEmployeeComingTotal"
        Me.txtEmployeeComingTotal.Size = New System.Drawing.Size(167, 20)
        Me.txtEmployeeComingTotal.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 171)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(83, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Ödenen Miktar :"
        '
        'txtEmployeeTotal
        '
        Me.txtEmployeeTotal.Location = New System.Drawing.Point(97, 142)
        Me.txtEmployeeTotal.Mask = "00000,00"
        Me.txtEmployeeTotal.Name = "txtEmployeeTotal"
        Me.txtEmployeeTotal.Size = New System.Drawing.Size(167, 20)
        Me.txtEmployeeTotal.TabIndex = 7
        '
        'txtEmployeeUnitPrice
        '
        Me.txtEmployeeUnitPrice.Location = New System.Drawing.Point(97, 116)
        Me.txtEmployeeUnitPrice.Mask = "00000,00"
        Me.txtEmployeeUnitPrice.Name = "txtEmployeeUnitPrice"
        Me.txtEmployeeUnitPrice.Size = New System.Drawing.Size(167, 20)
        Me.txtEmployeeUnitPrice.TabIndex = 6
        '
        'nudEmployeeCount
        '
        Me.nudEmployeeCount.Location = New System.Drawing.Point(97, 67)
        Me.nudEmployeeCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudEmployeeCount.Name = "nudEmployeeCount"
        Me.nudEmployeeCount.Size = New System.Drawing.Size(80, 20)
        Me.nudEmployeeCount.TabIndex = 5
        Me.nudEmployeeCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'dtpEmployeeDate
        '
        Me.dtpEmployeeDate.Location = New System.Drawing.Point(97, 41)
        Me.dtpEmployeeDate.Name = "dtpEmployeeDate"
        Me.dtpEmployeeDate.Size = New System.Drawing.Size(167, 20)
        Me.dtpEmployeeDate.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 145)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(73, 13)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Toplam Fiyat :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 2
        Me.Label16.Text = "Birim Fiyatý :"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Adet :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(73, 13)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Sipariþ Tarihi :"
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.Location = New System.Drawing.Point(97, 15)
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.ReadOnly = True
        Me.txtEmployeeId.Size = New System.Drawing.Size(80, 20)
        Me.txtEmployeeId.TabIndex = 1
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 18)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(72, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Sipariþ Kodu :"
        '
        'frmAddEmployee
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(298, 289)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "frmAddEmployee"
        Me.Padding = New System.Windows.Forms.Padding(10)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sipariþ Ekleme ..."
        Me.TabControl1.ResumeLayout(False)
        Me.tpCustomer.ResumeLayout(False)
        Me.tpCustomer.PerformLayout()
        Me.tpProduct.ResumeLayout(False)
        Me.tpProduct.PerformLayout()
        CType(Me.nudProductUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEmployee.ResumeLayout(False)
        Me.tpEmployee.PerformLayout()
        CType(Me.nudEmployeeCount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tpCustomer As System.Windows.Forms.TabPage
    Friend WithEvents tpProduct As System.Windows.Forms.TabPage
    Friend WithEvents tpEmployee As System.Windows.Forms.TabPage
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerPhone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCustomerDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtProductDescription As System.Windows.Forms.TextBox
    Friend WithEvents txtProductUnitPrice As System.Windows.Forms.MaskedTextBox
    Friend WithEvents nudProductUnit As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtProductId As System.Windows.Forms.TextBox
    Friend WithEvents cmbCustomerName As System.Windows.Forms.ComboBox
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dtpEmployeeDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtEmployeeComingTotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeTotal As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtEmployeeUnitPrice As System.Windows.Forms.MaskedTextBox
    Friend WithEvents nudEmployeeCount As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents cmbProductName As System.Windows.Forms.ComboBox
    Friend WithEvents rdbEmployeeYTL As System.Windows.Forms.RadioButton
    Friend WithEvents rdbEmployeeUSD As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
