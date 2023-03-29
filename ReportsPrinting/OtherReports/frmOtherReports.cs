using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaecLibrary;
using System.Data.OleDb;
using ReportsPrinting.Other_Reports;

namespace ReportsPrinting.Other_Reports
{
    public partial class frmOtherReports : Form
    {
        private DataSet ds;

        private dbConnection3 db = new dbConnection3();

        System.IO.FileInfo dbFile;
        string userName, pcName, domain;
        List<string> Exams;
        List<string> ReportName;
        List<string> ReportNameSql;

        public frmOtherReports()
        {
            InitializeComponent();
            domain = Environment.UserDomainName.ToString();
            userName = Environment.UserName.ToString();
            pcName = Environment.MachineName.ToString();

            if (!generateConnectionString())
            {
                MessageBox.Show("Error connecting to db", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxExam.SelectedItem.ToString())
            {
                case "NAT 3":
                    break;
                case "":
                    break;
                case "NAT 5":
                    break;
                case "NAT 8":
                    break;
                case "GABECE PC":
                    break;
                case "GABECE SC":
                    break;
                case "WASSCE PC":
                    break;
                case "WASSCE SC":
                    comboBoxReports.Items.Clear();

                    //comboBoxReports.Items.Add("Total Entries");
                    //comboBoxReports.Items.Add("Subjects");
                    //comboBoxReports.Items.Add("Schools");
                    //report names in ReportName
                    foreach (string s in ReportName)
                    {
                        comboBoxReports.Items.Add(s);
                    }
                    break;
                default:
                    break;
            }
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            /*NAT 3
            NAT 5
            NAT 8
            GABECE PC
            GABECE SC
            WASSCE PC
            WASSCE SC*/

            if (SearchAndLoadReport())
            {
                //report found and loaded
            }

            //switch (comboBoxExam.SelectedItem.ToString())
            //{
            //    case "NAT 3":
            //        break;
            //    case "":
            //        break;
            //    case "NAT 5":
            //        break;
            //    case "NAT 8":
            //        break;
            //    case "GABECE PC":
            //        break;
            //    case "GABECE SC":
            //        break;
            //    case "WASSCE PC":
            //        break;
            //    case "WASSCE SC":
            //        if (LoadWassceScReports())
            //        {
            //            // Load CR
            //        }
            //        break;
            //    default:
            //        break;
            //}
        }

        private bool SearchAndLoadReport()
        {
            // Strings are 
            //List<string> Exams;
            //List<string> ReportName;
            //List<string> ReportNameSql;

            for (int i = 0; i < ReportName.Count; i++)
            {
                if(comboBoxReports.SelectedItem.Equals(ReportName[i]))
                {
                    List<string> sqlStatements;
                    string[] tableNames;
                    string errorMessage = "";

                    tableNames = new string[] { ReportName[i]};

                    sqlStatements = new List<string>();
                    sqlStatements.Add(ReportNameSql[i]);

                    if (!UpdateDataset(tableNames, sqlStatements, out errorMessage))
                    {
                        MessageBox.Show($"Error loading report: {errorMessage}");
                        return false;
                    }

                    if (!LoadDataGridView(ds.Tables[tableNames[0]], out errorMessage))
                    {
                        MessageBox.Show($"Error loading report: {errorMessage}");
                        return false;
                    }
                    return true;
                }
            }

            return false;
        }

        private bool LoadWassceScReports()
        {
            List<string> sqlStatements;
            string[] tableNames;// = { "WassceSubjects" };
            string errorMessage = "";

            switch (comboBoxReports.SelectedItem.ToString())
            {
                case "Total Entries":
                    try
                    {
                        tableNames = new string[]{ "TotalEntries" };
                        {
                            //crystalReportViewer1.ReportSource = null;
                            //crpTotalEntriesWASSCESC cr = new crpTotalEntriesWASSCESC();

                            ////check constraints
                            ////sqlStatements.Add("Select ExamYear, CentNo, IndexNo, CandName, Sex FROM [02OUTWassce];");
                            //sqlStatements.Add(@"SELECT [02OUTWassce].ExamYear, CentresWassce.CentNo, CentresWassce.Description, Count([02OUTWassce].IndexNo) AS Total " +
                            //                    "FROM CentresWassce INNER JOIN 02OUTWassce ON CentresWassce.CentNo = [02OUTWassce].CentNo " +
                            //                    "GROUP BY [02OUTWassce].ExamYear, CentresWassce.CentNo, CentresWassce.Description;");
                            //sqlStatements.Add(@"SELECT [02OUTWassce].ExamYear, [02OUTWassce].CentNo, [02OUTWassce].Sex, Count([02OUTWassce].IndexNo) AS TotalMales " +
                            //                    "FROM 02OUTWassce " +
                            //                    "WHERE ((([02OUTWassce].Sex)='1')) " +
                            //                    "GROUP BY [02OUTWassce].ExamYear, [02OUTWassce].CentNo, [02OUTWassce].Sex;");
                            //sqlStatements.Add(@"SELECT [02OUTWassce].ExamYear, [02OUTWassce].CentNo, [02OUTWassce].Sex, Count([02OUTWassce].IndexNo) AS TotalFemales " +
                            //                    "FROM 02OUTWassce " +
                            //                    "WHERE ((([02OUTWassce].Sex)='2')) " +
                            //                    "GROUP BY [02OUTWassce].ExamYear, [02OUTWassce].CentNo, [02OUTWassce].Sex;");
                        }

                        sqlStatements = new List<string>();
                        sqlStatements.Add("SELECT qryTotalEntriesMFTWSC.* FROM qryTotalEntriesMFTWSC;");

                        if(!UpdateDataset(tableNames, sqlStatements, out errorMessage))
                        {
                            MessageBox.Show($"Error loading report: {errorMessage}");
                            return false;
                        }                        

                        if (!LoadDataGridView(ds.Tables["TotalEntries"], out errorMessage))
                        {
                            MessageBox.Show($"Error loading report: {errorMessage}");
                            return false;
                        }

                        {
                            //cr.VerifyDatabase();
                            //crystalReportViewer1.ReportSource = cr;
                            //crystalReportViewer1.Refresh();

                            //if (LoadCrystalReport(ds, tableNames))
                            //{
                            //    MessageBox.Show(@"Success");
                            //}

                        
                            //string pKey = "CentNo";

                            //// Add relationships
                            //ds.Tables["Total"].PrimaryKey = new DataColumn[1] { ds.Tables["Total"].Columns[pKey] };
                            //ds.Tables["TotalMales"].PrimaryKey = new DataColumn[1] { ds.Tables["TotalMales"].Columns[pKey] };
                            //ds.Tables["TotalFemales"].PrimaryKey = new DataColumn[1] { ds.Tables["TotalFemales"].Columns[pKey] };

                            //DataTable Total = ds.Tables["Total"];
                            //DataTable TotalMales = ds.Tables["TotalMales"];
                            //DataTable TotalFemales = ds.Tables["TotalFemales"];

                            //var query =
                            //    from tblTotal in Total.AsEnumerable()
                            //    join tblTotalMales in TotalMales.AsEnumerable()
                            //        on tblTotal.Field<string>(pKey) equals tblTotalMales.Field<string>(pKey)
                            //    //join tblTotalFemales in TotalFemales.AsEnumerable()
                            //    //    on tblTotal.Field<string>(pKey) equals tblTotalFemales.Field<string>(pKey)
                            //    select new
                            //    {
                            //        ExamYear = tblTotal["ExamYear"],
                            //        CentNo = tblTotal["CentNo"],
                            //        Centname = tblTotal.Field<string>("Description"),
                            //        Total = tblTotal.Field<int>("Total"),
                            //        TotalMales = tblTotalMales.Field<int>("TotalMales")
                            //        //TotalFemales = tblTotalFemales.Field<int>("TotalMales")
                            //    };


                        }

                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error Connecting ds: " + ex.Message);
                    }
                    break;
                case "Subjects":
                    tableNames = new string[]{ "WassceSubjects" };

                    sqlStatements = new List<string>();
                    sqlStatements.Add("SELECT * FROM WassceSubjects;");

                    if (!UpdateDataset(tableNames, sqlStatements, out errorMessage))
                    {
                        MessageBox.Show($"Error loading report: {errorMessage}");
                        return false;
                    }

                    if (!LoadDataGridView(ds.Tables[tableNames[0]], out errorMessage))
                    {
                        MessageBox.Show($"Error loading report: {errorMessage}");
                        return false;
                    }
                    
                    return true;
                case "Schools":
                    tableNames = new string[] { "CentresWassce" };

                    sqlStatements = new List<string>();
                    sqlStatements.Add("SELECT CentNo as SchoolNumber, Description as SchoolName, Address FROM CentresWassce;");

                    if (!UpdateDataset(tableNames, sqlStatements, out errorMessage))
                    {
                        MessageBox.Show($"Error loading report: {errorMessage}");
                        return false;
                    }

                    if (!LoadDataGridView(ds.Tables[tableNames[0]], out errorMessage))
                    {
                        MessageBox.Show($"Error loading report: {errorMessage}");
                        return false;
                    }

                    return true;
                default:
                    break;
            }

            return false;
        }

        private bool UpdateDataset(string[] tableNames, List<string> sqlStatements, out string errorMessage)
        {
            List<OleDbDataAdapter> dsAdapters = new List<OleDbDataAdapter>();

            if (!db.isConnected())
            {
                MessageBox.Show("Error connecting to db");
                errorMessage = "Cannot connect to db";
                return false;
            }

            for (int i = 0; i < sqlStatements.Count; i++)
            {
                try
                {
                    ds.Tables.Remove(tableNames[i]);
                }
                catch (Exception)
                {
                }

                try
                {
                    dsAdapters.Add(new OleDbDataAdapter(sqlStatements[i], db.con));
                    dsAdapters[i].Fill(ds, tableNames[i]);
                    errorMessage = null;
                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading report: {ex.Message}");
                    errorMessage = ex.Message;
                    return false;
                }

            }
            errorMessage = "Error retrieving data from db";
            return false;
        }

        private bool LoadDataGridView(DataTable source, out string errorMessage)
        {
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.DataSource = source;
                dataGridView1.Update();
                errorMessage = "";
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading report: {ex.Message}");
                errorMessage = ex.Message;
            }
            return false;
        }

