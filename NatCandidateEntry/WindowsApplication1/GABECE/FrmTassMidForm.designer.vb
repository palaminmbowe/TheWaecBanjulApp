<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTassMidForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTassMidForm))
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.Administrator = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateSubjectOfficerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListMarksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.BackupDatabaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UpdateUserLevelsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SubjectOfficer = New System.Windows.Forms.ToolStripMenuItem
        Me.CreateExaminer = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyExaminerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModifyMarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListMarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AllocatScriptsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Examiner = New System.Windows.Forms.ToolStripMenuItem
        Me.EnterMarksToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ListMarksToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.About = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutApplicationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ExitForms = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Administrator, Me.SubjectOfficer, Me.Examiner, Me.About, Me.ExitForms})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Padding = New System.Windows.Forms.Padding(7, 3, 0, 3)
        Me.MenuStrip.Size = New System.Drawing.Size(694, 25)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'Administrator
        '
        Me.Administrator.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateSubjectOfficerToolStripMenuItem, Me.ListMarksToolStripMenuItem1, Me.BackupDatabaseToolStripMenuItem, Me.UpdateUserLevelsToolStripMenuItem, Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.Administrator.Name = "Administrator"
        Me.Administrator.Size = New System.Drawing.Size(133, 19)
        Me.Administrator.Text = "System Administrator"
        '
        'CreateSubjectOfficerToolStripMenuItem
        '
        Me.CreateSubjectOfficerToolStripMenuItem.Name = "CreateSubjectOfficerToolStripMenuItem"
        Me.CreateSubjectOfficerToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.CreateSubjectOfficerToolStripMenuItem.Text = "Create Subject Officer"
        '
        'ListMarksToolStripMenuItem1
        '
        Me.ListMarksToolStripMenuItem1.Name = "ListMarksToolStripMenuItem1"
        Me.ListMarksToolStripMenuItem1.Size = New System.Drawing.Size(189, 22)
        Me.ListMarksToolStripMenuItem1.Text = "List Marks"
        '
        'BackupDatabaseToolStripMenuItem
        '
        Me.BackupDatabaseToolStripMenuItem.Name = "BackupDatabaseToolStripMenuItem"
        Me.BackupDatabaseToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.BackupDatabaseToolStripMenuItem.Text = "Backup Database"
        '
        'UpdateUserLevelsToolStripMenuItem
        '
        Me.UpdateUserLevelsToolStripMenuItem.Name = "UpdateUserLevelsToolStripMenuItem"
        Me.UpdateUserLevelsToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.UpdateUserLevelsToolStripMenuItem.Text = "Update User Levels"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(189, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'SubjectOfficer
        '
        Me.SubjectOfficer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateExaminer, Me.ModifyExaminerToolStripMenuItem, Me.ModifyMarksToolStripMenuItem, Me.ListMarksToolStripMenuItem, Me.AllocatScriptsToolStripMenuItem})
        Me.SubjectOfficer.Name = "SubjectOfficer"
        Me.SubjectOfficer.Size = New System.Drawing.Size(97, 19)
        Me.SubjectOfficer.Text = "Subject Officer"
        Me.SubjectOfficer.Visible = False
        '
        'CreateExaminer
        '
        Me.CreateExaminer.Name = "CreateExaminer"
        Me.CreateExaminer.Size = New System.Drawing.Size(163, 22)
        Me.CreateExaminer.Text = "Create Examiner"
        '
        'ModifyExaminerToolStripMenuItem
        '
        Me.ModifyExaminerToolStripMenuItem.Name = "ModifyExaminerToolStripMenuItem"
        Me.ModifyExaminerToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ModifyExaminerToolStripMenuItem.Text = "Modify Examiner"
        '
        'ModifyMarksToolStripMenuItem
        '
        Me.ModifyMarksToolStripMenuItem.Name = "ModifyMarksToolStripMenuItem"
        Me.ModifyMarksToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ModifyMarksToolStripMenuItem.Text = "Modify Marks"
        '
        'ListMarksToolStripMenuItem
        '
        Me.ListMarksToolStripMenuItem.Name = "ListMarksToolStripMenuItem"
        Me.ListMarksToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.ListMarksToolStripMenuItem.Text = "List Marks"
        '
        'AllocatScriptsToolStripMenuItem
        '
        Me.AllocatScriptsToolStripMenuItem.Name = "AllocatScriptsToolStripMenuItem"
        Me.AllocatScriptsToolStripMenuItem.Size = New System.Drawing.Size(163, 22)
        Me.AllocatScriptsToolStripMenuItem.Text = "Allocate Scripts"
        '
        'Examiner
        '
        Me.Examiner.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnterMarksToolStripMenuItem1, Me.ListMarksToolStripMenuItem2})
        Me.Examiner.Name = "Examiner"
        Me.Examiner.Size = New System.Drawing.Size(67, 19)
        Me.Examiner.Text = "Examiner"
        Me.Examiner.Visible = False
        '
        'EnterMarksToolStripMenuItem1
        '
        Me.EnterMarksToolStripMenuItem1.Name = "EnterMarksToolStripMenuItem1"
        Me.EnterMarksToolStripMenuItem1.Size = New System.Drawing.Size(136, 22)
        Me.EnterMarksToolStripMenuItem1.Text = "Enter Marks"
        '
        'ListMarksToolStripMenuItem2
        '
        Me.ListMarksToolStripMenuItem2.Name = "ListMarksToolStripMenuItem2"
        Me.ListMarksToolStripMenuItem2.Size = New System.Drawing.Size(136, 22)
        Me.ListMarksToolStripMenuItem2.Text = "List Marks"
        '
        'About
        '
        Me.About.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutApplicationToolStripMenuItem})
        Me.About.Name = "About"
        Me.About.Size = New System.Drawing.Size(52, 19)
        Me.About.Text = "About"
        '
        'AboutApplicationToolStripMenuItem
        '
        Me.AboutApplicationToolStripMenuItem.Name = "AboutApplicationToolStripMenuItem"
        Me.AboutApplicationToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.AboutApplicationToolStripMenuItem.Text = "About Application"
        '
        'ExitForms
        '
        Me.ExitForms.Name = "ExitForms"
        Me.ExitForms.Size = New System.Drawing.Size(37, 19)
        Me.ExitForms.Text = "&Exit"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 429)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(694, 23)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "Current User : || "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Maroon
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Times New Roman", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.GreenYellow
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(114, 18)
        Me.ToolStripStatusLabel1.Text = "Current User : || "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 18)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(0, 18)
        '
        'FrmTassMidForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.GABECE_NAT.My.Resources.Resources.waec_logo_1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(694, 452)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTassMidForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitForms As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents About As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutApplicationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Administrator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMarksToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectOfficer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateExaminer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyMarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Examiner As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupDatabaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnterMarksToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMarksToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyExaminerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CreateSubjectOfficerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateUserLevelsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllocatScriptsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel

End Class
