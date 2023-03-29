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
        Me.txtExamYear = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtTadExaminerNo = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.cmbTitle = New System.Windows.Forms.ComboBox()
        Me.CmbGender = New System.Windows.Forms.ComboBox()
        Me.cmbNational = New System.Windows.Forms.ComboBox()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CboSubjCode = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lblSubcode = New System.Windows.Forms.Label()
        Me.txtoccup = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtmsubj = New System.Windows.Forms.TextBox()
        Me.txtoname = New System.Windows.Forms.TextBox()
        Me.txtfname = New System.Windows.Forms.TextBox()
        Me.txtlname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtexaminer_no = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtqyr3 = New System.Windows.Forms.TextBox()
        Me.txtqual3 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtqyr2 = New System.Windows.Forms.TextBox()
        Me.txtqual2 = New System.Windows.Forms.TextBox()
        Me.txtqyr1 = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtqual1 = New System.Windows.Forms.TextBox()
        Me.cmdexit = New System.Windows.Forms.Button()
        Me.cmdmodify = New System.Windows.Forms.Button()
        Me.cmdsave = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtwtel_mob = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txtrtel_home = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txttel_off = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtwcity = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtCPassword = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtExamYear
        '
        Me.txtExamYear.BackColor = System.Drawing.Color.DarkCyan
        Me.txtExamYear.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExamYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExamYear.ForeColor = System.Drawing.Color.White
        Me.txtExamYear.Location = New System.Drawing.Point(438, 8)
        Me.txtExamYear.Name = "txtExamYear"
        Me.txtExamYear.Size = New System.Drawing.Size(139, 31)
        Me.txtExamYear.TabIndex = 169
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(298, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 31)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "GABECE"
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTadExaminerNo)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.cmbTitle)
        Me.GroupBox2.Controls.Add(Me.CmbGender)
        Me.GroupBox2.Controls.Add(Me.cmbNational)
        Me.GroupBox2.Controls.Add(Me.cmbStatus)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.CboSubjCode)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.lblSubcode)
        Me.GroupBox2.Controls.Add(Me.txtoccup)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label6)
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
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(3, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(998, 154)
        Me.GroupBox2.TabIndex = 137
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Examiner Details"
        '
        'txtTadExaminerNo
        '
        Me.txtTadExaminerNo.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTadExaminerNo.Location = New System.Drawing.Point(694, 101)
        Me.txtTadExaminerNo.Name = "txtTadExaminerNo"
        Me.txtTadExaminerNo.Size = New System.Drawing.Size(298, 32)
        Me.txtTadExaminerNo.TabIndex = 173
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label31.Location = New System.Drawing.Point(53, 21)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(37, 15)
        Me.Label31.TabIndex = 171
        Me.Label31.Text = "Title:"
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbTitle
        '
        Me.cmbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbTitle.FormattingEnabled = True
        Me.cmbTitle.Location = New System.Drawing.Point(94, 17)
        Me.cmbTitle.Name = "cmbTitle"
        Me.cmbTitle.Size = New System.Drawing.Size(70, 23)
        Me.cmbTitle.TabIndex = 170
        '
        'CmbGender
        '
        Me.CmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbGender.FormattingEnabled = True
        Me.CmbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.CmbGender.Location = New System.Drawing.Point(428, 17)
        Me.CmbGender.Name = "CmbGender"
        Me.CmbGender.Size = New System.Drawing.Size(136, 23)
        Me.CmbGender.TabIndex = 3
        '
        'cmbNational
        '
        Me.cmbNational.FormattingEnabled = True
        Me.cmbNational.Location = New System.Drawing.Point(428, 47)
        Me.cmbNational.Name = "cmbNational"
        Me.cmbNational.Size = New System.Drawing.Size(136, 23)
        Me.cmbNational.TabIndex = 4
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(693, 17)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(299, 32)
        Me.cmbStatus.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label14.Location = New System.Drawing.Point(578, 108)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(109, 15)
        Me.Label14.TabIndex = 168
        Me.Label14.Text = "TAD Examiner No:"
        '
        'CboSubjCode
        '
        Me.CboSubjCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboSubjCode.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboSubjCode.FormattingEnabled = True
        Me.CboSubjCode.Location = New System.Drawing.Point(693, 58)
        Me.CboSubjCode.Name = "CboSubjCode"
        Me.CboSubjCode.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CboSubjCode.Size = New System.Drawing.Size(299, 32)
        Me.CboSubjCode.TabIndex = 8
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label15.Location = New System.Drawing.Point(642, 26)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 15)
        Me.Label15.TabIndex = 165
        Me.Label15.Text = "Status:"
        '
        'lblSubcode
        '
        Me.lblSubcode.AutoSize = True
        Me.lblSubcode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubcode.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblSubcode.Location = New System.Drawing.Point(606, 67)
        Me.lblSubcode.Name = "lblSubcode"
        Me.lblSubcode.Size = New System.Drawing.Size(82, 15)
        Me.lblSubcode.TabIndex = 164
        Me.lblSubcode.Text = "Subject Code:"
        '
        'txtoccup
        '
        Me.txtoccup.Location = New System.Drawing.Point(428, 77)
        Me.txtoccup.Name = "txtoccup"
        Me.txtoccup.Size = New System.Drawing.Size(136, 22)
        Me.txtoccup.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label12.Location = New System.Drawing.Point(302, 81)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(119, 15)
        Me.Label12.TabIndex = 156
        Me.Label12.Text = "Present Occupation:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label6.Location = New System.Drawing.Point(373, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 15)
        Me.Label6.TabIndex = 153
        Me.Label6.Text = "Gender:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label9.Location = New System.Drawing.Point(327, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 15)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Major Subjects:"
        '
        'txtmsubj
        '
        Me.txtmsubj.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmsubj.Location = New System.Drawing.Point(428, 107)
        Me.txtmsubj.Name = "txtmsubj"
        Me.txtmsubj.Size = New System.Drawing.Size(136, 22)
        Me.txtmsubj.TabIndex = 6
        '
        'txtoname
        '
        Me.txtoname.Location = New System.Drawing.Point(94, 107)
        Me.txtoname.Name = "txtoname"
        Me.txtoname.Size = New System.Drawing.Size(159, 22)
        Me.txtoname.TabIndex = 2
        '
        'txtfname
        '
        Me.txtfname.Location = New System.Drawing.Point(94, 77)
        Me.txtfname.Name = "txtfname"
        Me.txtfname.Size = New System.Drawing.Size(159, 22)
        Me.txtfname.TabIndex = 1
        '
        'txtlname
        '
        Me.txtlname.Location = New System.Drawing.Point(94, 47)
        Me.txtlname.Name = "txtlname"
        Me.txtlname.Size = New System.Drawing.Size(159, 22)
        Me.txtlname.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label1.Location = New System.Drawing.Point(350, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 15)
        Me.Label1.TabIndex = 142
        Me.Label1.Text = "Nationality:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label2.Location = New System.Drawing.Point(21, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 143
        Me.Label2.Text = "Last Name:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label3.Location = New System.Drawing.Point(6, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 15)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Other Names:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label4.Location = New System.Drawing.Point(18, 81)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 15)
        Me.Label4.TabIndex = 145
        Me.Label4.Text = "First Name:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtexaminer_no
        '
        Me.txtexaminer_no.Font = New System.Drawing.Font("Times New Roman", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexaminer_no.Location = New System.Drawing.Point(143, 123)
        Me.txtexaminer_no.Name = "txtexaminer_no"
        Me.txtexaminer_no.ReadOnly = True
        Me.txtexaminer_no.Size = New System.Drawing.Size(237, 20)
        Me.txtexaminer_no.TabIndex = 99
        Me.txtexaminer_no.TabStop = False
        '
        'GroupBox3
        '
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
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox3.Location = New System.Drawing.Point(401, 205)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(600, 135)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Academic Qualifications"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label19.Location = New System.Drawing.Point(378, 107)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(88, 15)
        Me.Label19.TabIndex = 164
        Me.Label19.Text = "Year Obtained:"
        '
        'txtqyr3
        '
        Me.txtqyr3.Location = New System.Drawing.Point(473, 103)
        Me.txtqyr3.Name = "txtqyr3"
        Me.txtqyr3.Size = New System.Drawing.Size(104, 22)
        Me.txtqyr3.TabIndex = 18
        '
        'txtqual3
        '
        Me.txtqual3.Location = New System.Drawing.Point(19, 103)
        Me.txtqual3.Name = "txtqual3"
        Me.txtqual3.Size = New System.Drawing.Size(317, 22)
        Me.txtqual3.TabIndex = 17
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label28.Location = New System.Drawing.Point(378, 66)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(88, 15)
        Me.Label28.TabIndex = 161
        Me.Label28.Text = "Year Obtained:"
        '
        'txtqyr2
        '
        Me.txtqyr2.Location = New System.Drawing.Point(473, 62)
        Me.txtqyr2.Name = "txtqyr2"
        Me.txtqyr2.Size = New System.Drawing.Size(104, 22)
        Me.txtqyr2.TabIndex = 16
        '
        'txtqual2
        '
        Me.txtqual2.Location = New System.Drawing.Point(19, 62)
        Me.txtqual2.Name = "txtqual2"
        Me.txtqual2.Size = New System.Drawing.Size(317, 22)
        Me.txtqual2.TabIndex = 15
        '
        'txtqyr1
        '
        Me.txtqyr1.Location = New System.Drawing.Point(473, 21)
        Me.txtqyr1.Name = "txtqyr1"
        Me.txtqyr1.Size = New System.Drawing.Size(104, 22)
        Me.txtqyr1.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label20.Location = New System.Drawing.Point(378, 25)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(88, 15)
        Me.Label20.TabIndex = 156
        Me.Label20.Text = "Year Obtained:"
        '
        'txtqual1
        '
        Me.txtqual1.Location = New System.Drawing.Point(19, 21)
        Me.txtqual1.Name = "txtqual1"
        Me.txtqual1.Size = New System.Drawing.Size(317, 22)
        Me.txtqual1.TabIndex = 13
        '
        'cmdexit
        '
        Me.cmdexit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.ForeColor = System.Drawing.Color.Black
        Me.cmdexit.Location = New System.Drawing.Point(799, 18)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(190, 120)
        Me.cmdexit.TabIndex = 24
        Me.cmdexit.Text = "EXIT"
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'cmdmodify
        '
        Me.cmdmodify.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdmodify.ForeColor = System.Drawing.Color.Black
        Me.cmdmodify.Location = New System.Drawing.Point(594, 18)
        Me.cmdmodify.Name = "cmdmodify"
        Me.cmdmodify.Size = New System.Drawing.Size(190, 120)
        Me.cmdmodify.TabIndex = 23
        Me.cmdmodify.Text = "MODIFY"
        Me.cmdmodify.UseVisualStyleBackColor = True
        '
        'cmdsave
        '
        Me.cmdsave.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsave.ForeColor = System.Drawing.Color.Black
        Me.cmdsave.Location = New System.Drawing.Point(389, 18)
        Me.cmdsave.Name = "cmdsave"
        Me.cmdsave.Size = New System.Drawing.Size(190, 120)
        Me.cmdsave.TabIndex = 22
        Me.cmdsave.Text = "ADD EXAMINER "
        Me.cmdsave.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtwtel_mob)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.TextBox1)
        Me.GroupBox4.Controls.Add(Me.txtrtel_home)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.txttel_off)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label16)
        Me.GroupBox4.Controls.Add(Me.txtwcity)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox4.Location = New System.Drawing.Point(3, 205)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(380, 135)
        Me.GroupBox4.TabIndex = 170
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Contact Details"
        '
        'txtwtel_mob
        '
        Me.txtwtel_mob.Location = New System.Drawing.Point(112, 108)
        Me.txtwtel_mob.Name = "txtwtel_mob"
        Me.txtwtel_mob.Size = New System.Drawing.Size(98, 22)
        Me.txtwtel_mob.TabIndex = 11
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label17.Location = New System.Drawing.Point(19, 111)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(60, 15)
        Me.Label17.TabIndex = 207
        Me.Label17.Text = "MOBILE:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(295, 94)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(78, 22)
        Me.TextBox1.TabIndex = 12
        '
        'txtrtel_home
        '
        Me.txtrtel_home.Location = New System.Drawing.Point(740, 83)
        Me.txtrtel_home.Name = "txtrtel_home"
        Me.txtrtel_home.Size = New System.Drawing.Size(181, 22)
        Me.txtrtel_home.TabIndex = 17
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label22.Location = New System.Drawing.Point(216, 99)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 15)
        Me.Label22.TabIndex = 202
        Me.Label22.Text = "HOME TEL:"
        '
        'txttel_off
        '
        Me.txttel_off.Location = New System.Drawing.Point(112, 80)
        Me.txttel_off.Name = "txttel_off"
        Me.txttel_off.Size = New System.Drawing.Size(98, 22)
        Me.txttel_off.TabIndex = 10
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label21.Location = New System.Drawing.Point(1, 83)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 15)
        Me.Label21.TabIndex = 195
        Me.Label21.Text = "OFFICE TEL. NO.:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.Label16.Location = New System.Drawing.Point(18, 36)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 15)
        Me.Label16.TabIndex = 194
        Me.Label16.Text = "CITY/TOWN"
        '
        'txtwcity
        '
        Me.txtwcity.Location = New System.Drawing.Point(112, 33)
        Me.txtwcity.Multiline = True
        Me.txtwcity.Name = "txtwcity"
        Me.txtwcity.Size = New System.Drawing.Size(261, 37)
        Me.txtwcity.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(113, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(211, 15)
        Me.Label11.TabIndex = 191
        Me.Label11.Text = "Work Addres or Residential Address:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtUserName)
        Me.GroupBox5.Controls.Add(Me.cmdexit)
        Me.GroupBox5.Controls.Add(Me.Label30)
        Me.GroupBox5.Controls.Add(Me.txtCPassword)
        Me.GroupBox5.Controls.Add(Me.cmdmodify)
        Me.GroupBox5.Controls.Add(Me.txtexaminer_no)
        Me.GroupBox5.Controls.Add(Me.Label27)
        Me.GroupBox5.Controls.Add(Me.txtPassword)
        Me.GroupBox5.Controls.Add(Me.cmdsave)
        Me.GroupBox5.Controls.Add(Me.Label37)
        Me.GroupBox5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox5.Location = New System.Drawing.Point(3, 346)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(998, 153)
        Me.GroupBox5.TabIndex = 208
        Me.GroupBox5.TabStop = False
        '
        'txtUserName
        '
        Me.txtUserName.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(143, 18)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(237, 32)
        Me.txtUserName.TabIndex = 19
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.White
        Me.Label30.Location = New System.Drawing.Point(30, 27)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(97, 15)
        Me.Label30.TabIndex = 197
        Me.Label30.Text = "Enter UserName"
        '
        'txtCPassword
        '
        Me.txtCPassword.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCPassword.Location = New System.Drawing.Point(143, 86)
        Me.txtCPassword.Name = "txtCPassword"
        Me.txtCPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtCPassword.Size = New System.Drawing.Size(237, 32)
        Me.txtCPassword.TabIndex = 21
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.White
        Me.Label27.Location = New System.Drawing.Point(16, 95)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(111, 15)
        Me.Label27.TabIndex = 193
        Me.Label27.Text = "Confirm  Password"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Times New Roman", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(143, 52)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(237, 32)
        Me.txtPassword.TabIndex = 20
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.White
        Me.Label37.Location = New System.Drawing.Point(35, 61)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(92, 15)
        Me.Label37.TabIndex = 191
        Me.Label37.Text = "Enter Password"
        '
        'scMain
        '
        Me.scMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.scMain.IsSplitterFixed = True
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Name = "scMain"
        Me.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.Controls.Add(Me.Label18)
        Me.scMain.Panel1.Controls.Add(Me.Label13)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.txtExamYear)
        Me.scMain.Panel2.Controls.Add(Me.GroupBox5)
        Me.scMain.Panel2.Controls.Add(Me.GroupBox2)
        Me.scMain.Panel2.Controls.Add(Me.Label5)
        Me.scMain.Panel2.Controls.Add(Me.GroupBox4)
        Me.scMain.Panel2.Controls.Add(Me.GroupBox3)
        Me.scMain.Size = New System.Drawing.Size(1015, 607)
        Me.scMain.SplitterDistance = 91
        Me.scMain.TabIndex = 209
        '
        'Label18
        '
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(534, 7)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(467, 80)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Register New" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Examiner"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label13.Image = CType(resources.GetObject("Label13.Image"), System.Drawing.Image)
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(1011, 87)
        Me.Label13.TabIndex = 0
        '
        'FrmCreate_Examiner_
        '
        Me.AcceptButton = Me.cmdsave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.CancelButton = Me.cmdexit
        Me.ClientSize = New System.Drawing.Size(1015, 607)
        Me.Controls.Add(Me.scMain)
        Me.Controls.Add(Me.Label7)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmCreate_Examiner_"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CREATE EXAMINER "
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        Me.scMain.Panel2.PerformLayout()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdsave As System.Windows.Forms.Button
    Friend WithEvents cmdmodify As System.Windows.Forms.Button
    Friend WithEvents txtlname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents txtfname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
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
    Friend WithEvents txtrtel_home As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txttel_off As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtwcity As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtqyr3 As System.Windows.Forms.TextBox
    Friend WithEvents txtqual3 As System.Windows.Forms.TextBox
    Friend WithEvents txtExamYear As System.Windows.Forms.TextBox
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNational As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CmbGender As System.Windows.Forms.ComboBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents cmbTitle As System.Windows.Forms.ComboBox
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtTadExaminerNo As System.Windows.Forms.TextBox
End Class
