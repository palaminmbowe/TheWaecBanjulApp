using NAT8Processing.Model;
//using NAT8Processing.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using NAT_8_Processing.Utility;
using WaecUtils;
//using UtilityLibraries;

namespace NAT_8_Processing
{
    public partial class frmViewEditCandidates : Form
    {
        DbConnection db;
        OleDbDataAdapter oledbAdapter;
        OleDbCommandBuilder oledbCmdBuilder;
        DataSet ds = new DataSet();
        DataSet dsChanges;
        List<NatCentresCurrent> bsNatCentresOriginal;

        //SqlDataAdapter sqlAdapter;

        string cnn;

        List<NatEntries> natEntries;

        public frmViewEditCandidates(string connectionString)
        {
            InitializeComponent();
            cnn = connectionString;
            //db = new DbConnection(connectionString);
        }

        //public frmViewEditCandidates() : this(new DbConnection(null, null, DbConnection.TypeOfDatabase.AccessMDB)){}

        private void frmViewEditCandidates_Load(object sender, EventArgs e)
        {
            //load db
            //if(LoadData())
            //{
            //}
            dsNat = new DataSet("NatDataSet");
            bsNatCentresCurrent = new BindingSource();
            bsNatCentresOriginal = new List<NatCentresCurrent>();

            // using ef6
            using (var db = new NAT8Processing.Model.WaecNatEntities(cnn))
            {
                //Exam table
                bsNatCentresOriginal = db.uspNatCentresCurrent().ToList();
                bsNatCentresCurrent.DataSource = bsNatCentresOriginal;
                var totalCandidates = db.uspTotalCandidatesNat8().ToList();
                numericUpDownTotalCandidates.Controls[0].Visible = false;
                numericUpDownTotalCandidates.Value = (int)totalCandidates[0];
            }

            comboBoxExam.DataSource = bsNatCentresCurrent;
            comboBoxExamYear.DataSource = bsNatCentresCurrent;
        }

        //private bool LoadData()
        //{
        //    //connect to db, build sql to get data, load data to data grid view.
        //    //string sql = "SELECT NATGRADE8.CentNo, NATGRADE8.IndexNo, NATGRADE8.CandName, NATGRADE8.LastName, NATGRADE8.FirstName, NATGRADE8.Initial, NATGRADE8.Sex, NATGRADE8.Disability, NATGRADE8.Dob, NATGRADE8.Attempts " +
        //    //    "FROM NATGRADE8; ";

        //    string sql = "SELECT NATGRADE8.CentNo, NATGRADE8.IndexNo, NATGRADE8.CandName, NATGRADE8.Sex, NATGRADE8.Disability, NATGRADE8.Dob, NATGRADE8.Attempts " +
        //        "FROM NATGRADE8 " +
        //        "GROUP BY NATGRADE8.CentNo, NATGRADE8.IndexNo, NATGRADE8.CandName, NATGRADE8.Sex, NATGRADE8.Disability, NATGRADE8.Dob, NATGRADE8.Attempts; ";

        //    try
        //    {
        //        try{db.con.Open();}
        //        catch (OleDbException ex){ Console.WriteLine(ex.Message);}

        //        oledbAdapter = new OleDbDataAdapter(sql, db.con);
        //        oledbAdapter.Fill(ds);
        //        dataGridViewCandidates.DataSource = ds.Tables[0];

        //        dataGridViewCandidates.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

        //        return true;
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"\n*** Error! ***\nMethod: {e.TargetSite}\nMessage: {e.Message}\nSource: {e.Source}");
        //    }

