Public Class usrControlCustomerEmployee

    Private Function ConvertSingle(ByVal s As String) As Single
        Try
            s = s.Replace(".", ",")

            ConvertSingle = CType(s, Single)

        Catch ex As Exception
            ConvertSingle = 0
        End Try

        Return (ConvertSingle)
    End Function

    Public Sub FillDetails(ByVal objEmp As objCustomerEmployee)
        Dim MoneyType As String = ""
        If objEmp.EmployeeIsDolar = True Then
            MoneyType = " $"
        Else
            MoneyType = " YTL"
        End If

        With objEmp
            Me.lblProductName.Text = .EmployeeProductName
            Me.chkEmployeeDate.Text = .EmployeeDate.ToShortDateString
            Me.lblProductUnit.Text &= " " & .EmployeeUnit.ToString
            Me.lblUnitPrice.Text &= " " & .EmployeeUnitPrice & MoneyType
            Me.lblTotalPrice.Text &= " " & .EmployeeTotal & MoneyType
            Me.lblComingPrice.Text &= " " & .EmployeeComingTotal & MoneyType
        End With

        Me.Tag = objEmp

        If Me.ConvertSingle(objEmp.EmployeeComingTotal) < Me.ConvertSingle(objEmp.EmployeeTotal) Then
            Me.lblComingPrice.ForeColor = Color.Red
            objEmp.EmployeeDescription = "Borç : " & (Me.ConvertSingle(objEmp.EmployeeTotal) - Me.ConvertSingle(objEmp.EmployeeComingTotal)).ToString.Replace(",", ".") & MoneyType
        Else
            Me.lblComingPrice.ForeColor = Color.Black
            objEmp.EmployeeDescription = "Borç : YOK !"
        End If

    End Sub

    Private Sub btnBorc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorc.Click
        MessageBox.Show(CType(Me.Tag, objCustomerEmployee).EmployeeDescription, " Borç Bilgisi", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
    End Sub
End Class
