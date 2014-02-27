Public Class frmAddEmployee

#Region "Local Variables"
    Private dbCust As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "db.mdb", "tblCustomers")
    Private dbProd As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "db.mdb", "tblProducts")
    Private dbEmp As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "db.mdb", "tblCustomerEmployees")
    Public mode As String = "insert"

    Public Event frmAddEmployee_Closed(ByVal sender As Object, ByVal e As EventArgs)
#End Region

    Private Function ConvertSingle(ByVal s As String) As Single
        Try
            s = s.Replace(".", ",")

            ConvertSingle = CType(s, Single)

        Catch ex As Exception
            ConvertSingle = 0
        End Try

        Return (ConvertSingle)
    End Function
    
    Public Sub FillCustomers()

        Dim Cols As ArrayList = New ArrayList
        Cols.Add("custId")
        Cols.Add("custName")

        Dim dt As DataTable = New DataTable
        dt = dbCust.Select(Cols)

        Me.cmbCustomerName.DataSource = dt
        Me.cmbCustomerName.DisplayMember = dt.Columns(1).ColumnName
        Me.cmbCustomerName.ValueMember = dt.Columns(0).ColumnName

        Me.cmbCustomerName.SelectedIndex = -1
    End Sub

    Public Sub FillProducts()

        Dim dt As DataTable = New DataTable
        dt = dbProd.RunQuery(myDbOperations.QueryType.Select, "SELECT prodId, prodName FROM " & dbProd.MyDbTable & " WHERE prodIsCategory=false")

        Me.cmbProductName.DataSource = dt
        Me.cmbProductName.DisplayMember = dt.Columns(1).ColumnName
        Me.cmbProductName.ValueMember = dt.Columns(0).ColumnName

        Me.cmbProductName.SelectedIndex = -1
    End Sub

    Public Sub SelectCustAndProd(ByVal objCust As objCustomer, ByVal objProd As objProduct)
        Me.cmbCustomerName.SelectedValue = CInt(objCust.CustomerID)
        Me.cmbProductName.SelectedValue = CInt(objProd.ProductID)

        Me.txtEmployeeUnitPrice.Text = objProd.ProductUnitPrice
        Me.dtpEmployeeDate.Value = Now
        Me.nudProductUnit.Value = objProd.ProductUnit
        Me.nudEmployeeCount.Value = 1
        Me.txtEmployeeTotal.Text = objProd.ProductUnitPrice

    End Sub

    Public Sub SelectCustAndProd(ByVal objEmp As objCustomerEmployee)
        Me.cmbCustomerName.SelectedValue = CInt(objEmp.EmployeeCustomerID)
        Me.cmbProductName.SelectedValue = CInt(objEmp.EmployeeProductID)

        Me.txtEmployeeId.Text = objEmp.EmployeeID.ToString
        Me.txtEmployeeUnitPrice.Text = objEmp.EmployeeUnitPrice
        Me.dtpEmployeeDate.Value = objEmp.EmployeeDate
        Me.nudEmployeeCount.Value = objEmp.EmployeeUnit
        Me.txtEmployeeTotal.Text = objEmp.EmployeeTotal
        Me.txtEmployeeComingTotal.Text = objEmp.EmployeeComingTotal

        If objEmp.EmployeeIsDolar = True Then
            Me.rdbEmployeeUSD.Checked = True
        Else
            Me.rdbEmployeeYTL.Checked = True
        End If

        mode = "update"
    End Sub



    Private Sub cmbCustomerName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCustomerName.SelectedIndexChanged

        If Not Me.cmbCustomerName.SelectedIndex = -1 Then

            If Me.cmbCustomerName.SelectedValue.ToString = "System.Data.DataRowView" Then Exit Sub

            Dim dt As DataTable = New DataTable
            dt = dbCust.RunQuery(myDbOperations.QueryType.Select, "SELECT * FROM " & dbCust.MyDbTable & " WHERE custId=" & Me.cmbCustomerName.SelectedValue.ToString)

            If dt.Rows.Count = 0 Then Exit Sub

            Dim dr As DataRow = dt.Rows(0)

            'Seçilen müþteri tpCustomer tabPage in tag ýna objCust olarak kaydedilir.
            Dim objCust As objCustomer = New objCustomer(CInt(dr(0).ToString), dr(1).ToString, dr(2).ToString, dr(3).ToString, dr(4).ToString, dr(5).ToString)

            Me.tpCustomer.Tag = objCust

            Me.txtCustomerId.Text = objCust.CustomerID.ToString
            Me.txtCustomerSurname.Text = objCust.CustomerSurname
            Me.txtCustomerPhone.Text = objCust.CustomerPhone
            Me.txtCustomerCompany.Text = objCust.CustomerCompany
            Me.txtCustomerDescription.Text = objCust.CustomerDescription
        End If
    End Sub

    Private Sub cmbProductName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProductName.SelectedIndexChanged

        If Not Me.cmbCustomerName.SelectedIndex = -1 Then

            If Me.cmbProductName.SelectedValue.ToString = "System.Data.DataRowView" Then Exit Sub

            Dim dt As DataTable = New DataTable
            dt = dbProd.Select(New myDbOperations.Parameters("prodId", Me.cmbProductName.SelectedValue.ToString, myDbOperations.OLEVariableTypes.Number))

            If dt.Rows.Count = 0 Then Exit Sub

            Dim dr As DataRow = dt.Rows(0)

            'Seçilen müþteri tpCustomer tabPage in tag ýna objCust olarak kaydedilir.
            Dim objProd As objProduct = New objProduct(CInt(dr(0).ToString), dr(2).ToString, CInt(dr(1).ToString), "", CInt(dr(3).ToString), dr(4).ToString, False, dr(6).ToString)
            Me.tpProduct.Tag = objProd

            Me.txtProductId.Text = objProd.ProductID.ToString
            Me.nudProductUnit.Value = objProd.ProductUnit
            Me.txtProductUnitPrice.Text = objProd.ProductUnitPrice
            Me.txtProductDescription.Text = objProd.ProductDescription

        End If
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim objCust As objCustomer = CType(Me.tpCustomer.Tag, objCustomer)
        Dim objProd As objProduct = CType(Me.tpProduct.Tag, objProduct)
        Dim ColsVals As ArrayList = New ArrayList

        ColsVals.Add(New myDbOperations.Parameters("empCustId", objCust.CustomerID.ToString, myDbOperations.OLEVariableTypes.Number))
        ColsVals.Add(New myDbOperations.Parameters("empProdId", objProd.ProductID.ToString, myDbOperations.OLEVariableTypes.Number))
        ColsVals.Add(New myDbOperations.Parameters("empProdName", objProd.ProductName, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("empDate", Me.dtpEmployeeDate.Value.ToShortDateString, myDbOperations.OLEVariableTypes.DateTime))
        ColsVals.Add(New myDbOperations.Parameters("empCount", Me.nudEmployeeCount.Value.ToString, myDbOperations.OLEVariableTypes.Number))
        ColsVals.Add(New myDbOperations.Parameters("empUnitPrice", Me.txtEmployeeUnitPrice.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("empTotal", Me.txtEmployeeTotal.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("empComingPrice", Me.txtEmployeeComingTotal.Text, myDbOperations.OLEVariableTypes.Text))
        ColsVals.Add(New myDbOperations.Parameters("empIsDolar", Me.rdbEmployeeUSD.Checked.ToString, myDbOperations.OLEVariableTypes.YesNo))
        ColsVals.Add(New myDbOperations.Parameters("empDescription", ""))

        If mode = "insert" Then
            If dbEmp.Insert(ColsVals) = 1 Then
                MessageBox.Show("Sipariþ Kaydedilmiþtir!!" & vbCrLf & "Sipariþ kaydetme iþlemine devam edebilirsiniz..", "Kaydedildi..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)

                '
                '
                'ürün miktarýndaki deðiþimin gerçekleþtirilmesi..
                Dim db As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "db.mdb", "tblProducts")

                Dim prodColsVals As ArrayList = New ArrayList
                prodColsVals.Add(New myDbOperations.Parameters("prodSubId", objProd.ProductCategoryID.ToString, myDbOperations.OLEVariableTypes.Number))
                prodColsVals.Add(New myDbOperations.Parameters("prodName", objProd.ProductName, myDbOperations.OLEVariableTypes.Text))
                prodColsVals.Add(New myDbOperations.Parameters("prodCount", (objProd.ProductUnit - Me.nudEmployeeCount.Value).ToString, myDbOperations.OLEVariableTypes.Number))
                prodColsVals.Add(New myDbOperations.Parameters("prodUnitPrice", objProd.ProductUnitPrice.ToString, myDbOperations.OLEVariableTypes.Text))
                prodColsVals.Add(New myDbOperations.Parameters("prodIsCategory", "False", myDbOperations.OLEVariableTypes.YesNo))
                prodColsVals.Add(New myDbOperations.Parameters("prodDescription", objProd.ProductDescription, myDbOperations.OLEVariableTypes.Text))

                db.Update(New myDbOperations.Parameters("prodId", objProd.ProductID.ToString, myDbOperations.OLEVariableTypes.Number), prodColsVals)
            Else
                MessageBox.Show("Sipariþ kaydedilirken bir hata oluþtu !!", "Sipariþ Kaydedilemedi..", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        Else
            If dbEmp.Update(New myDbOperations.Parameters("empId", Me.txtEmployeeId.Text, myDbOperations.OLEVariableTypes.Number), ColsVals) = 1 Then
                MessageBox.Show("Sipariþ baþarýyla düzeltilmiþtir..", "Ýþlem Tamamlandý..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            Else
                MessageBox.Show("Sipariþ düzeltilirken bir hata oluþtu !!", "Sipariþ Düzeltilemedi !!", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            End If
        End If
    End Sub

    'Handles nudEmployeeCount.ValueChanged, txtEmployeeUnitPrice.LostFocus
    Private Sub nudEmployeeCount_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nudEmployeeCount.ValueChanged, txtEmployeeUnitPrice.LostFocus
        Dim UnitPrice As Single = Me.ConvertSingle(Me.txtEmployeeUnitPrice.Text)
        Dim Total As Single = UnitPrice * CInt(Me.nudEmployeeCount.Value)
        Dim strTotal As String = Total.ToString

        If strTotal.Length - 1 - strTotal.LastIndexOf(",") = 1 Then
            strTotal &= "0"
        ElseIf strTotal.Length - 1 - strTotal.LastIndexOf(",") = 0 Then
            strTotal &= "00"
        ElseIf strTotal.LastIndexOf(",") = -1 Then
            strTotal &= ",00"
        End If

        If strTotal.Length - 1 - strTotal.LastIndexOf(",") > 2 Then
            Do
                strTotal = strTotal.Remove(strTotal.Length - 1, 1)
            Loop While (strTotal.Length - 1 - strTotal.LastIndexOf(",") > 2)
        End If

        For i As Integer = 1 To 8 - (strTotal.Length)
            strTotal = " " & strTotal
        Next

        Me.txtEmployeeTotal.Text = strTotal.Replace(",", ".")

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddEmployee_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent frmAddEmployee_Closed(sender, e)
    End Sub

    Private Sub txtProductUnitPrice_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtProductUnitPrice.TextChanged
        Me.txtEmployeeUnitPrice.Text = Me.txtProductUnitPrice.Text
        Me.nudEmployeeCount.Value = 1
    End Sub

End Class