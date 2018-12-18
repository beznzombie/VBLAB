Public Class FrmLab4
    Dim datNowDate As Date = Today
    Dim dblYearSalary, dblBonus, dblAllIncome, dblAllowance, dblTax As Double

    Private Sub FrmLab4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblDate.Text = Format(datNowDate, "dd/MM/yy")
    End Sub

    Private Sub btnCalTax_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalTax.Click
        Const decR_BONUS As Double = 0.2
        Const decR_ALLOW As Double = 0.01
        Const decR_Tax As Double = 0.07

        dblYearSalary = Val(txtSalary.Text) * 12
        dblBonus = Val(txtSale.Text) * decR_BONUS
        dblAllIncome = dblYearSalary + dblBonus
        dblAllowance = dblAllIncome * decR_ALLOW
        dblTax = (dblAllIncome - dblAllowance) * decR_Tax

        lblYearSalary.Text = dblYearSalary.ToString("n2")
        lblBonus.Text = dblBonus.ToString("n2")
        lblAllIncome.Text = dblAllIncome.ToString("n2")
        lblAllowance.Text = dblAllowance.ToString("n2")
        lblTax.Text = dblTax.ToString("n2")

    End Sub

    Private Sub radShortDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radShortDate.CheckedChanged
        lblDate.Text = Format(datNowDate, "ddd/MMM/yyyy")
    End Sub

    Private Sub radGenDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radGenDate.CheckedChanged
        lblDate.Text = Format(datNowDate, "dd/MM/yy")
    End Sub

    Private Sub radLongDate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radLongDate.CheckedChanged
        lblDate.Text = Format(datNowDate, "dddd/MMMM/yyyy")
    End Sub
End Class