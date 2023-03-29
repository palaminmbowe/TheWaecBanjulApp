<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTassEntry
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTassEntry))
        Me.CmdExit = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtMark1 = New System.Windows.Forms.TextBox
        Me.CboCanNo = New System.Windows.Forms.ComboBox
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.CandidatName = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ChkAbs = New System.Windows.Forms.CheckBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmdviewall_marks = New System.Windows.Forms.Button
        Me.CompleteRecs = New System.Windows.Forms.Button
        Me.cmdOCand = New System.Windows.Forms.Button
        Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblWaec = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboCentCode = New System.Windows.Forms.ComboBox
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txttotscript = New System.Windows.Forms.TextBox
        Me.txtoutscript = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbltotscripts = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.lblSubjcode = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblSubjName = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cbosubjcode = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CboSubjName = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtexamyr = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdExit
        '
        Me.CmdExit.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(168, 19)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(55, 25)
        Me.CmdExit.TabIndex = 10
        Me.CmdExit.Text = "Exit"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label8.Location = New System.Drawing.Point(21, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 19)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Subject Code"
        '
        'CmdClear
        '
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.Location = New System.Drawing.Point(87, 19)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(75, 25)
        Me.CmdClear.TabIndex = 9
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CmdAdd
        '
        Me.CmdAdd.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.Location = New System.Drawing.Point(6, 19)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(75, 25)
        Me.CmdAdd.TabIndex = 2
        Me.CmdAdd.Text = "Add"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label7.Location = New System.Drawing.Point(12, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "Mark "
        '
        'txtMark1
        '
        Me.txtMark1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMark1.Location = New System.Drawing.Point(62, 24)
        Me.txtMark1.Name = "txtMark1"
        Me.txtMark1.Size = New System.Drawing.Size(93, 25)
        Me.txtMark1.TabIndex = 1
        '
        'CboCanNo
        '
        Me.CboCanNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCanNo.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CboCanNo.FormatString = "000"
        Me.CboCanNo.FormattingEnabled = True
        Me.CboCanNo.ItemHeight = 19
        Me.CboCanNo.Location = New System.Drawing.Point(157, 33)
        Me.CboCanNo.MaxDropDownItems = 1
        Me.CboCanNo.Name = "CboCanNo"
        Me.CboCanNo.Size = New System.Drawing.Size(64, 27)
        Me.CboCanNo.TabIndex = 60
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtLName.Location = New System.Drawing.Point(354, 34)
        Me.txtLName.MinimumSize = New System.Drawing.Size(10, 4)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.ReadOnly = True
        Me.txtLName.Size = New System.Drawing.Size(220, 26)
        Me.txtLName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label5.Location = New System.Drawing.Point(8, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Subject Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label4.Location = New System.Drawing.Point(8, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 19)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Candidate Index No"
        '
        'CandidatName
        '
        Me.CandidatName.AutoSize = True
        Me.CandidatName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CandidatName.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CandidatName.Location = New System.Drawing.Point(227, 41)
        Me.CandidatName.Name = "CandidatName"
        Me.CandidatName.Size = New System.Drawing.Size(121, 19)
        Me.CandidatName.TabIndex = 31
        Me.CandidatName.Text = "Candidate Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkAbs)
        Me.GroupBox2.Controls.Add(Me.txtMark1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(55, 359)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 66)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tass Marks"
        '
        'ChkAbs
        '
        Me.ChkAbs.AutoSize = True
        Me.ChkAbs.Location = New System.Drawing.Point(171, 32)
        Me.ChkAbs.Name = "ChkAbs"
        Me.ChkAbs.Size = New System.Drawing.Size(62, 17)
        Me.ChkAbs.TabIndex = 43
        Me.ChkAbs.Text = "Absent"
        Me.ChkAbs.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdviewall_marks)
        Me.GroupBox3.Controls.Add(Me.CompleteRecs)
        Me.GroupBox3.Controls.Add(Me.cmdOCand)
        Me.GroupBox3.Controls.Add(Me.CmdExit)
        Me.GroupBox3.Controls.Add(Me.CmdAdd)
        Me.GroupBox3.Controls.Add(Me.CmdClear)
        Me.GroupBox3.Location = New System.Drawing.Point(55, 431)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(747, 62)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        '
        'cmdviewall_marks
        '
        Me.cmdviewall_marks.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdviewall_marks.Location = New System.Drawing.Point(517, 20)
        Me.cmdviewall_marks.Name = "cmdviewall_marks"
        Me.cmdviewall_marks.Size = New System.Drawing.Size(102, 22)
        Me.cmdviewall_marks.TabIndex = 48
        Me.cmdviewall_marks.Text = "View All Marks"
        Me.cmdviewall_marks.UseVisualStyleBackColor = True
        '
        'CompleteRecs
        '
        Me.CompleteRecs.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CompleteRecs.ForeColor = System.Drawing.Color.Black
        Me.CompleteRecs.Location = New System.Drawing.Point(376, 19)
        Me.CompleteRecs.Name = "CompleteRecs"
        Me.CompleteRecs.Size = New System.Drawing.Size(135, 25)
        Me.CompleteRecs.TabIndex = 16
        Me.CompleteRecs.Text = "Complete Candidates"
        Me.CompleteRecs.UseVisualStyleBackColor = True
        '
        'cmdOCand
        '
        Me.cmdOCand.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdOCand.ForeColor = System.Drawing.Color.Black
        Me.cmdOCand.Location = New System.Drawing.Point(229, 19)
        Me.cmdOCand.Name = "cmdOCand"
        Me.cmdOCand.Size = New System.Drawing.Size(141, 25)
        Me.cmdOCand.TabIndex = 15
        Me.cmdOCand.Text = "Incomplete Candidates"
        Me.cmdOCand.UseVisualStyleBackColor = True
        '
        'errorProvider
        '
        Me.errorProvider.ContainerControl = Me
        '
        'lblWaec
        '
        Me.lblWaec.AutoSize = True
        Me.lblWaec.BackColor = System.Drawing.Color.Transparent
        Me.lblWaec.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWaec.ForeColor = System.Drawing.Color.Gold
        Me.lblWaec.Location = New System.Drawing.Point(247, 6)
        Me.lblWaec.Name = "lblWaec"
        Me.lblWaec.Size = New System.Drawing.Size(371, 19)
        Me.lblWaec.TabIndex = 26
        Me.lblWaec.Text = "The West African Examinations Council, Banjul Office"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(315, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 19)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "GABECE TASS MARKS ENTRY"
        '
        'CboCentCode
        '
        Me.CboCentCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCentCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCentCode.FormattingEnabled = True
        Me.CboCentCode.Location = New System.Drawing.Point(644, 21)
        Me.CboCentCode.MaxDropDownItems = 4
        Me.CboCentCode.Name = "CboCentCode"
        Me.CboCentCode.Size = New System.Drawing.Size(114, 25)
        Me.CboCentCode.TabIndex = 10
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(37, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 17)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Exam Year"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txttotscript)
        Me.GroupBox1.Controls.Add(Me.txtoutscript)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbltotscripts)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.lblSubjcode)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lblSubjName)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(55, 191)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(765, 79)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paper Details"
        '
        'txttotscript
        '
        Me.txttotscript.Location = New System.Drawing.Point(690, 17)
        Me.txttotscript.Name = "txttotscript"
        Me.txttotscript.Size = New System.Drawing.Size(57, 22)
        Me.txttotscript.TabIndex = 57
        '
        'txtoutscript
        '
        Me.txtoutscript.Location = New System.Drawing.Point(689, 44)
        Me.txtoutscript.Name = "txtoutscript"
        Me.txtoutscript.Size = New System.Drawing.Size(58, 22)
        Me.txtoutscript.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(478, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(211, 19)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "Total No. of Scripts Allocated:"
        '
        'lbltotscripts
        '
        Me.lbltotscripts.AutoSize = True
        Me.lbltotscripts.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotscripts.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbltotscripts.Location = New System.Drawing.Point(695, 18)
        Me.lbltotscripts.Name = "lbltotscripts"
        Me.lbltotscripts.Size = New System.Drawing.Size(0, 19)
        Me.lbltotscripts.TabIndex = 56
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label13.Location = New System.Drawing.Point(479, 43)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(184, 19)
        Me.Label13.TabIndex = 55
        Me.Label13.Text = "Total Marks Outstanding:"
        '
        'lblSubjcode
        '
        Me.lblSubjcode.AutoSize = True
        Me.lblSubjcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjcode.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSubjcode.Location = New System.Drawing.Point(129, 44)
        Me.lblSubjcode.Name = "lblSubjcode"
        Me.lblSubjcode.Size = New System.Drawing.Size(89, 19)
        Me.lblSubjcode.TabIndex = 54
        Me.lblSubjcode.Text = "lblSubjCode"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label6.Location = New System.Drawing.Point(21, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(102, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Subject Name"
        '
        'lblSubjName
        '
        Me.lblSubjName.AutoSize = True
        Me.lblSubjName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubjName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblSubjName.Location = New System.Drawing.Point(129, 18)
        Me.lblSubjName.Name = "lblSubjName"
        Me.lblSubjName.Size = New System.Drawing.Size(94, 19)
        Me.lblSubjName.TabIndex = 46
        Me.lblSubjName.Text = "lblSubjName"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtLName)
        Me.GroupBox4.Controls.Add(Me.CandidatName)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.CboCanNo)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox4.Location = New System.Drawing.Point(55, 276)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(690, 77)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Candidate Details"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cbosubjcode)
        Me.GroupBox5.Controls.Add(Me.Label1)
        Me.GroupBox5.Controls.Add(Me.CboSubjName)
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.CboCentCode)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox5.Location = New System.Drawing.Point(56, 129)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(764, 56)
        Me.GroupBox5.TabIndex = 54
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Subject Details"
        '
        'cbosubjcode
        '
        Me.cbosubjcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbosubjcode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbosubjcode.FormattingEnabled = True
        Me.cbosubjcode.Location = New System.Drawing.Point(427, 20)
        Me.cbosubjcode.MaxDropDownItems = 4
        Me.cbosubjcode.Name = "cbosubjcode"
        Me.cbosubjcode.Size = New System.Drawing.Size(121, 25)
        Me.cbosubjcode.TabIndex = 56
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label1.Location = New System.Drawing.Point(326, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Subject Code:"
        '
        'CboSubjName
        '
        Me.CboSubjName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSubjName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSubjName.FormattingEnabled = True
        Me.CboSubjName.Location = New System.Drawing.Point(117, 17)
        Me.CboSubjName.MaxDropDownItems = 4
        Me.CboSubjName.Name = "CboSubjName"
        Me.CboSubjName.Size = New System.Drawing.Size(203, 25)
        Me.CboSubjName.TabIndex = 52
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label11.Location = New System.Drawing.Point(545, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 53
        Me.Label11.Text = "Centre Code"
        '
        'txtexamyr
        '
        Me.txtexamyr.Location = New System.Drawing.Point(117, 82)
        Me.txtexamyr.Name = "txtexamyr"
        Me.txtexamyr.Size = New System.Drawing.Size(71, 20)
        Me.txtexamyr.TabIndex = 54
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(404, 28)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 76)
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'FrmTassEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(883, 508)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.txtexamyr)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblWaec)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmTassEntry"
        Me.Text = "G A B E C E   T A S S   M A R K  S"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtMark1 As System.Windows.Forms.TextBox
    Friend WithEvents CboCanNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CandidatName As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents errorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdOCand As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblWaec As System.Windows.Forms.Label
    Friend WithEvents CboCentCode As System.Windows.Forms.ComboBox
    Friend WithEvents CompleteRecs As System.Windows.Forms.Button
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdviewall_marks As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ChkAbs As System.Windows.Forms.CheckBox
    Friend WithEvents lblSubjName As System.Windows.Forms.Label
    Friend WithEvents CboSubjName As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblSubjcode As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtexamyr As System.Windows.Forms.TextBox
    Friend WithEvents cbosubjcode As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbltotscripts As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txttotscript As System.Windows.Forms.TextBox
    Friend WithEvents txtoutscript As System.Windows.Forms.TextBox

End Class