        //    return false;
        //}

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if(SaveChanges())
            {
                MessageBox.Show("Changes saved successfully");
            }
        }

        private bool SaveChanges()
        {
            dsChanges = ds.GetChanges();
            oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
            
            try
            {
                if (dsChanges != null)
                {
                    //foreach (DataRow dr in dsChanges.Tables[0].Rows)
                    //{
                    //    dsChanges.Tables[0].Rows[0]["CandName"] = $"{dr["LastName"]} {dr["FirstName"]} {dr["Initial"]}".Trim().ToUpper();
                    //}

                    oledbAdapter.Update(ds.Tables[0]);
                }
                ds.AcceptChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"\n*** Error! ***\nMethod: {e.TargetSite}\nMessage: {e.Message}\nSource: {e.Source}");
            }

            return false;
        }

        private void dataGridViewCandidates_RowLeave(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            //using (var db = new WaecNatEntities())
            //{
            //    //load centres
            //}
            listBoxCentres.DataSource = bsNatCentresCurrent;
        }

        private void examYearsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listBoxCentres_DoubleClick(object sender, EventArgs e)
        {
            //string m = User.ConnectionStringOther();
            // load centre in gridview
            using (var db = new NAT8Processing.Model.WaecNatEntities(User.EntityConnectionString))
            {
                //Exam table
                var examYear = int.Parse(comboBoxExamYear.SelectedValue.ToString());
                natEntries = db.uspNatEntriesByExamIDExamYearCentreNumber(comboBoxExam.SelectedValue.ToString(), examYear, listBoxCentres.SelectedValue.ToString()).ToList<NatEntries>();
                bsNatEntries.DataSource = natEntries;
            }

            dataGridViewCandidates.DataSource = (from d in natEntries
                                                 select new {d.ExamYear, d.CentreNumber, d.IndexNumber, d.CandidateName,
                                                 d.SexID, d.DisabilityID, d.DateOfBirth, d.Attempts}
                                                 ).Distinct().ToList();
            dataGridViewCandidates.Visible = true;
            buttonPrint.Enabled = true;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                using (SqlConnection cnn = new SqlConnection(UserUtils.CommonDbConnectionString))
                {
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter
                    {
                        SelectCommand = new SqlCommand("nat.uspNatEntriesByExamIDExamYearCentreNumber", cnn)
                    };
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ExamID", comboBoxExam.SelectedValue);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ExamYear", int.Parse(comboBoxExamYear.SelectedValue.ToString()));
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@CentreNumber", int.Parse(listBoxCentres.SelectedValue.ToString()));
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.Fill(ds, "NatEntry");
                }

                // table should be available. Call form and pass it.
                FormPrint fp = new FormPrint(ds.Tables["NatEntry"]);
                fp.ShowDialog();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting data for reports: {ex.Message}");
                MessageBox.Show($"Error Loading report to print.");
            }
        }

        private void listBoxCentres_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bsNatCentresCurrent.Count == 0) return;

            try
            {
                comboBoxCentreNumber.Items.Clear();
                comboBoxCentreNumber.Items.Add(listBoxCentres.SelectedValue);
                comboBoxCentreNumber.SelectedIndex = 0;
                dataGridViewCandidates.Visible = false;
                lblTotalCentresReceived.Text = listBoxCentres.Items.Count.ToString();
            }
            catch (Exception)
            {
                // searching might return null
            }
            
        }

        private void listBoxCentres_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void comboBoxCentreNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //BindingSource bsSearch = new BindingSource();
            //bsSearch.DataSource =
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            string searchString = textBoxSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchString) || string.IsNullOrWhiteSpace(searchString))
            {
                // nothing to search for
                if (listBoxCentres.DataSource != bsNatCentresCurrent) 
                {
                    bsNatCentresCurrent.DataSource = bsNatCentresOriginal;
                    listBoxCentres.DataSource = bsNatCentresCurrent;
                    return;
                }
            }
            
            switch (int.TryParse(searchString, out _))
            {
                case true:
                    // search using centreNumber
                    bsNatCentresCurrent.DataSource = (from c in bsNatCentresOriginal
                                                      where c.CentreNumber.Contains($"{searchString}")
                                                      select c
                                                 ).ToList();
                    break;
                default:
                    // search using centreName
                    bsNatCentresCurrent.DataSource = (from c in bsNatCentresOriginal
                                                      where c.CentreName.ToLower().Contains(searchString.ToLower())
                                                      select c  
                                                 ).ToList();
                    break;
            }

            listBoxCentres.SelectedIndex = -1;

            if (bsNatCentresCurrent.Count > 0)
                listBoxCentres.SelectedIndex = 0;
            else
                comboBoxCentreNumber.SelectedIndex = -1;
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("search...")) textBoxSearch.Text = "";
        }
    }
}
