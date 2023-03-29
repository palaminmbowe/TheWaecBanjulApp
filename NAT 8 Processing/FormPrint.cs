using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAT8Processing.Reports;

namespace NAT_8_Processing
{
    public partial class FormPrint : Form
    {
        DataTable sourceTable;
        //public FormPrint()
        //{
        //    InitializeComponent();
        //}
        public FormPrint(DataTable dt)
        {
            InitializeComponent();

            sourceTable = dt;
        }


        private void FormPrint_Load(object sender, EventArgs e)
        {
            // setup and load report
            NAT8Processing.Reports.rptCandidates cr = new NAT8Processing.Reports.rptCandidates();
            cr.Database.Tables["vGetNatCandidates"].SetDataSource(sourceTable);
            cr.VerifyDatabase();
            //cr.Refresh();
            crystalReportViewer1.ReportSource = cr;
            crystalReportViewer1.Refresh();
        }
    }
}
