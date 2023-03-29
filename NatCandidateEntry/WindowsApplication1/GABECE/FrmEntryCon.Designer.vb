<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEntryCon
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
        Me.lblCentCode = New System.Windows.Forms.Label
        Me.DGCandEntry = New System.Windows.Forms.DataGridView
        Me.lblConfirmation = New System.Windows.Forms.Label
        Me.lblInstructions = New System.Windows.Forms.Label
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.CmdModify = New System.Windows.Forms.Button
        Me.CmdNext = New System.Windows.Forms.Button
        Me.CmdFirst = New System.Windows.Forms.Button
        Me.CmdLast = New System.Windows.Forms.Button
        Me.CmdPrev = New System.Windows.Forms.Button
        Me.txtLname = New System.Windows.Forms.TextBox
        Me.txtCandNo = New System.Windows.Forms.TextBox
        Me.lblCandNo = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblSubj1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.txtDOB = New System.Windows.Forms.TextBox
        Me.txtSchofChc = New System.Windows.Forms.TextBox
        Me.txtsub3 = New System.Windows.Forms.TextBox
        Me.txtsub1 = New System.Windows.Forms.TextBox
        Me.txtsub2 = New System.Windows.Forms.TextBox
        Me.txtsex = New System.Windows.Forms.TextBox
        Me.txtsub8 = New System.Windows.Forms.TextBox
        Me.txtsub7 = New System.Windows.Forms.TextBox
        Me.txtsub6 = New System.Windows.Forms.TextBox
        Me.txtsub5 = New System.Windows.Forms.TextBox
        Me.txtsub4 = New System.Windows.Forms.TextBox
        Me.txtsub9 = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.txtNoofSubs = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CmdExit = New System.Windows.Forms.Button
        CType(Me.DGCandEntry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCentCode
        '
        Me.txtCentCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCentCode.Location = New System.Drawing.Point(79, 158)
        Me.txtCentCode.Name = "txtCentCode"
        Me.txtCentCode.Size = New System.Drawing.Size(100, 22)
        Me.txtCentCode.TabIndex = 0
        '
        'lblCentCode
        '
        Me.lblCentCode.AutoSize = True
        Me.lblCentCode.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCentCode.Location = New System.Drawing.Point(76, 127)
        Me.lblCentCode.Name = "lblCentCode"
        Me.lblCentCode.Size = New System.Drawing.Size(75, 15)
        Me.lblCentCode.TabIndex = 0
        Me.lblCentCode.Text = "Center Code"
        '
        'DGCandEntry
        '
        Me.DGCandEntry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGCandEntry.Location = New System.Drawing.Point(79, 374)
        Me.DGCandEntry.Name = "DGCandEntry"
        Me.DGCandEntry.Size = New System.Drawing.Size(762, 77)
        Me.DGCandEntry.TabIndex = 2
        '
        'lblConfirmation
        '
        Me.lblConfirmation.AutoSize = True
        Me.lblConfirmation.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConfirmation.Location = New System.Drawing.Point(341, 64)
        Me.lblConfirmation.Name = "lblConfirmation"
        Me.lblConfirmation.Size = New System.Drawing.Size(171, 19)
        Me.lblConfirmation.TabIndex = 0
        Me.lblConfirmation.Text = "Confirmation of Entrires"
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(77, 97)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(301, 17)
        Me.lblInstructions.TabIndex = 0
        Me.lblInstructions.Text = "Instructions:  Enter Center Code to Proceed"
        '
        'CmdPrint
        '
        Me.CmdPrint.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.Location = New System.Drawing.Point(457, 457)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(74, 27)
        Me.CmdPrint.TabIndex = 20
        Me.CmdPrint.Text = "Print "
        Me.CmdPrint.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(693, 12)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'CmdModify
        '
        Me.CmdModify.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdModify.Location = New System.Drawing.Point(369, 456)
        Me.CmdModify.Name = "CmdModify"
        Me.CmdModify.Size = New System.Drawing.Size(75, 25)
        Me.CmdModify.TabIndex = 19
        Me.CmdModify.Text = "Modify"
        Me.CmdModify.UseVisualStyleBackColor = True
        '
        'CmdNext
        '
        Me.CmdNext.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNext.Location = New System.Drawing.Point(369, 502)
        Me.CmdNext.Name = "CmdNext"
        Me.CmdNext.Size = New System.Drawing.Size(75, 25)
        Me.CmdNext.TabIndex = 22
        Me.CmdNext.Text = "Next"
        Me.CmdNext.UseVisualStyleBackColor = True
        '
        'CmdFirst
        '
        Me.CmdFirst.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdFirst.Location = New System.Drawing.Point(279, 502)
        Me.CmdFirst.Name = "CmdFirst"
        Me.CmdFirst.Size = New System.Drawing.Size(75, 25)
        Me.CmdFirst.TabIndex = 21
        Me.CmdFirst.Text = "First"
        Me.CmdFirst.UseVisualStyleBackColor = True
        '
        'CmdLast
        '
        Me.CmdLast.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLast.Location = New System.Drawing.Point(544, 502)
        Me.CmdLast.Name = "CmdLast"
        Me.CmdLast.Size = New System.Drawing.Size(74, 25)
        Me.CmdLast.TabIndex = 24
        Me.CmdLast.Text = "Last"
        Me.CmdLast.UseVisualStyleBackColor = True
        '
        'CmdPrev
        '
        Me.CmdPrev.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrev.Location = New System.Drawing.Point(457, 502)
        Me.CmdPrev.Name = "CmdPrev"
        Me.CmdPrev.Size = New System.Drawing.Size(74, 25)
        Me.CmdPrev.TabIndex = 23
        Me.CmdPrev.Text = "Previous"
        Me.CmdPrev.UseVisualStyleBackColor = True
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(80, 217)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(210, 22)
        Me.txtLname.TabIndex = 4
        '
        'txtCandNo
        '
        Me.txtCandNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCandNo.Location = New System.Drawing.Point(196, 158)
        Me.txtCandNo.Name = "txtCandNo"
        Me.txtCandNo.Size = New System.Drawing.Size(94, 22)
        Me.txtCandNo.TabIndex = 1
        '
        'lblCandNo
        '
        Me.lblCandNo.AutoSize = True
        Me.lblCandNo.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCandNo.Location = New System.Drawing.Point(187, 130)
        Me.lblCandNo.Name = "lblCandNo"
        Me.lblCandNo.Size = New System.Drawing.Size(108, 15)
        Me.lblCandNo.TabIndex = 42
        Me.lblCandNo.Text = "Candidate Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(81, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 15)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(322, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 15)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(322, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 15)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(447, 133)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 15)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "School of Choice"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(541, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 15)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Sex"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(541, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Subject 7"
        '
        'lblSubj1
        '
        Me.lblSubj1.AutoSize = True
        Me.lblSubj1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubj1.Location = New System.Drawing.Point(77, 265)
        Me.lblSubj1.Name = "lblSubj1"
        Me.lblSubj1.Size = New System.Drawing.Size(58, 15)
        Me.lblSubj1.TabIndex = 49
        Me.lblSubj1.Text = "Subject 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(77, 300)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 50
        Me.Label10.Text = "Subject 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(82, 337)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 51
        Me.Label11.Text = "Subject 3"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(318, 269)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 15)
        Me.Label12.TabIndex = 52
        Me.Label12.Text = "Subject 4"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(318, 307)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Subject 5"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(318, 341)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(58, 15)
        Me.Label14.TabIndex = 54
        Me.Label14.Text = "Subject 6"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(541, 314)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(58, 15)
        Me.Label15.TabIndex = 55
        Me.Label15.Text = "Subject 8"
        '
        'txtFname
        '
        Me.txtFname.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFname.Location = New System.Drawing.Point(325, 213)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(206, 22)
        Me.txtFname.TabIndex = 5
        '
        'txtDOB
        '
        Me.txtDOB.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDOB.Location = New System.Drawing.Point(325, 158)
        Me.txtDOB.Name = "txtDOB"
        Me.txtDOB.Size = New System.Drawing.Size(100, 22)
        Me.txtDOB.TabIndex = 2
        '
        'txtSchofChc
        '
        Me.txtSchofChc.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSchofChc.Location = New System.Drawing.Point(450, 158)
        Me.txtSchofChc.Name = "txtSchofChc"
        Me.txtSchofChc.Size = New System.Drawing.Size(100, 22)
        Me.txtSchofChc.TabIndex = 3
        '
        'txtsub3
        '
        Me.txtsub3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub3.Location = New System.Drawing.Point(143, 334)
        Me.txtsub3.Name = "txtsub3"
        Me.txtsub3.Size = New System.Drawing.Size(86, 22)
        Me.txtsub3.TabIndex = 9
        '
        'txtsub1
        '
        Me.txtsub1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub1.Location = New System.Drawing.Point(143, 262)
        Me.txtsub1.Name = "txtsub1"
        Me.txtsub1.Size = New System.Drawing.Size(86, 22)
        Me.txtsub1.TabIndex = 7
        '
        'txtsub2
        '
        Me.txtsub2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub2.Location = New System.Drawing.Point(143, 300)
        Me.txtsub2.Name = "txtsub2"
        Me.txtsub2.Size = New System.Drawing.Size(86, 22)
        Me.txtsub2.TabIndex = 8
        '
        'txtsex
        '
        Me.txtsex.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsex.Location = New System.Drawing.Point(544, 213)
        Me.txtsex.Name = "txtsex"
        Me.txtsex.Size = New System.Drawing.Size(44, 22)
        Me.txtsex.TabIndex = 6
        '
        'txtsub8
        '
        Me.txtsub8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub8.Location = New System.Drawing.Point(618, 307)
        Me.txtsub8.Name = "txtsub8"
        Me.txtsub8.Size = New System.Drawing.Size(78, 22)
        Me.txtsub8.TabIndex = 15
        '
        'txtsub7
        '
        Me.txtsub7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub7.Location = New System.Drawing.Point(618, 262)
        Me.txtsub7.Name = "txtsub7"
        Me.txtsub7.Size = New System.Drawing.Size(78, 22)
        Me.txtsub7.TabIndex = 14
        '
        'txtsub6
        '
        Me.txtsub6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub6.Location = New System.Drawing.Point(386, 341)
        Me.txtsub6.Name = "txtsub6"
        Me.txtsub6.Size = New System.Drawing.Size(74, 22)
        Me.txtsub6.TabIndex = 12
        '
        'txtsub5
        '
        Me.txtsub5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub5.Location = New System.Drawing.Point(386, 307)
        Me.txtsub5.Name = "txtsub5"
        Me.txtsub5.Size = New System.Drawing.Size(74, 22)
        Me.txtsub5.TabIndex = 11
        '
        'txtsub4
        '
        Me.txtsub4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub4.Location = New System.Drawing.Point(384, 262)
        Me.txtsub4.Name = "txtsub4"
        Me.txtsub4.Size = New System.Drawing.Size(76, 22)
        Me.txtsub4.TabIndex = 10
        '
        'txtsub9
        '
        Me.txtsub9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsub9.Location = New System.Drawing.Point(618, 346)
        Me.txtsub9.Name = "txtsub9"
        Me.txtsub9.Size = New System.Drawing.Size(78, 22)
        Me.txtsub9.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(541, 349)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 15)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Subject 9"
        '
        'CmdSearch
        '
        Me.CmdSearch.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSearch.Location = New System.Drawing.Point(279, 457)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(75, 23)
        Me.CmdSearch.TabIndex = 18
        Me.CmdSearch.Text = "Search"
        Me.CmdSearch.UseVisualStyleBackColor = True
        '
        'txtNoofSubs
        '
        Me.txtNoofSubs.Location = New System.Drawing.Point(733, 312)
        Me.txtNoofSubs.Name = "txtNoofSubs"
        Me.txtNoofSubs.Size = New System.Drawing.Size(44, 20)
        Me.txtNoofSubs.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(730, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 74
        Me.Label1.Text = "No of Subjects"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.GABECE_NAT.My.Resources.Resources.waec_logo_1
        Me.PictureBox1.Location = New System.Drawing.Point(682, 80)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(159, 176)
        Me.PictureBox1.TabIndex = 75
        Me.PictureBox1.TabStop = False
        '
        'CmdExit
        '
        Me.CmdExit.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdExit.Location = New System.Drawing.Point(544, 457)
        Me.CmdExit.Name = "CmdExit"
        Me.CmdExit.Size = New System.Drawing.Size(75, 27)
        Me.CmdExit.TabIndex = 76
        Me.CmdExit.Text = "Exit"
        Me.CmdExit.UseVisualStyleBackColor = True
        '
        'FrmEntryCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ClientSize = New System.Drawing.Size(916, 564)
        Me.Controls.Add(Me.CmdExit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNoofSubs)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.txtsub9)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtsub4)
        Me.Controls.Add(Me.txtsub5)
        Me.Controls.Add(Me.txtsub6)
        Me.Controls.Add(Me.txtsub7)
        Me.Controls.Add(Me.txtsub8)
        Me.Controls.Add(Me.txtsex)
        Me.Controls.Add(Me.txtsub2)
        Me.Controls.Add(Me.txtsub1)
        Me.Controls.Add(Me.txtsub3)
        Me.Controls.Add(Me.txtSchofChc)
        Me.Controls.Add(Me.txtDOB)
        Me.Controls.Add(Me.txtFname)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lblSubj1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCandNo)
        Me.Controls.Add(Me.txtCandNo)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.CmdNext)
        Me.Controls.Add(Me.CmdFirst)
        Me.Controls.Add(Me.CmdLast)
        Me.Controls.Add(Me.CmdPrev)
        Me.Controls.Add(Me.CmdModify)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.CmdPrint)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblConfirmation)
        Me.Controls.Add(Me.DGCandEntry)
        Me.Controls.Add(Me.lblCentCode)
        Me.Controls.Add(Me.txtCentCode)
        Me.Name = "FrmEntryCon"
        Me.Text = "Confirmation Of Entries"
        CType(Me.DGCandEntry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCentCode As System.Windows.Forms.TextBox
    Friend WithEvents lblCentCode As System.Windows.Forms.Label
    Friend WithEvents lblConfirmation As System.Windows.Forms.Label
    Friend WithEvents lblInstructions As System.Windows.Forms.Label
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdModify As System.Windows.Forms.Button
    Friend WithEvents CmdNext As System.Windows.Forms.Button
    Friend WithEvents CmdFirst As System.Windows.Forms.Button
    Friend WithEvents CmdLast As System.Windows.Forms.Button
    Friend WithEvents CmdPrev As System.Windows.Forms.Button
    Friend WithEvents DGCandEntry As System.Windows.Forms.DataGridView
    Friend WithEvents txtLname As System.Windows.Forms.TextBox
    Friend WithEvents txtCandNo As System.Windows.Forms.TextBox
    Friend WithEvents lblCandNo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblSubj1 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents txtDOB As System.Windows.Forms.TextBox
    Friend WithEvents txtSchofChc As System.Windows.Forms.TextBox
    Friend WithEvents txtsub3 As System.Windows.Forms.TextBox
    Friend WithEvents txtsub1 As System.Windows.Forms.TextBox
    Friend WithEvents txtsub2 As System.Windows.Forms.TextBox
    Friend WithEvents txtsex As System.Windows.Forms.TextBox
    Friend WithEvents txtsub8 As System.Windows.Forms.TextBox
    Friend WithEvents txtsub7 As System.Windows.Forms.TextBox
    Friend WithEvents txtsub6 As System.Windows.Forms.TextBox
    Friend WithEvents txtsub5 As System.Windows.Forms.TextBox
    Friend WithEvents txtsub4 As System.Windows.Forms.TextBox
    Friend WithEvents txtsub9 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtNoofSubs As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CmdExit As System.Windows.Forms.Button
End Class
