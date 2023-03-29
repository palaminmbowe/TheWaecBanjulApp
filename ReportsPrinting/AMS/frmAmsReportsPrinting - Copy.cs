using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Windows.Forms;
using WaecLibrary;
using System.Data.OleDb;
using ReportsPrinting.AMS;

namespace ReportsPrinting
{
    public partial class frmAmsReportsPrinting : Form
    {
        private DataSet ds;
        Exams exam;
        ReportTypes report;
        string selectedSubject;

        private dbConnection3 db = new dbConnection3();

        System.IO.FileInfo dbFile;
        string userName, pcName, domain;

        public frmAmsReportsPrinting(Exams exam, ReportTypes report)
        {
            InitializeComponent();
            this.exam = exam;
            this.report = report;
            domain = Environment.UserDomainName.ToString();
            userName = Environment.UserName.ToString();
            pcName = Environment.MachineName.ToString();

            if (!generateConnectionString())
            {
                MessageBox.Show("Error connecting to db", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private bool setupReportViewer()
        {
            try
            {
                if (ds == null)
                    return false;

                //_02OUTTableAdapter1.GetData();

                switch (exam)
                {
                    case Exams.GABECE:
                        return setupViewerGabece();
                    case Exams.NATG3:
                    case Exams.NATG5:
                    case Exams.NATG8:
                        return setupViewerNat();
                    case Exams.PWASSCE:
                    case Exams.WASSCE:
                        return setupViewerWassce();
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception setting up report: " + ex.Message);
            }

            return false;
        }

        private bool setupViewerNat()
        {
            try
            {
                string grade = exam.ToString().Substring(exam.ToString().Length - 1);

                //switch (grade)
                //{
                //    case "3":
                //        crNewAMSNat3 cr3 = new crNewAMSNat3();

                //        cr3.Database.Tables["NATGRADE" + grade].SetDataSource((DataTable)ds.Tables["02OUT"]);
                //        cr3.Database.Tables["qryCentresG" + grade].SetDataSource((DataTable)ds.Tables["CENTRES"]);
                //        cr3.Database.Tables["05OUTG" + grade].SetDataSource((DataTable)ds.Tables["05OUT"]);
                //        cr3.Database.Tables["qrySubjects"].SetDataSource((DataTable)ds.Tables["SUBJECTS"]);
                //        cr3.VerifyDatabase();
                //        cr3.Refresh();
                //        crystalReportViewer1.ReportSource = cr3;
                //        break;
                //    case "5":
                //        crNewAMSNat5 cr5 = new crNewAMSNat5();
                //        cr5.Database.Tables["NATGRADE3"].SetDataSource((DataTable)ds.Tables["02OUT"]);
                //        cr5.Database.Tables["qryCentresG3"].SetDataSource((DataTable)ds.Tables["CENTRES"]);
                //        cr5.Database.Tables["05OUTG3"].SetDataSource((DataTable)ds.Tables["05OUT"]);
                //        cr5.Database.Tables["qrySubjects"].SetDataSource((DataTable)ds.Tables["SUBJECTS"]);
                //        cr5.VerifyDatabase();
                //        cr5.Refresh();
                //        crystalReportViewer1.ReportSource = cr5;
                //        break;
                //    case "8":
                //        crNewAmsNAT8 cr8 = new crNewAmsNAT8();
                //        cr8.Database.Tables["NATGRADE3"].SetDataSource((DataTable)ds.Tables["02OUT"]);
                //        cr8.Database.Tables["qryCentresG3"].SetDataSource((DataTable)ds.Tables["CENTRES"]);
                //        cr8.Database.Tables["05OUTG3"].SetDataSource((DataTable)ds.Tables["05OUT"]);
                //        cr8.Database.Tables["qrySubjects"].SetDataSource((DataTable)ds.Tables["SUBJECTS"]);
                //        cr8.VerifyDatabase();
                //        cr8.Refresh();
                //        crystalReportViewer1.ReportSource = cr8;
                //        break;
                //    default:
                //        break;
                //}

                //return true;

                try
                {
                    crAmsNatNew cr = new crAmsNatNew();
                    cr.Database.Tables["02OUTG3"].SetDataSource(ds.Tables["02OUT"]);
                    cr.Database.Tables["qryCentresG3"].SetDataSource(ds.Tables["CENTRES"]);
                    cr.Database.Tables["05OUTG3"].SetDataSource(ds.Tables["05OUT"]);
                    cr.Database.Tables["qryNatSubjects"].SetDataSource(ds.Tables["SUBJECTS"]);
                    cr.VerifyDatabase();
                    cr.Refresh();
                    crystalReportViewer1.ReportSource = cr;
                    crystalReportViewer1.Refresh();

                    return true;
                }
                catch (CrystalReportsException ex)
                {
                    Console.WriteLine("Error saving tables: " + ex.Message + " Source: " + ex.Source);
                }
                return false;
            }
            catch (CrystalReportsException ex)
            {
                Console.WriteLine("Exception setting up report for NAT: " + ex.Message);
                return false;
            }
        }

        private bool setupViewerGabece()
        {
            try
            {
                // original one
                //crAmsGabece cr = new crAmsGabece();

                //shifted to the left - print head fault
                crAmsGabeceNewShifted cr = new crAmsGabeceNewShifted();

                cr.Database.Tables["02OUT"].SetDataSource(ds.Tables["02OUT"]);
                cr.Database.Tables["05OUT"].SetDataSource(ds.Tables["05OUT"]);
                cr.Database.Tables["Centres"].SetDataSource(ds.Tables["Centres"]);
                cr.Database.Tables["Subjects"].SetDataSource(ds.Tables["Subjects"]);

                cr.VerifyDatabase();
                cr.Refresh();

                //crystalReportViewer1 = new CrystalReportViewer();
                crystalReportViewer1.ReportSource = cr;

                crystalReportViewer1.Refresh();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception setting up report for WASSCE: " + ex.Message);
                return false;
            }
        }

        private bool setupViewerWassce()
        {
            try
            {
                if (rbDepot.Checked)
                {
                    crAmsWassce3_Depot crd = new crAmsWassce3_Depot();
                    crd.Database.Tables["Depot"].SetDataSource(ds.Tables["Depot"]);
                    crd.Database.Tables["02OUT"].SetDataSource(ds.Tables["02OUT"]);
                    crd.Database.Tables["05OUT"].SetDataSource(ds.Tables["05OUT"]);
                    crd.Database.Tables["Centres"].SetDataSource(ds.Tables["Centres"]);
                    crd.Database.Tables["Subjects"].SetDataSource(ds.Tables["Subjects"]);
                    crd.VerifyDatabase();
                    crd.Refresh();
                    crystalReportViewer1.ReportSource = crd;
                    crystalReportViewer1.Refresh();
                }
                else
                {
                    crAmsWassce2 cr = new crAmsWassce2();

                    cr.Database.Tables["02OUT"].SetDataSource((DataTable)ds.Tables["02OUT"]);
                    cr.Database.Tables["05OUT"].SetDataSource((DataTable)ds.Tables["05OUT"]);
                    cr.Database.Tables["Centres"].SetDataSource((DataTable)ds.Tables["Centres"]);
                    cr.Database.Tables["Subjects"].SetDataSource((DataTable)ds.Tables["Subjects"]);
                    cr.VerifyDatabase();
                    cr.Refresh();
                    crystalReportViewer1.ReportSource = cr;
                    crystalReportViewer1.Refresh();
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception setting up report for WASSCE: " + ex.Message);
                return false;
            }
        }

        private void frmReportsPrinting_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            lblExam.Text = exam.ToString();
            
            if(ds == null)
                ds = new DataSet("dsCsdPrinting");

            //if (!generateConnectionString())
            //{
            //    MessageBox.Show("Error connecting to db", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            //}
        }

        private void FillInSubjects()
        {
            if (!db.isConnected())
            {
                MessageBox.Show("Error connecting to db");
                return;
            }

            string sql, tn;

            sql = "SELECT Distinct GenSubjcode, ShortName From " + exam.ToString() + "Subjects";
            tn = exam.ToString() + "Subjects";

            //load subjects
            try
            {
                if (UpdateDs(tn, sql))
                {
                    clbSelectedSubjects.Items.Clear();
                    cbSubject.Items.Clear();

                    DataTable dt = ds.Tables[tn];

                    cbSubject.Items.Add("All Subjects");

                    foreach (DataRow dr in dt.Rows)
                    {
                        clbSelectedSubjects.Items.Add(dr["GenSubjCode"] + " - " + dr["ShortName"].ToString().Trim(), true);
                        cbSubject.Items.Add(dr["GenSubjCode"] + " - " + dr["ShortName"].ToString().Trim());
                    }
                    cbSubject.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("Failed to load subjects");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error loading subjects: " + ex.Message);
            }
        }

        private void rbSpecificCentre_CheckedChanged(object sender, EventArgs e)
        {
            //cbSelectedCentre.Enabled = rbSpecificCentre.Checked;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = null;
            scBottom.Panel2Collapsed = true;

            if (setupReport())
            {
                scBottom.Panel2Collapsed = false;
                if (setupReportViewer())
                    btnLoad.Enabled = false;
            }
            else
            {
                MessageBox.Show("The report didn't load properly. There was a bit of a problem setting it up. Please try again.", "Error setting up report", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool setupReport()
        {
            switch (exam)
            {
                
                case Exams.NATG3:
                case Exams.NATG5:
                case Exams.NATG8:
                    switch (report)
                    {
                        case ReportTypes.AMS:
                            if (retrieveNatAmsTables())
                                return true;
                            else
                            {
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case Exams.GABECE:
                case Exams.PWASSCE:
                case Exams.WASSCE:
                    switch (report)
                    {
                        case ReportTypes.AMS:
                            if (retrieveAmsTables())
                                return true;
                            else
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

            return false;
        }

        private Boolean retrieveNatAmsTables()
        {
            if (!db.isConnected())
            {
                MessageBox.Show("Error connecting to db");
                return false;
            }

            try
            {
                ds = new DataSet();
            }
            catch (Exception)
            {
                
                throw;
            }

            //bool loadSpecificSubject;
            string grade = exam.ToString().Substring(exam.ToString().Length - 1);

            //if (cbSubject.SelectedIndex > 0)
            //    loadSpecificSubject = true;

            try
            {
                List<OleDbDataAdapter> dsAdapters = new List<OleDbDataAdapter>();
                List<string> sqlStatements = new List<string>();
                string[] tables = { "02OUT", "CENTRES", "05OUT", "SUBJECTS"};

                //check constraints
                //sqlStatements.Add("Select ExamYear, CentNo, IndexNo, CandName, Sex FROM [02OUTWassce];");
                sqlStatements.Add("Select ExamYear, CentNo, IndexNo, CandName, Sex FROM [02OUTG" + grade + "];");
                sqlStatements.Add("Select * FROM [CentresNatG" + grade + "];");
                sqlStatements.Add("Select * FROM [05OUTG" + grade + "];");
                sqlStatements.Add("Select * FROM [NatSubjects" + "];");

                for (int i = 0; i < sqlStatements.Count; i++)
                {
                    dsAdapters.Add(new OleDbDataAdapter(sqlStatements[i], db.con));
                    dsAdapters[i].Fill(ds, tables[i]);
                }


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Connecting ds: " + ex.Message);
            }

            return false;
        }

        private Boolean retrieveAmsTables()
        {
            //if (!generateConnectionString())
            //{
            //    MessageBox.Show("Error connecting to db");
            //    return false;
            //}

            if (!db.isConnected())
            {
                MessageBox.Show("Error connecting to db");
                return false;
            }

            bool loadSpecificSubject = false;

            if (cbSubject.SelectedIndex > 0)
                loadSpecificSubject = true;
            else
                loadSpecificSubject = false;

            if (loadSpecificSubject)
            {
            }            

            try
            {
                List<OleDbDataAdapter> dsAdapters = new List<OleDbDataAdapter>();
                List<string> sqlStatements = new List<string>();
                string[] tables = { "02OUT", "05OUT", "Centres", "Subjects", "Depot" };
                //OleDbConnection[] con = {db.con, db.con1, db.con2, db.con3};

                //check constraints
                //sqlStatements.Add("Select ExamYear, CentNo, IndexNo, CandName, Sex FROM [02OUTWassce];");
                sqlStatements.Add("Select ExamYear, CentNo, IndexNo, CandName, Sex, DisabilityCode FROM [02OUT" + exam.ToString() + "];");

                //check which combination to get
                if (rbSubjectsWithoutPracticals.Checked)
                {
                    // subjects with only two components
                    //sqlStatements.Add("Select ExamYear, GenSubjCode, CentNo, IndexNo FROM [05OUTWassce] WHERE (RIGHT(GenSubjCode, 1) = '2');");
                    
                    if (cbSubject.SelectedIndex > 0)
                        sqlStatements.Add("Select ExamYear, GenSubjCode, CentNo, IndexNo FROM [05OUT" + exam.ToString() + "] WHERE (RIGHT(GenSubjCode, 1) = '2') AND (GenSubjCode = '" + selectedSubject + "');");
                    else
                        sqlStatements.Add("Select ExamYear, GenSubjCode, CentNo, IndexNo FROM [05OUT" + exam.ToString() + "] WHERE (RIGHT(GenSubjCode, 1) = '2');");
                }
                else if (rbSubjetsWithPracticals.Checked)
                {
                    //subjects with more that two components
                    //sqlStatements.Add("Select ExamYear, GenSubjCode, CentNo, IndexNo FROM [05OUTWassce] WHERE (RIGHT(GenSubjCode, 1) = '3') OR (RIGHT(GenSubjCode, 1) = '4');");
                    if (cbSubject.SelectedIndex > 0)
                        sqlStatements.Add("Select ExamYear, GenSubjCode, CentNo, IndexNo FROM [05OUT" + exam.ToString() + "] WHERE ((RIGHT(GenSubjCode, 1) = '3') OR (RIGHT(GenSubjCode, 1) = '4')) AND (GenSubjCode = '" + selectedSubject + "');");
                    else
                        sqlStatements.Add("Select ExamYear, GenSubjCode, CentNo, IndexNo FROM [05OUT" + exam.ToString() + "] WHERE (RIGHT(GenSubjCode, 1) = '3') OR (RIGHT(GenSubjCode, 1) = '4');");
                }
                else
                {
                    //load all
                    //sqlStatements.Add("Select ExamYear, GenSubjCode, CentNo, IndexNo FROM [05OUTWassce];");
                    if (cbSubject.SelectedIndex > 0)
                        sqlStatements.Add("Select ExamYear, GenSubjCode, CentNo, IndexNo FROM [05OUT" + exam.ToString() + "] WHERE (GenSubjCode = '" + selectedSubject + "');");
                    else
                        sqlStatements.Add("Select ExamYear, GenSubjCode, CentNo, IndexNo FROM [05OUT" + exam.ToString() + "];");
                }

                //sqlStatements.Add("Select * FROM CentresWassce;");
                //sqlStatements.Add("Select * FROM WassceSubjects;");
                sqlStatements.Add("Select * FROM Centres" + exam.ToString() + ";");
                sqlStatements.Add("Select * FROM " + exam.ToString() + "Subjects;");
                sqlStatements.Add("Select * FROM Depot" + exam.ToString() + ";");

                for (int i = 0; i < sqlStatements.Count; i++)
                {
                    dsAdapters.Add(new OleDbDataAdapter(sqlStatements[i], db.con));
                    //remove table first
                    try
                    {
                        ds.Tables.Remove(tables[i]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error removing tables retrieveAmsTables(): {ex.Message}");
                    }

                    try
                    {
                        dsAdapters[i].Fill(ds, tables[i]);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error fill tables retrieveAmsTables(): {ex.Message}");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Connecting ds: " + ex.Message);
            }
            return false;
        }

        private Boolean generateConnectionString()
        {
            //// dbName, path, password
            //db = new dbConnection3(Properties.Resources.dbName, Properties.Resources.dbPath, getPassword());

            //return db.isConnected();
            // dbName, path, password
            try
            {
                //if (((domain.ToLower() == "palamin") && (pcName.ToLower() == "palamin")) || ((domain.ToLower() == "csd") || (pcName.ToLower() == "waeccsdd020")))
                if (
                    (((this.domain.ToLower() == "palamin") && (this.pcName.ToLower() == "palamin")) ||
                    ((this.domain.ToLower() == "palamin2") && (this.pcName.ToLower() == "palamin2")) ||
                    ((this.domain.ToLower() == "ictd") && (this.pcName.ToLower() == "w-ictd19d002"))) &&
                    (MessageBox.Show("Local?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button1) == DialogResult.Yes))
                {
                    // check1

                    try
                    {
                        dbFile = new System.IO.FileInfo(String.Concat(ReportsPrinting.Properties.Resources.dbServerPathLocal, "\\", ReportsPrinting.Properties.Resources.dbName));
                        if (dbFile.Exists)
                        {
                            //lblHeader.Text += " LOCAL";
                            lblHeader.ForeColor = Color.Red;
                            db = new dbConnection3(dbFile.Name, dbFile.Directory.ToString(), getPassword());
                            return db.isConnected();
                            //return true;
                        }
                    }
                    catch (OleDbException ex)
                    {
                        Console.WriteLine("Error setting up local db: " + ex.ErrorCode + " : " + ex.Message);
                        this.BackColor = Color.Red;
                        return false;
                    }
                }


                dbFile = new System.IO.FileInfo(String.Concat(ReportsPrinting.Properties.Resources.dbServerPath, "\\", ReportsPrinting.Properties.Resources.dbName));
                if (dbFile.Exists)
                {
                    this.BackColor = Color.Olive;
                    //return true;
                }
                else
                {
                    //try local

                    //if ((userName.ToLower() != "palamin") || ((pcName.ToLower() != "palamin") || (pcName.ToLower() != "waeccsdd020")))
                    if (
                        ((this.userName.ToLower() != "palamin") && ((this.pcName.ToLower() != "palamin") || ((this.domain.ToLower() == "ictd") && (this.pcName.ToLower() != "w-ctd19d002")))) ||
                        ((this.domain.ToLower() == "palam") && (this.pcName.ToLower() != "palam")))
                    {
                        MessageBox.Show("There was a problem connecting to the data source, please close program and try again.",
                            "Error Connecting", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }

                    try
                    {
                        dbFile = new System.IO.FileInfo(String.Concat(ReportsPrinting.Properties.Resources.dbServerPathLocal, "\\", ReportsPrinting.Properties.Resources.dbName));
                        if (dbFile.Exists)
                        {
                            //lblHeader.Text += " LOCAL";
                            lblHeader.ForeColor = Color.Red;
                            db = new dbConnection3(ReportsPrinting.Properties.Resources.dbName, ReportsPrinting.Properties.Resources.dbServerPathLocal, getPassword());
                            return db.isConnected();
                        }
                        else
                        {

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
                return false;
            }

            //db = new dbConnection3(Properties.Resources.dbName, Properties.Resources.dbPath, getPassword());
            db = new dbConnection3(dbFile.Name, dbFile.Directory.ToString(), getPassword());
            return db.isConnected();
        }

        private string getPassword()
        {
            return ("CsdPrintDb");
        }

        private void SubjectOption(object sender, EventArgs e)
        {
            scBottom.Panel2Collapsed = true;
            btnLoad.Enabled = true;
        }

        private void scBottom_Panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panelSelected_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rbSelectedSubject_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSelectedSubject.Checked)
            {
                panelSelected.Visible = true;
                gbSelectedSubjects.Enabled = true;
                FillInSubjects();
            }
            else if (!rbSelectedCentre.Checked)
            {
                reset();
            }
            
        }

        private void rbSelectedCentre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSelectedCentre.Checked)
            {
                panelSelected.Visible = true;
                gbSelectedCentres.Enabled = true;
            }
            else if (!rbSelectedSubject.Checked)
            {
                reset();
            }
        }

        private void reset()
        {
            btnLoad.Enabled = true;

            panelSelected.Visible = false;
            gbSelectedSubjects.Enabled = false;
            clbSelectedSubjects.Enabled = false;
            gbSelectedCentres.Enabled = false;
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
                dsAdapter.Dispose();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Updating ds - table: " + tableName + " sql: " + sqlStatement + " : " + ex.Message);
            }
            return false;
        }

        private void cbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                selectedSubject = cbSubject.SelectedItem.ToString().Substring(0, 6);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in subjects: " + ex.Message);
            }
            
        }

        private void btnRefreshCrv_Click(object sender, EventArgs e)
        {
            crystalReportViewer1.RefreshReport();
            crystalReportViewer1.Refresh();
        }
    }
}
