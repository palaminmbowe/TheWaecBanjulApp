<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPost_Exam_Process
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPost_Exam_Process))
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CboExamYear = New System.Windows.Forms.ComboBox
        Me.CboCentCode = New System.Windows.Forms.ComboBox
        Me.Lmesg = New System.Windows.Forms.Label
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Regional = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button7 = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.cboSubjects = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(137, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Create Subj-By-Subj Entry"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Exam Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(213, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Centre No."
        '
        'CboExamYear
        '
        Me.CboExamYear.FormattingEnabled = True
        Me.CboExamYear.Location = New System.Drawing.Point(85, 158)
        Me.CboExamYear.Name = "CboExamYear"
        Me.CboExamYear.Size = New System.Drawing.Size(121, 21)
        Me.CboExamYear.TabIndex = 7
        '
        'CboCentCode
        '
        Me.CboCentCode.FormattingEnabled = True
        Me.CboCentCode.Location = New System.Drawing.Point(287, 158)
        Me.CboCentCode.Name = "CboCentCode"
        Me.CboCentCode.Size = New System.Drawing.Size(121, 21)
        Me.CboCentCode.TabIndex = 8
        '
        'Lmesg
        '
        Me.Lmesg.AutoSize = True
        Me.Lmesg.Location = New System.Drawing.Point(247, 137)
        Me.Lmesg.Name = "Lmesg"
        Me.Lmesg.Size = New System.Drawing.Size(39, 13)
        Me.Lmesg.TabIndex = 9
        Me.Lmesg.Text = "Label4"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(200, 240)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 26)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Create GABENTRY"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 240)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(161, 26)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Create Girls Entry"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Regional
        '
        Me.Regional.Location = New System.Drawing.Point(12, 301)
        Me.Regional.Name = "Regional"
        Me.Regional.Size = New System.Drawing.Size(161, 27)
        Me.Regional.TabIndex = 12
        Me.Regional.Text = "Girl Provident Fund By Region"
        Me.Regional.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(343, 240)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(220, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "(Select Exam Year to Create Entry File)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(343, 272)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "(Select Exam Year) "
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(12, 272)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(161, 23)
        Me.Button7.TabIndex = 18
        Me.Button7.Text = "Create Male Entry"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(247, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "THE WEST AFRICAN EXAMINATIONS COUNCIL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 104)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(188, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "GABECE POST-EXAM PROCESSING"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(250, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(72, 70)
        Me.PictureBox1.TabIndex = 138
        Me.PictureBox1.TabStop = False
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(200, 303)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(137, 23)
        Me.Button4.TabIndex = 139
        Me.Button4.Text = "Update Subject Entry"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'cboSubjects
        '
        Me.cboSubjects.FormattingEnabled = True
        Me.cboSubjects.Location = New System.Drawing.Point(228, 196)
        Me.cboSubjects.Name = "cboSubjects"
        Me.cboSubjects.Size = New System.Drawing.Size(121, 21)
        Me.cboSubjects.TabIndex = 141
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(154, 204)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 140
        Me.Label7.Text = "Subject Code:"
        '
        'FrmPost_Exam_Process
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(594, 404)
        Me.Controls.Add(Me.cboSubjects)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Regional)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Lmesg)
        Me.Controls.Add(Me.CboCentCode)
        Me.Controls.Add(Me.CboExamYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmPost_Exam_Process"
        Me.Text = "FrmCreateCanEntries"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CboExamYear As System.Windows.Forms.ComboBox
    Friend WithEvents CboCentCode As System.Windows.Forms.ComboBox
    Friend WithEvents Lmesg As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Regional As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents cboSubjects As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
