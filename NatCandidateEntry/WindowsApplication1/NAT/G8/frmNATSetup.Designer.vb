<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNATSetup
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
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.ListBoxCentreNo = New System.Windows.Forms.ListBox()
        Me.cBoxCentreNotListed = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCentName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCentNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbLocation = New System.Windows.Forms.GroupBox()
        Me.rbRural = New System.Windows.Forms.RadioButton()
        Me.rbUrban = New System.Windows.Forms.RadioButton()
        Me.gbOwner = New System.Windows.Forms.GroupBox()
        Me.rbMission = New System.Windows.Forms.RadioButton()
        Me.rbPrivate = New System.Windows.Forms.RadioButton()
        Me.rbGovernment = New System.Windows.Forms.RadioButton()
        Me.CheckBoxConfirm = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCentAddress = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.gbLocation.SuspendLayout()
        Me.gbOwner.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(487, 497)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.BackColor = System.Drawing.Color.SkyBlue
        Me.OK_Button.Enabled = False
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        Me.OK_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.BackColor = System.Drawing.Color.SkyBlue
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(618, 52)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "NAT Entry Grade 8 Centre Setup"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(12, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(615, 22)
        Me.Label8.TabIndex = 67
        Me.Label8.Text = "Please select your school number from the list. If it is not in the list, please " & _
            "do enter it in space provided below." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 138.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 251.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.ListBoxCentreNo, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.cBoxCentreNotListed, 2, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(118, 86)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(413, 109)
        Me.TableLayoutPanel2.TabIndex = 68
        '
        'ListBoxCentreNo
        '
        Me.ListBoxCentreNo.FormattingEnabled = True
        Me.ListBoxCentreNo.Location = New System.Drawing.Point(3, 3)
        Me.ListBoxCentreNo.Name = "ListBoxCentreNo"
        Me.TableLayoutPanel2.SetRowSpan(Me.ListBoxCentreNo, 2)
        Me.ListBoxCentreNo.Size = New System.Drawing.Size(132, 95)
        Me.ListBoxCentreNo.TabIndex = 0
        '
        'cBoxCentreNotListed
        '
        Me.cBoxCentreNotListed.AutoSize = True
        Me.cBoxCentreNotListed.Dock = System.Windows.Forms.DockStyle.Left
        Me.cBoxCentreNotListed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cBoxCentreNotListed.ForeColor = System.Drawing.Color.White
        Me.cBoxCentreNotListed.Location = New System.Drawing.Point(165, 3)
        Me.cBoxCentreNotListed.Name = "cBoxCentreNotListed"
        Me.cBoxCentreNotListed.Size = New System.Drawing.Size(245, 69)
        Me.cBoxCentreNotListed.TabIndex = 1
        Me.cBoxCentreNotListed.Text = "Click here if your cetre is not listed!"
        Me.cBoxCentreNotListed.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.Label12, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label11, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label10, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label9, 2, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label6, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.txtCentName, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label3, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.txtCentNo, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label7, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.gbLocation, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.gbOwner, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.CheckBoxConfirm, 1, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.txtCentAddress, 1, 2)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(7, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.Padding = New System.Windows.Forms.Padding(5)
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(598, 265)
        Me.TableLayoutPanel3.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(340, 65)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(248, 30)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Address of the centre"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(340, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(248, 88)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "Is the school owned by the Government, a private or by Missionaries?"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(9, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(81, 88)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Owner:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(340, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(248, 48)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Are you located in the Urban or Rural area?"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(340, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(248, 30)
        Me.Label6.TabIndex = 76
        Me.Label6.Text = "Name of the centre"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(340, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(250, 30)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Five digit number, starts with 6, for example 61001"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCentName
        '
        Me.txtCentName.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCentName.Location = New System.Drawing.Point(96, 38)
        Me.txtCentName.Name = "txtCentName"
        Me.txtCentName.Size = New System.Drawing.Size(238, 20)
        Me.txtCentName.TabIndex = 74
        '
        'Label3
        '
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(8, 35)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Centre Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCentNo
        '
        Me.txtCentNo.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtCentNo.Location = New System.Drawing.Point(96, 8)
        Me.txtCentNo.Name = "txtCentNo"
        Me.txtCentNo.Size = New System.Drawing.Size(89, 20)
        Me.txtCentNo.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(8, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 70
        Me.Label1.Text = "Centre Number:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(9, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 48)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Location:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbLocation
        '
        Me.gbLocation.Controls.Add(Me.rbRural)
        Me.gbLocation.Controls.Add(Me.rbUrban)
        Me.gbLocation.Dock = System.Windows.Forms.DockStyle.Left
        Me.gbLocation.ForeColor = System.Drawing.Color.White
        Me.gbLocation.Location = New System.Drawing.Point(96, 98)
        Me.gbLocation.Name = "gbLocation"
        Me.gbLocation.Size = New System.Drawing.Size(238, 42)
        Me.gbLocation.TabIndex = 78
        Me.gbLocation.TabStop = False
        '
        'rbRural
        '
        Me.rbRural.AutoSize = True
        Me.rbRural.Location = New System.Drawing.Point(115, 15)
        Me.rbRural.Name = "rbRural"
        Me.rbRural.Size = New System.Drawing.Size(50, 17)
        Me.rbRural.TabIndex = 1
        Me.rbRural.TabStop = True
        Me.rbRural.Text = "Rural"
        Me.rbRural.UseVisualStyleBackColor = True
        '
        'rbUrban
        '
        Me.rbUrban.AutoSize = True
        Me.rbUrban.Location = New System.Drawing.Point(10, 15)
        Me.rbUrban.Name = "rbUrban"
        Me.rbUrban.Size = New System.Drawing.Size(54, 17)
        Me.rbUrban.TabIndex = 0
        Me.rbUrban.TabStop = True
        Me.rbUrban.Text = "Urban"
        Me.rbUrban.UseVisualStyleBackColor = True
        '
        'gbOwner
        '
        Me.gbOwner.Controls.Add(Me.rbMission)
        Me.gbOwner.Controls.Add(Me.rbPrivate)
        Me.gbOwner.Controls.Add(Me.rbGovernment)
        Me.gbOwner.ForeColor = System.Drawing.Color.White
        Me.gbOwner.Location = New System.Drawing.Point(96, 146)
        Me.gbOwner.Name = "gbOwner"
        Me.gbOwner.Size = New System.Drawing.Size(238, 82)
        Me.gbOwner.TabIndex = 81
        Me.gbOwner.TabStop = False
        '
        'rbMission
        '
        Me.rbMission.AutoSize = True
        Me.rbMission.Location = New System.Drawing.Point(7, 52)
        Me.rbMission.Name = "rbMission"
        Me.rbMission.Size = New System.Drawing.Size(60, 17)
        Me.rbMission.TabIndex = 2
        Me.rbMission.TabStop = True
        Me.rbMission.Text = "Mission"
        Me.rbMission.UseVisualStyleBackColor = True
        '
        'rbPrivate
        '
        Me.rbPrivate.AutoSize = True
        Me.rbPrivate.Location = New System.Drawing.Point(7, 34)
        Me.rbPrivate.Name = "rbPrivate"
        Me.rbPrivate.Size = New System.Drawing.Size(58, 17)
        Me.rbPrivate.TabIndex = 1
        Me.rbPrivate.TabStop = True
        Me.rbPrivate.Text = "Private"
        Me.rbPrivate.UseVisualStyleBackColor = True
        '
        'rbGovernment
        '
        Me.rbGovernment.AutoSize = True
        Me.rbGovernment.Location = New System.Drawing.Point(6, 16)
        Me.rbGovernment.Name = "rbGovernment"
        Me.rbGovernment.Size = New System.Drawing.Size(83, 17)
        Me.rbGovernment.TabIndex = 0
        Me.rbGovernment.TabStop = True
        Me.rbGovernment.Text = "Government"
        Me.rbGovernment.UseVisualStyleBackColor = True
        '
        'CheckBoxConfirm
        '
        Me.CheckBoxConfirm.AutoSize = True
        Me.TableLayoutPanel3.SetColumnSpan(Me.CheckBoxConfirm, 2)
        Me.CheckBoxConfirm.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CheckBoxConfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBoxConfirm.Location = New System.Drawing.Point(96, 235)
        Me.CheckBoxConfirm.Name = "CheckBoxConfirm"
        Me.CheckBoxConfirm.Size = New System.Drawing.Size(494, 22)
        Me.CheckBoxConfirm.TabIndex = 73
        Me.CheckBoxConfirm.Text = "The above details are correct for my centre. (Check to continue!)"
        Me.CheckBoxConfirm.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(8, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 20)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Address:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCentAddress
        '
        Me.txtCentAddress.Location = New System.Drawing.Point(96, 68)
        Me.txtCentAddress.Name = "txtCentAddress"
        Me.txtCentAddress.Size = New System.Drawing.Size(238, 20)
        Me.txtCentAddress.TabIndex = 84
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel3)
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(12, 201)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(621, 290)
        Me.GroupBox3.TabIndex = 72
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Confirm and Adjust Centre Details!"
        '
        'frmNATSetup
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MidnightBlue
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(645, 538)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNATSetup"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmNATSetup"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.gbLocation.ResumeLayout(False)
        Me.gbLocation.PerformLayout()
        Me.gbOwner.ResumeLayout(False)
        Me.gbOwner.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCentName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCentNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbLocation As System.Windows.Forms.GroupBox
    Friend WithEvents rbRural As System.Windows.Forms.RadioButton
    Friend WithEvents rbUrban As System.Windows.Forms.RadioButton
    Friend WithEvents gbOwner As System.Windows.Forms.GroupBox
    Friend WithEvents rbMission As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrivate As System.Windows.Forms.RadioButton
    Friend WithEvents rbGovernment As System.Windows.Forms.RadioButton
    Friend WithEvents ListBoxCentreNo As System.Windows.Forms.ListBox
    Friend WithEvents cBoxCentreNotListed As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxConfirm As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCentAddress As System.Windows.Forms.TextBox

End Class
