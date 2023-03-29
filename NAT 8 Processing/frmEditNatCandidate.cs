using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using NAT_8_Processing.Utility;
using NAT8Processing.Model;

namespace NAT8Processing
{
    public partial class frmEditNatCandidate : Form
    {
        List<uspDeadline_GetByExamID_ExamYear_Result> deadline;
        List<ServerGetDateTime> serverDateTime;
        List<uspGetNatCandidate_Result> currentCandidate;
        uspGetCentre_Result currentCentre;

        public frmEditNatCandidate()
        {
            InitializeComponent();
        }

        private void frmEditNatCandidate_Load(object sender, EventArgs e)
        {
            comboBoxExam.SelectedIndex = 0;
            lblUsername.Text = WaecUtils.UserUtils.UserName;
            lblPcName.Text = WaecUtils.UserUtils.MachineName;
            lblDomainName.Text = WaecUtils.UserUtils.UserDomainName;
            
            using (var db = new Model.WaecNatEntities())
            {
                deadline = db.fDeadline_GetByExamID_ExamYear("nat8", 2021).ToList();
                serverDateTime = db.fServerGetDateTime().ToList();
                comboBoxExamYear.DataSource = serverDateTime;
                comboBoxExamYear.DisplayMember = "CurrentYear";
                comboBoxExamYear.ValueMember = "CurrentYear";
                toolStripStatusLabelDeadline.Text = deadline[0].CandidateModificationEnd.ToString();
                toolStripStatusLabelCurrentDate.Text = serverDateTime[0].CurrentDate.ToString();
            }
            HearBeat();
            txtCentreNumber.Focus();
        }

        private void btnRetrieveCandidate_Click(object sender, EventArgs e)
        {
            //fetch candide from db and populate fields
            using (var db = new Model.WaecNatEntities())
            {
                currentCandidate = db.fGetNatCandidate(
                    "NAT8"
                    , serverDateTime[0].CurrentYear
                    , currentCentre.CentreNumber
                    , txtIndexNumber.Text).ToList();
            }

            if (currentCandidate.Count != 0)
            {
                // row received. should expect one
                // load fields
                gbCandidateDetails.Enabled = true;
                gbCandidateInfo.Enabled = false;
                this.CancelButton = btnCancel;

                txtCandidateLastName.Text = currentCandidate[0].CandidateLastName;
                txtCandidateFirstName.Text = currentCandidate[0].CandidateFirstName;
                txtCandidateInitial.Text = currentCandidate[0].CandidateInitial;
                //comboBoxSex.Text = currentCandidate[0].SexID.ToString();
                comboBoxSex.SelectedIndex = currentCandidate[0].SexID - 1;
                //comboBoxDisability.Text = currentCandidate[0].DisabilityID.ToString();
                comboBoxDisability.SelectedIndex = currentCandidate[0].DisabilityID;
                dateOfBirth.Value = currentCandidate[0].DateOfBirth.Value;
                comboBoxAttempts.Text = currentCandidate[0].Attempts.ToString();
                lblSchoolName.Text = currentCentre.CentreName;

                txtCandidateLastName.SelectAll();

                if (serverDateTime[0].CurrentDate < deadline[0].CandidateModificationEnd)
                {
                    btnUpdate.Enabled = true;
                    btnDeleteCandidate.Enabled = true;
                }
                    
            }
            else
            {
                gbCandidateDetails.Enabled = false;
                gbCandidateInfo.Enabled = true;
                MessageBox.Show("Error getting candidates. Please check");
            }
        }

        private void txtIndexNumber_TextChanged(object sender, EventArgs e)
        {
            if (txtCentreNumber.Text.Length == 5 && txtIndexNumber.Text.Length == 3)
            {
                btnRetrieveCandidate.Enabled = true;
                btnRetrieveCandidate.Focus();
            }
            else
                btnRetrieveCandidate.Enabled = false;
        }

