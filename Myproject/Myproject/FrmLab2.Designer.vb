<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLab2
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
        Me.txtComAcer = New System.Windows.Forms.TextBox()
        Me.txtPrintHp = New System.Windows.Forms.TextBox()
        Me.btnCal = New System.Windows.Forms.Button()
        Me.lblTotalSale = New System.Windows.Forms.Label()
        Me.lblComAcer = New System.Windows.Forms.Label()
        Me.lblComHp = New System.Windows.Forms.Label()
        Me.lblComTotal = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtComAcer
        '
        Me.txtComAcer.Location = New System.Drawing.Point(178, 60)
        Me.txtComAcer.Name = "txtComAcer"
        Me.txtComAcer.Size = New System.Drawing.Size(149, 20)
        Me.txtComAcer.TabIndex = 0
        '
        'txtPrintHp
        '
        Me.txtPrintHp.Location = New System.Drawing.Point(178, 104)
        Me.txtPrintHp.Name = "txtPrintHp"
        Me.txtPrintHp.Size = New System.Drawing.Size(149, 20)
        Me.txtPrintHp.TabIndex = 1
        '
        'btnCal
        '
        Me.btnCal.Location = New System.Drawing.Point(143, 288)
        Me.btnCal.Name = "btnCal"
        Me.btnCal.Size = New System.Drawing.Size(75, 23)
        Me.btnCal.TabIndex = 2
        Me.btnCal.Text = "คำนวณ"
        Me.btnCal.UseVisualStyleBackColor = True
        '
        'lblTotalSale
        '
        Me.lblTotalSale.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblTotalSale.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalSale.ForeColor = System.Drawing.Color.Transparent
        Me.lblTotalSale.Location = New System.Drawing.Point(192, 147)
        Me.lblTotalSale.Name = "lblTotalSale"
        Me.lblTotalSale.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalSale.TabIndex = 3
        '
        'lblComAcer
        '
        Me.lblComAcer.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblComAcer.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComAcer.ForeColor = System.Drawing.Color.Transparent
        Me.lblComAcer.Location = New System.Drawing.Point(192, 172)
        Me.lblComAcer.Name = "lblComAcer"
        Me.lblComAcer.Size = New System.Drawing.Size(100, 23)
        Me.lblComAcer.TabIndex = 4
        '
        'lblComHp
        '
        Me.lblComHp.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblComHp.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComHp.ForeColor = System.Drawing.Color.Transparent
        Me.lblComHp.Location = New System.Drawing.Point(192, 197)
        Me.lblComHp.Name = "lblComHp"
        Me.lblComHp.Size = New System.Drawing.Size(100, 23)
        Me.lblComHp.TabIndex = 5
        '
        'lblComTotal
        '
        Me.lblComTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblComTotal.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblComTotal.ForeColor = System.Drawing.Color.Transparent
        Me.lblComTotal.Location = New System.Drawing.Point(192, 223)
        Me.lblComTotal.Name = "lblComTotal"
        Me.lblComTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblComTotal.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Computer Acer Veriton x5"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Printer HP M529DN"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(52, 147)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "ยอดขายรวม"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(52, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "ค่าคอมมิชชั่นคอมพิวเตอร์"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(52, 197)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ค่าคอมมิชชั่นพริ้นเตอร์"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(52, 223)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "ยอดรวมคอมมิชชั่น"
        '
        'FrmLab2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(380, 337)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblComTotal)
        Me.Controls.Add(Me.lblComHp)
        Me.Controls.Add(Me.lblComAcer)
        Me.Controls.Add(Me.lblTotalSale)
        Me.Controls.Add(Me.btnCal)
        Me.Controls.Add(Me.txtPrintHp)
        Me.Controls.Add(Me.txtComAcer)
        Me.Name = "FrmLab2"
        Me.Text = "FrmLab2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtComAcer As System.Windows.Forms.TextBox
    Friend WithEvents txtPrintHp As System.Windows.Forms.TextBox
    Friend WithEvents btnCal As System.Windows.Forms.Button
    Friend WithEvents lblTotalSale As System.Windows.Forms.Label
    Friend WithEvents lblComAcer As System.Windows.Forms.Label
    Friend WithEvents lblComHp As System.Windows.Forms.Label
    Friend WithEvents lblComTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
