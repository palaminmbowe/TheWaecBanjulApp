<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMarks
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMarks))
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSaveToServer = New System.Windows.Forms.Button()
        Me.btnPrintAllocation = New System.Windows.Forms.Button()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdChanges = New System.Windows.Forms.Button()
        Me.lblFilePath = New System.Windows.Forms.Label()
        Me.Lmesg = New System.Windows.Forms.Label()
        Me.Lmessage = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtExamYear = New System.Windows.Forms.TextBox()
        Me.CmbSubject = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbCenter = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbIndex = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.lblMaximumMark = New System.Windows.Forms.Label()
        Me.lblPaperType = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblPaperName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCandName = New System.Windows.Forms.TextBox()
        Me.txtMark = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ButtonMissingMark = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.chkbAbsent = New System.Windows.Forms.CheckBox()
        Me.timerSaveToDb = New System.Windows.Forms.Timer(Me.components)
        Me.SplitContainerBody = New System.Windows.Forms.SplitContainer()
        Me.SplitContainerInfo = New System.Windows.Forms.SplitContainer()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridViewFeedback = New System.Windows.Forms.DataGridView()
        Me.DataGridViewAllocated = New System.Windows.Forms.DataGridView()
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox()
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainerBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBody.Panel1.SuspendLayout()
        Me.SplitContainerBody.Panel2.SuspendLayout()
        Me.SplitContainerBody.SuspendLayout()
        CType(Me.SplitContainerInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerInfo.Panel1.SuspendLayout()
        Me.SplitContainerInfo.Panel2.SuspendLayout()
        Me.SplitContainerInfo.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridViewFeedback, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridViewAllocated, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel1.SuspendLayout()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdSearch
        '
        Me.cmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSearch.Location = New System.Drawing.Point(259, 34)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(115, 40)
        Me.cmdSearch.TabIndex = 10
        Me.cmdSearch.Text = "View Marks"
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSaveToServer)
        Me.GroupBox3.Controls.Add(Me.btnPrintAllocation)
        Me.GroupBox3.Controls.Add(Me.cmdSearch)
        Me.GroupBox3.Controls.Add(Me.cmdClose)
        Me.GroupBox3.Controls.Add(Me.cmdClear)
        Me.GroupBox3.Controls.Add(Me.cmdSave)
        Me.GroupBox3.Controls.Add(Me.cmdChanges)
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(3, 456)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(753, 104)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        '
        'btnSaveToServer
        '
        Me.btnSaveToServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveToServer.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveToServer.Location = New System.Drawing.Point(403, 26)
        Me.btnSaveToServer.Name = "btnSaveToServer"
        Me.btnSaveToServer.Size = New System.Drawing.Size(114, 57)
        Me.btnSaveToServer.TabIndex = 15
        Me.btnSaveToServer.Text = "Save"
        Me.btnSaveToServer.UseVisualStyleBackColor = True
        '
        'btnPrintAllocation
        '
        Me.btnPrintAllocation.Enabled = False
        Me.btnPrintAllocation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrintAllocation.Location = New System.Drawing.Point(540, 26)
        Me.btnPrintAllocation.Name = "btnPrintAllocation"
        Me.btnPrintAllocation.Size = New System.Drawing.Size(88, 57)
        Me.btnPrintAllocation.TabIndex = 14
        Me.btnPrintAllocation.Text = "Enter Irregular Candidate"
        Me.btnPrintAllocation.UseVisualStyleBackColor = True
        '
        'cmdClose
        '
        Me.cmdClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClose.Location = New System.Drawing.Point(660, 34)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(71, 40)
        Me.cmdClose.TabIndex = 12
        Me.cmdClose.Text = "Close "
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdClear.Location = New System.Drawing.Point(147, 34)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(106, 40)
        Me.cmdClear.TabIndex = 8
        Me.cmdClear.Text = "Clear Form"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.cmdSave.Enabled = False
        Me.cmdSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSave.ForeColor = System.Drawing.Color.White
        Me.cmdSave.Location = New System.Drawing.Point(15, 19)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(115, 71)
        Me.cmdSave.TabIndex = 7
        Me.cmdSave.Text = "Add Marks"
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'cmdChanges
        '
        Me.cmdChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdChanges.ForeColor = System.Drawing.SystemColors.Info
        Me.cmdChanges.Location = New System.Drawing.Point(21, 34)
        Me.cmdChanges.Name = "cmdChanges"
        Me.cmdChanges.Size = New System.Drawing.Size(106, 40)
        Me.cmdChanges.TabIndex = 13
        Me.cmdChanges.Text = "Save Changes"
        Me.cmdChanges.UseVisualStyleBackColor = True
        Me.cmdChanges.Visible = False
        '
        'lblFilePath
        '
        Me.lblFilePath.AutoSize = True
        Me.lblFilePath.Location = New System.Drawing.Point(574, 233)
        Me.lblFilePath.Name = "lblFilePath"
        Me.lblFilePath.Size = New System.Drawing.Size(0, 13)
        Me.lblFilePath.TabIndex = 19
        '
        'Lmesg
        '
        Me.Lmesg.AutoSize = True
        Me.Lmesg.Location = New System.Drawing.Point(489, 71)
        Me.Lmesg.Name = "Lmesg"
        Me.Lmesg.Size = New System.Drawing.Size(0, 13)
        Me.Lmesg.TabIndex = 26
        Me.Lmesg.Visible = False
        '
        'Lmessage
        '
        Me.Lmessage.AutoSize = True
        Me.Lmessage.Location = New System.Drawing.Point(513, 46)
        Me.Lmessage.Name = "Lmessage"
        Me.Lmessage.Size = New System.Drawing.Size(0, 13)
        Me.Lmessage.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(114, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 13)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "Exam Year"
        Me.Label10.Visible = False
        '
        'txtExamYear
        '
        Me.txtExamYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExamYear.Location = New System.Drawing.Point(181, 78)
        Me.txtExamYear.Name = "txtExamYear"
        Me.txtExamYear.Size = New System.Drawing.Size(69, 22)
        Me.txtExamYear.TabIndex = 7
        Me.txtExamYear.Visible = False
        '
        'CmbSubject
        '
        Me.CmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbSubject.FormattingEnabled = True
        Me.CmbSubject.Location = New System.Drawing.Point(76, 71)
        Me.CmbSubject.Name = "CmbSubject"
        Me.CmbSubject.Size = New System.Drawing.Size(652, 28)
        Me.CmbSubject.Sorted = True
        Me.CmbSubject.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmbSubject)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbCenter)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox1.Location = New System.Drawing.Point(3, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(750, 132)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Select Center, Candidate & Subject"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Subject"
        '
        'cmbCenter
        '
        Me.cmbCenter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCenter.FormattingEnabled = True
        Me.cmbCenter.Location = New System.Drawing.Point(76, 24)
        Me.cmbCenter.Name = "cmbCenter"
        Me.cmbCenter.Size = New System.Drawing.Size(652, 28)
        Me.cmbCenter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Center"
        '
        'cmbIndex
        '
        Me.cmbIndex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIndex.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbIndex.FormattingEnabled = True
        Me.cmbIndex.Location = New System.Drawing.Point(18, 53)
        Me.cmbIndex.Name = "cmbIndex"
        Me.cmbIndex.Size = New System.Drawing.Size(85, 39)
        Me.cmbIndex.Sorted = True
        Me.cmbIndex.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Index"
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(761, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(472, 106)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "M A R K   E N T R Y"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lblMaximumMark)
        Me.GroupBox5.Controls.Add(Me.lblPaperType)
        Me.GroupBox5.Controls.Add(Me.Label8)
        Me.GroupBox5.Controls.Add(Me.lblPaperName)
        Me.GroupBox5.ForeColor = System.Drawing.Color.Cornsilk
        Me.GroupBox5.Location = New System.Drawing.Point(6, 147)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(744, 100)
        Me.GroupBox5.TabIndex = 24
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "SELECTED PAPER"
        '
        'lblMaximumMark
        '
        Me.lblMaximumMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaximumMark.Location = New System.Drawing.Point(617, 35)
        Me.lblMaximumMark.Name = "lblMaximumMark"
        Me.lblMaximumMark.Size = New System.Drawing.Size(114, 59)
        Me.lblMaximumMark.TabIndex = 9
        Me.lblMaximumMark.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblPaperType
        '
        Me.lblPaperType.AutoEllipsis = True
        Me.lblPaperType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaperType.Location = New System.Drawing.Point(14, 56)
        Me.lblPaperType.Name = "lblPaperType"
        Me.lblPaperType.Size = New System.Drawing.Size(565, 24)
        Me.lblPaperType.TabIndex = 1
        Me.lblPaperType.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(635, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Maximum Mark"
        '
        'lblPaperName
        '
        Me.lblPaperName.AutoEllipsis = True
        Me.lblPaperName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaperName.Location = New System.Drawing.Point(14, 21)
        Me.lblPaperName.Name = "lblPaperName"
        Me.lblPaperName.Size = New System.Drawing.Size(554, 24)
        Me.lblPaperName.TabIndex = 0
        Me.lblPaperName.Text = "Label8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(375, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Candidate Name"
        '
        'txtCandName
        '
        Me.txtCandName.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCandName.Location = New System.Drawing.Point(109, 57)
        Me.txtCandName.Name = "txtCandName"
        Me.txtCandName.ReadOnly = True
        Me.txtCandName.Size = New System.Drawing.Size(619, 32)
        Me.txtCandName.TabIndex = 1
        '
        'txtMark
        '
        Me.txtMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMark.Location = New System.Drawing.Point(73, 107)
        Me.txtMark.MaxLength = 6
        Me.txtMark.Name = "txtMark"
        Me.txtMark.Size = New System.Drawing.Size(173, 56)
        Me.txtMark.TabIndex = 4
        Me.txtMark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 129)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "MARK"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.MidnightBlue
        Me.GroupBox2.Controls.Add(Me.ButtonMissingMark)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.chkbAbsent)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtMark)
        Me.GroupBox2.Controls.Add(Me.cmbIndex)
        Me.GroupBox2.Controls.Add(Me.txtCandName)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(3, 253)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(747, 197)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Enter Candidate Marks only after Selecting Subject"
        '
        'ButtonMissingMark
        '
        Me.ButtonMissingMark.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonMissingMark.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonMissingMark.Location = New System.Drawing.Point(565, 115)
        Me.ButtonMissingMark.Name = "ButtonMissingMark"
        Me.ButtonMissingMark.Size = New System.Drawing.Size(163, 56)
        Me.ButtonMissingMark.TabIndex = 16
        Me.ButtonMissingMark.Text = "REGISTER MISSING MARK"
        Me.ButtonMissingMark.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(55, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Enter marks in 3 digits please."
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.Button1.Location = New System.Drawing.Point(378, 95)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(179, 96)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Refresh"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'chkbAbsent
        '
        Me.chkbAbsent.AutoSize = True
        Me.chkbAbsent.Location = New System.Drawing.Point(252, 127)
        Me.chkbAbsent.Name = "chkbAbsent"
        Me.chkbAbsent.Size = New System.Drawing.Size(69, 17)
        Me.chkbAbsent.TabIndex = 7
        Me.chkbAbsent.Text = "ABSENT"
        Me.chkbAbsent.UseVisualStyleBackColor = True
        '
        'timerSaveToDb
        '
        Me.timerSaveToDb.Interval = 420000
        '
        'SplitContainerBody
        '
        Me.SplitContainerBody.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBody.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerBody.IsSplitterFixed = True
        Me.SplitContainerBody.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBody.Name = "SplitContainerBody"
        '
        'SplitContainerBody.Panel1
        '
        Me.SplitContainerBody.Panel1.Controls.Add(Me.GroupBox3)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.GroupBox5)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.GroupBox2)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.lblFilePath)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.Lmesg)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.Lmessage)
        '
        'SplitContainerBody.Panel2
        '
        Me.SplitContainerBody.Panel2.Controls.Add(Me.SplitContainerInfo)
        Me.SplitContainerBody.Size = New System.Drawing.Size(1233, 568)
        Me.SplitContainerBody.SplitterDistance = 761
        Me.SplitContainerBody.TabIndex = 27
        '
        'SplitContainerInfo
        '
        Me.SplitContainerInfo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerInfo.IsSplitterFixed = True
        Me.SplitContainerInfo.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerInfo.Name = "SplitContainerInfo"
        Me.SplitContainerInfo.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerInfo.Panel1
        '
        Me.SplitContainerInfo.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainerInfo.Panel2
        '
        Me.SplitContainerInfo.Panel2.Controls.Add(Me.rtbDisplay)
        Me.SplitContainerInfo.Size = New System.Drawing.Size(466, 566)
        Me.SplitContainerInfo.SplitterDistance = 154
        Me.SplitContainerInfo.TabIndex = 1
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridViewFeedback)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridViewAllocated)
        Me.SplitContainer1.Size = New System.Drawing.Size(466, 154)
        Me.SplitContainer1.SplitterDistance = 233
        Me.SplitContainer1.TabIndex = 0
        '
        'DataGridViewFeedback
        '
        Me.DataGridViewFeedback.AllowUserToOrderColumns = True
        Me.DataGridViewFeedback.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewFeedback.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewFeedback.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewFeedback.Name = "DataGridViewFeedback"
        Me.DataGridViewFeedback.ReadOnly = True
        Me.DataGridViewFeedback.Size = New System.Drawing.Size(233, 154)
        Me.DataGridViewFeedback.TabIndex = 0
        '
        'DataGridViewAllocated
        '
        Me.DataGridViewAllocated.AllowUserToOrderColumns = True
        Me.DataGridViewAllocated.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewAllocated.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridViewAllocated.Location = New System.Drawing.Point(0, 0)
        Me.DataGridViewAllocated.Name = "DataGridViewAllocated"
        Me.DataGridViewAllocated.ReadOnly = True
        Me.DataGridViewAllocated.Size = New System.Drawing.Size(229, 154)
        Me.DataGridViewAllocated.TabIndex = 1
        '
        'rtbDisplay
        '
        Me.rtbDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbDisplay.Location = New System.Drawing.Point(0, 0)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.ReadOnly = True
        Me.rtbDisplay.Size = New System.Drawing.Size(466, 408)
        Me.rtbDisplay.TabIndex = 0
        Me.rtbDisplay.Text = ""
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
        Me.scMain.Panel1.Controls.Add(Me.Panel1)
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.SplitContainerBody)
        Me.scMain.Size = New System.Drawing.Size(1237, 686)
        Me.scMain.SplitterDistance = 110
        Me.scMain.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.WAEC.My.Resources.Resources.header_890x100nobackgroundflag
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtExamYear)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1233, 106)
        Me.Panel1.TabIndex = 0
        '
        'frmMarks
        '
        Me.AcceptButton = Me.cmdSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(1237, 686)
        Me.Controls.Add(Me.scMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(1009, 725)
        Me.Name = "frmMarks"
        Me.ShowInTaskbar = False
        Me.Text = "E X A M I N E R S  M A R K S : : : EMS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainerBody.Panel1.ResumeLayout(False)
        Me.SplitContainerBody.Panel1.PerformLayout()
        Me.SplitContainerBody.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerBody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBody.ResumeLayout(False)
        Me.SplitContainerInfo.Panel1.ResumeLayout(False)
        Me.SplitContainerInfo.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerInfo.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridViewFeedback, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridViewAllocated, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.Panel1.ResumeLayout(False)
        Me.scMain.Panel2.ResumeLayout(False)
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdClose As System.Windows.Forms.Button
    Friend WithEvents cmdClear As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents lblFilePath As System.Windows.Forms.Label
    Friend WithEvents Lmesg As System.Windows.Forms.Label
    Friend WithEvents Lmessage As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtExamYear As System.Windows.Forms.TextBox
    Friend WithEvents CmbSubject As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbIndex As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCenter As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCandName As System.Windows.Forms.TextBox
    Friend WithEvents txtMark As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents chkbAbsent As System.Windows.Forms.CheckBox
    Friend WithEvents lblPaperName As System.Windows.Forms.Label
    Friend WithEvents lblPaperType As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdChanges As System.Windows.Forms.Button
    Friend WithEvents btnPrintAllocation As System.Windows.Forms.Button
    Friend WithEvents btnSaveToServer As System.Windows.Forms.Button
    Friend WithEvents lblMaximumMark As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents timerSaveToDb As System.Windows.Forms.Timer
    Friend WithEvents SplitContainerBody As System.Windows.Forms.SplitContainer
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents rtbDisplay As System.Windows.Forms.RichTextBox
    Friend WithEvents SplitContainerInfo As SplitContainer
    Friend WithEvents DataGridViewFeedback As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents ButtonMissingMark As Button
    Friend WithEvents DataGridViewAllocated As DataGridView
End Class