        private void txtCentreNumber_TextChanged(object sender, EventArgs e)
        {
            
            if (txtCentreNumber.TextLength == 5)
            {
                UseWaitCursor = true;
                using (var db = new Model.WaecNatEntities())
                {
                    try
                    {
                        currentCentre = db.fGetCentre("NAT8", int.Parse(txtCentreNumber.Text)).ToList()[0];
                        txtIndexNumber.Enabled = true;
                        txtIndexNumber.Focus();
                        txtIndexNumber.SelectAll();
                        txtCentreNumber.BackColor = Color.White;
                    }
                    catch (Exception)
                    {
                        txtIndexNumber.Enabled = false;
                    }
                    UseWaitCursor = false;
                }
            }
            else
                ;//txtIndexNumber.Text = "";
        }

        private void btnCancelTop_Click(object sender, EventArgs e)
        {
            if (txtCentreNumber.Text != null && txtIndexNumber.Text != null)
            {
                txtIndexNumber.Text = null;
                txtIndexNumber.Focus();
            }
            else if (txtCentreNumber.Text != null && txtIndexNumber.Text == null)
            {
                txtIndexNumber.Enabled = false;
                txtCentreNumber.Text = null;
                txtCentreNumber.BackColor = Color.PaleVioletRed;
                txtCentreNumber.Focus();
            }

            this.CancelButton = btnCancelTop;            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            gbCandidateInfo.Enabled = true;
            txtCandidateLastName.Text = null;
            txtCandidateFirstName.Text = null;
            txtCandidateInitial.Text = null;
            comboBoxSex.Text = null;
            comboBoxDisability.Text = null;
            dateOfBirth.Value = DateTime.Now;
            comboBoxAttempts.Text = null;

            btnUpdate.Enabled = false;
            btnDeleteCandidate.Enabled = false;

            gbCandidateDetails.Enabled = false;
            btnCancelTop.PerformClick();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (var db = new Model.WaecNatEntities())
            {
                var result = db.fNatInsertUpdateDeleteEntry2(
                    examID: "NAT8"
                    , examYear: 2021
                    , centreNumber: txtCentreNumber.Text
                    , indexNumber: txtIndexNumber.Text
                    , candidateName: ""
                    , candidateLastName: txtCandidateLastName.Text.ToUpper().Trim()
                    , candidateFirstName: txtCandidateFirstName.Text.ToUpper().Trim()
                    , candidateInitial: txtCandidateInitial.Text.ToUpper().Trim()
                    , sexID: int.Parse(comboBoxSex.Text.Substring(0, 1))
                    , disabilityID: int.Parse(comboBoxDisability.Text.Substring(0,1))
                    , dateOfBirth: dateOfBirth.Value
                    , attempts: int.Parse(comboBoxAttempts.Text)
                    , userName: WaecUtils.UserUtils.UserName
                    , pcName: WaecUtils.UserUtils.MachineName
                    , statementType: "update"
                    );

                if (result == -1)
                {
                    // success
                    MessageBox.Show("Update Success");
                    btnCancel.PerformClick();
                }
                else
                {
                    MessageBox.Show($"There was glitch in updating {result}");
                }
            }
        }

        private void timerHeartBeat_Tick(object sender, EventArgs e)
        {
            HearBeat();
        }

        private void HearBeat()
        {
            using (var db = new Model.WaecNatEntities())
            {
                try
                {
                    serverDateTime = db.fServerGetDateTime().ToList();
                    if (serverDateTime.Count > 0)
                    {
                        toolStripStatusLabelDeadline.Text = deadline[0].CandidateModificationEnd.ToString();
                        toolStripStatusLabelCurrentDate.Text = serverDateTime[0].CurrentDate.ToString();
                        toolStripStatusLabelConnected.Text = "Connected!";
                        toolStripStatusLabelConnected.BackColor = Color.Green;
                    }
                    else
                    {
                        toolStripStatusLabelConnected.Text = "Disconnected!";
                        toolStripStatusLabelConnected.BackColor = Color.Red;
                    }
                }
                catch (Exception)
                {
                    toolStripStatusLabelConnected.Text = "Disconnected!";
                    toolStripStatusLabelConnected.BackColor = Color.Red;
                }               
            }
        }

        private void txtTextBoxToUpper_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            //tb.Text = tb.Text.ToUpper();
            //tb.Select(tb.Text.Length, tb.Text.Length);
        }
    }
}
