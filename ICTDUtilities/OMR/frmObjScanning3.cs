using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaecLibrary;
using System.Threading;
using System.Data.OleDb;
using System.IO;
using System.Threading;

namespace ICTDUtilities.OMR
{
    public partial class frmObjScanning3 : Form
    {
        dbConnection3 db;
        string userName, pcName, domain;
        System.IO.FileInfo dbFile;
        //Thread tSaveToDb;
        //Thread tScoring;
        List<string> data;
        List<string> subjectsToScore;
        List<string> centres;

        DataSet ds;
        //List<string> dsTables;

        enum scanners { Drs = 0, Nanhao = 1, Nanhao2 = 2 };
        enum exams { OTHER = 0, NAT3 = 3, NAT5 = 5, NAT8 = 6, GABECE = 7, WASSCE = 8, PWASSCE = 9, PGABECE = 4, ADHOC = 99 };
        string[] grades = { "3", "5", "6", "7", "8", "9", "4", "99" };

        string[] scannerLineId = { "", "Data:A" };
        string currentYear, currentExam, currentGrade;

        int csdSubjLength = 6;
        int genSubjCodeLength = 3;

        scanners currentScanner;

        string[] validOptions = { "A", "B", "C", "D", " ", "<" };
        bool modifyQrsCandidate;
        TextBox currentQrsTextBox;

        Thread tRefreshUserScans;

