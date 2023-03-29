using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WaecLibrary;
using System.Data.OleDb;

namespace ICTDUtilities.OMR
{
    public partial class frmCheckQueries : Form
    {
        dbConnection3 db = new dbConnection3();
        DataSet ds;
        DataTable dt;
        DataTable dtNames;

        string centNo, csdSubjCode, ExamYear;

        public frmCheckQueries(string centreNo, string subjCode, DataTable dt)
        {
            InitializeComponent();

            lblCentreNumber.Text = centreNo;
            lblSubject.Text = subjCode;

            centNo = centreNo;
            csdSubjCode = subjCode;

            this.dt = dt;
        }

        public frmCheckQueries(string ExamYear, string centreNo, string subjCode, DataTable dt, dbConnection3 db3)
        {
            InitializeComponent();

            centNo = lblCentreNumber.Text = centreNo;
            csdSubjCode = lblSubject.Text = subjCode;
            this.ExamYear = ExamYear;
            this.db = db3;
            this.dt = dt;

        }

        private bool UpdateDataTable()
        {
            string tableName;
            string sqlStatement;

            // generate table name from centre number passed
            switch (centNo[0])
            {
                case '6':
                    tableName = "02OUTG8";
                    break;
                case '7':
                    tableName = "02OUTGabece";
                    break;
                case '4':
                    tableName = "02OUTPgabece";
                    break;
                case '8':
                    tableName = "02OUTWassce";
                    break;
                case '9':
                    tableName = "02OUTPWassce";
                    break;
                default:
                    tableName = "02OUTG" + centNo[0];
                    break;
            }

            // form sql statement 
            // SELECT [02OUTG3].ExamYear, [02OUTG3].CentNo, [02OUTG3].IndexNo, [02OUTG3].CandName, [02OUTG3].Sex FROM 02OUTG3;

            sqlStatement = "SELECT [" + tableName + "].ExamYear, [" + tableName + "].CentNo, [" + tableName + "].IndexNo, [" + tableName + "].CandName, [" + tableName + "].Sex FROM " + tableName +
                " WHERE [" + tableName + "].ExamYear = '" + ExamYear + "' AND [" + tableName + "].CentNo = '" + this.centNo + "';";

            // pass statement to update ds
            if (UpdateDs("02OUT", sqlStatement))
            {
                // update lblMissingCandidates
                UpdateMisssingCandidatesWithNames();
                return true;
            }
            else
            {
                MessageBox.Show("Failed to load candidate details!", "..: Failed :..",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void UpdateMisssingCandidatesWithNames()
        {
            // load list of missing candidates for subjects from the dt
            lbMissingCandidates.Items.Clear();

            // columns: examYear, centNo, indexNo, CsdSubjCode
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["CsdSubjCode"].ToString() == csdSubjCode)
                {
                    //found a match save it

                    // search for name in ds 02OUT table => dtNames;
                    dtNames = ds.Tables["02OUT"];

                    foreach (DataRow drName in dtNames.Rows)
                    {
                        // look for centNo and index no match
                        if (dr["centNo"].Equals(drName["centNo"]) && dr["indexNo"].Equals(drName["indexNo"]))
                        {
                            lbMissingCandidates.Items.Add("" +
                                dr["centNo"] + "\t" +
                                dr["indexNo"] + "\t" +
                                drName["Sex"] + "\t" +
                                drName["CandName"]
                                );
                            break;
                        }

                    }

                    
                }
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void frmCheckQueries_Load(object sender, EventArgs e)
        {
            if (UpdateDataTable())
            {
                //UpdateMisssingCandidates();
            }
        }

        private void UpdateMisssingCandidates()
        {
            // load list of missing candidates for subjects from the dt
            lbMissingCandidates.Items.Clear();

            // columns: examYear, centNo, indexNo, CsdSubjCode
            foreach (DataRow dr in dt.Rows)
            {
                Console.WriteLine(dr["CsdSubjCode"].ToString());
                if (dr["CsdSubjCode"].ToString() == csdSubjCode)
                {
                    //found a match save it
                    lbMissingCandidates.Items.Add("" + dr["centNo"] + " " + dr["indexNo"]);
                }
            }
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


//SELECT PrePrintObjDetailsWassce.examYear, PrePrintObjDetailsWassce.centNo, PrePrintObjDetailsWassce.indexNo, PrePrintObjDetailsWassce.CsdSubjCode
//FROM PrePrintObjDetailsWassce LEFT JOIN obj_8_2013 ON (PrePrintObjDetailsWassce.examYear = obj_8_2013.examYear) AND (PrePrintObjDetailsWassce.centNo = obj_8_2013.centNo) AND (PrePrintObjDetailsWassce.indexNo = obj_8_2013.indexNo) AND (PrePrintObjDetailsWassce.CsdSubjCode = obj_8_2013.CsdSubjCode)
//WHERE ((obj_8_2013.CsdSubjCode IS NULL) AND (PrePrintObjDetailsWassce.CsdSubjCode = "302343"));