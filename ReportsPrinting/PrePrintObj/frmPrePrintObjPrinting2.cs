using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WaecLibrary;
using ReportsPrinting.PrePrintObj.Reports;

namespace ReportsPrinting
{
    public partial class frmPrePrintObjPrinting2 : Form
    {
        dbConnection3 db;
        DataSet ds;
        
        public frmPrePrintObjPrinting2()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new dbConnection3("CSDPrinting.accdb", @"F:\dbs\WAEC\ictd\DBs", "CsdPrintDb");
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            ds = new DataSet("PrePrintObj");
			//string/* qry = @"SELECT TOP 100 qryPrePrintObj.YEAR, qryPrePrintObj.CsdSubjCode, qryPrePrintObj.CentNo, qryPrePrintObj.ExaminationNumber, qryPr*/ePrintObj.IndexNo, qryPrePrintObj.CandName, qryPrePrintObj.Sex, qryPrePrintObj.PapType, qryPrePrintObj.Description FROM qryPrePrintObj ";

			string qry = @"SELECT qryPrePrintObjWassce.YEAR, qryPrePrintObjWassce.CsdSubjCode, qryPrePrintObjWassce.CentNo, qryPrePrintObjWassce.ExaminationNumber, qryPrePrintObjWassce.IndexNo, qryPrePrintObjWassce.CandName, qryPrePrintObjWassce.Sex, qryPrePrintObjWassce.PapType, qryPrePrintObjWassce.Description, qryPrePrintObjWassce.Examination FROM qryPrePrintObjWassce;";

			if (!UpdateDs("qryPrePrintObj", qry))
			{
				return;
			}

            crpPrePrintObjsGPW4 crp = new crpPrePrintObjsGPW4();
			//crp.SetDataSource(ds);
			crp.Database.Tables["qryPrePrintObj"].SetDataSource(ds.Tables["qryPrePrintObj"]);
			crp.Refresh();
            crystalReportViewer1.ReportSource = crp;
            crystalReportViewer1.Update();
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
	}
}
