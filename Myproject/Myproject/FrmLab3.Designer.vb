<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLab3
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
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.cboSize = New System.Windows.Forms.ComboBox()
        Me.BigColor = New System.Windows.Forms.GroupBox()
        Me.lblBSky = New System.Windows.Forms.Label()
        Me.lblBWhite = New System.Windows.Forms.Label()
        Me.lblBBlack = New System.Windows.Forms.Label()
        Me.lblBBrown = New System.Windows.Forms.Label()
        Me.lblBViolet = New System.Windows.Forms.Label()
        Me.lblBYellow = New System.Windows.Forms.Label()
        Me.lblBGreen = New System.Windows.Forms.Label()
        Me.lblBOrange = New System.Windows.Forms.Label()
        Me.lblBBlue = New System.Windows.Forms.Label()
        Me.lblBRed = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblFSky = New System.Windows.Forms.Label()
        Me.lblFWhite = New System.Windows.Forms.Label()
        Me.lblFBlack = New System.Windows.Forms.Label()
        Me.lblFBrown = New System.Windows.Forms.Label()
        Me.lblFViolet = New System.Windows.Forms.Label()
        Me.lblFYellow = New System.Windows.Forms.Label()
        Me.lblFGreen = New System.Windows.Forms.Label()
        Me.lblFOrange = New System.Windows.Forms.Label()
        Me.lblFBlue = New System.Windows.Forms.Label()
        Me.lblFRed = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BigColor.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(179, 64)
        Me.txtInput.Multiline = True
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(300, 60)
        Me.txtInput.TabIndex = 0
        '
        'btnUp
        '
        Me.btnUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnUp.Location = New System.Drawing.Point(479, 64)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(46, 27)
        Me.btnUp.TabIndex = 1
        Me.btnUp.Text = "+"
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.btnDown.Location = New System.Drawing.Point(479, 97)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(46, 27)
        Me.btnDown.TabIndex = 2
        Me.btnDown.Text = "-"
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'cboSize
        '
        Me.cboSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSize.FormattingEnabled = True
        Me.cboSize.Items.AddRange(New Object() {"12", "14", "16", "18", "20", "22", "24", "26", "28", "30", "32", "34", "36", "38", "40", "42", "44", "46", "48", "50"})
        Me.cboSize.Location = New System.Drawing.Point(467, 186)
        Me.cboSize.Name = "cboSize"
        Me.cboSize.Size = New System.Drawing.Size(121, 21)
        Me.cboSize.TabIndex = 3
        '
        'BigColor
        '
        Me.BigColor.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.BigColor.Controls.Add(Me.lblBSky)
        Me.BigColor.Controls.Add(Me.lblBWhite)
        Me.BigColor.Controls.Add(Me.lblBBlack)
        Me.BigColor.Controls.Add(Me.lblBBrown)
        Me.BigColor.Controls.Add(Me.lblBViolet)
        Me.BigColor.Controls.Add(Me.lblBYellow)
        Me.BigColor.Controls.Add(Me.lblBGreen)
        Me.BigColor.Controls.Add(Me.lblBOrange)
        Me.BigColor.Controls.Add(Me.lblBBlue)
        Me.BigColor.Controls.Add(Me.lblBRed)
        Me.BigColor.Location = New System.Drawing.Point(350, 262)
        Me.BigColor.Name = "BigColor"
        Me.BigColor.Size = New System.Drawing.Size(285, 141)
        Me.BigColor.TabIndex = 5
        Me.BigColor.TabStop = False
        Me.BigColor.Text = "BigColor"
        '
        'lblBSky
        '
        Me.lblBSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblBSky.Location = New System.Drawing.Point(221, 85)
        Me.lblBSky.Name = "lblBSky"
        Me.lblBSky.Size = New System.Drawing.Size(46, 36)
        Me.lblBSky.TabIndex = 0
        '
        'lblBWhite
        '
        Me.lblBWhite.BackColor = System.Drawing.Color.White
        Me.lblBWhite.Location = New System.Drawing.Point(169, 85)
        Me.lblBWhite.Name = "lblBWhite"
        Me.lblBWhite.Size = New System.Drawing.Size(46, 36)
        Me.lblBWhite.TabIndex = 0
        '
        'lblBBlack
        '
        Me.lblBBlack.BackColor = System.Drawing.Color.Black
        Me.lblBBlack.Location = New System.Drawing.Point(221, 30)
        Me.lblBBlack.Name = "lblBBlack"
        Me.lblBBlack.Size = New System.Drawing.Size(46, 36)
        Me.lblBBlack.TabIndex = 0
        '
        'lblBBrown
        '
        Me.lblBBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBBrown.Location = New System.Drawing.Point(117, 85)
        Me.lblBBrown.Name = "lblBBrown"
        Me.lblBBrown.Size = New System.Drawing.Size(46, 36)
        Me.lblBBrown.TabIndex = 0
        '
        'lblBViolet
        '
        Me.lblBViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblBViolet.Location = New System.Drawing.Point(169, 30)
        Me.lblBViolet.Name = "lblBViolet"
        Me.lblBViolet.Size = New System.Drawing.Size(46, 36)
        Me.lblBViolet.TabIndex = 0
        '
        'lblBYellow
        '
        Me.lblBYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblBYellow.Location = New System.Drawing.Point(65, 85)
        Me.lblBYellow.Name = "lblBYellow"
        Me.lblBYellow.Size = New System.Drawing.Size(46, 36)
        Me.lblBYellow.TabIndex = 0
        '
        'lblBGreen
        '
        Me.lblBGreen.BackColor = System.Drawing.Color.Green
        Me.lblBGreen.Location = New System.Drawing.Point(117, 30)
        Me.lblBGreen.Name = "lblBGreen"
        Me.lblBGreen.Size = New System.Drawing.Size(46, 36)
        Me.lblBGreen.TabIndex = 0
        '
        'lblBOrange
        '
        Me.lblBOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBOrange.Location = New System.Drawing.Point(13, 85)
        Me.lblBOrange.Name = "lblBOrange"
        Me.lblBOrange.Size = New System.Drawing.Size(46, 36)
        Me.lblBOrange.TabIndex = 0
        '
        'lblBBlue
        '
        Me.lblBBlue.BackColor = System.Drawing.Color.Blue
        Me.lblBBlue.Location = New System.Drawing.Point(65, 30)
        Me.lblBBlue.Name = "lblBBlue"
        Me.lblBBlue.Size = New System.Drawing.Size(46, 36)
        Me.lblBBlue.TabIndex = 0
        '
        'lblBRed
        '
        Me.lblBRed.BackColor = System.Drawing.Color.Red
        Me.lblBRed.Location = New System.Drawing.Point(13, 30)
        Me.lblBRed.Name = "lblBRed"
        Me.lblBRed.Size = New System.Drawing.Size(46, 36)
        Me.lblBRed.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.lblFSky)
        Me.GroupBox1.Controls.Add(Me.lblFWhite)
        Me.GroupBox1.Controls.Add(Me.lblFBlack)
        Me.GroupBox1.Controls.Add(Me.lblFBrown)
        Me.GroupBox1.Controls.Add(Me.lblFViolet)
        Me.GroupBox1.Controls.Add(Me.lblFYellow)
        Me.GroupBox1.Controls.Add(Me.lblFGreen)
        Me.GroupBox1.Controls.Add(Me.lblFOrange)
        Me.GroupBox1.Controls.Add(Me.lblFBlue)
        Me.GroupBox1.Controls.Add(Me.lblFRed)
        Me.GroupBox1.Location = New System.Drawing.Point(59, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(285, 141)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ForeColor"
        '
        'lblFSky
        '
        Me.lblFSky.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblFSky.Location = New System.Drawing.Point(221, 85)
        Me.lblFSky.Name = "lblFSky"
        Me.lblFSky.Size = New System.Drawing.Size(46, 36)
        Me.lblFSky.TabIndex = 0
        '
        'lblFWhite
        '
        Me.lblFWhite.BackColor = System.Drawing.Color.White
        Me.lblFWhite.Location = New System.Drawing.Point(169, 85)
        Me.lblFWhite.Name = "lblFWhite"
        Me.lblFWhite.Size = New System.Drawing.Size(46, 36)
        Me.lblFWhite.TabIndex = 0
        '
        'lblFBlack
        '
        Me.lblFBlack.BackColor = System.Drawing.Color.Black
        Me.lblFBlack.Location = New System.Drawing.Point(221, 30)
        Me.lblFBlack.Name = "lblFBlack"
        Me.lblFBlack.Size = New System.Drawing.Size(46, 36)
        Me.lblFBlack.TabIndex = 0
        '
        'lblFBrown
        '
        Me.lblFBrown.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFBrown.Location = New System.Drawing.Point(117, 85)
        Me.lblFBrown.Name = "lblFBrown"
        Me.lblFBrown.Size = New System.Drawing.Size(46, 36)
        Me.lblFBrown.TabIndex = 0
        '
        'lblFViolet
        '
        Me.lblFViolet.BackColor = System.Drawing.Color.Fuchsia
        Me.lblFViolet.Location = New System.Drawing.Point(169, 30)
        Me.lblFViolet.Name = "lblFViolet"
        Me.lblFViolet.Size = New System.Drawing.Size(46, 36)
        Me.lblFViolet.TabIndex = 0
        '
        'lblFYellow
        '
        Me.lblFYellow.BackColor = System.Drawing.Color.Yellow
        Me.lblFYellow.Location = New System.Drawing.Point(65, 85)
        Me.lblFYellow.Name = "lblFYellow"
        Me.lblFYellow.Size = New System.Drawing.Size(46, 36)
        Me.lblFYellow.TabIndex = 0
        '
        'lblFGreen
        '
        Me.lblFGreen.BackColor = System.Drawing.Color.Green
        Me.lblFGreen.Location = New System.Drawing.Point(117, 30)
        Me.lblFGreen.Name = "lblFGreen"
        Me.lblFGreen.Size = New System.Drawing.Size(46, 36)
        Me.lblFGreen.TabIndex = 0
        '
        'lblFOrange
        '
        Me.lblFOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblFOrange.Location = New System.Drawing.Point(13, 85)
        Me.lblFOrange.Name = "lblFOrange"
        Me.lblFOrange.Size = New System.Drawing.Size(46, 36)
        Me.lblFOrange.TabIndex = 0
        '
        'lblFBlue
        '
        Me.lblFBlue.BackColor = System.Drawing.Color.Blue
        Me.lblFBlue.Location = New System.Drawing.Point(65, 30)
        Me.lblFBlue.Name = "lblFBlue"
        Me.lblFBlue.Size = New System.Drawing.Size(46, 36)
        Me.lblFBlue.TabIndex = 0
        '
        'lblFRed
        '
        Me.lblFRed.BackColor = System.Drawing.Color.Red
        Me.lblFRed.Location = New System.Drawing.Point(13, 30)
        Me.lblFRed.Name = "lblFRed"
        Me.lblFRed.Size = New System.Drawing.Size(46, 36)
        Me.lblFRed.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(56, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "กำหนดตัวเลข"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 187)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ขนาดฟอนต์"
        '
        'FrmLab3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 431)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BigColor)
        Me.Controls.Add(Me.cboSize)
        Me.Controls.Add(Me.btnDown)
        Me.Controls.Add(Me.btnUp)
        Me.Controls.Add(Me.txtInput)
        Me.Name = "FrmLab3"
        Me.Text = "FrmLab32"
        Me.BigColor.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As System.Windows.Forms.TextBox
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents cboSize As System.Windows.Forms.ComboBox
    Friend WithEvents BigColor As System.Windows.Forms.GroupBox
    Friend WithEvents lblBSky As System.Windows.Forms.Label
    Friend WithEvents lblBWhite As System.Windows.Forms.Label
    Friend WithEvents lblBBlack As System.Windows.Forms.Label
    Friend WithEvents lblBBrown As System.Windows.Forms.Label
    Friend WithEvents lblBViolet As System.Windows.Forms.Label
    Friend WithEvents lblBYellow As System.Windows.Forms.Label
    Friend WithEvents lblBGreen As System.Windows.Forms.Label
    Friend WithEvents lblBOrange As System.Windows.Forms.Label
    Friend WithEvents lblBBlue As System.Windows.Forms.Label
    Friend WithEvents lblBRed As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFSky As System.Windows.Forms.Label
    Friend WithEvents lblFWhite As System.Windows.Forms.Label
    Friend WithEvents lblFBlack As System.Windows.Forms.Label
    Friend WithEvents lblFBrown As System.Windows.Forms.Label
    Friend WithEvents lblFViolet As System.Windows.Forms.Label
    Friend WithEvents lblFYellow As System.Windows.Forms.Label
    Friend WithEvents lblFGreen As System.Windows.Forms.Label
    Friend WithEvents lblFOrange As System.Windows.Forms.Label
    Friend WithEvents lblFBlue As System.Windows.Forms.Label
    Friend WithEvents lblFRed As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
