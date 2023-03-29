namespace ReportsPrinting
{
    partial class frmTimeTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelTimetable = new System.Windows.Forms.Label();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.scBody = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNat = new System.Windows.Forms.Button();
            this.buttonGabecePc = new System.Windows.Forms.Button();
            this.buttonWasscePc = new System.Windows.Forms.Button();
            this.buttonGabeceSc = new System.Windows.Forms.Button();
            this.buttonWassceSc = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.examYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tadSubjectCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combinedPaperDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timetableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.waecCommonDataSet = new ReportsPrinting.WaecCommonDataSet();
            this.panelFontSize = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nupFontSize = new System.Windows.Forms.NumericUpDown();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.timetableTableAdapter = new ReportsPrinting.WaecCommonDataSetTableAdapters.TimetableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBody)).BeginInit();
            this.scBody.Panel1.SuspendLayout();
            this.scBody.Panel2.SuspendLayout();
            this.scBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waecCommonDataSet)).BeginInit();
            this.panelFontSize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFontSize)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.labelTimetable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(986, 620);
            this.splitContainer1.SplitterDistance = 68;
            this.splitContainer1.TabIndex = 0;
            // 
            // labelTimetable
            // 
            this.labelTimetable.AutoSize = true;
            this.labelTimetable.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimetable.ForeColor = System.Drawing.Color.White;
            this.labelTimetable.Location = new System.Drawing.Point(6, 15);
            this.labelTimetable.Name = "labelTimetable";
            this.labelTimetable.Size = new System.Drawing.Size(157, 37);
            this.labelTimetable.TabIndex = 0;
            this.labelTimetable.Text = "Timetable";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.scBody);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelFontSize);
            this.splitContainer2.Panel2.Controls.Add(this.buttonUpdate);
            this.splitContainer2.Size = new System.Drawing.Size(986, 548);
            this.splitContainer2.SplitterDistance = 473;
            this.splitContainer2.TabIndex = 0;
            // 
            // scBody
            // 
            this.scBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBody.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scBody.IsSplitterFixed = true;
            this.scBody.Location = new System.Drawing.Point(0, 0);
            this.scBody.Name = "scBody";
            // 
            // scBody.Panel1
            // 
            this.scBody.Panel1.Controls.Add(this.panel1);
            this.scBody.Panel1.Controls.Add(this.buttonNat);
            this.scBody.Panel1.Controls.Add(this.buttonGabecePc);
            this.scBody.Panel1.Controls.Add(this.buttonWasscePc);
            this.scBody.Panel1.Controls.Add(this.buttonGabeceSc);
            this.scBody.Panel1.Controls.Add(this.buttonWassceSc);
            // 
            // scBody.Panel2
            // 
            this.scBody.Panel2.Controls.Add(this.dataGridView1);
            this.scBody.Size = new System.Drawing.Size(986, 473);
            this.scBody.SplitterDistance = 169;
            this.scBody.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ReportsPrinting.Properties.Resources.WAEC_LOGO1;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(179, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 465);
            this.panel1.TabIndex = 1;
            // 
            // buttonNat
            // 
            this.buttonNat.Enabled = false;
            this.buttonNat.Location = new System.Drawing.Point(13, 203);
            this.buttonNat.Name = "buttonNat";
            this.buttonNat.Size = new System.Drawing.Size(150, 67);
            this.buttonNat.TabIndex = 0;
            this.buttonNat.Text = "NAT";
            this.buttonNat.UseVisualStyleBackColor = true;
            this.buttonNat.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonGabecePc
            // 
            this.buttonGabecePc.Enabled = false;
            this.buttonGabecePc.Location = new System.Drawing.Point(12, 401);
            this.buttonGabecePc.Name = "buttonGabecePc";
            this.buttonGabecePc.Size = new System.Drawing.Size(150, 67);
            this.buttonGabecePc.TabIndex = 0;
            this.buttonGabecePc.Text = "GABECE PC";
            this.buttonGabecePc.UseVisualStyleBackColor = true;
            this.buttonGabecePc.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonWasscePc
            // 
            this.buttonWasscePc.Enabled = false;
            this.buttonWasscePc.Location = new System.Drawing.Point(13, 302);
            this.buttonWasscePc.Name = "buttonWasscePc";
            this.buttonWasscePc.Size = new System.Drawing.Size(150, 67);
            this.buttonWasscePc.TabIndex = 0;
            this.buttonWasscePc.Text = "WASSCE PC";
            this.buttonWasscePc.UseVisualStyleBackColor = true;
            this.buttonWasscePc.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonGabeceSc
            // 
            this.buttonGabeceSc.Enabled = false;
            this.buttonGabeceSc.Location = new System.Drawing.Point(13, 104);
            this.buttonGabeceSc.Name = "buttonGabeceSc";
            this.buttonGabeceSc.Size = new System.Drawing.Size(150, 67);
            this.buttonGabeceSc.TabIndex = 0;
            this.buttonGabeceSc.Text = "GABECE SC";
            this.buttonGabeceSc.UseVisualStyleBackColor = true;
            this.buttonGabeceSc.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonWassceSc
            // 
            this.buttonWassceSc.Location = new System.Drawing.Point(12, 5);
            this.buttonWassceSc.Name = "buttonWassceSc";
            this.buttonWassceSc.Size = new System.Drawing.Size(150, 67);
            this.buttonWassceSc.TabIndex = 0;
            this.buttonWassceSc.Text = "WASSCE SC";
            this.buttonWassceSc.UseVisualStyleBackColor = true;
            this.buttonWassceSc.Click += new System.EventHandler(this.button_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.examYearDataGridViewTextBoxColumn,
            this.tadSubjectCodeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.combinedPaperDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.timetableBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(813, 473);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            // 
            // examYearDataGridViewTextBoxColumn
            // 
            this.examYearDataGridViewTextBoxColumn.DataPropertyName = "ExamYear";
            this.examYearDataGridViewTextBoxColumn.HeaderText = "ExamYear";
            this.examYearDataGridViewTextBoxColumn.Name = "examYearDataGridViewTextBoxColumn";
            this.examYearDataGridViewTextBoxColumn.ReadOnly = true;
            this.examYearDataGridViewTextBoxColumn.Width = 80;
            // 
            // tadSubjectCodeDataGridViewTextBoxColumn
            // 
            this.tadSubjectCodeDataGridViewTextBoxColumn.DataPropertyName = "TadSubjectCode";
            this.tadSubjectCodeDataGridViewTextBoxColumn.HeaderText = "TadSubjectCode";
            this.tadSubjectCodeDataGridViewTextBoxColumn.Name = "tadSubjectCodeDataGridViewTextBoxColumn";
            this.tadSubjectCodeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tadSubjectCodeDataGridViewTextBoxColumn.Width = 112;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateDataGridViewTextBoxColumn.Width = 55;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.startTimeDataGridViewTextBoxColumn.Width = 77;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            this.endTimeDataGridViewTextBoxColumn.ReadOnly = true;
            this.endTimeDataGridViewTextBoxColumn.Width = 74;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryDateDataGridViewTextBoxColumn.Width = 93;
            // 
            // combinedPaperDataGridViewCheckBoxColumn
            // 
            this.combinedPaperDataGridViewCheckBoxColumn.DataPropertyName = "CombinedPaper";
            this.combinedPaperDataGridViewCheckBoxColumn.HeaderText = "CombinedPaper";
            this.combinedPaperDataGridViewCheckBoxColumn.Name = "combinedPaperDataGridViewCheckBoxColumn";
            this.combinedPaperDataGridViewCheckBoxColumn.ReadOnly = true;
            this.combinedPaperDataGridViewCheckBoxColumn.Width = 88;
            // 
            // timetableBindingSource
            // 
            this.timetableBindingSource.DataMember = "Timetable";
            this.timetableBindingSource.DataSource = this.waecCommonDataSet;
            // 
            // waecCommonDataSet
            // 
            this.waecCommonDataSet.DataSetName = "WaecCommonDataSet";
            this.waecCommonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panelFontSize
            // 
            this.panelFontSize.Controls.Add(this.label1);
            this.panelFontSize.Controls.Add(this.nupFontSize);
            this.panelFontSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelFontSize.Location = new System.Drawing.Point(0, 0);
            this.panelFontSize.Name = "panelFontSize";
            this.panelFontSize.Size = new System.Drawing.Size(176, 71);
            this.panelFontSize.TabIndex = 3;
            this.panelFontSize.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font Size";
            // 
            // nupFontSize
            // 
            this.nupFontSize.AutoSize = true;
            this.nupFontSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nupFontSize.Location = new System.Drawing.Point(92, 36);
            this.nupFontSize.Name = "nupFontSize";
            this.nupFontSize.Size = new System.Drawing.Size(68, 26);
            this.nupFontSize.TabIndex = 1;
            this.nupFontSize.ValueChanged += new System.EventHandler(this.nupFontSize_ValueChanged);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(892, 0);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(94, 71);
            this.buttonUpdate.TabIndex = 0;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Visible = false;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // timetableTableAdapter
            // 
            this.timetableTableAdapter.ClearBeforeFill = true;
            // 
            // frmTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(986, 620);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmTimeTable";
            this.Text = "Exam Time Table";
            this.Load += new System.EventHandler(this.frmTimeTable_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.scBody.Panel1.ResumeLayout(false);
            this.scBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBody)).EndInit();
            this.scBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timetableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waecCommonDataSet)).EndInit();
            this.panelFontSize.ResumeLayout(false);
            this.panelFontSize.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupFontSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonUpdate;
        private WaecCommonDataSet waecCommonDataSet;
        private System.Windows.Forms.BindingSource timetableBindingSource;
        private WaecCommonDataSetTableAdapters.TimetableTableAdapter timetableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn examYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tadSubjectCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn combinedPaperDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tSDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label labelTimetable;
        private System.Windows.Forms.SplitContainer scBody;
        private System.Windows.Forms.Button buttonNat;
        private System.Windows.Forms.Button buttonGabecePc;
        private System.Windows.Forms.Button buttonWasscePc;
        private System.Windows.Forms.Button buttonGabeceSc;
        private System.Windows.Forms.Button buttonWassceSc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelFontSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nupFontSize;
    }
}