        public frmObjScanning3()
        {
            InitializeComponent();

            currentScanner = scanners.Nanhao;

            domain = Environment.UserDomainName.ToString();
            userName = Environment.UserName.ToString();
            pcName = Environment.MachineName.ToString();

            if (SetupDbFile())
            {
                if (generateConnectionString())
                {
                    //successfully connected to db
                    this.BackColor = Color.Olive;
                }
                else
                {
                    this.BackColor = Color.Red;
                    MessageBox.Show("There was an error connecting to the DB!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private Boolean generateConnectionString()
        {
            db = new dbConnection3(dbFile.Name, dbFile.Directory.ToString(), "CsdObjScanDbNew");
            if (db.isConnected())
                return true;
            else
            {
                //try connecting local
                db = new dbConnection3(ICTDUtilities.Properties.Resources.dbName, ICTDUtilities.Properties.Resources.dbServerPathLocal, "CsdObjScanDb");
            }
            return db.isConnected();
        }

        private string getPassword() { return ""; }

        private bool SetupDbFile()
        {
            try
            {
                //if (((domain.ToLower() == "palamin") && (pcName.ToLower() == "palamin")) || ((domain.ToLower() == "csd") || (pcName.ToLower() == "waeccsdd020")))
                if (
                    (
                        ((this.domain.ToLower() == "palamin2") && (this.pcName.ToLower() == "palamin2")) ||
                        ((this.domain.ToLower() == "palamin") && (this.pcName.ToLower() == "palamin")) ||
                        ((this.domain.ToLower() == "ictd") && (this.pcName.ToLower() == "w-ictd19d002"))
                    ) &&
                    (MessageBox.Show("Local?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    // check1

                    try
                    {
                        dbFile = new System.IO.FileInfo(String.Concat(ICTDUtilities.Properties.Resources.dbServerPathLocal, "\\", ICTDUtilities.Properties.Resources.dbName));
                        if (dbFile.Exists)
                        {
                            //lblHeader.Text += " LOCAL";
                            lblHeader.ForeColor = Color.Red;
                            cbSingleCentreMode.Enabled = true;
                            cbSingleCentreMode.Checked = false;
                            cbSingleSubjectMode.Enabled = true;
                            cbSingleSubjectMode.Checked = false;
                            return true;
                        }
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("Error setting up local db: " + ex.ErrorCode + " : " + ex.Message);
                    }

                    this.BackColor = Color.Red;
                    return false;
                }


                dbFile = new System.IO.FileInfo(String.Concat(ICTDUtilities.Properties.Resources.dbServerPath, "\\", ICTDUtilities.Properties.Resources.dbName));
                if (dbFile.Exists)
                {
                    this.BackColor = Color.Olive;
                    if ((
                        ((this.domain.ToLower() == "palamin2") && (this.pcName.ToLower() == "palamin2")) ||
                        ((this.domain.ToLower() == "palamin") && (this.pcName.ToLower() == "palamin")) ||
                        ((this.domain.ToLower() == "ictd") && (this.pcName.ToLower() == "w-ictd19d002"))
                    ))
                    {
                        cbSingleCentreMode.Enabled = true;
                        cbSingleCentreMode.Checked = false;
                        cbSingleSubjectMode.Enabled = true;
                        cbSingleSubjectMode.Checked = false;
                    }
                    return true;
                }
                else
                {
                    //try local

                    //if ((userName.ToLower() != "palamin") || ((pcName.ToLower() != "palamin") || (pcName.ToLower() != "waeccsdd020")))
                    if (
                        ((this.userName.ToLower() != "palamin") && ((this.pcName.ToLower() != "palamin") || ((this.domain.ToLower() == "ictd") && (this.pcName.ToLower() != "w-ictd19d002")))) ||
                        ((this.domain.ToLower() == "csd") && (this.pcName.ToLower() != "sosabou")))
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
                            //lblHeader.Text += " LOCAL";
                            lblHeader.ForeColor = Color.Red;
                            return true;
                        }
                    }

                    catch (OleDbException ex)
                    {
                        MessageBox.Show("There was a problem connecting to the data source, please close program and try again: " + ex.ErrorCode + " : " + ex.Message,
                            "Error Connecting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("Error setting up local db: " + ex.ErrorCode + " : " + ex.Message);
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

        private void frmObjScanning_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            scMid.Panel2Collapsed = true;
            scScore.Visible = false;
            scScore.Panel2Collapsed = true;
            scScoreMain.Panel2Collapsed = true;

            switch (domain.ToLower())
            {
                case "ictd":
                    if ((userName.ToLower() == "palamin") || (userName.ToLower() == "palamin.mbowe") || (userName.ToLower() == "sosseh.jagne"))
                    {
                        scScore.Visible = true;
                        btnShowScore.Enabled = true;
                        scScoreMain.Panel2Collapsed = false;
                        scScore.Panel2Collapsed = false;
                    }
                    else
                    {
                        scScore.Visible = false;
                        btnShowScore.Enabled = false;
                        scScoreMain.Panel2Collapsed = true;
                        scScore.Panel2Collapsed = true;
                    }
                    break;
                case "palamin":
                case "palamin2":
                case "w-itcd19d002":
                    scScore.Visible = true;
                    btnShowScore.Enabled = true;
                    scScoreMain.Panel2Collapsed = false;
                    scScore.Panel2Collapsed = false;
                    break;
                default:
                    MessageBox.Show("Please log on to the domain to continue. Exiting!", "Error logging in.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    break;
            }

            //MountNetworkDrive("z");
            SetupComponents();
            Cursor = DefaultCursor;

            CheckForIllegalCrossThreadCalls = false;

            //if (SetThreadExecutionState(ES_CONTINUOUS | ES_SYSTEM_REQUIRED | ES_AWAYMODE_REQUIRED) == NULL)
            //{
            //    // try XP variant as well just to make sure 
            //    SetThreadExecutionState(ES_CONTINUOUS | ES_SYSTEM_REQUIRED);
            //}  

            cmbQrsCheckExamYear.Items.Clear();
            cmbQrsCheckExamYear.Items.Add(DateTime.Now.Year.ToString());
            cmbQrsCheckExamYear.Items.Add(DateTime.Now.Year - 1);
            txtQrsCheckExamYear.Text = DateTime.Now.Year.ToString();

            cmbQrsExamYear.Items.Clear();
            cmbQrsExamYear.Items.Add(DateTime.Now.Year.ToString());
            cmbQrsExamYear.Items.Add(DateTime.Now.Year - 1);
            // load scanned info

            scScoreMain.Panel1Collapsed = false;
        }

        private bool LoadUserTotalScanned()
        {
            try
            {
                // setup tables - use datasets
                List<string> tableNames = new List<string>();
                List<string> sqls = new List<string>();
                List<string> rowData = new List<string>();
                tableNames.Add("TotalUserScanned");
                tableNames.Add("TotalUserKeyed");
                tableNames.Add("Users");

                // fetch data
                sqls.Add(string.Concat(new object[] { "SELECT examYear, userName, COUNT(data) AS totalScanned FROM obj_", this.currentGrade,
                    " WHERE ManuallyKeyed = false GROUP BY examYear, userName ORDER BY COUNT(data) DESC;" }));

                sqls.Add(string.Concat(new object[] { "SELECT examYear, userName, COUNT(data) AS totalScanned FROM obj_", this.currentGrade,
                    " WHERE ManuallyKeyed = true GROUP BY examYear, userName;" }));

                sqls.Add(string.Concat(new object[] { "SELECT examYear, userName, COUNT(data) FROM obj_", this.currentGrade,
                    " GROUP BY examYear, userName ORDER BY COUNT(data) DESC;" }));

                for (int i = 0; i < sqls.Count; i++)
                {
                    if (this.UpdateDs(tableNames[i], sqls[i]))
                    {
                        Console.WriteLine(tableNames[i] + ": Update success");
                    }
                }

                // load lvTotalScannedKeyed
                lvTotalScannedKeyed.Items.Clear();

                foreach (DataRow row in ds.Tables["Users"].Rows)
                {
                    try
                    {
                        string[] strArray2 = new string[3];

                        strArray2[0] = row["userName"].ToString();
                        //strArray2[1] = row["totalScanned"].ToString();

                        // get total Scanned
                        foreach (DataRow dr in ds.Tables["TotalUserScanned"].Rows)
                        {
                            if (strArray2[0].Equals(dr["userName"].ToString()))
                            {
                                strArray2[1] = dr["totalScanned"].ToString();
                                break;
                            }
                        }

                        // get total keyed
                        foreach (DataRow dr in ds.Tables["TotalUserKeyed"].Rows)
                        {
                            if (strArray2[0].Equals(dr["userName"].ToString()))
                            {
                                strArray2[2] = dr["totalScanned"].ToString();
                                break;
                            }
                        }

                        string[] items = strArray2;
                        lvTotalScannedKeyed.Items.Add(new ListViewItem(items));

                    }
                    catch (Exception exception1)
                    {
                        Console.WriteLine("Error in getting records: " + exception1.Message);
                    }
                }

                // update scanned progress bar
                if (UpdateScannedProgressBar(this.currentGrade));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in LoadUserTotalScanned(): " + ex.Message);
            }
            return false;
        }

        private bool UpdateScannedProgressBar(string grade)
        {
            List<int> totalExpectedScanned = new List<int>();
            string tableName = "";
            pbScannedProgress.Value = 0;
            labelProgressBar.Text = "";
            //System.Windows.Forms.Timer pbTimer = this.timerProgressBar;
            timerProgressBar.Tick += timerProgressBar_Tick;

            // get total expected for the grade
            List<string> sql = new List<string>();

            switch (grade)
            {
                case "3":
                case "5":
                case "6":
                    tableName = "PrePrintObjDetailsNat" + (grade == "6" ? "8" : grade);
                    break;
                case "4":
                    tableName = "PrePrintObjDetailsPgabece";
                    break;
                case "7":
                    tableName = "PrePrintObjDetailsGabece";
                    break;
                case "8":
                    tableName = "PrePrintObjDetailsWassce";
                    break;
                case "9":
                    tableName = "PrePrintObjDetailsPwassce";
                    break;
                default:
                    break;
            }

            sql.Add(string.Concat(new object[] { "SELECT COUNT(IndexNo) FROM ", tableName,
                    $" where ExamYear = '{cbExamYear.Text}';" }));

            sql.Add(string.Concat(new object[] { "SELECT COUNT(IndexNo) FROM obj_", this.currentGrade,
                    $" where ExamYear = '{cbExamYear.Text}';" }));

            // get total expected scanned and save in variabletotalExpectedScanned

            try
            {
                if (db.con.State != ConnectionState.Closed)
                    db.con.Close();
                db.con.Open();
                

                foreach (string s in sql)
                {
                    db.cmd.CommandText = s;
                    
                    totalExpectedScanned.Add(int.Parse(db.cmd.ExecuteScalar().ToString()));
                }

                pbScannedProgress.Maximum = totalExpectedScanned[0];
                //pbScannedProgress.Value = totalExpectedScanned[1];
                pbScannedProgress.Value = (totalExpectedScanned[1] > totalExpectedScanned[0] ? totalExpectedScanned[0] : totalExpectedScanned[1]);
                pbScannedProgress.Style = ProgressBarStyle.Continuous;

                timerProgressBar.Interval = 10000;
                timerProgressBar.Start();
                labelProgressBar.Text = totalExpectedScanned[1] + " / " + totalExpectedScanned[0] + "  (" + Math.Round(((double)totalExpectedScanned[1] / (double)totalExpectedScanned[0] * 100), 2) + "%)";

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in UpdateScannedProgressBar(): " + ex.Message);
            }
            finally
            {
                db.con.Close();
            }

            // update progress bar

            return false;
        }

        private void timerProgressBar_Tick(object sender, EventArgs e)
        {
            pbScannedProgress.Increment(1);
        }

        private void SetupComponents()
        {
            //populate exam year
            currentYear = DateTime.Now.Year.ToString();
            cbExamYear.Items.Add(currentYear);
            cbExamYear.Items.Add((int.Parse(currentYear) - 1));
            cbExamYear.SelectedIndex = 0;
            cmbQueryExamYear.Items.Add(currentYear);
            cmbQueryExamYear.Items.Add((int.Parse(currentYear) - 1));
            cmbQueryExamYear.SelectedIndex = 0;
            txtQrsCheckExamYear.Text = currentYear;

            PopulateDs();
        }

        private Boolean PopulateDs()
        {
            Cursor.Current = Cursors.WaitCursor;

            //Populates ds with common data: 
            foreach (string grade in grades)
            {
                try
                {
                    // update SubjIndex 
                    if (UpdateDs("SubjIndex" + grade, "SELECT * FROM SubjIndex" + grade + ";"))
                    {
                        Console.WriteLine("SubjIndex" + grade + " success");
                    }
                    else
                    {
                        Console.WriteLine("SubjIndex" + grade + " failed");
                    }

                    // update Centre Numbers
                    if (UpdateDs("Centre" + grade, "SELECT * FROM qryCentre" + grade + ";"))
                    {
                        Console.WriteLine("Centre" + grade + " success");
                    }
                    else
                    {
                        Console.WriteLine("Centre" + grade + " failed");
                    }

                    // Exam year
                    if (UpdateDs("ExamYear" + grade, "SELECT * FROM qryExamYear" + grade + ";"))
                    {
                        Console.WriteLine("ExamYear" + grade + " success");
                    }
                    else
                    {
                        Console.WriteLine("ExamYear" + grade + " failed");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error in loading subjectindex: " + ex.Message);
                }
            }
            Cursor.Current = Cursors.Default;
            return true;
        }

        private void tcOmr_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tcOmr.SelectedTab.Name.Equals("View and Export".ToLower()))
            {
                if (timerRefresh.Enabled == false)
                    timerRefresh.Enabled = true;
            }
            else
            {
                if (timerRefresh.Enabled == true)
                    timerRefresh.Enabled = false;
            }

            if (tcOmr.SelectedTab.Name.Equals("OMR Data Capture".ToLower()))
            {
                if (comboBoxScanExamYear.Items.Count == 0)
                {
                    // empty populate.
                }
            }

        }

        private void btnPasteDataFromCB_Click(object sender, EventArgs e)
        {
            //rtbData.AppendText("Testing");
            if (rtbOutput.Text != "")
                btnClearRtbs.PerformClick();

            scMid.Panel2Collapsed = false;
            btnClean.Visible = true;

            try
            {
                rtbData.AppendText(Clipboard.GetText());
                DisplayRtbDisplayMessage("\n\nCleaning Data... please wait");
                btnClean.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting data: " + ex.Message);
                DisplayRtbDisplayMessage("\n***** Error getting data: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rtbData.TextLength > 1)
            {
                rtbData.Clear();
                rtbOutput.Clear();
                //rtbRejectDisplay.Clear();
                lblTotalCleanLines.Text = "0";
                pgStatus.Value = 0;
                scMid.Panel2Collapsed = true;
            }

        }

        private void rtbData_TextChanged(object sender, EventArgs e)
        {
            countNoOfLines();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            if (cleanData())
            {
                Console.WriteLine("Saving data...");
                StartSavingToDb();

                //reset the check boxes after each transfer.
                cbLess15Check.Checked = true;
                cbSingleCentreMode.Checked = true;
            }
            //MessageBox.Show("Saving Data. Please wait before loading next data!", "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("There was an error in processing data. Please try again!", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private long countNoOfLines()
        {
            long count = new long();
            foreach (string s in rtbData.Lines)
            {
                count++;
            }
            lblTotalLines.Text = count.ToString();

            return count;
        }

        private long countNoOfCleanLines()
        {
            long count = new long();
            foreach (string s in rtbOutput.Lines)
            {
                count++;
            }
            lblTotalCleanLines.Text = count.ToString();

            return count;
        }

        private bool cleanData()
        {
            ////try
            ////{
            ////    if (tSaveToDb.IsAlive)
            ////    {
            ////        DisplayRtbDisplayMessage("\n***** Saving to DB in Progress... Please wait");
            ////        MessageBox.Show("Saving to DB in Progress... Please wait", "Saving to DB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////        return false;
            ////    }
            ////}
            ////catch (Exception ex)
            ////{
            ////    Console.WriteLine("Cannot determine thread state: " + ex.Message);
            ////}

            //scRtfDisplay.Panel1Collapsed = false;
            //scRtfDisplay.Panel2Collapsed = true;

            data = new List<string>();

            //rtbOutput.Clear();
            long count = new long();

            if (rtbOutput.TextLength > 0)
                rtbOutput.AppendText("\n");

            DisplayRtbDisplayMessage("\nCleaning started...");

            try
            {
                string cleanLine = "";

                foreach (string s in rtbData.Lines)
                {
                    try
                    {
                        //remove 000 prefix
                        if (s.EndsWith("000"))
                        {
                            //remove trailing zeros
                            cleanLine = s.Substring(0, (s.Length - 3)).Trim();
                        }
                        else
                            cleanLine = s;

                        switch (currentScanner)
                        {
                            case scanners.Drs:
                                if ((cleanLine.Length > 10))
                                {
                                    // required line
                                    //sb.Append(s);

                                    if (count++ != 0)
                                        rtbOutput.AppendText("\n");



                                    string cleaned = cleanLine.Trim();
                                    if (cleaned.Contains(".") || cleaned.Contains(","))
                                    {
                                        try
                                        {
                                            cleaned = cleaned.Replace('.', ' ');
                                            cleaned = cleaned.Replace(',', ' ');
                                            cleaned = cleaned.TrimEnd(' ');
                                        }
                                        catch (Exception ex) { }
                                    }
                                    rtbOutput.AppendText(cleaned);
                                    data.Add(cleaned);
                                }
                                break;
                            case scanners.Nanhao:
                                if ((cleanLine.Length > 6) && (cleanLine.Substring(0, 6) == "Data:A"))
                                {
                                    // required line
                                    //sb.Append(s);

                                    if (count++ != 0)
                                        rtbOutput.AppendText("\n");

                                    //rtbOutput.AppendText(s.Substring(6).Replace(".", " ").Trim());
                                    string cleaned = cleanLine.Substring(6).Replace(".", " ").Trim();

                                    if (cleaned.Contains(".") || cleaned.Contains(","))
                                    {
                                        try
                                        {
                                            cleaned = cleaned.Replace('.', ' ').Substring(0, 120).TrimEnd(' ');
                                            cleaned = cleaned.TrimEnd(' ');
                                        }
                                        catch (Exception ex) { }
                                    }
                                    rtbOutput.AppendText(cleaned);
                                    data.Add(cleaned);
                                }
                                break;
                            case scanners.Nanhao2:
                                if ((cleanLine.Length > 10))
                                {
                                    // required line
                                    //sb.Append(s);

                                    if (count++ != 0)
                                        rtbOutput.AppendText("\n");

                                    string cleaned = cleanLine.Trim();
                                    if (cleaned.Contains(".") || cleaned.Contains(","))
                                    {
                                        try
                                        {
                                            cleaned = cleaned.Replace('.', ' ');
                                            cleaned = cleaned.Replace(',', ' ');
                                            cleaned = cleaned.TrimEnd(' ');
                                        }
                                        catch (Exception ex) { }
                                    }
                                    rtbOutput.AppendText(cleaned);
                                    data.Add(cleaned);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error Cleaning: " + s + " : " + ex.Message);
                        continue;
                    }
                }
                //countNoOfCleanLines();

                //DisplayRtbDisplayMessage("success");
                if (countNoOfCleanLines() > 0) return true;
            }
            catch (Exception ex)
            {
                DisplayRtbDisplayMessage("failed");
                MessageBox.Show("Error in cleaning data: " + ex.Message);
            }
            return false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void rtbOutput_TextChanged(object sender, EventArgs e)
        {
            countNoOfCleanLines();
        }

        private void rbScanners_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;

            switch (rb.Text.ToLower())
            {
                case "drs data":
                    currentScanner = scanners.Drs;
                    break;
                case "nanhao data":
                    currentScanner = scanners.Nanhao;
                    break;
                case "nanhao2 data":
                    currentScanner = scanners.Nanhao2;
                    break;
                default:
                    currentScanner = scanners.Drs;
                    break;
            }

            btnPasteDataFromCB.Enabled = true;
            gbPasteScanData.Visible = true;
            labelScan4.Visible = true;
        }

        //private void EnablePasteData()
        //{
        //    throw new NotImplementedException();

            
        //}

        private void StartSavingToDb()
        {
            if (db.isConnected())
            {
                //CheckForIllegalCrossThreadCalls = false;
                //tSaveToDb = new Thread(new ThreadStart(SaveToDb));
                //btnPasteDataFromCB.Enabled = false;
                //tSaveToDb.Start();
                SaveToDb();
                rtbDisplay.ScrollToCaret();
            }
            else
            {
                MessageBox.Show("Cannot connect to database! Try cleaning again.", "Error Connecting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveToDb()
        {
            //string[] exams = { "GABECE", "NAT3", "NAT5", "NAT8", "WASSCE", "WASSCE", "OTHER"};
            //exams exam = new exams();

            string currentExam;
            //string currentYear = DateTime.Now.Year.ToString();
            string currentYear = comboBoxScanExamYear.Text;
            bool showErrorDialog = true;

            DisplayRtbDisplayMessage("\n\nSaving ... ...");
            btnClean.Enabled = false;
            btnClearRtbs.Enabled = false;
            //scRtfDisplay.Panel1Collapsed = false;
            //scRtfDisplay.Panel2Collapsed = true;

            //determine which exam it is first
            uint count = 0;
            uint success = 0;
            uint failed = 0;
            uint ignored = 0;
            uint notValidData = 0;
            uint rejectedData = 0;
            int absentStartsAt = 16;
            List<string> noOfCentres = new List<string>();
            List<string> noOfSubjects = new List<string>();

            string[] tString; ;
            string centNo;
            string indexNo;
            string csdSubjCode = "";
            string candAbsent = "";
            string scanData = "";
            string candSex = "";
            string currentCentre = "";
            string currentSubject = "";

            try
            {
                pgStatus.Maximum = rtbOutput.Lines.Length;
                pgStatus.Step = 1;

                db.con.Open();

                foreach (string s in data)
                {
                    currentExam = s.Substring(0,3) == "990" ?  s.Substring(0, 2) : s.Substring(0, 1);
                    //use this value to determine where to save the data

                    int centreLength;
                    //int indexSubjLength = 16;

                    if (currentExam.Equals("99"))
                    {
                        centreLength = 5;
                        csdSubjLength = 6;
                    }
                    else
                    {
                        switch (currentExam[0])
                        {
                            case '4':
                            case '7':
                                centreLength = 5;
                                csdSubjLength = 6;
                                //absentStartsAt = 16;
                                break;
                            case '8':
                            case '9':
                                centreLength = 7;
                                csdSubjLength = 6;
                                //absentStartsAt = 16;
                                break;
                            default:
                                centreLength = 5;
                                csdSubjLength = 2;
                                break;
                        }
                    }

                    if (currentScanner == scanners.Drs)
                        absentStartsAt = 20;
                    else if (currentScanner == scanners.Nanhao2 || currentScanner == scanners.Nanhao)
                        absentStartsAt = 16;

                    count++;
                    pgStatus.PerformStep();

                    if (rtbDisplay.TextLength > 500000)
                        rtbDisplay.Clear();

                    if (s.Length <= 16)
                        continue;

                    try
                    {
                        //check for scoring key
                        if (s.Substring(0, 3) == "990")
                        {
                            // reserved for Ad-hoc centres
                            centreLength = 5;
                            csdSubjLength = 6;
                        }
                        else if(s.Substring(0, 2) == "99")
                        {
                            // scoring key
                            DisplayRtbDisplayMessage("\nScoring key detected: " + s + "\n" + count + " - " + "Processing...\n");

                            if (ProcessScoringKey(s))
                            {
                                success++;
                                DisplayRtbDisplayMessage("Saved successfully.\n");
                            }
                            else
                            {
                                failed++;
                                DisplayRtbDisplayMessage("***** REJECTED *****");
                                rtbRejectDisplay.AppendText("\n" + count + " - " + s + "\n --> Rejected.");
                            }

                            continue;
                        }
                        //if (s.Substring(0, 2) == "99")
                        //{
                        //    // scoring key
                        //    DisplayRtbDisplayMessage("\nScoring key detected: " + s + "\n" + count + " - " + "Processing...\n");
                        //    if (s.Contains('>'))
                        //    {
                        //        // key not valid. Multi mark
                        //        DisplayRtbDisplayMessage("Key not valid !!!");
                        //        continue;
                        //    }

                        //    if (ProcessScoringKey(s))
                        //    {
                        //        success++;
                        //        DisplayRtbDisplayMessage("Saved successfully.\n");
                        //    }
                        //    else
                        //    {
                        //        failed++;
                        //        DisplayRtbDisplayMessage("***** REJECTED *****");
                        //        rtbRejectDisplay.AppendText("\n" + count + " - " + s + "\n --> Rejected.");
                        //    }

                        //    continue;
                        //}

                        // do individual checks here
                        tString = s.Substring(0, centreLength).Split(' ');
                        centNo = tString[0].Trim();
                        tString = s.Substring(centreLength, 3).Split(' ');
                        indexNo = tString[0].Trim();
                        tString = s.Substring(10, csdSubjLength).Split(' ');
                        csdSubjCode = tString[0].Trim();

                        // valid Centre number
                        try
                        {
                            string tableName = String.Concat("Centre", currentExam);
                            bool centreOk = false;
                            DataTable dt = ds.Tables[String.Concat(tableName)];

                            // get list of all centres for the current exam
                            foreach (DataRow dr in dt.Rows)
                            {
                                if(dr[0].ToString() == centNo)
                                {
                                    //found match
                                    centreOk = true;

                                    // save centre number from first sheet
                                    if(currentCentre == "")
                                    {
                                        currentCentre = centNo;
                                        currentSubject = csdSubjCode;
                                    }

                                    break;
                                }
                            }

                            if (!centreOk)
                            {
                                // no match found not valid data
                                DisplayRtbDisplayMessage(" *** not a valid Centre Number ***");
                                rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "... *** not a valid CENTRE NUMBER ***");
                                notValidData++;
                                centreOk = false;
                                continue;
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error determining absent: " + ex.Message);
                        }

                        // check for different centre number while scanning
                        if(cbSingleCentreMode.Checked == true)
                        {
                            if (currentCentre != centNo)
                            {
                                // wrong sheet in batch
                                DisplayRtbDisplayMessage(" *** CONFIRM CENTRE number ***");
                                rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "... *** CONFIRM CENTRE number *** [" + currentCentre +"]");
                                notValidData++;
                                continue;
                            }
                        }

                        // check for different subject code while scanning
                        if (cbSingleSubjectMode.Checked == true)
                        {
                            if (currentSubject != csdSubjCode)
                            {
                                // wrong sheet in batch
                                DisplayRtbDisplayMessage(" *** CONFIRM SUBJECT code ***");
                                rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "... *** CONFIRM SUBJECT code *** [" + currentSubject + "]");
                                notValidData++;
                                continue;
                            }
                        }

                        // test for subject code
                        try
                        {
                            string tableName = String.Concat("SubjIndex",currentExam);
                            bool subjectOk = false;
                            DataTable dt = ds.Tables[String.Concat(tableName)];

                            // get list of all centres for the current exam
                            foreach (DataRow dr in dt.Rows)
                            {
                                // 0 for Others 2 for NAT
                                if (dr[(centNo[0] == '3' || centNo[0] == '5') || centNo[0] == '6' ? 2 : 0].ToString() == csdSubjCode)
                                {
                                    //found match
                                    subjectOk = true;
                                    break;
                                }
                            }

                            if (!subjectOk)
                            {
                                // no match found not valid data
                                DisplayRtbDisplayMessage(" *** not a valid SUBJECT Code ***");
                                rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "... *** not a valid SUBJECT CODE ***");
                                notValidData++;
                                subjectOk = false;
                                continue;
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error determining absent: " + ex.Message);
                        }

                        // cand absent
                        try
                        {
                            candAbsent = s.Substring(absentStartsAt, 1);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error determining absent: " + ex.Message);
                        }

                        try
                        {
                            candSex = s.Substring(absentStartsAt + 1, 1);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error determining absent: " + ex.Message);
                        }

                        // cand scanData
                        try
                        {
                            scanData = s.Substring(absentStartsAt + 2).TrimEnd();
                            //if (scanData.Contains("000"))
                            //{
                            //    //remove trailing zeros
                            //    scanData = scanData.Substring(0, (scanData.Length - 3)).Trim();
                            //}
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error determining scanData: " + ex.Message);
                        }

                        // start checking
                        DisplayRtbDisplayMessage("\n " + count + " - processing " + s.Substring(0, 16).Trim() + "...");

                        // checking for csdsubjcode length will cause problem for nat
                        if ((centNo.Length != centreLength) || (indexNo.Length != 3) || (csdSubjCode.Length != csdSubjLength) ||
                            (centNo.Contains('>')) || indexNo.Contains('>') || (csdSubjCode.Contains('>')))
                        {
                            //not valid data
                            DisplayRtbDisplayMessage(" *** not a valid data [Centre Number|indexNo|SubjCode Error] ***");
                            rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "... *** not a valid data [Centre Number|indexNo|SubjCode Error] ***");
                            notValidData++;
                            continue;
                        }

                        // Test for improper shading - should have more than atleast 20 shaded
                        if (scanData != "")
                        {
                            //tString = s.Substring(18).Split(' ');
                            tString = scanData.Split(' ');
                            int total = 0;
                            foreach (string ans in tString)
                            {
                                total += ans.Trim().Length;
                            }

                            if (total < int.Parse(ICTDUtilities.Properties.Resources.minShadedTotal))
                            {
                                //less than 15 options, reject and check again


                                if (cbLess15Check.Checked)
                                {
                                    rejectedData++;
                                    DisplayRtbDisplayMessage(" *** rejected: total shaded less than " + ICTDUtilities.Properties.Resources.minShadedTotal + " ***");
                                    rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "..." +
                                        " *** rejected: total shaded less than " + ICTDUtilities.Properties.Resources.minShadedTotal + " ***");
                                    continue;
                                }
                                else
                                {
                                    DisplayRtbDisplayMessage(" *** warning: total shaded less than " + ICTDUtilities.Properties.Resources.minShadedTotal + " ***");
                                    //rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "..." +
                                    //    " *** warning: total shaded less than " + Properties.Resources.minShadedTotal + " ***");

                                }

                            }
                        }
                        else
                        {
                            // check whether absent is empty
                            if (this.cbAbsentCheck.Checked && ((candAbsent == "") || (candAbsent == " ")))
                            {
                                rejectedData++;
                                DisplayRtbDisplayMessage(" *** rejected: Is candidate absent? ***");
                                rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "..." + " *** rejected: Is candidate absent? ***");
                                continue;
                            }
                            else if (!cbAbsentCheck.Checked && ((candAbsent == "") || (candAbsent == " ")))
                            {
                                DisplayRtbDisplayMessage(" *** WARNING: Is candidate absent? ***".ToUpper());
                            }
                            else
                            {
                                DisplayRtbDisplayMessage(" Absent ");
                                //rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "..." + " *** warning: Is candidate absent? ***");
                                //continue;
                            }
                        }

                        // test for absent and data
                        if (candAbsent.Trim() != "" && scanData != "")
                        {
                            //Absent with data
                            rejectedData++;
                            DisplayRtbDisplayMessage(" *** rejected: Candidate absent with data! ***");
                            rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "..." + "  *** rejected: Candidate absent with data! ***");
                            continue;
                        }
                        //List<string> temp = new List<string>();

                        if (!(noOfCentres.Contains(centNo)))
                        {
                            noOfCentres.Add(centNo);
                        }

                        if (!(noOfSubjects.Contains(csdSubjCode)))
                        {
                            noOfSubjects.Add(csdSubjCode);
                        }
                    }
                    catch (Exception ex)
                    {
                        //Error, something is wrong.
                        DisplayRtbDisplayMessage(" ***** wrong data. Please check." + ex.Message);
                        rtbRejectDisplay.AppendText("\n" + count + " - " + s.Substring(0, 16).Trim() + "..." + " ***** wrong data. Please check.");
                        notValidData++;
                        continue;
                    }


                    switch (currentScanner)
                    {
                        case scanners.Drs:
                            // Drs Data
                            try
                            {
                                db.cmd.CommandText = "INSERT INTO obj_" + currentExam + " " +
                                    "(examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, userName, MachineName) VALUES " +
                                    "('" + currentYear + "', '" + centNo + "', '" +
                                    s.Substring(centreLength, 3).Trim() + "', '" + csdSubjCode.Trim() +
                                    "', '" + candSex.Trim() + "', '" + candAbsent.Trim() +
                                    "', '" + scanData + "', '" + userName + "', '" + pcName + "');";

                            }
                            catch (Exception)
                            {
                                if (s.Length == 17)
                                    try
                                    {
                                        db.cmd.CommandText = "INSERT INTO obj_" + currentExam + " " +
                                            "(examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, userName, MachineName) VALUES " +
                                            "('" + currentYear + "', '" + centNo + "', '" + indexNo + "', '" + csdSubjCode.Trim() +
                                            "', '" + candSex.Trim() + "', '" + candAbsent.Trim() + "', '', '" + userName + "', '" + pcName + "');";
                                    }
                                    catch (Exception)
                                    {
                                        try
                                        {
                                            db.cmd.CommandText = "INSERT INTO obj_" + currentExam + " " +
                                                "(examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, userName, MachineName) VALUES " +
                                                "('" + currentYear + "', '" + centNo + "', '" + indexNo + "', '" + csdSubjCode.Trim() +
                                                "', '', '" + candAbsent.Trim() + "', '', '" + userName + "', '" + pcName + "');";
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Error: " + ex.Message);
                                        }

                                    }
                            }
                            break;
                        case scanners.Nanhao2:
                        case scanners.Nanhao:
                            // Nanhao data
                            try
                            {
                                db.cmd.CommandText = "INSERT INTO obj_" + currentExam + " " +
                                    "(examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, userName, MachineName) VALUES " +
                                    "('" + currentYear + "', '" + centNo + "', '" + indexNo + "', '" + csdSubjCode.Trim() +
                                    "', '" + candSex.Trim() + "', '" + candAbsent.Trim() + "', '" + scanData + "', '" +
                                    userName + "', '" + pcName + "');";

                            }
                            catch (Exception)
                            {
                                if (s.Length == 17)
                                    try
                                    {
                                        db.cmd.CommandText = "INSERT INTO obj_" + currentExam + " " +
                                            "(examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, userName, MachineName) VALUES " +
                                            "('" + currentYear + "', '" + centNo + "', '" + indexNo + "', '" + csdSubjCode.Trim() +
                                            "', '" + candSex.Trim() + "', '" + candAbsent.Trim() + "', '', '" +
                                            userName + "', '" + pcName + "');";
                                    }
                                    catch (Exception)
                                    {
                                        try
                                        {
                                            db.cmd.CommandText = "INSERT INTO obj_" + currentExam + " " +
                                                "(examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, userName, MachineName) VALUES " +
                                                "('" + currentYear + "', '" + centNo + "', '" + indexNo + "', '" + csdSubjCode.Trim() +
                                                "', '', '" + candAbsent.Trim() + "', '', '" + userName + "', '" + pcName + "');";
                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Error: " + ex.Message);
                                        }

                                    }
                            }
                            break;
                        default:
                            break;
                    }

                    // common codes
                    try
                    {
                        if (db.cmd.ExecuteNonQuery() > 0)
                        {
                            //Console.WriteLine("saved...");
                            DisplayRtbDisplayMessage("success");
                            success++;
                        }
                        else
                        {
                            //Console.WriteLine("failed...");
                            DisplayRtbDisplayMessage("failed");
                            failed++;
                        }
                    }
                    catch (OleDbException ex)
                    {
                        //error if value is duplicated
                        if (showErrorDialog)
                        {
                            DialogResult = MessageBox.Show(s.Substring(0, 16).Trim() +
                                " already exist. It will not be saved. Please escallate for action to be taken.\n\nShow this message for others?",
                                "Error: record exists", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                            switch (DialogResult)
                            {
                                case DialogResult.No:
                                    showErrorDialog = false;
                                    break;
                                case DialogResult.Yes:
                                    break;
                                default:
                                    //abort current process
                                    if (MessageBox.Show("This will cancel the current operation. Are you sure?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                                    {
                                        DisplayRtbDisplayMessage("\n*** ABORTED ***");
                                        return;
                                    }
                                    break;
                            }

                        }
                        Console.WriteLine("Error running insert: " + ex.Message);
                        DisplayRtbDisplayMessage("ignored (already exist) !!");
                        ignored++;
                    }


                } // end for each loop

                // Display summary
                DisplayRtbDisplayMessage("\n\nSuccessfully transferred " + success + " out of " + lblTotalCleanLines.Text);
                DisplayRtbDisplayMessage("\n    Success = " + success);
                DisplayRtbDisplayMessage("\n    Failed = " + failed);
                DisplayRtbDisplayMessage("\n    Ignored (duplicates) = " + ignored);
                DisplayRtbDisplayMessage("\n    Unrecognised data = " + notValidData);
                DisplayRtbDisplayMessage("\n    Rejected data = " + rejectedData);
                DisplayRtbDisplayMessage("\n    No of Centres scanned = " + noOfCentres.Count());

                if (noOfCentres.Count() > 1)
                {
                    foreach (string cent in noOfCentres)
                    {
                        DisplayRtbDisplayMessage("\n      - = " + cent);
                    }
                    DisplayRtbDisplayMessage("\n    ***** Please Check *****");
                }

                DisplayRtbDisplayMessage("\n    No of subjects scanned = " + noOfSubjects.Count());
                rtbRejectDisplay.AppendText("\n\nSuccessfully transfered: " + success + " out of " + lblTotalCleanLines.Text + "\n");

                if (noOfSubjects.Count() >= 1)
                {
                    foreach (string subj in noOfSubjects)
                    {
                        DisplayRtbDisplayMessage("\n      - = " + subj);
                    }
                    DisplayRtbDisplayMessage("\n    ***** Please Check *****");
                }
                DisplayRtbDisplayMessage("\n\n\nEND");
                //MessageBox.Show("Successfully transfered: " + success + " out of " + lblTotalCleanLines.Text, "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClearRtbs.PerformClick();

                //if (rtbRejectDisplay.Text != "")
                //{
                //    ////scRtfDisplay.Panel1Collapsed = true;
                //    ////scRtfDisplay.Panel2Collapsed = false;
                //}
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving to db: " + ex.Message);
                DisplayRtbDisplayMessage("failed");
            }
            finally
            {
                db.con.Close();
                btnPasteDataFromCB.Enabled = true;
                btnClean.Enabled = true;
                btnClearRtbs.Enabled = true;
                showErrorDialog = true;
            }

            currentCentre = "";
            currentSubject = "";
            //MessageBox.Show("Successfully transfered: " + success + " out of " + lblTotalCleanLines.Text, "Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            rtbRejectDisplay.AppendText("_______________________________________________");
            rtbRejectDisplay.ScrollToCaret();

            btnSaveScanned.Visible = true;
            btnSaveScanned.PerformClick();

        }

        private bool ProcessScoringKey(string s)
        {
            DisplayRtbDisplayMessage("\nChecking key... ");

            // scoring key
            // do checks here
            if (s.Contains('>'))
            {
                // key not valid. Multi mark
                DisplayRtbDisplayMessage("Key not valid !!!");
                return false;
            }

            //if (ProcessScoringKey(s))
            //{
            //    success++;
            //    DisplayRtbDisplayMessage("Saved successfully.\n");
            //}
            //else
            //{
            //    failed++;
            //    DisplayRtbDisplayMessage("***** REJECTED *****");
            //    rtbRejectDisplay.AppendText("\n" + count + " - " + s + "\n --> Rejected.");
            //}


            try
            {
                // 9980402013607213  CBDACDADBACAAADABCDBBDDCBCBAACBDBCABDCCA
                // 9980052014999999  AABCD
                // 993050201331  BCCBAACDBBBCBDABABBACBBBBABDCBDAAABABCDCAABDCCACDA
                int noOfItems = 0;
                string examInitial;
                string examYear;
                string csdSubjCode;
                //int dataStartsAt;
                string data;

                try
                {
                    noOfItems = int.Parse(s.Substring(3, 3));

                    if ((noOfItems < 0) || (noOfItems >= 120))
                    {
                        DisplayRtbDisplayMessage("\n*****No of items not valid: " + noOfItems);
                        return false;
                    }
                }
                catch (Exception)
                {
                    DisplayRtbDisplayMessage("\n*****Error determining number of items: " + s.Substring(3, 3));
                    return false;
                }

                examYear = s.Substring(6, 4);
                examInitial = s.Substring(2, 1);

                switch (examInitial)
                {
                    case "3":
                    case "5":
                    case "6":
                        this.csdSubjLength = 2;
                        //dataStartsAt = 14;
                        break;
                    default:
                        this.csdSubjLength = 6;
                        //dataStartsAt = 18;
                        break;
                }

                csdSubjCode = s.Substring(10, this.csdSubjLength);


                if (csdSubjCode.Length != this.csdSubjLength)
                {
                    DisplayRtbDisplayMessage("\n*****subjects code length error");
                    return false;
                }

                if ((int.Parse(examInitial) < 0) || (int.Parse(examInitial) > 9))
                {
                    DisplayRtbDisplayMessage("\n*****Exam Initial not recognised: " + s.Substring(2, 1));
                    return false;
                }

                data = s.Substring(18).Trim();

                if ((string.IsNullOrWhiteSpace(data)) || (string.IsNullOrEmpty(data)))
                {
                    //not valid
                    DisplayRtbDisplayMessage("\n*****subjects code length error");
                    return false;
                }

                if (data.Length != noOfItems)
                {
                    // Something is wrong with the total items.
                    return false;
                }

                //check for each option
                foreach (char c in data)
                {
                    DisplayRtbDisplayMessage(c.ToString());

                    if ((c != 'A') && (c != 'B') && (c != 'C') && (c != 'D') && (c != ' ') && (c != '<'))
                    {
                        // not valid
                        DisplayRtbDisplayMessage("\n*****Error with options: " + c);
                        return false;
                    }
                }

                // seems like it has passsed. save key

                List<string> sqls = new List<string>();

                //sqls.Add("DELETE * FROM ScoringKeys WHERE ((examYear = '" + examYear + 
                //    "') AND (CsdSubjCode = '" + csdSubjCode + "'));");

                // INSERT INTO ScoringKeys ( examYear, CsdSubjCode, examInitial, NoOfItems, ScoreData, pcName, userName, scanner )
                //VALUES(examYear, CsdSubjCode, examInitial, NoOfItems, ScoreData, pcName, userName, scanner); ;
                sqls.Add("INSERT INTO ScoringKeys ( examYear, CsdSubjCode, examInitial, NoOfItems, ScoreData, pcName, userName, scanner) " +
                    "VALUES ('" + examYear + "', '" + csdSubjCode + "', '" + examInitial +
                    "', '" + noOfItems + "', '" + data + "', '" + pcName + "', '" + userName + "', '" + currentScanner.ToString() + "');");

                foreach (string sql in sqls)
                {
                    db.cmd4.CommandText = sql;

                    try
                    {
                        db.con4.Open();

                        if (db.cmd4.ExecuteNonQuery() > 0)
                        {
                            // success running command
                            DisplayRtbDisplayMessage("\nSaved\n\n");
                            Console.WriteLine("Success updating key: " + s);
                            return true;
                        }
                        else
                        {
                            DisplayRtbDisplayMessage("\nFailed to save key to db\n\n");
                            return false;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error with db: " + ex.Message);
                        DisplayRtbDisplayMessage("Error with db: " + ex.Message);
                    }
                    finally
                    {
                        db.con4.Close();
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error processing key: " + ex.Message);
            }
            return false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DisplayRtbDisplayMessage(string message, bool clearAll)
        {
            if (clearAll)
                rtbDisplay.Clear();

            rtbDisplay.AppendText(message + "\n");
        }

        private void DisplayRtbDisplayMessage(string message)
        {
            rtbDisplay.AppendText(message);
            rtbDisplay.ScrollToCaret();
        }

        private void btnClearRtbDisplay_Click(object sender, EventArgs e)
        {
            rtbDisplay.Clear();
            rtbRejectDisplay.Clear();
        }

        private void scMid_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTotalLines_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void scMain_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLoadScanned_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;

            if (LoadScanned())
            {
                // ok what to do next
                LoadUserTotalScanned();
                lbCsdSubjCode.Focus();
            }
            else
            {
            }

            UseWaitCursor = false;
        }

        private bool LoadScanned()
        {
            //Orig
            //try
            //{
            //    lbCsdSubjCode.Items.Clear();
            //}
            //catch (Exception){}


            //if (cbExams.SelectedIndex == -1)
            //    return false;

            //string tableName = "";

            //try
            //{
            //    tableName = "obj_" + currentGrade + "_" + currentYear;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("There was an error: " + ex.Message);
            //    return false;
            //}


            //try
            //{
            //    //fill ds with data. basically refresh or add
            //    string sqlStatement = "SELECT DISTINCT " + tableName + ".CsdSubjCode FROM " + tableName + " INNER JOIN SubjIndex" +
            //        tableName.Substring(4, 1) + " ON " + tableName + ".CsdSubjCode = SubjIndex" + tableName.Substring(4, 1) + ".CsdSubjCode;";

            //    if (UpdateDs(tableName, sqlStatement))
            //    {
            //        //successfully updated: load data into lbCsdSubjCode

            //        DataTable dt = ds.Tables[tableName];

            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            if (!(dr["CsdSubjCode"].ToString().Contains(">")))
            //                lbCsdSubjCode.Items.Add(dr["CsdSubjCode"].ToString() + " - " + GetSubjectName(dr["CsdSubjCode"].ToString()));
            //        }

            //        return true;
            //    }
            //    else
            //    {
            //        //failed to update
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error loading scanned data: " + ex.Message);
            //}

            //return false;

            try
            {
                this.lbCsdSubjCode.Items.Clear();
                this.lvSubjDetails.Items.Clear();
            }
            catch (Exception)
            {
            }
            if (this.cbExams.SelectedIndex != -1)
            {
                Exception exception;
                string tableName = "";
                string examInitial = "";
                try
                {
                    tableName = "obj_" + cbExams.SelectedItem.ToString().Substring(0,2).Trim();
                    examInitial = cbExams.SelectedItem.ToString().Substring(0, 2).Trim();
                    //tableName = "obj_" + this.currentGrade + "_" + this.currentYear;
                                                      }
                catch (Exception exception2)
                {
                    exception = exception2;
                    MessageBox.Show("There was an error: " + exception.Message);
                    return false;
                }
                try
                {
                    string currentGrade = this.currentGrade;
                    string currentYear = cbExamYear.Text;

                    if ((currentGrade != null) && (((currentGrade == "3") || (currentGrade == "5")) || (currentGrade == "6")))
                    {
                        this.csdSubjLength = 2;
                    }
                    else
                    {
                        this.csdSubjLength = 6;
                    }
                    //string sqlStatement = string.Concat(new object[] { "SELECT DISTINCT ", tableName, ".CsdSubjCode FROM ", tableName,
                    //    " INNER JOIN SubjIndex", tableName.Substring(4, 1), " ON LEFT(", tableName, ".CsdSubjCode, ", this.csdSubjLength,
                    //    ") = LEFT(SubjIndex", tableName.Substring(4, 1), ".CsdSubjCode, ",
                    //    this.csdSubjLength, ") WHERE ", tableName, ".examYear = '" + currentYear + "';" });

                    string sqlStatement = string.Concat(new object[] { "SELECT DISTINCT ", tableName, ".CsdSubjCode FROM ", tableName,
                        " INNER JOIN SubjIndex", examInitial, " ON LEFT(", tableName, ".CsdSubjCode, ", this.csdSubjLength,
                        ") = LEFT(SubjIndex", examInitial, ".CsdSubjCode, ",
                        this.csdSubjLength, ") WHERE ", tableName, ".examYear = '" + currentYear + "';" });

                    if (this.UpdateDs(tableName, sqlStatement))
                    {
                        DataTable table = this.ds.Tables[tableName];
                        foreach (DataRow row in table.Rows)
                        {
                            if (!row["CsdSubjCode"].ToString().Contains(">"))
                            {
                                this.lbCsdSubjCode.Items.Add(row["CsdSubjCode"].ToString() + " - " + this.GetSubjectName(row["CsdSubjCode"].ToString()));
                            }
                        }
                        return true;
                    }
                }
                catch (Exception exception3)
                {
                    exception = exception3;
                    Console.WriteLine("Error loading scanned data: " + exception.Message);
                }
            }
            return false;
        }

        private bool UpdateDs(string tableName, string sqlStatement)
        {
            try
            {
                if (ds == null)
                    ds = new DataSet();

                // try to remove table first
                try
                {
                    ds.Tables.RemoveAt(ds.Tables.IndexOf(tableName));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error removing table: " + tableName + ": " + ex.Message);
                }

                OleDbDataAdapter dsAdapter = new OleDbDataAdapter(new OleDbCommand(sqlStatement, new OleDbConnection(db.connectionString)));
                //dsAdapter.SelectCommand.Connection = new OleDbConnection(db.connectionString);
                dsAdapter.SelectCommand.CommandText = sqlStatement;
                dsAdapter.Fill(ds, tableName);
                Console.WriteLine("Returned " + ds.Tables[tableName].Rows.Count + " : " + tableName);
                dsAdapter.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Updating ds - table: " + tableName + " sql: " + sqlStatement + " : " + ex.Message);
            }
            return false;
        }

        private string GetSubjectName(string CsdSubjCode)
        {
            try
            {
                DataTable table = this.ds.Tables["SubjIndex" + cbExams.SelectedItem.ToString().Substring(0, 2).Trim()];
                foreach (DataRow row in table.Rows)
                {
                    if (CsdSubjCode == row["CsdSubjCode"].ToString().Substring(0, CsdSubjCode.Length))
                    {
                        return row["SubjName"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error getting subject name: {ex.Message}");
            }

            return "Unknown";

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbCsdSubjCode.Items.Clear();
            lvSubjDetails.Items.Clear();
            cbExams.SelectedIndex = -1;
            btnLoadScanned.Visible = false;
        }

        private void cbExams_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                currentGrade = cbExams.SelectedItem.ToString().Substring(0, 1);
                currentExam = cbExams.SelectedItem.ToString().Substring(4);
                btnLoadScanned.Visible = true;
                //btnLoadScanned.PerformClick();
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error: " + ex.Message);
                Console.WriteLine("Error: " + ex.Message);
            }

        }

        private void lbCsdSubjCode_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show("Not yet implemented");
            // Load the centres scanned for the subjects selected.
            startLoadingLvWithSubjects();
        }

        private void startLoadingLvWithSubjects()
        {
            lvSubjDetails.Items.Clear();
            try
            {
                lblSelectedSubject.Text = lbCsdSubjCode.SelectedItem.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in loading subjects: " + ex.Message);
                return;
            }

            try
            {
                string csdSubjCode = lbCsdSubjCode.SelectedItem.ToString().Substring(0, csdSubjLength);

                if (LoadLvWithSubject(csdSubjCode))
                {
                    //MessageBox.Show(this, "Successfully loaded details for " + subj, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Failed to load " + csdSubjCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in StarLoadingLvwithsubjects(): " + ex.Message);
            }

        }

        private bool LoadLvWithSubject(string csdSubjCode)
        {
            // Orig
            //lvSubjDetails.Items.Clear();
            //List<string> tableNames = new List<string>();
            //List<string> sqls = new List<string>();

            //try 
            //{
            //    tableNames.Add("obj_" + currentGrade + "_" + currentYear + "TotalScanned");
            //    tableNames.Add("obj_" + currentGrade + "_" + currentYear + "TotalExpected");

            //    sqls.Add("SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total " +
            //        "FROM obj_" + currentGrade + "_" + currentYear + " WHERE ((CsdSubjCode = '" + csdSubjCode + "') AND (examYear = '" + currentYear +
            //        "')) GROUP BY examYear, centNo, CsdSubjCode;");

            //    sqls.Add("SELECT DISTINCT examYear, centNo, GenSubjCode as CsdSubjCode, Count(indexNo) AS Total " +
            //        "FROM [05OUT" + currentExam + "] WHERE ((LEFT(GenSubjCode, 3) = '" + csdSubjCode.Substring(0, 3) + "') AND (examYear = '" + currentYear +
            //        "')) GROUP BY examYear, centNo, GenSubjCode;");

            //    for (int i = 0; i < sqls.Count; i++)
            //    {
            //        if (UpdateDs(tableNames[i], sqls[i]))
            //        {
            //            Console.WriteLine(tableNames[i] + ": Update success");
            //        }
            //    }

            //    // now start populating
            //    //ListViewGroup lvGroup = new ListViewGroup(csdSubjCode, HorizontalAlignment.Center);
            //    //List<ListViewItem> lvis = new List<ListViewItem>();
            //    DataTable dt = ds.Tables["obj_" + currentGrade + "_" + currentYear + "TotalScanned"];
            //    List<int> totalScanExp;

            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        totalScanExp = new List<int>();

            //        if (GettotalExpScan(totalScanExp, tableNames, dr["centNo"].ToString(), dr["CsdSubjCode"].ToString()))
            //        {
            //            try
            //            {
            //                string[] subItems = {dr["centNo"].ToString(), "-" , totalScanExp[1].ToString(), "-", totalScanExp[0].ToString(), 
            //                    (totalScanExp[0] - totalScanExp[1]).ToString()};

            //                lvSubjDetails.Items.Add(new ListViewItem(subItems));
            //            }
            //            catch (Exception ex)
            //            {
            //                Console.WriteLine("Error in getting records for: " + dr["centNo"].ToString() + " - " + dr["CsdSubjCode"].ToString() + ": " + ex.Message);
            //            }                        

            //            //var listVI = new ListViewItem(subItems);

            //            //lvSubjDetails.Items.Add(listVI);

            //        }
            //        else
            //        {
            //            // cannot load values
            //            MessageBox.Show(this, "Cannot load details for subjects " + csdSubjCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    HighlightOutstanding();
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error in LoadLvWithSubject: " + ex.Message);
            //    return false;
            //}

            //Other
            Exception exception;
            bool flag;
            this.lvSubjDetails.Items.Clear();
            List<string> tableNames = new List<string>();
            List<string> sqls = new List<string>();
            this.currentYear = cbExamYear.Text;

            tableNames.Add("obj_" + this.currentGrade + "TotalScanned");
            tableNames.Add("obj_" + this.currentGrade + "TotalExpected");
            tableNames.Add("obj_" + this.currentGrade + "ScanInfo");

            //tableNames.Add("obj_" + this.currentGrade + "_" + this.currentYear + "TotalScanned");
            //tableNames.Add("obj_" + this.currentGrade + "_" + this.currentYear + "TotalExpected");

            string currentGrade = this.currentGrade;
            string selectedDate = dtpViewSpecificDate.Value.ToShortDateString();

            switch (this.currentGrade)
            {
                case "3":
                case "5":
                    this.genSubjCodeLength = 2;
                    if (rbViewSpecificDate.Checked == true)
                    {
                        //sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total, LEFT(ts, 10) AS DateScanned, userName FROM obj_", this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength, ")) AND (examYear = '", this.currentYear, "') AND (LEFT(ts, 10) = '" + selectedDate + "')) GROUP BY examYear, centNo, CsdSubjCode, LEFT(ts, 10), userName;" }));
                        sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total, LEFT(ts, 10) AS DateScanned, userName FROM obj_", this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength, ")) AND (examYear = '", this.currentYear, "') AND (LEFT(ts, 10) = '" + selectedDate + "')) GROUP BY examYear, centNo, CsdSubjCode, LEFT(ts, 10), userName;" }));

                    }
                    else
                    {
                        //sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total, LEFT(ts, 10) AS DateScanned, userName FROM obj_", this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength, ")) AND (examYear = '", this.currentYear, "')) GROUP BY examYear, centNo, CsdSubjCode, LEFT(ts, 10), userName;" }));
                        sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total FROM obj_",
                            this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ",
                            this.csdSubjLength, ")) AND (examYear = '", this.currentYear,
                            "')) GROUP BY examYear, centNo, CsdSubjCode;" }));
                    }
                    sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, GenSubjCode as CsdSubjCode, Count(indexNo) AS Total FROM [05OUTG", this.currentGrade, "] WHERE ((LEFT(GenSubjCode, ", this.genSubjCodeLength, ") = '", csdSubjCode.Substring(0, this.genSubjCodeLength), "') AND (examYear = '", this.currentYear, "')) GROUP BY examYear, centNo, GenSubjCode;" }));

                    break;
                case "6":
                    this.genSubjCodeLength = 2;
                    if (rbViewSpecificDate.Checked == true)
                    {
                        sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total, LEFT(ts, 10) AS DateScanned, userName FROM obj_", this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength, ")) AND (examYear = '", this.currentYear, "') AND (LEFT(ts, 10) = '" + selectedDate + "')) GROUP BY examYear, centNo, CsdSubjCode, LEFT(ts, 10), userName;" }));
                    }
                    else
                    {
                        //sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total, '' AS DateScanned, '-' as userName FROM obj_", this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength, ")) AND (examYear = '", this.currentYear, "')) GROUP BY examYear, centNo, CsdSubjCode, '', '-';" }));
                        sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total, LEFT(ts, 10) AS DateScanned, userName FROM obj_", this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength, ")) AND (examYear = '", this.currentYear, "')) GROUP BY examYear, centNo, CsdSubjCode, LEFT(ts, 10), userName;" }));
                    }
                    sqls.Add(string.Concat(new object[] { "SELECT examYear, centNo, GenSubjCode as CsdSubjCode, Count(indexNo) AS Total FROM [05OUTG8] WHERE ((LEFT(GenSubjCode, ", this.genSubjCodeLength, ") = '", csdSubjCode.Substring(0, this.genSubjCodeLength), "') AND (examYear = '", this.currentYear, "')) GROUP BY examYear, centNo, GenSubjCode;" }));

                    break;
                default:
                    this.genSubjCodeLength = 3;
                    if (rbViewSpecificDate.Checked == true)
                    {
                        sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total, LEFT(ts, 10) AS DateScanned, userName FROM obj_", this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength, ")) AND (examYear = '", this.currentYear, "') AND (LEFT(ts, 10) = '" + selectedDate + "')) GROUP BY examYear, centNo, CsdSubjCode, LEFT(ts, 10), userName;" }));
                    }
                    else
                    {
                        sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total FROM obj_",
                            this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ",
                            this.csdSubjLength, ")) AND (examYear = '", this.currentYear,
                            "')) GROUP BY examYear, centNo, CsdSubjCode;" }));

                    }
                    //sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, CsdSubjCode, Count(indexNo) AS Total, LEFT(ts, 10) AS DateScanned FROM obj_", this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength, ")) AND (examYear = '", this.currentYear, "')) GROUP BY examYear, centNo, CsdSubjCode, LEFT(ts, 10);" }));
                    sqls.Add(string.Concat(new object[] { "SELECT DISTINCT examYear, centNo, GenSubjCode as CsdSubjCode, Count(indexNo) AS Total FROM [05OUT", this.currentExam, "] WHERE ((LEFT(GenSubjCode, ", this.genSubjCodeLength, ") = '", csdSubjCode.Substring(0, this.genSubjCodeLength), "') AND (examYear = '", this.currentYear, "')) GROUP BY examYear, centNo, GenSubjCode;" }));

