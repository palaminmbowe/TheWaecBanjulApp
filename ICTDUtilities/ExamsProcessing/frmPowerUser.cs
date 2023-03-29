using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaecLibrary;
using ICTDUtilities.Objects;

namespace ICTDUtilities.ExamsProcessing
{
    public partial class frmPowerUser : Form
    {
        public dbConnection3 db;
        
        public frmPowerUser()
        {
            InitializeComponent();
        }

        private void frmPowerUser_Load(object sender, EventArgs e)
        {
            cbYear.Items.Add(DateTime.Now.Year.ToString());
            if (db.isConnected())
            {
                btnConnected.BackColor = Color.Green;
                btnConnected.Text = "Connected";
            }                
            else
            {
                btnConnected.BackColor = Color.Red;
                btnConnected.Text = "Not Connected";
            }                
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddSchool_Click(object sender, EventArgs e)
        {
            if (!clbSchools.Items.Contains(txtSchool.Text))
            {
                switch (txtSchool.Text[0])
                {
                    case '3':
                    case '5':
                    case '6':
                    case '7':
                        clbSchools.Items.Add(txtSchool.Text.Substring(0, 5), true);
                        break;
                    case '8':
                    case '9':
                        clbSchools.Items.Add(txtSchool.Text.Substring(0, 7), true);
                        break;
                    default:
                        break;
                }
                
                txtSchool.Text = "";
            }
            else
                MessageBox.Show("School code already in the list", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            
        }

        private void btnClearSchools_Click(object sender, EventArgs e)
        {
            clbSchools.Items.Clear();
        }

        private void btnClearSubjects_Click(object sender, EventArgs e)
        {
        }

        private void btnAddSubjectToAllCandidates_Click(object sender, EventArgs e)
        {
            rtbDisplay.AppendText("Adding subjects to candidates");
            if (txtSubject.Text.Trim().Equals("") || clbSchools.SelectedIndices.Count < 1)
            {
                return;
            }

            if (txtBeginRange.Text.Trim().Equals("") || txtBeginRange.Text.Length != 3)
            {
                return;
            }

            if (txtEndRange.Text.Trim().Equals("") || txtEndRange.Text.Length != 3)
            {
                return;
            }

            // get list of all candidates

            // for each candidate, add the subject
            string examYear = cbYear.SelectedItem.ToString();
            string centNo = clbSchools.SelectedItem.ToString();
            string tableName = "";

            rtbDisplay.AppendText("\nExamYear = " + examYear + "\ncentNO = " + centNo);

            if(examYear.Equals("") || centNo.Equals(""))
            {
                MessageBox.Show("Please check exam year or cent no");
                return;
            }

            switch (centNo[0])
	        {
                case '7':
                    tableName = "02OUTGabece";
                    break;
                case '8':
                    tableName = "02OUTWassce";
                    break;
                case '9':
                    tableName = "02OUTPwassce";
                    break;
		        default:
                break;
	        }

            rtbDisplay.AppendText("\nUsing table: " + tableName);

            try
            {
                db.con.Open();

                db.cmd.CommandText = "SELECT ExamYear, CentNo, IndexNo FROM " + tableName +
                    " WHERE ExamYear = '" + examYear + "' AND CentNo = '" + centNo + 
                    "' AND IndexNo >= '" + txtBeginRange.Text + "' AND IndexNo <= '" + txtEndRange.Text + "'";

                rtbDisplay.AppendText("\n\nstatement: " + db.cmd.CommandText);

                db.dr = db.cmd.ExecuteReader();

                if(db.dr.HasRows)
                {
                    rtbDisplay.AppendText("Executed successfully");
                }

                int count = 0;
                int totalAffected = 0;

                while (db.dr.Read())
                {
                    count++;

                    CandidateGabece c = new CandidateGabece(db.dr.GetString(0), db.dr.GetString(01), db.dr.GetString(2), db.connectionString);
                    rtbDisplay.AppendText("\nProcessing: " + c.CentNo + c.IndexNo + " - " + c.CandidateName);

                    if(c.RetrieveCandidateDetails())
                    {
                        // check for subject

                        // add subject
                        if (c.AddSubject(txtSubject.Text.Substring(0, 3)))
                        {
                            //Successfully added
                            if (c.UpdateCandidateDetails(Environment.UserName, Environment.MachineName, Environment.UserDomainName))
                            {
                                totalAffected++;
                                rtbDisplay.AppendText(" - " + txtSubject.Text.Substring(0, 3) + " success");
                                rtbDisplay.ScrollToCaret();
                            }
                            else
                                rtbDisplay.AppendText("\n\t*** Error updating candidate");
                        }
                        else
                            rtbDisplay.AppendText("\n\t**Error adding subject: " + txtSubject.Text.Substring(0, 3));
                    }
                    else
                        rtbDisplay.AppendText("\n\tError retrieving candidate");
                }

                rtbDisplay.AppendText("\n\nProcessed " + totalAffected.ToString() + " of " + count + " successfully.");
                MessageBox.Show("Processed " + totalAffected.ToString() + " of " + count + " successfully.","", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error adding subjects: " + ex.Message);
            }
            finally
            {
                db.con.Close();
            }
        }

        private void TrimTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = tb.Text.Trim();
        }
    }
}
