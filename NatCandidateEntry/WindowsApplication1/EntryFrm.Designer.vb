<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmgabEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmgabEntry))
        Me.lblwaec = New System.Windows.Forms.Label
        Me.CmdAdd = New System.Windows.Forms.Button
        Me.txtCanNo = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.OptMale = New System.Windows.Forms.RadioButton
        Me.OptFemale = New System.Windows.Forms.RadioButton
        Me.OptBMale = New System.Windows.Forms.RadioButton
        Me.OptBFemale = New System.Windows.Forms.RadioButton
        Me.OptHMale = New System.Windows.Forms.RadioButton
        Me.OptHFemale = New System.Windows.Forms.RadioButton
        Me.OptDMale = New System.Windows.Forms.RadioButton
        Me.OptDFemale = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.CmdExit = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtNoOfSubs = New System.Windows.Forms.TextBox
        Me.lblcandSurname = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.CmdClear = New System.Windows.Forms.Button
        Me.CboCentCode = New System.Windows.Forms.ComboBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GrpGender = New System.Windows.Forms.GroupBox
        Me.CboSchofChc = New System.Windows.Forms.ComboBox
        Me.lblSchofCho = New System.Windows.Forms.Label
        Me.ChkEnglish = New System.Windows.Forms.CheckBox
        Me.ChkMaths = New System.Windows.Forms.CheckBox
        Me.ChkScience = New System.Windows.Forms.CheckBox
        Me.ChkSES = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.ChkLBSub1 = New System.Windows.Forms.CheckedListBox
        Me.ChkLBSub2 = New System.Windows.Forms.CheckedListBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GrpGender.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblwaec
        '
        Me.lblwaec.AutoSize = True
        Me.lblwaec.BackColor = System.Drawing.Color.Navy
        Me.lblwaec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwaec.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaec.ForeColor = System.Drawing.Color.Yellow
        Me.lblwaec.Location = New System.Drawing.Point(178, 7)
        Me.lblwaec.Name = "lblwaec"
        Me.lblwaec.Size = New System.Drawing.Size(277, 21)
        Me.lblwaec.TabIndex = 0
        Me.lblwaec.Text = "The West African Examinations Council"
        '
        'CmdAdd
        '
        Me.CmdAdd.Enabled = False
        Me.CmdAdd.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdd.Location = New System.Drawing.Point(164, 509)
        Me.CmdAdd.Name = "CmdAdd"
        Me.CmdAdd.Size = New System.Drawing.Size(94, 25)
        Me.CmdAdd.TabIndex = 28
        Me.CmdAdd.Text = "Add"
        Me.CmdAdd.UseVisualStyleBackColor = True
        '
        'txtCanNo
        '
        Me.txtCanNo.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCanNo.Location = New System.Drawing.Point(522, 158)
        Me.txtCanNo.Name = "txtCanNo"
        Me.txtCanNo.Size = New System.Drawing.Size(93, 25)
        Me.txtCanNo.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Centre Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(343, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(173, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Candidate Index Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(400, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Candidate Name"
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(522, 189)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(166, 25)
        Me.txtFName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(53, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Date of Birth"
        '
        'OptMale
        '
        Me.OptMale.AutoSize = True
        Me.OptMale.Checked = True
        Me.OptMale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptMale.Location = New System.Drawing.Point(6, 19)
        Me.OptMale.Name = "OptMale"
        Me.OptMale.Size = New System.Drawing.Size(52, 19)
        Me.OptMale.TabIndex = 7
        Me.OptMale.TabStop = True
        Me.OptMale.Text = "Male"
        Me.OptMale.UseVisualStyleBackColor = True
        '
        'OptFemale
        '
        Me.OptFemale.AutoSize = True
        Me.OptFemale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptFemale.Location = New System.Drawing.Point(64, 19)
        Me.OptFemale.Name = "OptFemale"
        Me.OptFemale.Size = New System.Drawing.Size(64, 19)
        Me.OptFemale.TabIndex = 8
        Me.OptFemale.Text = "Female"
        Me.OptFemale.UseVisualStyleBackColor = True
        '
        'OptBMale
        '
        Me.OptBMale.AutoSize = True
        Me.OptBMale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptBMale.Location = New System.Drawing.Point(134, 19)
        Me.OptBMale.Name = "OptBMale"
        Me.OptBMale.Size = New System.Drawing.Size(85, 19)
        Me.OptBMale.TabIndex = 9
        Me.OptBMale.Text = "Blind Male"
        Me.OptBMale.UseVisualStyleBackColor = True
        '
        'OptBFemale
        '
        Me.OptBFemale.AutoSize = True
        Me.OptBFemale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptBFemale.Location = New System.Drawing.Point(230, 19)
        Me.OptBFemale.Name = "OptBFemale"
        Me.OptBFemale.Size = New System.Drawing.Size(97, 19)
        Me.OptBFemale.TabIndex = 10
        Me.OptBFemale.Text = "Blind Female"
        Me.OptBFemale.UseVisualStyleBackColor = True
        '
        'OptHMale
        '
        Me.OptHMale.AutoSize = True
        Me.OptHMale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptHMale.Location = New System.Drawing.Point(517, 19)
        Me.OptHMale.Name = "OptHMale"
        Me.OptHMale.Size = New System.Drawing.Size(104, 19)
        Me.OptHMale.TabIndex = 13
        Me.OptHMale.Text = "Phy. Hnd Male"
        Me.OptHMale.UseVisualStyleBackColor = True
        '
        'OptHFemale
        '
        Me.OptHFemale.AutoSize = True
        Me.OptHFemale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptHFemale.Location = New System.Drawing.Point(624, 19)
        Me.OptHFemale.Name = "OptHFemale"
        Me.OptHFemale.Size = New System.Drawing.Size(116, 19)
        Me.OptHFemale.TabIndex = 14
        Me.OptHFemale.Text = "Phy. Hnd Female"
        Me.OptHFemale.UseVisualStyleBackColor = True
        '
        'OptDMale
        '
        Me.OptDMale.AutoSize = True
        Me.OptDMale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDMale.Location = New System.Drawing.Point(333, 19)
        Me.OptDMale.Name = "OptDMale"
        Me.OptDMale.Size = New System.Drawing.Size(80, 19)
        Me.OptDMale.TabIndex = 11
        Me.OptDMale.Text = "Deaf Male"
        Me.OptDMale.UseVisualStyleBackColor = True
        '
        'OptDFemale
        '
        Me.OptDFemale.AutoSize = True
        Me.OptDFemale.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptDFemale.Location = New System.Drawing.Point(419, 19)
        Me.OptDFemale.Name = "OptDFemale"
        Me.OptDFemale.Size = New System.Drawing.Size(92, 19)
        Me.OptDFemale.TabIndex = 12
        Me.OptDFemale.Text = "Deaf Female"
        Me.OptDFemale.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Navy
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(129, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(368, 19)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "The Gambia Basic Education Examination Certificate "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Navy
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(227, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 19)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Candidate Entry Details"
        '
        'CmdExit
        '
        Me.CmdExit.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(403, 509)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(94, 25)
        Me.CmdExit.TabIndex = 31
        Me.CmdExit.Text = "Exit"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(60, 437)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "No. of Subjects"
        '
        'txtNoOfSubs
        '
        Me.txtNoOfSubs.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoOfSubs.Location = New System.Drawing.Point(545, 49)
        Me.txtNoOfSubs.Name = "txtNoOfSubs"
        Me.txtNoOfSubs.Size = New System.Drawing.Size(51, 26)
        Me.txtNoOfSubs.TabIndex = 17
        '
        'lblcandSurname
        '
        Me.lblcandSurname.AutoSize = True
        Me.lblcandSurname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcandSurname.Location = New System.Drawing.Point(53, 199)
        Me.lblcandSurname.Name = "lblcandSurname"
        Me.lblcandSurname.Size = New System.Drawing.Size(135, 17)
        Me.lblcandSurname.TabIndex = 28
        Me.lblcandSurname.Text = "Candidate Surname"
        '
        'txtLName
        '
        Me.txtLName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(194, 192)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(174, 25)
        Me.txtLName.TabIndex = 3
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(64, 468)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(59, 20)
        Me.TextBox1.TabIndex = 27
        '
        'CmdClear
        '
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.Location = New System.Drawing.Point(275, 509)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(94, 25)
        Me.CmdClear.TabIndex = 30
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'CboCentCode
        '
        Me.CboCentCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCentCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCentCode.FormattingEnabled = True
        Me.CboCentCode.Location = New System.Drawing.Point(194, 158)
        Me.CboCentCode.Name = "CboCentCode"
        Me.CboCentCode.Size = New System.Drawing.Size(99, 25)
        Me.CboCentCode.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/mmm/yy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(194, 230)
        Me.DateTimePicker1.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(113, 25)
        Me.DateTimePicker1.TabIndex = 5
        '
        'GrpGender
        '
        Me.GrpGender.Controls.Add(Me.txtNoOfSubs)
        Me.GrpGender.Controls.Add(Me.OptMale)
        Me.GrpGender.Controls.Add(Me.OptFemale)
        Me.GrpGender.Controls.Add(Me.OptBMale)
        Me.GrpGender.Controls.Add(Me.OptBFemale)
        Me.GrpGender.Controls.Add(Me.OptHFemale)
        Me.GrpGender.Controls.Add(Me.OptHMale)
        Me.GrpGender.Controls.Add(Me.OptDMale)
        Me.GrpGender.Controls.Add(Me.OptDFemale)
        Me.GrpGender.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GrpGender.Location = New System.Drawing.Point(42, 268)
        Me.GrpGender.Name = "GrpGender"
        Me.GrpGender.Size = New System.Drawing.Size(746, 46)
        Me.GrpGender.TabIndex = 36
        Me.GrpGender.TabStop = False
        Me.GrpGender.Text = "Gender"
        '
        'CboSchofChc
        '
        Me.CboSchofChc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSchofChc.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSchofChc.FormattingEnabled = True
        Me.CboSchofChc.Location = New System.Drawing.Point(522, 225)
        Me.CboSchofChc.Name = "CboSchofChc"
        Me.CboSchofChc.Size = New System.Drawing.Size(121, 25)
        Me.CboSchofChc.TabIndex = 6
        '
        'lblSchofCho
        '
        Me.lblSchofCho.AutoSize = True
        Me.lblSchofCho.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchofCho.Location = New System.Drawing.Point(399, 233)
        Me.lblSchofCho.Name = "lblSchofCho"
        Me.lblSchofCho.Size = New System.Drawing.Size(117, 17)
        Me.lblSchofCho.TabIndex = 43
        Me.lblSchofCho.Text = "School of Choice"
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
        Me.ChkSES.Size = New System.Drawing.Size(140, 21)
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
        Me.GroupBox1.Location = New System.Drawing.Point(40, 340)
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
        Me.label6.Location = New System.Drawing.Point(355, 329)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(193, 17)
        Me.label6.TabIndex = 64
        Me.label6.Text = "Optional(Select atleast One)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(556, 326)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(193, 17)
        Me.Label10.TabIndex = 65
        Me.Label10.Text = "Optional(Select atleast One)"
        '
        'ChkLBSub1
        '
        Me.ChkLBSub1.CheckOnClick = True
        Me.ChkLBSub1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLBSub1.FormattingEnabled = True
        Me.ChkLBSub1.Items.AddRange(New Object() {"211  -  Arabic", "212  -  French", "213  -  IRK", "214  -  CRE", "215  -  Agric_Sci", "216  -  Phy_Edu", "217  -  Lit_In_Eng"})
        Me.ChkLBSub1.Location = New System.Drawing.Point(387, 349)
        Me.ChkLBSub1.Name = "ChkLBSub1"
        Me.ChkLBSub1.Size = New System.Drawing.Size(166, 104)
        Me.ChkLBSub1.TabIndex = 66
        '
        'ChkLBSub2
        '
        Me.ChkLBSub2.CheckOnClick = True
        Me.ChkLBSub2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkLBSub2.FormattingEnabled = True
        Me.ChkLBSub2.Items.AddRange(New Object() {"311  -  Home_Eco", "312  -  Arts_Craft", "313  -  Tech_Drawing", "314  -  Metalwork", "315  -  Woodwork"})
        Me.ChkLBSub2.Location = New System.Drawing.Point(559, 349)
        Me.ChkLBSub2.Name = "ChkLBSub2"
        Me.ChkLBSub2.Size = New System.Drawing.Size(174, 104)
        Me.ChkLBSub2.TabIndex = 68
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(735, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(119, 148)
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(274, 29)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 57)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'FrmgabEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(896, 590)
        Me.Controls.Add(Me.ChkLBSub2)
        Me.Controls.Add(Me.ChkLBSub1)
        Me.Controls.Add(Me.label6)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSchofCho)
        Me.Controls.Add(Me.CboSchofChc)
        Me.Controls.Add(Me.GrpGender)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CboCentCode)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.CmdAdd)
        Me.Controls.Add(Me.txtLName)
        Me.Controls.Add(Me.lblcandSurname)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtFName)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCanNo)
        Me.Controls.Add(Me.lblwaec)
        Me.Name = "FrmgabEntry"
        Me.Text = "Candidate Entry Form"
        Me.GrpGender.ResumeLayout(False)
        Me.GrpGender.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblwaec As System.Windows.Forms.Label
    Friend WithEvents CmdAdd As System.Windows.Forms.Button
    Friend WithEvents txtCanNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OptMale As System.Windows.Forms.RadioButton
    Friend WithEvents OptFemale As System.Windows.Forms.RadioButton
    Friend WithEvents OptBMale As System.Windows.Forms.RadioButton
    Friend WithEvents OptBFemale As System.Windows.Forms.RadioButton
    Friend WithEvents OptHMale As System.Windows.Forms.RadioButton
    Friend WithEvents OptHFemale As System.Windows.Forms.RadioButton
    Friend WithEvents OptDMale As System.Windows.Forms.RadioButton
    Friend WithEvents OptDFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CmdExit As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtNoOfSubs As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcandSurname As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents CboCentCode As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GrpGender As System.Windows.Forms.GroupBox
    Friend WithEvents CboSchofChc As System.Windows.Forms.ComboBox
    Friend WithEvents lblSchofCho As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ChkEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents ChkMaths As System.Windows.Forms.CheckBox
    Friend WithEvents ChkScience As System.Windows.Forms.CheckBox
    Friend WithEvents ChkSES As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents ChkLBSub1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents ChkLBSub2 As System.Windows.Forms.CheckedListBox

End Class
