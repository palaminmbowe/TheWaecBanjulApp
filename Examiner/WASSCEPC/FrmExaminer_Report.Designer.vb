<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExaminer_Report
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmExaminer_Report))
        Me.lblGenComments = New System.Windows.Forms.Label()
        Me.rtb_Gen_Comments = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblGenComments
        '
        Me.lblGenComments.AutoSize = True
        Me.lblGenComments.Location = New System.Drawing.Point(93, 37)
        Me.lblGenComments.Name = "lblGenComments"
        Me.lblGenComments.Size = New System.Drawing.Size(138, 13)
        Me.lblGenComments.TabIndex = 0
        Me.lblGenComments.Text = "1.  GENERAL COMMENTS"
        '
        'rtb_Gen_Comments
        '
        Me.rtb_Gen_Comments.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_Gen_Comments.Location = New System.Drawing.Point(12, 69)
        Me.rtb_Gen_Comments.Name = "rtb_Gen_Comments"
        Me.rtb_Gen_Comments.Size = New System.Drawing.Size(708, 194)
        Me.rtb_Gen_Comments.TabIndex = 1
        Me.rtb_Gen_Comments.Text = resources.GetString("rtb_Gen_Comments.Text")
        '
        'FrmExaminer_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 538)
        Me.Controls.Add(Me.rtb_Gen_Comments)
        Me.Controls.Add(Me.lblGenComments)
        Me.Name = "FrmExaminer_Report"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGenComments As System.Windows.Forms.Label
    Friend WithEvents rtb_Gen_Comments As System.Windows.Forms.RichTextBox
End Class
