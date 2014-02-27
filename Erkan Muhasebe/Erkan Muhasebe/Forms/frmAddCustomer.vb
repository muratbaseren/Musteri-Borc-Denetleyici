Public Class frmAddCustomer

    Public Event frmAddcustomer_Closing(ByVal sender As Object, ByVal e As EventArgs)

    Public mode As String = "insert"

    Public Sub LoadcustomerDetails(ByVal customer As objcustomer)
        Me.txtCustomerId.Text = customer.customerID.ToString
        Me.txtCustomerName.Text = customer.customerName
        Me.txtCustomerSurname.Text = customer.CustomerSurname
        Me.txtCustomerPhone.Text = customer.CustomerPhone
        Me.txtCustomerCompany.Text = customer.CustomerCompany
        Me.txtCustomerDescription.Text = customer.CustomerDescription
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddcustomer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent frmAddcustomer_Closing(sender, e)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Not Me.txtCustomerName.Text.Trim.Length = 0 Then
            Dim db As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "db.mdb", "tblCustomers")

            Me.txtCustomerName.Text = Me.txtCustomerName.Text.Replace(",", " - ")
            Me.txtCustomerDescription.Text = Me.txtCustomerDescription.Text.Replace(",", " ; ")

            Dim ColsVals As ArrayList = New ArrayList
            ColsVals.Add(New myDbOperations.Parameters("custName", Me.txtCustomerName.Text, myDbOperations.OLEVariableTypes.Text))
            ColsVals.Add(New myDbOperations.Parameters("custSurname", Me.txtCustomerSurname.Text, myDbOperations.OLEVariableTypes.Text))
            ColsVals.Add(New myDbOperations.Parameters("custPhone", Me.txtCustomerPhone.Text, myDbOperations.OLEVariableTypes.Text))
            ColsVals.Add(New myDbOperations.Parameters("custCompany", Me.txtCustomerCompany.Text, myDbOperations.OLEVariableTypes.Text))
            ColsVals.Add(New myDbOperations.Parameters("custDescription", Me.txtCustomerDescription.Text, myDbOperations.OLEVariableTypes.Text))

            If Me.mode = "insert" Then
                If db.Insert(ColsVals) = 1 Then
                    MessageBox.Show("Müþteri Kaydedilmiþtir!!" & vbCrLf & "Müþteri ekleme iþlemine devam edebilirsiniz..", "Kaydedildi..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("Müþteri eklenirken bir hata oluþtu !!", "Müþteri Eklenemedi..", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Else
                If db.Update(New myDbOperations.Parameters("custId", Me.txtCustomerId.Text, myDbOperations.OLEVariableTypes.Number), ColsVals) = 1 Then
                    MessageBox.Show("Müþteri Düzeltilmiþtir!!" & vbCrLf & "Müþteri düzeltme iþlemine devam edebilirsiniz..", "Düzeltildi..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("Müþteri düzeltilirken bir hata oluþtu !!", "Müþteri düzeltilemedi..", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        Else
            MessageBox.Show("Müþteri Adý boþ býrakýlamaz....", "Müþteri Adý Boþ !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub

End Class