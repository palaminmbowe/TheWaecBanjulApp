<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCentEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtCentCode = New System.Windows.Forms.TextBox
        Me.txtCentAdd = New System.Windows.Forms.TextBox
        Me.txtCentName = New System.Windows.Forms.TextBox
        Me.lblwaec = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblCentCode = New System.Windows.Forms.Label
        Me.lblCentName = New System.Windows.Forms.Label
        Me.lblCentAdd = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmdModify = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdNext = New System.Windows.Forms.Button
        Me.CmdExit = New System.Windows.Forms.Button
        Me.CmdFirst = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.CmdLast = New System.Windows.Forms.Button
        Me.CmdPrev = New System.Windows.Forms.Button
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtCentCode
        '
        Me.txtCentCode.Location = New System.Drawing.Point(144, 154)
        Me.txtCentCode.Name = "txtCentCode"
        Me.txtCentCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCentCode.TabIndex = 0
        '
        'txtCentAdd
        '
        Me.txtCentAdd.Location = New System.Drawing.Point(144, 230)
        Me.txtCentAdd.Name = "txtCentAdd"
        Me.txtCentAdd.Size = New System.Drawing.Size(416, 20)
        Me.txtCentAdd.TabIndex = 1
        '
        'txtCentName
        '
        Me.txtCentName.Location = New System.Drawing.Point(144, 193)
        Me.txtCentName.Name = "txtCentName"
        Me.txtCentName.Size = New System.Drawing.Size(416, 20)
        Me.txtCentName.TabIndex = 2
        '
        'lblwaec
        '
        Me.lblwaec.AutoSize = True
        Me.lblwaec.BackColor = System.Drawing.Color.Navy
        Me.lblwaec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwaec.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaec.ForeColor = System.Drawing.Color.Yellow
        Me.lblwaec.Location = New System.Drawing.Point(100, 9)
        Me.lblwaec.Name = "lblwaec"
        Me.lblwaec.Size = New System.Drawing.Size(367, 26)
        Me.lblwaec.TabIndex = 41
        Me.lblwaec.Text = "The West African Examinations Council"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Navy
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(44, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(493, 24)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "The Gambia Basic Education Examination Certificate "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Navy
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(176, 80)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(181, 24)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Centre Entry Form"
        '
        'lblCentCode
        '
        Me.lblCentCode.AutoSize = True
        Me.lblCentCode.Location = New System.Drawing.Point(52, 157)
        Me.lblCentCode.Name = "lblCentCode"
        Me.lblCentCode.Size = New System.Drawing.Size(66, 13)
        Me.lblCentCode.TabIndex = 44
        Me.lblCentCode.Text = "Center Code"
        '
        'lblCentName
        '
        Me.lblCentName.AutoSize = True
        Me.lblCentName.Location = New System.Drawing.Point(52, 196)
        Me.lblCentName.Name = "lblCentName"
        Me.lblCentName.Size = New System.Drawing.Size(69, 13)
        Me.lblCentName.TabIndex = 45
        Me.lblCentName.Text = "Centre Name"
        '
        'lblCentAdd
        '
        Me.lblCentAdd.AutoSize = True
        Me.lblCentAdd.Location = New System.Drawing.Point(52, 233)
        Me.lblCentAdd.Name = "lblCentAdd"
        Me.lblCentAdd.Size = New System.Drawing.Size(79, 13)
        Me.lblCentAdd.TabIndex = 46
        Me.lblCentAdd.Text = "Centre Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(167, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(220, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Instructions: Please Enter the Centre Details. "
        '
        'CmdModify
        '
        Me.CmdModify.AutoSize = True
        Me.CmdModify.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdModify.Location = New System.Drawing.Point(263, 304)
        Me.CmdModify.Name = "CmdModify"
        Me.CmdModify.Size = New System.Drawing.Size(57, 25)
        Me.CmdModify.TabIndex = 73
        Me.CmdModify.Text = "Modify "
        Me.CmdModify.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.AutoSize = True
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.Location = New System.Drawing.Point(388, 307)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(48, 25)
        Me.CmdClear.TabIndex = 74
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdNext
        '
        Me.CmdNext.AutoSize = True
        Me.CmdNext.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNext.Location = New System.Drawing.Point(326, 336)
        Me.CmdNext.Name = "CmdNext"
        Me.CmdNext.Size = New System.Drawing.Size(56, 25)
        Me.CmdNext.TabIndex = 69
        Me.CmdNext.Text = "Next"
        Me.CmdNext.UseVisualStyleBackColor = True
        '
        'CmdExit
        '
        Me.CmdExit.AutoSize = True
        Me.CmdExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(613, 359)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(38, 25)
        Me.CmdExit.TabIndex = 75
        Me.CmdExit.Text = "Exit"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'CmdFirst
        '
        Me.CmdFirst.AutoSize = True
        Me.CmdFirst.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFirst.Location = New System.Drawing.Point(212, 336)
        Me.CmdFirst.Name = "CmdFirst"
        Me.CmdFirst.Size = New System.Drawing.Size(44, 25)
        Me.CmdFirst.TabIndex = 68
        Me.CmdFirst.Text = "First"
        Me.CmdFirst.UseVisualStyleBackColor = True
        '
        'CmdAdd
        '
        Me.CmdAdd.AutoSize = True
        Me.CmdAdd.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.Location = New System.Drawing.Point(212, 304)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(44, 25)
        Me.CmdAdd.TabIndex = 72
        Me.CmdAdd.Text = "Add"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'CmdLast
        '
        Me.CmdLast.AutoSize = True
        Me.CmdLast.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLast.Location = New System.Drawing.Point(388, 338)
        Me.CmdLast.Name = "CmdLast"
        Me.CmdLast.Size = New System.Drawing.Size(48, 25)
        Me.CmdLast.TabIndex = 71
        Me.CmdLast.Text = "Last"
        Me.CmdLast.UseVisualStyleBackColor = True
        '
        'CmdPrev
        '
        Me.CmdPrev.AutoSize = True
        Me.CmdPrev.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrev.Location = New System.Drawing.Point(263, 336)
        Me.CmdPrev.Name = "CmdPrev"
        Me.CmdPrev.Size = New System.Drawing.Size(57, 25)
        Me.CmdPrev.TabIndex = 70
        Me.CmdPrev.Text = "Prev"
        Me.CmdPrev.UseVisualStyleBackColor = True
        '
        'CmdSearch
        '
        Me.CmdSearch.AutoSize = True
        Me.CmdSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSearch.Location = New System.Drawing.Point(326, 307)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(56, 25)
        Me.CmdSearch.TabIndex = 76
        Me.CmdSearch.Text = "Search"
        Me.CmdSearch.UseVisualStyleBackColor = True
        '
        'FrmCentEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(663, 396)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.CmdModify)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdNext)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdFirst)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.CmdLast)
        Me.Controls.Add(Me.CmdPrev)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCentAdd)
        Me.Controls.Add(Me.lblCentName)
        Me.Controls.Add(Me.lblCentCode)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblwaec)
        Me.Controls.Add(Me.txtCentName)
        Me.Controls.Add(Me.txtCentAdd)
        Me.Controls.Add(Me.txtCentCode)
        Me.Name = "FrmCentEntry"
        Me.Text = "Centre Entry Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCentCode As System.Windows.Forms.TextBox
    Friend WithEvents txtCentAdd As System.Windows.Forms.TextBox
    Friend WithEvents txtCentName As System.Windows.Forms.TextBox
    Friend WithEvents lblwaec As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblCentCode As System.Windows.Forms.Label
    Friend WithEvents lblCentName As System.Windows.Forms.Label
    Friend WithEvents lblCentAdd As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdModify As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdNext As System.Windows.Forms.Button
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents CmdFirst As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents CmdLast As System.Windows.Forms.Button
    Friend WithEvents CmdPrev As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
End Class
