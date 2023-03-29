using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReportsPrinting.Models;
using System.Configuration;
using ReportsPrinting.Reports;
using CrystalDecisions.CrystalReports.Engine;

namespace ICTDUtilities.Reports
{
    public partial class FormReports : Form
    {
        DataSet ds;
        List<ExamReports> examReports;

        SqlDataAdapter sqlDataAdapter;
        // WaecCommonDbContext reportsDB = new WaecCommonDbContext();
        // connection string: Server= waecgmvdbs;Database=WaecCommon;user id=ictdstaff;password=Wa123Ec321;
        // DBContext - <add name="WaecCommonDbContext" connectionString="metadata=res://*/Models.WaecCommonDBContext.csdl|res://*/Models.WaecCommonDBContext.ssdl|res://*/Models.WaecCommonDBContext.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=waecgmvdbs;initial catalog=WaecCommon;user id=ictdstaff;password=Wa123Ec321;MultipleActiveResultSets=True;App=EntityFramework&quot;" providerName="System.Data.EntityClient" />

        public FormReports()
        {
            InitializeComponent();
        }

        private void FormReports_Load(object sender, EventArgs e)
        {
            ds = new DataSet("FormsDS");

            using (var db = new WaecCommonDBEntities())
            {
                // abstract !!!
                try
                {
                    examReports = db.uspExamReports_GetAll().ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading report: {ex.Message}");
                }

                comboBoxExamName.DataSource = (from b in examReports
                                               select new
                                               { b.ExamID, b.ExamShortName }).Distinct().ToList();
                comboBoxExamName.DisplayMember = "ExamShortName";
                comboBoxExamName.ValueMember = "ExamID";
            }
            comboBoxExamName.SelectedIndex = -1;
        }

        private void comboBoxExamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxExamName.SelectedValue.ToString() == null) return;

                // use examReports to filter and select available years
                comboBoxExamYear.DataSource = (from y in examReports
                                               select y.ExamYear).Distinct().ToList();
                comboBoxExamYear.DisplayMember = "ExamYear";
                comboBoxExamYear.ValueMember = comboBoxExamName.DisplayMember;
                
            }
            catch (Exception)
            {
            }
            comboBoxExamYear.SelectedIndex = -1;
        }

        private void comboBoxExamYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxExamYear.SelectedValue.ToString() == null) return;

                comboBoxReports.DataSource = examReports;
                //comboBoxReports.DataSource = examReports.Select (x => 
                //                                                x.ExamName == comboBoxExamName.SelectedValue.ToString() && 
                //                                                x.ExamYear == (int)comboBoxExamYear.SelectedValue).ToList();
                comboBoxReports.DisplayMember = "ReportName";
                comboBoxReports.ValueMember = "ReportID";
                
                
            }
            catch (Exception)
            {
            }
            comboBoxReports.SelectedIndex = -1;
        }

        private void buttonLoadReport_Click(object sender, EventArgs e)
        {
            if(GetAndLoadReportFor(comboBoxExamName.SelectedValue.ToString(), comboBoxExamYear.SelectedValue.ToString(), comboBoxReports.SelectedValue.ToString()))
            {
                //MessageBox.Show("Load complete");
            }
            else
            {
                MessageBox.Show("Error loading report or report not available.");
            }
        }

        private bool GetAndLoadReportFor(string examID, string examYear, string reportID)
        {
            try
            {
                // ???? load report somehow

                // get stored procedure name
                string reportViewName = "";
                string reportSpName = "";
                bool reportViewerAvailable = false;
                string reportPath = "";
                string reportName = "";

                using (var db = new WaecCommonDBEntities())
                {
                    //should return only one row. Interested in the ReportViewName/ReportSpName
                    //var report = db.uspExamReportsSp_GetByExamId_ExamYear_ReportID(examID, int.Parse(examYear), int.Parse(reportID)).ToList();
                    var report = db.uspExamReportsSp_GetByExamId_ExamYear_ReportID(examID, int.Parse(examYear), int.Parse(reportID)).ToList();
                    reportSpName = report[0].ReportSpName;
                    reportViewName = report[0].ReportViewName;
                    reportPath = report[0].ReportPath;
                    
                    reportViewerAvailable = (bool)report[0].ReportViewerAvailable;
                    buttonLoadReport.Enabled = reportViewerAvailable;
                }

                if (reportSpName.Equals("") || reportViewName.Equals(""))
                {
                    // nothing to report
                    MessageBox.Show($"Error loading report: Missing report string (View/SP)");

                    // load in grid view?
                    return false;
                }


                // get data tables
                // view or sp should be ok by here

                DataTable dt = new DataTable();

                // delivery and collection reports !!!!
                using (SqlConnection cnn = new SqlConnection("Server= waecgmvdbs;Database=WaecCommon;user id=ictdstaff;password=Wa123Ec321;"))
                {
                    //sqlDataAdapter = new SqlDataAdapter("common.uspTimetable_GetByExamId_ExamYear", cnn);
                    sqlDataAdapter = new SqlDataAdapter();
                    sqlDataAdapter.SelectCommand = new SqlCommand(reportSpName, cnn);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ExamID", examID);
                    sqlDataAdapter.SelectCommand.Parameters.AddWithValue("@ExamYear", int.Parse(examYear));
                    sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sqlDataAdapter.Fill(ds, "TimeTable");
                    dt = ds.Tables["TimeTable"];
                    dgvReport.DataSource = dt;
                }

                //--------------------------------------------------------------------------
                //ReportDocument rptdoc = new ReportDocument();
                //rptdoc.Load(Server.MapPath("~\\Reports\\ProjectReport.rpt"));
                //rptdoc.SetDataSource(dt);
                //--------------------------------------------------------------------------

                ReportDocument rpt = new ReportDocument();

                // link tables to report
                switch (int.Parse(reportID))
                {
                    case 1:
                        //collection
                        CollectionOfQuestionPapers cr = new CollectionOfQuestionPapers();
                        cr.Database.Tables["qryGabeceTimeTable"].SetDataSource(dt);
                        cr.VerifyDatabase();
                        cr.Refresh();
                        rpt.Load($"{reportPath}\\{reportName}");
                        crystalReportViewer1.ReportSource = cr;
                        break;
                    case 2:
                        //Delivery
                        DeliveryOfQuestionPapers d = new DeliveryOfQuestionPapers();
                        d.Database.Tables["qryGabeceTimeTable"].SetDataSource(dt);
                        d.VerifyDatabase();
                        d.Refresh();
                        crystalReportViewer1.ReportSource = d;
                        break;
                    default:
                        break;
                }
                
                crystalReportViewer1.Refresh();

                // load report

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in report: {ex.Message}");
            }
            return false;
        }

        private void comboBoxReports_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonViewReport_Click(object sender, EventArgs e)
        {
            if (scReports.Panel1Collapsed)
            {
                scReports.Panel1Collapsed = false;
                scReports.Panel2Collapsed = true;
            }
            else
            {
                scReports.Panel2Collapsed = false;
                scReports.Panel1Collapsed = true;
            }
            
        }
    }
}
