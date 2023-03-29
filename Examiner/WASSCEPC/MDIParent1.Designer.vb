<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ADMINISTRATIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MARKSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyMarksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EXAMINERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubjectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QUERIESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarksEnteredToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarksOustandingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllOCATEPAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.C_E_REPORTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ABOUTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblVersion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tsslConnection = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ADMINISTRATIONToolStripMenuItem, Me.MARKSToolStripMenuItem, Me.EXAMINERToolStripMenuItem, Me.SubjectToolStripMenuItem, Me.QUERIESToolStripMenuItem, Me.AllOCATEPAToolStripMenuItem, Me.C_E_REPORTToolStripMenuItem, Me.ABOUTToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(904, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'ADMINISTRATIONToolStripMenuItem
        '
        Me.ADMINISTRATIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoginToolStripMenuItem, Me.LogoutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ADMINISTRATIONToolStripMenuItem.Name = "ADMINISTRATIONToolStripMenuItem"
        Me.ADMINISTRATIONToolStripMenuItem.Size = New System.Drawing.Size(117, 20)
        Me.ADMINISTRATIONToolStripMenuItem.Text = "ADMINISTRATION"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'MARKSToolStripMenuItem
        '
        Me.MARKSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMarksToolStripMenuItem, Me.ModifyMarksToolStripMenuItem})
        Me.MARKSToolStripMenuItem.Name = "MARKSToolStripMenuItem"
        Me.MARKSToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.MARKSToolStripMenuItem.Text = "MARKS"
        Me.MARKSToolStripMenuItem.Visible = False
        '
        'AddMarksToolStripMenuItem
        '
        Me.AddMarksToolStripMenuItem.Name = "AddMarksToolStripMenuItem"
        Me.AddMarksToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AddMarksToolStripMenuItem.Text = "Add Marks"
        Me.AddMarksToolStripMenuItem.Visible = False
        '
        'ModifyMarksToolStripMenuItem
        '
        Me.ModifyMarksToolStripMenuItem.Name = "ModifyMarksToolStripMenuItem"
        Me.ModifyMarksToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.ModifyMarksToolStripMenuItem.Text = "Modify Marks"
        Me.ModifyMarksToolStripMenuItem.Visible = False
        '
        'EXAMINERToolStripMenuItem
        '
        Me.EXAMINERToolStripMenuItem.Name = "EXAMINERToolStripMenuItem"
        Me.EXAMINERToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EXAMINERToolStripMenuItem.Text = "EXAMINER"
        Me.EXAMINERToolStripMenuItem.Visible = False
        '
        'SubjectToolStripMenuItem
        '
        Me.SubjectToolStripMenuItem.Name = "SubjectToolStripMenuItem"
        Me.SubjectToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.SubjectToolStripMenuItem.Text = "SUBJECT OFFICER"
        Me.SubjectToolStripMenuItem.Visible = False
        '
        'QUERIESToolStripMenuItem
        '
        Me.QUERIESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarksEnteredToolStripMenuItem, Me.MarksOustandingToolStripMenuItem})
        Me.QUERIESToolStripMenuItem.Name = "QUERIESToolStripMenuItem"
        Me.QUERIESToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.QUERIESToolStripMenuItem.Text = "QUERIES"
        Me.QUERIESToolStripMenuItem.Visible = False
        '
        'MarksEnteredToolStripMenuItem
        '
        Me.MarksEnteredToolStripMenuItem.Name = "MarksEnteredToolStripMenuItem"
        Me.MarksEnteredToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.MarksEnteredToolStripMenuItem.Text = "Marks Entered"
        '
        'MarksOustandingToolStripMenuItem
        '
        Me.MarksOustandingToolStripMenuItem.Name = "MarksOustandingToolStripMenuItem"
        Me.MarksOustandingToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.MarksOustandingToolStripMenuItem.Text = "Marks Oustanding"
        '
        'AllOCATEPAToolStripMenuItem
        '
        Me.AllOCATEPAToolStripMenuItem.Name = "AllOCATEPAToolStripMenuItem"
        Me.AllOCATEPAToolStripMenuItem.Size = New System.Drawing.Size(121, 20)
        Me.AllOCATEPAToolStripMenuItem.Text = "ALLOCATE PAPERS"
        Me.AllOCATEPAToolStripMenuItem.Visible = False
        '
        'C_E_REPORTToolStripMenuItem
        '
        Me.C_E_REPORTToolStripMenuItem.Name = "C_E_REPORTToolStripMenuItem"
        Me.C_E_REPORTToolStripMenuItem.Size = New System.Drawing.Size(157, 20)
        Me.C_E_REPORTToolStripMenuItem.Text = "CHIEF EXAMINER REPORT"
        Me.C_E_REPORTToolStripMenuItem.Visible = False
        '
        'ABOUTToolStripMenuItem
        '
        Me.ABOUTToolStripMenuItem.Name = "ABOUTToolStripMenuItem"
        Me.ABOUTToolStripMenuItem.Size = New System.Drawing.Size(58, 20)
        Me.ABOUTToolStripMenuItem.Text = "ABOUT"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel, Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.lblVersion, Me.tsslConnection, Me.ToolStripProgressBar1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(904, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(91, 17)
        Me.ToolStripStatusLabel.Text = "Current User : || "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel1.Text = " "
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.AutoSize = False
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(121, 17)
        '
        'lblVersion
        '
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(121, 17)
        Me.lblVersion.Text = "ToolStripStatusLabel3"
        '
        'tsslConnection
        '
        Me.tsslConnection.AutoSize = False
        Me.tsslConnection.BackColor = System.Drawing.Color.Transparent
        Me.tsslConnection.Name = "tsslConnection"
        Me.tsslConnection.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tsslConnection.Size = New System.Drawing.Size(100, 17)
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(300, 16)
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkCyan
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(904, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "THE WEST AFRICAN EXAMINATIONS COUNCIL - THE GAMBIA      : : :  EXAMINERS MARK SHE" & _
    "ET"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ADMINISTRATIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MARKSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyMarksToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ABOUTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EXAMINERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QUERIESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubjectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllOCATEPAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MarksEnteredToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MarksOustandingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblVersion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents C_E_REPORTToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsslConnection As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar

End Class
