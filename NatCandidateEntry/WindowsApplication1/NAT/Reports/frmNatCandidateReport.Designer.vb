<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNatCandidateReport
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
        Me.crvNat8Candidates = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptCandidates1 = New GABECE_NAT.rptCandidates()
        Me.SuspendLayout()
        '
        'crvNat8Candidates
        '
        Me.crvNat8Candidates.ActiveViewIndex = -1
        Me.crvNat8Candidates.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvNat8Candidates.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvNat8Candidates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvNat8Candidates.Location = New System.Drawing.Point(0, 0)
        Me.crvNat8Candidates.Name = "crvNat8Candidates"
        Me.crvNat8Candidates.Size = New System.Drawing.Size(937, 445)
        Me.crvNat8Candidates.TabIndex = 0
        '
        'frmNatCandidateReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 445)
        Me.Controls.Add(Me.crvNat8Candidates)
        Me.Name = "frmNatCandidateReport"
        Me.Text = "frmNatCandidateReport"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents crvNat8Candidates As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptCandidates1 As GABECE_NAT.rptCandidates
End Class
