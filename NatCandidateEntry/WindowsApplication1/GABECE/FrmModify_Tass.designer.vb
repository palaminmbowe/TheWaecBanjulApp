<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmModify_Tass
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmModify_Tass))
        Me.Waeclbl = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CboCenCode = New System.Windows.Forms.ComboBox
        Me.CboCanNo = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CboSubName = New System.Windows.Forms.ComboBox
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.CandidatName = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ChkAbs = New System.Windows.Forms.CheckBox
        Me.txtMark = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CmdExit = New System.Windows.Forms.Button
        Me.cmdModify = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.txtexamyr = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Waeclbl
        '
        Me.Waeclbl.AllowDrop = True
        Me.Waeclbl.AutoSize = True
        Me.Waeclbl.BackColor = System.Drawing.Color.Transparent
        Me.Waeclbl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Waeclbl.ForeColor = System.Drawing.Color.Gold
        Me.Waeclbl.Location = New System.Drawing.Point(218, 18)
        Me.Waeclbl.Name = "Waeclbl"
        Me.Waeclbl.Size = New System.Drawing.Size(371, 19)
        Me.Waeclbl.TabIndex = 27
        Me.Waeclbl.Text = "The West African Examinations Council, Banjul Office"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(365, 40)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(72, 75)
        Me.PictureBox2.TabIndex = 28
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(330, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 19)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Modify Tass Marks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label2.Location = New System.Drawing.Point(7, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 19)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Centre Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(196, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Candidate Number"
        '
        'CboCenCode
        '
        Me.CboCenCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCenCode.FormattingEnabled = True
        Me.CboCenCode.Location = New System.Drawing.Point(99, 54)
        Me.CboCenCode.Name = "CboCenCode"
        Me.CboCenCode.Size = New System.Drawing.Size(91, 21)
        Me.CboCenCode.TabIndex = 1
        '
        'CboCanNo
        '
        Me.CboCanNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCanNo.FormattingEnabled = True
        Me.CboCanNo.Location = New System.Drawing.Point(344, 55)
        Me.CboCanNo.Name = "CboCanNo"
        Me.CboCanNo.Size = New System.Drawing.Size(100, 21)
        Me.CboCanNo.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(443, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Subject Name"
        '
        'CboSubName
        '
        Me.CboSubName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSubName.FormattingEnabled = True
        Me.CboSubName.Location = New System.Drawing.Point(547, 54)
        Me.CboSubName.Name = "CboSubName"
        Me.CboSubName.Size = New System.Drawing.Size(216, 21)
        Me.CboSubName.TabIndex = 3
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLName.Location = New System.Drawing.Point(123, 100)
        Me.txtLName.MinimumSize = New System.Drawing.Size(10, 4)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(301, 25)
        Me.txtLName.TabIndex = 4
        '
        'CandidatName
        '
        Me.CandidatName.AutoSize = True
        Me.CandidatName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CandidatName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CandidatName.Location = New System.Drawing.Point(6, 108)
        Me.CandidatName.Name = "CandidatName"
        Me.CandidatName.Size = New System.Drawing.Size(116, 17)
        Me.CandidatName.TabIndex = 37
        Me.CandidatName.Text = "Candidate Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkAbs)
        Me.GroupBox2.Controls.Add(Me.txtMark)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(23, 306)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(239, 54)
        Me.GroupBox2.TabIndex = 38
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "TassMark"
        '
        'ChkAbs
        '
        Me.ChkAbs.AutoSize = True
        Me.ChkAbs.Location = New System.Drawing.Point(166, 27)
        Me.ChkAbs.Name = "ChkAbs"
        Me.ChkAbs.Size = New System.Drawing.Size(59, 17)
        Me.ChkAbs.TabIndex = 44
        Me.ChkAbs.Text = "Absent"
        Me.ChkAbs.UseVisualStyleBackColor = True
        '
        'txtMark
        '
        Me.txtMark.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMark.Location = New System.Drawing.Point(67, 19)
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(93, 25)
        Me.txtMark.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(16, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Mark"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CmdExit)
        Me.GroupBox3.Controls.Add(Me.cmdModify)
        Me.GroupBox3.Controls.Add(Me.CmdClear)
        Me.GroupBox3.Location = New System.Drawing.Point(303, 306)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(303, 54)
        Me.GroupBox3.TabIndex = 39
        Me.GroupBox3.TabStop = False
        '
        'CmdExit
        '
        Me.CmdExit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(203, 12)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(81, 32)
        Me.CmdExit.TabIndex = 8
        Me.CmdExit.Text = "Exit"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'cmdModify
        '
        Me.cmdModify.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdModify.Location = New System.Drawing.Point(6, 12)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.Size = New System.Drawing.Size(110, 31)
        Me.cmdModify.TabIndex = 6
        Me.cmdModify.Text = "Modify Marks"
        Me.cmdModify.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.Location = New System.Drawing.Point(122, 12)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(75, 32)
        Me.CmdClear.TabIndex = 7
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'txtexamyr
        '
        Me.txtexamyr.Location = New System.Drawing.Point(89, 19)
        Me.txtexamyr.Name = "txtexamyr"
        Me.txtexamyr.Size = New System.Drawing.Size(71, 20)
        Me.txtexamyr.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(9, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Exam Year"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboCanNo)
        Me.GroupBox1.Controls.Add(Me.txtexamyr)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.CboSubName)
        Me.GroupBox1.Controls.Add(Me.CboCenCode)
        Me.GroupBox1.Controls.Add(Me.txtLName)
        Me.GroupBox1.Controls.Add(Me.CandidatName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(23, 160)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(769, 140)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Candidate Details"
        '
        'FrmModify_Tass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(804, 393)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Waeclbl)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmModify_Tass"
        Me.Text = "TASS_ M A R K S  M O D I F I C A T I O N"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Waeclbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CboCenCode As System.Windows.Forms.ComboBox
    Friend WithEvents CboCanNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CboSubName As System.Windows.Forms.ComboBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents CandidatName As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdModify As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents txtexamyr As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkAbs As System.Windows.Forms.CheckBox
End Class
