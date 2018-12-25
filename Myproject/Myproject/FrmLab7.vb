Public Class FrmLab7
    Private Sub FrmLab7_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnAdd.Enabled = False
    End Sub
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        lstAdd.Items.Add(txtAdd.Text)
        txtAdd.Clear()
        txtAdd.Focus()
        Dim n As Integer
        n = lstAdd.Items.Count
        lstAdd.SelectedIndex = n - 1
    End Sub
    Private Sub txtAdd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdd.TextChanged
        If txtAdd.Text = "" Then
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
        End If
    End Sub


    Private Sub btnMove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMove.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("กรุณากรอกข้อมูล")
        Else
            cboOutput.Items.Add(lstAdd.SelectedItem)
            lstAdd.Items.Remove(lstAdd.SelectedItem)
            Dim n As Integer

            n = cboOutput.Items.Count
            cboOutput.SelectedIndex = n - 1
            n = lstAdd.Items.Count
            lstAdd.SelectedIndex = n - 1
        End If
    End Sub

    Private Sub btnMoveAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMoveAll.Click
        If lstAdd.SelectedIndex = -1 Then
            MessageBox.Show("กรุณากรอกข้อมูล")
        Else
            For Each Item As String In lstAdd.Items
                cboOutput.Items.Add(Item)
            Next
            lstAdd.Items.Clear()
            Dim n As Integer
            n = cboOutput.Items.Count
            cboOutput.SelectedIndex = n - 1
            n = lstAdd.Items.Count
            lstAdd.SelectedIndex = n - 1
        End If
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        If cboOutput.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเพิ่มข้อมูล")
        Else
            lstAdd.Items.Add(cboOutput.SelectedItem)
            cboOutput.Items.Remove(cboOutput.SelectedItem)
            Dim n As Integer
            n = lstAdd.Items.Count
            lstAdd.SelectedIndex = n - 1
            n = cboOutput.Items.Count
            cboOutput.SelectedIndex = n - 1
        End If
    End Sub

    Private Sub btnBackAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackAll.Click
        If cboOutput.SelectedIndex = -1 Then
            MessageBox.Show("กรุณาเพิ่มข้อมูล")
        Else
            For Each Item As String In cboOutput.Items
                lstAdd.Items.Add(Item)
            Next
            cboOutput.Items.Clear()
            Dim n As Integer
            n = lstAdd.Items.Count
            lstAdd.SelectedIndex = n - 1
            n = cboOutput.Items.Count
            cboOutput.SelectedIndex = n - 1
        End If
    End Sub

    Private Sub cboOutput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboOutput.SelectedIndexChanged
        lblOutput.Text = cboOutput.SelectedItem
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        lblOutput.Text = ""
        txtAdd.Clear()
        lstAdd.Items.Clear()
        cboOutput.Items.Clear()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class