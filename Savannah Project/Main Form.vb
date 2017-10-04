' Project Name: Savannah Solution - 4A14
' Purpose: To determine Shipping Charge
' Programmer: Andrew Kuykendall on 9/19/2017 on Row 2

Public Class frmMain
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Variables
        Dim strCreditCard As String
        Dim decTotal As Decimal
        Dim decShipping As Decimal
        decTotal = txtTotal.Text
        strCreditCard = txtCreditCard.Text
        ' Shipping Calculation
        If strCreditCard.ToUpper = "Y" AndAlso decTotal >= 100 Then decShipping = "0" Else decShipping = "9.00"
        lblShipping.Text = decShipping.ToString("C2")

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged, txtCreditCard.TextChanged
        lblShipping.Text = String.Empty

    End Sub
End Class
