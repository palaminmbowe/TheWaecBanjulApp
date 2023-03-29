<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModerateCass
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
        Me.cmdCassModerate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmdCassModerate
        '
        Me.cmdCassModerate.Location = New System.Drawing.Point(101, 61)
        Me.cmdCassModerate.Name = "cmdCassModerate"
        Me.cmdCassModerate.Size = New System.Drawing.Size(269, 96)
        Me.cmdCassModerate.TabIndex = 0
        Me.cmdCassModerate.Text = "Moderate CASS"
        Me.cmdCassModerate.UseVisualStyleBackColor = True
        '
        'frmModerateCass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 266)
        Me.Controls.Add(Me.cmdCassModerate)
        Me.Name = "frmModerateCass"
        Me.Text = "frmModerateCass"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdCassModerate As System.Windows.Forms.Button
End Class
