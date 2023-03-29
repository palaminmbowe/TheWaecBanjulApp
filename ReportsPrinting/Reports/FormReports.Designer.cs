
namespace ICTDUtilities.Reports
{
    partial class FormReports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxExamName = new System.Windows.Forms.ComboBox();
            this.buttonLoadReport = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.comboBoxExamYear = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.scBody = new System.Windows.Forms.SplitContainer();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.viewWPC1TimeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.examDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scReports = new System.Windows.Forms.SplitContainer();
            this.buttonViewReport = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBody)).BeginInit();
            this.scBody.Panel1.SuspendLayout();
            this.scBody.Panel2.SuspendLayout();
            this.scBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewWPC1TimeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scReports)).BeginInit();
            this.scReports.Panel1.SuspendLayout();
            this.scReports.Panel2.SuspendLayout();
            this.scReports.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.label1);
            this.scMain.Panel1.Controls.Add(this.comboBoxExamName);
            this.scMain.Panel1.Controls.Add(this.buttonLoadReport);
            this.scMain.Panel1.Controls.Add(this.label2);
            this.scMain.Panel1.Controls.Add(this.comboBoxReports);
            this.scMain.Panel1.Controls.Add(this.comboBoxExamYear);
            this.scMain.Panel1.Controls.Add(this.label3);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scBody);
            this.scMain.Size = new System.Drawing.Size(1314, 835);
            this.scMain.SplitterDistance = 81;
            this.scMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Name";
            // 
            // comboBoxExamName
            // 
            this.comboBoxExamName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExamName.FormattingEnabled = true;
            this.comboBoxExamName.Location = new System.Drawing.Point(8, 30);
            this.comboBoxExamName.Name = "comboBoxExamName";
            this.comboBoxExamName.Size = new System.Drawing.Size(180, 28);
            this.comboBoxExamName.TabIndex = 1;
            this.comboBoxExamName.SelectedIndexChanged += new System.EventHandler(this.comboBoxExamName_SelectedIndexChanged);
            // 
            // buttonLoadReport
            // 
            this.buttonLoadReport.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonLoadReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonLoadReport.Location = new System.Drawing.Point(945, 7);
            this.buttonLoadReport.Name = "buttonLoadReport";
            this.buttonLoadReport.Size = new System.Drawing.Size(98, 65);
            this.buttonLoadReport.TabIndex = 2;
            this.buttonLoadReport.Text = "&Load Report";
            this.buttonLoadReport.UseVisualStyleBackColor = false;
            this.buttonLoadReport.Click += new System.EventHandler(this.buttonLoadReport_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Exam Year";
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxReports.FormattingEnabled = true;
            this.comboBoxReports.Location = new System.Drawing.Point(488, 30);
            this.comboBoxReports.Name = "comboBoxReports";
            this.comboBoxReports.Size = new System.Drawing.Size(434, 28);
            this.comboBoxReports.TabIndex = 1;
            this.comboBoxReports.SelectedIndexChanged += new System.EventHandler(this.comboBoxReports_SelectedIndexChanged);
            // 
            // comboBoxExamYear
            // 
            this.comboBoxExamYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExamYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExamYear.FormattingEnabled = true;
            this.comboBoxExamYear.Location = new System.Drawing.Point(248, 30);
            this.comboBoxExamYear.Name = "comboBoxExamYear";
            this.comboBoxExamYear.Size = new System.Drawing.Size(180, 28);
            this.comboBoxExamYear.TabIndex = 1;
            this.comboBoxExamYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxExamYear_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Available Reports";
            // 
            // scBody
            // 
            this.scBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBody.Location = new System.Drawing.Point(0, 0);
            this.scBody.Name = "scBody";
            this.scBody.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBody.Panel1
            // 
            this.scBody.Panel1.Controls.Add(this.scReports);
            // 
            // scBody.Panel2
            // 
            this.scBody.Panel2.Controls.Add(this.groupBox1);
            this.scBody.Panel2.Controls.Add(this.buttonViewReport);
            this.scBody.Size = new System.Drawing.Size(1314, 750);
            this.scBody.SplitterDistance = 648;
            this.scBody.TabIndex = 0;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1314, 482);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToOrderColumns = true;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReport.Location = new System.Drawing.Point(0, 0);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvReport.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvReport.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvReport.RowTemplate.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(1314, 648);
            this.dgvReport.TabIndex = 1;
            // 
            // scReports
            // 
            this.scReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scReports.Location = new System.Drawing.Point(0, 0);
            this.scReports.Name = "scReports";
            this.scReports.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scReports.Panel1
            // 
            this.scReports.Panel1.Controls.Add(this.crystalReportViewer1);
            this.scReports.Panel1Collapsed = true;
            // 
            // scReports.Panel2
            // 
            this.scReports.Panel2.Controls.Add(this.dgvReport);
            this.scReports.Size = new System.Drawing.Size(1314, 648);
            this.scReports.SplitterDistance = 482;
            this.scReports.TabIndex = 2;
            // 
            // buttonViewReport
            // 
            this.buttonViewReport.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonViewReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonViewReport.Location = new System.Drawing.Point(3, 3);
            this.buttonViewReport.Name = "buttonViewReport";
            this.buttonViewReport.Size = new System.Drawing.Size(123, 83);
            this.buttonViewReport.TabIndex = 2;
            this.buttonViewReport.Text = "View Report";
            this.buttonViewReport.UseVisualStyleBackColor = false;
            this.buttonViewReport.Click += new System.EventHandler(this.buttonViewReport_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(105, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Export";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(14, 22);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(85, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "radioButton1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(14, 46);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(152, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 83);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1314, 835);
            this.Controls.Add(this.scMain);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "FormReports";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scBody.Panel1.ResumeLayout(false);
            this.scBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBody)).EndInit();
            this.scBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewWPC1TimeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.examDetailsBindingSource)).EndInit();
            this.scReports.Panel1.ResumeLayout(false);
            this.scReports.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scReports)).EndInit();
            this.scReports.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.ComboBox comboBoxExamYear;
        private System.Windows.Forms.ComboBox comboBoxExamName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLoadReport;
        private System.Windows.Forms.ComboBox comboBoxReports;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.BindingSource viewWPC1TimeTableBindingSource;
        private System.Windows.Forms.SplitContainer scBody;
        private System.Windows.Forms.BindingSource examDetailsBindingSource;
        private System.Windows.Forms.SplitContainer scReports;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonViewReport;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}