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
using System.Threading;
using System.IO;

namespace ICTDUtilities.OMR
{
    public partial class frmExportSubjects : Form
    {
        dbConnection3 db = new dbConnection3();
        DataSet ds;
        List<string> csdSubjCode;
        string tableName, examYear, grade;
        
        Thread tWorker;

        public frmExportSubjects(List<string> csdSubjCode, string connectionString, string tableName, string examYear)
        {
            InitializeComponent();
            db.connectionString = connectionString;
            this.csdSubjCode = csdSubjCode;
            txtSavePath.Text = ICTDUtilities.Properties.Resources.scannedObjSavePath;

            lbSubjects.Items.AddRange(csdSubjCode.ToArray());
            this.tableName = tableName;
            this.examYear = examYear;
        }

        private void BeginExport()
        {
            try
            {
                // update dataset with subjects
                foreach (string subj in lbSubjects.Items)
                {
                    //if(subj.Length != (int.Parse(Properties.Resources.subjectLength)))
                    //{
                    //    continue;
                    //}

                    
                    //examYear = tableName.Substring(6, 4);
                    grade = tableName.Substring(4, 1);
                    StringBuilder sb = new StringBuilder();

                    string sql = "SELECT examYear, centNo, indexNo, CsdSubjCode, sex, Absent, Data FROM " + tableName +
                        " WHERE CsdSubjCode = '" + subj + "' AND examYear = '" + examYear + "' ORDER BY examYear, CentNo, indexNo;";

                    if (UpdateDs(subj, sql))
                    {
                        // successfully retrieved records, load in rtfDisplay in specified format
                        rtfDisplay.Clear();
                        string currentSubject = "";
                        long count = 0;

                        foreach (DataRow dr in ds.Tables[subj].Rows)
                        {
                            //rtfDisplay.AppendText(string.Concat(dr["centNo"], dr["indexNo"], dr["CsdSubjCode"]));
                            currentSubject = subj;
                            sb.Append(string.Concat(dr["centNo"], dr["indexNo"], dr["CsdSubjCode"]));

                            if ((dr["Absent"] == null) || (dr["Absent"] == ""))
                                //rtfDisplay.AppendText(" ");
                                sb.Append(" ");
                            else
                                //rtfDisplay.AppendText("" + dr["Absent"]);
                                sb.Append("" + dr["Absent"]);

                            if (dr["sex"] == null)
                                //rtfDisplay.AppendText(">");
                                sb.Append(">");
                            else
                                //rtfDisplay.AppendText("" + dr["sexCode"]);
                                sb.Append("" + dr["sex"]);

                            if (dr["Data"] == null)
                                //rtfDisplay.AppendText(" ");
                                sb.Append(" ");
                            else
                                //rtfDisplay.AppendText("" + dr["Data"]);
                                sb.Append("" + dr["Data"]);

                            //rtfDisplay.AppendText("\n");
                            sb.Append("\n");
                            count++;

                            //rtfDisplay.ScrollToCaret();

                        }

                        rtfDisplay.AppendText(sb.ToString());
                        lblTotalLines.Text = "Total records: " + count.ToString();
                        // all done, save file
                        try
                        {
                            FileInfo f = new FileInfo(txtSavePath.Text + "\\" + grade + "\\" + examYear + "\\" +
                                grade + "_" + examYear + "_" + currentSubject + ".txt");

                            DirectoryInfo di = new DirectoryInfo(txtSavePath.Text + "\\" + grade + "\\" + examYear);

                            try
                            {
                                if (!di.Exists)
                                {
                                    di.Create();
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Error creating directory: " + di.FullName + ": " + ex.Message);
                            }

                            rtfDisplay.SaveFile(f.FullName, RichTextBoxStreamType.PlainText);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error saving to file: " + ex.Message);
                            DirectoryInfo di = new DirectoryInfo(txtSavePath.Text + "\\" + grade + "\\" + examYear);
                            
                            if (!di.Exists)
                            {
                                di.Create();
                            }

                            FileInfo f = new FileInfo(di.FullName + "\\" + grade + "_" + examYear + "_" + currentSubject + ".txt");
                            txtSavePath.Text = ICTDUtilities.Properties.Resources.scannedObjSavePathLocal;
                            rtfDisplay.SaveFile(f.FullName, RichTextBoxStreamType.UnicodePlainText);
                        }

                        try
                        {
                            ds.Tables.RemoveAt(ds.Tables.IndexOf(subj));
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("Error removing table: " + tableName + ": " + ex.Message);
                        }
                    }
                    
                }

                // for each subjects load selected subjects in rtfDisplay

                // then save rtfDisplay using path

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving subjects: " + ex.Message);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;

            //try
            //{
            //    if (tWorker.IsAlive)
            //    {
            //        return;
            //    }
            //}
            //catch (Exception)
            //{
            //}

            //tWorker = new Thread(new ThreadStart(BeginExport));
            //tWorker.Start();
            //tWorker.Join();
            fbdSavePath.ShowDialog();
            txtSavePath.Text = fbdSavePath.SelectedPath;
            BeginExport();
        }

        private void frmExportSubjects_Load(object sender, EventArgs e)
        {
            //if (csdSubjCode.Count == 1)
            //{
            //    BeginExport();
            //}
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            DialogResult dr = fbdSavePath.ShowDialog();
            txtSavePath.Text = fbdSavePath.SelectedPath;
        }

        private void lbSubjects_DoubleClick(object sender, EventArgs e)
        {
            //load selected subjects

        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }
    }
}