        //private bool LoadCrystalReport(DataSet ds, string[] tableNames)
        //{

        //}

        private void OtherReports_Load(object sender, EventArgs e)
        {
            ds = new DataSet();
            Exams = new List<string>();
            ReportName = new List<string>();
            ReportNameSql = new List<string>();

            LoadData();

            //exams from db
            foreach (string s in Exams)
            {
                comboBoxExam.Items.Add(s);
            }

            //from db of course
            ReportName.Add("Total Entries");
            ReportNameSql.Add("SELECT qryTotalEntriesMFTWSC.* FROM qryTotalEntriesMFTWSC;");

            ReportName.Add("Subjects");
            ReportNameSql.Add("SELECT GenSubjCode, ShortSubjCode, Description as SubjectName, ShortName FROM WassceSubjects;");

            ReportName.Add("Subjects Details");
            ReportNameSql.Add("SELECT CsdSubjCode, GenSubjCode, TadSubjCode, SubjName, PapType, PaperNo FROM SubjIndexWassce;");

            ReportName.Add("Schools");
            ReportNameSql.Add("SELECT CentNo as SchoolNumber, Description as SchoolName, Address FROM CentresWassce;");

        }

        private void LoadData()
        {
            /*NAT 3
            NAT 5
            NAT 8
            GABECE PC
            GABECE SC
            WASSCE PC
            
            */
            Exams.Add("WASSCE SC");
        }

        private void comboBoxReports_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearGricView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClearReport_Click(object sender, EventArgs e)
        {
            ClearGricView();
        }

        private void ClearGricView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Update();
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
    }
}
