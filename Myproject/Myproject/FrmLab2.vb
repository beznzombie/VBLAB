Public Class FrmLab2

    Private Sub btnCal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCal.Click
        Dim ComAcerPrice, Printer, TotalSale As Double
        Dim CommissionAcer, CommissionHp, CommissionTotal As Double

        ComAcerPrice = Val(txtComAcer.Text)
        Printer = Val(txtPrintHp.Text)

        TotalSale = ComAcerPrice + Printer
        CommissionAcer = ComAcerPrice * 0.05
        CommissionHp = Printer * 0.1
        CommissionTotal = CommissionAcer + CommissionHp


        lblTotalSale.Text = TotalSale
        lblComAcer.Text = CommissionAcer
        lblComHp.Text = CommissionHp
        lblComTotal.Text = CommissionTotal
    End Sub
End Class