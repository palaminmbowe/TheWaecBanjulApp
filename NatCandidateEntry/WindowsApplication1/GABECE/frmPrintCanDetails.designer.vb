<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintCanDetails
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintCanDetails))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdprint = New System.Windows.Forms.Button
        Me.CmdClose = New System.Windows.Forms.Button
        Me.cmbexamseries = New System.Windows.Forms.Label
        Me.lblFilePath = New System.Windows.Forms.Label
        Me.cmbindex = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupSubjects = New System.Windows.Forms.GroupBox
        Me.lblsub9 = New System.Windows.Forms.Label
        Me.lblsub8 = New System.Windows.Forms.Label
        Me.lblsub7 = New System.Windows.Forms.Label
        Me.lblsub6 = New System.Windows.Forms.Label
        Me.lblsub5 = New System.Windows.Forms.Label
        Me.lblsub4 = New System.Windows.Forms.Label
        Me.lblsub3 = New System.Windows.Forms.Label
        Me.lblsub2 = New System.Windows.Forms.Label
        Me.lblsub1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.lbltotsubj = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCenter = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.DOB = New System.Windows.Forms.DateTimePicker
        Me.txtfirstname = New System.Windows.Forms.TextBox
        Me.txtlastname = New System.Windows.Forms.TextBox
        Me.txtOtherNames = New System.Windows.Forms.TextBox
        Me.GroupBiodata = New System.Windows.Forms.GroupBox
        Me.txtgender = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.schchoice = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.LblGender = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.FontDialog1 = New System.Windows.Forms.FontDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.txtexamyr = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupSubjects.SuspendLayout()
        Me.GroupBiodata.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdprint)
        Me.GroupBox1.Controls.Add(Me.CmdClose)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 629)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(845, 58)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        '
        'cmdprint
        '
        Me.cmdprint.ForeColor = System.Drawing.Color.Crimson
        Me.cmdprint.Location = New System.Drawing.Point(145, 11)
        Me.cmdprint.Name = "cmdprint"
        Me.cmdprint.Size = New System.Drawing.Size(183, 38)
        Me.cmdprint.TabIndex = 9
        Me.cmdprint.Text = "Print"
        Me.cmdprint.UseVisualStyleBackColor = True
        '
        'CmdClose
        '
        Me.CmdClose.Location = New System.Drawing.Point(549, 11)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(102, 43)
        Me.CmdClose.TabIndex = 8
        Me.CmdClose.Text = "CLOSE"
        Me.CmdClose.UseVisualStyleBackColor = True
        '
        'cmbexamseries
        '
        Me.cmbexamseries.AutoSize = True
        Me.cmbexamseries.Location = New System.Drawing.Point(111, 25)
        Me.cmbexamseries.Name = "cmbexamseries"
        Me.cmbexamseries.Size = New System.Drawing.Size(13, 19)
        Me.cmbexamseries.TabIndex = 20
        Me.cmbexamseries.Text = " "
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Location = New System.Drawing.Point(657, 70)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(0, 13)
        Me.lblFilePath.TabIndex = 27
        '
        'cmbindex
        '
        Me.cmbindex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbindex.FormattingEnabled = True
        Me.cmbindex.Location = New System.Drawing.Point(321, 56)
        Me.cmbindex.Name = "cmbindex"
        Me.cmbindex.Size = New System.Drawing.Size(103, 27)
        Me.cmbindex.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(235, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "First Name :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(433, 62)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Date of Birth :"
        '
        'GroupSubjects
        '
        Me.GroupSubjects.Controls.Add(Me.lblsub9)
        Me.GroupSubjects.Controls.Add(Me.lblsub8)
        Me.GroupSubjects.Controls.Add(Me.lblsub7)
        Me.GroupSubjects.Controls.Add(Me.lblsub6)
        Me.GroupSubjects.Controls.Add(Me.lblsub5)
        Me.GroupSubjects.Controls.Add(Me.lblsub4)
        Me.GroupSubjects.Controls.Add(Me.lblsub3)
        Me.GroupSubjects.Controls.Add(Me.lblsub2)
        Me.GroupSubjects.Controls.Add(Me.lblsub1)
        Me.GroupSubjects.Controls.Add(Me.Label10)
        Me.GroupSubjects.Controls.Add(Me.lbltotsubj)
        Me.GroupSubjects.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupSubjects.ForeColor = System.Drawing.Color.White
        Me.GroupSubjects.Location = New System.Drawing.Point(17, 323)
        Me.GroupSubjects.Name = "GroupSubjects"
        Me.GroupSubjects.Size = New System.Drawing.Size(845, 292)
        Me.GroupSubjects.TabIndex = 31
        Me.GroupSubjects.TabStop = False
        Me.GroupSubjects.Text = "Candidate Subject Selection"
        '
        'lblsub9
        '
        Me.lblsub9.AutoSize = True
        Me.lblsub9.Location = New System.Drawing.Point(11, 262)
        Me.lblsub9.Name = "lblsub9"
        Me.lblsub9.Size = New System.Drawing.Size(58, 16)
        Me.lblsub9.TabIndex = 26
        Me.lblsub9.Text = "Label19"
        '
        'lblsub8
        '
        Me.lblsub8.AutoSize = True
        Me.lblsub8.Location = New System.Drawing.Point(11, 232)
        Me.lblsub8.Name = "lblsub8"
        Me.lblsub8.Size = New System.Drawing.Size(58, 16)
        Me.lblsub8.TabIndex = 25
        Me.lblsub8.Text = "Label18"
        '
        'lblsub7
        '
        Me.lblsub7.AutoSize = True
        Me.lblsub7.Location = New System.Drawing.Point(11, 207)
        Me.lblsub7.Name = "lblsub7"
        Me.lblsub7.Size = New System.Drawing.Size(58, 16)
        Me.lblsub7.TabIndex = 24
        Me.lblsub7.Text = "Label17"
        '
        'lblsub6
        '
        Me.lblsub6.AutoSize = True
        Me.lblsub6.Location = New System.Drawing.Point(11, 182)
        Me.lblsub6.Name = "lblsub6"
        Me.lblsub6.Size = New System.Drawing.Size(58, 16)
        Me.lblsub6.TabIndex = 23
        Me.lblsub6.Text = "Label16"
        '
        'lblsub5
        '
        Me.lblsub5.AutoSize = True
        Me.lblsub5.Location = New System.Drawing.Point(11, 151)
        Me.lblsub5.Name = "lblsub5"
        Me.lblsub5.Size = New System.Drawing.Size(58, 16)
        Me.lblsub5.TabIndex = 22
        Me.lblsub5.Text = "Label15"
        '
        'lblsub4
        '
        Me.lblsub4.AutoSize = True
        Me.lblsub4.Location = New System.Drawing.Point(11, 124)
        Me.lblsub4.Name = "lblsub4"
        Me.lblsub4.Size = New System.Drawing.Size(58, 16)
        Me.lblsub4.TabIndex = 21
        Me.lblsub4.Text = "Label14"
        '
        'lblsub3
        '
        Me.lblsub3.AutoSize = True
        Me.lblsub3.Location = New System.Drawing.Point(11, 92)
        Me.lblsub3.Name = "lblsub3"
        Me.lblsub3.Size = New System.Drawing.Size(58, 16)
        Me.lblsub3.TabIndex = 20
        Me.lblsub3.Text = "Label13"
        '
        'lblsub2
        '
        Me.lblsub2.AutoSize = True
        Me.lblsub2.Location = New System.Drawing.Point(11, 62)
        Me.lblsub2.Name = "lblsub2"
        Me.lblsub2.Size = New System.Drawing.Size(58, 16)
        Me.lblsub2.TabIndex = 19
        Me.lblsub2.Text = "Label12"
        '
        'lblsub1
        '
        Me.lblsub1.AutoSize = True
        Me.lblsub1.Location = New System.Drawing.Point(11, 35)
        Me.lblsub1.Name = "lblsub1"
        Me.lblsub1.Size = New System.Drawing.Size(51, 16)
        Me.lblsub1.TabIndex = 18
        Me.lblsub1.Text = "Label9"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(666, 262)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 16)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Total Subjects ="
        '
        'lbltotsubj
        '
        Me.lbltotsubj.AutoSize = True
        Me.lbltotsubj.Location = New System.Drawing.Point(792, 262)
        Me.lbltotsubj.Name = "lbltotsubj"
        Me.lbltotsubj.Size = New System.Drawing.Size(16, 16)
        Me.lbltotsubj.TabIndex = 15
        Me.lbltotsubj.Text = "T"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Exam Series :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Center :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(286, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(389, 18)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "The West African Examinations Council - Banjul Office"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(244, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Index No.:"
        '
        'cmbCenter
        '
        Me.cmbCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCenter.FormattingEnabled = True
        Me.cmbCenter.Location = New System.Drawing.Point(110, 58)
        Me.cmbCenter.Name = "cmbCenter"
        Me.cmbCenter.Size = New System.Drawing.Size(119, 27)
        Me.cmbCenter.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(446, 95)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 15)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Other Names"
        '
        'DOB
        '
        Me.DOB.CustomFormat = "dd/MMM/yy"
        Me.DOB.Enabled = False
        Me.DOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DOB.Location = New System.Drawing.Point(534, 54)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(102, 26)
        Me.DOB.TabIndex = 4
        Me.DOB.Value = New Date(2009, 1, 18, 0, 0, 0, 0)
        '
        'txtfirstname
        '
        Me.txtfirstname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.Location = New System.Drawing.Point(321, 90)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.ReadOnly = True
        Me.txtfirstname.Size = New System.Drawing.Size(114, 22)
        Me.txtfirstname.TabIndex = 6
        '
        'txtlastname
        '
        Me.txtlastname.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.Location = New System.Drawing.Point(109, 88)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.ReadOnly = True
        Me.txtlastname.Size = New System.Drawing.Size(120, 22)
        Me.txtlastname.TabIndex = 5
        '
        'txtOtherNames
        '
        Me.txtOtherNames.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOtherNames.Location = New System.Drawing.Point(534, 90)
        Me.txtOtherNames.Name = "txtOtherNames"
        Me.txtOtherNames.ReadOnly = True
        Me.txtOtherNames.Size = New System.Drawing.Size(96, 22)
        Me.txtOtherNames.TabIndex = 7
        '
        'GroupBiodata
        '
        Me.GroupBiodata.Controls.Add(Me.txtgender)
        Me.GroupBiodata.Controls.Add(Me.Label12)
        Me.GroupBiodata.Controls.Add(Me.schchoice)
        Me.GroupBiodata.Controls.Add(Me.Label9)
        Me.GroupBiodata.Controls.Add(Me.LblGender)
        Me.GroupBiodata.Controls.Add(Me.cmbexamseries)
        Me.GroupBiodata.Controls.Add(Me.cmbindex)
        Me.GroupBiodata.Controls.Add(Me.cmbCenter)
        Me.GroupBiodata.Controls.Add(Me.Label11)
        Me.GroupBiodata.Controls.Add(Me.DOB)
        Me.GroupBiodata.Controls.Add(Me.txtfirstname)
        Me.GroupBiodata.Controls.Add(Me.txtlastname)
        Me.GroupBiodata.Controls.Add(Me.txtOtherNames)
        Me.GroupBiodata.Controls.Add(Me.Label8)
        Me.GroupBiodata.Controls.Add(Me.Label7)
        Me.GroupBiodata.Controls.Add(Me.Label3)
        Me.GroupBiodata.Controls.Add(Me.Label4)
        Me.GroupBiodata.Controls.Add(Me.Label5)
        Me.GroupBiodata.Controls.Add(Me.Label6)
        Me.GroupBiodata.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBiodata.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBiodata.Location = New System.Drawing.Point(17, 149)
        Me.GroupBiodata.Name = "GroupBiodata"
        Me.GroupBiodata.Size = New System.Drawing.Size(845, 157)
        Me.GroupBiodata.TabIndex = 28
        Me.GroupBiodata.TabStop = False
        Me.GroupBiodata.Text = "Candidate Bio Data Details"
        '
        'txtgender
        '
        Me.txtgender.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtgender.Location = New System.Drawing.Point(725, 123)
        Me.txtgender.Name = "txtgender"
        Me.txtgender.ReadOnly = True
        Me.txtgender.Size = New System.Drawing.Size(83, 22)
        Me.txtgender.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(660, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 16)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Gender:"
        '
        'schchoice
        '
        Me.schchoice.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.schchoice.Location = New System.Drawing.Point(138, 124)
        Me.schchoice.Name = "schchoice"
        Me.schchoice.ReadOnly = True
        Me.schchoice.Size = New System.Drawing.Size(520, 22)
        Me.schchoice.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(17, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 16)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "School of Choice:"
        '
        'LblGender
        '
        Me.LblGender.AutoSize = True
        Me.LblGender.Location = New System.Drawing.Point(33, 127)
        Me.LblGender.Name = "LblGender"
        Me.LblGender.Size = New System.Drawing.Size(0, 19)
        Me.LblGender.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 16)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Last Name :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(323, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(262, 18)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "C a n d i d a t e   E n t r y   D e t a i l s"
        '
        'PrintDocument1
        '
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
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'txtexamyr
        '
        Me.txtexamyr.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtexamyr.ForeColor = System.Drawing.Color.MidnightBlue
        Me.txtexamyr.Location = New System.Drawing.Point(124, 62)
        Me.txtexamyr.Name = "txtexamyr"
        Me.txtexamyr.Size = New System.Drawing.Size(100, 26)
        Me.txtexamyr.TabIndex = 32
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(22, 70)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(96, 19)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "Exam Year:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(419, 53)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 74)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'frmPrintCanDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(878, 711)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtexamyr)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFilePath)
        Me.Controls.Add(Me.GroupSubjects)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBiodata)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPrintCanDetails"
        Me.Text = "Print Candidate Payment Details"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupSubjects.ResumeLayout(False)
        Me.GroupSubjects.PerformLayout()
        Me.GroupBiodata.ResumeLayout(False)
        Me.GroupBiodata.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents cmbexamseries As System.Windows.Forms.Label
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents cmbindex As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupSubjects As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbltotsubj As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCenter As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents DOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtfirstname As System.Windows.Forms.TextBox
    Friend WithEvents txtlastname As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherNames As System.Windows.Forms.TextBox
    Friend WithEvents GroupBiodata As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblsub9 As System.Windows.Forms.Label
    Friend WithEvents lblsub8 As System.Windows.Forms.Label
    Friend WithEvents lblsub7 As System.Windows.Forms.Label
    Friend WithEvents lblsub6 As System.Windows.Forms.Label
    Friend WithEvents lblsub5 As System.Windows.Forms.Label
    Friend WithEvents lblsub4 As System.Windows.Forms.Label
    Friend WithEvents lblsub3 As System.Windows.Forms.Label
    Friend WithEvents lblsub2 As System.Windows.Forms.Label
    Friend WithEvents lblsub1 As System.Windows.Forms.Label
    Friend WithEvents cmdprint As System.Windows.Forms.Button
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents LblGender As System.Windows.Forms.Label
    Friend WithEvents txtgender As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents schchoice As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtexamyr As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
