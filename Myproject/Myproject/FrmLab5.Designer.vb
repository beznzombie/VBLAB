<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLab5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtProduct = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.txtUnit = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblPaid = New System.Windows.Forms.Label()
        Me.lblCredit = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radMember = New System.Windows.Forms.RadioButton()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radPaid = New System.Windows.Forms.RadioButton()
        Me.radCredit = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "โปรแกรมคำนวณการขาย"
        '
        'txtProduct
        '
        Me.txtProduct.Location = New System.Drawing.Point(159, 89)
        Me.txtProduct.Name = "txtProduct"
        Me.txtProduct.Size = New System.Drawing.Size(184, 20)
        Me.txtProduct.TabIndex = 1
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(159, 121)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(184, 20)
        Me.txtPrice.TabIndex = 1
        '
        'txtUnit
        '
        Me.txtUnit.Location = New System.Drawing.Point(159, 151)
        Me.txtUnit.Name = "txtUnit"
        Me.txtUnit.Size = New System.Drawing.Size(184, 20)
        Me.txtUnit.TabIndex = 1
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.SteelBlue
        Me.btnCalculate.Location = New System.Drawing.Point(162, 372)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(174, 29)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "คำนวณ"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblTotal.Location = New System.Drawing.Point(156, 184)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(187, 23)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblDiscount
        '
        Me.lblDiscount.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblDiscount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblDiscount.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblDiscount.Location = New System.Drawing.Point(156, 276)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(187, 23)
        Me.lblDiscount.TabIndex = 3
        Me.lblDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPaid
        '
        Me.lblPaid.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblPaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblPaid.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblPaid.Location = New System.Drawing.Point(156, 302)
        Me.lblPaid.Name = "lblPaid"
        Me.lblPaid.Size = New System.Drawing.Size(187, 23)
        Me.lblPaid.TabIndex = 3
        Me.lblPaid.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCredit
        '
        Me.lblCredit.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.lblCredit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.lblCredit.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblCredit.Location = New System.Drawing.Point(156, 328)
        Me.lblCredit.Name = "lblCredit"
        Me.lblCredit.Size = New System.Drawing.Size(187, 23)
        Me.lblCredit.TabIndex = 3
        Me.lblCredit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radOther)
        Me.GroupBox1.Controls.Add(Me.radMember)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 215)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(183, 42)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ประเภทลูกค้า"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radCredit)
        Me.GroupBox2.Controls.Add(Me.radPaid)
        Me.GroupBox2.Location = New System.Drawing.Point(208, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(135, 42)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "การชำระเงิน"
        '
        'radMember
        '
        Me.radMember.AutoSize = True
        Me.radMember.Location = New System.Drawing.Point(7, 20)
        Me.radMember.Name = "radMember"
        Me.radMember.Size = New System.Drawing.Size(57, 17)
        Me.radMember.TabIndex = 0
        Me.radMember.TabStop = True
        Me.radMember.Text = "สมาชิก"
        Me.radMember.UseVisualStyleBackColor = True
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(91, 19)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(76, 17)
        Me.radOther.TabIndex = 1
        Me.radOther.TabStop = True
        Me.radOther.Text = "ลูกค้าทั่วไป"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radPaid
        '
        Me.radPaid.AutoSize = True
        Me.radPaid.Location = New System.Drawing.Point(7, 19)
        Me.radPaid.Name = "radPaid"
        Me.radPaid.Size = New System.Drawing.Size(38, 17)
        Me.radPaid.TabIndex = 0
        Me.radPaid.TabStop = True
        Me.radPaid.Text = "สด"
        Me.radPaid.UseVisualStyleBackColor = True
        '
        'radCredit
        '
        Me.radCredit.AutoSize = True
        Me.radCredit.Location = New System.Drawing.Point(73, 19)
        Me.radCredit.Name = "radCredit"
        Me.radCredit.Size = New System.Drawing.Size(43, 17)
        Me.radCredit.TabIndex = 1
        Me.radCredit.TabStop = True
        Me.radCredit.Text = "เชื่อ"
        Me.radCredit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label2.Location = New System.Drawing.Point(11, 89)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(138, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ชื่อสินค้า"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label3.Location = New System.Drawing.Point(11, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ราคาสินค้า"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label4.Location = New System.Drawing.Point(11, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(138, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "จำนวนซื้อ"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label5.Location = New System.Drawing.Point(12, 278)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(138, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "ส่วนลด"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label6.Location = New System.Drawing.Point(12, 304)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "จำนวนเงินที่ต้องชำระ"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label7.Location = New System.Drawing.Point(12, 330)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 21)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "ยอดค้างจำระ"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Label8.Location = New System.Drawing.Point(12, 186)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(138, 17)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "เป็นเงิน"
        '
        'FrmLab5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(377, 416)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblCredit)
        Me.Controls.Add(Me.lblPaid)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtUnit)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtProduct)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLab5"
        Me.Text = "FrmLab5"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtProduct As System.Windows.Forms.TextBox
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit As System.Windows.Forms.TextBox
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblDiscount As System.Windows.Forms.Label
    Friend WithEvents lblPaid As System.Windows.Forms.Label
    Friend WithEvents lblCredit As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents radMember As System.Windows.Forms.RadioButton
    Friend WithEvents radCredit As System.Windows.Forms.RadioButton
    Friend WithEvents radPaid As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
