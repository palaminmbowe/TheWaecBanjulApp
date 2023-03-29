<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPackingList
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
        Me.cmdPackingList = New System.Windows.Forms.Button
        Me.cmdExpandSubjects = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmdPackingListByPaper = New System.Windows.Forms.Button
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.cmdCentSubjects = New System.Windows.Forms.Button
        Me.cmdPerformance = New System.Windows.Forms.Button
        Me.cmdWassceStats = New System.Windows.Forms.Button
        Me.cmdReArrange = New System.Windows.Forms.Button
        Me.cmdViewPackBySubject = New System.Windows.Forms.Button
        Me.cmdViewPackByCenter = New System.Windows.Forms.Button
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdPackingList
        '
        Me.cmdPackingList.Location = New System.Drawing.Point(48, 13)
        Me.cmdPackingList.Name = "cmdPackingList"
        Me.cmdPackingList.Size = New System.Drawing.Size(162, 47)
        Me.cmdPackingList.TabIndex = 0
        Me.cmdPackingList.Text = "Create Packing List"
        Me.cmdPackingList.UseVisualStyleBackColor = True
        '
        'cmdExpandSubjects
        '
        Me.cmdExpandSubjects.Location = New System.Drawing.Point(48, 91)
        Me.cmdExpandSubjects.Name = "cmdExpandSubjects"
        Me.cmdExpandSubjects.Size = New System.Drawing.Size(162, 47)
        Me.cmdExpandSubjects.TabIndex = 1
        Me.cmdExpandSubjects.Text = "Expand Subjects File"
        Me.cmdExpandSubjects.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(48, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 47)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Create Packing List By Center"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdPackingListByPaper
        '
        Me.cmdPackingListByPaper.Location = New System.Drawing.Point(48, 239)
        Me.cmdPackingListByPaper.Name = "cmdPackingListByPaper"
        Me.cmdPackingListByPaper.Size = New System.Drawing.Size(162, 47)
        Me.cmdPackingListByPaper.TabIndex = 3
        Me.cmdPackingListByPaper.Text = "Create Packing List By Subject"
        Me.cmdPackingListByPaper.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdPackingList)
        Me.Panel1.Controls.Add(Me.cmdPackingListByPaper)
        Me.Panel1.Controls.Add(Me.cmdExpandSubjects)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(23, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(248, 321)
        Me.Panel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cmdCentSubjects)
        Me.Panel2.Controls.Add(Me.cmdPerformance)
        Me.Panel2.Controls.Add(Me.cmdWassceStats)
        Me.Panel2.Controls.Add(Me.cmdReArrange)
        Me.Panel2.Controls.Add(Me.cmdViewPackBySubject)
        Me.Panel2.Controls.Add(Me.cmdViewPackByCenter)
        Me.Panel2.Location = New System.Drawing.Point(425, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 322)
        Me.Panel2.TabIndex = 5
        '
        'cmdCentSubjects
        '
        Me.cmdCentSubjects.Location = New System.Drawing.Point(19, 278)
        Me.cmdCentSubjects.Name = "cmdCentSubjects"
        Me.cmdCentSubjects.Size = New System.Drawing.Size(162, 34)
        Me.cmdCentSubjects.TabIndex = 8
        Me.cmdCentSubjects.Text = "Create Subjects for Center"
        Me.cmdCentSubjects.UseVisualStyleBackColor = True
        '
        'cmdPerformance
        '
        Me.cmdPerformance.Location = New System.Drawing.Point(19, 229)
        Me.cmdPerformance.Name = "cmdPerformance"
        Me.cmdPerformance.Size = New System.Drawing.Size(162, 43)
        Me.cmdPerformance.TabIndex = 7
        Me.cmdPerformance.Text = "Center Performance"
        Me.cmdPerformance.UseVisualStyleBackColor = True
        '
        'cmdWassceStats
        '
        Me.cmdWassceStats.Location = New System.Drawing.Point(19, 174)
        Me.cmdWassceStats.Name = "cmdWassceStats"
        Me.cmdWassceStats.Size = New System.Drawing.Size(162, 43)
        Me.cmdWassceStats.TabIndex = 6
        Me.cmdWassceStats.Text = "WASSCE STATS"
        Me.cmdWassceStats.UseVisualStyleBackColor = True
        '
        'cmdReArrange
        '
        Me.cmdReArrange.Location = New System.Drawing.Point(20, 120)
        Me.cmdReArrange.Name = "cmdReArrange"
        Me.cmdReArrange.Size = New System.Drawing.Size(162, 43)
        Me.cmdReArrange.TabIndex = 5
        Me.cmdReArrange.Text = "ReArrange Results"
        Me.cmdReArrange.UseVisualStyleBackColor = True
        '
        'cmdViewPackBySubject
        '
        Me.cmdViewPackBySubject.Location = New System.Drawing.Point(20, 61)
        Me.cmdViewPackBySubject.Name = "cmdViewPackBySubject"
        Me.cmdViewPackBySubject.Size = New System.Drawing.Size(162, 47)
        Me.cmdViewPackBySubject.TabIndex = 4
        Me.cmdViewPackBySubject.Text = "View Packing List By Subject"
        Me.cmdViewPackBySubject.UseVisualStyleBackColor = True
        '
        'cmdViewPackByCenter
        '
        Me.cmdViewPackByCenter.Location = New System.Drawing.Point(20, 8)
        Me.cmdViewPackByCenter.Name = "cmdViewPackByCenter"
        Me.cmdViewPackByCenter.Size = New System.Drawing.Size(162, 47)
        Me.cmdViewPackByCenter.TabIndex = 3
        Me.cmdViewPackByCenter.Text = "View Packing List By Center"
        Me.cmdViewPackByCenter.UseVisualStyleBackColor = True
        '
        'frmPackingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 401)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmPackingList"
        Me.Text = "frmPackingList"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdPackingList As System.Windows.Forms.Button
    Friend WithEvents cmdExpandSubjects As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdPackingListByPaper As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents cmdViewPackBySubject As System.Windows.Forms.Button
    Friend WithEvents cmdViewPackByCenter As System.Windows.Forms.Button
    Friend WithEvents cmdReArrange As System.Windows.Forms.Button
    Friend WithEvents cmdWassceStats As System.Windows.Forms.Button
    Friend WithEvents cmdPerformance As System.Windows.Forms.Button
    Friend WithEvents cmdCentSubjects As System.Windows.Forms.Button
End Class
