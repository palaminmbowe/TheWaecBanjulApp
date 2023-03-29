<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNatTools
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
        Me.scMain = New System.Windows.Forms.SplitContainer()
        Me.scBody = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ListBoxUsers = New System.Windows.Forms.ListBox()
        Me.RadioButtonUser = New System.Windows.Forms.RadioButton()
        Me.RadioButton = New System.Windows.Forms.RadioButton()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.chNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSchoolNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSchoolName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.chSchoolTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.scRight = New System.Windows.Forms.SplitContainer()
        Me.rtbDisplay = New System.Windows.Forms.RichTextBox()
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scMain.Panel2.SuspendLayout()
        Me.scMain.SuspendLayout()
        CType(Me.scBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scBody.Panel1.SuspendLayout()
        Me.scBody.Panel2.SuspendLayout()
        Me.scBody.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.scRight, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scRight.Panel2.SuspendLayout()
        Me.scRight.SuspendLayout()
        Me.SuspendLayout()
        '
        'scMain
        '
        Me.scMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scMain.Location = New System.Drawing.Point(0, 0)
        Me.scMain.Name = "scMain"
        Me.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scMain.Panel1
        '
        Me.scMain.Panel1.BackgroundImage = Global.GABECE_NAT.My.Resources.Resources.header_890x100_no_background_flag
        Me.scMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        '
        'scMain.Panel2
        '
        Me.scMain.Panel2.Controls.Add(Me.scBody)
        Me.scMain.Size = New System.Drawing.Size(787, 448)
        Me.scMain.SplitterDistance = 105
        Me.scMain.TabIndex = 0
        '
        'scBody
        '
        Me.scBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scBody.Location = New System.Drawing.Point(0, 0)
        Me.scBody.Name = "scBody"
        '
        'scBody.Panel1
        '
        Me.scBody.Panel1.Controls.Add(Me.TabControl1)
        '
        'scBody.Panel2
        '
        Me.scBody.Panel2.Controls.Add(Me.scRight)
        Me.scBody.Size = New System.Drawing.Size(787, 339)
        Me.scBody.SplitterDistance = 571
        Me.scBody.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.HotTrack = True
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(571, 339)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.MidnightBlue
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(563, 313)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Personal"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ListBoxUsers)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButtonUser)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RadioButton)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(557, 307)
        Me.SplitContainer1.SplitterDistance = 148
        Me.SplitContainer1.TabIndex = 0
        '
        'ListBoxUsers
        '
        Me.ListBoxUsers.FormattingEnabled = True
        Me.ListBoxUsers.Location = New System.Drawing.Point(5, 74)
        Me.ListBoxUsers.Name = "ListBoxUsers"
        Me.ListBoxUsers.Size = New System.Drawing.Size(140, 134)
        Me.ListBoxUsers.TabIndex = 2
        Me.ListBoxUsers.Visible = False
        '
        'RadioButtonUser
        '
        Me.RadioButtonUser.AutoSize = True
        Me.RadioButtonUser.Location = New System.Drawing.Point(20, 51)
        Me.RadioButtonUser.Name = "RadioButtonUser"
        Me.RadioButtonUser.Size = New System.Drawing.Size(55, 17)
        Me.RadioButtonUser.TabIndex = 1
        Me.RadioButtonUser.TabStop = True
        Me.RadioButtonUser.Text = "Select"
        Me.RadioButtonUser.UseVisualStyleBackColor = True
        '
        'RadioButton
        '
        Me.RadioButton.AutoSize = True
        Me.RadioButton.Location = New System.Drawing.Point(20, 15)
        Me.RadioButton.Name = "RadioButton"
        Me.RadioButton.Size = New System.Drawing.Size(66, 17)
        Me.RadioButton.TabIndex = 0
        Me.RadioButton.TabStop = True
        Me.RadioButton.Text = "Show All"
        Me.RadioButton.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNo, Me.chSchoolNo, Me.chSchoolName, Me.chSchoolTotal})
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(405, 307)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'chNo
        '
        Me.chNo.Text = "No."
        Me.chNo.Width = 34
        '
        'chSchoolNo
        '
        Me.chSchoolNo.Text = "School No."
        Me.chSchoolNo.Width = 71
        '
        'chSchoolName
        '
        Me.chSchoolName.Text = "School Name"
        Me.chSchoolName.Width = 229
        '
        'chSchoolTotal
        '
        Me.chSchoolTotal.Text = "Total"
        Me.chSchoolTotal.Width = 64
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(563, 313)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Global"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'scRight
        '
        Me.scRight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.scRight.Location = New System.Drawing.Point(0, 0)
        Me.scRight.Name = "scRight"
        Me.scRight.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'scRight.Panel2
        '
        Me.scRight.Panel2.Controls.Add(Me.rtbDisplay)
        Me.scRight.Size = New System.Drawing.Size(212, 339)
        Me.scRight.SplitterDistance = 25
        Me.scRight.TabIndex = 0
        '
        'rtbDisplay
        '
        Me.rtbDisplay.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rtbDisplay.Location = New System.Drawing.Point(0, 0)
        Me.rtbDisplay.Name = "rtbDisplay"
        Me.rtbDisplay.Size = New System.Drawing.Size(212, 310)
        Me.rtbDisplay.TabIndex = 0
        Me.rtbDisplay.Text = ""
        '
        'frmNatTools
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.ClientSize = New System.Drawing.Size(787, 448)
        Me.Controls.Add(Me.scMain)
        Me.ForeColor = System.Drawing.Color.Gold
        Me.Name = "frmNatTools"
        Me.Text = "frmNatTools"
        Me.scMain.Panel2.ResumeLayout(False)
        CType(Me.scMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scMain.ResumeLayout(False)
        Me.scBody.Panel1.ResumeLayout(False)
        Me.scBody.Panel2.ResumeLayout(False)
        CType(Me.scBody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scBody.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.scRight.Panel2.ResumeLayout(False)
        CType(Me.scRight, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scRight.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents scMain As System.Windows.Forms.SplitContainer
    Friend WithEvents scBody As System.Windows.Forms.SplitContainer
    Friend WithEvents scRight As System.Windows.Forms.SplitContainer
    Friend WithEvents rtbDisplay As System.Windows.Forms.RichTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ListBoxUsers As ListBox
    Friend WithEvents RadioButtonUser As RadioButton
    Friend WithEvents RadioButton As RadioButton
    Friend WithEvents ListView1 As ListView
    Friend WithEvents chNo As ColumnHeader
    Friend WithEvents chSchoolNo As ColumnHeader
    Friend WithEvents chSchoolName As ColumnHeader
    Friend WithEvents chSchoolTotal As ColumnHeader
End Class