                    break;
            }



            //sqls.Add(string.Concat(new object[] {
            //            "SELECT DISTINCT examYear, centNo, CsdSubjCode, '' AS DateScanned, '-' as userName FROM obj_",
            //            this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength,
            //            ")) AND (examYear = '", this.currentYear, "')) GROUP BY examYear, centNo, CsdSubjCode, '', '-';" }));

            sqls.Add(string.Concat(new object[] {
                        "SELECT DISTINCT examYear, centNo, CsdSubjCode, LEFT(ts, 10) AS DateScanned, userName FROM obj_",
                        this.currentGrade, " WHERE ((LEFT(CsdSubjCode, ", this.csdSubjLength, ") = LEFT('", csdSubjCode, "', ", this.csdSubjLength,
                        ")) AND (examYear = '", this.currentYear, "')) GROUP BY examYear, centNo, CsdSubjCode, LEFT(ts, 10), userName;" }));

            try
            {
                string[] strArray2 = new string[8];

                for (int i = 0; i < sqls.Count; i++)
                {
                    if (this.UpdateDs(tableNames[i], sqls[i]))
                    {
                        Console.WriteLine(tableNames[i] + ": Update success");
                    }
                }

                DataTable table = this.ds.Tables["obj_" + this.currentGrade + "TotalExpected"];
                //DataTable table = this.ds.Tables["obj_" + this.currentGrade + "TotalScanned"];
                List<string> userName = new List<string>();

                foreach (DataRow row in table.Rows)
                {
                    List<int> expScan = new List<int>();
                    if (this.GettotalExpScan(expScan, tableNames, row["centNo"].ToString(), row["CsdSubjCode"].ToString()))
                    {
                        try
                        {
                            //string[] strArray2 = new string[8];


                            strArray2[0] = row["centNo"].ToString();
                            strArray2[1] = GetCentreName(row["centNo"].ToString());
                            int num2 = (int)row["Total"];
                            strArray2[2] = num2.ToString();
                            strArray2[3] = "-";
                            num2 = expScan[0];
                            strArray2[4] = num2.ToString();
                            int difference = (expScan[0] - (int)row["Total"]);
                            strArray2[5] = difference.ToString();

                            try
                            {
                                //strArray2[6] = row["DateScanned"].ToString();
                                strArray2[6] = GetDateScanned(row["centNo"].ToString(), ds.Tables["obj_" + this.currentGrade + "ScanInfo"]);
                            }
                            catch (Exception)
                            {
                            }

                            try
                            {
                                strArray2[7] = GetScannedBy(row["centNo"].ToString(), ds.Tables["obj_" + this.currentGrade + "ScanInfo"]);
                                if (!userName.Contains(strArray2[7]))
                                    userName.Add(strArray2[7]);
                                if (!cmbViewSpecificUser.Items.Contains(strArray2[7]))
                                    cmbViewSpecificUser.Items.Add(strArray2[7]);
                                //cmbViewSpecificUser.Items.Clear();
                                //cmbViewSpecificUser.Items.AddRange(userName.ToArray());
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error parsing username: " + ex.Message);
                            }

                            if (rbViewIncompleteCentres.Checked)
                            {
                                if (difference >= 0)
                                    continue;
                            }

                            if (cbViewSpecificUser.Checked)
                            {
                                if (!strArray2[7].ToString().Equals(cmbViewSpecificUser.Text))
                                    continue;
                            }

                            if (rbUnscannedCentres.Checked)
                            {
                                if (num2 != 0)
                                    continue;
                            }

                            string[] items = strArray2;
                            this.lvSubjDetails.Items.Add(new ListViewItem(items));

                        }
                        catch (Exception exception1)
                        {
                            exception = exception1;
                            Console.WriteLine("Error in getting records for: " + row["centNo"].ToString() + " - " + row["CsdSubjCode"].ToString() + ": " + exception.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Cannot load details for subjects " + csdSubjCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }

                this.HighlightOutstanding();
                flag = true;

                // load unscanned centres


            }
            catch (Exception exception2)
            {
                exception = exception2;
                Console.WriteLine("Error in LoadLvWithSubject: " + exception.Message);
                flag = false;
            }
            return flag;

        }

        string GetCentreName(string centNo)
        {
            string centreName = "";
            string sql = "";
            DataTable listOfCentres = new DataTable();

            switch (centNo[0])
            {
                case '3':
                case '5':
                case '6':
                    centreName = "CentresNatG" + centNo[0].ToString();
                    sql = "Select CentNo, CentName from CentresNatG" + centNo[0].ToString();
                    break;
                case '7':
                    break;
                case '8':
                    break;
                case '9':
                    break;
                default:
                    break;
            }

            listOfCentres = ds.Tables[centreName];

            try
            {

                if (listOfCentres == null)
                {
                    // centre not found, build sql load it in the dataset


                    if (this.UpdateDs(centreName, sql))
                    {
                        Console.WriteLine(centreName + ": Update success");
                    }
                    else
                        return "-";
                }

                // centre should be in table listOfCentres

                foreach (DataRow dr in listOfCentres.Rows)
                {
                    if (dr["CentNo"].ToString().Equals(centNo))
                    {
                        // found a match
                        return dr["CentName"].ToString();
                    }
                }

                // no match found
                return "- not found -";
            }
            catch (Exception ex)
            {
            }
            return "-";
        }

        private bool GetUnscannedCentres()
        {
            try
            {

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        private string GetScannedBy(string centNo, DataTable dt)
        {
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (centNo.Equals(dr["centNo"].ToString()))
                    {
                        // DateScanned, userName
                        return dr["userName"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error GetScanned(): " + ex.Message);
            }
            return "";
        }

        private string GetDateScanned(string centNo, DataTable dt)
        {
            try
            {
                foreach (DataRow dr in dt.Rows)
                {
                    if (centNo.Equals(dr["centNo"].ToString()))
                    {
                        // DateScanned, userName
                        return dr["DateScanned"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error GetScanned(): " + ex.Message);
            }
            return "";
        }

        private void HighlightOutstanding()
        {
            int count = 0;
            foreach (ListViewItem lv in lvSubjDetails.Items)
            {
                try
                {
                    if (cbViewSpecificUser.Checked)
                    {
                        if (!cmbViewSpecificUser.Text.Equals(""))
                        {
                            if (!lv.SubItems[7].Text.Equals(cmbViewSpecificUser.Text))
                            {
                                lvSubjDetails.Items.RemoveAt(count);
                                continue;
                            }
                        }
                    }

                    if (int.Parse(lv.SubItems[5].Text) < 0)
                    {
                        lv.BackColor = Color.PaleVioletRed;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error HighlightOutstanding: ", ex.Message);
                }
                count++;
            }
        }

        private bool GettotalExpScan(List<int> expScan, List<string> tableNames, string centNo, string csdSubjCode)
        {
            //Orig
            //try
            //{
            //    for (int i = 0; i < tableNames.Count; i++)
            //    {
            //        DataTable dt = ds.Tables[tableNames[i]];

            //        foreach (DataRow dr in dt.Rows)
            //        {
            //            if (dr["centNo"].ToString() == centNo)
            //            {
            //                if (dr["CsdSubjCode"].ToString().Substring(0, 3) == csdSubjCode.Substring(0, 3))
            //                {
            //                    //found a match
            //                    expScan.Add((int)dr["Total"]);
            //                    break;
            //                }
            //            }
            //        }
            //    //expScan.Add(0);
            //    }   

            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error in GettotalExpScan: " + ex.Message);
            //}


            //return false;

            //Other
            try
            {
                int totalExpected = 0, totalScanned = 0;
                expScan.Add(0);
                expScan.Add(0);

                for (int i = 0; i <= 0; i++)
                //for (int i = 0; i < tableNames.Count-1; i++)
                {
                    DataTable table = this.ds.Tables[tableNames[i]];
                    foreach (DataRow row in table.Rows)
                    {
                        try
                        {
                            if (row["centNo"].ToString() == centNo)
                            {
                                //Console.WriteLine("Subj Code: " + row["CsdSubjCode"].ToString().Substring(0, this.genSubjCodeLength));
                                if (row["CsdSubjCode"].ToString().Substring(0, this.genSubjCodeLength) == csdSubjCode.Substring(0, this.genSubjCodeLength))
                                {
                                    totalScanned += (int)row["Total"];
                                }
                            }
                        }
                        catch (Exception exception)
                        {
                            Console.WriteLine("Error in GetTotalExpScan(): " + exception.Message);
                        }
                    }
                    expScan[0] = totalScanned;
                }
                return true;
            }
            catch (Exception exception2)
            {
                Console.WriteLine("Error in GettotalExpScan: " + exception2.Message);
            }
            return false;

        }

        private int GetTotalExpected(string centNo, string csdSubjCode)
        {
            // retrieves
            return 0;
        }

        private int GetTotalScanned(string centNo, string csdSubjCode)
        {
            // retrieves
            return 0;
        }

        private void lbCsdSubjCode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportSelected_Click(object sender, EventArgs e)
        {
            List<string> subj;
            Char examInitial;

            if (lbCsdSubjCode.Items.Count < 1)
                return;

            try
            {
                examInitial = lbCsdSubjCode.SelectedItem.ToString()[0];
            }
            catch (Exception)
            {
                examInitial = lbCsdSubjCode.Items[0].ToString()[0];
            }


            //send a list of string to represent the subjects codes
            //string subj = lbCsdSubjCode.SelectedItem.ToString().Substring(0, 6);
            switch (examInitial)
            {
                case '3':
                case '5':
                case '8':
                    subj = new List<string>() { lbCsdSubjCode.SelectedItem.ToString().Substring(0, 2) };
                    break;
                default:
                    subj = new List<string>() { lbCsdSubjCode.SelectedItem.ToString().Substring(0, 6) };
                    break;
            }

            //List<string> subj = new List<string>(){lbCsdSubjCode.SelectedItem.ToString().Substring(0, 6)};

            frmExportSubjects frmExport = new frmExportSubjects(subj, db.con.ConnectionString, "obj_" + currentGrade, cbExamYear.Text);
            frmExport.ShowDialog();

        }

        private void btnExportAll_Click(object sender, EventArgs e)
        {
            List<string> subj = new List<string>();
            Char examInitial;

            if (lbCsdSubjCode.Items.Count < 1)
                return;

            try
            {
                examInitial = lbCsdSubjCode.SelectedItem.ToString()[0];
            }
            catch (Exception)
            {
                examInitial = lbCsdSubjCode.Items[0].ToString()[0];
            }

            switch (examInitial)
            {
                case '3':
                case '5':
                case '8':
                    foreach (string s in lbCsdSubjCode.Items)
                    {
                        subj.Add(s.Substring(0, 2));
                    }
                    break;
                default:
                    foreach (string s in lbCsdSubjCode.Items)
                    {
                        subj.Add(s.Substring(0, 6));
                    }
                    break;
            }

            //         foreach (string s in lbCsdSubjCode.Items)
            //{
            //	subj.Add(s.Substring(0, 6));
            //}

            frmExportSubjects frmExport = new frmExportSubjects(subj, db.con.ConnectionString, ("obj_" + currentGrade), cbExamYear.Text);
            frmExport.ShowDialog();
        }

        private void tsmiLoad_Click(object sender, EventArgs e)
        {
            startLoadingLvWithSubjects();
        }

        private void tmsiClear_Click(object sender, EventArgs e)
        {
            lvSubjDetails.Items.Clear();
        }

        private void lvSubjDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvSubjDetails_DoubleClick(object sender, EventArgs e)
        {
            // load frmCheckQueries and pass the centre and subjects
            ////Console.WriteLine(lbCsdSubjCode.SelectedItem.ToString().Substring(0, 6));

            //if (lvSubjDetails.SelectedItems[0].SubItems[5].Text == "0")
            //    return;

            ////load table: missingCandidates
            //if (getMissingCandidate("missingCandidates", lvSubjDetails.SelectedItems[0].SubItems[0].Text))
            //{
            //    //successfully updated, pass it on
            //    frmCheckQueries frm = new frmCheckQueries(lvSubjDetails.SelectedItems[0].SubItems[0].Text,
            //    lbCsdSubjCode.SelectedItem.ToString().Substring(0, 6), ds.Tables["missingCandidates"]);
            //    frm.ShowDialog();
            //}
            //else
            //{
            //}

            if ((this.lvSubjDetails.SelectedItems[0].SubItems[5].Text != "0") && this.getMissingCandidate("missingCandidates", this.lvSubjDetails.SelectedItems[0].SubItems[0].Text))
            {
                //frmCheckQueries frm = new frmCheckQueries(lvSubjDetails.SelectedItems[0].SubItems[0].Text,
                //lbCsdSubjCode.SelectedItem.ToString().Substring(0, csdSubjLength), ds.Tables["missingCandidates"]);
                //frm.ShowDialog();

                frmCheckQueries frm = new frmCheckQueries(cbExamYear.Text,lvSubjDetails.SelectedItems[0].SubItems[0].Text,
                lbCsdSubjCode.SelectedItem.ToString().Substring(0, csdSubjLength), ds.Tables["missingCandidates"], db);
                frm.ShowDialog();

            }


        }

        private bool getMissingCandidate(string tableName, string centNo)
        {
            //Orig
            //string sql = "SELECT PrePrintObjDetails" + currentExam + ".examYear, PrePrintObjDetails" + currentExam + ".centNo, PrePrintObjDetails" + currentExam + ".indexNo, " +
            //        "PrePrintObjDetails" + currentExam + ".CsdSubjCode " +
            //        "FROM PrePrintObjDetails" + currentExam + " LEFT JOIN obj_" + currentGrade + "_" + currentYear + " ON " +
            //        "(PrePrintObjDetails" + currentExam + ".examYear = obj_" + currentGrade + "_" + currentYear + ".examYear) AND " +
            //        "(PrePrintObjDetails" + currentExam + ".centNo = obj_" + currentGrade + "_" + currentYear + ".centNo) AND " +
            //        "(PrePrintObjDetails" + currentExam + ".indexNo = obj_" + currentGrade + "_" + currentYear + ".indexNo) AND " +
            //        "(PrePrintObjDetails" + currentExam + ".CsdSubjCode = obj_" + currentGrade + "_" + currentYear + ".CsdSubjCode) " +
            //        "WHERE ((obj_" + currentGrade + "_" + currentYear + ".CsdSubjCode IS NULL) " +
            //        " AND (PrePrintObjDetails" + currentExam + ".centNo = '" + centNo + "'));";

            //if (UpdateDs(tableName, sql))
            //    return true;

            //return false;

            //Other
            string str;
            string currentGrade = this.currentGrade;

            switch (currentGrade)
            {
                case "3":
                case "5":
                    str = string.Concat(new object[] {
                        "SELECT PrePrintObjDetailsNAT", this.currentGrade, ".examYear, PrePrintObjDetailsNAT", this.currentGrade, ".centNo, PrePrintObjDetailsNAT",
                        this.currentGrade, ".indexNo, PrePrintObjDetailsNAT", this.currentGrade, ".CsdSubjCode FROM PrePrintObjDetailsNAT", this.currentGrade,
                        " LEFT JOIN obj_", this.currentGrade, " ON (PrePrintObjDetailsNAT", this.currentGrade,
                        ".examYear = obj_", this.currentGrade, ".examYear) AND (PrePrintObjDetailsNAT", this.currentGrade, ".centNo = obj_",
                        this.currentGrade, ".centNo) AND (PrePrintObjDetailsNAT", this.currentGrade, ".indexNo = obj_", this.currentGrade,
                        ".indexNo) AND (PrePrintObjDetailsNAT", this.currentGrade, ".CsdSubjCode = obj_", this.currentGrade,
                        ".CsdSubjCode) WHERE ((obj_", this.currentGrade,
                        ".CsdSubjCode IS NULL)  AND (PrePrintObjDetailsNAT", this.currentGrade, ".centNo = '", centNo, "'));"});

                    //str = string.Concat(new object[] { 
                    //    "SELECT PrePrintObjDetailsNAT", this.currentGrade, ".examYear, PrePrintObjDetailsNAT", this.currentGrade, ".centNo, PrePrintObjDetailsNAT",
                    //    this.currentGrade, ".indexNo, PrePrintObjDetailsNAT", this.currentGrade, ".CsdSubjCode FROM PrePrintObjDetailsNAT", this.currentGrade, 
                    //    " LEFT JOIN obj_", this.currentGrade, "_", this.currentYear, " ON (PrePrintObjDetailsNAT", this.currentGrade, 
                    //    ".examYear = obj_", this.currentGrade, "_", this.currentYear, ".examYear) AND (PrePrintObjDetailsNAT", this.currentGrade, ".centNo = obj_", 
                    //    this.currentGrade, "_", this.currentYear, ".centNo) AND (PrePrintObjDetailsNAT", this.currentGrade, ".indexNo = obj_", this.currentGrade, 
                    //    "_", this.currentYear, ".indexNo) AND (PrePrintObjDetailsNAT", this.currentGrade, ".CsdSubjCode = obj_", this.currentGrade, 
                    //    "_", this.currentYear, ".CsdSubjCode) WHERE ((obj_", this.currentGrade, 
                    //    "_", this.currentYear, ".CsdSubjCode IS NULL)  AND (PrePrintObjDetailsNAT", this.currentGrade, ".centNo = '", centNo, "'));"});
                    //str = string.Concat(new object[] { 
                    //    "SELECT PrePrintObjDetailsNAT", this.currentGrade, ".examYear, PrePrintObjDetailsNAT", this.currentGrade, ".centNo, PrePrintObjDetailsNAT",
                    //    this.currentGrade, ".indexNo, PrePrintObjDetailsNAT", this.currentGrade, ".CsdSubjCode FROM PrePrintObjDetailsNAT", this.currentGrade, 
                    //    " LEFT JOIN obj_", this.currentGrade, "_", this.currentYear, " ON (PrePrintObjDetailsNAT", this.currentGrade, 
                    //    ".examYear = obj_", this.currentGrade, "_", this.currentYear, ".examYear) AND (PrePrintObjDetailsNAT", this.currentGrade, ".centNo = obj_", 
                    //    this.currentGrade, "_", this.currentYear, ".centNo) AND (PrePrintObjDetailsNAT", this.currentGrade, ".indexNo = obj_", this.currentGrade, 
                    //    "_", this.currentYear, ".indexNo) AND (PrePrintObjDetailsNAT", this.currentGrade, ".CsdSubjCode = obj_", this.currentGrade, 
                    //    "_", this.currentYear, ".CsdSubjCode) WHERE ((obj_", this.currentGrade, 
                    //    "_", this.currentYear, ".CsdSubjCode IS NULL)  AND (PrePrintObjDetailsNAT", this.currentGrade, ".centNo = '", centNo, "'));"});

                    break;
                case "6":
                    str = string.Concat(new object[] {
                    "SELECT PrePrintObjDetailsNAT8.examYear, PrePrintObjDetailsNAT8.centNo, PrePrintObjDetailsNAT8.indexNo, PrePrintObjDetailsNAT8.CsdSubjCode FROM PrePrintObjDetailsNAT8 LEFT JOIN obj_",
                    this.currentGrade, " ON (PrePrintObjDetailsNAT8.examYear = obj_", this.currentGrade,
                    ".examYear) AND (PrePrintObjDetailsNAT8.centNo = obj_", this.currentGrade,
                    ".centNo) AND (PrePrintObjDetailsNAT8.indexNo = obj_", this.currentGrade,
                    ".indexNo) AND (PrePrintObjDetailsNAT8.CsdSubjCode = obj_", this.currentGrade, ".CsdSubjCode) WHERE ((obj_",
                    this.currentGrade, ".CsdSubjCode IS NULL)  AND (PrePrintObjDetailsNAT8.centNo = '", centNo, "'));"
                 });
                    break;
                default:
                    str = "SELECT PrePrintObjDetails" + this.currentExam + ".examYear, PrePrintObjDetails" + this.currentExam +
                        ".centNo, PrePrintObjDetails" + this.currentExam + ".indexNo, PrePrintObjDetails" + this.currentExam +
                        ".CsdSubjCode FROM PrePrintObjDetails" + this.currentExam + " LEFT JOIN obj_" + this.currentGrade +
                        " ON (PrePrintObjDetails" + this.currentExam + ".examYear = obj_" + this.currentGrade +
                        ".examYear) AND (PrePrintObjDetails" + this.currentExam + ".centNo = obj_" + this.currentGrade +
                        ".centNo) AND (PrePrintObjDetails" + this.currentExam + ".indexNo = obj_" + this.currentGrade +
                        ".indexNo) AND (PrePrintObjDetails" + this.currentExam + ".CsdSubjCode = obj_" + this.currentGrade +
                        ".CsdSubjCode) WHERE ((obj_" + this.currentGrade + ".CsdSubjCode IS NULL)  AND (PrePrintObjDetails" +
                        this.currentExam + ".centNo = '" + centNo + "'));";
                    //str = "SELECT PrePrintObjDetails" + this.currentExam + ".examYear, PrePrintObjDetails" + this.currentExam +
                    //    ".centNo, PrePrintObjDetails" + this.currentExam + ".indexNo, PrePrintObjDetails" + this.currentExam +
                    //    ".CsdSubjCode FROM PrePrintObjDetails" + this.currentExam + " LEFT JOIN obj_" + this.currentGrade + "_" + this.currentYear +
                    //    " ON (PrePrintObjDetails" + this.currentExam + ".examYear = obj_" + this.currentGrade + "_" + this.currentYear +
                    //    ".examYear) AND (PrePrintObjDetails" + this.currentExam + ".centNo = obj_" + this.currentGrade + "_" + this.currentYear +
                    //    ".centNo) AND (PrePrintObjDetails" + this.currentExam + ".indexNo = obj_" + this.currentGrade + "_" + this.currentYear +
                    //    ".indexNo) AND (PrePrintObjDetails" + this.currentExam + ".CsdSubjCode = obj_" + this.currentGrade + "_" + this.currentYear +
                    //    ".CsdSubjCode) WHERE ((obj_" + this.currentGrade + "_" + this.currentYear + ".CsdSubjCode IS NULL)  AND (PrePrintObjDetails" +
                    //    this.currentExam + ".centNo = '" + centNo + "'));";

                    break;
            }

            if (this.UpdateDs(tableName, str))
            {
                return true;
            }
            return false;
        }

        private bool getAllMissingCandidate(string tableName)
        {
            string str;
            string currentGrade = this.currentGrade;

            switch (currentGrade)
            {
                case "3":
                case "5":
                    str = string.Concat(new object[] {
                        "SELECT PrePrintObjDetailsNAT", this.currentGrade, ".examYear, PrePrintObjDetailsNAT", this.currentGrade, ".centNo, PrePrintObjDetailsNAT",
                        this.currentGrade, ".indexNo, PrePrintObjDetailsNAT", this.currentGrade, ".CsdSubjCode FROM PrePrintObjDetailsNAT", this.currentGrade,
                        " LEFT JOIN obj_", this.currentGrade, "_", this.currentYear, " ON (PrePrintObjDetailsNAT", this.currentGrade,
                        ".examYear = obj_", this.currentGrade, "_", this.currentYear, ".examYear) AND (PrePrintObjDetailsNAT", this.currentGrade, ".centNo = obj_",
                        this.currentGrade, "_", this.currentYear, ".centNo) AND (PrePrintObjDetailsNAT", this.currentGrade, ".indexNo = obj_", this.currentGrade,
                        "_", this.currentYear, ".indexNo) AND (PrePrintObjDetailsNAT", this.currentGrade, ".CsdSubjCode = obj_", this.currentGrade,
                        "_", this.currentYear, ".CsdSubjCode) WHERE ((obj_", this.currentGrade,
                        "_", this.currentYear, ".CsdSubjCode IS NULL));"});
                    break;
                case "6":
                    str = string.Concat(new object[] {
                    "SELECT PrePrintObjDetailsNAT8.examYear, PrePrintObjDetailsNAT8.centNo, PrePrintObjDetailsNAT8.indexNo, PrePrintObjDetailsNAT8.CsdSubjCode FROM PrePrintObjDetailsNAT8 LEFT JOIN obj_",
                    this.currentGrade, "_", this.currentYear, " ON (PrePrintObjDetailsNAT8.examYear = obj_", this.currentGrade, "_", this.currentYear,
                    ".examYear) AND (PrePrintObjDetailsNAT8.centNo = obj_", this.currentGrade, "_", this.currentYear,
                    ".centNo) AND (PrePrintObjDetailsNAT8.indexNo = obj_", this.currentGrade, "_", this.currentYear,
                    ".indexNo) AND (PrePrintObjDetailsNAT8.CsdSubjCode = obj_", this.currentGrade, "_", this.currentYear, ".CsdSubjCode) WHERE ((obj_",
                    this.currentGrade, "_", this.currentYear, ".CsdSubjCode IS NULL));"
                 });
                    break;
                default:
                    str = "SELECT PrePrintObjDetails" + this.currentExam + ".examYear, PrePrintObjDetails" + this.currentExam +
                        ".centNo, PrePrintObjDetails" + this.currentExam + ".indexNo, PrePrintObjDetails" + this.currentExam +
                        ".CsdSubjCode FROM PrePrintObjDetails" + this.currentExam + " LEFT JOIN obj_" + this.currentGrade +
                        " ON (PrePrintObjDetails" + this.currentExam + ".examYear = obj_" + this.currentGrade +
                        ".examYear) AND (PrePrintObjDetails" + this.currentExam + ".centNo = obj_" + this.currentGrade +
                        ".centNo) AND (PrePrintObjDetails" + this.currentExam + ".indexNo = obj_" + this.currentGrade +
                        ".indexNo) AND (PrePrintObjDetails" + this.currentExam + ".CsdSubjCode = obj_" + this.currentGrade +
                        ".CsdSubjCode) WHERE ((obj_" + this.currentGrade + ".CsdSubjCode IS NULL));";
                    //str = "SELECT PrePrintObjDetails" + this.currentExam + ".examYear, PrePrintObjDetails" + this.currentExam +
                    //    ".centNo, PrePrintObjDetails" + this.currentExam + ".indexNo  FROM PrePrintObjDetails" + this.currentExam + 
                    //    " LEFT JOIN obj_" + this.currentGrade +
                    //    " ON (PrePrintObjDetails" + this.currentExam + ".examYear = obj_" + this.currentGrade +
                    //    ".examYear) AND (PrePrintObjDetails" + this.currentExam + ".centNo = obj_" + this.currentGrade +
                    //    ".centNo) AND (PrePrintObjDetails" + this.currentExam + ".indexNo = obj_" + this.currentGrade +
                    //    ".indexNo) AND (PrePrintObjDetails" + this.currentExam + ".CsdSubjCode = obj_" + this.currentGrade +
                    //    ".CsdSubjCode) WHERE ((obj_" + this.currentGrade + ".CsdSubjCode IS NULL));";
                    break;
            }
            if (this.UpdateDs(tableName, str))
            {
                return true;
            }
            return false;
        }

        private void cbExams_MouseHover(object sender, EventArgs e)
        {
            cbExams.DroppedDown = true;
        }

        private void rtbRejectDisplay_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //scRtfDisplay.Panel2Collapsed = true;
            //scRtfDisplay.Panel1Collapsed = false;
        }

        private void rtbDisplay_DoubleClick(object sender, EventArgs e)
        {
            //scRtfDisplay.Panel1Collapsed = true;
            //scRtfDisplay.Panel2Collapsed = false;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {

            if (ReloadScoringKeys())
            {
            }
        }

        private bool ReloadScoringKeys()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading scoring keys: " + ex.Message);
            }

            return false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //Orig
            //if (UpdateScoringKeysTable())
            //{
            //    if (LoadScoreExamYear())
            //    {
            //        cbScoreExamYear.SelectedIndex = cbScoreExamYear.Items.Count - 1;
            //        cbKeysExamYear.SelectedIndex = cbScoreExamYear.Items.Count - 1;

            //        if (LoadScoreExamTypes())
            //        {
            //            if (cbScoreExamType.Items.Count == 1)
            //            {
            //                cbScoreExamType.SelectedIndex = 0;
            //                cbKeysExamType.SelectedIndex = 0;
            //                btnLoadKeys.PerformClick();
            //            }
            //            else
            //                cbScoreExamType.DroppedDown = true;

            //            rtbScoreDisplay.AppendText("\n\nRefresh successful.");
            //        }
            //        else
            //        {
            //            rtbScoreDisplay.AppendText("\n\n*** Error loading Exam Types. Please check table?");
            //        }
            //    }
            //    else
            //    {
            //        rtbScoreDisplay.AppendText("\n\n*** Error loading Exam Years. Please check table?");
            //    }
            //}
            //else
            //{
            //    rtbScoreDisplay.AppendText("\n\n*** Error loading Scoring Keys Table. Does it exist?");
            //}
            if (UpdateScoringKeysTable())
            {
                if (LoadScoreExamYear())
                {
                    //cbKeysExamYear.SelectedIndex = this.cbScoreExamYear.Items.Count - 1;
                    if (LoadScoreExamTypes())
                    {
                        if (cbScoreExamType.Items.Count == 1)
                        {
                            cbKeysExamType.SelectedIndex = 0;
                        }

                        cbScoreExamType.DroppedDown = true;

                        rtbScoreDisplay.AppendText("\n\nRefresh successful.");
                    }
                    else
                    {
                        this.rtbScoreDisplay.AppendText("\n\n*** Error loading Exam Types. Please check table?");
                    }
                }
                else
                {
                    this.rtbScoreDisplay.AppendText("\n\n*** Error loading Exam Years. Please check table?");
                }
            }
            else
            {
                this.rtbScoreDisplay.AppendText("\n\n*** Error loading Scoring Keys Table. Does it exist?");
            }

        }

        private bool UpdateScoringKeysTable()
        {
            try
            {

                string sql = "SELECT * FROM ScoringKeys ORDER By examYear Desc;";
                string tableName = "ScoringKeys";

                rtbScoreDisplay.AppendText("\nUpdating Keys data ... ");

                if (UpdateDs(tableName, sql))
                {
                    // table successfully updated
                    rtbScoreDisplay.AppendText("success");
                    return true;
                }
                else
                    rtbScoreDisplay.AppendText("failed");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Loading Score Exam Year: " + ex.Message);
            }
            return false;
        }

        private bool LoadScoreExamYear()
        {
            try
            {
                DataTable dt = ds.Tables["ScoringKeys"];
                cbScoreExamYear.Items.Clear();
                cbKeysExamYear.Items.Clear();
                List<string> examYears = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    if (!examYears.Contains(dr["examYear"].ToString()))
                    {
                        examYears.Add(dr["examYear"].ToString());
                        cbScoreExamYear.Items.Add(dr["examYear"].ToString());
                        cbKeysExamYear.Items.Add(dr["examYear"].ToString());
                    }
                }

                try
                {
                    cbScoreExamYear.SelectedIndex = 0;
                    cbKeysExamYear.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error selecting exam year: " + ex.Message);
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Loading Score Exam Year: " + ex.Message);
            }

            return false;
        }

        private bool LoadScoreExamTypes()
        {
            try
            {
                DataTable dt = ds.Tables["ScoringKeys"];
                cbScoreExamType.Items.Clear();
                cbKeysExamType.Items.Clear();
                List<string> examType = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    if (!examType.Contains(dr["examInitial"].ToString()))
                    {
                        examType.Add(dr["examInitial"].ToString());
                        cbScoreExamType.Items.Add(dr["examInitial"].ToString());
                        cbKeysExamType.Items.Add(dr["examInitial"].ToString());
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Loading Score Exam Type: " + ex.Message);
            }

            return false;
        }

        private bool LoadScoringKeys()
        {
            try
            {
                DataTable dt = ds.Tables["ScoringKeys"];

                lvScoringKeys.Items.Clear();

                List<string> examType = new List<string>();

                foreach (DataRow dr in dt.Rows)
                {
                    if (!examType.Contains(dr["examInitial"].ToString()))
                    {
                        examType.Add(dr["examInitial"].ToString());
                        cbScoreExamType.Items.Add(dr["examInitial"].ToString());
                        //lbAvailableKeys.Items.Add(dr["examInitial"].ToString());
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Loading Score Exam Type: " + ex.Message);
            }

            return false;
        }

        private void btnLoadKeys_Click(object sender, EventArgs e)
        {
            rtbScoreDisplay.AppendText("\n\nFetching scoring keys ... ");

            if (ShowScoringKeys())
            {
                rtbScoreDisplay.AppendText("success");
            }
            else
                rtbScoreDisplay.AppendText("failed");
        }

        private bool ShowScoringKeys()
        {
            //Orig
            //DataTable dt = ds.Tables["ScoringKeys"];
            //lvScoringKeys.Items.Clear();
            //lbAvailableKeys.Items.Clear();
            //int count = 0;

            //try
            //{
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        if ((dr["examYear"].ToString() == cbScoreExamYear.SelectedItem.ToString()) &&
            //            (dr["examInitial"].ToString() == cbScoreExamType.SelectedItem.ToString().Substring(0, 1)))
            //        {
            //            string[] subItems = { dr["CsdSubjCode"].ToString(), dr["examYear"].ToString(), dr["NoOfItems"].ToString(), 
            //                                dr["ScoreData"].ToString()};
            //            lvScoringKeys.Items.Add(new ListViewItem(subItems));
            //            lbAvailableKeys.Items.Add(dr["CsdSubjCode"].ToString());
            //            count++;
            //        }
            //    }

            //    rtbScoreDisplay.AppendText("" + count + " keys found ... ");
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error in getting Scoring Keys: " + ex.Message);
            //}
            //return false;
            DataTable table = this.ds.Tables["ScoringKeys"];
            lvScoringKeys.Items.Clear();
            lbAvailableKeys.Items.Clear();
            int num = 0;
            try
            {
                foreach (DataRow row in table.Rows)
                {
                    string[] strArray;
                    try
                    {
                        if (
                            //(row["examYear"].ToString().Equals(this.cbScoreExamYear.SelectedItem.ToString())) &&
                            //(row["examInitial"].ToString().Equals(this.cbScoreExamType.SelectedItem.ToString().Substring(0, 1))))
                            (row["examYear"].ToString().Equals(this.cbScoreExamYear.SelectedItem)) &&
                            (row["examInitial"].ToString().Equals(this.cbScoreExamType.SelectedItem.ToString())))
                        {
                            strArray = new string[] { row["CsdSubjCode"].ToString(), row["examYear"].ToString(), row["NoOfItems"].ToString(), row["ScoreData"].ToString() };
                            this.lvScoringKeys.Items.Add(new ListViewItem(strArray));
                            this.lbAvailableKeys.Items.Add(row["CsdSubjCode"].ToString());
                            num++;
                        }
                    }
                    catch (Exception)
                    {
                        try
                        {
                            if (
                                (row["examYear"].ToString() == this.cbKeysExamYear.SelectedItem.ToString()) &&
                                (row["examInitial"].ToString() == this.cbKeysExamType.SelectedItem.ToString().Substring(0, 1)))
                            {
                                strArray = new string[] { row["CsdSubjCode"].ToString(), row["examYear"].ToString(), row["NoOfItems"].ToString(), row["ScoreData"].ToString() };
                                this.lvScoringKeys.Items.Add(new ListViewItem(strArray));
                                this.lbAvailableKeys.Items.Add(row["CsdSubjCode"].ToString());
                                num++;
                            }
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
                this.rtbScoreDisplay.AppendText(num + " keys found ... ");
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error in getting Scoring Keys: " + exception.Message);
            }
            return false;

        }

        private void cbScoreExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoadKeys.Visible = true;
            btnLoadKeys.PerformClick();
        }

        private void btnScoreSelected_Click(object sender, EventArgs e)
        {
            subjectsToScore = new List<string>();
            rtbScoreDisplay.AppendText("\n\nGetting selected subjects ... ");

            foreach (int i in lvScoringKeys.SelectedIndices)
            {
                subjectsToScore.Add(lvScoringKeys.Items[i].SubItems[0].Text);
                rtbScoreDisplay.AppendText("\n   : " + subjectsToScore[subjectsToScore.Count - 1]);
            }

            rtbScoreDisplay.ScrollToCaret();

            if (subjectsToScore.Count > 0)
            {
                // start and wait for thread to end.
                //tScoring = new Thread(new ThreadStart(ScoreSubject));
                //tScoring.Name = "threadScoring";
                ////tScoring.Priority = ThreadPriority.AboveNormal;
                //tScoring.Start();
                //tScoring.Join();

                if (MessageBox.Show("About to score " + subjectsToScore.Count + " subjects" + ((subjectsToScore.Count > 1) ? "s" : "") + ". Do you want to proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ScoreSubject(subjectsToScore, false);
                }
                else
                {
                    rtbScoreDisplay.AppendText("\n\nCANCELLED");
                }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            subjectsToScore = new List<string>();
            rtbScoreDisplay.AppendText("\n\nGetting selected subjects ... ");

            for (int i = 0; i < lvScoringKeys.Items.Count; i++)
            {
                subjectsToScore.Add(lvScoringKeys.Items[i].SubItems[0].Text);
                rtbScoreDisplay.AppendText("\n   : " + subjectsToScore[subjectsToScore.Count - 1]);
            }
            rtbScoreDisplay.ScrollToCaret();

            if (subjectsToScore.Count > 0)
            {
                // start and wait for thread to end.
                //tScoring = new Thread(new ThreadStart(ScoreSubject));
                //tScoring.Name = "threadScoring";
                ////tScoring.Priority = ThreadPriority.AboveNormal;
                //tScoring.Start();
                //tScoring.Join();

                if (MessageBox.Show("About to score " + subjectsToScore.Count + " subjects" + ((subjectsToScore.Count > 1) ? "s" : "") + ". Do you want to proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ScoreSubject(subjectsToScore, false);
                }
                else
                {
                    rtbScoreDisplay.AppendText("\n\nCANCELLED");
                }
                //ScoreSubject(subjectsToScore);
            }
        }

        //private bool ScoreSubject(List<string> subjects)
        //{
        //    rtbScoreDisplay.AppendText("\n\nSCORING subjects");
        //    int count = 0;
        //    try
        //    {
        //        db.con.Open();

        //        foreach (string subjects in subjects)
        //        {
        //            count++;

        //            // for each subjects
        //            string csdSubjCode = subjects;
        //            string examYear = cbScoreExamYear.SelectedItem.ToString();
        //            string examInitial = cbScoreExamType.SelectedItem.ToString().Substring(0, 1);
        //            string sourceTable = "obj_" + examInitial + "_" + examYear;
        //            int noOfItems = GetNoOfScoringItems(subjects, examInitial, examYear);
        //            string key = GetScoringKey(subjects, examInitial, examYear);

        //            List<List<char>> candidates = new List<List<char>>();

        //            rtbScoreDisplay.AppendText("\n    Subject: " + subjects);
        //            rtbScoreDisplay.AppendText("\n  Exam Year: " + examYear);
        //            rtbScoreDisplay.AppendText("\nNo of Items: " + noOfItems);
        //            rtbScoreDisplay.AppendText("\n        Key: " + key.ToString());

        //            // fetch candidates and save them in table
        //            rtbScoreDisplay.AppendText("\n\nFetching candidates ... ");
        //            rtbScoreDisplay.ScrollToCaret();

        //            string sql = "SELECT * FROM " + sourceTable + " WHERE ((examYear = '" + examYear +
        //                "') AND (CsdSubjCode = '" + subjects + "') AND (LEFT(centNo, 1) = '" + examInitial + "'));";

        //            if (UpdateDs(sourceTable, sql))
        //            {
        //                DataTable dt = ds.Tables[sourceTable];

        //                // data received
        //                rtbScoreDisplay.AppendText("" + dt.Rows.Count + " returned.");
        //                rtbScoreDisplay.ScrollToCaret();

        //                foreach (DataRow dr in dt.Rows)
        //                {
        //                    string data = dr["Data"].ToString();
        //                    string absent = dr["Absent"].ToString();
        //                    int score = -99;                            

        //                    rtbScoreDisplay.AppendText("\nScoring " + dr["centNo"] + dr["indexNo"] + " " + subjects + ":");
        //                    //score
        //                    if ((absent == "") && (data == ""))
        //                    {
        //                        rtbScoreDisplay.AppendText(" *** skipping ***");
        //                        continue;
        //                    }
        //                    else if ((absent.ToLower() == "a") && (data == ""))
        //                    {
        //                        score = -1;
        //                    }
        //                    else if ((absent != "") && (data != ""))
        //                    {
        //                        rtbScoreDisplay.AppendText(" *** WARNING: Absent with data ***");
        //                        //continue;
        //                    }
        //                    else
        //                    {
        //                        score = ScoreCandidatePlease(noOfItems, key, data);
        //                    }

        //                    rtbScoreDisplay.AppendText("\n = " + score);

        //                    // save to db please
        //                    try
        //                    {
        //                        //db.con.Open();

        //                        db.cmd.CommandText = "INSERT INTO " + sourceTable + "S (examYear, centNo, indexNo, CsdSubjCode, Score, pcName, userName) VALUES ('" +
        //                            dr["examYear"].ToString() + "', '" + dr["centNo"].ToString() + "', '" +
        //                            dr["indexNo"].ToString() + "', '" + dr["CsdSubjCode"].ToString() + "', " + score +
        //                            ", '" + pcName + "', '" + userName + "');";

        //                        if (db.cmd.ExecuteNonQuery() > 0)
        //                        {
        //                            rtbScoreDisplay.AppendText(" success");
        //                            // update scored flag

        //                        }
        //                        else
        //                        {
        //                            rtbScoreDisplay.AppendText(" failed");
        //                        }
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        Console.WriteLine("Error saving to db: " + ex.Message);
        //                        rtbScoreDisplay.AppendText(" failed! Record already exist.");
        //                    }
        //                    finally
        //                    {
        //                        //db.con.Close();
        //                    }
        //                    rtbScoreDisplay.ScrollToCaret();
        //                }
        //            }

        //        }

        //        rtbScoreDisplay.AppendText("\n\nCompleted: " + DateTime.Now.ToString());
        //        rtbScoreDisplay.ScrollToCaret();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error Scoring subjects: " + ex.Message);
        //    }
        //    finally
        //    {
        //        db.con.Close();
        //    }
        //    return false;
        //}

        private bool ScoreSubject(List<string> subjects, bool scoreMissing)
        {
            this.rtbScoreDisplay.AppendText("\n\nSCORING subjects");
            int count = 0;
            //ulong num2 = 0;
            //ulong num3 = 0;
            try
            {
                this.db.con.Open();
                foreach (string subject in subjects)
                {
                    string str7;
                    count++;
                    string str2 = subject;
                    string examYear = this.cbScoreExamYear.SelectedItem.ToString();
                    //string examInitial = this.cbScoreExamType.SelectedItem.ToString().Substring(0, 2);
                    string examInitial = this.cbScoreExamType.SelectedItem.ToString();
                    //if (!examInitial.Equals("99"))
                    //{
                    //    examInitial = examInitial.ToString().Substring(0, 1);
                    //}
                    //string tableName = "obj_" + examInitial + "_" + examYear;
                    string tableName = "obj_" + examInitial;// +"_" + examYear;
                    int noOfItems = this.GetNoOfScoringItems(subject, examInitial, examYear);
                    string key = this.GetScoringKey(subject, examInitial, examYear);
                    List<List<char>> list = new List<List<char>>();
                    this.rtbScoreDisplay.Text = "\n    Subject: " + subject;
                    this.rtbScoreDisplay.AppendText("\n  Exam Year: " + examYear);
                    this.rtbScoreDisplay.AppendText("\nNo of Items: " + noOfItems);
                    this.rtbScoreDisplay.AppendText("\n        Key: " + key.ToString());
                    this.rtbScoreDisplay.AppendText("\n\nFetching candidates ... ");
                    this.rtbScoreDisplay.ScrollToCaret();
                    if (scoreMissing)
                    {
                        if (examInitial.Equals("99"))
                            str7 = "SELECT * FROM " + tableName + " WHERE ((examYear = '" + examYear + "') AND (CsdSubjCode = '" + subject + "') AND (LEFT(centNo, 2) = '" + examInitial + "') AND (SCORED = 0));";
                        else
                            str7 = "SELECT * FROM " + tableName + " WHERE ((examYear = '" + examYear + "') AND (CsdSubjCode = '" + subject + "') AND (LEFT(centNo, 1) = '" + examInitial + "') AND (SCORED = 0));";

                    }
                    else
                    {
                        if (examInitial.Equals("99"))
                            str7 = "SELECT * FROM " + tableName + " WHERE ((examYear = '" + examYear + "') AND (CsdSubjCode = '" + subject + "') AND (LEFT(centNo, 2) = '" + examInitial + "'));";
                        else
                            str7 = "SELECT * FROM " + tableName + " WHERE ((examYear = '" + examYear + "') AND (CsdSubjCode = '" + subject + "') AND (LEFT(centNo, 1) = '" + examInitial + "'));";
                    }
                    if (this.UpdateDs(tableName, str7))
                    {
                        DataTable table = this.ds.Tables[tableName];
                        this.rtbScoreDisplay.AppendText(table.Rows.Count + " returned.");
                        this.rtbScoreDisplay.ScrollToCaret();
                        foreach (DataRow row in table.Rows)
                        {
                            string data = row["Data"].ToString();

                            // check for data with dots instead of spaces
                            try
                            {
                                data = data.Replace('.', ' ').Substring(0, 120).TrimEnd(' ');
                                data = data.TrimEnd(' ');
                            }
                            catch (Exception ex) { }

                            string absent = row["Absent"].ToString();
                            int score = -99;
                            string scoreData = "";
                            this.rtbScoreDisplay.AppendText(string.Concat(new object[] { "\nScoring ", row["centNo"], row["indexNo"], " ", subject, ":" }));
                            if ((absent == "") && (data == ""))
                            {
                                if (cbScoreblankAbsentData.Checked)
                                {
                                    rtbScoreDisplay.AppendText("\n   *** WARNING!!! Missing Absent and DATA. Probably Zero ***");
                                    score = this.ScoreCandidatePlease(noOfItems, key, data);
                                }
                                else
                                {
                                    rtbScoreDisplay.AppendText(" *** skipping ***");
                                    continue;
                                }

                            }
                            else if ((absent.ToLower().Equals("a")) && (data.Equals("")))
                            {
                                score = -1;
                                //num2++;
                            }
                            else if ((!absent.Equals("")) && (!data.Equals("")))
                            {
                                this.rtbScoreDisplay.AppendText(" *** WARNING: Absent with data ***");
                                //num3++;
                                continue;
                            }
                            else
                            {
                                score = this.ScoreCandidatePlease(noOfItems, key, data, ref scoreData);
                                //num2++;
                            }

                            this.rtbScoreDisplay.AppendText("\n = " + score);

                            List<string> sqls = new List<string> {
                                string.Concat(new object[] {
                                    "INSERT INTO ", tableName, "S (examYear, centNo, indexNo, CsdSubjCode, Score, pcName, userName, scoreData) VALUES ('",
                                    row["examYear"].ToString(), "', '", row["centNo"].ToString(), "', '",
                                    row["indexNo"].ToString(), "', '", row["CsdSubjCode"].ToString(), "', ", score, ", '", this.pcName, "', '", this.userName,
                                    "', '" + scoreData + "');"
                                 }),
                                "UPDATE " + tableName + " SET Scored = 1, Score =" + score + " WHERE ((examYear ='" + row["examYear"].ToString() + "') AND (centNo = '" + row["centNo"].ToString() + "') AND (indexNo = '" + row["indexNo"].ToString() + "') AND (CsdSubjCode = '" + row["CsdSubjCode"].ToString() + "'));"
                            };
                            for (int i = 0; i < sqls.Count; i++)
                            {
                                try
                                {
                                    try
                                    {
                                        this.db.cmd.CommandText = sqls[i];
                                        if (this.db.cmd.ExecuteNonQuery() > 0)
                                        {
                                            this.rtbScoreDisplay.AppendText(" success");
                                        }
                                        else
                                        {
                                            this.rtbScoreDisplay.AppendText(" failed");
                                            break;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        Console.WriteLine("Error saving to db: " + ex.Message);
                                        this.rtbScoreDisplay.AppendText(" failed! Record already exist.");
                                    }
                                }
                                finally
                                {
                                }

                                if (rtbScoreDisplay.TextLength > 500000)
                                {
                                    rtbScoreDisplay.Clear();
                                }
                            }
                            this.rtbScoreDisplay.ScrollToCaret();
                        }
                    }
                }
                this.rtbScoreDisplay.AppendText("\n\nCompleted: " + DateTime.Now.ToString());
                this.rtbScoreDisplay.AppendText("\n   Success: " + count);
                //this.rtbScoreDisplay.AppendText("\n   Success: " + num3);
                this.rtbScoreDisplay.ScrollToCaret();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Scoring subjects: " + ex.Message);
            }
            finally
            {
                this.db.con.Close();
            }
            return false;
        }

        //private void ScoreSubject()
        //{
        //    rtbScoreDisplay.AppendText("\n\nSCORING subjects");
        //    int count = 0;

        //    if (subjectsToScore.Count < 1)
        //        return;

        //    try
        //    {
        //        db.con.Open();

        //        foreach (string subjects in subjectsToScore)
        //        {
        //            count++;

        //            // for each subjects
        //            string csdSubjCode = subjects;
        //            string examYear = cbScoreExamYear.SelectedItem.ToString();
        //            string examInitial = cbScoreExamType.SelectedItem.ToString().Substring(0, 1);
        //            string sourceTable = "obj_" + examInitial + "_" + examYear;
        //            int noOfItems = GetNoOfScoringItems(subjects, examInitial, examYear);
        //            string key = GetScoringKey(subjects, examInitial, examYear);

        //            List<List<char>> candidates = new List<List<char>>();

        //            rtbScoreDisplay.AppendText("\n    Subject: " + subjects);
        //            rtbScoreDisplay.AppendText("\n  Exam Year: " + examYear);
        //            rtbScoreDisplay.AppendText("\nNo of Items: " + noOfItems);
        //            rtbScoreDisplay.AppendText("\n        Key: " + key.ToString());

        //            // fetch candidates and save them in table
        //            rtbScoreDisplay.AppendText("\n\nFetching candidates ... ");
        //            string sql = "SELECT * FROM " + sourceTable + " WHERE ((examYear = '" + examYear +
        //                "') AND (CsdSubjCode = '" + subjects + "') AND (LEFT(centNo, 1) = '" + examInitial + "'));";

        //            if (UpdateDs(sourceTable, sql))
        //            {
        //                DataTable dt = ds.Tables[sourceTable];

        //                // data received
        //                rtbScoreDisplay.AppendText("" + dt.Rows.Count + " returned.");
        //                rtbScoreDisplay.ScrollToCaret();

        //                foreach (DataRow dr in dt.Rows)
        //                {
        //                    string data = dr["Data"].ToString();
        //                    int score = -99;

        //                    if (dr["Absent"].ToString() == "A")
        //                    {
        //                        MessageBox.Show("Found Absent");
        //                    }

        //                    rtbScoreDisplay.AppendText("\nScoring " + dr["centNo"] + dr["indexNo"] + ":");
        //                    //score
        //                    if ((dr["Absent"].ToString() == null) && (dr["Data"].ToString() == null))
        //                    {
        //                        rtbScoreDisplay.AppendText(" *** skipping ***");
        //                    }
        //                    else if ((dr["Absent"].ToString() == "A") && (dr["Data"].ToString() == null))
        //                    {
        //                        score = -1;
        //                    }
        //                    //else if ((dr["Absent"].ToString() != null) && (dr["Data"].ToString() != null))
        //                    //{
        //                    //    rtbScoreDisplay.AppendText(" *** skipping ***");
        //                    //}
        //                    else
        //                    {
        //                        score = ScoreCandidatePlease(noOfItems, key, data);
        //                    }

        //                    rtbScoreDisplay.AppendText("\n = " + score);

        //                    // save to db please
        //                    try
        //                    {
        //                        //db.con.Open();

        //                        db.cmd.CommandText = "INSERT INTO " + sourceTable + "S (examYear, centNo, indexNo, CsdSubjCode, Score, pcName, userName) VALUES ('" +
        //                            dr["examYear"].ToString() + "', '" + dr["centNo"].ToString() + "', '" +
        //                            dr["indexNo"].ToString() + "', '" + dr["CsdSubjCode"].ToString() + "', " + score +
        //                            ", '" + pcName + "', '" + userName + "');";

        //                        if (db.cmd.ExecuteNonQuery() > 0)
        //                        {
        //                            rtbScoreDisplay.AppendText(" success");
        //                        }
        //                        else
        //                        {
        //                            rtbScoreDisplay.AppendText(" failed");
        //                        }
        //                    }
        //                    catch (Exception ex)
        //                    {
        //                        Console.WriteLine("Error saving to db: " + ex.Message);
        //                        rtbScoreDisplay.AppendText(" failed! Record already exist.");
        //                    }
        //                    finally
        //                    {
        //                        //db.con.Close();
        //                    }
        //                    rtbScoreDisplay.ScrollToCaret();
        //                }
        //            }

        //        }
        //        return;
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error Scoring subjects: " + ex.Message);
        //    }
        //    finally
        //    {
        //        db.con.Close();
        //    }
        //    return;
        //}

        private int ScoreCandidatePlease(int noOfItems, string key, string data)
        {
            List<bool> correct = new List<bool>();

            try
            {
                if (data.Length < noOfItems)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (key[i] == data[i])
                        {
                            correct.Add(true);
                            rtbScoreDisplay.AppendText("1");
                        }
                        else
                        {
                            rtbScoreDisplay.AppendText("0");
                        }
                    }
                }
                else if (data.Length >= noOfItems)
                {
                    for (int i = 0; i < noOfItems; i++)
                    {
                        if (key[i] == data[i])
                        {
                            correct.Add(true);
                            rtbScoreDisplay.AppendText("1");
                        }
                        else
                        {
                            rtbScoreDisplay.AppendText("0");
                        }
                    }
                }
                else
                {
                    return -99;
                }
                return correct.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error scoring candidate: " + ex.Message);
            }

            return -99;
        }

        private int ScoreCandidatePlease(int noOfItems, string key, string data, ref string scoreData)
        {
            List<bool> correct = new List<bool>();
            scoreData = "";

            //bonus key = '<'
            char bonusKey = '<';
            int addbonus = 0;

            try
            {
                if (data.Length < noOfItems)
                {
                    for (int i = 0; i < data.Length; i++)
                    {
                        if (key[i].Equals(bonusKey))
                        {
                            // increment bonus and surprise candidates please
                            // there should be restrictions on the bonus char
                            addbonus++;
                            rtbScoreDisplay.AppendText("+");
                            scoreData += "+";
                            continue;
                        }

                        if (key[i].Equals(data[i]))
                        {
                            correct.Add(true);
                            rtbScoreDisplay.AppendText("1");
                            scoreData += "1";
                        }
                        else
                        {
                            rtbScoreDisplay.AppendText("0");
                            scoreData += "0";
                        }
                    }
                }
                else if (data.Length >= noOfItems)
                {
                    for (int i = 0; i < noOfItems; i++)
                    {
                        if (key[i].Equals(bonusKey))
                        {
                            // increment bonus and surprise candidates please
                            // there should be restrictions on the bonus char
                            if (cbProcessBonusMark.Checked)
                            {
                                addbonus++;
                                rtbScoreDisplay.AppendText("+");
                                scoreData += "+";
                            }
                            else
                            {
                                rtbScoreDisplay.AppendText("X");
                                scoreData += "X";
                            }
                            continue;
                        }

                        if (key[i].Equals(' '))
                        {
                            // skip question, no answer
                            rtbScoreDisplay.AppendText(" ");
                            scoreData += " ";
                            continue;
                        }

                        if ((key[i].Equals(data[i])) && (!key[i].Equals(' ')))
                        {
                            correct.Add(true);
                            scoreData += "1";
                            rtbScoreDisplay.AppendText("1");
                        }
                        else
                        {
                            rtbScoreDisplay.AppendText("0");
                            scoreData += "0";
                        }
                    }
                }
                else
                {
                    return -99;
                }
                return correct.Count + addbonus;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error scoring candidate: " + ex.Message);
            }

            return -99;
        }

        private int GetNoOfScoringItems(string subject, string examInitial, string examYear)
        {
            try
            {
                for (int i = 0; i < lvScoringKeys.Items.Count; i++)
                {
                    if ((lvScoringKeys.Items[i].SubItems[0].Text == subject) &&
                        (lvScoringKeys.Items[i].SubItems[1].Text == examYear))
                    {
                        return (int.Parse(lvScoringKeys.Items[i].SubItems[2].Text));
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting no of items: " + ex.Message);
            }
            return 0;
        }

        private string GetScoringKey(string subject, string examInitial, string examYear)
        {
            try
            {
                for (int i = 0; i < lvScoringKeys.Items.Count; i++)
                {
                    if ((lvScoringKeys.Items[i].SubItems[0].Text == subject) &&
                        (lvScoringKeys.Items[i].SubItems[1].Text == examYear))
                    {
                        return (lvScoringKeys.Items[i].SubItems[3].Text);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error getting no of items: " + ex.Message);
            }
            return "";
        }

        private void cbScoreExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnShowScore_Click(object sender, EventArgs e)
        {
            scScoreMain.Panel1Collapsed = !scScoreMain.Panel1Collapsed;

            if (scScoreMain.Panel1Collapsed == true)
                scScore.Panel2Collapsed = false;
            else
                scScore.Panel2Collapsed = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbAvailableKeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnLoadSelectedKey.Enabled = true;
        }

        private void btnLoadSelectedKey_Click(object sender, EventArgs e)
        {
            LoadSelectedKey();
        }

        private void lbAvailableKeys_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            LoadSelectedKey();
        }
        private bool LoadSelectedKey()
        {
            // Orig
            //try
            //{
            //    rtbKeysView.Clear();

            //    int rows = 5;
            //    int cols = GetNoOfScoringItems(lbAvailableKeys.SelectedItem.ToString().Substring(0, 6), 
            //        cbKeysExamType.SelectedItem.ToString(), cbKeysExamYear.SelectedItem.ToString()) / 5;
            //    string scoringKey = GetScoringKey(lbAvailableKeys.SelectedItem.ToString().Substring(0, 6),
            //        cbKeysExamType.SelectedItem.ToString(), cbKeysExamYear.SelectedItem.ToString());

            //    string[,] keyArray = new string[cols, rows];
            //    int[,] keyCount = new int[cols, rows];
            //    int count = 0;

            //    for (int i = 0; i < cols; i++)
            //    {
            //        for (int j = 0; j < rows; j++)
            //        {
            //            keyArray[i, j] = scoringKey[count].ToString();
            //            keyCount[i, j] = 1 + count++;
            //        }
            //    }

            //    count = 0;

            //    for (int j = 0; j <= rows; j++)
            //    {
            //        for (int i = 0; i < cols; i++)
            //        {
            //            try
            //            {
            //                rtbKeysView.AppendText(((keyCount[i, j] == 10) || (keyCount[i, j] == 100) ? "" : " ") +
            //                    keyCount[i, j] + " " + keyArray[i, j] + "     ");
            //            }
            //            catch (Exception)
            //            {
            //                Console.WriteLine("Error getting rows and columns. next = " + count); 
            //            }
            //            count++;
            //        }
            //        rtbKeysView.AppendText("\n");
            //    }

            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error loading selected key: " + ex.Message);
            //}
            //return false;
            try
            {
                int num5;
                this.rtbKeysView.Clear();
                int rows = int.Parse(this.nupRows.Value.ToString());
                int cols = this.GetNoOfScoringItems(this.lbAvailableKeys.SelectedItem.ToString(), this.cbKeysExamType.SelectedItem.ToString(), this.cbKeysExamYear.SelectedItem.ToString()) / rows;
                string scoringKey = this.GetScoringKey(this.lbAvailableKeys.SelectedItem.ToString(), this.cbKeysExamType.SelectedItem.ToString(), this.cbKeysExamYear.SelectedItem.ToString());
                string[,] strArray = new string[cols, rows];
                int[,] numArray = new int[cols, rows];
                int num3 = 0;
                this.rtbKeysView.AppendText(string.Concat(new object[] { "SUBJECT: ", this.lbAvailableKeys.SelectedItem.ToString(), "    Total options = ", this.GetNoOfScoringItems(this.lbAvailableKeys.SelectedItem.ToString(), this.cbKeysExamType.SelectedItem.ToString(), this.cbKeysExamYear.SelectedItem.ToString()), "\n\n" }));
                int num4 = 0;
                while (num4 < cols)
                {
                    num5 = 0;
                    while (num5 < rows)
                    {
                        strArray[num4, num5] = scoringKey[num3].ToString();
                        numArray[num4, num5] = 1 + num3++;
                        num5++;
                    }
                    num4++;
                }
                num3 = 0;
                for (num5 = 0; num5 <= rows; num5++)
                {
                    for (num4 = 0; num4 < cols; num4++)
                    {
                        try
                        {
                            this.rtbKeysView.AppendText(string.Concat(new object[] { ((numArray[num4, num5] == 10) || (numArray[num4, num5] == 100)) ? "" : " ", numArray[num4, num5], " ", strArray[num4, num5], "     " }));
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Error getting rows and columns. next = " + num3);
                        }
                        num3++;
                    }
                    if (num5 != rows)
                    {
                        this.rtbKeysView.AppendText("\n");
                    }
                }
                return true;
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error loading selected key: " + exception.Message);
            }
            return false;

        }

        private void btnKeysZoomPlus_Click(object sender, EventArgs e)
        {
            try
            {
                rtbKeysView.ZoomFactor += 1;
            }
            catch (Exception)
            {
            }
        }

        private void btnKeysZoomMinus_Click(object sender, EventArgs e)
        {
            try
            {
                rtbKeysView.ZoomFactor -= 1;
            }
            catch (Exception)
            {
            }

        }

        private void btnScrollKeysRight_Click(object sender, EventArgs e)
        {
            rtbKeysView.ScrollBars = RichTextBoxScrollBars.Horizontal;
        }

        private void btnScrollKeysLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshCentres_Click(object sender, EventArgs e)
        {
            UseWaitCursor = true;
            ////if(lvSubjDetails.Items.Count > 0)
            try
            {
                this.startLoadingLvWithSubjects();
                LoadUserTotalScanned();
            }
            catch (Exception)
            {
            }

            UseWaitCursor = false;
        }

        private void rtbDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveScanned_Click(object sender, EventArgs e)
        {
            //saves text file locally. Assumes that rtbOutput has some text
            if (rtbOutput.Text == null)
            {
                return;
            }

            string currentDate = DateTime.UtcNow.Year +
                (DateTime.UtcNow.Month < 10 ? ("0" + DateTime.UtcNow.Month) : DateTime.UtcNow.Month.ToString()) +
                (DateTime.UtcNow.Day < 10 ? ("0" + DateTime.UtcNow.Day) : DateTime.UtcNow.Day.ToString());

            System.IO.DirectoryInfo backupDirectory = new System.IO.DirectoryInfo(ICTDUtilities.Properties.Resources.textFileBackupPath + "\\" + currentDate + "\\" + userName);
            System.IO.DirectoryInfo backupDirectoryLocal = new System.IO.DirectoryInfo(ICTDUtilities.Properties.Resources.textFileBackupPathLocal + "\\" + currentDate + "\\" + userName);

            string fileName = this.userName +
                DateTime.UtcNow.Year + (DateTime.UtcNow.Month < 10 ? ("0" + DateTime.UtcNow.Month) : DateTime.UtcNow.Month.ToString()) +
                (DateTime.UtcNow.Day < 10 ? ("0" + DateTime.UtcNow.Day) : DateTime.UtcNow.Day.ToString()) +
                DateTime.UtcNow.Hour + DateTime.UtcNow.Minute + DateTime.UtcNow.Second + ".txt";

            try
            {
                if (!backupDirectory.Exists)
                {
                    backupDirectory.Create();
                    backupDirectory.Attributes = System.IO.FileAttributes.Hidden;
                }

                rtbOutput.SaveFile(backupDirectory + "\\" + fileName, RichTextBoxStreamType.PlainText);
                Console.WriteLine("Save success");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving text file to server: " + ex.Message);
            }
            finally
            {
                //try to save locally

                try
                {
                    if (!backupDirectoryLocal.Exists)
                    {
                        backupDirectory.Create();
                    }
                    rtbOutput.SaveFile(backupDirectoryLocal + "\\" + fileName, RichTextBoxStreamType.PlainText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error saving local text file to server: " + ex.Message);
                }
            }

            btnSaveScanned.Visible = false;
        }

        private void cbKeysExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbKeysExamType.DroppedDown = true;
        }

        private void cbKeysExamType_SelectedIndexChanged(object sender, EventArgs e)
        {
            rtbKeysView.Clear();
            if (ShowScoringKeys())
            {
                rtbScoreDisplay.AppendText("success");
            }
            else
            {
                rtbScoreDisplay.AppendText("failed");
            }
        }

        private void btnScoreMissing_Click(object sender, EventArgs e)
        {
            subjectsToScore = new List<string>();
            rtbScoreDisplay.AppendText("\n\nGetting selected subjects ... ");

            foreach (int i in lvScoringKeys.SelectedIndices)
            {
                subjectsToScore.Add(lvScoringKeys.Items[i].SubItems[0].Text);
                rtbScoreDisplay.AppendText("\n   : " + subjectsToScore[subjectsToScore.Count - 1]);
            }

            rtbScoreDisplay.ScrollToCaret();

            if (subjectsToScore.Count > 0)
            {

                if (MessageBox.Show("About to score " + subjectsToScore.Count + " subjects" + ((subjectsToScore.Count > 1) ? "s" : "") + ". Do you want to proceed?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    ScoreSubject(subjectsToScore, true);
                }
                else
                {
                    rtbScoreDisplay.AppendText("\n\nCANCELLED");
                }

            }
        }

        private void cbScoreblankAbsentData_CheckedChanged(object sender, EventArgs e)
        {
            if (cbScoreblankAbsentData.Checked)
            {
                MessageBox.Show("WARNING!!! This could lead to a score of ZERO if candidate is absent and absent box was not shaded.\nProceed with caution.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnEnterUnscanned_Click(object sender, EventArgs e)
        {
            BtnQrsClear.PerformClick();
            scQryRes.Panel2Collapsed = !scQryRes.Panel2Collapsed;
            txtQrsExamYear.Text = DateTime.Now.Year.ToString();
        }

        private void cbQrsAbsent_CheckedChanged(object sender, EventArgs e)
        {
            scQrsData.Panel2Collapsed = cbQrsAbsent.Checked;
            if (cbQrsAbsent.Checked)
            {
                btnQrsSaveData.Enabled = true;
            }
        }

        private void txtQrsCentreNumber_TextChanged(object sender, EventArgs e)
        {
            txtQrsData.Clear();
            txtQrsDataConfirm.Clear();
            txtQrsIndexNumber.Clear();
            cmbQrsIndexNumber.Items.Clear();
            txtQrsExamYear.Text = DateTime.Now.Year.ToString();

            switch (txtQrsCentreNumber.TextLength)
            {
                case 5:
                    switch (txtQrsCentreNumber.Text.ToString()[0])
                    {
                        case '3':
                        case '4':
                        case '5':
                        case '6':
                        case '7':
                            //txtQrsIndexNumber.Focus();
                            //txtQrsIndexNumber.SelectAll();
                            // load index number from query
                            if (LoadQueryIndexNumber(txtQrsCheckExamYear.Text, txtQrsCentreNumber.Text.ToString(), txtQrsCentreNumber.Text.ToString()[0]))
                            {

                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case 7:
                    switch (txtQrsCentreNumber.Text.ToString()[0])
                    {
                        case '8':
                        case '9':
                            //txtQrsIndexNumber.Focus();
                            //txtQrsIndexNumber.SelectAll();
                            if (LoadQueryIndexNumber(cmbQrsExamYear.Text, txtQrsCentreNumber.Text.ToString(), txtQrsCentreNumber.Text.ToString()[0]))
                            {

                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
        }

        private bool LoadQueryIndexNumber(string examYear, string centNo, char grade)
        {
            string subjectsTable, examType;
            //examYear = txtQrsExamYear.Text;
            examType = "";
            subjectsTable = "";

            switch (centNo[0])
            {
                case '8':
                    examType = "PrePrintObjDetailsWassce";
                    subjectsTable = "obj_8";
                    break;
                case '9':
                    examType = "PrePrintObjDetailsPwassce";
                    subjectsTable = "obj_9";
                    break;
                case '4':
                    examType = "PrePrintObjDetailsPgabece";
                    subjectsTable = "obj_4";
                    break;
                case '7':
                    examType = "PrePrintObjDetailsGabece";
                    subjectsTable = "obj_7";
                    break;
                case '3':
                case '5':
                case '6':
                    examType = "PrePrintObjDetailsNat" + (centNo[0] == '6' ? "8" : centNo[0].ToString());
                    subjectsTable = "obj_" + centNo[0].ToString();
                    break;
                default:
                    break;
            }

            // retrieve candidates index numbers, subjects, filter only not scanned rows

            string sql = "SELECT " + examType + ".ExamYear, " + examType + ".CentNo, " + examType + ".IndexNo " +
                "FROM " + examType + " LEFT JOIN " + subjectsTable + " ON (" + examType + ".CsdSubjCode = " + subjectsTable + ".CsdSubjCode) AND (" + examType + ".IndexNo = " + subjectsTable + ".IndexNo) AND (" + examType + ".CentNo = " + subjectsTable + ".CentNo) AND (" + examType + ".ExamYear = " + subjectsTable + ".ExamYear) " +
                "WHERE (((" + subjectsTable + ".CsdSubjCode) Is Null)) " +
                "GROUP BY " + examType + ".ExamYear, " + examType + ".CentNo, " + examType + ".IndexNo " +
                "HAVING (((" + examType + ".ExamYear) = '" + examYear + "') AND ((" + examType + ".CentNo) = '" + centNo + "'));";

            db.cmd.CommandText = sql;

            try
            {
                db.con.Open();
                db.dr = db.cmd.ExecuteReader();

                // populate  cmbQrsSubjects

                cmbQrsIndexNumber.Items.Add("...");
                while (db.dr.Read())
                {
                    cmbQrsIndexNumber.Items.Add(db.dr["IndexNo"].ToString());
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting candidate subjects. Please check and try again!");
            }
            finally
            {
                if (db.con.State == ConnectionState.Open)
                    db.con.Close();
            }

            // drop down cmbQrsSubjects
            cmbQrsIndexNumber.SelectedItem = "...";
            cmbQrsIndexNumber.Focus();
            //cmbQrsIndexNumber.DroppedDown = true;


            //// load centres with queries
            //List<string> subjects = new List<string>();
            //List<string> centres = new List<string>();

            //try
            //{
            //    //fetch all candidates and store
            //    if (!getAllQueryIndexNumbersFrom("allMissingIndexNumbers", examYear, centNumber, grade.ToString()))
            //    {
            //        return false;
            //    }

            //    //select index numbers
            //    DataTable dt = ds.Tables["allMissingIndexNumbers"];

            //    // Examyear, centNo, indexNo, CsdSubjCode
            //    foreach (DataRow dr in dt.Rows)
            //    {
            //        if (!cmbQrsIndexNumber.Items.Contains(dr["indexNo"].ToString()))
            //        {
            //            subjects.Add(dr["indexNo"].ToString());
            //        }
            //    }


            //    cmbQuerySubjects.Items.AddRange(subjects.ToArray());

            //    cmbQuerySubjects.DroppedDown = true;
            //    //

            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            return false;
        }

        private bool getAllQueryIndexNumbersFrom(string tableName, string examYear, string centreNumber, string grade)
        {
            //string str, examType;
            //string currentGrade = grade;

            //switch (grade)
            //{
            //    case "3":
            //    case "5":
            //    case "6":
            //        examType = "NAT" + grade;
            //        break;
            //    case "4":
            //        examType = "pgabece";
            //        break;
            //    case "7":
            //        examType = "Gabece";
            //        break;
            //    case "8":
            //        examType = "Wassce";
            //        break;
            //    case "9":
            //        examType = "Pwassce";
            //        break;
            //    default:
            //        break;
            //}

            //switch (currentGrade)
            //{
            //    case "3":
            //    case "5":
            //        str = string.Concat(new object[] {
            //            "SELECT PrePrintObjDetailsNAT", grade, ".examYear, PrePrintObjDetailsNAT", grade, ".centNo, PrePrintObjDetailsNAT",
            //            grade, ".indexNo, PrePrintObjDetailsNAT", grade, ".CsdSubjCode FROM PrePrintObjDetailsNAT", grade,
            //            " LEFT JOIN obj_", grade, " ON (PrePrintObjDetailsNAT", grade,
            //            ".examYear = obj_", grade, "_", examYear, ".examYear) AND (PrePrintObjDetailsNAT", grade, ".centNo = obj_",
            //            grade, "_", examYear, ".centNo) AND (PrePrintObjDetailsNAT", grade, ".indexNo = obj_", grade,
            //            "_", examYear, ".indexNo) AND (PrePrintObjDetailsNAT", grade, ".CsdSubjCode = obj_", grade,
            //            "_", examYear, ".CsdSubjCode) WHERE ((obj_", grade,
            //            "_", examYear, ".CsdSubjCode IS NULL));"});
            //        break;
            //    case "6":
            //        str = string.Concat(new object[] {
            //        "SELECT PrePrintObjDetailsNAT8.examYear, PrePrintObjDetailsNAT8.centNo, PrePrintObjDetailsNAT8.indexNo, PrePrintObjDetailsNAT8.CsdSubjCode FROM PrePrintObjDetailsNAT8 LEFT JOIN obj_",
            //        grade, "_", this.currentYear, " ON (PrePrintObjDetailsNAT8.examYear = obj_", grade, "_", examYear,
            //        ".examYear) AND (PrePrintObjDetailsNAT8.centNo = obj_", grade, "_", examYear,
            //        ".centNo) AND (PrePrintObjDetailsNAT8.indexNo = obj_", grade, "_", examYear,
            //        ".indexNo) AND (PrePrintObjDetailsNAT8.CsdSubjCode = obj_", grade, "_", examYear, ".CsdSubjCode) WHERE ((obj_",
            //        grade, "_", examYear, ".CsdSubjCode IS NULL));"
            //     });
            //        break;
            //    default:
            //        str = "SELECT PrePrintObjDetails" + examType + ".examYear, PrePrintObjDetails" + examYear +
            //            ".centNo, PrePrintObjDetails" + examYear + ".indexNo, PrePrintObjDetails" + examYear +
            //            ".CsdSubjCode FROM PrePrintObjDetails" + examYear + " LEFT JOIN obj_" + grade +
            //            " ON (PrePrintObjDetails" + examYear + ".examYear = obj_" + grade +
            //            ".examYear) AND (PrePrintObjDetails" + examYear + ".centNo = obj_" + grade +
            //            ".centNo) AND (PrePrintObjDetails" + examYear + ".indexNo = obj_" + grade +
            //            ".indexNo) AND (PrePrintObjDetails" + examYear + ".CsdSubjCode = obj_" + grade +
            //            ".CsdSubjCode) WHERE ((obj_" + grade + ".CsdSubjCode IS NULL));";
            //        //str = "SELECT PrePrintObjDetails" + this.currentExam + ".examYear, PrePrintObjDetails" + this.currentExam +
            //        //    ".centNo, PrePrintObjDetails" + this.currentExam + ".indexNo  FROM PrePrintObjDetails" + this.currentExam + 
            //        //    " LEFT JOIN obj_" + this.currentGrade +
            //        //    " ON (PrePrintObjDetails" + this.currentExam + ".examYear = obj_" + this.currentGrade +
            //        //    ".examYear) AND (PrePrintObjDetails" + this.currentExam + ".centNo = obj_" + this.currentGrade +
            //        //    ".centNo) AND (PrePrintObjDetails" + this.currentExam + ".indexNo = obj_" + this.currentGrade +
            //        //    ".indexNo) AND (PrePrintObjDetails" + this.currentExam + ".CsdSubjCode = obj_" + this.currentGrade +
            //        //    ".CsdSubjCode) WHERE ((obj_" + this.currentGrade + ".CsdSubjCode IS NULL));";
            //        break;
            //}
            //if (this.UpdateDs(tableName, str))
            //{
            //    return true;
            //}
            return false;
        }


            private void txtQrsIndexNumber_TextChanged(object sender, EventArgs e)
        {
            txtQrsData.Clear();
            txtQrsDataConfirm.Clear();
            cmbQrsSubjects.Items.Clear();

            if (txtQrsIndexNumber.TextLength >= 3 && txtQrsIndexNumber.Text != "...")
            {
                string examYear, subjectsTable, examType, centNo, indexNo;
                examYear = cmbQrsExamYear.Text;
                centNo = txtQrsCentreNumber.Text;
                indexNo = txtQrsIndexNumber.Text;
                examType = "";
                subjectsTable = "";

                switch (centNo[0])
                {
                    case '8':
                        examType = "PrePrintObjDetailsWassce";
                        subjectsTable = "obj_8";
                        break;
                    case '9':
                        examType = "PrePrintObjDetailsPwassce";
                        subjectsTable = "obj_9";
                        break;
                    case '4':
                        examType = "PrePrintObjDetailsPgabece";
                        subjectsTable = "obj_4";
                        break;
                    case '7':
                        examType = "PrePrintObjDetailsGabece";
                        subjectsTable = "obj_7";
                        break;
                    case '3':
                    case '5':
                    case '6':
                        examType = "PrePrintObjDetailsNat" + (centNo[0] == '6' ? "8" : centNo[0].ToString());
                        subjectsTable = "obj_" + centNo[0].ToString();
                        break;
                    default:
                        break;
                }

                // retrieve candidates subjects, filter only not scanned rows

                string sql = "SELECT " + examType + ".ExamYear, " + examType + ".CentNo, " + examType + ".IndexNo, " + examType + ".CsdSubjCode " +
                    "FROM " + examType + " LEFT JOIN " + subjectsTable + " ON (" + examType + ".CsdSubjCode = " + subjectsTable + ".CsdSubjCode) AND (" + examType + ".IndexNo = " + subjectsTable + ".IndexNo) AND (" + examType + ".CentNo = " + subjectsTable + ".CentNo) AND (" + examType + ".ExamYear = " + subjectsTable + ".ExamYear) " +
                    "WHERE (((" + subjectsTable + ".CsdSubjCode) Is Null)) " +
                    "GROUP BY " + examType + ".ExamYear, " + examType + ".CentNo, " + examType + ".IndexNo, " + examType + ".CsdSubjCode " +
                    "HAVING (((" + examType + ".ExamYear) = '" + examYear + "') AND ((" + examType + ".CentNo) = '" + centNo + "') AND ((" + examType + ".IndexNo) = '" + indexNo + "'));";

                db.cmd.CommandText = sql;

                try
                {
                    db.con.Open();
                    db.dr = db.cmd.ExecuteReader();

                    // populate  cmbQrsSubjects
                    

                    while (db.dr.Read())
                    {
                        cmbQrsSubjects.Items.Add(db.dr[3].ToString());
                    }

                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error getting candidate subjects. Please check and try again!");
                }
                finally
                {
                    if (db.con.State == ConnectionState.Open)
                        db.con.Close();
                }

                // drop down cmbQrsSubjects
                cmbQrsSubjects.Focus();
                cmbQrsSubjects.DroppedDown = true;
            }
        }

        private void resetQrsFields()
        {
            txtQrsData.Clear();
            txtQrsDataConfirm.Clear();

            txtQrsIndexNumber.Clear();
            txtQrsSubjCode.Clear();
            cbQrsSex.SelectedIndex = -1;
            cbQrsAbsent.Checked = false;
            btnQrsSaveData.Enabled = false;

            if (rbQrsStartFromIndex.Checked)
            {
                txtQrsIndexNumber.Focus();
            }
            else
            {
                txtQrsCentreNumber.Clear();
                txtQrsCentreNumber.Focus();
            }
        }

        private void txtQrsData_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;

            currentQrsTextBox = (TextBox)sender;

            if (tb.TextLength > 1)
                btnQrsSaveData.Enabled = true;
            else
                btnQrsSaveData.Enabled = false;

            lblCurrentQuestion.Text = (tb.TextLength + 1).ToString();

            if (tb.Text == "")
                return;

            tb.Text = tb.Text.ToUpper();
            tb.Select(tb.TextLength, 1);

            //MessageBox.Show("Key is: " + 
            switch (tb.Text.ToUpper()[tb.TextLength - 1])
            {
                case 'A':
                case 'B':
                case 'C':
                case 'D':
                case ' ':
                case '<':
                case '>': // bonus key
                case '+':
                    break;
                default:
                    tb.Text = tb.Text.Substring(0, tb.Text.Length - 1);
                    break;
            }

            if (tb.Name == "txtQrsDataConfirm")
            {
                try
                {
                    if (txtQrsDataConfirm.Text[txtQrsDataConfirm.TextLength - 1] != txtQrsData.Text[txtQrsDataConfirm.TextLength - 1])
                    {
                        // data mismatch

                        MessageBox.Show("Mismatch Data on Question " + (int.Parse(lblCurrentQuestion.Text) - 1) + "\nPlease Check.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }

        private void btnQrsSaveData_Click(object sender, EventArgs e)
        {
            DialogResult = MessageBox.Show("Continue saving?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult != System.Windows.Forms.DialogResult.Yes)
                return;

            if (txtQrsSubjCode.Text == "")
            {
                MessageBox.Show("Please check the selected subject.");
                return;
            }
                

            rtbQrsDisplay.AppendText("\n" + txtQrsCentreNumber.Text + txtQrsIndexNumber.Text + " " + txtQrsSubjCode.Text + " ... ");

            if (txtQrsData.Text != txtQrsDataConfirm.Text)
            {
                MessageBox.Show("The two entered data are not the same. Please check.");
                return;
            }

            // check for key
            string s = txtQrsCentreNumber.Text + txtQrsIndexNumber.Text + txtQrsSubjCode.Text + "  " + txtQrsData.Text;

            if (s.Substring(0, 2) == "99")
            {
                // scoring key
                DisplayRtbDisplayMessage("\nScoring key detected: " + s + "\n" + " - " + "Processing...\n");

                if (ProcessScoringKey(s))
                {
                    rtbQrsDisplay.AppendText("Saved");
                    BtnQrsClear.PerformClick();
                }
                else
                {
                    rtbQrsDisplay.AppendText("*** REJECTED");
                }

                return;
            }

            if (saveQrsData())
            {
                BtnQrsClear.PerformClick();
            }
            return;
        }

        private bool saveQrsData()
        {
            if (!cbQrsAbsent.Checked && txtQrsData.Text == "")
            {
                MessageBox.Show("Data is missing. Please check.", "Missing data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                db.con.Open();

                //db.cmd.CommandText =
                //    "INSERT INTO obj_" + txtQrsCentreNumber.Text[0] + "_" + txtQrsExamYear.Text +
                //    " (examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, userName, pcName, ManuallyKeyed) VALUES (" +
                //    "'" + txtQrsExamYear.Text + "', '" + txtQrsCentreNumber.Text + "', '" + txtQrsIndexNumber.Text + "', '" +
                //    txtQrsSubjCode.Text + "', '" + ((cbQrsSex.SelectedIndex == -1)?"":cbQrsSex.SelectedItem.ToString()) + "', '" +
                //    ((cbQrsAbsent.Checked == true)?"A": "") + "', '" + ((cbQrsAbsent.Checked == true)?"": txtQrsData.Text) + "', '" +
                //    userName + "', '" + pcName + "', " + true + ");";

                db.cmd.CommandText =
                    "INSERT INTO obj_" + txtQrsCentreNumber.Text[0] +
                    " (examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, userName, MachineName, ManuallyKeyed) VALUES (" +
                    "'" + cmbQrsExamYear.Text + "', '" + txtQrsCentreNumber.Text + "', '" + txtQrsIndexNumber.Text + "', '" +
                    txtQrsSubjCode.Text + "', '" + ((cbQrsSex.SelectedIndex == -1) ? "" : cbQrsSex.SelectedItem.ToString()) + "', '" +
                    ((cbQrsAbsent.Checked == true) ? "A" : "") + "', '" + ((cbQrsAbsent.Checked == true) ? "" : txtQrsData.Text) + "', '" +
                    userName + "', '" + pcName + "', " + true + ");";

                if (db.cmd.ExecuteNonQuery() > 0)
                {
                    rtbQrsDisplay.AppendText(" success");
                }
                else
                {
                    rtbQrsDisplay.AppendText(" failed");
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving: " + ex.Message);
                rtbQrsDisplay.AppendText(" error saving. NOT SAVED!");
                return false;
            }
            finally
            {
                db.con.Close();
            }

        }

        private void BtnQrsClear_Click(object sender, EventArgs e)
        {
            resetQrsFields();
        }

        private void txtQrsSubjCode_TextChanged(object sender, EventArgs e)
        {
            switch (txtQrsCentreNumber.TextLength)
            {
                case 5:
                    if (txtQrsCentreNumber.Text[0] == '7')
                    {
                        if (txtQrsSubjCode.TextLength == 6)
                        {
                            cbQrsSex.Focus();
                            //cbQrsSex.DroppedDown = true;
                        }
                    }
                    else
                    {
                        if (txtQrsSubjCode.TextLength == 2)
                        {
                            cbQrsSex.Focus();
                            //cbQrsSex.DroppedDown = true;
                        }
                    }
                    break;
                default:
                    if (txtQrsSubjCode.TextLength == 6)
                    {
                        cbQrsSex.Focus();
                        //cbQrsSex.DroppedDown = true;
                    }
                    break;
            }
        }

        private void txtQrsSubjCode_Leave(object sender, EventArgs e)
        {
            
// check to see whether candidate exists
            try
            {
                db.con.Open();

                db.cmd.CommandText =
                    "SELECT * FROM Obj_" + txtQrsCentreNumber.Text[0] + "_" + txtQrsExamYear.Text + " WHERE ((examYear = '" +
                    txtQrsExamYear.Text + "') AND (centNo = '" + txtQrsCentreNumber.Text + "') AND (indexNo = '" +
                    txtQrsIndexNumber.Text + "') AND (CsdSubjCode = '" + txtQrsSubjCode.Text + "') AND (ManuallyKeyed = true))";

                db.dr = db.cmd.ExecuteReader();

                if (db.dr.HasRows)
                {
                    // exists
                    rtbQrsDisplay.AppendText("\n" + txtQrsCentreNumber.Text + txtQrsIndexNumber.Text + " " + txtQrsSubjCode.Text + " ... ");
                    DialogResult = MessageBox.Show("Candidate already exists! Do you want to modify details entered?", "Confirm",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        // load the details and delete
                        while (db.dr.Read())
                        {
                            switch (db.dr["Sex"].ToString())
                            {
                                case "M":
                                    cbQrsSex.SelectedIndex = 0;
                                    break;
                                case "F":
                                    cbQrsSex.SelectedIndex = 1;
                                    break;
                                default:
                                    cbQrsSex.SelectedIndex = -1;
                                    break;
                            }

                            try
                            {
                                txtQrsData.Text = db.dr["Data"].ToString();
                                txtQrsDataConfirm.Text = txtQrsData.Text;
                            }
                            catch (Exception)
                            {
                            }

                            if (db.dr["Absent"].ToString().ToUpper() == "A")
                            {
                                cbQrsAbsent.Checked = true;
                            }

                        }

                        if (!db.dr.IsClosed)
                            db.dr.Close();

                        db.cmd.CommandText = "DELETE * FROM Obj_" + txtQrsCentreNumber.Text[0] + "_" + txtQrsExamYear.Text + " WHERE ((examYear = '" +
                            txtQrsExamYear.Text + "') AND (centNo = '" + txtQrsCentreNumber.Text + "') AND (indexNo = '" +
                            txtQrsIndexNumber.Text + "') AND (CsdSubjCode = '" + txtQrsSubjCode.Text + "') AND (ManuallyKeyed = true))";

                        if (db.cmd.ExecuteNonQuery() > 0)
                        {
                            rtbQrsDisplay.AppendText(" deleted. Please save new data.");
                            Console.WriteLine("Candidate deleted");
                        }
                    }
                    else
                        BtnQrsClear.PerformClick();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in subjcode_leave: " + ex.Message);
            }
            finally
            {
                db.con.Close();
            }

        }

        private void UpdateCurrentQrsTextBox(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            try
            {
                currentQrsTextBox.Text += b.Text;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in updateCurrentQrsTextBox: " + ex.Message);
            }

        }

        private void QrsTextBoxActive(object sender, EventArgs e)
        {
            currentQrsTextBox = (TextBox)sender;
        }

        private void btnQrsShowKeyPad_Click(object sender, EventArgs e)
        {
            gbQrsKeypad.Visible = !gbQrsKeypad.Visible;
        }

        private void btnSearchQrsCandidate_Click(object sender, EventArgs e)
        {
            scQryRes.Panel2Collapsed = true;
            gbQrsCheckCandidate.Visible = !gbQrsCheckCandidate.Visible;
            txtQrsCheckExamYear.Text = DateTime.Now.Year.ToString();
        }

        private void btnQrsCheckClear_Click(object sender, EventArgs e)
        {
            txtQrsCheckCentNo.Text = "";
            txtQrsCheckIndexNo.Text = "";
            lvQrsCheckCandidate.Items.Clear();
        }

        private void btnSearchCheckCandidate_Click(object sender, EventArgs e)
        {
            try
            {
                db.con.Open();

                string whereClause = "";

                if ((cbQrsCheckShowManuallyKeyed.Checked) && (!cbQrsCheckShowUnscored.Checked))
                    whereClause = " AND (ManuallyKeyed = True) ";
                else if ((!cbQrsCheckShowManuallyKeyed.Checked) && (cbQrsCheckShowUnscored.Checked))
                    whereClause = " AND (Scored = False) ";
                else if ((cbQrsCheckShowManuallyKeyed.Checked) && (cbQrsCheckShowUnscored.Checked))
                    whereClause = " AND ((ManuallyKeyed = True) AND (Scored = False) ";
                else
                    whereClause = "";

                if (txtQrsCheckCentNo.Text != "")
                {
                    if (txtQrsCheckIndexNo.Text != "")
                    {
                        db.cmd.CommandText =
                            "SELECT examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, UserName, MachineName, ts, ManuallyKeyed, Scored " +
                            "FROM obj_" + txtQrsCheckCentNo.Text[0] + " " +
                            "WHERE (examYear = '" + txtQrsCheckExamYear.Text + "') AND (centNo = '" + txtQrsCheckCentNo.Text + "') AND (indexNo = '" + txtQrsCheckIndexNo.Text + "') " + whereClause +
                            "ORDER BY centNo, indexNo, CsdSubjCode;";
                    }
                    else
                    {
                        db.cmd.CommandText =
                            "SELECT examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, UserName, MachineName, ts, ManuallyKeyed, Scored " +
                            "FROM obj_" + txtQrsCheckCentNo.Text[0] + " " +
                            "WHERE (examYear = '" + txtQrsCheckExamYear.Text + "') AND (centNo LIKE \'%" + txtQrsCheckCentNo.Text + "%\') " + whereClause +
                            "ORDER BY centNo, indexNo, CsdSubjCode;";
                        //    db.cmd.CommandText =
                        //        "SELECT examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, UserName, PcName, ts, ManuallyKeyed, Scored " +
                        //        "FROM obj_" + txtQrsCheckCentNo.Text[0] + "_" + txtQrsCheckExamYear.Text + " " +
                        //        "WHERE (examYear = '" + txtQrsCheckExamYear.Text + "') AND (centNo LIKE \'%" + txtQrsCheckCentNo.Text + "%\') " + whereClause +
                        //        "ORDER BY centNo, indexNo, CsdSubjCode;";
                    }
                }
                else
                {
                    db.cmd.CommandText =
                             "SELECT examYear, centNo, indexNo, CsdSubjCode, Sex, Absent, Data, UserName, MachineName, ts, ManuallyKeyed, Scored " +
                             "FROM obj_" + txtQrsCheckCentNo.Text[0] + " " +
                             "WHERE " + whereClause +
                             "ORDER BY centNo, indexNo, CsdSubjCode;";
                }


                db.dr = db.cmd.ExecuteReader();

                if (!db.dr.HasRows)
                {
                    MessageBox.Show("Selection not found. Please check and try again.", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                lvQrsCheckCandidate.Items.Clear();

                while (db.dr.Read())
                {
                    // populate lv
                    string[] subItems = new string[] { db.dr[0].ToString(), db.dr[1].ToString(), db.dr[2].ToString(),
                        db.dr[3].ToString(), db.dr[4].ToString(), db.dr[5].ToString(), db.dr[6].ToString()
                    , ((db.dr[10].ToString()== "False")?"NO":"YES"), ((db.dr[11].ToString()== "False")?"NO":"YES")};
                    lvQrsCheckCandidate.Items.Add(new ListViewItem(subItems));
                }

                //highlight unscored
                foreach (ListViewItem lv in lvQrsCheckCandidate.Items)
                {
                    try
                    {
                        if (lv.SubItems[8].Text == "NO")
                        {
                            lv.BackColor = Color.OrangeRed;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error HighlightOutstanding: ", ex.Message);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error checking for candidate: " + ex.Message);
            }
            finally
            {
                db.con.Close();
            }
        }

        private void txtQrsCheckCentNo_TextChanged(object sender, EventArgs e)
        {
            if (txtQrsCheckCentNo.Text == "")
            {
                btnSearchCheckCandidate.Enabled = false;
                return;
            }
            else
                btnSearchCheckCandidate.Enabled = true;

            try
            {
                switch (txtQrsCheckCentNo.Text[0])
                {
                    case '3':
                    case '5':
                    case '6':
                    case '7':
                        if (txtQrsCheckCentNo.TextLength == 5)
                        {
                            txtQrsCheckIndexNo.Focus();
                            txtQrsCheckIndexNo.SelectAll();
                        }
                        break;
                    case '8':
                    case '9':
                        if (txtQrsCheckCentNo.TextLength == 7)
                        {
                            txtQrsCheckIndexNo.Focus();
                            txtQrsCheckIndexNo.SelectAll();
                        }
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in checking qrscheckcentNo: " + ex.Message);
            }

        }

        private void txtQrsCheckIndexNo_TextChanged(object sender, EventArgs e)
        {
            if (txtQrsCheckIndexNo.TextLength == 3)
            {
                btnSearchCheckCandidate.Focus();
            }
        }

        private void cbQrsCheckShowManuallyKeyed_CheckedChanged(object sender, EventArgs e)
        {
            //btnSearchCheckCandidate.PerformClick();
        }

        private void cbExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.currentExam = cbExamYear.SelectedItem.ToString();
        }

        private void lvQrsCheckCandidate_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblHeader_Click(object sender, EventArgs e)
        {

        }

        private void rbViewSpecificDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpViewSpecificDate.Visible = rbViewSpecificDate.Checked;
            //rbViewAll_CheckedChanged(sender, e);
        }

        private void rbViewAll_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                btnRefreshCentres.PerformClick();
        }

        private void lblSelectedSubject_Click(object sender, EventArgs e)
        {

        }

        private void dtpViewSpecificDate_ValueChanged(object sender, EventArgs e)
        {
            btnRefreshCentres.PerformClick();
        }

        private void rbViewSpecificUser_CheckedChanged(object sender, EventArgs e)
        {
            //cmbViewSpecificUser.Visible = rbViewSpecificUser.Checked;
            //rbViewAll_CheckedChanged(sender, e);
        }

        private void cmbViewSpecificUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSortAscDesc_Click(object sender, EventArgs e)
        {
            //▲▼
            if (btnSortAscDesc.Text == "▲")
            {
                //sort ascending
                lvSubjDetails.Sorting = SortOrder.Ascending;
                btnSortAscDesc.Text = "▼";
            }
            else
            {
                //sort desc
                lvSubjDetails.Sorting = SortOrder.Descending;
                btnSortAscDesc.Text = "▲";
            }
        }

        private void rbViewIncompleteCentres_CheckedChanged(object sender, EventArgs e)
        {
            btnRefreshCentres.PerformClick();
        }

        private void gbQrsCheckCandidate_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter_1(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void scQrsMain_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtQrsCheckExamYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabQuery_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if ((tabQuery.SelectedTab.Name == "tpGetQuery") && (cmbQueryGrade.Items.Count == 0))
            //{
            //    btnQueryReload.PerformClick();
            //}
            switch (tabQuery.SelectedTab.Name)
            {
                case "tabEnterUnscannedSheets":
                    // load year in cb
                    cmbQrsExamYear.DroppedDown = true;
                    break;
                default:
                    break;
            }

        }

        private void btnQueryReload_Click(object sender, EventArgs e)
        {
            cmbQueryCentres.Items.Clear();
            cmbQuerySubjects.Items.Clear();

            if (ReloadQuery())
                Console.WriteLine("Query data loaded success");
            else
                Console.WriteLine("Query data loaded FAILED");
        }

        private bool ReloadQuery()
        {
            List<string> subjects = new List<string>();
            List<string> centres = new List<string>();
            cmbQuerySubjects.Items.Clear();
            lvQueryCandidate.Items.Clear();

            try
            {
                //fetch all candidates and store
                if (!getAllMissingCandidate("allMissingCandidates"))
                {
                    return false;
                }

                //select subjects
                DataTable dt = ds.Tables["allMissingCandidates"];

                // Examyear, centNo, indexNo, CsdSubjCode
                foreach (DataRow dr in dt.Rows)
                {
                    if (!subjects.Contains(dr["CsdSubjCode"].ToString()))
                    {
                        subjects.Add(dr["CsdSubjCode"].ToString());
                    }
                }


                cmbQuerySubjects.Items.AddRange(subjects.ToArray());

                cmbQuerySubjects.DroppedDown = true;
                //

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }

        private void cmbQueryGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbQueryGrade.SelectedIndex == -1)
                return;

            //this.currentGrade = cmbQueryGrade.SelectedItem.ToString().Substring(0,1);
            currentGrade = cmbQueryGrade.SelectedItem.ToString().Substring(0, 1);
            currentExam = cmbQueryGrade.SelectedItem.ToString().Substring(4);
            cmbQuerySubjects.Items.Clear();
            lvQueryCandidate.Items.Clear();
            //lvSubjDetails.Items.Clear();
            cmbQuerySubjects.Enabled = true;
            btnQueryReload.Enabled = true;

            if (tabQuery.SelectedTab.Name == "tpGetQuery")
            {
                btnQueryReload.PerformClick();
            }

            //cmbQuerySubjects.SelectedText = "(Please select subjects)";
        }

        private bool LoadlvQueryCandidate()
        {
            lvQueryCandidate.Items.Clear();
            List<ListViewItem> lvis = new List<ListViewItem>();

            //if (!getMissingCandidate("MissingCandidates", cmbQueryCentres.SelectedItem.ToString()))
            //{
            //    return false;
            //}

            try
            {
                //DataTable dt = ds.Tables["MissingCandidates"];

                foreach (DataRow dr in ds.Tables["allMissingCandidates"].Select("CsdSubjCode = '" +
                    cmbQuerySubjects.Text.Substring(0, 6) + "' AND centNo = '" +
                    cmbQueryCentres.Text.Substring(0, (currentGrade.Equals(8) || currentGrade.Equals(9)) ? 7 : 5) + "'"))
                {
                    // Add Data
                    string subject = dr["CsdSubjCode"].ToString();
                    if (subject.Equals(cmbQuerySubjects.SelectedItem.ToString().Substring(0, 6)))
                    {
                        lvis.Add(new ListViewItem(new string[] { dr["centNo"].ToString(), dr["indexNo"].ToString(), (subject + " - " + GetSubjectName(subject)) }));
                    }
                }

                if (lvis.Count > 0)
                {
                    lvQueryCandidate.Items.AddRange(lvis.ToArray());

                }
                else
                {
                    MessageBox.Show("No records returned!!!", "..:: No record returned ::..", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in LoadlvQueryCandidate: " + ex.Message);
            }
            return false;
        }

        private void cmbQuerySubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbQuerySubjects_SelectionChangeCommitted(object sender, EventArgs e)
        {

            try
            {
                // load centres for that subjects
                List<string> centres = new List<string>();

                cmbQueryCentres.Items.Clear();
                lvQueryCandidate.Items.Clear();

                string csdSubjCode = cmbQuerySubjects.Text.Substring(0, 6);
                ////DataTable dt = ds.Tables["allMissingCandidates"].Select("CsdSubjCode = '" + cmbQuerySubjects.Text + "'");

                foreach (DataRow dr in ds.Tables["allMissingCandidates"].Select("CsdSubjCode = '" + csdSubjCode + "'"))
                {
                    string centNo = dr["centNo"].ToString();
                    if (!centres.Contains(centNo))
                    {
                        centres.Add(centNo);
                        //centres.Add(centNo + " - " + CountCentreSubjectTotalQueries(csdSubjCode, centNo));
                    }
                }

                cmbQueryCentres.Items.AddRange(centres.ToArray());
                cmbQueryCentres.Enabled = true;
                cmbQueryCentres.DroppedDown = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading centres: " + ex.Message);
            }
        }

        private int CountCentreSubjectTotalQueries(string subject, string centNo)
        {
            try
            {
                int total = 0;
                foreach (DataRow dr in
                    ds.Tables["allMissingCandidates"].Select("CsdSubjCode = '" + subject + "' AND centNo = '" + centNo + "'"))
                {
                    total++;
                }
                return total;
            }
            catch (Exception)
            {

            }
            return (-1);
        }

        private int CountCentreTotalQueries(string centNo)
        {
            try
            {
                int total = 0;
                foreach (DataRow dr in
                    ds.Tables["allMissingCandidates"].Select("centNo = '" + centNo + "'"))
                {
                    total++;
                }
                return total;
            }
            catch (Exception)
            {

            }
            return (-1);
        }

        private void cmbQueryCentres_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void cmbQueryCentres_SelectedIndexChanged(object sender, EventArgs e)
        {
            //load listview with details from allMissingCandidates
            if (LoadlvQueryCandidate())
            {

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbAbsentCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbLess15Check_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            try
            {
                LoadUserTotalScanned();
                //startLoadingLvWithSubjects();
            }
            catch (Exception)
            {
            }

        }

        private void rbUnscannedCentres_CheckedChanged(object sender, EventArgs e)
        {
            btnRefreshCentres.PerformClick();
        }

        private void btnSelectScanFile_Click(object sender, EventArgs e)
        {
            // updating from text saved text file.
            // show file browser
            ofdScanData.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            ofdScanData.Title = "Select Scan Text File(s)";
            DialogResult dialogResult = ofdScanData.ShowDialog();
            FileStream myStream = null;
            FileInfo scanFile;
            int count = 0;
            

            // select multiple files
            // load contents of file in rtbData
            // proceed with normal cleaning

            //rtbData.AppendText("Testing");

            try
            {
                foreach (string filename in ofdScanData.FileNames)
                {
                    scanFile = new FileInfo(filename);

                    if (rtbOutput.Text != "")
                        btnClearRtbs.PerformClick();
                    scMid.Panel2Collapsed = false;
                    btnClean.Visible = true;

                    gbPasteScanData.Visible = true;
                    try
                    {
                        if (File.Exists(filename))
                        {
                            rtbData.Text = File.ReadAllText(filename);
                            DisplayRtbDisplayMessage("\n\nCleaning Data from file: " + filename + " ...please wait");
                            rtbRejectDisplay.AppendText("\n\n" + ++count + "Processing file: " + filename + "...");
                            btnClean.PerformClick();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error reading from file: " + filename + " failed - " + ex.Message);
                        DisplayRtbDisplayMessage("\n\nCleaning Data... please wait");
                        rtbRejectDisplay.AppendText("\n\n" + ++count + "Processing file: " + filename + " failed!");
                    }
                    rtbData.AppendText("\n");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting data: " + ex.Message);
                DisplayRtbDisplayMessage("\n***** Error getting data: " + ex.Message);
            }
        }

        private void cmbQrsSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load index numbers with queries from selected centre
            txtQrsSubjCode.Text = cmbQrsSubjects.Text;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtQrsExamYear_TextChanged(object sender, EventArgs e)
        {
            // load centres with missing objs
        }

        private void cmbQrsIndexNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            // load index numbers with changes
            txtQrsIndexNumber.Text = cmbQrsIndexNumber.Text;
        }

        private void cmbQrsExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtQrsCentreNumber_Leave(object sender, EventArgs e)
        {
            // load all index numbers for the selected centre with queries

        }

        private void CmbQrsExamYear_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnSaveRtbDisplay_Click(object sender, EventArgs e)
        {

        }

        private void btnQrsCheckShowAbsents_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxScanExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            if (comboBoxScanExamYear.SelectedItem != "")
            {
                groupBoxScanScanners.Enabled = true;
                labelScan3.Visible = true;
                
            }
            else
            { 
                groupBoxScanScanners.Enabled = false;
                labelScan3.Visible = false;
            }
        }

        private void comboBoxScanGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            // populate ExamYear for selected grade
            comboBoxScanExamYear.Items.Clear();
            groupBoxScanScanners.Enabled = false;

            var examYearTable = ds.Tables["ExamYear" + comboBoxScanGrade.Text];

            foreach (DataRow row in examYearTable.Rows)
            {
                comboBoxScanExamYear.Items.Add(row[0]);
            }

            labelScan2.Visible = true;
            labelScan3.Visible = false;
            labelScan4.Visible = false;


        }

        private void cmbQrsCheckExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtQrsCheckExamYear.Text = cmbQrsCheckExamYear.Text;
        }

        private void scMain_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lvQryCandidateRegisterdSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbQrsSex_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void scScoreMain_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        //private string GetCentreName(string centNo)
        //{
        //    try
        //    {
        //        foreach (DataRow dr in ds.Tables["SubjIndex" + currentGrade].Rows)
        //        {
        //            if(csdSubjCode.Equals(dr["CsdSubjCode"].ToString()))
        //            {
        //                // match found, return name
        //                return dr["SubjName"].ToString();
        //            }
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Error in GetCentreName(): " + ex.Message);
        //    }
        //    return "";
        //}
    }
}

//public class CursorWait : IDisposable
//{
//    public CursorWait(bool appStarting = false, bool applicationCursor = false)
//    {
//        // Wait
//        Cursor.Current = appStarting ? Cursors.AppStarting : Cursors.WaitCursor;
//        if (applicationCursor) Application.UseWaitCursor = true;
//    }

//    public void Dispose()
//    {
//        // Reset
//        Cursor.Current = Cursors.Default;
//        Application.UseWaitCursor = false;
//    }
//}