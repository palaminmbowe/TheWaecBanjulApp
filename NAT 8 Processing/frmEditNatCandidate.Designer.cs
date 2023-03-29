
namespace NAT8Processing
{
    partial class frmEditNatCandidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditNatCandidate));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lblCandidate = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelDeadline = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelCurrentDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbCandidateDetails = new System.Windows.Forms.GroupBox();
            this.lblDomainName = new System.Windows.Forms.Label();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pbCandidate = new System.Windows.Forms.PictureBox();
            this.label13 = new System.Windows.Forms.Label();
            this.comboBoxDisability = new System.Windows.Forms.ComboBox();
            this.lblPcName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.lblUsername = new System.Windows.Forms.Label();
            this.comboBoxAttempts = new System.Windows.Forms.ComboBox();
            this.comboBoxSex = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDeleteCandidate = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtCandidateInitial = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCandidateFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCandidateLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gbCandidateInfo = new System.Windows.Forms.GroupBox();
            this.comboBoxExam = new System.Windows.Forms.ComboBox();
            this.txtCentreNumber = new System.Windows.Forms.TextBox();
            this.btnRetrieveCandidate = new System.Windows.Forms.Button();
            this.btnCancelTop = new System.Windows.Forms.Button();
            this.txtIndexNumber = new System.Windows.Forms.TextBox();
            this.comboBoxExamYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timerHeartBeat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbCandidateDetails.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandidate)).BeginInit();
            this.gbCandidateInfo.SuspendLayout();
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
            this.scMain.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scMain.Panel1.BackgroundImage")));
            this.scMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scMain.Panel1.Controls.Add(this.lblCandidate);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scMain.Panel2.Controls.Add(this.statusStrip1);
            this.scMain.Panel2.Controls.Add(this.gbCandidateDetails);
            this.scMain.Panel2.Controls.Add(this.gbCandidateInfo);
            this.scMain.Size = new System.Drawing.Size(905, 639);
            this.scMain.SplitterDistance = 109;
            this.scMain.TabIndex = 1;
            // 
            // lblCandidate
            // 
            this.lblCandidate.AutoSize = true;
            this.lblCandidate.BackColor = System.Drawing.Color.Transparent;
            this.lblCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidate.ForeColor = System.Drawing.Color.White;
            this.lblCandidate.Location = new System.Drawing.Point(718, 33);
            this.lblCandidate.Name = "lblCandidate";
            this.lblCandidate.Size = new System.Drawing.Size(182, 62);
            this.lblCandidate.TabIndex = 0;
            this.lblCandidate.Text = "NAT\r\nCANDIDATE";
            this.lblCandidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelDeadline,
            this.toolStripStatusLabelCurrentDate,
            this.toolStripStatusLabelConnected});
            this.statusStrip1.Location = new System.Drawing.Point(0, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(905, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelDeadline
            // 
            this.toolStripStatusLabelDeadline.Name = "toolStripStatusLabelDeadline";
            this.toolStripStatusLabelDeadline.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelDeadline.Text = "toolStripStatusLabel1";
            this.toolStripStatusLabelDeadline.Visible = false;
            // 
            // toolStripStatusLabelCurrentDate
            // 
            this.toolStripStatusLabelCurrentDate.Name = "toolStripStatusLabelCurrentDate";
            this.toolStripStatusLabelCurrentDate.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabelCurrentDate.Text = "toolStripStatusLabel2";
            this.toolStripStatusLabelCurrentDate.Visible = false;
            // 
            // toolStripStatusLabelConnected
            // 
            this.toolStripStatusLabelConnected.BackColor = System.Drawing.Color.Red;
            this.toolStripStatusLabelConnected.Name = "toolStripStatusLabelConnected";
            this.toolStripStatusLabelConnected.Size = new System.Drawing.Size(890, 17);
            this.toolStripStatusLabelConnected.Spring = true;
            // 
            // gbCandidateDetails
            // 
            this.gbCandidateDetails.BackColor = System.Drawing.Color.Transparent;
            this.gbCandidateDetails.Controls.Add(this.lblDomainName);
            this.gbCandidateDetails.Controls.Add(this.panelPicture);
            this.gbCandidateDetails.Controls.Add(this.label13);
            this.gbCandidateDetails.Controls.Add(this.comboBoxDisability);
            this.gbCandidateDetails.Controls.Add(this.lblPcName);
            this.gbCandidateDetails.Controls.Add(this.label8);
            this.gbCandidateDetails.Controls.Add(this.label11);
            this.gbCandidateDetails.Controls.Add(this.dateOfBirth);
            this.gbCandidateDetails.Controls.Add(this.lblUsername);
            this.gbCandidateDetails.Controls.Add(this.comboBoxAttempts);
            this.gbCandidateDetails.Controls.Add(this.comboBoxSex);
            this.gbCandidateDetails.Controls.Add(this.label10);
            this.gbCandidateDetails.Controls.Add(this.lblSchoolName);
            this.gbCandidateDetails.Controls.Add(this.btnExit);
            this.gbCandidateDetails.Controls.Add(this.label5);
            this.gbCandidateDetails.Controls.Add(this.label9);
            this.gbCandidateDetails.Controls.Add(this.btnDeleteCandidate);
            this.gbCandidateDetails.Controls.Add(this.btnCancel);
            this.gbCandidateDetails.Controls.Add(this.lblSex);
            this.gbCandidateDetails.Controls.Add(this.txtCandidateInitial);
            this.gbCandidateDetails.Controls.Add(this.btnUpdate);
            this.gbCandidateDetails.Controls.Add(this.label7);
            this.gbCandidateDetails.Controls.Add(this.txtCandidateFirstName);
            this.gbCandidateDetails.Controls.Add(this.label6);
            this.gbCandidateDetails.Controls.Add(this.txtCandidateLastName);
            this.gbCandidateDetails.Controls.Add(this.label3);
            this.gbCandidateDetails.Enabled = false;
            this.gbCandidateDetails.Location = new System.Drawing.Point(12, 109);
            this.gbCandidateDetails.Name = "gbCandidateDetails";
            this.gbCandidateDetails.Size = new System.Drawing.Size(870, 386);
            this.gbCandidateDetails.TabIndex = 0;
            this.gbCandidateDetails.TabStop = false;
            // 
            // lblDomainName
            // 
            this.lblDomainName.AutoSize = true;
            this.lblDomainName.ForeColor = System.Drawing.Color.White;
            this.lblDomainName.Location = new System.Drawing.Point(776, 359);
            this.lblDomainName.Name = "lblDomainName";
            this.lblDomainName.Size = new System.Drawing.Size(0, 13);
            this.lblDomainName.TabIndex = 38;
            // 
            // panelPicture
            // 
            this.panelPicture.BackColor = System.Drawing.Color.White;
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPicture.Controls.Add(this.pbCandidate);
            this.panelPicture.Location = new System.Drawing.Point(649, 46);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(200, 200);
            this.panelPicture.TabIndex = 20;
            // 
            // pbCandidate
            // 
            this.pbCandidate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCandidate.Enabled = false;
            this.pbCandidate.Location = new System.Drawing.Point(0, 0);
            this.pbCandidate.Name = "pbCandidate";
            this.pbCandidate.Size = new System.Drawing.Size(196, 196);
            this.pbCandidate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCandidate.TabIndex = 12;
            this.pbCandidate.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(782, 359);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 37;
            this.label13.Text = "Domain:";
            this.label13.Visible = false;
            // 
            // comboBoxDisability
            // 
            this.comboBoxDisability.AutoCompleteCustomSource.AddRange(new string[] {
            "0 - UNKNOWN",
            "1 - NONE",
            "2 - Visually Impaired",
            "3 - Hearing/Speech Impaired",
            "4 - Physically Impaired",
            "5 - Mentally Impaired",
            "6 - Spastic/Palsy/Epilectic Conditions",
            "7 - Low Vision"});
            this.comboBoxDisability.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxDisability.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxDisability.DisplayMember = "DisabilityID";
            this.comboBoxDisability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDisability.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDisability.FormattingEnabled = true;
            this.comboBoxDisability.Items.AddRange(new object[] {
            "0 - UNKNOWN",
            "1 - NONE",
            "2 - Visually Impaired",
            "3 - Hearing/Speech Impaired",
            "4 - Physically Impaired",
            "5 - Mentally Impaired",
            "6 - Spastic/Palsy/Epilectic Conditions",
            "7 - Low Vision"});
            this.comboBoxDisability.Location = new System.Drawing.Point(87, 220);
            this.comboBoxDisability.Name = "comboBoxDisability";
            this.comboBoxDisability.Size = new System.Drawing.Size(248, 33);
            this.comboBoxDisability.TabIndex = 9;
            this.comboBoxDisability.ValueMember = "DisabilityID";
            // 
            // lblPcName
            // 
            this.lblPcName.AutoSize = true;
            this.lblPcName.ForeColor = System.Drawing.Color.White;
            this.lblPcName.Location = new System.Drawing.Point(451, 359);
            this.lblPcName.Name = "lblPcName";
            this.lblPcName.Size = new System.Drawing.Size(0, 13);
            this.lblPcName.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Disability:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(392, 359);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 34;
            this.label11.Text = "PC Name:";
            this.label11.Visible = false;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirth.Location = new System.Drawing.Point(87, 265);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(248, 31);
            this.dateOfBirth.TabIndex = 10;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(97, 359);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 13);
            this.lblUsername.TabIndex = 35;
            // 
            // comboBoxAttempts
            // 
            this.comboBoxAttempts.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxAttempts.FormattingEnabled = true;
            this.comboBoxAttempts.Location = new System.Drawing.Point(87, 309);
            this.comboBoxAttempts.Name = "comboBoxAttempts";
            this.comboBoxAttempts.Size = new System.Drawing.Size(248, 33);
            this.comboBoxAttempts.TabIndex = 11;
            // 
            // comboBoxSex
            // 
            this.comboBoxSex.AutoCompleteCustomSource.AddRange(new string[] {
            "1 - MALE",
            "2 - FEMALE",
            "3 - OTHER"});
            this.comboBoxSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxSex.DisplayMember = "SexID";
            this.comboBoxSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSex.FormattingEnabled = true;
            this.comboBoxSex.Items.AddRange(new object[] {
            "1 - MALE",
            "2 - FEMALE",
            "3 - OTHER"});
            this.comboBoxSex.Location = new System.Drawing.Point(87, 175);
            this.comboBoxSex.Name = "comboBoxSex";
            this.comboBoxSex.Size = new System.Drawing.Size(248, 33);
            this.comboBoxSex.TabIndex = 8;
            this.comboBoxSex.ValueMember = "SexID";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(33, 359);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Username:";
            this.label10.Visible = false;
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.ForeColor = System.Drawing.Color.White;
            this.lblSchoolName.Location = new System.Drawing.Point(19, 14);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(0, 26);
            this.lblSchoolName.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(395, 290);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(147, 52);
            this.btnExit.TabIndex = 32;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(52, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DOB:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(34, 319);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Attempts:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnDeleteCandidate
            // 
            this.btnDeleteCandidate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteCandidate.Enabled = false;
            this.btnDeleteCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCandidate.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteCandidate.Location = new System.Drawing.Point(395, 130);
            this.btnDeleteCandidate.Name = "btnDeleteCandidate";
            this.btnDeleteCandidate.Size = new System.Drawing.Size(147, 68);
            this.btnDeleteCandidate.TabIndex = 31;
            this.btnDeleteCandidate.TabStop = false;
            this.btnDeleteCandidate.Text = "Delete Candidate";
            this.btnDeleteCandidate.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(395, 216);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(147, 68);
            this.btnCancel.TabIndex = 31;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.Color.White;
            this.lblSex.Location = new System.Drawing.Point(40, 185);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(45, 13);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Gender:";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCandidateInitial
            // 
            this.txtCandidateInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateInitial.Location = new System.Drawing.Point(87, 132);
            this.txtCandidateInitial.Name = "txtCandidateInitial";
            this.txtCandidateInitial.Size = new System.Drawing.Size(248, 31);
            this.txtCandidateInitial.TabIndex = 7;
            this.txtCandidateInitial.TextChanged += new System.EventHandler(this.txtTextBoxToUpper_TextChanged);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(395, 46);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(147, 74);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(51, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Initial:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCandidateFirstName
            // 
            this.txtCandidateFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateFirstName.Location = new System.Drawing.Point(87, 89);
            this.txtCandidateFirstName.Name = "txtCandidateFirstName";
            this.txtCandidateFirstName.Size = new System.Drawing.Size(248, 31);
            this.txtCandidateFirstName.TabIndex = 6;
            this.txtCandidateFirstName.TextChanged += new System.EventHandler(this.txtTextBoxToUpper_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "First Name:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCandidateLastName
            // 
            this.txtCandidateLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateLastName.Location = new System.Drawing.Point(87, 46);
            this.txtCandidateLastName.Name = "txtCandidateLastName";
            this.txtCandidateLastName.Size = new System.Drawing.Size(248, 31);
            this.txtCandidateLastName.TabIndex = 5;
            this.txtCandidateLastName.TextChanged += new System.EventHandler(this.txtTextBoxToUpper_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Last Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCandidateInfo
            // 
            this.gbCandidateInfo.BackColor = System.Drawing.Color.Transparent;
            this.gbCandidateInfo.Controls.Add(this.comboBoxExam);
            this.gbCandidateInfo.Controls.Add(this.txtCentreNumber);
            this.gbCandidateInfo.Controls.Add(this.btnRetrieveCandidate);
            this.gbCandidateInfo.Controls.Add(this.btnCancelTop);
            this.gbCandidateInfo.Controls.Add(this.txtIndexNumber);
            this.gbCandidateInfo.Controls.Add(this.comboBoxExamYear);
            this.gbCandidateInfo.Controls.Add(this.label4);
            this.gbCandidateInfo.Controls.Add(this.label1);
            this.gbCandidateInfo.Controls.Add(this.label14);
            this.gbCandidateInfo.Controls.Add(this.label2);
            this.gbCandidateInfo.Location = new System.Drawing.Point(12, 3);
            this.gbCandidateInfo.Name = "gbCandidateInfo";
            this.gbCandidateInfo.Size = new System.Drawing.Size(870, 100);
            this.gbCandidateInfo.TabIndex = 0;
            this.gbCandidateInfo.TabStop = false;
            // 
            // comboBoxExam
            // 
            this.comboBoxExam.DisplayMember = "ExamShortName";
            this.comboBoxExam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExam.FormattingEnabled = true;
            this.comboBoxExam.Items.AddRange(new object[] {
            "NAT8"});
            this.comboBoxExam.Location = new System.Drawing.Point(18, 41);
            this.comboBoxExam.Name = "comboBoxExam";
            this.comboBoxExam.Size = new System.Drawing.Size(132, 33);
            this.comboBoxExam.TabIndex = 7;
            this.comboBoxExam.ValueMember = "ExamID";
            // 
            // txtCentreNumber
            // 
            this.txtCentreNumber.BackColor = System.Drawing.Color.PaleVioletRed;
            this.txtCentreNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentreNumber.Location = new System.Drawing.Point(321, 41);
            this.txtCentreNumber.MaxLength = 5;
            this.txtCentreNumber.Name = "txtCentreNumber";
            this.txtCentreNumber.Size = new System.Drawing.Size(121, 32);
            this.txtCentreNumber.TabIndex = 1;
            this.txtCentreNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCentreNumber.TextChanged += new System.EventHandler(this.txtCentreNumber_TextChanged);
            // 
            // btnRetrieveCandidate
            // 
            this.btnRetrieveCandidate.Enabled = false;
            this.btnRetrieveCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveCandidate.ForeColor = System.Drawing.Color.Black;
            this.btnRetrieveCandidate.Location = new System.Drawing.Point(572, 20);
            this.btnRetrieveCandidate.Name = "btnRetrieveCandidate";
            this.btnRetrieveCandidate.Size = new System.Drawing.Size(171, 65);
            this.btnRetrieveCandidate.TabIndex = 3;
            this.btnRetrieveCandidate.Text = "Retrieve Candidate";
            this.btnRetrieveCandidate.UseVisualStyleBackColor = true;
            this.btnRetrieveCandidate.Click += new System.EventHandler(this.btnRetrieveCandidate_Click);
            // 
            // btnCancelTop
            // 
            this.btnCancelTop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTop.ForeColor = System.Drawing.Color.Black;
            this.btnCancelTop.Location = new System.Drawing.Point(752, 20);
            this.btnCancelTop.Name = "btnCancelTop";
            this.btnCancelTop.Size = new System.Drawing.Size(107, 65);
            this.btnCancelTop.TabIndex = 4;
            this.btnCancelTop.Text = "Cancel";
            this.btnCancelTop.UseVisualStyleBackColor = true;
            this.btnCancelTop.Click += new System.EventHandler(this.btnCancelTop_Click);
            // 
            // txtIndexNumber
            // 
            this.txtIndexNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndexNumber.Location = new System.Drawing.Point(467, 41);
            this.txtIndexNumber.MaxLength = 3;
            this.txtIndexNumber.Name = "txtIndexNumber";
            this.txtIndexNumber.Size = new System.Drawing.Size(71, 32);
            this.txtIndexNumber.TabIndex = 2;
            this.txtIndexNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIndexNumber.TextChanged += new System.EventHandler(this.txtIndexNumber_TextChanged);
            // 
            // comboBoxExamYear
            // 
            this.comboBoxExamYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExamYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxExamYear.FormattingEnabled = true;
            this.comboBoxExamYear.Location = new System.Drawing.Point(175, 41);
            this.comboBoxExamYear.Name = "comboBoxExamYear";
            this.comboBoxExamYear.Size = new System.Drawing.Size(121, 33);
            this.comboBoxExamYear.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(33, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Exam ID:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(194, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exam Year:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(351, 22);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 13);
            this.label14.TabIndex = 6;
            this.label14.Text = "Centre No.:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(482, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Index No.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // timerHeartBeat
            // 
            this.timerHeartBeat.Interval = 2000;
            this.timerHeartBeat.Tick += new System.EventHandler(this.timerHeartBeat_Tick);
            // 
            // frmEditNatCandidate
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(905, 639);
            this.Controls.Add(this.scMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmEditNatCandidate";
            this.Text = "frmEditNatCandidate";
            this.Load += new System.EventHandler(this.frmEditNatCandidate_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            this.scMain.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbCandidateDetails.ResumeLayout(false);
            this.gbCandidateDetails.PerformLayout();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCandidate)).EndInit();
            this.gbCandidateInfo.ResumeLayout(false);
            this.gbCandidateInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.Label lblCandidate;
        private System.Windows.Forms.GroupBox gbCandidateDetails;
        private System.Windows.Forms.ComboBox comboBoxDisability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtCandidateLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbCandidateInfo;
        private System.Windows.Forms.TextBox txtCentreNumber;
        private System.Windows.Forms.Button btnRetrieveCandidate;
        private System.Windows.Forms.Button btnCancelTop;
        private System.Windows.Forms.TextBox txtIndexNumber;
        private System.Windows.Forms.ComboBox comboBoxExamYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDomainName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblPcName;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxExam;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.PictureBox pbCandidate;
        private System.Windows.Forms.TextBox txtCandidateInitial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCandidateFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxAttempts;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDeleteCandidate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDeadline;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCurrentDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelConnected;
        private System.Windows.Forms.Timer timerHeartBeat;
    }
}