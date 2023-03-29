<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmReceipt
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmReceipt))
        Me.lblExamYear = New System.Windows.Forms.Label
        Me.lblExamSeries = New System.Windows.Forms.Label
        Me.lblcandetails = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblwaec = New System.Windows.Forms.Label
        Me.cboindexno = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtDOB = New System.Windows.Forms.TextBox
        Me.txtgender = New System.Windows.Forms.TextBox
        Me.Subject1 = New System.Windows.Forms.Label
        Me.subj2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtSubj1 = New System.Windows.Forms.TextBox
        Me.txtSubj2 = New System.Windows.Forms.TextBox
        Me.txtSubj3 = New System.Windows.Forms.TextBox
        Me.txtSubj4 = New System.Windows.Forms.TextBox
        Me.txtSubj5 = New System.Windows.Forms.TextBox
        Me.txtSubj6 = New System.Windows.Forms.TextBox
        Me.txtSubj7 = New System.Windows.Forms.TextBox
        Me.txtSubj8 = New System.Windows.Forms.TextBox
        Me.txtSubj9 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label18 = New System.Windows.Forms.Label
        Me.CboCandNum = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtexyr = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtschcode = New System.Windows.Forms.TextBox
        Me.cbocentNo = New System.Windows.Forms.ComboBox
        Me.txtSchchc = New System.Windows.Forms.TextBox
        Me.lblcsch = New System.Windows.Forms.Label
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.txtFName = New System.Windows.Forms.TextBox
        Me.txtOtherName = New System.Windows.Forms.TextBox
        Me.lbloname = New System.Windows.Forms.Label
        Me.lblfname = New System.Windows.Forms.Label
        Me.lbllname = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.txtNoofSubjs = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbexit = New System.Windows.Forms.Button
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.cmdprint = New System.Windows.Forms.Button
        Me.cmdUpdate = New System.Windows.Forms.Button
        Me.ChNPaid = New System.Windows.Forms.CheckBox
        Me.ChkPaid = New System.Windows.Forms.CheckBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.lblbal = New System.Windows.Forms.Label
        Me.balance = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtAmtPaid = New System.Windows.Forms.TextBox
        Me.LblExpectedAmt = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.lblAmount = New System.Windows.Forms.Label
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.Lmessage = New System.Windows.Forms.Label
        Me.RichTextBox3 = New System.Windows.Forms.RichTextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.lblcentno = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblExamYear
        '
        Me.lblExamYear.AutoSize = True
        Me.lblExamYear.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamYear.ForeColor = System.Drawing.Color.Transparent
        Me.lblExamYear.Location = New System.Drawing.Point(11, 19)
        Me.lblExamYear.Name = "lblExamYear"
        Me.lblExamYear.Size = New System.Drawing.Size(69, 15)
        Me.lblExamYear.TabIndex = 90
        Me.lblExamYear.Text = "Exam Year:"
        '
        'lblExamSeries
        '
        Me.lblExamSeries.AutoSize = True
        Me.lblExamSeries.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExamSeries.ForeColor = System.Drawing.Color.Transparent
        Me.lblExamSeries.Location = New System.Drawing.Point(10, 43)
        Me.lblExamSeries.Name = "lblExamSeries"
        Me.lblExamSeries.Size = New System.Drawing.Size(74, 15)
        Me.lblExamSeries.TabIndex = 89
        Me.lblExamSeries.Text = "Exam Name:"
        '
        'lblcandetails
        '
        Me.lblcandetails.AutoSize = True
        Me.lblcandetails.BackColor = System.Drawing.Color.Transparent
        Me.lblcandetails.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcandetails.ForeColor = System.Drawing.Color.Yellow
        Me.lblcandetails.Location = New System.Drawing.Point(301, 113)
        Me.lblcandetails.Name = "lblcandetails"
        Me.lblcandetails.Size = New System.Drawing.Size(327, 19)
        Me.lblcandetails.TabIndex = 85
        Me.lblcandetails.Text = "GABECE CANDIDATE PAYMENT DETAILS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(387, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 19)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = " "
        '
        'lblwaec
        '
        Me.lblwaec.AutoSize = True
        Me.lblwaec.BackColor = System.Drawing.Color.Transparent
        Me.lblwaec.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblwaec.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblwaec.ForeColor = System.Drawing.Color.Yellow
        Me.lblwaec.Location = New System.Drawing.Point(232, -1)
        Me.lblwaec.Name = "lblwaec"
        Me.lblwaec.Size = New System.Drawing.Size(373, 21)
        Me.lblwaec.TabIndex = 83
        Me.lblwaec.Text = "The West African Examinations Council, Banjul Office"
        '
        'cboindexno
        '
        Me.cboindexno.AutoSize = True
        Me.cboindexno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboindexno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cboindexno.Location = New System.Drawing.Point(214, 31)
        Me.cboindexno.Name = "cboindexno"
        Me.cboindexno.Size = New System.Drawing.Size(75, 19)
        Me.cboindexno.TabIndex = 92
        Me.cboindexno.Text = "Index No."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(780, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(385, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 19)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "Date of Birth:"
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtDOB.Location = New System.Drawing.Point(493, 23)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(119, 26)
        Me.txtDOB.TabIndex = 97
        '
        'txtgender
        '
        Me.txtgender.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.Location = New System.Drawing.Point(839, 61)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.Size = New System.Drawing.Size(39, 26)
        Me.txtgender.TabIndex = 98
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
        'subj2
        '
        Me.subj2.AutoSize = True
        Me.subj2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subj2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.subj2.Location = New System.Drawing.Point(2, 45)
        Me.subj2.Name = "subj2"
        Me.subj2.Size = New System.Drawing.Size(58, 15)
        Me.subj2.TabIndex = 100
        Me.subj2.Text = "Subject 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(560, 46)
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
        Me.Label11.Location = New System.Drawing.Point(271, 26)
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
        Me.Label12.Location = New System.Drawing.Point(560, 69)
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
        Me.Label13.Location = New System.Drawing.Point(271, 50)
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
        Me.Label14.Location = New System.Drawing.Point(271, 75)
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
        Me.Label15.Location = New System.Drawing.Point(560, 21)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "Subject 7"
        '
        'txtSubj1
        '
        Me.txtSubj1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj1.Location = New System.Drawing.Point(60, 18)
        Me.txtSubj1.Name = "txtSubj1"
        Me.txtSubj1.Size = New System.Drawing.Size(213, 22)
        Me.txtSubj1.TabIndex = 108
        '
        'txtSubj2
        '
        Me.txtSubj2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj2.Location = New System.Drawing.Point(60, 42)
        Me.txtSubj2.Name = "txtSubj2"
        Me.txtSubj2.Size = New System.Drawing.Size(213, 22)
        Me.txtSubj2.TabIndex = 109
        '
        'txtSubj3
        '
        Me.txtSubj3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj3.Location = New System.Drawing.Point(60, 67)
        Me.txtSubj3.Name = "txtSubj3"
        Me.txtSubj3.Size = New System.Drawing.Size(213, 22)
        Me.txtSubj3.TabIndex = 110
        '
        'txtSubj4
        '
        Me.txtSubj4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj4.Location = New System.Drawing.Point(335, 22)
        Me.txtSubj4.Name = "txtSubj4"
        Me.txtSubj4.Size = New System.Drawing.Size(219, 22)
        Me.txtSubj4.TabIndex = 111
        '
        'txtSubj5
        '
        Me.txtSubj5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj5.Location = New System.Drawing.Point(335, 46)
        Me.txtSubj5.Name = "txtSubj5"
        Me.txtSubj5.Size = New System.Drawing.Size(219, 22)
        Me.txtSubj5.TabIndex = 112
        '
        'txtSubj6
        '
        Me.txtSubj6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj6.Location = New System.Drawing.Point(335, 71)
        Me.txtSubj6.Name = "txtSubj6"
        Me.txtSubj6.Size = New System.Drawing.Size(219, 22)
        Me.txtSubj6.TabIndex = 113
        '
        'txtSubj7
        '
        Me.txtSubj7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj7.Location = New System.Drawing.Point(624, 17)
        Me.txtSubj7.Name = "txtSubj7"
        Me.txtSubj7.Size = New System.Drawing.Size(228, 22)
        Me.txtSubj7.TabIndex = 114
        '
        'txtSubj8
        '
        Me.txtSubj8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj8.Location = New System.Drawing.Point(624, 42)
        Me.txtSubj8.Name = "txtSubj8"
        Me.txtSubj8.Size = New System.Drawing.Size(228, 22)
        Me.txtSubj8.TabIndex = 115
        '
        'txtSubj9
        '
        Me.txtSubj9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubj9.Location = New System.Drawing.Point(624, 66)
        Me.txtSubj9.Name = "txtSubj9"
        Me.txtSubj9.Size = New System.Drawing.Size(228, 22)
        Me.txtSubj9.TabIndex = 116
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(81, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 117
        Me.Label5.Text = "GABECE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(654, 51)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(228, 26)
        Me.DateTimePicker1.TabIndex = 124
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(601, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(47, 19)
        Me.Label18.TabIndex = 125
        Me.Label18.Text = "Date:"
        '
        'CboCandNum
        '
        Me.CboCandNum.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CboCandNum.FormattingEnabled = True
        Me.CboCandNum.Location = New System.Drawing.Point(295, 23)
        Me.CboCandNum.Name = "CboCandNum"
        Me.CboCandNum.Size = New System.Drawing.Size(78, 27)
        Me.CboCandNum.TabIndex = 128
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtexyr)
        Me.GroupBox1.Controls.Add(Me.lblExamYear)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.lblExamSeries)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox1.Location = New System.Drawing.Point(15, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(169, 60)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam Details"
        '
        'txtexyr
        '
        Me.txtexyr.Location = New System.Drawing.Point(79, 17)
        Me.txtexyr.Name = "txtexyr"
        Me.txtexyr.Size = New System.Drawing.Size(76, 20)
        Me.txtexyr.TabIndex = 118
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtschcode)
        Me.GroupBox2.Controls.Add(Me.cbocentNo)
        Me.GroupBox2.Controls.Add(Me.lblcentno)
        Me.GroupBox2.Controls.Add(Me.txtSchchc)
        Me.GroupBox2.Controls.Add(Me.lblcsch)
        Me.GroupBox2.Controls.Add(Me.txtLname)
        Me.GroupBox2.Controls.Add(Me.txtFName)
        Me.GroupBox2.Controls.Add(Me.txtOtherName)
        Me.GroupBox2.Controls.Add(Me.lbloname)
        Me.GroupBox2.Controls.Add(Me.lblfname)
        Me.GroupBox2.Controls.Add(Me.lbllname)
        Me.GroupBox2.Controls.Add(Me.txtgender)
        Me.GroupBox2.Controls.Add(Me.cboindexno)
        Me.GroupBox2.Controls.Add(Me.CboCandNum)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtDOB)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Gold
        Me.GroupBox2.Location = New System.Drawing.Point(12, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(884, 136)
        Me.GroupBox2.TabIndex = 130
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Candidate Details"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Transparent
        Me.Label17.Location = New System.Drawing.Point(678, 106)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(92, 19)
        Me.Label17.TabIndex = 140
        Me.Label17.Text = "School Code"
        '
        'txtschcode
        '
        Me.txtschcode.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtschcode.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtschcode.Location = New System.Drawing.Point(778, 100)
        Me.txtschcode.Name = "txtschcode"
        Me.txtschcode.Size = New System.Drawing.Size(74, 26)
        Me.txtschcode.TabIndex = 141
        '
        'cbocentNo
        '
        Me.cbocentNo.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocentNo.FormattingEnabled = True
        Me.cbocentNo.Location = New System.Drawing.Point(97, 22)
        Me.cbocentNo.Name = "cbocentNo"
        Me.cbocentNo.Size = New System.Drawing.Size(98, 27)
        Me.cbocentNo.TabIndex = 139
        '
        'txtSchchc
        '
        Me.txtSchchc.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchchc.Location = New System.Drawing.Point(137, 100)
        Me.txtSchchc.Name = "txtSchchc"
        Me.txtSchchc.Size = New System.Drawing.Size(535, 26)
        Me.txtSchchc.TabIndex = 136
        '
        'lblcsch
        '
        Me.lblcsch.AutoSize = True
        Me.lblcsch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcsch.ForeColor = System.Drawing.Color.Transparent
        Me.lblcsch.Location = New System.Drawing.Point(16, 106)
        Me.lblcsch.Name = "lblcsch"
        Me.lblcsch.Size = New System.Drawing.Size(120, 19)
        Me.lblcsch.TabIndex = 135
        Me.lblcsch.Text = "Choice of School"
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(97, 60)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(150, 26)
        Me.txtLname.TabIndex = 134
        '
        'txtFName
        '
        Me.txtFName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFName.Location = New System.Drawing.Point(330, 61)
        Me.txtFName.Name = "txtFName"
        Me.txtFName.Size = New System.Drawing.Size(195, 26)
        Me.txtFName.TabIndex = 133
        '
        'txtOtherName
        '
        Me.txtOtherName.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherName.Location = New System.Drawing.Point(640, 60)
        Me.txtOtherName.Name = "txtOtherName"
        Me.txtOtherName.Size = New System.Drawing.Size(134, 26)
        Me.txtOtherName.TabIndex = 132
        '
        'lbloname
        '
        Me.lbloname.AutoSize = True
        Me.lbloname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbloname.ForeColor = System.Drawing.Color.Transparent
        Me.lbloname.Location = New System.Drawing.Point(538, 67)
        Me.lbloname.Name = "lbloname"
        Me.lbloname.Size = New System.Drawing.Size(95, 19)
        Me.lbloname.TabIndex = 131
        Me.lbloname.Text = "OtherNames"
        '
        'lblfname
        '
        Me.lblfname.AutoSize = True
        Me.lblfname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfname.ForeColor = System.Drawing.Color.Transparent
        Me.lblfname.Location = New System.Drawing.Point(244, 68)
        Me.lblfname.Name = "lblfname"
        Me.lblfname.Size = New System.Drawing.Size(80, 19)
        Me.lblfname.TabIndex = 130
        Me.lblfname.Text = "FirstName"
        '
        'lbllname
        '
        Me.lbllname.AutoSize = True
        Me.lbllname.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllname.ForeColor = System.Drawing.Color.Transparent
        Me.lbllname.Location = New System.Drawing.Point(12, 63)
        Me.lbllname.Name = "lbllname"
        Me.lbllname.Size = New System.Drawing.Size(79, 19)
        Me.lbllname.TabIndex = 129
        Me.lbllname.Text = "LastName"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtNoofSubjs)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.txtSubj1)
        Me.GroupBox3.Controls.Add(Me.Subject1)
        Me.GroupBox3.Controls.Add(Me.subj2)
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
        Me.GroupBox3.Location = New System.Drawing.Point(12, 277)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(884, 132)
        Me.GroupBox3.TabIndex = 131
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
        'cmbexit
        '
        Me.cmbexit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbexit.Location = New System.Drawing.Point(471, 511)
        Me.cmbexit.Name = "cmbexit"
        Me.cmbexit.Size = New System.Drawing.Size(75, 25)
        Me.cmbexit.TabIndex = 140
        Me.cmbexit.Text = "Exit"
        Me.cmbexit.UseVisualStyleBackColor = True
        '
        'CmdSearch
        '
        Me.CmdSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSearch.Location = New System.Drawing.Point(390, 511)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.CmdSearch.TabIndex = 133
        Me.CmdSearch.Text = "Search"
        Me.CmdSearch.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.cmdprint)
        Me.GroupBox5.Controls.Add(Me.cmdUpdate)
        Me.GroupBox5.Controls.Add(Me.ChNPaid)
        Me.GroupBox5.Controls.Add(Me.ChkPaid)
        Me.GroupBox5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Cornsilk
        Me.GroupBox5.Location = New System.Drawing.Point(471, 415)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(305, 80)
        Me.GroupBox5.TabIndex = 142
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Manipulation"
        '
        'cmdprint
        '
        Me.cmdprint.ForeColor = System.Drawing.Color.Crimson
        Me.cmdprint.Location = New System.Drawing.Point(112, 48)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(84, 32)
        Me.cmdprint.TabIndex = 5
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = True
        '
        'cmdUpdate
        '
        Me.cmdUpdate.ForeColor = System.Drawing.Color.Crimson
        Me.cmdUpdate.Location = New System.Drawing.Point(22, 48)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(84, 32)
        Me.cmdUpdate.TabIndex = 4
        Me.cmdUpdate.Text = "Update"
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'ChNPaid
        '
        Me.ChNPaid.AutoSize = True
        Me.ChNPaid.Checked = True
        Me.ChNPaid.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChNPaid.Location = New System.Drawing.Point(25, 21)
        Me.ChNPaid.Name = "ChNPaid"
        Me.ChNPaid.Size = New System.Drawing.Size(81, 20)
        Me.ChNPaid.TabIndex = 1
        Me.ChNPaid.Text = "Not Paid"
        Me.ChNPaid.UseVisualStyleBackColor = True
        '
        'ChkPaid
        '
        Me.ChkPaid.AutoSize = True
        Me.ChkPaid.Location = New System.Drawing.Point(127, 22)
        Me.ChkPaid.Name = "ChkPaid"
        Me.ChkPaid.Size = New System.Drawing.Size(56, 20)
        Me.ChkPaid.TabIndex = 0
        Me.ChkPaid.Text = "Paid"
        Me.ChkPaid.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lblbal)
        Me.GroupBox6.Controls.Add(Me.balance)
        Me.GroupBox6.Controls.Add(Me.Label24)
        Me.GroupBox6.Controls.Add(Me.txtAmtPaid)
        Me.GroupBox6.Controls.Add(Me.LblExpectedAmt)
        Me.GroupBox6.Controls.Add(Me.Label25)
        Me.GroupBox6.Controls.Add(Me.lblAmount)
        Me.GroupBox6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GroupBox6.ForeColor = System.Drawing.Color.Cornsilk
        Me.GroupBox6.Location = New System.Drawing.Point(12, 415)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(458, 80)
        Me.GroupBox6.TabIndex = 141
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Candidate Fee Status"
        '
        'lblbal
        '
        Me.lblbal.AutoSize = True
        Me.lblbal.Location = New System.Drawing.Point(188, 64)
        Me.lblbal.Name = "lblbal"
        Me.lblbal.Size = New System.Drawing.Size(28, 16)
        Me.lblbal.TabIndex = 6
        Me.lblbal.Text = "bal"
        '
        'balance
        '
        Me.balance.AutoSize = True
        Me.balance.Location = New System.Drawing.Point(182, 64)
        Me.balance.Name = "balance"
        Me.balance.Size = New System.Drawing.Size(0, 16)
        Me.balance.TabIndex = 5
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(28, 64)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(157, 16)
        Me.Label24.TabIndex = 4
        Me.Label24.Text = "Oustanding Balance : D"
        '
        'txtAmtPaid
        '
        Me.txtAmtPaid.Location = New System.Drawing.Point(354, 31)
        Me.txtAmtPaid.Name = "txtAmtPaid"
        Me.txtAmtPaid.Size = New System.Drawing.Size(78, 22)
        Me.txtAmtPaid.TabIndex = 3
        Me.txtAmtPaid.Text = "0"
        '
        'LblExpectedAmt
        '
        Me.LblExpectedAmt.AutoSize = True
        Me.LblExpectedAmt.Location = New System.Drawing.Point(173, 31)
        Me.LblExpectedAmt.Name = "LblExpectedAmt"
        Me.LblExpectedAmt.Size = New System.Drawing.Size(58, 16)
        Me.LblExpectedAmt.TabIndex = 2
        Me.LblExpectedAmt.Text = "Label13"
        Me.LblExpectedAmt.Visible = False
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(242, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(111, 16)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "Amount Paid : D"
        '
        'lblAmount
        '
        Me.lblAmount.AutoSize = True
        Me.lblAmount.Location = New System.Drawing.Point(26, 31)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(141, 16)
        Me.lblAmount.TabIndex = 0
        Me.lblAmount.Text = "Expected Amount : D"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDocument1
        '
        '
        'Lmessage
        '
        Me.Lmessage.AutoSize = True
        Me.Lmessage.Location = New System.Drawing.Point(609, 103)
        Me.Lmessage.Name = "Lmessage"
        Me.Lmessage.Size = New System.Drawing.Size(45, 13)
        Me.Lmessage.TabIndex = 6
        Me.Lmessage.Text = "Label19"
        '
        'RichTextBox3
        '
        Me.RichTextBox3.Location = New System.Drawing.Point(815, 425)
        Me.RichTextBox3.Name = "RichTextBox3"
        Me.RichTextBox3.Size = New System.Drawing.Size(100, 96)
        Me.RichTextBox3.TabIndex = 143
        Me.RichTextBox3.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(399, 30)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 72)
        Me.PictureBox1.TabIndex = 86
        Me.PictureBox1.TabStop = False
        '
        'lblcentno
        '
        Me.lblcentno.AutoSize = True
        Me.lblcentno.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcentno.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblcentno.Location = New System.Drawing.Point(12, 26)
        Me.lblcentno.Name = "lblcentno"
        Me.lblcentno.Size = New System.Drawing.Size(83, 19)
        Me.lblcentno.TabIndex = 137
        Me.lblcentno.Text = "Centre No."
        '
        'FrmReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(924, 549)
        Me.Controls.Add(Me.RichTextBox3)
        Me.Controls.Add(Me.Lmessage)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.cmbexit)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblcandetails)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblwaec)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmReceipt"
        Me.Text = "Candidate Payment Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblExamYear As System.Windows.Forms.Label
    Friend WithEvents lblExamSeries As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblcandetails As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblwaec As System.Windows.Forms.Label
    Friend WithEvents cboindexno As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents Subject1 As System.Windows.Forms.Label
    Friend WithEvents subj2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtSubj1 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj2 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj3 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj4 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj5 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj6 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj7 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj8 As System.Windows.Forms.TextBox
    Friend WithEvents txtSubj9 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents CboCandNum As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNoofSubjs As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtFName As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherName As System.Windows.Forms.TextBox
    Friend WithEvents lbloname As System.Windows.Forms.Label
    Friend WithEvents lblfname As System.Windows.Forms.Label
    Friend WithEvents lbllname As System.Windows.Forms.Label
    Friend WithEvents cmbexit As System.Windows.Forms.Button
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents lblcsch As System.Windows.Forms.Label
    Friend WithEvents txtSchchc As System.Windows.Forms.TextBox
    Friend WithEvents cbocentNo As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents ChNPaid As System.Windows.Forms.CheckBox
    Friend WithEvents ChkPaid As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents balance As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtAmtPaid As System.Windows.Forms.TextBox
    Friend WithEvents LblExpectedAmt As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents lblAmount As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtschcode As System.Windows.Forms.TextBox
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents txtexyr As System.Windows.Forms.TextBox
    Friend WithEvents Lmessage As System.Windows.Forms.Label
    Friend WithEvents RichTextBox3 As System.Windows.Forms.RichTextBox
    Friend WithEvents lblbal As System.Windows.Forms.Label
    Friend WithEvents lblcentno As System.Windows.Forms.Label
End Class
