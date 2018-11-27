Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        lblSalaryPYear.Text = Val(txtSalary.Text) * 12
        lblTax.Text = Val(lblSalaryPYear.Text) * 0.05
        lblTotal.Text = Val(lblSalaryPYear.Text) - Val(lblTax.Text)
    End Sub
End Class
