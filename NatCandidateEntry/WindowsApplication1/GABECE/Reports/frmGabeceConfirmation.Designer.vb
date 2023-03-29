<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGabeceConfirmation
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
        Me.crvGabeceConfirmation = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rptGabeceConfirmation21 = New GABECE_NAT.rptGabeceConfirmation2()
        Me.rptGabeceConfirmation31 = New GABECE_NAT.rptGabeceConfirmation3()
        Me.SuspendLayout()
        '
        'crvGabeceConfirmation
        '
        Me.crvGabeceConfirmation.ActiveViewIndex = 0
        Me.crvGabeceConfirmation.AutoScroll = True
        Me.crvGabeceConfirmation.AutoSize = True
        Me.crvGabeceConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.crvGabeceConfirmation.Cursor = System.Windows.Forms.Cursors.Default
        Me.crvGabeceConfirmation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.crvGabeceConfirmation.Location = New System.Drawing.Point(0, 0)
        Me.crvGabeceConfirmation.Name = "crvGabeceConfirmation"
        Me.crvGabeceConfirmation.ReportSource = Me.rptGabeceConfirmation31
        Me.crvGabeceConfirmation.Size = New System.Drawing.Size(1325, 474)
        Me.crvGabeceConfirmation.TabIndex = 0
        '
        'frmGabeceConfirmation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 474)
        Me.Controls.Add(Me.crvGabeceConfirmation)
        Me.Name = "frmGabeceConfirmation"
        Me.Text = "rptGabeceConfirmation"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents crvGabeceConfirmation As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rptGabeceConfirmation21 As GABECE_NAT.rptGabeceConfirmation2
    Friend WithEvents rptGabeceConfirmation31 As GABECE_NAT.rptGabeceConfirmation3
End Class
