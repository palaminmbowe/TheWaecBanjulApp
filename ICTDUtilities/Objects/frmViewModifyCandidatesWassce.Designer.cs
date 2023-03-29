namespace ICTDUtilities.Objects
{
    partial class frmViewModifyCandidatesWassce
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewModifyCandidatesWassce));
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.lblCandidate = new System.Windows.Forms.Label();
            this.scBody = new System.Windows.Forms.SplitContainer();
            this.gbCandidateInfo = new System.Windows.Forms.GroupBox();
            this.txtCentNo = new System.Windows.Forms.TextBox();
            this.btnRetrieveCandidate = new System.Windows.Forms.Button();
            this.txtIndexNumber = new System.Windows.Forms.TextBox();
            this.cmbExamYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbCandidateBio = new System.Windows.Forms.GroupBox();
            this.panelPicture = new System.Windows.Forms.Panel();
            this.pbCandidate = new System.Windows.Forms.PictureBox();
            this.cmbDisability = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lblSchoolName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtCandidateName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDomainName = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblPcName = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbCandidateSubjects = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelGroup5 = new System.Windows.Forms.Panel();
            this.panelGroup4 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panelGroup3 = new System.Windows.Forms.Panel();
            this.panelGroup2 = new System.Windows.Forms.Panel();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panelGroup1 = new System.Windows.Forms.Panel();
            this.lblCandidateTotalSubjects = new System.Windows.Forms.Label();
            this.btnPowerUser = new System.Windows.Forms.Button();
            this.btnRemoveSubject = new System.Windows.Forms.Button();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.lbSubjectCandidates = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbSubjectsAll = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBody)).BeginInit();
            this.scBody.Panel1.SuspendLayout();
            this.scBody.Panel2.SuspendLayout();
            this.scBody.SuspendLayout();
            this.gbCandidateInfo.SuspendLayout();
            this.gbCandidateBio.SuspendLayout();
            this.panelPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCandidate)).BeginInit();
            this.gbCandidateSubjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.IsSplitterFixed = true;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.BackgroundImage = global::ICTDUtilities.Properties.Resources.header_890x100_no_background_flag;
            this.scMain.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scMain.Panel1.Controls.Add(this.lblCandidate);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scBody);
            this.scMain.Size = new System.Drawing.Size(886, 734);
            this.scMain.SplitterDistance = 78;
            this.scMain.TabIndex = 0;
            // 
            // lblCandidate
            // 
            this.lblCandidate.AutoSize = true;
            this.lblCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidate.Location = new System.Drawing.Point(671, 6);
            this.lblCandidate.Name = "lblCandidate";
            this.lblCandidate.Size = new System.Drawing.Size(203, 74);
            this.lblCandidate.TabIndex = 0;
            this.lblCandidate.Text = "WASSCE\r\nCANDIDATE";
            this.lblCandidate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.scBody.Panel1.Controls.Add(this.gbCandidateInfo);
            // 
            // scBody.Panel2
            // 
            this.scBody.Panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scBody.Panel2.BackgroundImage")));
            this.scBody.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.scBody.Panel2.Controls.Add(this.gbCandidateBio);
            this.scBody.Panel2.Controls.Add(this.lblDomainName);
            this.scBody.Panel2.Controls.Add(this.label13);
            this.scBody.Panel2.Controls.Add(this.lblPcName);
            this.scBody.Panel2.Controls.Add(this.lblUsername);
            this.scBody.Panel2.Controls.Add(this.label11);
            this.scBody.Panel2.Controls.Add(this.label10);
            this.scBody.Panel2.Controls.Add(this.gbCandidateSubjects);
            this.scBody.Size = new System.Drawing.Size(886, 652);
            this.scBody.SplitterDistance = 77;
            this.scBody.TabIndex = 0;
            this.scBody.TabStop = false;
            // 
            // gbCandidateInfo
            // 
            this.gbCandidateInfo.Controls.Add(this.btnCancelTop);
            this.gbCandidateInfo.Controls.Add(this.txtCentNo);
            this.gbCandidateInfo.Controls.Add(this.btnRetrieveCandidate);
            this.gbCandidateInfo.Controls.Add(this.txtIndexNumber);
            this.gbCandidateInfo.Controls.Add(this.cmbExamYear);
            this.gbCandidateInfo.Controls.Add(this.label1);
            this.gbCandidateInfo.Controls.Add(this.label14);
            this.gbCandidateInfo.Controls.Add(this.label2);
            this.gbCandidateInfo.Location = new System.Drawing.Point(7, 3);
            this.gbCandidateInfo.Name = "gbCandidateInfo";
            this.gbCandidateInfo.Size = new System.Drawing.Size(870, 70);
            this.gbCandidateInfo.TabIndex = 0;
            this.gbCandidateInfo.TabStop = false;
            // 
            // txtCentNo
            // 
            this.txtCentNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCentNo.Location = new System.Drawing.Point(217, 15);
            this.txtCentNo.Name = "txtCentNo";
            this.txtCentNo.Size = new System.Drawing.Size(194, 32);
            this.txtCentNo.TabIndex = 1;
            this.txtCentNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCentNo.TextChanged += new System.EventHandler(this.txtCentNo_TextChanged);
            // 
            // btnRetrieveCandidate
            // 
            this.btnRetrieveCandidate.Enabled = false;
            this.btnRetrieveCandidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveCandidate.ForeColor = System.Drawing.Color.Black;
            this.btnRetrieveCandidate.Location = new System.Drawing.Point(551, 12);
            this.btnRetrieveCandidate.Name = "btnRetrieveCandidate";
            this.btnRetrieveCandidate.Size = new System.Drawing.Size(197, 49);
            this.btnRetrieveCandidate.TabIndex = 3;
            this.btnRetrieveCandidate.Text = "Retrieve Candidate";
            this.btnRetrieveCandidate.UseVisualStyleBackColor = true;
            this.btnRetrieveCandidate.Click += new System.EventHandler(this.btnRetrieveCandidate_Click);
            // 
            // txtIndexNumber
            // 
            this.txtIndexNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndexNumber.Location = new System.Drawing.Point(424, 15);
            this.txtIndexNumber.Name = "txtIndexNumber";
            this.txtIndexNumber.Size = new System.Drawing.Size(71, 32);
            this.txtIndexNumber.TabIndex = 2;
            this.txtIndexNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtIndexNumber.TextChanged += new System.EventHandler(this.txtIndexNumber_TextChanged);
            // 
            // cmbExamYear
            // 
            this.cmbExamYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExamYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExamYear.FormattingEnabled = true;
            this.cmbExamYear.Location = new System.Drawing.Point(73, 15);
            this.cmbExamYear.Name = "cmbExamYear";
            this.cmbExamYear.Size = new System.Drawing.Size(121, 33);
            this.cmbExamYear.TabIndex = 0;
            this.cmbExamYear.SelectedIndexChanged += new System.EventHandler(this.cmbExamYear_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 27);
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
            this.label14.Location = new System.Drawing.Point(247, 47);
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
            this.label2.Location = new System.Drawing.Point(432, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Index No.:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbCandidateBio
            // 
            this.gbCandidateBio.BackColor = System.Drawing.Color.Transparent;
            this.gbCandidateBio.Controls.Add(this.panelPicture);
            this.gbCandidateBio.Controls.Add(this.cmbDisability);
            this.gbCandidateBio.Controls.Add(this.label8);
            this.gbCandidateBio.Controls.Add(this.dateOfBirth);
            this.gbCandidateBio.Controls.Add(this.cmbSex);
            this.gbCandidateBio.Controls.Add(this.lblSchoolName);
            this.gbCandidateBio.Controls.Add(this.label5);
            this.gbCandidateBio.Controls.Add(this.lblSex);
            this.gbCandidateBio.Controls.Add(this.txtCandidateName);
            this.gbCandidateBio.Controls.Add(this.label3);
            this.gbCandidateBio.Enabled = false;
            this.gbCandidateBio.Location = new System.Drawing.Point(7, 3);
            this.gbCandidateBio.Name = "gbCandidateBio";
            this.gbCandidateBio.Size = new System.Drawing.Size(870, 233);
            this.gbCandidateBio.TabIndex = 0;
            this.gbCandidateBio.TabStop = false;
            // 
            // panelPicture
            // 
            this.panelPicture.BackColor = System.Drawing.Color.White;
            this.panelPicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPicture.Controls.Add(this.pbCandidate);
            this.panelPicture.Location = new System.Drawing.Point(649, 27);
            this.panelPicture.Name = "panelPicture";
            this.panelPicture.Size = new System.Drawing.Size(200, 200);
            this.panelPicture.TabIndex = 14;
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
            // cmbDisability
            // 
            this.cmbDisability.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbDisability.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbDisability.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisability.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDisability.FormattingEnabled = true;
            this.cmbDisability.Items.AddRange(new object[] {
            "1 - NORMAL",
            "2 - VISUALLY IMPAIRED",
            "3 - HEARING/SPEECH IMPAIRED",
            "4 - PHYSICALLY IMPAIRED",
            "5 - MENTALLY IMPAIRED",
            "6 - SPASTIC/PALSY/EPILECTIC CONDIDTIONS",
            "7 - LOW VISSION",
            "8 - OTHER"});
            this.cmbDisability.Location = new System.Drawing.Point(68, 165);
            this.cmbDisability.Name = "cmbDisability";
            this.cmbDisability.Size = new System.Drawing.Size(343, 33);
            this.cmbDisability.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Disability:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateOfBirth
            // 
            this.dateOfBirth.CustomFormat = "dd/MM/yyyy";
            this.dateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateOfBirth.Location = new System.Drawing.Point(68, 126);
            this.dateOfBirth.Name = "dateOfBirth";
            this.dateOfBirth.Size = new System.Drawing.Size(155, 32);
            this.dateOfBirth.TabIndex = 6;
            // 
            // cmbSex
            // 
            this.cmbSex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "1 - Male",
            "2 - Female"});
            this.cmbSex.Location = new System.Drawing.Point(68, 85);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(155, 33);
            this.cmbSex.TabIndex = 5;
            this.cmbSex.SelectedIndexChanged += new System.EventHandler(this.cmbSex_SelectedIndexChanged);
            // 
            // lblSchoolName
            // 
            this.lblSchoolName.AutoSize = true;
            this.lblSchoolName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchoolName.Location = new System.Drawing.Point(12, 16);
            this.lblSchoolName.Name = "lblSchoolName";
            this.lblSchoolName.Size = new System.Drawing.Size(0, 24);
            this.lblSchoolName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "DOB:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(14, 95);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(45, 13);
            this.lblSex.TabIndex = 7;
            this.lblSex.Text = "Gender:";
            this.lblSex.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCandidateName
            // 
            this.txtCandidateName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCandidateName.Location = new System.Drawing.Point(68, 46);
            this.txtCandidateName.Name = "txtCandidateName";
            this.txtCandidateName.Size = new System.Drawing.Size(507, 32);
            this.txtCandidateName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDomainName
            // 
            this.lblDomainName.AutoSize = true;
            this.lblDomainName.Location = new System.Drawing.Point(505, 555);
            this.lblDomainName.Name = "lblDomainName";
            this.lblDomainName.Size = new System.Drawing.Size(0, 13);
            this.lblDomainName.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(454, 555);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Domain:";
            this.label13.Visible = false;
            // 
            // lblPcName
            // 
            this.lblPcName.AutoSize = true;
            this.lblPcName.Location = new System.Drawing.Point(273, 557);
            this.lblPcName.Name = "lblPcName";
            this.lblPcName.Size = new System.Drawing.Size(0, 13);
            this.lblPcName.TabIndex = 9;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(81, 555);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(0, 13);
            this.lblUsername.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(214, 557);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "PC Name:";
            this.label11.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 555);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Username:";
            this.label10.Visible = false;
            // 
            // gbCandidateSubjects
            // 
            this.gbCandidateSubjects.BackColor = System.Drawing.Color.Transparent;
            this.gbCandidateSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.gbCandidateSubjects.Controls.Add(this.btnCancel);
            this.gbCandidateSubjects.Controls.Add(this.panelGroup5);
            this.gbCandidateSubjects.Controls.Add(this.panelGroup4);
            this.gbCandidateSubjects.Controls.Add(this.btnExit);
            this.gbCandidateSubjects.Controls.Add(this.panelGroup3);
            this.gbCandidateSubjects.Controls.Add(this.panelGroup2);
            this.gbCandidateSubjects.Controls.Add(this.btnUpdate);
            this.gbCandidateSubjects.Controls.Add(this.panelGroup1);
            this.gbCandidateSubjects.Controls.Add(this.lblCandidateTotalSubjects);
            this.gbCandidateSubjects.Controls.Add(this.btnPowerUser);
            this.gbCandidateSubjects.Controls.Add(this.btnRemoveSubject);
            this.gbCandidateSubjects.Controls.Add(this.btnAddSubject);
            this.gbCandidateSubjects.Controls.Add(this.lbSubjectCandidates);
            this.gbCandidateSubjects.Controls.Add(this.label7);
            this.gbCandidateSubjects.Controls.Add(this.lbSubjectsAll);
            this.gbCandidateSubjects.Controls.Add(this.label6);
            this.gbCandidateSubjects.Enabled = false;
            this.gbCandidateSubjects.Location = new System.Drawing.Point(7, 244);
            this.gbCandidateSubjects.Name = "gbCandidateSubjects";
            this.gbCandidateSubjects.Size = new System.Drawing.Size(870, 310);
            this.gbCandidateSubjects.TabIndex = 0;
            this.gbCandidateSubjects.TabStop = false;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(754, 91);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 57);
            this.btnCancel.TabIndex = 14;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panelGroup5
            // 
            this.panelGroup5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGroup5.BackgroundImage")));
            this.panelGroup5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGroup5.Location = new System.Drawing.Point(681, 264);
            this.panelGroup5.Name = "panelGroup5";
            this.panelGroup5.Size = new System.Drawing.Size(25, 25);
            this.panelGroup5.TabIndex = 21;
            this.panelGroup5.Visible = false;
            // 
            // panelGroup4
            // 
            this.panelGroup4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGroup4.BackgroundImage")));
            this.panelGroup4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGroup4.Location = new System.Drawing.Point(681, 206);
            this.panelGroup4.Name = "panelGroup4";
            this.panelGroup4.Size = new System.Drawing.Size(25, 25);
            this.panelGroup4.TabIndex = 20;
            this.panelGroup4.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(754, 167);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(102, 57);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panelGroup3
            // 
            this.panelGroup3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGroup3.BackgroundImage")));
            this.panelGroup3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGroup3.Location = new System.Drawing.Point(681, 148);
            this.panelGroup3.Name = "panelGroup3";
            this.panelGroup3.Size = new System.Drawing.Size(25, 25);
            this.panelGroup3.TabIndex = 19;
            this.panelGroup3.Visible = false;
            // 
            // panelGroup2
            // 
            this.panelGroup2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelGroup2.BackgroundImage")));
            this.panelGroup2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGroup2.Location = new System.Drawing.Point(681, 90);
            this.panelGroup2.Name = "panelGroup2";
            this.panelGroup2.Size = new System.Drawing.Size(25, 25);
            this.panelGroup2.TabIndex = 18;
            this.panelGroup2.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(754, 15);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 57);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panelGroup1
            // 
            this.panelGroup1.BackgroundImage = global::ICTDUtilities.Properties.Resources.Deletered16x16;
            this.panelGroup1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelGroup1.Location = new System.Drawing.Point(681, 32);
            this.panelGroup1.Name = "panelGroup1";
            this.panelGroup1.Size = new System.Drawing.Size(25, 25);
            this.panelGroup1.TabIndex = 17;
            this.panelGroup1.Visible = false;
            // 
            // lblCandidateTotalSubjects
            // 
            this.lblCandidateTotalSubjects.AutoSize = true;
            this.lblCandidateTotalSubjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCandidateTotalSubjects.Location = new System.Drawing.Point(501, 11);
            this.lblCandidateTotalSubjects.Name = "lblCandidateTotalSubjects";
            this.lblCandidateTotalSubjects.Size = new System.Drawing.Size(0, 20);
            this.lblCandidateTotalSubjects.TabIndex = 15;
            // 
            // btnPowerUser
            // 
            this.btnPowerUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPowerUser.ForeColor = System.Drawing.Color.Black;
            this.btnPowerUser.Location = new System.Drawing.Point(794, 264);
            this.btnPowerUser.Name = "btnPowerUser";
            this.btnPowerUser.Size = new System.Drawing.Size(62, 40);
            this.btnPowerUser.TabIndex = 16;
            this.btnPowerUser.Text = "P U";
            this.btnPowerUser.UseVisualStyleBackColor = true;
            this.btnPowerUser.Visible = false;
            this.btnPowerUser.Click += new System.EventHandler(this.btnPowerUser_Click);
            // 
            // btnRemoveSubject
            // 
            this.btnRemoveSubject.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveSubject.Location = new System.Drawing.Point(316, 184);
            this.btnRemoveSubject.Name = "btnRemoveSubject";
            this.btnRemoveSubject.Size = new System.Drawing.Size(39, 107);
            this.btnRemoveSubject.TabIndex = 11;
            this.btnRemoveSubject.Text = "<<";
            this.btnRemoveSubject.UseVisualStyleBackColor = true;
            this.btnRemoveSubject.Click += new System.EventHandler(this.btnRemoveSubject_Click);
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.ForeColor = System.Drawing.Color.Black;
            this.btnAddSubject.Location = new System.Drawing.Point(316, 32);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(39, 107);
            this.btnAddSubject.TabIndex = 10;
            this.btnAddSubject.Text = ">>";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click);
            // 
            // lbSubjectCandidates
            // 
            this.lbSubjectCandidates.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubjectCandidates.FormattingEnabled = true;
            this.lbSubjectCandidates.ItemHeight = 17;
            this.lbSubjectCandidates.Location = new System.Drawing.Point(362, 32);
            this.lbSubjectCandidates.Name = "lbSubjectCandidates";
            this.lbSubjectCandidates.Size = new System.Drawing.Size(302, 259);
            this.lbSubjectCandidates.Sorted = true;
            this.lbSubjectCandidates.TabIndex = 12;
            this.lbSubjectCandidates.SelectedIndexChanged += new System.EventHandler(this.lbSubjectCandidates_SelectedIndexChanged);
            this.lbSubjectCandidates.DoubleClick += new System.EventHandler(this.lbSubjectCandidates_DoubleClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(362, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Subjects (Candidate\'s)";
            // 
            // lbSubjectsAll
            // 
            this.lbSubjectsAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSubjectsAll.FormattingEnabled = true;
            this.lbSubjectsAll.ItemHeight = 17;
            this.lbSubjectsAll.Location = new System.Drawing.Point(6, 32);
            this.lbSubjectsAll.Name = "lbSubjectsAll";
            this.lbSubjectsAll.Size = new System.Drawing.Size(302, 259);
            this.lbSubjectsAll.Sorted = true;
            this.lbSubjectsAll.TabIndex = 9;
            this.lbSubjectsAll.DoubleClick += new System.EventHandler(this.lbSubjectsAll_DoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Subjects (Available)";
            // 
            // btnCancelTop
            // 
            this.btnCancelTop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTop.ForeColor = System.Drawing.Color.Black;
            this.btnCancelTop.Location = new System.Drawing.Point(754, 16);
            this.btnCancelTop.Name = "btnCancelTop";
            this.btnCancelTop.Size = new System.Drawing.Size(102, 41);
            this.btnCancelTop.TabIndex = 14;
            this.btnCancelTop.Text = "Cancel";
            this.btnCancelTop.UseVisualStyleBackColor = true;
            this.btnCancelTop.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmViewModifyCandidatesWassce
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.CancelButton = this.btnCancelTop;
            this.ClientSize = new System.Drawing.Size(886, 734);
            this.Controls.Add(this.scMain);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmViewModifyCandidatesWassce";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmViewModifyCandidates";
            this.Load += new System.EventHandler(this.frmViewModifyCandidates_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel1.PerformLayout();
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scBody.Panel1.ResumeLayout(false);
            this.scBody.Panel2.ResumeLayout(false);
            this.scBody.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBody)).EndInit();
            this.scBody.ResumeLayout(false);
            this.gbCandidateInfo.ResumeLayout(false);
            this.gbCandidateInfo.PerformLayout();
            this.gbCandidateBio.ResumeLayout(false);
            this.gbCandidateBio.PerformLayout();
            this.panelPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCandidate)).EndInit();
            this.gbCandidateSubjects.ResumeLayout(false);
            this.gbCandidateSubjects.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scBody;
        private System.Windows.Forms.GroupBox gbCandidateInfo;
        private System.Windows.Forms.Button btnRetrieveCandidate;
        private System.Windows.Forms.TextBox txtIndexNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbExamYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCandidateSubjects;
        private System.Windows.Forms.GroupBox gbCandidateBio;
        private System.Windows.Forms.TextBox txtCandidateName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSchoolName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRemoveSubject;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbSubjectCandidates;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lbSubjectsAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pbCandidate;
        private System.Windows.Forms.DateTimePicker dateOfBirth;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ComboBox cmbDisability;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCandidate;
        private System.Windows.Forms.Label lblPcName;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblDomainName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCentNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblCandidateTotalSubjects;
        private System.Windows.Forms.Button btnPowerUser;
        private System.Windows.Forms.Panel panelPicture;
        private System.Windows.Forms.Panel panelGroup5;
        private System.Windows.Forms.Panel panelGroup4;
        private System.Windows.Forms.Panel panelGroup3;
        private System.Windows.Forms.Panel panelGroup2;
        private System.Windows.Forms.Panel panelGroup1;
        private System.Windows.Forms.Button btnCancelTop;
    }
}