using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaecLibrary;
using ICTDUtilities.ExamsProcessing;

namespace ICTDUtilities.Objects
{
    public partial class frmViewModifyCandidates : Form
    {
        string username;
        string pcName;
        string domainName;
        dbConnection3 db = new dbConnection3();
        System.IO.FileInfo dbFile;
        CandidateGabece candidate;

        public frmViewModifyCandidates()
        {
            InitializeComponent();
        }

        private void frmViewModifyCandidates_Load(object sender, EventArgs e)
        {
            
            SetupComponents();
            SetupDB();
            LoadDefaults();
        }

        private bool LoadDefaults()
        {
            // load common tables
            try
            {
                // load subjects
                db.con.Open();

                db.cmd.CommandText = "SELECT ShortSubjCode, Description, GenSubjCode FROM SubjectsGabece;";

                db.dr = db.cmd.ExecuteReader();
                Common.SubjectsGabece.Clear();
                while (db.dr.Read())
                {
                    // assign subjects
                    Common.SubjectsGabece.Add(new Subject(db.dr.GetString(0), db.dr.GetString(1)));
                }

                if (!db.dr.IsClosed) db.dr.Close();

                // load school

                db.cmd.CommandText = "SELECT CentNo, CentName FROM CentresGabece;";

                db.dr = db.cmd.ExecuteReader();
                Common.SchoolsGabece.Clear();
                while (db.dr.Read())
                {
                    // assign school
                    Common.SchoolsGabece.Add(new School(db.dr.GetString(0), db.dr.GetString(1)));
                }

                if (!db.dr.IsClosed) db.dr.Close();

                // load school of choice

                db.cmd.CommandText = "SELECT SCHCODE, SCHOOLNAME, SCHADDRESS FROM SchoolOfChoice;";

                db.dr = db.cmd.ExecuteReader();
                Common.SchoolOfChoice.Clear();
                while (db.dr.Read())
                {
                    // assign schoolOfChoice
                    Common.SchoolOfChoice.Add(new SchoolOfChoice(db.dr.GetString(0), db.dr.GetString(1)));
                }

                if (!db.dr.IsClosed) db.dr.Close();

                // load deadlines
                db.cmd.CommandText = "SELECT ExamYear, ExamInitial, CandidateModificationBegin, CandidateModificationEnD, MarksKeyingBegin, MarksKeyingEnd, NOW() as CurrentDate FROM Deadlines;";

                db.dr = db.cmd.ExecuteReader();
                Common.Deadline.Clear();
                while (db.dr.Read())
                {
                    // deadlines
                    Common.Deadline.Add(new Deadline(
                        db.dr.GetString(0), db.dr.GetString(1),
                        db.dr.GetDateTime(2), db.dr.GetDateTime(3), db.dr.GetDateTime(4), db.dr.GetDateTime(5), db.dr.GetDateTime(6)));
                }

                if (!db.dr.IsClosed) db.dr.Close();

                // load schools


                if(((this.domainName.ToLower() == "palamin") && (this.pcName.ToLower() == "palamin")) ||
                    ((this.domainName.ToLower() == "csd") && (this.pcName.ToLower() == "waeccsdd020")))
                    btnPowerUser.Visible = true;
                else
                    btnPowerUser.Visible = false;

                cmbExamYear.DroppedDown = true;
                //dateOfBirth.MinDate = DateTime.Now.Subtract(;

                scBody.Panel2Collapsed = true;

                //this.ClientSize = new System.Drawing.Size(894, 911);
                this.Size = new Size(910, 260);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading subjects: " + ex.Message);
            }
            finally
            {
                db.con.Close();
            }
            return false;
        }
                
