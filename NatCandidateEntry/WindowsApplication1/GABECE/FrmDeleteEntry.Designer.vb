<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDeleteEntry
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDeleteEntry))
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblwaec = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtcanno = New System.Windows.Forms.TextBox
        Me.txtgender = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtschcode = New System.Windows.Forms.TextBox
        Me.lblExamYear = New System.Windows.Forms.Label
        Me.txtexamyear = New System.Windows.Forms.TextBox
        Me.txtOtherName = New System.Windows.Forms.TextBox
        Me.LblOtherName = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboCentCode = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLName = New System.Windows.Forms.TextBox
        Me.lblcandSurname = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.lblSchofCho = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtNoofSubjs = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtSubj1 = New System.Windows.Forms.TextBox
        Me.Subject1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtSubj2 = New System.Windows.Forms.TextBox
        Me.txtSubj3 = New System.Windows.Forms.TextBox
        Me.txtSubj4 = New System.Windows.Forms.TextBox
        Me.txtSubj9 = New System.Windows.Forms.TextBox
        Me.txtSubj5 = New System.Windows.Forms.TextBox
        Me.txtSubj8 = New System.Windows.Forms.TextBox
        Me.txtSubj6 = New System.Windows.Forms.TextBox
        Me.txtSubj7 = New System.Windows.Forms.TextBox
        Me.cmdsearch = New System.Windows.Forms.Button
        Me.cmddelete = New System.Windows.Forms.Button
        Me.cmdexit = New System.Windows.Forms.Button
        Me.CmdClear = New System.Windows.Forms.Button
        Me.LMessage = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Yellow
        Me.Label8.Location = New System.Drawing.Point(301, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(175, 19)
        Me.Label8.TabIndex = 42
        Me.Label8.Text = "Delete Candidate Entry  "
        '
        'lblwaec
        '
        Me.lblwaec.AutoSize = True
        Me.lblwaec.BackColor = System.Drawing.Color.Transparent
        Me.lblwaec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwaec.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaec.ForeColor = System.Drawing.Color.Yellow
        Me.lblwaec.Location = New System.Drawing.Point(205, 3)
        Me.lblwaec.Name = "lblwaec"
        Me.lblwaec.Size = New System.Drawing.Size(373, 21)
        Me.lblwaec.TabIndex = 41
        Me.lblwaec.Text = "The West African Examinations Council, Banjul Office"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtcanno)
        Me.GroupBox2.Controls.Add(Me.txtgender)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtschcode)
        Me.GroupBox2.Controls.Add(Me.lblExamYear)
        Me.GroupBox2.Controls.Add(Me.txtexamyear)
        Me.GroupBox2.Controls.Add(Me.txtOtherName)
        Me.GroupBox2.Controls.Add(Me.LblOtherName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.CboCentCode)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtLName)
        Me.GroupBox2.Controls.Add(Me.lblcandSurname)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFName)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.lblSchofCho)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(12, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(788, 135)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Candidate Details"
        '
        'txtcanno
        '
        Me.txtcanno.Location = New System.Drawing.Point(503, 14)
        Me.txtcanno.Name = "txtcanno"
        Me.txtcanno.Size = New System.Drawing.Size(100, 25)
        Me.txtcanno.TabIndex = 140
        '
        'txtgender
        '
        Me.txtgender.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.Location = New System.Drawing.Point(538, 100)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(93, 25)
        Me.txtgender.TabIndex = 139
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(475, 108)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 17)
        Me.Label1.TabIndex = 138
        Me.Label1.Text = "Gender"
        '
        'txtschcode
        '
        Me.txtschcode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtschcode.Location = New System.Drawing.Point(376, 100)
        Me.txtschcode.Name = "txtschcode"
        Me.txtschcode.Size = New System.Drawing.Size(93, 25)
        Me.txtschcode.TabIndex = 136
        '
        'lblExamYear
        '
        Me.lblExamYear.AutoSize = True
        Me.lblExamYear.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamYear.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblExamYear.Location = New System.Drawing.Point(14, 22)
        Me.lblExamYear.Name = "lblExamYear"
        Me.lblExamYear.Size = New System.Drawing.Size(80, 17)
        Me.lblExamYear.TabIndex = 82
        Me.lblExamYear.Text = "Exam Year"
        '
        'txtexamyear
        '
        Me.txtexamyear.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexamyear.Location = New System.Drawing.Point(100, 19)
        Me.txtexamyear.Name = "txtexamyear"
        Me.txtexamyear.Size = New System.Drawing.Size(93, 25)
        Me.txtexamyear.TabIndex = 135
        '
        'txtOtherName
        '
        Me.txtOtherName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOtherName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherName.Location = New System.Drawing.Point(613, 56)
        Me.txtOtherName.Name = "txtOtherName"
        Me.txtOtherName.Size = New System.Drawing.Size(166, 25)
        Me.txtOtherName.TabIndex = 7
        '
        'LblOtherName
        '
        Me.LblOtherName.AutoSize = True
        Me.LblOtherName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOtherName.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.LblOtherName.Location = New System.Drawing.Point(511, 62)
        Me.LblOtherName.Name = "LblOtherName"
        Me.LblOtherName.Size = New System.Drawing.Size(96, 17)
        Me.LblOtherName.TabIndex = 84
        Me.LblOtherName.Text = "Other Names"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(207, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Centre Number"
        '
        'CboCentCode
        '
        Me.CboCentCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCentCode.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCentCode.FormattingEnabled = True
        Me.CboCentCode.Location = New System.Drawing.Point(317, 15)
        Me.CboCentCode.Name = "CboCentCode"
        Me.CboCentCode.Size = New System.Drawing.Size(99, 25)
        Me.CboCentCode.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(422, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Index NO."
        '
        'txtLName
        '
        Me.txtLName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLName.Location = New System.Drawing.Point(84, 58)
        Me.txtLName.Name = "txtLName"
        Me.txtLName.Size = New System.Drawing.Size(174, 25)
        Me.txtLName.TabIndex = 5
        '
        'lblcandSurname
        '
        Me.lblcandSurname.AutoSize = True
        Me.lblcandSurname.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcandSurname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblcandSurname.Location = New System.Drawing.Point(14, 67)
        Me.lblcandSurname.Name = "lblcandSurname"
        Me.lblcandSurname.Size = New System.Drawing.Size(75, 17)
        Me.lblcandSurname.TabIndex = 28
        Me.lblcandSurname.Text = "LastName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(264, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "FirstName"
        '
        'txtFName
        '
        Me.txtFName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(341, 56)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(166, 25)
        Me.txtFName.TabIndex = 6
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(112, 100)
        Me.DateTimePicker1.MinDate = New Date(1980, 1, 1, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 25)
        Me.DateTimePicker1.TabIndex = 8
        '
        'lblSchofCho
        '
        Me.lblSchofCho.AutoSize = True
        Me.lblSchofCho.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSchofCho.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.lblSchofCho.Location = New System.Drawing.Point(253, 108)
        Me.lblSchofCho.Name = "lblSchofCho"
        Me.lblSchofCho.Size = New System.Drawing.Size(117, 17)
        Me.lblSchofCho.TabIndex = 43
        Me.lblSchofCho.Text = "School of Choice"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(13, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 17)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Date of Birth"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNoofSubjs)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtSubj1)
        Me.GroupBox3.Controls.Add(Me.Subject1)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txtSubj2)
        Me.GroupBox3.Controls.Add(Me.txtSubj3)
        Me.GroupBox3.Controls.Add(Me.txtSubj4)
        Me.GroupBox3.Controls.Add(Me.txtSubj9)
        Me.GroupBox3.Controls.Add(Me.txtSubj5)
        Me.GroupBox3.Controls.Add(Me.txtSubj8)
        Me.GroupBox3.Controls.Add(Me.txtSubj6)
        Me.GroupBox3.Controls.Add(Me.txtSubj7)
        Me.GroupBox3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox3.Location = New System.Drawing.Point(12, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(788, 138)
        Me.GroupBox3.TabIndex = 132
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Subject Details"
        '
        'txtNoofSubjs
        '
        Me.txtNoofSubjs.Location = New System.Drawing.Point(346, 104)
        Me.txtNoofSubjs.Name = "txtNoofSubjs"
        Me.txtNoofSubjs.Size = New System.Drawing.Size(55, 22)
        Me.txtNoofSubjs.TabIndex = 119
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(195, 111)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(145, 15)
        Me.Label21.TabIndex = 118
        Me.Label21.Text = "Total Number of Subjects"
        '
        'txtSubj1
        '
        Me.txtSubj1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj1.Location = New System.Drawing.Point(60, 17)
        Me.txtSubj1.Name = "txtSubj1"
        Me.txtSubj1.Size = New System.Drawing.Size(181, 22)
        Me.txtSubj1.TabIndex = 108
        '
        'Subject1
        '
        Me.Subject1.AutoSize = True
        Me.Subject1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Subject1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Subject1.Location = New System.Drawing.Point(4, 17)
        Me.Subject1.Name = "Subject1"
        Me.Subject1.Size = New System.Drawing.Size(58, 15)
        Me.Subject1.TabIndex = 99
        Me.Subject1.Text = "Subject 1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(2, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 15)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Subject 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(521, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Subject 8"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(2, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 102
        Me.Label10.Text = "Subject 3"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(247, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 103
        Me.Label11.Text = "Subject 4"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(521, 68)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 104
        Me.Label12.Text = "Subject 9"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label13.Location = New System.Drawing.Point(247, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 105
        Me.Label13.Text = "Subject 5"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(247, 69)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 106
        Me.Label14.Text = "Subject 6"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(521, 18)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "Subject 7"
        '
        'txtSubj2
        '
        Me.txtSubj2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj2.Location = New System.Drawing.Point(60, 42)
        Me.txtSubj2.Name = "txtSubj2"
        Me.txtSubj2.Size = New System.Drawing.Size(181, 22)
        Me.txtSubj2.TabIndex = 109
        '
        'txtSubj3
        '
        Me.txtSubj3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj3.Location = New System.Drawing.Point(60, 67)
        Me.txtSubj3.Name = "txtSubj3"
        Me.txtSubj3.Size = New System.Drawing.Size(181, 22)
        Me.txtSubj3.TabIndex = 110
        '
        'txtSubj4
        '
        Me.txtSubj4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj4.Location = New System.Drawing.Point(313, 14)
        Me.txtSubj4.Name = "txtSubj4"
        Me.txtSubj4.Size = New System.Drawing.Size(202, 22)
        Me.txtSubj4.TabIndex = 111
        '
        'txtSubj9
        '
        Me.txtSubj9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj9.Location = New System.Drawing.Point(585, 63)
        Me.txtSubj9.Name = "txtSubj9"
        Me.txtSubj9.Size = New System.Drawing.Size(194, 22)
        Me.txtSubj9.TabIndex = 116
        '
        'txtSubj5
        '
        Me.txtSubj5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj5.Location = New System.Drawing.Point(313, 39)
        Me.txtSubj5.Name = "txtSubj5"
        Me.txtSubj5.Size = New System.Drawing.Size(202, 22)
        Me.txtSubj5.TabIndex = 112
        '
        'txtSubj8
        '
        Me.txtSubj8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj8.Location = New System.Drawing.Point(585, 39)
        Me.txtSubj8.Name = "txtSubj8"
        Me.txtSubj8.Size = New System.Drawing.Size(194, 22)
        Me.txtSubj8.TabIndex = 115
        '
        'txtSubj6
        '
        Me.txtSubj6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj6.Location = New System.Drawing.Point(313, 67)
        Me.txtSubj6.Name = "txtSubj6"
        Me.txtSubj6.Size = New System.Drawing.Size(202, 22)
        Me.txtSubj6.TabIndex = 113
        '
        'txtSubj7
        '
        Me.txtSubj7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj7.Location = New System.Drawing.Point(585, 14)
        Me.txtSubj7.Name = "txtSubj7"
        Me.txtSubj7.Size = New System.Drawing.Size(194, 22)
        Me.txtSubj7.TabIndex = 114
        '
        'cmdsearch
        '
        Me.cmdsearch.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdsearch.Location = New System.Drawing.Point(271, 414)
        Me.cmdsearch.Name = "cmdsearch"
        Me.cmdsearch.Size = New System.Drawing.Size(75, 31)
        Me.cmdsearch.TabIndex = 120
        Me.cmdsearch.Text = "Search"
        Me.cmdsearch.UseVisualStyleBackColor = True
        '
        'cmddelete
        '
        Me.cmddelete.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmddelete.Location = New System.Drawing.Point(352, 414)
        Me.cmddelete.Name = "cmddelete"
        Me.cmddelete.Size = New System.Drawing.Size(75, 31)
        Me.cmddelete.TabIndex = 121
        Me.cmddelete.Text = "Delete"
        Me.cmddelete.UseVisualStyleBackColor = True
        '
        'cmdexit
        '
        Me.cmdexit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdexit.Location = New System.Drawing.Point(433, 414)
        Me.cmdexit.Name = "cmdexit"
        Me.cmdexit.Size = New System.Drawing.Size(76, 31)
        Me.cmdexit.TabIndex = 133
        Me.cmdexit.Text = "Exit"
        Me.cmdexit.UseVisualStyleBackColor = True
        '
        'CmdClear
        '
        Me.CmdClear.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClear.Location = New System.Drawing.Point(515, 414)
        Me.CmdClear.Name = "CmdClear"
        Me.CmdClear.Size = New System.Drawing.Size(75, 31)
        Me.CmdClear.TabIndex = 134
        Me.CmdClear.Text = "Clear"
        Me.CmdClear.UseVisualStyleBackColor = True
        '
        'LMessage
        '
        Me.LMessage.AutoSize = True
        Me.LMessage.Location = New System.Drawing.Point(602, 79)
        Me.LMessage.Name = "LMessage"
        Me.LMessage.Size = New System.Drawing.Size(0, 13)
        Me.LMessage.TabIndex = 135
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(350, 34)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 72)
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'FrmDeleteEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(812, 457)
        Me.Controls.Add(Me.LMessage)
        Me.Controls.Add(Me.CmdClear)
        Me.Controls.Add(Me.cmdexit)
        Me.Controls.Add(Me.cmdsearch)
        Me.Controls.Add(Me.cmddelete)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblwaec)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmDeleteEntry"
        Me.Text = "GABECE Candidate Entry Deletion"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblwaec As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblExamYear As System.Windows.Forms.Label
    Friend WithEvents txtOtherName As System.Windows.Forms.TextBox
    Friend WithEvents LblOtherName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboCentCode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLName As System.Windows.Forms.TextBox
    Friend WithEvents lblcandSurname As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents lblSchofCho As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoofSubjs As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSubj1 As System.Windows.Forms.TextBox
    Friend WithEvents Subject1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSubj2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj4 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj9 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj5 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj8 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj6 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj7 As System.Windows.Forms.TextBox
    Friend WithEvents cmdsearch As System.Windows.Forms.Button
    Friend WithEvents cmddelete As System.Windows.Forms.Button
    Friend WithEvents cmdexit As System.Windows.Forms.Button
    Friend WithEvents CmdClear As System.Windows.Forms.Button
    Friend WithEvents txtexamyear As System.Windows.Forms.TextBox
    Friend WithEvents txtschcode As System.Windows.Forms.TextBox
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LMessage As System.Windows.Forms.Label
    Friend WithEvents txtcanno As System.Windows.Forms.TextBox
End Class
