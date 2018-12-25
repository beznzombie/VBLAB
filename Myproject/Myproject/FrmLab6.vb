Public Class FrmLab6
    Dim Total As Integer
    Private Sub FrmLab6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Total = Val(lblStartPrice.Text) + Val(lblFree1.Text) + Val(lblFree2.Text) + Val(lblFree3.Text)
    End Sub
    Private Sub chkCarForMe_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCarForMe.CheckedChanged
        If chkCarForMe.Checked Then
            chkItemAdd1.Enabled = True
            chkItemAdd2.Enabled = True
            chkItemAdd3.Enabled = True
            chkItemAdd4.Enabled = True
            chkFree1.Enabled = True
            chkFree2.Enabled = True
            chkFree3.Enabled = True
            lblPaidPrice.Text = Total
        Else

            If MsgBox("คุณต้องการจะยกเลิกใช่หรือไม่", vbYesNo) = vbYes Then

                chkItemAdd1.Enabled = False
                chkItemAdd2.Enabled = False
                chkItemAdd3.Enabled = False
                chkItemAdd4.Enabled = False
                chkFree1.Enabled = False
                chkFree2.Enabled = False
                chkFree3.Enabled = False

                chkItemAdd1.Checked = False
                chkItemAdd2.Checked = False
                chkItemAdd3.Checked = False
                chkItemAdd4.Checked = False
                chkFree1.Checked = False
                chkFree2.Checked = False
                chkFree3.Checked = False
                lblPaidPrice.Text = ""
            Else
                chkCarForMe.Checked = True

            End If
        End If


    End Sub

    Private Sub chkItemAdd1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemAdd1.CheckedChanged
        If chkItemAdd1.Checked Then
            Total = Total + Val(lblItemPrice1.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total - Val(lblItemPrice1.Text)
            lblPaidPrice.Text = Total
        End If

    End Sub

    Private Sub chkItemAdd2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemAdd2.CheckedChanged
        If chkItemAdd2.Checked Then
            Total = Total + Val(lblItemPrice2.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total - Val(lblItemPrice2.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkItemAdd3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemAdd3.CheckedChanged
        If chkItemAdd3.Checked Then
            Total = Total + Val(lblItemPrice3.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total - Val(lblItemPrice3.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkItemAdd4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkItemAdd4.CheckedChanged
        If chkItemAdd4.Checked Then
            Total = Total + Val(lblItemPrice4.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total - Val(lblItemPrice4.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkFree1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree1.CheckedChanged
        If chkFree1.Checked Then
            Total = Total - Val(lblFree1.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total + Val(lblFree1.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkFree2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree2.CheckedChanged
        If chkFree2.Checked Then
            Total = Total - Val(lblFree2.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total + Val(lblFree2.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

    Private Sub chkFree3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkFree3.CheckedChanged
        If chkFree3.Checked Then
            Total = Total - Val(lblFree3.Text)
            lblPaidPrice.Text = Total
        Else
            Total = Total + Val(lblFree3.Text)
            lblPaidPrice.Text = Total
        End If
    End Sub

   
End Class