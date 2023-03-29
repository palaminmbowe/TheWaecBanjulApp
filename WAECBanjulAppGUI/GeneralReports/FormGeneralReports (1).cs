using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaecUtils;
using WaecBanjulModels;

namespace WAECBanjulAppGUI.GeneralReports
{
    public partial class FormGeneralReports : Form
    {
        DataTable dataGridViewReportsTable;
        List<ExamReports> examReports;
        bool initialLoadCompleted = false;
        ExamReports currentReport = null;

        public FormGeneralReports()
        {
            InitializeComponent();
        }

        private void FormGeneralReports_Load(object sender, EventArgs e)
        {
            LoadInitialData();
        }

        private bool LoadInitialData()
        {
            try
            {
                //var exams = ExamsUtils.GetExams();
                //comboBoxExamID.DataSource = exams;
                //comboBoxExamID.DisplayMember = "ExamShortName";
                //comboBoxExamID.ValueMember = "ExamID";

                if (examReports == null) RefreshReport();

                var db = examReports.Select(er =>
                                    new { er.ExamID, er.ExamName, er.ExamShortName }).Distinct().ToList();

                comboBoxExamID.DataSource = db;
                comboBoxExamID.DisplayMember = "ExamShortName";
                comboBoxExamID.ValueMember = "ExamID";

                comboBoxExamID.SelectedIndex = -1;
                Clear(1);
                initialLoadCompleted = true;
                return true;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error in Load - {ex.Message}");
            }
            
            return false;
        }

        private void ComboBoxExamID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (initialLoadCompleted)
                try
                {
                    if(examReports == null) RefreshReport();

                    var reportYears = examReports.Select(er =>
                                        new {er.ExamYear}).Distinct().ToList();

                    comboBoxExamYear.DataSource = reportYears;
                    comboBoxExamYear.DisplayMember = "ExamYear";
                    comboBoxExamYear.ValueMember = "Examyear";
                    comboBoxExamYear.SelectedIndex = -1;
                    Clear(1);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($" Error in Load - {ex.Message}");
                }
        }

        private void ComboBoxExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            LoadReportList();
        }

        private bool RefreshReport()
        {
            try
            {
                examReports = ReportUtils.GetExamReports();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error refreshing: {0}", ex.Message);
            }
            return false;
        }

        private bool LoadReportList()
        {
            // get and load report info from db
            try
            {
                if (examReports == null) RefreshReport();

                dataGridViewReportsList.DataSource = examReports.Select(er =>
                                                        new { er.ReportName, er.ReportAvailable, er.ExamID, er.ExamYear, er.ReportID }).
                                                        Where(er => er.ExamID == comboBoxExamID.SelectedValue.ToString() && er.ReportAvailable == true).ToList();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($" Error in Load - {ex.Message}");
            }
            return false;
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            RefreshReport();
        }

        private bool Clear(int option = 0)
        {
            switch (option)
            {
                case 1:
                    // clear data grid view
                    dataGridViewReports.DataSource = null;
                    dataGridViewReportsList.DataSource = null;
                    break;
                default:
                    // clears all forms
                    initialLoadCompleted = false;
                    dataGridViewReports.DataSource = null;
                    dataGridViewReportsList.DataSource = null;
                    examReports = null;
                    if (comboBoxExamYear != null)
                    {
                        comboBoxExamYear.DataSource = null;
                        comboBoxExamYear.Items.Clear(); 
                    }
                    if (comboBoxExamID != null)
                    {
                        comboBoxExamID.DataSource = null;
                        comboBoxExamID.Items.Clear();
                    }
                    LoadInitialData();
                    break;
            }
            return true;
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DataGridViewReportsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewReportsList_CellClick(sender, e);
        }

        private void DataGridViewReportsList_Click(object sender, EventArgs e)
        {

        }

        private void DataGridViewReportsList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //RefreshReport();

            try
            {
                int reportID = int.Parse(dataGridViewReportsList.Rows[e.RowIndex].Cells["ReportID"].FormattedValue.ToString());
                var selectedReport = examReports.Where(r => r.ReportID == reportID).ToList();
                currentReport = selectedReport[0];
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}");
            }

            //Clear datagridvies
            dataGridViewReports.DataSource = null;
        }

        private void ButtonLoadReport_Click(object sender, EventArgs e)
        {
            textBoxSearch.Text = "Search...";
            if (LoadReport()) 
            {
                textBoxSearch.Enabled = true;
            };

        }

        private bool LoadReport()
        {
            try
            {
                // get list of parameters
                string[] rParameters = currentReport.ReportSpParameters.Split(',');
                List<string> rParamsreportParameterValues = new List<string>();
                foreach (var p in rParameters)
                {
                    if (p.Equals("ExamID"))
                    {
                        rParamsreportParameterValues.Add(comboBoxExamID.SelectedValue.ToString());
                    }

                    if (p.Equals("ExamYear"))
                    {
                        rParamsreportParameterValues.Add(comboBoxExamYear.SelectedValue.ToString());
                    }
                }

                // get datatable
                bool result;
                dataGridViewReportsTable = new DataTable();
                (dataGridViewReportsTable, result) = ReportUtils.GetReportDataByStoredProcedure(currentReport, rParamsreportParameterValues);
                // set binding source
                dataGridViewReports.DataSource = dataGridViewReportsTable;
                labelReportTitle.Text = currentReport.ReportName;
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error getting report. Please try again later. Also inform your system administrator.");
            }
            return false;
        }

        private void DataGridViewReportsList_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (LoadReport()) { };
        }

        private void DataGridViewReportsList_MouseDown(object sender, MouseEventArgs e)
        {
            RefreshReport();
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if(SearchDatagrid(textBoxSearch.Text.Trim()))
            {
                // Search must have been successful.
            }
            else
            {
                // no results from search
            }
        }

        private bool SearchDatagrid(string s)
        {
            if (string.IsNullOrEmpty(s) || string.IsNullOrWhiteSpace(s))
            {
                dataGridViewReports.DataSource = dataGridViewReportsTable;
                return true;
            }

            DataTable t = dataGridViewReportsTable.Copy();
            t.Clear();

            try
            {
                //((DataTable)dataGridViewReports.DataSource).DefaultView.RowFilter = string.Format("{0}", s);
                foreach (DataRow r in dataGridViewReportsTable.Rows)
                {
                    foreach (DataColumn c in dataGridViewReportsTable.Columns)
                    {
                        string value = r[c.ColumnName].ToString().ToLower();
                        if (value.Contains(s.ToLower()))
                        {
                            t.ImportRow(r);
                        }
                    }
                }
                if (t.Rows.Count > 0)
                    dataGridViewReports.DataSource = t;

                dataGridViewReports.Update();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            switch (int.TryParse(s, out _))
            {
                case true:
                    // search using number

                    //bsNatCentresCurrent.DataSource = (from c in bsNatCentresOriginal
                    //                                  where c.CentreNumber.Contains($"{s}")
                    //                                  select c
                    //                             ).ToList();
                    return true;
                default:
                    // search using centreName
                    //bsNatCentresCurrent.DataSource = (from c in bsNatCentresOriginal
                    //                                  where c.CentreName.ToLower().Contains(s.ToLower())
                    //                                  select c
                    //                             ).ToList();
                    
                    return true;
            }

            return false;
        }

        private void textBoxSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text.Equals("Search...")) textBoxSearch.Text = "";
        }
    }
}
