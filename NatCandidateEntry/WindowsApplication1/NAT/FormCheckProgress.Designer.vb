<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormCheckProgress
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.SplitContainerMain = New System.Windows.Forms.SplitContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitContainerBody = New System.Windows.Forms.SplitContainer()
        Me.ButtonLoad = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.QryNat3UsernamePcnameBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetNat3 = New GABECE_NAT.DataSetNat3()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ExamYearDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateKeyedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalCandidatesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QryNat3TotalByUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.QryNat3UsernamePcnameTableAdapter = New GABECE_NAT.DataSetNat3TableAdapters.qryNat3UsernamePcnameTableAdapter()
        Me.QryNat3TotalByUserTableAdapter = New GABECE_NAT.DataSetNat3TableAdapters.qryNat3TotalByUserTableAdapter()
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerMain.Panel1.SuspendLayout()
        Me.SplitContainerMain.Panel2.SuspendLayout()
        Me.SplitContainerMain.SuspendLayout()
        CType(Me.SplitContainerBody, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainerBody.Panel1.SuspendLayout()
        Me.SplitContainerBody.Panel2.SuspendLayout()
        Me.SplitContainerBody.SuspendLayout()
        CType(Me.QryNat3UsernamePcnameBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetNat3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QryNat3TotalByUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainerMain
        '
        Me.SplitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerMain.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerMain.Name = "SplitContainerMain"
        Me.SplitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainerMain.Panel1
        '
        Me.SplitContainerMain.Panel1.Controls.Add(Me.Label4)
        '
        'SplitContainerMain.Panel2
        '
        Me.SplitContainerMain.Panel2.Controls.Add(Me.SplitContainerBody)
        Me.SplitContainerMain.Size = New System.Drawing.Size(846, 606)
        Me.SplitContainerMain.SplitterDistance = 52
        Me.SplitContainerMain.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(846, 82)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Your Progress"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainerBody
        '
        Me.SplitContainerBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainerBody.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainerBody.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainerBody.Name = "SplitContainerBody"
        '
        'SplitContainerBody.Panel1
        '
        Me.SplitContainerBody.Panel1.Controls.Add(Me.ButtonLoad)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.ComboBox1)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainerBody.Panel1.Controls.Add(Me.Label1)
        '
        'SplitContainerBody.Panel2
        '
        Me.SplitContainerBody.Panel2.Controls.Add(Me.SplitContainer1)
        Me.SplitContainerBody.Size = New System.Drawing.Size(846, 550)
        Me.SplitContainerBody.SplitterDistance = 186
        Me.SplitContainerBody.TabIndex = 0
        '
        'ButtonLoad
        '
        Me.ButtonLoad.Enabled = False
        Me.ButtonLoad.Location = New System.Drawing.Point(14, 203)
        Me.ButtonLoad.Name = "ButtonLoad"
        Me.ButtonLoad.Size = New System.Drawing.Size(156, 38)
        Me.ButtonLoad.TabIndex = 3
        Me.ButtonLoad.Text = "Load"
        Me.ButtonLoad.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Enabled = False
        Me.DateTimePicker2.Location = New System.Drawing.Point(10, 155)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Location = New System.Drawing.Point(11, 89)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(160, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.Enabled = False
        Me.Label3.Location = New System.Drawing.Point(10, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 23)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "To"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.QryNat3UsernamePcnameBindingSource
        Me.ComboBox1.DisplayMember = "userName"
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(11, 28)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 21)
        Me.ComboBox1.TabIndex = 1
        Me.ComboBox1.ValueMember = "userName"
        '
        'QryNat3UsernamePcnameBindingSource
        '
        Me.QryNat3UsernamePcnameBindingSource.DataMember = "qryNat3UsernamePcname"
        Me.QryNat3UsernamePcnameBindingSource.DataSource = Me.DataSetNat3
        '
        'DataSetNat3
        '
        Me.DataSetNat3.DataSetName = "DataSetNat3"
        Me.DataSetNat3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.Enabled = False
        Me.Label2.Location = New System.Drawing.Point(11, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 23)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "From"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Chart1)
        Me.SplitContainer1.Size = New System.Drawing.Size(656, 550)
        Me.SplitContainer1.SplitterDistance = 167
        Me.SplitContainer1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ExamYearDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.DateKeyedDataGridViewTextBoxColumn, Me.TotalCandidatesDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.QryNat3TotalByUserBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(656, 167)
        Me.DataGridView1.TabIndex = 0
        '
        'ExamYearDataGridViewTextBoxColumn
        '
        Me.ExamYearDataGridViewTextBoxColumn.DataPropertyName = "ExamYear"
        Me.ExamYearDataGridViewTextBoxColumn.HeaderText = "ExamYear"
        Me.ExamYearDataGridViewTextBoxColumn.Name = "ExamYearDataGridViewTextBoxColumn"
        Me.ExamYearDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "userName"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "userName"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateKeyedDataGridViewTextBoxColumn
        '
        Me.DateKeyedDataGridViewTextBoxColumn.DataPropertyName = "DateKeyed"
        Me.DateKeyedDataGridViewTextBoxColumn.HeaderText = "DateKeyed"
        Me.DateKeyedDataGridViewTextBoxColumn.Name = "DateKeyedDataGridViewTextBoxColumn"
        Me.DateKeyedDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalCandidatesDataGridViewTextBoxColumn
        '
        Me.TotalCandidatesDataGridViewTextBoxColumn.DataPropertyName = "TotalCandidates"
        Me.TotalCandidatesDataGridViewTextBoxColumn.HeaderText = "TotalCandidates"
        Me.TotalCandidatesDataGridViewTextBoxColumn.Name = "TotalCandidatesDataGridViewTextBoxColumn"
        Me.TotalCandidatesDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QryNat3TotalByUserBindingSource
        '
        Me.QryNat3TotalByUserBindingSource.DataMember = "qryNat3TotalByUser"
        Me.QryNat3TotalByUserBindingSource.DataSource = Me.DataSetNat3
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(0, 0)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(656, 379)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        Title1.Name = "Title1"
        Me.Chart1.Titles.Add(Title1)
        '
        'QryNat3UsernamePcnameTableAdapter
        '
        Me.QryNat3UsernamePcnameTableAdapter.ClearBeforeFill = True
        '
        'QryNat3TotalByUserTableAdapter
        '
        Me.QryNat3TotalByUserTableAdapter.ClearBeforeFill = True
        '
        'FormCheckProgress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 606)
        Me.Controls.Add(Me.SplitContainerMain)
        Me.Name = "FormCheckProgress"
        Me.Text = "FormCheckProgress"
        Me.SplitContainerMain.Panel1.ResumeLayout(False)
        Me.SplitContainerMain.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerMain, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerMain.ResumeLayout(False)
        Me.SplitContainerBody.Panel1.ResumeLayout(False)
        Me.SplitContainerBody.Panel2.ResumeLayout(False)
        CType(Me.SplitContainerBody, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainerBody.ResumeLayout(False)
        CType(Me.QryNat3UsernamePcnameBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetNat3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QryNat3TotalByUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainerMain As SplitContainer
    Friend WithEvents SplitContainerBody As SplitContainer
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents Label4 As Label
    Friend WithEvents ButtonLoad As Button
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSetNat3 As DataSetNat3
    Friend WithEvents QryNat3UsernamePcnameBindingSource As BindingSource
    Friend WithEvents QryNat3UsernamePcnameTableAdapter As DataSetNat3TableAdapters.qryNat3UsernamePcnameTableAdapter
    Friend WithEvents QryNat3TotalByUserBindingSource As BindingSource
    Friend WithEvents QryNat3TotalByUserTableAdapter As DataSetNat3TableAdapters.qryNat3TotalByUserTableAdapter
    Friend WithEvents ExamYearDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateKeyedDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalCandidatesDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
