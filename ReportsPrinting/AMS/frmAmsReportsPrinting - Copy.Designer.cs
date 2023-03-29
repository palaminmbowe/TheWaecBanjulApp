namespace ReportsPrinting
{
    partial class frmAmsReportsPrinting
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAmsReportsPrinting));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lblHeader = new System.Windows.Forms.Label();
            this.scBottom = new System.Windows.Forms.SplitContainer();
            this.panelSelected = new System.Windows.Forms.Panel();
            this.gbSelectedSubjects = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.clbSelectedSubjects = new System.Windows.Forms.CheckedListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnClearAllSubjects = new System.Windows.Forms.Button();
            this.btnSelectAllSubject = new System.Windows.Forms.Button();
            this.gbSelectedCentres = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.clbSelectedCentres = new System.Windows.Forms.CheckedListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearAllSubject = new System.Windows.Forms.Button();
            this.btnSelectAllCentres = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblExam = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRefreshCrv = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSelectedSubject = new System.Windows.Forms.RadioButton();
            this.rbSubjectsWithoutPracticals = new System.Windows.Forms.RadioButton();
            this.rbSubjetsWithPracticals = new System.Windows.Forms.RadioButton();
            this.rbAllSubjects = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbSelectedCentre = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rbDepot = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBottom)).BeginInit();
            this.scBottom.Panel1.SuspendLayout();
            this.scBottom.Panel2.SuspendLayout();
            this.scBottom.SuspendLayout();
            this.panelSelected.SuspendLayout();
            this.gbSelectedSubjects.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbSelectedCentres.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.scMain.Panel1.Controls.Add(this.lblHeader);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scBottom);
            this.scMain.Size = new System.Drawing.Size(964, 641);
            this.scMain.SplitterDistance = 99;
            this.scMain.TabIndex = 1;
            // 
            // lblHeader
            // 
            this.lblHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(101)))), ((int)(((byte)(145)))));
            this.lblHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Monotype Corsiva", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.White;
            this.lblHeader.Image = ((System.Drawing.Image)(resources.GetObject("lblHeader.Image")));
            this.lblHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(964, 99);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Attendance and Mark Sheet\r\nPrinting";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scBottom
            // 
            this.scBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBottom.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.scBottom.Location = new System.Drawing.Point(0, 0);
            this.scBottom.Name = "scBottom";
            // 
            // scBottom.Panel1
            // 
            this.scBottom.Panel1.Controls.Add(this.panelSelected);
            this.scBottom.Panel1.Controls.Add(this.panel1);
            this.scBottom.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.scBottom_Panel1_Paint);
            // 
            // scBottom.Panel2
            // 
            this.scBottom.Panel2.Controls.Add(this.crystalReportViewer1);
            this.scBottom.Panel2Collapsed = true;
            this.scBottom.Size = new System.Drawing.Size(964, 538);
            this.scBottom.SplitterDistance = 157;
            this.scBottom.TabIndex = 0;
            // 
            // panelSelected
            // 
            this.panelSelected.Controls.Add(this.gbSelectedSubjects);
            this.panelSelected.Controls.Add(this.gbSelectedCentres);
            this.panelSelected.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSelected.Location = new System.Drawing.Point(151, 0);
            this.panelSelected.Name = "panelSelected";
            this.panelSelected.Size = new System.Drawing.Size(694, 538);
            this.panelSelected.TabIndex = 6;
            this.panelSelected.Visible = false;
            this.panelSelected.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSelected_Paint);
            // 
            // gbSelectedSubjects
            // 
            this.gbSelectedSubjects.Controls.Add(this.tableLayoutPanel1);
            this.gbSelectedSubjects.Enabled = false;
            this.gbSelectedSubjects.ForeColor = System.Drawing.Color.White;
            this.gbSelectedSubjects.Location = new System.Drawing.Point(34, 12);
            this.gbSelectedSubjects.Name = "gbSelectedSubjects";
            this.gbSelectedSubjects.Size = new System.Drawing.Size(313, 295);
            this.gbSelectedSubjects.TabIndex = 5;
            this.gbSelectedSubjects.TabStop = false;
            this.gbSelectedSubjects.Text = "Selected Subject";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel9, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.17391F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.82609F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(307, 276);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.clbSelectedSubjects);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.cbSubject);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(301, 206);
            this.panel9.TabIndex = 2;
            // 
            // clbSelectedSubjects
            // 
            this.clbSelectedSubjects.FormattingEnabled = true;
            this.clbSelectedSubjects.Location = new System.Drawing.Point(7, 89);
            this.clbSelectedSubjects.Name = "clbSelectedSubjects";
            this.clbSelectedSubjects.Size = new System.Drawing.Size(280, 319);
            this.clbSelectedSubjects.Sorted = true;
            this.clbSelectedSubjects.TabIndex = 4;
            this.clbSelectedSubjects.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Select subject to load:";
            // 
            // cbSubject
            // 
            this.cbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(3, 29);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(295, 28);
            this.cbSubject.TabIndex = 11;
            this.cbSubject.SelectedIndexChanged += new System.EventHandler(this.cbSubject_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClearAllSubjects);
            this.panel2.Controls.Add(this.btnSelectAllSubject);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 58);
            this.panel2.TabIndex = 0;
            // 
            // btnClearAllSubjects
            // 
            this.btnClearAllSubjects.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClearAllSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllSubjects.ForeColor = System.Drawing.Color.Black;
            this.btnClearAllSubjects.Location = new System.Drawing.Point(81, 3);
            this.btnClearAllSubjects.Name = "btnClearAllSubjects";
            this.btnClearAllSubjects.Size = new System.Drawing.Size(72, 35);
            this.btnClearAllSubjects.TabIndex = 4;
            this.btnClearAllSubjects.Text = "Clear";
            this.btnClearAllSubjects.UseVisualStyleBackColor = true;
            // 
            // btnSelectAllSubject
            // 
            this.btnSelectAllSubject.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSelectAllSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAllSubject.ForeColor = System.Drawing.Color.Black;
            this.btnSelectAllSubject.Location = new System.Drawing.Point(3, 4);
            this.btnSelectAllSubject.Name = "btnSelectAllSubject";
            this.btnSelectAllSubject.Size = new System.Drawing.Size(72, 35);
            this.btnSelectAllSubject.TabIndex = 3;
            this.btnSelectAllSubject.Text = "Select All";
            this.btnSelectAllSubject.UseVisualStyleBackColor = true;
            // 
            // gbSelectedCentres
            // 
            this.gbSelectedCentres.Controls.Add(this.tableLayoutPanel2);
            this.gbSelectedCentres.Enabled = false;
            this.gbSelectedCentres.ForeColor = System.Drawing.Color.White;
            this.gbSelectedCentres.Location = new System.Drawing.Point(359, 12);
            this.gbSelectedCentres.Name = "gbSelectedCentres";
            this.gbSelectedCentres.Size = new System.Drawing.Size(313, 295);
            this.gbSelectedCentres.TabIndex = 5;
            this.gbSelectedCentres.TabStop = false;
            this.gbSelectedCentres.Text = "Selected Centres";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.clbSelectedCentres, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.89855F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.10145F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(307, 276);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // clbSelectedCentres
            // 
            this.clbSelectedCentres.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbSelectedCentres.FormattingEnabled = true;
            this.clbSelectedCentres.Location = new System.Drawing.Point(3, 3);
            this.clbSelectedCentres.Name = "clbSelectedCentres";
            this.clbSelectedCentres.Size = new System.Drawing.Size(301, 209);
            this.clbSelectedCentres.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClearAllSubject);
            this.panel3.Controls.Add(this.btnSelectAllCentres);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(301, 55);
            this.panel3.TabIndex = 0;
            // 
            // btnClearAllSubject
            // 
            this.btnClearAllSubject.BackColor = System.Drawing.Color.Goldenrod;
            this.btnClearAllSubject.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAllSubject.ForeColor = System.Drawing.Color.Black;
            this.btnClearAllSubject.Location = new System.Drawing.Point(81, 3);
            this.btnClearAllSubject.Name = "btnClearAllSubject";
            this.btnClearAllSubject.Size = new System.Drawing.Size(72, 35);
            this.btnClearAllSubject.TabIndex = 5;
            this.btnClearAllSubject.Text = "Clear";
            this.btnClearAllSubject.UseVisualStyleBackColor = true;
            // 
            // btnSelectAllCentres
            // 
            this.btnSelectAllCentres.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSelectAllCentres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAllCentres.ForeColor = System.Drawing.Color.Black;
            this.btnSelectAllCentres.Location = new System.Drawing.Point(3, 4);
            this.btnSelectAllCentres.Name = "btnSelectAllCentres";
            this.btnSelectAllCentres.Size = new System.Drawing.Size(72, 35);
            this.btnSelectAllCentres.TabIndex = 3;
            this.btnSelectAllCentres.Text = "Select All";
            this.btnSelectAllCentres.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblExam);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnLoad);
            this.panel1.Controls.Add(this.btnRefreshCrv);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(151, 538);
            this.panel1.TabIndex = 3;
            // 
            // lblExam
            // 
            this.lblExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(101)))), ((int)(((byte)(145)))));
            this.lblExam.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblExam.Font = new System.Drawing.Font("Monotype Corsiva", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExam.ForeColor = System.Drawing.Color.White;
            this.lblExam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExam.Location = new System.Drawing.Point(0, 451);
            this.lblExam.Name = "lblExam";
            this.lblExam.Size = new System.Drawing.Size(147, 83);
            this.lblExam.TabIndex = 3;
            this.lblExam.Text = "Exam";
            this.lblExam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "OPTIONS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Goldenrod;
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.Color.Black;
            this.btnLoad.Location = new System.Drawing.Point(4, 316);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(137, 69);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRefreshCrv
            // 
            this.btnRefreshCrv.BackColor = System.Drawing.Color.Goldenrod;
            this.btnRefreshCrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshCrv.ForeColor = System.Drawing.Color.Black;
            this.btnRefreshCrv.Location = new System.Drawing.Point(3, 403);
            this.btnRefreshCrv.Name = "btnRefreshCrv";
            this.btnRefreshCrv.Size = new System.Drawing.Size(138, 45);
            this.btnRefreshCrv.TabIndex = 2;
            this.btnRefreshCrv.Text = "Refresh";
            this.btnRefreshCrv.UseVisualStyleBackColor = true;
            this.btnRefreshCrv.Click += new System.EventHandler(this.btnRefreshCrv_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDepot);
            this.groupBox1.Controls.Add(this.rbSelectedSubject);
            this.groupBox1.Controls.Add(this.rbSubjectsWithoutPracticals);
            this.groupBox1.Controls.Add(this.rbSubjetsWithPracticals);
            this.groupBox1.Controls.Add(this.rbAllSubjects);
            this.groupBox1.Location = new System.Drawing.Point(3, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPTION";
            // 
            // rbSelectedSubject
            // 
            this.rbSelectedSubject.AutoSize = true;
            this.rbSelectedSubject.Location = new System.Drawing.Point(19, 103);
            this.rbSelectedSubject.Name = "rbSelectedSubject";
            this.rbSelectedSubject.Size = new System.Drawing.Size(106, 17);
            this.rbSelectedSubject.TabIndex = 1;
            this.rbSelectedSubject.Text = "Selected Subject";
            this.rbSelectedSubject.UseVisualStyleBackColor = true;
            this.rbSelectedSubject.CheckedChanged += new System.EventHandler(this.rbSelectedSubject_CheckedChanged);
            // 
            // rbSubjectsWithoutPracticals
            // 
            this.rbSubjectsWithoutPracticals.AutoSize = true;
            this.rbSubjectsWithoutPracticals.Location = new System.Drawing.Point(19, 76);
            this.rbSubjectsWithoutPracticals.Name = "rbSubjectsWithoutPracticals";
            this.rbSubjectsWithoutPracticals.Size = new System.Drawing.Size(111, 17);
            this.rbSubjectsWithoutPracticals.TabIndex = 0;
            this.rbSubjectsWithoutPracticals.Text = "Without Practicals";
            this.rbSubjectsWithoutPracticals.UseVisualStyleBackColor = true;
            this.rbSubjectsWithoutPracticals.CheckedChanged += new System.EventHandler(this.SubjectOption);
            // 
            // rbSubjetsWithPracticals
            // 
            this.rbSubjetsWithPracticals.AutoSize = true;
            this.rbSubjetsWithPracticals.Location = new System.Drawing.Point(19, 49);
            this.rbSubjetsWithPracticals.Name = "rbSubjetsWithPracticals";
            this.rbSubjetsWithPracticals.Size = new System.Drawing.Size(96, 17);
            this.rbSubjetsWithPracticals.TabIndex = 0;
            this.rbSubjetsWithPracticals.Text = "With Practicals";
            this.rbSubjetsWithPracticals.UseVisualStyleBackColor = true;
            this.rbSubjetsWithPracticals.CheckedChanged += new System.EventHandler(this.SubjectOption);
            // 
            // rbAllSubjects
            // 
            this.rbAllSubjects.AutoSize = true;
            this.rbAllSubjects.Checked = true;
            this.rbAllSubjects.Location = new System.Drawing.Point(19, 22);
            this.rbAllSubjects.Name = "rbAllSubjects";
            this.rbAllSubjects.Size = new System.Drawing.Size(80, 17);
            this.rbAllSubjects.TabIndex = 0;
            this.rbAllSubjects.TabStop = true;
            this.rbAllSubjects.Text = "All Subjects";
            this.rbAllSubjects.UseVisualStyleBackColor = true;
            this.rbAllSubjects.CheckedChanged += new System.EventHandler(this.SubjectOption);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbSelectedCentre);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(3, 215);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 85);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Centres";
            // 
            // rbSelectedCentre
            // 
            this.rbSelectedCentre.AutoSize = true;
            this.rbSelectedCentre.Location = new System.Drawing.Point(19, 51);
            this.rbSelectedCentre.Name = "rbSelectedCentre";
            this.rbSelectedCentre.Size = new System.Drawing.Size(106, 17);
            this.rbSelectedCentre.TabIndex = 1;
            this.rbSelectedCentre.Text = "Selected Centres";
            this.rbSelectedCentre.UseVisualStyleBackColor = true;
            this.rbSelectedCentre.CheckedChanged += new System.EventHandler(this.rbSelectedCentre_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(19, 22);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(75, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "All Centres";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(72, 81);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // rbDepot
            // 
            this.rbDepot.AutoSize = true;
            this.rbDepot.Location = new System.Drawing.Point(19, 130);
            this.rbDepot.Name = "rbDepot";
            this.rbDepot.Size = new System.Drawing.Size(69, 17);
            this.rbDepot.TabIndex = 1;
            this.rbDepot.Text = "By Depot";
            this.rbDepot.UseVisualStyleBackColor = true;
            this.rbDepot.CheckedChanged += new System.EventHandler(this.rbSelectedSubject_CheckedChanged);
            // 
            // frmAmsReportsPrinting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(101)))), ((int)(((byte)(145)))));
            this.ClientSize = new System.Drawing.Size(964, 641);
            this.Controls.Add(this.scMain);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(980, 678);
            this.Name = "frmAmsReportsPrinting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report Printing Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportsPrinting_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scBottom.Panel1.ResumeLayout(false);
            this.scBottom.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scBottom)).EndInit();
            this.scBottom.ResumeLayout(false);
            this.panelSelected.ResumeLayout(false);
            this.gbSelectedSubjects.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gbSelectedCentres.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer scMain;
        internal System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.SplitContainer scBottom;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSubjectsWithoutPracticals;
        private System.Windows.Forms.RadioButton rbSubjetsWithPracticals;
        private System.Windows.Forms.RadioButton rbAllSubjects;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelSelected;
        private System.Windows.Forms.GroupBox gbSelectedSubjects;
        private System.Windows.Forms.CheckedListBox clbSelectedSubjects;
        private System.Windows.Forms.GroupBox gbSelectedCentres;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClearAllSubjects;
        private System.Windows.Forms.Button btnSelectAllSubject;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.CheckedListBox clbSelectedCentres;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClearAllSubject;
        private System.Windows.Forms.Button btnSelectAllCentres;
        private System.Windows.Forms.RadioButton rbSelectedSubject;
        private System.Windows.Forms.RadioButton rbSelectedCentre;
        internal System.Windows.Forms.Label lblExam;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Button btnRefreshCrv;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.RadioButton rbDepot;
    }
}

