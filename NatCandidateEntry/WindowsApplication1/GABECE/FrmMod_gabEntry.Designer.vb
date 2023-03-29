<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMod_gabEntry
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMod_gabEntry))
        Me.lblwaec = New System.Windows.Forms.Label()
        Me.CmdModify = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OptMale = New System.Windows.Forms.RadioButton()
        Me.OptFemale = New System.Windows.Forms.RadioButton()
        Me.OptBMale = New System.Windows.Forms.RadioButton()
        Me.OptBFemale = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CmdExit = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lblcandSurname = New System.Windows.Forms.Label()
        Me.txtLName = New System.Windows.Forms.TextBox()
        Me.txtTot_Sub = New System.Windows.Forms.TextBox()
        Me.CmdClear = New System.Windows.Forms.Button()
        Me.CboCentCode = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GrpGender = New System.Windows.Forms.GroupBox()
        Me.lblSchofCho = New System.Windows.Forms.Label()
        Me.ChkEnglish = New System.Windows.Forms.CheckBox()
        Me.ChkMaths = New System.Windows.Forms.CheckBox()
        Me.ChkScience = New System.Windows.Forms.CheckBox()
        Me.ChkSES = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.label6 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.CboGrp2 = New System.Windows.Forms.ComboBox()
        Me.CboGrp3 = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblExamYear = New System.Windows.Forms.Label()
        Me.txtOtherName = New System.Windows.Forms.TextBox()
        Me.LblOtherName = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cbocanno = New System.Windows.Forms.ComboBox()
        Me.txtsname = New System.Windows.Forms.TextBox()
        Me.txtscode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtexamyr = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtschcode = New System.Windows.Forms.TextBox()
        Me.cmdretrieve = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cboSchname = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GrpGender.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblwaec
        '
        Me.lblwaec.AutoSize = True
        Me.lblwaec.BackColor = System.Drawing.Color.Transparent
        Me.lblwaec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwaec.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaec.ForeColor = System.Drawing.Color.Yellow
        Me.lblwaec.Location = New System.Drawing.Point(314, 23)
        Me.lblwaec.Name = "lblwaec"
        Me.lblwaec.Size = New System.Drawing.Size(371, 21)
        Me.lblwaec.TabIndex = 0
        Me.lblwaec.Text = "The West African Examinations Council, Banjul Office"
        '
        'CmdModify
        '
        Me.CmdModify.AutoSize = True
        Me.CmdModify.Enabled = False
        Me.CmdModify.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdModify.Location = New System.Drawing.Point(499, 519)
        Me.CmdModify.Name = "CmdModify"
        Me.CmdModify.Size = New System.Drawing.Size(94, 29)
        Me.CmdModify.TabIndex = 18
        Me.CmdModify.Text = "Modify"
        Me.CmdModify.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(5, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Centre Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(43, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Index No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(228, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "First Name"
        '
        'txtFName
        '
        Me.txtFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(315, 46)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(204, 25)
        Me.txtFName.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(216, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Date of Birth"
        '
        'OptMale
        '
        Me.OptMale.AutoSize = True
        Me.OptMale.Checked = True
        Me.OptMale.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptMale.Location = New System.Drawing.Point(8, 19)
        Me.OptMale.Name = "OptMale"
        Me.OptMale.Size = New System.Drawing.Size(60, 21)
        Me.OptMale.TabIndex = 10
        Me.OptMale.TabStop = True
        Me.OptMale.Text = "Male"
        Me.OptMale.UseVisualStyleBackColor = True
        '
        'OptFemale
        '
        Me.OptFemale.AutoSize = True
        Me.OptFemale.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFemale.Location = New System.Drawing.Point(74, 19)
        Me.OptFemale.Name = "OptFemale"
        Me.OptFemale.Size = New System.Drawing.Size(74, 21)
        Me.OptFemale.TabIndex = 11
        Me.OptFemale.Text = "Female"
        Me.OptFemale.UseVisualStyleBackColor = True
        '
        'OptBMale
        '
        Me.OptBMale.AutoSize = True
        Me.OptBMale.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptBMale.Location = New System.Drawing.Point(161, 19)
        Me.OptBMale.Name = "OptBMale"
        Me.OptBMale.Size = New System.Drawing.Size(99, 21)
        Me.OptBMale.TabIndex = 12
        Me.OptBMale.Text = "Blind Male"
        Me.OptBMale.UseVisualStyleBackColor = True
        '
        'OptBFemale
        '
        Me.OptBFemale.AutoSize = True
        Me.OptBFemale.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptBFemale.Location = New System.Drawing.Point(271, 19)
        Me.OptBFemale.Name = "OptBFemale"
        Me.OptBFemale.Size = New System.Drawing.Size(113, 21)
        Me.OptBFemale.TabIndex = 13
        Me.OptBFemale.Text = "Blind Female"
        Me.OptBFemale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(382, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(410, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(207, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Candidate Entry Modification"
        '
        'CmdExit
        '
        Me.CmdExit.AutoSize = True
        Me.CmdExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(699, 519)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(94, 29)
        Me.CmdExit.TabIndex = 21
        Me.CmdExit.Text = "Exit"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(34, 502)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "No. of Subjects"
        '
        'lblcandSurname
        '
        Me.lblcandSurname.AutoSize = True
        Me.lblcandSurname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcandSurname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblcandSurname.Location = New System.Drawing.Point(230, 20)
        Me.lblcandSurname.Name = "lblcandSurname"
        Me.lblcandSurname.Size = New System.Drawing.Size(79, 17)
        Me.lblcandSurname.TabIndex = 28
        Me.lblcandSurname.Text = "Last Name"
        '
        'txtLName
        '
        Me.txtLName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(315, 16)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(204, 25)
        Me.txtLName.TabIndex = 5
        '
        'txtTot_Sub
        '
        Me.txtTot_Sub.Location = New System.Drawing.Point(150, 503)
        Me.txtTot_Sub.Name = "txtTot_Sub"
        Me.txtTot_Sub.Size = New System.Drawing.Size(45, 20)
        Me.txtTot_Sub.TabIndex = 11
        '
        'CmdClear
        '
        Me.CmdClear.AutoSize = True
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.Location = New System.Drawing.Point(599, 519)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(94, 29)
        Me.CmdClear.TabIndex = 20
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CboCentCode
        '
        Me.CboCentCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCentCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCentCode.FormattingEnabled = True
        Me.CboCentCode.Location = New System.Drawing.Point(120, 53)
        Me.CboCentCode.Name = "CboCentCode"
        Me.CboCentCode.Size = New System.Drawing.Size(84, 25)
        Me.CboCentCode.TabIndex = 3
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd-MM-yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(315, 106)
        Me.DateTimePicker1.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(204, 25)
        Me.DateTimePicker1.TabIndex = 8
        '
        'GrpGender
        '
        Me.GrpGender.Controls.Add(Me.OptMale)
        Me.GrpGender.Controls.Add(Me.OptFemale)
        Me.GrpGender.Controls.Add(Me.OptBMale)
        Me.GrpGender.Controls.Add(Me.OptBFemale)
        Me.GrpGender.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpGender.ForeColor = System.Drawing.Color.Gold
        Me.GrpGender.Location = New System.Drawing.Point(545, 297)
        Me.GrpGender.Name = "GrpGender"
        Me.GrpGender.Size = New System.Drawing.Size(389, 46)
        Me.GrpGender.TabIndex = 10
        Me.GrpGender.TabStop = False
        Me.GrpGender.Text = "Gender"
        '
        'lblSchofCho
        '
        Me.lblSchofCho.AutoSize = True
        Me.lblSchofCho.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchofCho.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblSchofCho.Location = New System.Drawing.Point(13, 51)
        Me.lblSchofCho.Name = "lblSchofCho"
        Me.lblSchofCho.Size = New System.Drawing.Size(90, 17)
        Me.lblSchofCho.TabIndex = 43
        Me.lblSchofCho.Text = "School Code"
        '
        'ChkEnglish
        '
        Me.ChkEnglish.AutoSize = True
        Me.ChkEnglish.Checked = True
        Me.ChkEnglish.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkEnglish.Enabled = False
        Me.ChkEnglish.Location = New System.Drawing.Point(6, 19)
        Me.ChkEnglish.Name = "ChkEnglish"
        Me.ChkEnglish.Size = New System.Drawing.Size(144, 21)
        Me.ChkEnglish.TabIndex = 45
        Me.ChkEnglish.Text = "English Language"
        Me.ChkEnglish.UseVisualStyleBackColor = True
        '
        'ChkMaths
        '
        Me.ChkMaths.AutoSize = True
        Me.ChkMaths.Checked = True
        Me.ChkMaths.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkMaths.Enabled = False
        Me.ChkMaths.Location = New System.Drawing.Point(163, 19)
        Me.ChkMaths.Name = "ChkMaths"
        Me.ChkMaths.Size = New System.Drawing.Size(112, 21)
        Me.ChkMaths.TabIndex = 46
        Me.ChkMaths.Text = "Mathematics"
        Me.ChkMaths.UseVisualStyleBackColor = True
        '
        'ChkScience
        '
        Me.ChkScience.AutoSize = True
        Me.ChkScience.Checked = True
        Me.ChkScience.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkScience.Enabled = False
        Me.ChkScience.Location = New System.Drawing.Point(6, 58)
        Me.ChkScience.Name = "ChkScience"
        Me.ChkScience.Size = New System.Drawing.Size(77, 21)
        Me.ChkScience.TabIndex = 47
        Me.ChkScience.Text = "Science"
        Me.ChkScience.UseVisualStyleBackColor = True
        '
        'ChkSES
        '
        Me.ChkSES.AutoSize = True
        Me.ChkSES.Checked = True
        Me.ChkSES.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkSES.Enabled = False
        Me.ChkSES.Location = New System.Drawing.Point(163, 58)
        Me.ChkSES.Name = "ChkSES"
        Me.ChkSES.Size = New System.Drawing.Size(139, 21)
        Me.ChkSES.TabIndex = 48
        Me.ChkSES.Text = "Soc. Env. Studies"
        Me.ChkSES.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkEnglish)
        Me.GroupBox1.Controls.Add(Me.ChkMaths)
        Me.GroupBox1.Controls.Add(Me.ChkScience)
        Me.GroupBox1.Controls.Add(Me.ChkSES)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Yellow
        Me.GroupBox1.Location = New System.Drawing.Point(32, 398)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 94)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Core Subjects"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.Gold
        Me.label6.Location = New System.Drawing.Point(364, 384)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(180, 34)
        Me.label6.TabIndex = 64
        Me.label6.Text = "Group2 Select atleast One" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(558, 384)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(184, 17)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Group3 Select  atleast One"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CboGrp2
        '
        Me.CboGrp2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGrp2.FormattingEnabled = True
        Me.CboGrp2.Location = New System.Drawing.Point(355, 407)
        Me.CboGrp2.Name = "CboGrp2"
        Me.CboGrp2.Size = New System.Drawing.Size(190, 21)
        Me.CboGrp2.TabIndex = 16
        '
        'CboGrp3
        '
        Me.CboGrp3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGrp3.FormattingEnabled = True
        Me.CboGrp3.Location = New System.Drawing.Point(561, 407)
        Me.CboGrp3.Name = "CboGrp3"
        Me.CboGrp3.Size = New System.Drawing.Size(190, 21)
        Me.CboGrp3.TabIndex = 17
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(355, 434)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(190, 56)
        Me.ListBox1.TabIndex = 73
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(561, 434)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(190, 56)
        Me.ListBox2.TabIndex = 74
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(772, 410)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(184, 82)
        Me.ListBox3.TabIndex = 77
        Me.ListBox3.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(800, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 17)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Selected Subjects" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.Visible = False
        '
        'lblExamYear
        '
        Me.lblExamYear.AutoSize = True
        Me.lblExamYear.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamYear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblExamYear.Location = New System.Drawing.Point(39, 20)
        Me.lblExamYear.Name = "lblExamYear"
        Me.lblExamYear.Size = New System.Drawing.Size(77, 17)
        Me.lblExamYear.TabIndex = 82
        Me.lblExamYear.Text = "Exam Year"
        '
        'txtOtherName
        '
        Me.txtOtherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOtherName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherName.Location = New System.Drawing.Point(315, 76)
        Me.txtOtherName.Name = "txtOtherName"
        Me.txtOtherName.Size = New System.Drawing.Size(204, 25)
        Me.txtOtherName.TabIndex = 7
        '
        'LblOtherName
        '
        Me.LblOtherName.AutoSize = True
        Me.LblOtherName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOtherName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LblOtherName.Location = New System.Drawing.Point(213, 80)
        Me.LblOtherName.Name = "LblOtherName"
        Me.LblOtherName.Size = New System.Drawing.Size(96, 17)
        Me.LblOtherName.TabIndex = 84
        Me.LblOtherName.Text = "Other Names"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cbocanno)
        Me.GroupBox2.Controls.Add(Me.txtsname)
        Me.GroupBox2.Controls.Add(Me.txtexamyr)
        Me.GroupBox2.Controls.Add(Me.lblExamYear)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CboCentCode)
        Me.GroupBox2.Controls.Add(Me.txtscode)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtLName)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtOtherName)
        Me.GroupBox2.Controls.Add(Me.LblOtherName)
        Me.GroupBox2.Controls.Add(Me.lblcandSurname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.txtFName)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(32, 146)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(902, 145)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Candidate Details"
        '
        'cbocanno
        '
        Me.cbocanno.FormattingEnabled = True
        Me.cbocanno.Location = New System.Drawing.Point(121, 90)
        Me.cbocanno.Name = "cbocanno"
        Me.cbocanno.Size = New System.Drawing.Size(83, 25)
        Me.cbocanno.TabIndex = 80
        '
        'txtsname
        '
        Me.txtsname.Location = New System.Drawing.Point(554, 104)
        Me.txtsname.Name = "txtsname"
        Me.txtsname.Size = New System.Drawing.Size(326, 25)
        Me.txtsname.TabIndex = 91
        '
        'txtscode
        '
        Me.txtscode.Location = New System.Drawing.Point(667, 44)
        Me.txtscode.Name = "txtscode"
        Me.txtscode.Size = New System.Drawing.Size(81, 25)
        Me.txtscode.TabIndex = 89
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(664, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 17)
        Me.Label12.TabIndex = 90
        Me.Label12.Text = "School Name"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(664, 21)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 17)
        Me.Label13.TabIndex = 88
        Me.Label13.Text = "School Code"
        '
        'txtexamyr
        '
        Me.txtexamyr.Location = New System.Drawing.Point(122, 16)
        Me.txtexamyr.Name = "txtexamyr"
        Me.txtexamyr.Size = New System.Drawing.Size(82, 25)
        Me.txtexamyr.TabIndex = 79
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(13, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 17)
        Me.Label11.TabIndex = 86
        Me.Label11.Text = "School Name"
        '
        'txtschcode
        '
        Me.txtschcode.Location = New System.Drawing.Point(105, 46)
        Me.txtschcode.Name = "txtschcode"
        Me.txtschcode.Size = New System.Drawing.Size(81, 22)
        Me.txtschcode.TabIndex = 85
        '
        'cmdretrieve
        '
        Me.cmdretrieve.AutoSize = True
        Me.cmdretrieve.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdretrieve.Location = New System.Drawing.Point(355, 519)
        Me.cmdretrieve.Name = "cmdretrieve"
        Me.cmdretrieve.Size = New System.Drawing.Size(138, 29)
        Me.cmdretrieve.TabIndex = 79
        Me.cmdretrieve.Text = "Retrieve Record"
        Me.cmdretrieve.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cboSchname)
        Me.GroupBox3.Controls.Add(Me.txtschcode)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.lblSchofCho)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox3.Location = New System.Drawing.Point(32, 297)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(507, 74)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Choice of School"
        '
        'cboSchname
        '
        Me.cboSchname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSchname.FormattingEnabled = True
        Me.cboSchname.Location = New System.Drawing.Point(105, 15)
        Me.cboSchname.Name = "cboSchname"
        Me.cboSchname.Size = New System.Drawing.Size(393, 23)
        Me.cboSchname.TabIndex = 87
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(459, 54)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 72)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Gold
        Me.Label14.Location = New System.Drawing.Point(411, 493)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(276, 15)
        Me.Label14.TabIndex = 80
        Me.Label14.Text = "Please Note that the Minimum No. of subjects is 7"
        '
        'FrmMod_gabEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(943, 553)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdretrieve)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CboGrp3)
        Me.Controls.Add(Me.CboGrp2)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtTot_Sub)
        Me.Controls.Add(Me.GrpGender)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdModify)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblwaec)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmMod_gabEntry"
        Me.Text = "GABECE Candidate Entry Mofidication"
        Me.GrpGender.ResumeLayout(False)
        Me.GrpGender.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblwaec As System.Windows.Forms.Label
    Friend WithEvents CmdModify As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OptMale As System.Windows.Forms.RadioButton
    Friend WithEvents OptFemale As System.Windows.Forms.RadioButton
    Friend WithEvents OptBMale As System.Windows.Forms.RadioButton
    Friend WithEvents OptBFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcandSurname As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CboCentCode As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GrpGender As System.Windows.Forms.GroupBox
    Friend WithEvents lblSchofCho As System.Windows.Forms.Label
    Friend WithEvents txtTot_Sub As System.Windows.Forms.TextBox
    Friend WithEvents ChkEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMaths As System.Windows.Forms.CheckBox
    Friend WithEvents ChkScience As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSES As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CboGrp2 As System.Windows.Forms.ComboBox
    Friend WithEvents CboGrp3 As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblExamYear As System.Windows.Forms.Label
    Friend WithEvents txtOtherName As System.Windows.Forms.TextBox
    Friend WithEvents LblOtherName As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtschcode As System.Windows.Forms.TextBox
    Friend WithEvents txtexamyr As System.Windows.Forms.TextBox
    Friend WithEvents cmdretrieve As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cboSchname As System.Windows.Forms.ComboBox
    Friend WithEvents txtsname As System.Windows.Forms.TextBox
    Friend WithEvents txtscode As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cbocanno As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label

End Class
