<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class usrControlCustomerEmployee
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container
        Me.chkEmployeeDate = New System.Windows.Forms.CheckBox
        Me.lblProductName = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.lblProductUnit = New System.Windows.Forms.Label
        Me.lblUnitPrice = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.btnBorc = New System.Windows.Forms.Button
        Me.lblComingPrice = New System.Windows.Forms.Label
        Me.lblTotalPrice = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkEmployeeDate
        '
        Me.chkEmployeeDate.AutoSize = True
        Me.chkEmployeeDate.BackColor = System.Drawing.Color.Transparent
        Me.chkEmployeeDate.Dock = System.Windows.Forms.DockStyle.Left
        Me.chkEmployeeDate.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.chkEmployeeDate.Location = New System.Drawing.Point(3, 3)
        Me.chkEmployeeDate.Name = "chkEmployeeDate"
        Me.chkEmployeeDate.Padding = New System.Windows.Forms.Padding(0, 5, 5, 5)
        Me.chkEmployeeDate.Size = New System.Drawing.Size(75, 54)
        Me.chkEmployeeDate.TabIndex = 0
        Me.chkEmployeeDate.Text = "[Tarih]"
        Me.chkEmployeeDate.UseVisualStyleBackColor = False
        '
        'lblProductName
        '
        Me.lblProductName.BackColor = System.Drawing.Color.Transparent
        Me.lblProductName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblProductName.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProductName.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblProductName.ForeColor = System.Drawing.Color.DarkRed
        Me.lblProductName.Location = New System.Drawing.Point(78, 3)
        Me.lblProductName.Name = "lblProductName"
        Me.lblProductName.Size = New System.Drawing.Size(403, 20)
        Me.lblProductName.TabIndex = 1
        Me.lblProductName.Text = "[Ürün Adý]"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblProductUnit)
        Me.Panel1.Controls.Add(Me.lblUnitPrice)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Panel1.Location = New System.Drawing.Point(78, 23)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(403, 20)
        Me.Panel1.TabIndex = 2
        '
        'lblProductUnit
        '
        Me.lblProductUnit.BackColor = System.Drawing.Color.Transparent
        Me.lblProductUnit.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProductUnit.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblProductUnit.Location = New System.Drawing.Point(215, 0)
        Me.lblProductUnit.Name = "lblProductUnit"
        Me.lblProductUnit.Size = New System.Drawing.Size(188, 20)
        Me.lblProductUnit.TabIndex = 9
        Me.lblProductUnit.Text = "Alýnan Adet :"
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblUnitPrice.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblUnitPrice.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblUnitPrice.Location = New System.Drawing.Point(0, 0)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(215, 20)
        Me.lblUnitPrice.TabIndex = 7
        Me.lblUnitPrice.Text = "Ürün Birim Fiyatý :"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnBorc)
        Me.Panel2.Controls.Add(Me.lblComingPrice)
        Me.Panel2.Controls.Add(Me.lblTotalPrice)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Panel2.Location = New System.Drawing.Point(78, 43)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(403, 20)
        Me.Panel2.TabIndex = 3
        '
        'btnBorc
        '
        Me.btnBorc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnBorc.Location = New System.Drawing.Point(380, -1)
        Me.btnBorc.Name = "btnBorc"
        Me.btnBorc.Size = New System.Drawing.Size(23, 17)
        Me.btnBorc.TabIndex = 10
        Me.btnBorc.Text = "..."
        Me.btnBorc.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.ToolTip1.SetToolTip(Me.btnBorc, "Borç Bilgisi Ver !")
        Me.btnBorc.UseVisualStyleBackColor = True
        '
        'lblComingPrice
        '
        Me.lblComingPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblComingPrice.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblComingPrice.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblComingPrice.Location = New System.Drawing.Point(215, 0)
        Me.lblComingPrice.Name = "lblComingPrice"
        Me.lblComingPrice.Size = New System.Drawing.Size(188, 20)
        Me.lblComingPrice.TabIndex = 9
        Me.lblComingPrice.Text = "Ödenen Miktar :"
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalPrice.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTotalPrice.Font = New System.Drawing.Font("Times New Roman", 9.5!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.lblTotalPrice.Location = New System.Drawing.Point(0, 0)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(215, 20)
        Me.lblTotalPrice.TabIndex = 7
        Me.lblTotalPrice.Text = "Toplam Tutar :"
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "Bilgi :"
        '
        'usrControlCustomerEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblProductName)
        Me.Controls.Add(Me.chkEmployeeDate)
        Me.Name = "usrControlCustomerEmployee"
        Me.Padding = New System.Windows.Forms.Padding(3)
        Me.Size = New System.Drawing.Size(484, 60)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkEmployeeDate As System.Windows.Forms.CheckBox
    Friend WithEvents lblProductName As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lblProductUnit As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblComingPrice As System.Windows.Forms.Label
    Friend WithEvents lblTotalPrice As System.Windows.Forms.Label
    Friend WithEvents lblUnitPrice As System.Windows.Forms.Label
    Friend WithEvents btnBorc As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

End Class
