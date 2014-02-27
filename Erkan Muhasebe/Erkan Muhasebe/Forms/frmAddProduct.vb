Public Class frmAddProduct

    Public Event frmAddProduct_Closing(ByVal sender As Object, ByVal e As EventArgs)

    Public subID As Integer = 1
    Public subName As String = ""
    Public mode As String = "insert"

    Public Sub LoadProductDetails(ByVal product As objProduct)
        Me.txtProductId.Text = product.ProductID.ToString
        Me.txtProductName.Text = product.ProductName
        Me.nudProductUnit.Value = product.ProductUnit
        Me.txtProductUnitPrice.Text = product.ProductUnitPrice
        Me.txtProductDescription.Text = product.ProductDescription
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub frmAddProduct_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        RaiseEvent frmAddProduct_Closing(sender, e)
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If Not Me.txtProductName.Text.Trim.Length = 0 Then
            Dim db As myDbOperations.OLEDB = New myDbOperations.OLEDB(Application.StartupPath & "\" & "db.mdb", "tblProducts")

            Me.txtProductName.Text = Me.txtProductName.Text.Replace(",", " - ")
            Me.txtProductDescription.Text = Me.txtProductDescription.Text.Replace(",", " ; ")

            Dim ColsVals As ArrayList = New ArrayList
            ColsVals.Add(New myDbOperations.Parameters("prodSubId", subID.ToString, myDbOperations.OLEVariableTypes.Number))
            ColsVals.Add(New myDbOperations.Parameters("prodName", Me.txtProductName.Text, myDbOperations.OLEVariableTypes.Text))
            ColsVals.Add(New myDbOperations.Parameters("prodCount", Me.nudProductUnit.Value.ToString, myDbOperations.OLEVariableTypes.Number))
            ColsVals.Add(New myDbOperations.Parameters("prodUnitPrice", Me.txtProductUnitPrice.Text, myDbOperations.OLEVariableTypes.Text))
            ColsVals.Add(New myDbOperations.Parameters("prodIsCategory", "False", myDbOperations.OLEVariableTypes.YesNo))
            ColsVals.Add(New myDbOperations.Parameters("prodDescription", Me.txtProductDescription.Text, myDbOperations.OLEVariableTypes.Text))

            If Me.mode = "insert" Then
                If db.Insert(ColsVals) = 1 Then
                    MessageBox.Show("Ürün Kaydedilmiþtir!!" & vbCrLf & "Ürün kaydetme iþlemine devam edebilirsiniz..", "Kaydedildi..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("Ürün kaydedilirken bir hata oluþtu !!", "Ürün Kaydedilemedi..", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            Else
                If db.Update(New myDbOperations.Parameters("prodId", Me.txtProductId.Text, myDbOperations.OLEVariableTypes.Number), ColsVals) = 1 Then
                    MessageBox.Show("Ürün Düzeltilmiþtir!!" & vbCrLf & "Ürün düzeltme iþlemine devam edebilirsiniz..", "Düzeltildi..", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                Else
                    MessageBox.Show("Ürün düzeltilirken bir hata oluþtu !!", "Ürün düzeltilemedi..", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                End If
            End If

        Else
            MessageBox.Show("Ürün Adý boþ býrakýlamaz....", "Ürün Adý Boþ !", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
        End If
    End Sub
End Class