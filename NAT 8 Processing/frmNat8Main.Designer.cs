namespace NAT_8_Processing
{
    partial class frmNat8Main
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
            this.spMain = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.scBody = new System.Windows.Forms.SplitContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lbSelectedlDatabaseName = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.listViewDroppedDatabases = new System.Windows.Forms.ListView();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.labelDatabaseName = new System.Windows.Forms.Label();
            this.spRight = new System.Windows.Forms.SplitContainer();
            this.lvDetails = new System.Windows.Forms.ListView();
            this.chExamYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chGrade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSchoolNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chSchoolName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chMales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFemales = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOutstandingSchools = new System.Windows.Forms.Button();
            this.btnViewEditCandidates = new System.Windows.Forms.Button();
            this.btnSaveToServer = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).BeginInit();
            this.spMain.Panel1.SuspendLayout();
            this.spMain.Panel2.SuspendLayout();
            this.spMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBody)).BeginInit();
            this.scBody.Panel1.SuspendLayout();
            this.scBody.Panel2.SuspendLayout();
            this.scBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).BeginInit();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spRight)).BeginInit();
            this.spRight.Panel1.SuspendLayout();
            this.spRight.Panel2.SuspendLayout();
            this.spRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // spMain
            // 
            this.spMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spMain.IsSplitterFixed = true;
            this.spMain.Location = new System.Drawing.Point(0, 0);
            this.spMain.Name = "spMain";
            this.spMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spMain.Panel1
            // 
            this.spMain.Panel1.Controls.Add(this.label1);
            // 
            // spMain.Panel2
            // 
            this.spMain.Panel2.Controls.Add(this.scBody);
            this.spMain.Size = new System.Drawing.Size(1119, 670);
            this.spMain.SplitterDistance = 59;
            this.spMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "NAT PROCESSING FOR GRADE 8";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.scBody.Panel1.Controls.Add(this.splitContainer1);
            this.scBody.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // scBody.Panel2
            // 
            this.scBody.Panel2.Controls.Add(this.scRight);
            this.scBody.Size = new System.Drawing.Size(1119, 607);
            this.scBody.SplitterDistance = 172;
            this.scBody.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lbSelectedlDatabaseName);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnSelectFile);
            this.splitContainer1.Panel2.Controls.Add(this.listViewDroppedDatabases);
            this.splitContainer1.Panel2.Controls.Add(this.btnRetrieve);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(172, 607);
            this.splitContainer1.SplitterDistance = 73;
            this.splitContainer1.TabIndex = 2;
            // 
            // lbSelectedlDatabaseName
            // 
            this.lbSelectedlDatabaseName.AutoEllipsis = true;
            this.lbSelectedlDatabaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSelectedlDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelectedlDatabaseName.ForeColor = System.Drawing.Color.White;
            this.lbSelectedlDatabaseName.Location = new System.Drawing.Point(0, 0);
            this.lbSelectedlDatabaseName.Name = "lbSelectedlDatabaseName";
            this.lbSelectedlDatabaseName.Size = new System.Drawing.Size(172, 73);
            this.lbSelectedlDatabaseName.TabIndex = 0;
            this.lbSelectedlDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(10, 3);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(147, 51);
            this.btnSelectFile.TabIndex = 0;
            this.btnSelectFile.Text = "&Select File..";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // listViewDroppedDatabases
            // 
            this.listViewDroppedDatabases.AllowDrop = true;
            this.listViewDroppedDatabases.HideSelection = false;
            this.listViewDroppedDatabases.Location = new System.Drawing.Point(12, 444);
            this.listViewDroppedDatabases.Name = "listViewDroppedDatabases";
            this.listViewDroppedDatabases.Size = new System.Drawing.Size(147, 69);
            this.listViewDroppedDatabases.TabIndex = 1;
            this.listViewDroppedDatabases.UseCompatibleStateImageBehavior = false;
            this.listViewDroppedDatabases.View = System.Windows.Forms.View.SmallIcon;
            this.listViewDroppedDatabases.Visible = false;
            this.listViewDroppedDatabases.SelectedIndexChanged += new System.EventHandler(this.ListViewDroppedDatabases_SelectedIndexChanged);
            this.listViewDroppedDatabases.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListViewDroppedDatabases_DragDrop);
            this.listViewDroppedDatabases.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewDroppedDatabases_DragEnter);
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Enabled = false;
            this.btnRetrieve.Location = new System.Drawing.Point(10, 63);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(147, 51);
            this.btnRetrieve.TabIndex = 0;
            this.btnRetrieve.Text = "&Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.Enabled = false;
            this.btnClear.Location = new System.Drawing.Point(10, 120);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(147, 51);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Name = "scRight";
            this.scRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.spRight);
            this.scRight.Size = new System.Drawing.Size(943, 607);
            this.scRight.SplitterDistance = 38;
            this.scRight.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.30769F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.69231F));
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDatabaseName, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 38);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Database Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDatabaseName
            // 
            this.labelDatabaseName.AutoEllipsis = true;
            this.labelDatabaseName.AutoSize = true;
            this.labelDatabaseName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDatabaseName.Location = new System.Drawing.Point(166, 0);
            this.labelDatabaseName.Name = "labelDatabaseName";
            this.labelDatabaseName.Size = new System.Drawing.Size(774, 38);
            this.labelDatabaseName.TabIndex = 1;
            this.labelDatabaseName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // spRight
            // 
            this.spRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spRight.Location = new System.Drawing.Point(0, 0);
            this.spRight.Name = "spRight";
            this.spRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spRight.Panel1
            // 
            this.spRight.Panel1.Controls.Add(this.lvDetails);
            // 
            // spRight.Panel2
            // 
            this.spRight.Panel2.Controls.Add(this.btnOutstandingSchools);
            this.spRight.Panel2.Controls.Add(this.btnViewEditCandidates);
            this.spRight.Panel2.Controls.Add(this.btnSaveToServer);
            this.spRight.Panel2.Controls.Add(this.btnExit);
            this.spRight.Size = new System.Drawing.Size(943, 565);
            this.spRight.SplitterDistance = 483;
            this.spRight.TabIndex = 1;
            // 
            // lvDetails
            // 
            this.lvDetails.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvDetails.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chExamYear,
            this.chGrade,
            this.chSchoolNumber,
            this.chSchoolName,
            this.chTotal,
            this.chMales,
            this.chFemales});
            this.lvDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvDetails.FullRowSelect = true;
            this.lvDetails.GridLines = true;
            this.lvDetails.HideSelection = false;
            this.lvDetails.HotTracking = true;
            this.lvDetails.HoverSelection = true;
            this.lvDetails.Location = new System.Drawing.Point(0, 0);
            this.lvDetails.MultiSelect = false;
            this.lvDetails.Name = "lvDetails";
            this.lvDetails.Size = new System.Drawing.Size(943, 483);
            this.lvDetails.TabIndex = 0;
            this.lvDetails.UseCompatibleStateImageBehavior = false;
            this.lvDetails.View = System.Windows.Forms.View.Details;
            this.lvDetails.SelectedIndexChanged += new System.EventHandler(this.lvDetails_SelectedIndexChanged);
            // 
            // chExamYear
            // 
            this.chExamYear.Text = "Exam Year";
            this.chExamYear.Width = 72;
            // 
            // chGrade
            // 
            this.chGrade.Text = "Grade";
            this.chGrade.Width = 58;
            // 
            // chSchoolNumber
            // 
            this.chSchoolNumber.Text = "School Number";
            this.chSchoolNumber.Width = 85;
            // 
            // chSchoolName
            // 
            this.chSchoolName.Text = "School Name";
            this.chSchoolName.Width = 208;
            // 
            // chTotal
            // 
            this.chTotal.Text = "Total";
            this.chTotal.Width = 79;
            // 
            // chMales
            // 
            this.chMales.Text = "Males";
            this.chMales.Width = 55;
            // 
            // chFemales
            // 
            this.chFemales.Text = "Females";
            this.chFemales.Width = 81;
            // 
            // btnOutstandingSchools
            // 
            this.btnOutstandingSchools.Enabled = false;
            this.btnOutstandingSchools.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOutstandingSchools.Location = new System.Drawing.Point(631, 10);
            this.btnOutstandingSchools.Name = "btnOutstandingSchools";
            this.btnOutstandingSchools.Size = new System.Drawing.Size(147, 51);
            this.btnOutstandingSchools.TabIndex = 0;
            this.btnOutstandingSchools.Text = "Check OutstandingSchools";
            this.btnOutstandingSchools.UseVisualStyleBackColor = true;
            // 
            // btnViewEditCandidates
            // 
            this.btnViewEditCandidates.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnViewEditCandidates.Location = new System.Drawing.Point(224, 10);
            this.btnViewEditCandidates.Name = "btnViewEditCandidates";
            this.btnViewEditCandidates.Size = new System.Drawing.Size(340, 51);
            this.btnViewEditCandidates.TabIndex = 0;
            this.btnViewEditCandidates.Text = "View/Edit Candidates";
            this.btnViewEditCandidates.UseVisualStyleBackColor = true;
            this.btnViewEditCandidates.Click += new System.EventHandler(this.btnViewEditCandidates_Click);
            // 
            // btnSaveToServer
            // 
            this.btnSaveToServer.Enabled = false;
            this.btnSaveToServer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveToServer.Location = new System.Drawing.Point(6, 10);
            this.btnSaveToServer.Name = "btnSaveToServer";
            this.btnSaveToServer.Size = new System.Drawing.Size(147, 51);
            this.btnSaveToServer.TabIndex = 0;
            this.btnSaveToServer.Text = "S&ave to Sever";
            this.btnSaveToServer.UseVisualStyleBackColor = true;
            this.btnSaveToServer.Click += new System.EventHandler(this.btnSaveToServer_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.Location = new System.Drawing.Point(818, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 51);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmNat8Main
            // 
            this.AcceptButton = this.btnSelectFile;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Navy;
            this.CancelButton = this.btnClear;
            this.ClientSize = new System.Drawing.Size(1119, 670);
            this.Controls.Add(this.spMain);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "frmNat8Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "...::: PROCESS NAT DB :::...";
            this.Load += new System.EventHandler(this.FrmNat8Main_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.ListViewDroppedDatabases_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.listViewDroppedDatabases_DragEnter);
            this.spMain.Panel1.ResumeLayout(false);
            this.spMain.Panel1.PerformLayout();
            this.spMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spMain)).EndInit();
            this.spMain.ResumeLayout(false);
            this.scBody.Panel1.ResumeLayout(false);
            this.scBody.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBody)).EndInit();
            this.scBody.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).EndInit();
            this.scRight.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.spRight.Panel1.ResumeLayout(false);
            this.spRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spRight)).EndInit();
            this.spRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer scBody;
        private System.Windows.Forms.ListView listViewDroppedDatabases;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSaveToServer;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.SplitContainer scRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelDatabaseName;
        private System.Windows.Forms.ListView lvDetails;
        private System.Windows.Forms.ColumnHeader chExamYear;
        private System.Windows.Forms.ColumnHeader chGrade;
        private System.Windows.Forms.ColumnHeader chSchoolNumber;
        private System.Windows.Forms.ColumnHeader chSchoolName;
        private System.Windows.Forms.ColumnHeader chTotal;
        private System.Windows.Forms.ColumnHeader chMales;
        private System.Windows.Forms.ColumnHeader chFemales;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lbSelectedlDatabaseName;
        private System.Windows.Forms.SplitContainer spRight;
        private System.Windows.Forms.Button btnViewEditCandidates;
        private System.Windows.Forms.Button btnOutstandingSchools;
    }
}

