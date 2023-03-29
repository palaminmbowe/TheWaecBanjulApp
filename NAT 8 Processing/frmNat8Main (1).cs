using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using NAT8Processing;
using NAT_8_Processing.Utility;
using NAT8Processing.Model;
using WaecUtils;

namespace NAT_8_Processing
{
    public partial class frmNat8Main : Form
    {
        FileInfo currentDBFile;
        Utility.DbConnection db;
        //Utility.DbConnection serverDB;
        string examInitial = "";
        string centreNumber = "";
        string centreName = "";
        string locationString = "";
        string ownerString = "";
        string examYear = "";

        public frmNat8Main()
        {
            InitializeComponent();
        }

        private void FrmNat8Main_Load(object sender, EventArgs e)
        {

        }

        private void ListViewDroppedDatabases_DragDrop(object sender, DragEventArgs e)
        {
            btnClear.PerformClick();
            currentDBFile = null;

            string[] filePath = (string[])e.Data.GetData(DataFormats.FileDrop);
            currentDBFile = new FileInfo(filePath[0]);

            LoadDB();

            // copy file to location: \\svictd\School Entries\NAT DBs
            DirectoryInfo natServerLocation = new DirectoryInfo(String.Concat(@"\\svictd\School Entries\",$"{examYear} ENTRIES\\NAT\\School Databases\\"));
            if(!natServerLocation.Exists)
            {
                natServerLocation.Create();
                if (!natServerLocation.Exists)
                {
                    MessageBox.Show($"Cannot find the destination folder. Kindly check whether it exists.\n({natServerLocation.FullName})", "Cannot Access Directory", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnClear.PerformClick();
                    return;
                }
            }

            FileInfo destinationFile = new FileInfo(String.Concat(natServerLocation.FullName, @"\", $"{examYear}{centreNumber}{currentDBFile.Extension}"));
            if (destinationFile.Exists)
            {
                // get centre from server and compare
                //var serverCentre = CentresUtils.GetCentre("NAT8", int.Parse(centreNumber))[0];

                //var message = $"Centre to process: \n\t{centreNumber} - {centreName} \nRecord in Server: \n\t{serverCentre.CentreNumber} - {serverCentre.CentreName}";

                DialogResult = MessageBox.Show(this, $"The file you are trying to copy already exists. Proceeding will replace it.\n\tYes - Replaces Files\n\tNo - Uses file in server\n\nProceed?", "Please Confirm", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (DialogResult)
                {
                    case DialogResult.None:
                    case DialogResult.Cancel:
                        btnClear.Enabled = true;
                        btnClear.PerformClick();
                        return;
                    case DialogResult.Yes:
                        currentDBFile.CopyTo(destinationFile.FullName, true);
                        break;
                    case DialogResult.No:

                        break;
                    default:
                        break;
                }
            }
            else
            {
                currentDBFile.CopyTo(destinationFile.FullName);
            }

            currentDBFile = destinationFile;

            lbSelectedlDatabaseName.Text = currentDBFile.Name.ToUpper();
            labelDatabaseName.Text = currentDBFile.FullName;

            btnRetrieve.Enabled = true;
            btnSaveToServer.Enabled = true;
            btnSelectFile.Enabled = false;
            lvDetails.Items.Clear();

            btnRetrieve.PerformClick();

            DialogResult = MessageBox.Show(this, $"Data file porcessed successfully. Do you want to save the records?", "Save Records", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            switch (DialogResult)
            {
                case DialogResult.Yes:
                    btnSaveToServer.PerformClick();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }

        }

        private void listViewDroppedDatabases_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
        }

        private void ListViewDroppedDatabases_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveToServer_Click(object sender, EventArgs e)
        {
            //MessageBox.Show( "This will delete and update. Continue?", "Confirm Transfer", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxIcon.Question, MessageBoxIcon.Question);

            //if (DialogResult == DialogResult.Cancel)
            //{
            //    return;
            //}
            if (CheckAndAddCentre(examInitial, centreNumber, centreName, locationString, ownerString))
            {
                Console.WriteLine("Centre Added");
                lvDetails.BackColor = Color.PaleGoldenrod;
            }
            else
            {
                Console.WriteLine("Centre probably exists");
            }


            int centreTotal = CentresUtils.GetCentreTotal("nat8", int.Parse(centreNumber));

            if (centreTotal > 0)
            {
                //int centreTotal = CentresUtils.GetCentreTotal("nat8", int.Parse(centreNumber));
                MessageBox.Show($"CANNOT process centre. It already has {centreTotal} total candidate(s)");
                return;
            }

            DataSet ds = new DataSet();
            
            // load the data 
            // fetch data from db
            db = new Utility.DbConnection(currentDBFile, "", currentDBFile.Extension == ".mdb" ? Utility.DbConnection.TypeOfDatabase.AccessMDB : Utility.DbConnection.TypeOfDatabase.AccessACCDB);

            // build and run query to get data
            //  SELECT "nat8" AS ExamID, "2021" AS ExamYear, NatAdmin.CentNo, NATGRADE8.IndexNo, NATGRADE8.CandName, NATGRADE8.Sex, NATGRADE8.Disability, NATGRADE8.Dob, NATGRADE8.Attempts, NatAdmin.CentName, "username" AS UserName, "pcname" AS PcName, NatAdmin.Location, NatAdmin.Owner
            //  FROM NatAdmin INNER JOIN NATGRADE8 ON NatAdmin.CentNo = NATGRADE8.CentNo;

            db.cmd.CommandText = $"SELECT 'NAT8' AS ExamID, '2021' AS ExamYear, NatAdmin.CentNo, NATGRADE8.IndexNo, NATGRADE8.CandName, " +
                $"NATGRADE8.Sex, NATGRADE8.Disability, NATGRADE8.Dob, NATGRADE8.Attempts, NatAdmin.CentName, '{User.UserName()}' AS UserName, " +
                $"'{User.MachineName()}' AS PcName, NatAdmin.Location, NatAdmin.Owner, NATGRADE8.LastName, NATGRADE8.FirstName, NATGRADE8.Initial " +
                $"FROM NatAdmin INNER JOIN NATGRADE8 ON NatAdmin.CentNo = NATGRADE8.CentNo;";

            // save in data table
            using (db.con)
            {
                OleDbDataAdapter da = new OleDbDataAdapter(db.cmd.CommandText, db.con);
                da.Fill(ds, "NatSourceEntries");
            }

            // reformat data if necessary
            DataTable newTable = new DataTable("NatDestiantionEntries");

            bool firstRow = true;
            int count = 0;

            foreach (DataRow r in ds.Tables["NatSourceEntries"].Rows)
            {
                if (firstRow)
                {
                    // empty centre
                    using (var db = new NAT8Processing.Model.WaecNatEntities())
                    {
                        string examID = r["ExamID"].ToString();
                        string centreNumber = r["CentNo"].ToString();
                        int? examYear = int.Parse(r["ExamYear"].ToString());
                        var result = db.DeleteNatCentre(examID, examYear, centreNumber);
                        Console.WriteLine($"Deleted centre {centreNumber} with result {result}");

                        //var cResult = db.AddNATCentre("6", r["CentNo"].ToString(), r["CentName"].ToString(), r["Location"].ToString(), r["Owner"].ToString());

                        firstRow = false;
                    }
                }

                //Console.WriteLine(r);
                r.BeginEdit();

                //r["Disability"] = r["Disability"].ToString().Equals("0") ? 1 : 2;
                //r["Sex"] = r["Sex"].ToString().Equals("M") ? 1 : 2;

                //r["Examyear"] = GetExamYear();
                string s = r["Sex"].ToString();

                if (r["Sex"].ToString().ToUpper().Equals("M"))
                    r["Sex"] = 1;
                else
                    r["Sex"] = 2;

                string d = r["Disability"].ToString();

                switch (r["Disability"].ToString())
                {
                    case "0":
                        r["Disability"] = 1;
                        break;
                    case "1":
                        r["Disability"] = 2;
                        break;
                    case "2":                        
                    case "3":
                    case "4":
                        r["Disability"] = 3;
                        break;
                    default:
                        r["Disability"] = 0;
                        break;
                }

                r["UserName"] = User.UserName();
                r["PcName"] = User.MachineName();

                switch (r["Location"].ToString())
                {
                    case "U":
                        r["Location"] = 1;
                        break;
                    case "R":
                        r["Location"] = 2;
                        break;                    
                    default:
                        r["Location"] = 0;
                        break;
                }

                r.EndEdit();

                

                if (SaveRecord(r))
                {
                    //Console.WriteLine($"{r} saved.");
                    count++;
                    //lvDetails.BackColor = Color.LightGreen;
                }
            }

            //using (SqlBulkCopy bulkCopy = new SqlBulkCopy(User.EntityConnectionString))
            //{

            //}
            // save to server
            //foreach (DataRow r in ds.Tables["NatSourceEntries"].Rows)
            //{
            //    if (SaveRecord(r))
            //    {
            //        Console.WriteLine($"{r} saved.");
            //        lvDetails.BackColor = Color.LightGreen;
            //    }
            //    //else
            //    //    return;
            //}
            lvDetails.BackColor = Color.LightGreen;
            MessageBox.Show($"Saving Completed. A total of {count} record{(count > 1 ? "s" : "")} processed.", "Transfer Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool SaveRecord(DataRow r)
        {
            //string s = r["Sex"].ToString();
            //string d = r["Disability"].ToString();
            //User.IctdConnectionString

            using (var cnn = new SqlConnection(UserUtils.ConnectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                {
                    SelectCommand = new SqlCommand("nat.uspNatInsertUpdateDeleteEntry2", cnn)
                };

                //SELECT 'NAT8' AS ExamID, '2021' AS ExamYear, NatAdmin.CentNo, NATGRADE8.IndexNo, NATGRADE8.CandName, " +
                //$"NATGRADE8.Sex, NATGRADE8.Disability, NATGRADE8.Dob, NATGRADE8.Attempts, NatAdmin.CentName, 'username' AS UserName, " +
                //$"'pcname' AS PcName, NatAdmin.Location, NatAdmin.Owner "

                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@examID", r["ExamID"]);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@examYear", int.Parse(r["ExamYear"].ToString()));
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@centreNumber", r["CentNo"]);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@IndexNumber", r["IndexNo"]);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@candidateName", r["CandName"]);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@sexID", int.Parse(r["Sex"].ToString()));
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@disabilityID", int.Parse(r["Disability"].ToString()));
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@dateOfBirth", r["Dob"]);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@attempts", int.Parse(r["Attempts"].ToString()));
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@userName", r["UserName"]);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@pcName", r["PcName"]);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@StatementType", "INSERT");
                // NATGRADE8.LastName, NATGRADE8.FirstName, NATGRADE8.Initial
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@candidateFirstName", r["FirstName"]);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@candidateLastName", r["LastName"]);
                sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@candidateInitial", r["Initial"]);

                sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

                int result = 0;

                if(sqlDataAdapter.SelectCommand.Connection.State == ConnectionState.Closed)
                {
                    sqlDataAdapter.SelectCommand.Connection.Open();
                }

                try
                {
                    result = sqlDataAdapter.SelectCommand.ExecuteNonQuery();
                    sqlDataAdapter.SelectCommand.Connection.Close();
                    return true;
                }
                catch (Exception)
                {
                    Console.WriteLine($"Error saving. Please check.");
                    //MessageBox.Show($"Error saving. Please check. Maybe data already exists.");
                    return false;
                }
            }

            
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            lvDetails.Items.Clear();

            if (!LoadDB())
            {
                MessageBox.Show(this, $"Are you sure that : {currentDBFile.Name} is a NAT Database?\n\nPlease check and try again.");
                btnSaveToServer.Enabled = false;
            }
            else
                btnSaveToServer.Enabled = true;
        }

        private bool LoadDB()
        {
            // check the extention of file
            //if (!currentDBFile.Exists)
            //    return false;

            // connect to database
            db = new Utility.DbConnection(currentDBFile, "", currentDBFile.Extension == ".mdb" ? Utility.DbConnection.TypeOfDatabase.AccessMDB : Utility.DbConnection.TypeOfDatabase.AccessACCDB);

            
            // build and run query to get data
            db.cmd.CommandText = "SELECT Left([NATGRADE8.CentNo],1) AS Grade, NATGRADE8.CentNo AS SchoolNumber, NatAdmin.CentName AS SchoolName, Count(NATGRADE8.IndexNo) AS Total, Year(Now()) as cYear, Month(Now()) as cMonth, NatAdmin.Location, NatAdmin.Owner " +
                "FROM NatAdmin INNER JOIN NATGRADE8 ON NatAdmin.CentNo = NATGRADE8.CentNo " +
                "GROUP BY Left([NATGRADE8.CentNo],1), NATGRADE8.CentNo, NatAdmin.CentName, NatAdmin.Location, NatAdmin.Owner;";
            //Update ListView with query result

            //string examInitial = "";
            //string centreNumber = "";
            //string centreName = "";
            //string locationString = "";
            //string ownerString = "";


            try
            {
                if (db.con.State == ConnectionState.Closed)
                {
                    db.con.Open();
                }
                
                db.dr = db.cmd.ExecuteReader();

                while(db.dr.Read())
                {
                    // received some rows, populate list view
                    lvDetails.Items.Add(new ListViewItem(new string[] { GetExamYear(db.dr["cYear"].ToString(), db.dr["cMonth"].ToString()), db.dr["Grade"].ToString(), db.dr["SchoolNumber"].ToString(), db.dr["SchoolName"].ToString(), db.dr["Total"].ToString() }));
                    //string[] myItems = {GetExamYear(db.dr[4].ToString(),db.dr[5].ToString()), db.dr[0].ToString(), db.dr[1].ToString(), db.dr[2].ToString(), db.dr[3].ToString(),
                    //    "", "" };
                    //ListViewItem items = new ListViewItem(myItems);
                    //lvDetails.Items.Add(items);

                    // ADD Centre
                    examInitial = db.dr["Grade"].ToString();
                    centreNumber = db.dr["SchoolNumber"].ToString();
                    centreName = db.dr["SchoolName"].ToString();
                    locationString = db.dr["Location"].ToString();
                    ownerString = db.dr["Owner"].ToString();
                    examYear = db.dr["cYear"].ToString();
                }

                var serverCentre = CentresUtils.GetCentre("NAT8", int.Parse(centreNumber))[0];
                if (serverCentre != null)
                {
                    var message = $"Centre to process: \n\t{centreNumber} - {centreName} \nRecord in Server: \n\t{serverCentre.CentreNumber} - {serverCentre.CentreName}";
                    if (!centreNumber.Equals(serverCentre.CentreNumber.ToString()))
                    {
                        DialogResult = MessageBox.Show(this, $"{message}\n\nThe school name in database does not match exactly with the school name in server.\n\n Do you wan to continue? ",
                            "Please Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (DialogResult == DialogResult.No) return false;
                    }
                }
                                
                btnSaveToServer.Enabled = true;
                btnViewEditCandidates.Enabled = true;
                btnClear.Enabled = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occured connecting to db: {ex.Message}");
                return false;
            }
            finally
            {
                db.con.Close();     // close db
            }
            return true;
        }

        private bool CheckAndAddCentre(string examInitial, string centreNumber, string centreName, string locationString, string ownerString)
        {
            // called stored procedure nat.addcentre and pass values
            if (CentresUtils.DoesCentreExist("nat8", int.Parse(centreNumber)))
            {
                return false;
            }

            try
            {
                using (var db = new WaecNatEntities())
                {
                    var result = db.fAddCentre2(examInitial, centreNumber, centreName, locationString, ownerString).ToList();
                    //Console.WriteLine(result.ToString());
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding centre: {ex.Message}");
            }

            return false;
        }

        private string GetExamYear(string currentYear, string currentMonth)
        {
            int cYear = int.Parse(currentYear);
            // get the exam year using the current year and month
            switch (int.Parse(currentMonth))
            {
                case int i when i >= 9:
                    return (cYear + 1).ToString();
                default:
                    return currentYear;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lvDetails.Items.Clear();
            lvDetails.BackColor = Color.White;
            btnSelectFile.Enabled = true;

            lbSelectedlDatabaseName.Text = "";
            labelDatabaseName.Text = "";

            btnRetrieve.Enabled = false;
            btnSaveToServer.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewEditCandidates_Click(object sender, EventArgs e)
        {
            frmViewEditCandidates frmCandiates = new frmViewEditCandidates(User.EntityConnectionString);
            //frmViewEditCandidates frmCandiates = new frmViewEditCandidates(db.ConnectionString);
            //frmCandiates.Parent = this;
            frmCandiates.ShowDialog(this);
        }

        private void lvDetails_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
