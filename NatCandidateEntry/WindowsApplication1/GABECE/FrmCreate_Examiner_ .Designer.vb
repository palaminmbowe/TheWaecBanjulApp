<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCreate_Examiner_
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCreate_Examiner_))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtexamyr = New System.Windows.Forms.TextBox
        Me.lblExamYear = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblExamSeries = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblwaec = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CboTitle = New System.Windows.Forms.ComboBox
        Me.CboStatus = New System.Windows.Forms.ComboBox
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.rdbMale = New System.Windows.Forms.RadioButton
        Me.rdbFemale = New System.Windows.Forms.RadioButton
        Me.Grpsec = New System.Windows.Forms.GroupBox
        Me.txtusername = New System.Windows.Forms.TextBox
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtconfpass = New System.Windows.Forms.TextBox
        Me.Label30 = New System.Windows.Forms.Label
        Me.txtpassword = New System.Windows.Forms.TextBox
        Me.Label29 = New System.Windows.Forms.Label
        Me.CboNational = New System.Windows.Forms.ComboBox
        Me.Label27 = New System.Windows.Forms.Label
        Me.txtexaminer_no = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.CboSubjCode = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.lblSubcode = New System.Windows.Forms.Label
        Me.txtoccup = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtmsubj = New System.Windows.Forms.TextBox
        Me.txtoname = New System.Windows.Forms.TextBox
        Me.txtfname = New System.Windows.Forms.TextBox
        Me.txtlname = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtqyr3 = New System.Windows.Forms.TextBox
        Me.txtqual3 = New System.Windows.Forms.TextBox
        Me.Label28 = New System.Windows.Forms.Label
        Me.txtqyr2 = New System.Windows.Forms.TextBox
        Me.txtqual2 = New System.Windows.Forms.TextBox
        Me.txtqyr1 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtqual1 = New System.Windows.Forms.TextBox
        Me.cmdsave = New System.Windows.Forms.Button
        Me.cmdclear = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.txtwtel_mob = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtrstreet = New System.Windows.Forms.TextBox
        Me.txtrlocal = New System.Windows.Forms.TextBox
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.txtrcity = New System.Windows.Forms.TextBox
        Me.txttel_off = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtwcity = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Grpsec.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtexamyr)
        Me.GroupBox1.Controls.Add(Me.lblExamYear)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblExamSeries)
        Me.GroupBox1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox1.Location = New System.Drawing.Point(24, 27)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(194, 69)
        Me.GroupBox1.TabIndex = 136
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam Details"
        '
        'txtexamyr
        '
        Me.txtexamyr.Location = New System.Drawing.Point(82, 16)
        Me.txtexamyr.Name = "txtexamyr"
        Me.txtexamyr.Size = New System.Drawing.Size(72, 22)
        Me.txtexamyr.TabIndex = 118
        '
        'lblExamYear
        '
        Me.lblExamYear.AutoSize = True
        Me.lblExamYear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamYear.ForeColor = System.Drawing.Color.Navy
        Me.lblExamYear.Location = New System.Drawing.Point(11, 19)
        Me.lblExamYear.Name = "lblExamYear"
        Me.lblExamYear.Size = New System.Drawing.Size(64, 15)
        Me.lblExamYear.TabIndex = 90
        Me.lblExamYear.Text = "Exam Year"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(108, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "GABECE"
        '
        'lblExamSeries
        '
        Me.lblExamSeries.AutoSize = True
        Me.lblExamSeries.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamSeries.ForeColor = System.Drawing.Color.Navy
        Me.lblExamSeries.Location = New System.Drawing.Point(10, 42)
        Me.lblExamSeries.Name = "lblExamSeries"
        Me.lblExamSeries.Size = New System.Drawing.Size(96, 19)
        Me.lblExamSeries.TabIndex = 89
        Me.lblExamSeries.Text = "Exam Name:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Navy
        Me.Label18.Location = New System.Drawing.Point(642, 52)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 19)
        Me.Label18.TabIndex = 135
        Me.Label18.Text = "Date:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(695, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(184, 26)
        Me.DateTimePicker1.TabIndex = 134
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(398, 31)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 72)
        Me.PictureBox1.TabIndex = 133
        Me.PictureBox1.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(380, 104)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 19)
        Me.Label8.TabIndex = 132
        Me.Label8.Text = "Examiner Details "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(227, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 19)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = " "
        '
        'lblwaec
        '
        Me.lblwaec.AutoSize = True
        Me.lblwaec.BackColor = System.Drawing.Color.Transparent
        Me.lblwaec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwaec.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaec.ForeColor = System.Drawing.Color.Yellow
        Me.lblwaec.Location = New System.Drawing.Point(266, 9)
        Me.lblwaec.Name = "lblwaec"
        Me.lblwaec.Size = New System.Drawing.Size(371, 21)
        Me.lblwaec.TabIndex = 130
        Me.lblwaec.Text = "The West African Examinations Council, Banjul Office"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CboTitle)
        Me.GroupBox2.Controls.Add(Me.CboStatus)
        Me.GroupBox2.Controls.Add(Me.GroupBox5)
        Me.GroupBox2.Controls.Add(Me.Grpsec)
        Me.GroupBox2.Controls.Add(Me.CboNational)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.txtexaminer_no)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.CboSubjCode)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblSubcode)
        Me.GroupBox2.Controls.Add(Me.txtoccup)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtmsubj)
        Me.GroupBox2.Controls.Add(Me.txtoname)
        Me.GroupBox2.Controls.Add(Me.txtfname)
        Me.GroupBox2.Controls.Add(Me.txtlname)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox2.Location = New System.Drawing.Point(24, 126)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(841, 166)
        Me.GroupBox2.TabIndex = 137
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Examiner Details"
        '
        'CboTitle
        '
        Me.CboTitle.FormattingEnabled = True
        Me.CboTitle.Items.AddRange(New Object() {"MR.", "MRS.", "MISS."})
        Me.CboTitle.Location = New System.Drawing.Point(55, 20)
        Me.CboTitle.Name = "CboTitle"
        Me.CboTitle.Size = New System.Drawing.Size(60, 23)
        Me.CboTitle.TabIndex = 1
        '
        'CboStatus
        '
        Me.CboStatus.FormattingEnabled = True
        Me.CboStatus.Location = New System.Drawing.Point(179, 17)
        Me.CboStatus.Name = "CboStatus"
        Me.CboStatus.Size = New System.Drawing.Size(187, 23)
        Me.CboStatus.TabIndex = 2
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdbMale)
        Me.GroupBox5.Controls.Add(Me.rdbFemale)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox5.Location = New System.Drawing.Point(755, 45)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(80, 64)
        Me.GroupBox5.TabIndex = 11
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Gender"
        '
        'rdbMale
        '
        Me.rdbMale.AutoSize = True
        Me.rdbMale.Location = New System.Drawing.Point(10, 17)
        Me.rdbMale.Name = "rdbMale"
        Me.rdbMale.Size = New System.Drawing.Size(52, 19)
        Me.rdbMale.TabIndex = 11
        Me.rdbMale.TabStop = True
        Me.rdbMale.Text = "Male"
        Me.rdbMale.UseVisualStyleBackColor = True
        '
        'rdbFemale
        '
        Me.rdbFemale.AutoSize = True
        Me.rdbFemale.Location = New System.Drawing.Point(10, 35)
        Me.rdbFemale.Name = "rdbFemale"
        Me.rdbFemale.Size = New System.Drawing.Size(64, 19)
        Me.rdbFemale.TabIndex = 12
        Me.rdbFemale.TabStop = True
        Me.rdbFemale.Text = "Female"
        Me.rdbFemale.UseVisualStyleBackColor = True
        '
        'Grpsec
        '
        Me.Grpsec.Controls.Add(Me.txtusername)
        Me.Grpsec.Controls.Add(Me.Label31)
        Me.Grpsec.Controls.Add(Me.txtconfpass)
        Me.Grpsec.Controls.Add(Me.Label30)
        Me.Grpsec.Controls.Add(Me.txtpassword)
        Me.Grpsec.Controls.Add(Me.Label29)
        Me.Grpsec.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grpsec.ForeColor = System.Drawing.Color.Navy
        Me.Grpsec.Location = New System.Drawing.Point(7, 109)
        Me.Grpsec.Name = "Grpsec"
        Me.Grpsec.Size = New System.Drawing.Size(484, 47)
        Me.Grpsec.TabIndex = 139
        Me.Grpsec.TabStop = False
        Me.Grpsec.Text = "Security Details"
        '
        'txtusername
        '
        Me.txtusername.Location = New System.Drawing.Point(85, 19)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(75, 20)
        Me.txtusername.TabIndex = 13
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(7, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(77, 19)
        Me.Label31.TabIndex = 174
        Me.Label31.Text = "Username"
        '
        'txtconfpass
        '
        Me.txtconfpass.Location = New System.Drawing.Point(427, 18)
        Me.txtconfpass.Name = "txtconfpass"
        Me.txtconfpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtconfpass.Size = New System.Drawing.Size(51, 20)
        Me.txtconfpass.TabIndex = 15
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(296, 19)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(135, 19)
        Me.Label30.TabIndex = 172
        Me.Label30.Text = "Confirm Password:"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(238, 18)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(52, 20)
        Me.txtpassword.TabIndex = 14
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(166, 19)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(77, 19)
        Me.Label29.TabIndex = 170
        Me.Label29.Text = "Password:"
        '
        'CboNational
        '
        Me.CboNational.FormattingEnabled = True
        Me.CboNational.Items.AddRange(New Object() {"GAMBIAN", "NIGERIAN", "GHANIAN", "SIERRA LEONIAN", "LIBERIAN", "CAMERONIAN", "SENEGALISE"})
        Me.CboNational.Location = New System.Drawing.Point(95, 81)
        Me.CboNational.Name = "CboNational"
        Me.CboNational.Size = New System.Drawing.Size(121, 23)
        Me.CboNational.TabIndex = 8
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Navy
        Me.Label27.Location = New System.Drawing.Point(9, 21)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(45, 19)
        Me.Label27.TabIndex = 169
        Me.Label27.Text = "Title:"
        '
        'txtexaminer_no
        '
        Me.txtexaminer_no.Location = New System.Drawing.Point(653, 17)
        Me.txtexaminer_no.Name = "txtexaminer_no"
        Me.txtexaminer_no.Size = New System.Drawing.Size(98, 22)
        Me.txtexaminer_no.TabIndex = 4
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Navy
        Me.Label14.Location = New System.Drawing.Point(551, 23)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 19)
        Me.Label14.TabIndex = 168
        Me.Label14.Text = "Examiner No.:"
        '
        'CboSubjCode
        '
        Me.CboSubjCode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSubjCode.FormattingEnabled = True
        Me.CboSubjCode.Location = New System.Drawing.Point(468, 14)
        Me.CboSubjCode.Name = "CboSubjCode"
        Me.CboSubjCode.Size = New System.Drawing.Size(83, 27)
        Me.CboSubjCode.TabIndex = 3
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Navy
        Me.Label15.Location = New System.Drawing.Point(128, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 19)
        Me.Label15.TabIndex = 165
        Me.Label15.Text = "Status:"
        '
        'lblSubcode
        '
        Me.lblSubcode.AutoSize = True
        Me.lblSubcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubcode.ForeColor = System.Drawing.Color.Navy
        Me.lblSubcode.Location = New System.Drawing.Point(372, 23)
        Me.lblSubcode.Name = "lblSubcode"
        Me.lblSubcode.Size = New System.Drawing.Size(102, 19)
        Me.lblSubcode.TabIndex = 164
        Me.lblSubcode.Text = "Subject Code:"
        '
        'txtoccup
        '
        Me.txtoccup.Location = New System.Drawing.Point(359, 80)
        Me.txtoccup.Name = "txtoccup"
        Me.txtoccup.Size = New System.Drawing.Size(116, 22)
        Me.txtoccup.TabIndex = 9
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Navy
        Me.Label12.Location = New System.Drawing.Point(215, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(144, 19)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "Present Occupation:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Navy
        Me.Label9.Location = New System.Drawing.Point(476, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 19)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Major Subject:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtmsubj
        '
        Me.txtmsubj.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmsubj.Location = New System.Drawing.Point(591, 84)
        Me.txtmsubj.Name = "txtmsubj"
        Me.txtmsubj.Size = New System.Drawing.Size(138, 22)
        Me.txtmsubj.TabIndex = 10
        '
        'txtoname
        '
        Me.txtoname.Location = New System.Drawing.Point(591, 53)
        Me.txtoname.Name = "txtoname"
        Me.txtoname.Size = New System.Drawing.Size(138, 22)
        Me.txtoname.TabIndex = 7
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(334, 50)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(151, 22)
        Me.txtfname.TabIndex = 6
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(95, 50)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(151, 22)
        Me.txtlname.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Navy
        Me.Label1.Location = New System.Drawing.Point(10, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 19)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Nationality:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(10, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Last Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(484, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 19)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Other Names:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(245, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "First Name:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txtqyr3)
        Me.GroupBox3.Controls.Add(Me.txtqual3)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtqyr2)
        Me.GroupBox3.Controls.Add(Me.txtqual2)
        Me.GroupBox3.Controls.Add(Me.txtqyr1)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.txtqual1)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox3.Location = New System.Drawing.Point(24, 417)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(860, 109)
        Me.GroupBox3.TabIndex = 150
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Academic Qualifications And Marking Experience"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(5, 21)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 17)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Qualifications"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Navy
        Me.Label19.Location = New System.Drawing.Point(683, 75)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 15)
        Me.Label19.TabIndex = 164
        Me.Label19.Text = "Year Obtained:"
        '
        'txtqyr3
        '
        Me.txtqyr3.Location = New System.Drawing.Point(778, 69)
        Me.txtqyr3.Name = "txtqyr3"
        Me.txtqyr3.Size = New System.Drawing.Size(63, 22)
        Me.txtqyr3.TabIndex = 29
        '
        'txtqual3
        '
        Me.txtqual3.Location = New System.Drawing.Point(100, 72)
        Me.txtqual3.Name = "txtqual3"
        Me.txtqual3.Size = New System.Drawing.Size(577, 22)
        Me.txtqual3.TabIndex = 28
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Navy
        Me.Label28.Location = New System.Drawing.Point(683, 47)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 15)
        Me.Label28.TabIndex = 161
        Me.Label28.Text = "Year Obtained:"
        '
        'txtqyr2
        '
        Me.txtqyr2.Location = New System.Drawing.Point(778, 41)
        Me.txtqyr2.Name = "txtqyr2"
        Me.txtqyr2.Size = New System.Drawing.Size(63, 22)
        Me.txtqyr2.TabIndex = 27
        '
        'txtqual2
        '
        Me.txtqual2.Location = New System.Drawing.Point(100, 44)
        Me.txtqual2.Name = "txtqual2"
        Me.txtqual2.Size = New System.Drawing.Size(577, 22)
        Me.txtqual2.TabIndex = 26
        '
        'txtqyr1
        '
        Me.txtqyr1.Location = New System.Drawing.Point(778, 16)
        Me.txtqyr1.Name = "txtqyr1"
        Me.txtqyr1.Size = New System.Drawing.Size(63, 22)
        Me.txtqyr1.TabIndex = 25
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Navy
        Me.Label20.Location = New System.Drawing.Point(683, 23)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 15)
        Me.Label20.TabIndex = 156
        Me.Label20.Text = "Year Obtained:"
        '
        'txtqual1
        '
        Me.txtqual1.Location = New System.Drawing.Point(100, 16)
        Me.txtqual1.Name = "txtqual1"
        Me.txtqual1.Size = New System.Drawing.Size(577, 22)
        Me.txtqual1.TabIndex = 24
        '
        'cmdsave
        '
        Me.cmdsave.Location = New System.Drawing.Point(260, 532)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(75, 24)
        Me.cmdsave.TabIndex = 32
        Me.cmdsave.Text = "SAVE"
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'cmdclear
        '
        Me.cmdclear.Location = New System.Drawing.Point(341, 532)
        Me.cmdclear.Name = "cmdclear"
        Me.cmdclear.Size = New System.Drawing.Size(96, 24)
        Me.cmdclear.TabIndex = 34
        Me.cmdclear.Text = "CLEAR"
        Me.cmdclear.UseVisualStyleBackColor = True
        '
        'cmdexit
        '
        Me.cmdexit.Location = New System.Drawing.Point(440, 532)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(95, 24)
        Me.cmdexit.TabIndex = 35
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtwtel_mob)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.txtrstreet)
        Me.GroupBox4.Controls.Add(Me.txtrlocal)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.txtrcity)
        Me.GroupBox4.Controls.Add(Me.txttel_off)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtwcity)
        Me.GroupBox4.Controls.Add(Me.Label13)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Navy
        Me.GroupBox4.Location = New System.Drawing.Point(24, 298)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(860, 113)
        Me.GroupBox4.TabIndex = 140
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Contact Details"
        '
        'txtwtel_mob
        '
        Me.txtwtel_mob.Location = New System.Drawing.Point(684, 33)
        Me.txtwtel_mob.Name = "txtwtel_mob"
        Me.txtwtel_mob.Size = New System.Drawing.Size(170, 22)
        Me.txtwtel_mob.TabIndex = 18
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Navy
        Me.Label17.Location = New System.Drawing.Point(624, 36)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 19)
        Me.Label17.TabIndex = 207
        Me.Label17.Text = "Mobile:"
        '
        'txtrstreet
        '
        Me.txtrstreet.Location = New System.Drawing.Point(410, 74)
        Me.txtrstreet.Name = "txtrstreet"
        Me.txtrstreet.Size = New System.Drawing.Size(130, 22)
        Me.txtrstreet.TabIndex = 20
        '
        'txtrlocal
        '
        Me.txtrlocal.Location = New System.Drawing.Point(620, 74)
        Me.txtrlocal.Name = "txtrlocal"
        Me.txtrlocal.Size = New System.Drawing.Size(215, 22)
        Me.txtrlocal.TabIndex = 22
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Navy
        Me.Label24.Location = New System.Drawing.Point(305, 77)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(99, 19)
        Me.Label24.TabIndex = 200
        Me.Label24.Text = "Street Name:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.Color.Navy
        Me.Label25.Location = New System.Drawing.Point(546, 77)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(68, 19)
        Me.Label25.TabIndex = 199
        Me.Label25.Text = "Locality:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Navy
        Me.Label26.Location = New System.Drawing.Point(12, 77)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 19)
        Me.Label26.TabIndex = 198
        Me.Label26.Text = "City/Town:"
        '
        'txtrcity
        '
        Me.txtrcity.Location = New System.Drawing.Point(92, 74)
        Me.txtrcity.Name = "txtrcity"
        Me.txtrcity.Size = New System.Drawing.Size(205, 22)
        Me.txtrcity.TabIndex = 19
        '
        'txttel_off
        '
        Me.txttel_off.Location = New System.Drawing.Point(430, 33)
        Me.txttel_off.Name = "txttel_off"
        Me.txttel_off.Size = New System.Drawing.Size(188, 22)
        Me.txttel_off.TabIndex = 17
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Navy
        Me.Label21.Location = New System.Drawing.Point(303, 36)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(112, 19)
        Me.Label21.TabIndex = 195
        Me.Label21.Text = "Office Tel. No.:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Navy
        Me.Label16.Location = New System.Drawing.Point(9, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(81, 19)
        Me.Label16.TabIndex = 194
        Me.Label16.Text = "City/Town:"
        '
        'txtwcity
        '
        Me.txtwcity.Location = New System.Drawing.Point(92, 36)
        Me.txtwcity.Name = "txtwcity"
        Me.txtwcity.Size = New System.Drawing.Size(205, 22)
        Me.txtwcity.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(11, 61)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 15)
        Me.Label13.TabIndex = 192
        Me.Label13.Text = "Residencial Address"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Navy
        Me.Label11.Location = New System.Drawing.Point(11, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 15)
        Me.Label11.TabIndex = 191
        Me.Label11.Text = "Work Address:"
        '
        'FrmCreate_Examiner_
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ClientSize = New System.Drawing.Size(891, 561)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.cmdclear)
        Me.Controls.Add(Me.cmdsave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblwaec)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCreate_Examiner_"
        Me.Text = "Create Examiner"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Grpsec.ResumeLayout(False)
        Me.Grpsec.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExamYear As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblExamSeries As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblwaec As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdclear As System.Windows.Forms.Button
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtqual1 As System.Windows.Forms.TextBox
    Friend WithEvents txtmsubj As System.Windows.Forms.TextBox
    Friend WithEvents txtoname As System.Windows.Forms.TextBox
    Friend WithEvents txtoccup As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CboSubjCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents lblSubcode As System.Windows.Forms.Label
    Friend WithEvents txtexaminer_no As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtqyr1 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtqyr2 As System.Windows.Forms.TextBox
    Friend WithEvents txtqual2 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtwtel_mob As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtrstreet As System.Windows.Forms.TextBox
    Friend WithEvents txtrlocal As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtrcity As System.Windows.Forms.TextBox
    Friend WithEvents txttel_off As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtwcity As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtqyr3 As System.Windows.Forms.TextBox
    Friend WithEvents txtqual3 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtconfpass As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Grpsec As System.Windows.Forms.GroupBox
    Friend WithEvents CboNational As System.Windows.Forms.ComboBox
    Friend WithEvents txtusername As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtexamyr As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rdbFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMale As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CboStatus As System.Windows.Forms.ComboBox
    Friend WithEvents CboTitle As System.Windows.Forms.ComboBox
End Class