        private bool SetupDB()
        {
            try
            {
                if (SetupDbFile())
                {
                    if (generateConnectionString())
                    {
                        //successfully connected to db
                        this.BackColor = Color.MidnightBlue;
                    }
                    else
                    {
                        this.BackColor = Color.Red;
                        MessageBox.Show("There was an error connecting to the DB!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Setting up DB: " + ex.Message);
            }
            finally
            {

            }
            return false;
        }

        private Boolean generateConnectionString()
        {
            db = new dbConnection3("ExamsProcessing.accdb", dbFile.Directory.ToString(), "CsdProcessDb");
            if (db.isConnected())
                return true;
            else
            {
                //try connecting local
                db = new dbConnection3("ExamsProcessing.accdb", ICTDUtilities.Properties.Resources.dbServerPathLocal, "CsdExamsProcessingDb");
            }
            return db.isConnected();
        }
        
        private bool SetupDbFile()
        {
            try
            {
                //if (((domain.ToLower() == "palamin") && (pcName.ToLower() == "palamin")) || ((domain.ToLower() == "csd") || (pcName.ToLower() == "waeccsdd020")))
                if (
                    (((this.domainName.ToLower() == "ictd") && (this.pcName.ToLower() == "pvm02")) ||
                    ((this.domainName.ToLower() == "palamin2") && (this.pcName.ToLower() == "palam")) ||
                    ((this.domainName.ToLower() == "ictd") && (this.pcName.ToLower() == "w-ictd19d002"))) &&
                    (MessageBox.Show("Local?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    // check1

                    try
                    {
                        dbFile = new System.IO.FileInfo(String.Concat(ICTDUtilities.Properties.Resources.dbServerPathLocal, "\\", ICTDUtilities.Properties.Resources.dbName));
                        if (dbFile.Exists)
                        {
                            lblCandidate.ForeColor = Color.Red;
                            return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error setting up local db: " + ex.Message);
                    }

                    this.BackColor = Color.Red;
                    return false;
                }


                dbFile = new System.IO.FileInfo(String.Concat(ICTDUtilities.Properties.Resources.dbServerPath, "\\", ICTDUtilities.Properties.Resources.dbName));
                if (dbFile.Exists)
                {
                    this.BackColor = Color.MidnightBlue;
                    return true;
                }
                else
                {
                    //try local

                    //if ((userName.ToLower() != "palamin") || ((pcName.ToLower() != "palamin") || (pcName.ToLower() != "waeccsdd020")))
                    if (
                        ((this.username.ToLower() != "palamin") && ((this.pcName.ToLower() != "palamin") || ((this.domainName.ToLower() == "ictd") && (this.pcName.ToLower() != "w-ictd19d002")))))
                    {
                        MessageBox.Show("There was a problem connecting to the data source, please close program and try again.",
                            "Error Connecting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    try
                    {
                        dbFile = new System.IO.FileInfo(String.Concat(ICTDUtilities.Properties.Resources.dbServerPathLocal, "\\", ICTDUtilities.Properties.Resources.dbName));
                        if (dbFile.Exists)
                        {
                            lblCandidate.ForeColor = Color.Red;
                            return true;
                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("There was a problem connecting to the data source, please close program and try again: " + ex.Message,
                            "Error Connecting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Error setting up local db: " + ex.Message);
                    }

                    this.BackColor = Color.Red;
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error accessing file. Check whether it exists: " + ex.Message);
                this.BackColor = Color.Red;
            }
            return false;
        }

        private bool SetupComponents()
        {
            try
            {
                //date - use current date
                cmbExamYear.Items.Add(DateTime.Now.Year);
                //cmbExamYear.DroppedDown = true;
                username = System.Environment.UserName;
                lblUsername.Text = username;
                pcName = System.Environment.MachineName;
                lblPcName.Text = pcName;
                domainName = System.Environment.UserDomainName;
                lblDomainName.Text = domainName;
                dateOfBirth.Format = DateTimePickerFormat.Custom;
                dateOfBirth.CustomFormat = "dd/MM/yyyy";
                
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in SetupComponents: " + ex.Message);
            }
            return false;
        }

        private void cmbExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCentNo.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRetrieveCandidate_Click(object sender, EventArgs e)
        {
            if (!RetrieveCandidate())
            {
                MessageBox.Show("Error getting candidate. Please check what you've entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnCancel.PerformClick();
                scBody.Panel2Collapsed = true;
                return;
            }
            else
            {
                gbCandidateInfo.Enabled = false;
                btnUpdate.Enabled = true;

                //check for deadline and disable fields
                foreach (Deadline d in Common.Deadline)
                {
                    if(d.ExamYear.Equals(cmbExamYear.Text) & (d.ExamInitial.Equals(txtCentNo.Text[0].ToString())))
                    {
                        //selected right record
                        if(!((d.CurrentDate > d.CandidateModificationBegin) && (d.CurrentDate < d.CandidateModificationEnd)))
                        {
                            // before or after deadline
                            DisableFields();
                        }
                    }
                }
                scBody.Panel2Collapsed = false;
                this.Size = new Size(910, 950);
                this.CancelButton = this.btnCancel;
                btnCancel.Focus();
            }
                
        }

        private bool RetrieveCandidate()
        {
            try
            {
                //create new candidate, then retrieve details.

                switch (txtCentNo.Text[0])
                {
                    case '7':
                        candidate = new CandidateGabece(cmbExamYear.Items[0].ToString(), txtCentNo.Text, txtIndexNumber.Text, db.connectionString);
                        break;
                    default:
                        MessageBox.Show("Not yeat implemented!", ":::", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
                
                if(candidate.RetrieveCandidateDetails())
                {
                    gbCandidateBio.Enabled = true;
                    gbCandidateSubjects.Enabled = true;

                    // retrieved successfully load details in form
                    txtCandidateName.Text = candidate.CandidateName;

                    // get school name

                    foreach (School s in Common.SchoolsGabece)
                    {
                        if(s.Code.Equals(txtCentNo.Text))
                        {
                            // school exists, load and break
                            lblSchoolName.Text = s.Description;
                            break;
                        }
                    }

                    //retrieve sex
                    cmbSex.Text = candidate.Sex.Code + " - " + candidate.Sex.Description;

                    switch (candidate.Sex.Code)
                    {
                        case "1":
                            pbCandidate.Image = ICTDUtilities.Properties.Resources.PlaceHolderMale;
                            //cmbSex.Items.Add("2 - Female");
                            break;
                        case "2":
                            pbCandidate.Image = ICTDUtilities.Properties.Resources.PlaceHolderFemale;
                            break;
                        default:
                            pbCandidate.Image = null;
                            //cmbSex.Items.Add("1 - Male");
                            break;
                    }

                    cmbDisability.Text = candidate.Disability.Code + " - " + candidate.Disability.Description;


                    dateOfBirth.Format = DateTimePickerFormat.Custom;
                    //dateOfBirth.CustomFormat;
                    dateOfBirth.Value = candidate.DateOfBirth.Date;

                    if (candidate.CentNo[0] == '7')
                    {
                        cmbChoice.Enabled = true;
                        cmbChoice.Text = candidate.SchoolOfChoice.Code + " - " + candidate.SchoolOfChoice.Name;
                        cmbChoice2.Text = candidate.SchoolOfChoice2.Code + " - " + candidate.SchoolOfChoice2.Name;
                        cmbChoice3.Text = candidate.SchoolOfChoice3.Code + " - " + candidate.SchoolOfChoice3.Name;
                    }
                    else
                        cmbChoice.Enabled = false;

                    LoadSubjects();

                    // populate subjects all
                    foreach (object s in lbSubjectCandidates.Items)
	                {
                        for (int i = 0; i < lbSubjectCandidates.Items.Count - 1; i++)
                        {
                            lbSubjectsAll.Items.Remove(s);
                            //if(lbSubjectsAll.Items[i].ToString().Contains(s.ToString()))
                            //{
                            //    // found a match - remove from list
                            //    lbSubjectsAll.Items.Remove(s);
                            //}
                        }
		 
	                }

                    

                }
                else
                {
                    gbCandidateBio.Enabled = false;
                    gbCandidateSubjects.Enabled = false;
                    MessageBox.Show("No records found. Please check and try again.", "No records found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error retrieving candidate: " + ex.Message);
            }
            finally
            {

            }

            return false;
        }

        private void LoadSubjects()
        {
            // load subjects
            lbSubjectCandidates.Items.Clear();
            foreach (Subject s in candidate.Subjects)
            {
                lbSubjectCandidates.Items.Add(s.ShortCode + " - " + s.Name);
            }

            lblCandidateTotalSubjects.Text = candidate.TotalSubjects.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtCentNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(!txtCentNo.Text.Equals(""))
                    switch (txtCentNo.Text[0])
                    {
                        case '7':
                            //case '8':
                            break;
                        default:
                            txtCentNo.Text = "";
                            break;
                    }
                

                if (txtCentNo.TextLength == 5 || txtCentNo.TextLength == 7)
                {
                    txtIndexNumber.Focus();
                    txtCentNo.BackColor = Color.White;
                }
                else
                    txtCentNo.BackColor = Color.PaleVioletRed;
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }

        private bool PopulateFieldsData()
        {
            if (txtCentNo.TextLength == 5 || txtCentNo.TextLength == 7)
            {
                btnRetrieveCandidate.Enabled = true;
                txtIndexNumber.Focus();

                // load appropriate subject list
                switch (txtCentNo.Text[0])
                {
                    case '7':
                        //GABECE
                        lbSubjectsAll.Items.Clear();

                        //load subjects
                        foreach (Subject s in Common.SubjectsGabece)
                        {
                            lbSubjectsAll.Items.Add(s.ShortCode + " - " + s.Name);
                        }

                        //load school of choice
                        cmbChoice.Items.Clear();
                        foreach (SchoolOfChoice s in Common.SchoolOfChoice)
                        {
                            cmbChoice.Items.Add(s.Code + " - " + s.Name);
                            cmbChoice2.Items.Add(s.Code + " - " + s.Name);
                            cmbChoice3.Items.Add(s.Code + " - " + s.Name);
                        }

                        break;
                    case '8':
                        //WASSCE
                        break;
                    default:
                        break;
                }

                return true;
            }

            else
                btnRetrieveCandidate.Enabled = false;

            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(txtIndexNumber.Text.Equals(""))
                ResetFields(0);
            else
                ResetFields(1);
        }

        private bool ResetFields(int code)
        {
            try
            {
                lbSubjectCandidates.Items.Clear();
                lbSubjectsAll.Items.Clear();
                cmbChoice.Text = "";
                cmbDisability.Text = "";
                dateOfBirth.Value = DateTime.Now;
                cmbSex.Text = "";
                lblSchoolName.Text = "";
                txtCandidateName.Text = "";

                btnUpdate.Enabled = false;

                gbCandidateBio.Enabled = false;
                gbCandidateSubjects.Enabled = false;
                gbCandidateInfo.Enabled = true;

                this.Size = new Size(910, 260);
                scBody.Panel2Collapsed = true;
                this.CancelButton = this.btnCancelTop;

                switch (code)
	            {
                    case 0:
                        //hard reset
                        txtIndexNumber.Text = "";
                        txtCentNo.Text = "";
                        txtCentNo.Focus();
                        break;
                    case 1:
                        txtIndexNumber.Text = "";
                        txtIndexNumber.Focus();
                        break;
		            default:
                    break;
	            }


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in ResetFields(): " + ex.Message);
            }

            return false;
        }

        private void txtIndexNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtIndexNumber.TextLength != 3)
            {
                //clear all except cent no
                ResetFields(-1);
                btnRetrieveCandidate.Enabled = false;
                txtIndexNumber.BackColor = Color.PaleVioletRed;
            }
            else
            {
                PopulateFieldsData();
                btnRetrieveCandidate.Enabled = true;
                btnRetrieveCandidate.Focus();
                txtIndexNumber.BackColor = Color.White;
            }
                
        }

        private void btnRemoveSubject_Click(object sender, EventArgs e)
        {
            switch (txtCentNo.Text[0])
            {
                case '7':
                    // don't all the first four subjects to be reomved
                    if (lbSubjectCandidates.SelectedIndex < 4)
                    {
                        MessageBox.Show("Cannot remove core subjects!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                        
                    if (AddRemoveGabeceSubject(1))
                    {
                        lblCandidateTotalSubjects.Text = candidate.Subjects.Count.ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            switch (txtCentNo.Text[0])
            {
                case '7':
                    if (AddRemoveGabeceSubject(0))
                    {
                        lblCandidateTotalSubjects.Text = candidate.TotalSubjects.ToString();
                    }
                    break;
                default:
                    break;
            }
        }

        private bool AddRemoveGabeceSubject(int code)
        {
            try
            {
                switch (code)
                {
                    case 0:
                        // Add subject
                        // check for total subject
                        if(candidate.TotalSubjects >= 9)
                        {
                            MessageBox.Show("Cannot add more subjects. Please check.", "Maximum Subjects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if(candidate.AddSubject(lbSubjectsAll.SelectedItem.ToString().Substring(0,3)))
                        {
                            lbSubjectCandidates.Items.Add(lbSubjectsAll.SelectedItem);
                            lbSubjectsAll.Items.RemoveAt(lbSubjectsAll.SelectedIndex);
                        }
                        break;
                    case 1:
                        // Remove subject
                        // check for total subject
                        if (candidate.TotalSubjects <= 7)
                        {
                            MessageBox.Show("Cannot remove more subjects. Please check.", "Minimum Subjects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }

                        if (candidate.RemoveSubject(lbSubjectCandidates.SelectedItem.ToString().Substring(0, 3)))
                        {
                            lbSubjectsAll.Items.Add(lbSubjectCandidates.SelectedItem);
                            lbSubjectCandidates.Items.RemoveAt(lbSubjectCandidates.SelectedIndex);
                        }
                        else
                        {
                            MessageBox.Show("Cannot remove subject. Results in group violation. Please check.", "Group Violation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        break;
                    default:
                        return false;
                }

                LoadSubjects();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding/removing GABECE Subjects: " + ex.Message);
            }
            return false;
        }

        private void lbSubjectCandidates_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCandidateTotalSubjects.Text = candidate.TotalSubjects.ToString();
        }

        private void lbSubjectCandidates_Validated(object sender, EventArgs e)
        {
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("About to update, do you want to continue?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes) return;

            if (UpdateCandidate())
            {
                MessageBox.Show("Saved Successfully!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnCancel.PerformClick();
            }
            else MessageBox.Show("Something went wrong. Please check and try agian.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool UpdateCandidate()
        {
            try
            {
                try
                {
                    if (txtCandidateName.Text.Equals(""))
                    {
                        return false;
                    }
                    if (cmbSex.Text.Substring(0, 1).Equals(""))
                    {
                        return false;
                    }
                    if (cmbDisability.Text.Substring(0, 1).Equals(""))
                    {
                        return false;
                    }
                    if (cmbChoice.Text.Substring(0, 4).Equals(""))
                    {
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error checking fields: " + ex.Message);
                    return false;
                }
                    
                candidate.CandidateName = txtCandidateName.Text.Trim().ToUpper();
                candidate.Sex.Code = cmbSex.Text.Substring(0, 1);
                candidate.DisabilityCode = int.Parse(cmbDisability.Text.Substring(0, 1));
                candidate.DateOfBirth = dateOfBirth.Value;
                candidate.SchoolOfChoice.Code = cmbChoice.Text.Substring(0,4);
                candidate.SchoolOfChoice2.Code = cmbChoice2.Text.Substring(0, 4);
                candidate.SchoolOfChoice3.Code = cmbChoice3.Text.Substring(0, 4);

                return candidate.UpdateCandidateDetails(username, pcName, domainName);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error updating candidate: " + ex.Message);
            }
            return false;
        }

        private void txtCandidateName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmbDisability_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void dateOfBirth_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private bool DisableFields()
        {
            try
            {
                //lbSubjectCandidates.Items.Clear();
                //cmbChoice.Text = "";
                //cmbDisability.Text = "";
                //dateOfBirth.Value = DateTime.Now;
                //cmbSex.Text = "";
                //lblSchoolName.Text = "";
                //txtCandidateName.Text = "";

                btnUpdate.Enabled = false;

                gbCandidateInfo.Enabled = true;
                gbCandidateBio.Enabled = false;
                gbCandidateSubjects.Enabled = false;
                //scBody.Panel2Collapsed = true;

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in DisableFields(): " + ex.Message);
            }

            return false;
        }

        private void btnPowerUser_Click(object sender, EventArgs e)
        {
            frmPowerUser frmPu = new frmPowerUser();
            // set defaults
            frmPu.db = this.db;
            frmPu.ShowDialog();
        }

        private void lblSex_Click(object sender, EventArgs e)
        {

        }

        private void lbSubjectCandidates_DoubleClick(object sender, EventArgs e)
        {
            btnRemoveSubject.PerformClick();
        }

        private void lbSubjectsAll_DoubleClick(object sender, EventArgs e)
        {
            btnAddSubject.PerformClick();
        }
    }

}
