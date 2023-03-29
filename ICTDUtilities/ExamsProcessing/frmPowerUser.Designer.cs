namespace ICTDUtilities.ExamsProcessing
{
    partial class frmPowerUser
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
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.btnConnected = new System.Windows.Forms.Button();
            this.cbExamType = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndRange = new System.Windows.Forms.TextBox();
            this.txtBeginRange = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.btnAddSubjectToAllCandidates = new System.Windows.Forms.Button();
            this.btnClearSubjects = new System.Windows.Forms.Button();
            this.btnClearSchools = new System.Windows.Forms.Button();
            this.btnAddSchool = new System.Windows.Forms.Button();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.clbSchools = new System.Windows.Forms.CheckedListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 0);
            this.scMain.Name = "scMain";
            this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.btnConnected);
            this.scMain.Panel1.Controls.Add(this.cbExamType);
            this.scMain.Panel1.Controls.Add(this.Label7);
            this.scMain.Panel1.Controls.Add(this.cbYear);
            this.scMain.Panel1.Controls.Add(this.Label5);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.tcMain);
            this.scMain.Size = new System.Drawing.Size(836, 441);
            this.scMain.SplitterDistance = 74;
            this.scMain.TabIndex = 0;
            // 
            // btnConnected
            // 
            this.btnConnected.BackColor = System.Drawing.Color.DarkGray;
            this.btnConnected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnected.Location = new System.Drawing.Point(239, 5);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(122, 57);
            this.btnConnected.TabIndex = 53;
            this.btnConnected.Text = "Not Connected";
            this.btnConnected.UseVisualStyleBackColor = false;
            // 
            // cbExamType
            // 
            this.cbExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbExamType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExamType.FormattingEnabled = true;
            this.cbExamType.Items.AddRange(new object[] {
            "GABECE",
            "NAT",
            "PWASSCE",
            "WASSCE"});
            this.cbExamType.Location = new System.Drawing.Point(85, 37);
            this.cbExamType.Name = "cbExamType";
            this.cbExamType.Size = new System.Drawing.Size(114, 28);
            this.cbExamType.Sorted = true;
            this.cbExamType.TabIndex = 27;
            // 
            // Label7
            // 
            this.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label7.Location = new System.Drawing.Point(2, 41);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(77, 21);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Exam Type:";
            this.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbYear
            // 
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.Location = new System.Drawing.Point(85, 5);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(115, 28);
            this.cbYear.Sorted = true;
            this.cbYear.TabIndex = 25;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // Label5
            // 
            this.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Label5.Location = new System.Drawing.Point(4, 9);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(75, 21);
            this.Label5.TabIndex = 24;
            this.Label5.Text = "Year:";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tabPage1);
            this.tcMain.Controls.Add(this.tabPage2);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 0);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(836, 363);
            this.tcMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Tan;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnClearSubjects);
            this.tabPage1.Controls.Add(this.btnClearSchools);
            this.tabPage1.Controls.Add(this.btnAddSchool);
            this.tabPage1.Controls.Add(this.txtSchool);
            this.tabPage1.Controls.Add(this.rtbDisplay);
            this.tabPage1.Controls.Add(this.clbSchools);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(828, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEndRange);
            this.groupBox1.Controls.Add(this.txtBeginRange);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.btnAddSubjectToAllCandidates);
            this.groupBox1.Location = new System.Drawing.Point(210, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(130, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(59, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 21);
            this.label3.TabIndex = 27;
            this.label3.Text = "-";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(70, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 22);
            this.label2.TabIndex = 26;
            this.label2.Text = "End";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 22);
            this.label1.TabIndex = 25;
            this.label1.Text = "Begin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEndRange
            // 
            this.txtEndRange.Location = new System.Drawing.Point(70, 42);
            this.txtEndRange.MaxLength = 3;
            this.txtEndRange.Name = "txtEndRange";
            this.txtEndRange.Size = new System.Drawing.Size(49, 20);
            this.txtEndRange.TabIndex = 8;
            this.txtEndRange.TextChanged += new System.EventHandler(this.TrimTextBox_TextChanged);
            // 
            // txtBeginRange
            // 
            this.txtBeginRange.Location = new System.Drawing.Point(7, 42);
            this.txtBeginRange.MaxLength = 3;
            this.txtBeginRange.Name = "txtBeginRange";
            this.txtBeginRange.Size = new System.Drawing.Size(49, 20);
            this.txtBeginRange.TabIndex = 7;
            this.txtBeginRange.TextChanged += new System.EventHandler(this.TrimTextBox_TextChanged);
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(6, 16);
            this.txtSubject.MaxLength = 3;
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(114, 20);
            this.txtSubject.TabIndex = 6;
            this.txtSubject.TextChanged += new System.EventHandler(this.TrimTextBox_TextChanged);
            // 
            // btnAddSubjectToAllCandidates
            // 
            this.btnAddSubjectToAllCandidates.Location = new System.Drawing.Point(6, 90);
            this.btnAddSubjectToAllCandidates.Name = "btnAddSubjectToAllCandidates";
            this.btnAddSubjectToAllCandidates.Size = new System.Drawing.Size(113, 57);
            this.btnAddSubjectToAllCandidates.TabIndex = 2;
            this.btnAddSubjectToAllCandidates.Text = "Add subject for all candidates";
            this.btnAddSubjectToAllCandidates.UseVisualStyleBackColor = true;
            this.btnAddSubjectToAllCandidates.Click += new System.EventHandler(this.btnAddSubjectToAllCandidates_Click);
            // 
            // btnClearSubjects
            // 
            this.btnClearSubjects.Location = new System.Drawing.Point(217, 306);
            this.btnClearSubjects.Name = "btnClearSubjects";
            this.btnClearSubjects.Size = new System.Drawing.Size(75, 23);
            this.btnClearSubjects.TabIndex = 1;
            this.btnClearSubjects.Text = "Clear";
            this.btnClearSubjects.UseVisualStyleBackColor = true;
            this.btnClearSubjects.Click += new System.EventHandler(this.btnClearSubjects_Click);
            // 
            // btnClearSchools
            // 
            this.btnClearSchools.Location = new System.Drawing.Point(8, 306);
            this.btnClearSchools.Name = "btnClearSchools";
            this.btnClearSchools.Size = new System.Drawing.Size(75, 23);
            this.btnClearSchools.TabIndex = 1;
            this.btnClearSchools.Text = "Clear";
            this.btnClearSchools.UseVisualStyleBackColor = true;
            this.btnClearSchools.Click += new System.EventHandler(this.btnClearSchools_Click);
            // 
            // btnAddSchool
            // 
            this.btnAddSchool.Location = new System.Drawing.Point(126, 25);
            this.btnAddSchool.Name = "btnAddSchool";
            this.btnAddSchool.Size = new System.Drawing.Size(75, 23);
            this.btnAddSchool.TabIndex = 5;
            this.btnAddSchool.Text = "Add School";
            this.btnAddSchool.UseVisualStyleBackColor = true;
            this.btnAddSchool.Click += new System.EventHandler(this.btnAddSchool_Click);
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(8, 25);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.Size = new System.Drawing.Size(100, 20);
            this.txtSchool.TabIndex = 4;
            this.txtSchool.TextChanged += new System.EventHandler(this.TrimTextBox_TextChanged);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(535, 8);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.Size = new System.Drawing.Size(285, 321);
            this.rtbDisplay.TabIndex = 3;
            this.rtbDisplay.Text = "";
            // 
            // clbSchools
            // 
            this.clbSchools.FormattingEnabled = true;
            this.clbSchools.Location = new System.Drawing.Point(8, 55);
            this.clbSchools.Name = "clbSchools";
            this.clbSchools.Size = new System.Drawing.Size(193, 244);
            this.clbSchools.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(828, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmPowerUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(836, 441);
            this.Controls.Add(this.scMain);
            this.Name = "frmPowerUser";
            this.Text = "frmPowerUser";
            this.Load += new System.EventHandler(this.frmPowerUser_Load);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.tcMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer scMain;
        internal System.Windows.Forms.Button btnConnected;
        internal System.Windows.Forms.ComboBox cbExamType;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.ComboBox cbYear;
        internal System.Windows.Forms.Label Label5;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnClearSubjects;
        private System.Windows.Forms.Button btnClearSchools;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Button btnAddSchool;
        private System.Windows.Forms.TextBox txtSchool;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Button btnAddSubjectToAllCandidates;
        private System.Windows.Forms.CheckedListBox clbSchools;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndRange;
        private System.Windows.Forms.TextBox txtBeginRange;
    }
}