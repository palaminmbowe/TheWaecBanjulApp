namespace NAT_8_Processing
{
    partial class frmViewEditCandidates
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.dataGridViewCandidates = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.contextMenuStripdgCandidates = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.numericUpDownTotalCandidates = new System.Windows.Forms.NumericUpDown();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonOutstandingCentres = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxCentres = new System.Windows.Forms.ListBox();
            this.bsNatCentresCurrent = new System.Windows.Forms.BindingSource(this.components);
            this.lblTotalCentresExpected = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblTotalCentresReceived = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxExam = new System.Windows.Forms.ComboBox();
            this.comboBoxCentreNumber = new System.Windows.Forms.ComboBox();
            this.comboBoxExamYear = new System.Windows.Forms.ComboBox();
            this.dsNat = new System.Data.DataSet();
            this.bsNatEntries = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalCandidates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNatCentresCurrent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNatEntries)).BeginInit();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.dataGridViewCandidates);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.btnExit);
            this.scMain.Panel2.Controls.Add(this.buttonPrint);
            this.scMain.Panel2.Controls.Add(this.btnSaveChanges);
            this.scMain.Size = new System.Drawing.Size(1225, 503);
            this.scMain.SplitterDistance = 446;
            this.scMain.TabIndex = 0;
            // 
            // dataGridViewCandidates
            // 
            this.dataGridViewCandidates.AllowUserToResizeRows = false;
            this.dataGridViewCandidates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCandidates.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCandidates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCandidates.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCandidates.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCandidates.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewCandidates.MultiSelect = false;
            this.dataGridViewCandidates.Name = "dataGridViewCandidates";
            this.dataGridViewCandidates.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCandidates.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCandidates.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewCandidates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCandidates.Size = new System.Drawing.Size(1225, 446);
            this.dataGridViewCandidates.TabIndex = 0;
            this.dataGridViewCandidates.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCandidates_RowLeave);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.Location = new System.Drawing.Point(1137, 7);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 38);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPrint.Enabled = false;
            this.buttonPrint.Location = new System.Drawing.Point(99, 7);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(82, 38);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveChanges.Enabled = false;
            this.btnSaveChanges.Location = new System.Drawing.Point(11, 7);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(82, 38);
            this.btnSaveChanges.TabIndex = 0;
            this.btnSaveChanges.Text = "Save";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // contextMenuStripdgCandidates
            // 
            this.contextMenuStripdgCandidates.Name = "contextMenuStripdgCandidates";
            this.contextMenuStripdgCandidates.Size = new System.Drawing.Size(61, 4);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.numericUpDownTotalCandidates);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSearch);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.buttonOutstandingCentres);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.listBoxCentres);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalCentresExpected);
            this.splitContainer1.Panel1.Controls.Add(this.button1);
            this.splitContainer1.Panel1.Controls.Add(this.lblTotalCentresReceived);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxExam);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxCentreNumber);
            this.splitContainer1.Panel1.Controls.Add(this.comboBoxExamYear);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scMain);
            this.splitContainer1.Size = new System.Drawing.Size(1225, 791);
            this.splitContainer1.SplitterDistance = 284;
            this.splitContainer1.TabIndex = 1;
            // 
            // numericUpDownTotalCandidates
            // 
            this.numericUpDownTotalCandidates.AutoSize = true;
            this.numericUpDownTotalCandidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTotalCandidates.InterceptArrowKeys = false;
            this.numericUpDownTotalCandidates.Location = new System.Drawing.Point(1057, 91);
            this.numericUpDownTotalCandidates.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericUpDownTotalCandidates.Name = "numericUpDownTotalCandidates";
            this.numericUpDownTotalCandidates.ReadOnly = true;
            this.numericUpDownTotalCandidates.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownTotalCandidates.TabIndex = 13;
            this.numericUpDownTotalCandidates.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDownTotalCandidates.ThousandsSeparator = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBoxSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSearch.Location = new System.Drawing.Point(260, 11);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(743, 32);
            this.textBoxSearch.TabIndex = 11;
            this.textBoxSearch.Text = "search...";
            this.textBoxSearch.Click += new System.EventHandler(this.textBoxSearch_Click);
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1024, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Total Centres Expected";
            // 
            // buttonOutstandingCentres
            // 
            this.buttonOutstandingCentres.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonOutstandingCentres.Enabled = false;
            this.buttonOutstandingCentres.Location = new System.Drawing.Point(1043, 220);
            this.buttonOutstandingCentres.Name = "buttonOutstandingCentres";
            this.buttonOutstandingCentres.Size = new System.Drawing.Size(170, 55);
            this.buttonOutstandingCentres.TabIndex = 0;
            this.buttonOutstandingCentres.Text = "Outstanding Centres";
            this.buttonOutstandingCentres.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1048, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(129, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Total Candidates";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1024, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total Centres Received";
            // 
            // listBoxCentres
            // 
            this.listBoxCentres.DataSource = this.bsNatCentresCurrent;
            this.listBoxCentres.DisplayMember = "CentreName";
            this.listBoxCentres.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxCentres.FormattingEnabled = true;
            this.listBoxCentres.ItemHeight = 24;
            this.listBoxCentres.Location = new System.Drawing.Point(260, 55);
            this.listBoxCentres.Name = "listBoxCentres";
            this.listBoxCentres.Size = new System.Drawing.Size(743, 220);
            this.listBoxCentres.TabIndex = 9;
            this.listBoxCentres.ValueMember = "CentreNumber";
            this.listBoxCentres.SelectedIndexChanged += new System.EventHandler(this.listBoxCentres_SelectedIndexChanged);
            this.listBoxCentres.DoubleClick += new System.EventHandler(this.listBoxCentres_DoubleClick);
            // 
            // bsNatCentresCurrent
            // 
            this.bsNatCentresCurrent.DataSource = typeof(NAT8Processing.Model.NatCentresCurrent);
            // 
            // lblTotalCentresExpected
            // 
            this.lblTotalCentresExpected.AutoSize = true;
            this.lblTotalCentresExpected.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCentresExpected.Location = new System.Drawing.Point(1093, 162);
            this.lblTotalCentresExpected.Name = "lblTotalCentresExpected";
            this.lblTotalCentresExpected.Size = new System.Drawing.Size(36, 20);
            this.lblTotalCentresExpected.TabIndex = 4;
            this.lblTotalCentresExpected.Text = "???";
            this.lblTotalCentresExpected.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(31, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "Reload";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // lblTotalCentresReceived
            // 
            this.lblTotalCentresReceived.AutoSize = true;
            this.lblTotalCentresReceived.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCentresReceived.Location = new System.Drawing.Point(1093, 39);
            this.lblTotalCentresReceived.Name = "lblTotalCentresReceived";
            this.lblTotalCentresReceived.Size = new System.Drawing.Size(36, 20);
            this.lblTotalCentresReceived.TabIndex = 4;
            this.lblTotalCentresReceived.Text = "000";
            this.lblTotalCentresReceived.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exam Name";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(66, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "School Number";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Exam Year";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBoxExam
            // 
            this.comboBoxExam.DataSource = this.bsNatCentresCurrent;
            this.comboBoxExam.DisplayMember = "ExamShortName";
            this.comboBoxExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExam.Enabled = false;
            this.comboBoxExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExam.FormattingEnabled = true;
            this.comboBoxExam.Location = new System.Drawing.Point(16, 34);
            this.comboBoxExam.Name = "comboBoxExam";
            this.comboBoxExam.Size = new System.Drawing.Size(218, 28);
            this.comboBoxExam.TabIndex = 6;
            this.comboBoxExam.ValueMember = "ExamID";
            this.comboBoxExam.SelectedIndexChanged += new System.EventHandler(this.comboBoxExamYear_SelectedIndexChanged);
            // 
            // comboBoxCentreNumber
            // 
            this.comboBoxCentreNumber.DisplayMember = "ExamYear";
            this.comboBoxCentreNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCentreNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCentreNumber.FormattingEnabled = true;
            this.comboBoxCentreNumber.Location = new System.Drawing.Point(16, 174);
            this.comboBoxCentreNumber.Name = "comboBoxCentreNumber";
            this.comboBoxCentreNumber.Size = new System.Drawing.Size(216, 28);
            this.comboBoxCentreNumber.TabIndex = 6;
            this.comboBoxCentreNumber.ValueMember = "ExamYear";
            this.comboBoxCentreNumber.SelectedIndexChanged += new System.EventHandler(this.comboBoxCentreNumber_SelectedIndexChanged);
            // 
            // comboBoxExamYear
            // 
            this.comboBoxExamYear.DataSource = this.bsNatCentresCurrent;
            this.comboBoxExamYear.DisplayMember = "ExamYear";
            this.comboBoxExamYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExamYear.Enabled = false;
            this.comboBoxExamYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExamYear.FormattingEnabled = true;
            this.comboBoxExamYear.Location = new System.Drawing.Point(16, 104);
            this.comboBoxExamYear.Name = "comboBoxExamYear";
            this.comboBoxExamYear.Size = new System.Drawing.Size(216, 28);
            this.comboBoxExamYear.TabIndex = 6;
            this.comboBoxExamYear.ValueMember = "ExamYear";
            this.comboBoxExamYear.SelectedIndexChanged += new System.EventHandler(this.comboBoxExamYear_SelectedIndexChanged);
            // 
            // dsNat
            // 
            this.dsNat.DataSetName = "NatDataSet";
            // 
            // bsNatEntries
            // 
            this.bsNatEntries.DataSource = typeof(NAT8Processing.Model.NatEntries);
            // 
            // frmViewEditCandidates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1225, 791);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmViewEditCandidates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ViewEditCandidates";
            this.Load += new System.EventHandler(this.frmViewEditCandidates_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidates)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTotalCandidates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNatCentresCurrent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsNat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsNatEntries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.DataGridView dataGridViewCandidates;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripdgCandidates;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxExamYear;
        private System.Windows.Forms.ListBox listBoxCentres;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxExam;
        private System.Windows.Forms.BindingSource bsNatCentresCurrent;
        private System.Data.DataSet dsNat;
        private System.Windows.Forms.BindingSource bsNatEntries;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCentreNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonOutstandingCentres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalCentresExpected;
        private System.Windows.Forms.Label lblTotalCentresReceived;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownTotalCandidates;
    }
}