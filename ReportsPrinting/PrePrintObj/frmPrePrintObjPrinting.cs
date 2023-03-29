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
using ReportsPrinting.PrePrintObj.Reports;

namespace ReportsPrinting.PrePrintObj
{

	public partial class frmPrePrintObjPrinting : Form
	{
		private DataSet ds;
		OleDbDataAdapter dsAdapter;
		Exams exam;
		ReportTypes report;
		List<CheckBox> cbAreas = new List<CheckBox>();

		//private dbConnection3 db;
		private WaecLibrary.dbConnection3 db;
		System.IO.FileInfo dbFile;
		string userName, pcName, domain;

  //      crpPrePrintObjsGPW3Sub crGpw3Sub = new crpPrePrintObjsGPW3Sub();
  //      crpPrePrintObjsGPW2 crGpw = new crpPrePrintObjsGPW2();
		//crpPrePrintObjsGPW4 crGpw4 = new crpPrePrintObjsGPW4();
		//crpPrePrintObjsGPW4_new newCrpObj = new crpPrePrintObjsGPW4_new();

		public frmPrePrintObjPrinting(ReportTypes report)
		{
			InitializeComponent();
			this.report = report;
			domain = Environment.UserDomainName.ToString();
			userName = Environment.UserName.ToString();
			pcName = Environment.MachineName.ToString();

			if (!generateConnectionString())
			{
				MessageBox.Show("Error connecting to db", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void scBottom_Panel1_Paint(object sender, PaintEventArgs e)
		{

		}

		private void ExamType_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton rb = (RadioButton)sender;
			clbSelectedCentres.Items.Clear();
			chkbGroupBySubjects.Checked = false;
			chkbGroupByDepot.Checked = false;
			//chkbGroupBySubjects.Visible = false;
			groupBoxGroupOptions.Visible = false;

            if (!rb.Checked)
				return;

			//btnClear.PerformClick();

			lblExam.Text = rb.Text.ToString();

			scBottom.Panel2Collapsed = true;
			btnShow.Text = "<";

			if ((rb.Name != "rbNat") && (rb.Name != "rbNatG3") && (rb.Name != "rbNatG5") && (rb.Name != "rbNatG8"))
			{
				rbNatG3.Checked = false;
				rbNatG5.Checked = false;
				rbNatG8.Checked = false;
				panelNat.Enabled = false;
			}
			else
			{
				//panelNat.Enabled = true;

				if ((rb.Name == "rbNat") && (!rbNatG3.Checked) && (!rbNatG5.Checked) && (!rbNatG8.Checked))
					panelSelected.Visible = false;
				
			}

			switch (rb.Name)
			{
				case "rbGabece":
					// load centres
					exam = Exams.GABECE;
					//MessageBox.Show("Not yet available.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (loadCentres(Exams.GABECE)) { }
					panelSelected.Visible = true;
					chkbGroupBySubjects.Visible = true;
					groupBoxGroupOptions.Visible = true;
					break;
                case "rbPgabece":
                    // load centres
                    exam = Exams.PGABECE;
                    //MessageBox.Show("Not yet available.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (loadCentres(Exams.PGABECE)) { }
                    panelSelected.Visible = true;
                    break;
                case "rbNat":
					// enable group box nats
					panelNat.Enabled = true;
					break;
				case "rbNatG3":
					// load centres
					exam = Exams.NATG3;
					if (loadCentres(Exams.NATG3)) { }
					panelSelected.Visible = true;
					chkbGroupBySubjects.Visible = false;
					groupBoxGroupOptions.Visible = true;
					break;
				case "rbNatG5":
					// load centres
					exam = Exams.NATG5;
					if (loadCentres(Exams.NATG5)) { }
					panelSelected.Visible = true;
					chkbGroupBySubjects.Visible = false;
					groupBoxGroupOptions.Visible = true;
					break;
				case "rbNatG8":
					// load centres
					exam = Exams.NATG8;
					if (loadCentres(Exams.NATG8)) { }
					panelSelected.Visible = true;
					chkbGroupBySubjects.Visible = false;
					groupBoxGroupOptions.Visible = true;
					break;
				case "rbWassce":
					// load centres
					exam = Exams.WASSCE;
					//MessageBox.Show("Not yet available.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (loadCentres(Exams.WASSCE)) { }
					panelSelected.Visible = true;
                    chkbGroupBySubjects.Visible = true;
					groupBoxGroupOptions.Visible = true;
					break;
				case "rbPwassce":
					// load centres
					exam = Exams.PWASSCE;
					//MessageBox.Show("Not yet available.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (loadCentres(Exams.PWASSCE)) { }
					panelSelected.Visible = true;
					break;
				default:
					break;
			}


			

			if ((rbWassce.Checked) || (rbPwassce.Checked))
			{
				panelOral.Visible = true;
				rbExcludeOralArabicFrench.Checked = true;
			}
			else
			{
				panelOral.Visible = false;
				rbExcludeOralArabicFrench.Checked = false;
				rbOralEnglishOnly.Checked = false;
			}
		}

		private void frmPrePrintObjPrinting_Load(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Maximized;
			lblExam.Text = exam.ToString();
			scBottom.Panel2Collapsed = true;
			ds = new DataSet("dsReports");

			ShowHide();
			checkedListBoxDepot.Items.Clear();
			scCentreDepot.Panel2Collapsed = true;

			// uncomment during runtime
			//scBottom.Panel2Collapsed = true;

			cbAreas = new List<CheckBox>();
			cbAreas.Add(cbArea1);
			cbAreas.Add(cbArea2);
			cbAreas.Add(cbArea3);
			cbAreas.Add(cbArea4);
			cbAreas.Add(cbArea5);
			cbAreas.Add(cbArea6);
			cbAreas.Add(cbArea7);

			rbExcludeOralArabicFrench.Checked = true;
			//switch (exam)
			//{
			//    case Exams.GABECE:
			//        rbGabece.Checked = true;
			//        break;
			//    case Exams.NATG3:
			//        rbNat.Checked = true;
			//        rbNatG3.Checked = true;
			//        break;
			//    case Exams.NATG5:
			//        rbNat.Checked = true;
			//        rbNatG5.Checked = true;
			//        break;
			//    case Exams.NATG8:
			//        rbNat.Checked = true;
			//        rbNatG8.Checked = true;
			//        break;
			//    case Exams.PWASSCE:
			//        rbPwassce.Checked = true;
			//        break;
			//    case Exams.WASSCE:
			//        rbWassce.Checked = true;
			//        break;
			//    default:
			//        break;
			//}

			//if (!generateConnectionString())
			//{
			//    MessageBox.Show("Error connecting to db", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
		}

		private bool loadCentres(Exams exam)
		{
			if (!db.isConnected())
			{
				MessageBox.Show("Error connecting to db");
				return false;
			}

			//clear centres

			//based on exam, generate sql
			string sqlStatement = "";
			string tableName = "";
			string sql2 = "";
			string tn2 = "";
			string sql3 = "";
			string tn3 = "";

			switch (exam)
			{
				case Exams.GABECE:
					sqlStatement = "Select CentNo, CentName From CentresGabece";
					tableName = "CentresGabece";
					sql2 = "SELECT Distinct GenSubjcode, ShortName From GabeceSubjects";
					tn2 = "GabeceSubjects";
					sql3 = "SELECT Distinct DepotId, DepotName From DepotGabece";
					tn3 = "DepotGabece";
					break;
                case Exams.PGABECE:
                    sqlStatement = "Select CentNo, CentName From CentresPgabece";
                    tableName = "CentresPgabece";
                    sql2 = "SELECT Distinct GenSubjcode, ShortName From PgabeceSubjects";
                    tn2 = "PgabeceSubjects";
					sql3 = "SELECT Distinct DepotId, DepotName From DepotPgabece";
					tn3 = "DepotPgabece";
					break;
                case Exams.NATG3:
					sqlStatement = "Select CentNo, CentName From CentresNatG3";
					tableName = "CentresNatG3";
					sql2 = "SELECT Distinct GenSubjcode, ShortName From NatSubjects WHERE Left(GenSubjCode, 1) = '3'";
					tn2 = "NatSubjects";
					sql3 = "SELECT Distinct DepotId, DepotName From DepotNat";
					tn3 = "DepotNat";
					break;
				case Exams.NATG5:
					sqlStatement = "Select CentNo, CentName From CentresNatG5";
					tableName = "CentresNatG5";
					sql2 = "SELECT Distinct GenSubjcode, ShortName From NatSubjects WHERE Left(GenSubjCode, 1) = '5'";
					tn2 = "NatSubjects";
					sql3 = "SELECT Distinct DepotId, DepotName From DepotNat";
					tn3 = "DepotNat";
					break;
				case Exams.NATG8:
					sqlStatement = "Select CentNo, CentName From CentresNatG8";
					tableName = "CentresNatG8";
					sql2 = "SELECT Distinct GenSubjcode, ShortName From NatSubjects WHERE Left(GenSubjCode, 1) = '8'";
					tn2 = "NatSubjects";
					sql3 = "SELECT Distinct DepotId, DepotName From DepotNat";
					tn3 = "DepotNat";
					break;
				case Exams.PWASSCE:
					sqlStatement = "Select CentNo, Venue as CentName From CentresPwassce";
					tableName = "CentresPwassce";
					sql2 = "SELECT Distinct GenSubjcode, ShortName From PwassceSubjects";
					tn2 = "PwassceSubjects";
					sql3 = "SELECT Distinct DepotId, DepotName From DepotPwassce";
					tn3 = "DepotPwassce";
					break;
				case Exams.WASSCE:
					sqlStatement = "Select CentNo, Description as CentName From CentresWassce";
					tableName = "CentresWassce";
					sql2 = "SELECT Distinct GenSubjcode, ShortName From WassceSubjects";
					tn2 = "WassceSubjects";
					sql3 = "SELECT Distinct DepotId, DepotName From DepotWassce";
					tn3 = "DepotWassce";
					break;
				default:
                    sqlStatement = "Select CentNo, CentName From Centres" + exam + "";
                    tableName = "Centres" + exam + "";
                    sql2 = "SELECT Distinct GenSubjcode, ShortName From " + exam + "Subjects";
                    tn2 = "" + exam + "Subjects";
					sql3 = $"SELECT Distinct DepotId, DepotName From Depot{exam}";
					tn3 = "Depot{exam}";
					break;
			}

			if (sqlStatement == "") return false;

			try
			{
				dsAdapter = new OleDbDataAdapter(sqlStatement, db.con);

				try
				{
					ds.Tables.Remove(tableName);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}

				dsAdapter.Fill(ds, tableName);

				clbSelectedCentres.Items.Clear();
				clbSelectedSubjects.Items.Clear();

				DataTable dt = ds.Tables[tableName];

				foreach (DataRow dr in dt.Rows)
				{
					clbSelectedCentres.Items.Add(dr["CentNo"] + " - " + dr["CentName"].ToString().Trim(), true);
				}

				clbSelectedSubjects.Items.Add("All Subjects", true);

				//load subjects
				try
				{
					
					if (UpdateDs(tn2, sql2))
					{
						clbSelectedSubjects.Items.Clear();
						cbSubject.Items.Clear();

						dt = ds.Tables[tn2];

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

				//load Depots
				try
				{
					if (UpdateDs(tn3, sql3))
					{
						checkedListBoxDepot.Items.Clear();

						dt = ds.Tables[tn3];

						foreach (DataRow dr in dt.Rows)
						{
							checkedListBoxDepot.Items.Add(dr["DepotID"] + "-" + dr["DepotName"].ToString().Trim(), true);
						}
					}
					else
					{
						MessageBox.Show("Failed to load Depots");
					}
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error loading subjects: " + ex.Message);
				}

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error filling ds: " + ex.Message);
				return false;
			}
		}

		private bool loadCentres(Exams exam, List<string> area)
		{
			if (!generateConnectionString())
			{
				MessageBox.Show("Error connecting to db");
				return false;
			}

			//clear centres

			//based on exam, generate sql
			string sqlStatement = "";
			string tableName = "";

			string whereClause = "WHERE ";

			switch (exam)
			{
				case Exams.GABECE:
                case Exams.PGABECE:
                case Exams.NATG3:
				case Exams.NATG5:
				case Exams.NATG8:
					foreach (string s in area)
					{
						whereClause += "(Mid(CentNo, 2, 1) = " + s;
						if ((area.Count > 1) && (s != area[area.Count - 1]))
							whereClause += " OR ";
					}
					break;
				case Exams.PWASSCE:
				case Exams.WASSCE:
					foreach (string s in area)
					{
						whereClause += "(Mid(CentNo, 3, 1) = " + s;
						if ((area.Count > 1) && (s != area[area.Count - 1]))
							whereClause += " OR ";
					}
					break;
				default:
				 break;
			}

			switch (exam)
			{
				case Exams.GABECE:
					sqlStatement = "Select CentNo, CentName From CentresGabece " + whereClause;
					tableName = "CentresGabece";
					break;
				case Exams.NATG3:
					sqlStatement = "Select CentNo, CentName From CentresNatG3 " + whereClause;
					tableName = "CentresNatG3";
					break;
				case Exams.NATG5:
					sqlStatement = "Select CentNo, CentName From CentresNatG5 " + whereClause;
					tableName = "CentresNatG5";
					break;
				case Exams.NATG8:
					sqlStatement = "Select CentNo, CentName From CentresNatG8 " + whereClause;
					tableName = "CentresNatG8";
					break;
				case Exams.PWASSCE:
					MessageBox.Show("Not Yet Implemented.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
					break;
				case Exams.WASSCE:
					sqlStatement = "Select CentNo, Description as CentName From CentresWassce " + whereClause;
					tableName = "CentresWassce";
					break;
				default:
                    sqlStatement = "Select CentNo, CentName From Centres" + exam + " " + whereClause;
                    tableName = "Centres" + exam + "";
                    break;
			}

			if (sqlStatement == "") return false;

			try
			{
				dsAdapter = new OleDbDataAdapter(sqlStatement, db.con);
				dsAdapter.Fill(ds, tableName);

				clbSelectedCentres.Items.Clear();
				clbSelectedSubjects.Items.Clear();

				DataTable dt = ds.Tables[tableName];

				foreach (DataRow dr in dt.Rows)
				{
					clbSelectedCentres.Items.Add(dr["CentNo"] + " - " + dr["CentName"].ToString().Trim(), true);
				}

				clbSelectedSubjects.Items.Add("All Subjects", true);

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error filling ds: " + ex.Message);
				return false;
			}
		}

		private bool loadSubjects(Exams Exam)
		{
			return false;
		}

		private void reset()
		{
			btnLoad.Enabled = true;

			panelSelected.Visible = false;
			gbSubject.Enabled = false;
			clbSelectedSubjects.Enabled = false;
			gbCentre.Enabled = false;
		}

		private Boolean generateConnectionString()
		{
			// dbName, path, password
			try
			{
				//if (((domain.ToLower() == "palamin") && (pcName.ToLower() == "palamin")) || ((domain.ToLower() == "csd") || (pcName.ToLower() == "waeccsdd020")))
				if (
					(((this.domain.ToLower() == "palamin") && (this.pcName.ToLower() == "palamin")) ||
					((this.domain.ToLower() == "palamin2") && (this.pcName.ToLower() == "palamin2")) ||
                    ((this.domain.ToLower() == "ictd") && (this.pcName.ToLower() == "w-ictd19d002")) ) &&
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
						((this.userName.ToLower() != "palamin") && ((this.pcName.ToLower() != "palamin") || ((this.domain.ToLower() == "csd") && (this.pcName.ToLower() != "waeccsdd020")))) ||
						((this.domain.ToLower() == "csd") && (this.pcName.ToLower() != "sosabou")))
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

		private void btnClearAllCentres_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < clbSelectedCentres.Items.Count; i++)
			{
				clbSelectedCentres.SetItemChecked(i, false);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			btnShow.Enabled = false;
			scBottom.Panel2Collapsed = true;
			crystalReportViewer2.ReportSource = null;
			clbSelectedCentres.Items.Clear();
			clbSelectedSubjects.Items.Clear();
			panelSelected.Visible = false;
			//btnLoad.Visible = false;
			rbGabece.Checked = false;
			rbPgabece.Checked = false;
			rbNat.Checked = false;
			rbNatG3.Checked = false;
			rbNatG5.Checked = false;
			rbNatG8.Checked = false;
			rbPwassce.Checked = false;
			rbWassce.Checked = false;
			panelNat.Enabled = false;
			clbSelectedCentres.Items.Clear();
			
		}

		private void btnSelectAllCentres_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < clbSelectedCentres.Items.Count; i++)
			{
				clbSelectedCentres.SetItemChecked(i, true);
			}
		}

		private void btnLoad_Click(object sender, EventArgs e)
		{
			//get selected centres and pass to retrieve data

			crystalReportViewer2.ReportSource = null;

			List<string> selectedCentres = new List<string>();
			int centreLength = 5;

			if ((exam == Exams.PWASSCE) || (exam == Exams.WASSCE)) 
				centreLength = 7;

			for (int i = 0; i < clbSelectedCentres.Items.Count; i++)
			{
				if (clbSelectedCentres.GetItemChecked(i) == true)
				{
					selectedCentres.Add(clbSelectedCentres.Items[i].ToString().Substring(0, centreLength));
				}
			}

			if (cbSubject.SelectedIndex == 0)
			{
				if (retrievePrePrintData(selectedCentres))
				{
					scBottom.Panel2Collapsed = false;
					setupCrystalReportViewer();
					btnShow.Enabled = true;
				}
			}
			else
			{
				if (retrievePrePrintData(selectedCentres, cbSubject.SelectedItem.ToString()))
				{
					scBottom.Panel2Collapsed = false;
					//setupCrystalReportViewer();
					btnShow.Enabled = true;
				}
			}
		}

		private bool setupCrystalReportViewer()
		{
			//setup crystal report viewer

			try
			{
				//MicroplexPrinter
				if (rbPrinterMicroplex.Checked)
				{
					switch (exam)
					{

						case Exams.NATG3:
						case Exams.NATG5:
						case Exams.NATG8:
							crpPrePrintObjs60E cr = new crpPrePrintObjs60E();
							cr.Database.Tables["qryPrePrintObj"].SetDataSource((DataTable)ds.Tables["qryPrePrintObj"]);
							cr.VerifyDatabase();
							cr.Refresh();
							crystalReportViewer2.ReportSource = cr;
							break;
						case Exams.GABECE:
                        case Exams.PGABECE:
                        case Exams.PWASSCE:
						case Exams.WASSCE:
							//crpPrePrintObjsGPW crGpw = new crpPrePrintObjsGPW();
							//crGpw.Database.Tables["qryPrePrintObj"].SetDataSource((DataTable)ds.Tables["qryPrePrintObj"]);
							//crGpw.VerifyDatabase();
							//crGpw.Refresh();
							//crystalReportViewer1.ReportSource = crGpw;
							break;
						default:
							return false;
					}
				}
				else
				{
					switch (exam)
					{
						case Exams.NATG3:
						case Exams.NATG5:
						case Exams.NATG8:
                            if (chkbGroupByDepot.Checked)
                            {
								crpPrePrintObjsNatNew2_Depot cr = new crpPrePrintObjsNatNew2_Depot();
								cr.Database.Tables["qryPrePrintObj"].SetDataSource(ds.Tables["qryPrePrintObj"]);
								cr.VerifyDatabase();
								cr.Refresh();
								//crystalReportViewer1 = new CrystalReportViewer();
								crystalReportViewer2.ReportSource = cr;
							}
                            else
                            {
								crpPrePrintObjsNatNew2 cr = new crpPrePrintObjsNatNew2();
								cr.Database.Tables["qryPrePrintObj"].SetDataSource(ds.Tables["qryPrePrintObj"]);
								cr.VerifyDatabase();
								cr.Refresh();
								//crystalReportViewer1 = new CrystalReportViewer();
								crystalReportViewer2.ReportSource = cr;
							}
							
							break;
						case Exams.GABECE:
                        case Exams.PGABECE:
                        case Exams.PWASSCE:
						case Exams.WASSCE:
                            if(chkbGroupBySubjects.Checked == true)
                            {
								//crGpw3Sub = new crpPrePrintObjsGPW3Sub();
								//crGpw3Sub.Database.Tables["qryPrePrintObj"].SetDataSource((DataTable)ds.Tables["qryPrePrintObj"]);
								//crGpw3Sub.VerifyDatabase();
								//crGpw3Sub.Refresh();
								////crystalReportViewer1 = new CrystalReportViewer();
								//crystalReportViewer2.ReportSource = crGpw3Sub;

								crpPrePrintObjsGPW4Subject crGpw4D = new crpPrePrintObjsGPW4Subject();
								crGpw4D.Database.Tables[0].SetDataSource(ds.Tables["qryPrePrintObj"]);
								crGpw4D.VerifyDatabase();
								crGpw4D.Refresh();
								crystalReportViewer2.ReportSource = crGpw4D;
							}
							else if (chkbGroupByDepot.Checked)
							{
								crpPrePrintObjsGPW4_Depot crGpw4 = new crpPrePrintObjsGPW4_Depot();
								crGpw4.Database.Tables[0].SetDataSource(ds.Tables["qryPrePrintObj"]);
								crGpw4.VerifyDatabase();
								crGpw4.Refresh();
								crystalReportViewer2.ReportSource = crGpw4;
							}
							else
                            {
								//DataTable table = new DataTable();
								//table = ds.Tables["qryPrePrintObj"];


								//if (table.Equals(null))
								//	MessageBox.Show($"{table.TableName} is null;");

								crpPrePrintObjsGPW4 crGpw = new crpPrePrintObjsGPW4();
								crGpw.Database.Tables["qryPrePrintObj"].SetDataSource(ds.Tables["qryPrePrintObj"]);
								//crGpw.SetDataSource(ds);
								crGpw.VerifyDatabase();
								crGpw.Refresh();
								////crystalReportViewer1 = new CrystalReportViewer();
								crystalReportViewer2.ReportSource = crGpw;

								//ReportsPrinting.PrePrintObj.Reports.crpPrePrintObjsGPW4 crp = new crpPrePrintObjsGPW4();
								//crpTest crp = new crpTest();
								//crpPrePrintObjsGPW4 newReport = new crpPrePrintObjsGPW4();

								//ConnectionInfo ciReportConnection = new ConnectionInfo(db.con.ConnectionString);

								//foreach (Table tbl in newReport.Database.Tables)
								//{
								//	tbl.LogOnInfo.ConnectionInfo
								//}
								//newReport.Database.Tables["qryPrePrintObj"].SetDataSource(ds.Tables["qryPrePrintObj"]);
								//newReport.SetDataSource(ds);
								////crGpw.Database.Tables["qryPrePrintObj"].SetDataSource((DataTable)ds.Tables["qryPrePrintObj"]);
								//newReport.VerifyDatabase();
								//newReport.Refresh();
								//crystalReportViewer2.ReportSource = crp;
							}
                                
							break;
						default:
							return false;
					}
				}

				crystalReportViewer2.Refresh();

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error is setting up Crystal Report: " + ex.Message);
				return false;
			}
		}

		private bool retrievePrePrintData(List<String> centres, string subjectToLoad)
		{
			if (centres.Count < 1) return false;

			//fill ds with preprint data

			string sqlStatement = "";
			string tableName = "";
			string grade = "" + exam.ToString()[exam.ToString().Length - 1];

			switch (exam)
			{
				case Exams.NATG3:
				case Exams.NATG5:
				case Exams.NATG8:
                    if (chkbGroupByDepot.Checked)
                    {
						sqlStatement =
							$"SELECT qryPrePrintObjG8.Year, qryPrePrintObjG8.CsdSubjCode, qryPrePrintObjG8.CentNo, qryPrePrintObjG8.ExaminationNumber, qryPrePrintObjG8.IndexNo, " +
							$"qryPrePrintObjG8.CandName, qryPrePrintObjG8.Sex, qryPrePrintObjG8.PapType, qryPrePrintObjG8.Description, qryPrePrintObjG8.TotSubs, " +
							$"qryPrePrintObjG8.Examination, qryPrePrintObjG8.Disability, CentresNatG8.DepotId, DepotNat.DepotName, DepotNat.Region " +
							$"FROM(qryPrePrintObjG8 INNER JOIN CentresNatG8 ON qryPrePrintObjG8.CentNo = CentresNatG8.CentNo) INNER JOIN DepotNat ON CentresNatG8.DepotId = DepotNat.DepotId;";
                    }
					else
						sqlStatement =
						"SELECT NatPrePrintObjDetails" + exam.ToString()[exam.ToString().Length - 1] + ".ExamYear AS [Year], NatPrePrintObjDetails" +
						grade + ".CsdSubjCode, NatPrePrintObjDetails" + grade +
						".CentNo, (NatPrePrintObjDetails" + grade + ".CentNo + NatPrePrintObjDetails" +
						grade + ".IndexNo) AS ExaminationNumber, NatPrePrintObjDetails" +
						grade + ".IndexNo, NATGRADE" + grade +
						".CandName, NATGRADE" + grade + ".Sex, ('OBJECTIVE') AS PapType, NatSubjects.Description AS Description, 4 AS TotSubs, 'JUNE' AS Examination, NATGRADE" + grade + ".Disability " +
							"FROM NatSubjects INNER JOIN (NatPrePrintObjDetails" + grade +
							" INNER JOIN NATGRADE" + grade + " ON (NatPrePrintObjDetails" + grade +
							".ExamYear = NATGRADE" + grade + ".ExamYear) AND (NatPrePrintObjDetails" + grade +
							".CentNo = NATGRADE" + grade + ".CentNo) AND (NatPrePrintObjDetails" + grade +
							".IndexNo = NATGRADE" + exam.ToString()[exam.ToString().Length - 1] + ".IndexNo)) ON NatSubjects.GenSubjCode = NatPrePrintObjDetails" +
							exam.ToString()[exam.ToString().Length - 1] + ".CsdSubjCode " +
							buildWhereClause(centres, "NatPrePrintObjDetails" + exam.ToString()[exam.ToString().Length - 1] + ".CentNo") + " " +//where clause
							"ORDER BY NatPrePrintObjDetails" + exam.ToString()[exam.ToString().Length - 1] + ".CsdSubjCode, NatPrePrintObjDetails" + exam.ToString()[exam.ToString().Length - 1] + ".CentNo, NatPrePrintObjDetails" + exam.ToString()[exam.ToString().Length - 1] + ".IndexNo; ";



					//sqlStatement =
					//    "SELECT NatPrePrintObjDetails8.ExamYear AS [Year], NatPrePrintObjDetails8.CsdSubjCode, NatPrePrintObjDetails8.CentNo, (NatPrePrintObjDetails8.CentNo + NatPrePrintObjDetails8.IndexNo) AS ExaminationNumber, NatPrePrintObjDetails8.IndexNo, NATGRADE8.CandName, NATGRADE8.Sex, ('OBJECTIVE') AS PapType, NatSubjects.Description AS Description, 4 AS TotSubs, 'JUNE' AS Examination, NATGRADE8.Disability " +
					//        "FROM NatSubjects INNER JOIN (NatPrePrintObjDetails8 INNER JOIN NATGRADE8 ON (NatPrePrintObjDetails8.ExamYear = NATGRADE8.ExamYear) AND (NatPrePrintObjDetails8.CentNo = NATGRADE8.CentNo) AND (NatPrePrintObjDetails8.IndexNo = NATGRADE8.IndexNo)) ON NatSubjects.GenSubjCode = NatPrePrintObjDetails8.CsdSubjCode " +
					//        buildWhereClause(centres, "NatPrePrintObjDetails8.CentNo") + " " +//where clause
					//        "ORDER BY NatPrePrintObjDetails8.CsdSubjCode, NatPrePrintObjDetails8.CentNo, NatPrePrintObjDetails8.IndexNo; ";
					tableName = "qryPrePrintObj";
					break;
				case Exams.PWASSCE:
					sqlStatement =
						"SELECT PrePrintObjDetails" + exam.ToString() + ".ExamYear AS [YEAR], PrePrintObjDetails" + exam.ToString() +
						".CsdSubjCode, PrePrintObjDetails" + exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() +
						".ExaminationNumber, PrePrintObjDetails" + exam.ToString() + ".IndexNo, [02OUT" + exam.ToString() + "].CandName, [02OUT" +
						exam.ToString() + "].Sex, SubjIndex" + exam.ToString() + ".PapType, " + exam.ToString() +
						"Subjects.Description, 'MAY/JUNE' AS Examination " +
						"FROM " + exam.ToString() + "Subjects INNER JOIN (SubjIndex" + exam.ToString() + " INNER JOIN (02OUT" + exam.ToString() +
						" INNER JOIN PrePrintObjDetails" + exam.ToString() + " ON ([02OUT" + exam.ToString() + "].CentNo = PrePrintObjDetails" + exam.ToString() +
						".[CentNo]) AND ([02OUT" + exam.ToString() + "].IndexNo = PrePrintObjDetails" + exam.ToString() + ".IndexNo)) ON SubjIndex" +
						exam.ToString() + ".CsdSubjCode = PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode) ON " + exam.ToString() +
						"Subjects.GenSubjCode = SubjIndex" + exam.ToString() + ".GenSubjCode " +
						buildWhereClause(centres, "PrePrintObjDetails" + exam.ToString() + ".CentNo") + " " +//where clause
						"GROUP BY PrePrintObjDetails" + exam.ToString() + ".ExamYear, PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode, PrePrintObjDetails" +
						exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() + ".ExaminationNumber, PrePrintObjDetails" + exam.ToString() +
						".IndexNo, [02OUT" + exam.ToString() + "].CandName, [02OUT" + exam.ToString() + "].Sex, SubjIndex" + exam.ToString() + ".PapType, " +
						exam.ToString() + "Subjects.Description " +
						"ORDER BY PrePrintObjDetails" + exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode, PrePrintObjDetails" +
						exam.ToString() + ".IndexNo; ";

					tableName = "qryPrePrintObj";
					break;
				case Exams.GABECE:
                case Exams.PGABECE:                
				case Exams.WASSCE:
					sqlStatement =
						"SELECT PrePrintObjDetails" + exam.ToString() + ".ExamYear AS [YEAR], PrePrintObjDetails" + exam.ToString() + 
						".CsdSubjCode, PrePrintObjDetails" + exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() + 
						".ExaminationNumber, PrePrintObjDetails" + exam.ToString() + ".IndexNo, [02OUT" + exam.ToString() + "].CandName, [02OUT" + 
						exam.ToString() + "].Sex, SubjIndex" + exam.ToString() + ".PapType, " + exam.ToString() + 
						"Subjects.Description, 'MAY/JUNE' AS Examination " +
						"FROM " + exam.ToString() + "Subjects INNER JOIN (SubjIndex" + exam.ToString() + " INNER JOIN (02OUT" + exam.ToString() + 
						" INNER JOIN PrePrintObjDetails" + exam.ToString() + " ON ([02OUT" + exam.ToString() + "].CentNo = PrePrintObjDetails" + exam.ToString() + 
						".[CentNo]) AND ([02OUT" + exam.ToString() + "].IndexNo = PrePrintObjDetails" + exam.ToString() + ".IndexNo)) ON SubjIndex" + 
						exam.ToString() + ".CsdSubjCode = PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode) ON " + exam.ToString() + 
						"Subjects.GenSubjCode = SubjIndex" + exam.ToString() + ".GenSubjCode " +
						buildWhereClause(centres, "PrePrintObjDetails" + exam.ToString() + ".CentNo") + " " +//where clause
						"GROUP BY PrePrintObjDetails" + exam.ToString() + ".ExamYear, PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode, PrePrintObjDetails" + 
						exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() + ".ExaminationNumber, PrePrintObjDetails" + exam.ToString() + 
						".IndexNo, [02OUT" + exam.ToString() + "].CandName, [02OUT" + exam.ToString() + "].Sex, SubjIndex" + exam.ToString() + ".PapType, " + 
						exam.ToString() + "Subjects.Description " +                        
						"ORDER BY PrePrintObjDetails" + exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode, PrePrintObjDetails" + 
						exam.ToString() + ".IndexNo; ";

					//sqlStatement =
					//    "SELECT PrePrintObjDetailsWassce.ExamYear AS [YEAR], PrePrintObjDetailsWassce.CsdSubjCode, PrePrintObjDetailsWassce.CentNo, PrePrintObjDetailsWassce.ExaminationNumber, PrePrintObjDetailsWassce.IndexNo, [02OUTWassce].CandName, [02OUTWassce].Sex, SubjIndexWassce.PapType, WassceSubjects.Description, 'MAY/JUNE' AS Examination " +
					//    "FROM WassceSubjects INNER JOIN (SubjIndexWassce INNER JOIN (02OUTWassce INNER JOIN PrePrintObjDetailsWassce ON ([02OUTWassce].CentNo = PrePrintObjDetailsWassce.[CentNo]) AND ([02OUTWassce].IndexNo = PrePrintObjDetailsWassce.IndexNo)) ON SubjIndexWassce.CsdSubjCode = PrePrintObjDetailsWassce.CsdSubjCode) ON WassceSubjects.GenSubjCode = SubjIndexWassce.GenSubjCode " +
					//    "GROUP BY PrePrintObjDetailsWassce.ExamYear, PrePrintObjDetailsWassce.CsdSubjCode, PrePrintObjDetailsWassce.CentNo, PrePrintObjDetailsWassce.ExaminationNumber, PrePrintObjDetailsWassce.IndexNo, [02OUTWassce].CandName, [02OUTWassce].Sex, SubjIndexWassce.PapType, WassceSubjects.Description " +
					//    "ORDER BY PrePrintObjDetailsWassce.CentNo, PrePrintObjDetailsWassce.CsdSubjCode, PrePrintObjDetailsWassce.IndexNo; ";

					tableName = "qryPrePrintObj";
					break;
				default:
					break;
			}

			try
			{
				try
				{
					ds.Tables.Remove("qryPrePrintObj");
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error trying to delete qryPrePrintObj. Probably not there: " + ex.Message);
				}


				dsAdapter = new OleDbDataAdapter(sqlStatement, db.con);
				dsAdapter.Fill(ds, tableName);
				dsAdapter.Dispose();

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error filling ds with preprintObj: " + ex.Message);
				return false;
			}
		}

		private bool retrievePrePrintData(List<String> centres)
		{
			if (centres.Count < 1) return false;

			//fill ds with preprint data

			string sqlStatement = "";
			string tableName = "";
			string grade = "" + exam.ToString()[exam.ToString().Length - 1];

			switch (exam)
			{
				case Exams.NATG3:
				case Exams.NATG5:
				case Exams.NATG8:
					if (chkbGroupByDepot.Checked)
					{
						sqlStatement = $"SELECT * FROM qryPrePrintObjG{exam.ToString().Substring(exam.ToString().Length-1, 1)}Depot {GetSelectedDepots()};";

						//sqlStatement =
						//	$"SELECT qryPrePrintObjG8.Year, qryPrePrintObjG8.CsdSubjCode, qryPrePrintObjG8.CentNo, qryPrePrintObjG8.ExaminationNumber, qryPrePrintObjG8.IndexNo, " +
						//	$"qryPrePrintObjG8.CandName, qryPrePrintObjG8.Sex, qryPrePrintObjG8.PapType, qryPrePrintObjG8.Description, qryPrePrintObjG8.TotSubs, " +
						//	$"qryPrePrintObjG8.Examination, qryPrePrintObjG8.Disability, CentresNatG8.DepotId, DepotNat.DepotName, DepotNat.Region " +
						//	$"FROM(qryPrePrintObjG8 INNER JOIN CentresNatG8 ON qryPrePrintObjG8.CentNo = CentresNatG8.CentNo) INNER JOIN DepotNat ON CentresNatG8.DepotId = DepotNat.DepotId;";
					}
					else
						sqlStatement =
						"SELECT NatPrePrintObjDetails" + grade + ".ExamYear AS [Year], NatPrePrintObjDetails" +
						grade + ".CsdSubjCode, NatPrePrintObjDetails" + grade +
						".CentNo, (NatPrePrintObjDetails" + grade + ".CentNo + NatPrePrintObjDetails" +
						grade + ".IndexNo) AS ExaminationNumber, NatPrePrintObjDetails" +
						grade + ".IndexNo, NATGRADE" + grade +
						".CandName, NATGRADE" + grade + ".Sex, ('OBJECTIVE') AS PapType, NatSubjects.Description AS Description, 4 AS TotSubs, 'JUNE' AS Examination, NATGRADE" + grade + ".Disability " +
							"FROM NatSubjects INNER JOIN (NatPrePrintObjDetails" + grade +
							" INNER JOIN NATGRADE" + grade + " ON (NatPrePrintObjDetails" + grade +
							".ExamYear = NATGRADE" + grade + ".ExamYear) AND (NatPrePrintObjDetails" + grade +
							".CentNo = NATGRADE" + grade + ".CentNo) AND (NatPrePrintObjDetails" + grade +
							".IndexNo = NATGRADE" + grade + ".IndexNo)) ON LeFT(NatSubjects.GenSubjCode, 2) = LEFT(NatPrePrintObjDetails" +
							grade + ".CsdSubjCode, 2) " +
							buildWhereClause(centres, "NatPrePrintObjDetails" + grade + ".CentNo") + " " +//where clause
							"ORDER BY NatPrePrintObjDetails" + grade + ".CsdSubjCode, NatPrePrintObjDetails" + grade + ".CentNo, NatPrePrintObjDetails" + grade + ".IndexNo; ";

					//sqlStatement =
					//    "SELECT NatPrePrintObjDetails8.ExamYear AS [Year], NatPrePrintObjDetails8.CsdSubjCode, NatPrePrintObjDetails8.CentNo, (NatPrePrintObjDetails8.CentNo + NatPrePrintObjDetails8.IndexNo) AS ExaminationNumber, NatPrePrintObjDetails8.IndexNo, NATGRADE8.CandName, NATGRADE8.Sex, ('OBJECTIVE') AS PapType, NatSubjects.Description AS Description, 4 AS TotSubs, 'JUNE' AS Examination, NATGRADE8.Disability " +
					//        "FROM NatSubjects INNER JOIN (NatPrePrintObjDetails8 INNER JOIN NATGRADE8 ON (NatPrePrintObjDetails8.ExamYear = NATGRADE8.ExamYear) AND (NatPrePrintObjDetails8.CentNo = NATGRADE8.CentNo) AND (NatPrePrintObjDetails8.IndexNo = NATGRADE8.IndexNo)) ON NatSubjects.GenSubjCode = NatPrePrintObjDetails8.CsdSubjCode " +
					//        buildWhereClause(centres, "NatPrePrintObjDetails8.CentNo") + " " +//where clause
					//        "ORDER BY NatPrePrintObjDetails8.CsdSubjCode, NatPrePrintObjDetails8.CentNo, NatPrePrintObjDetails8.IndexNo; ";
					tableName = "qryPrePrintObj";
					break;
				case Exams.GABECE:
                case Exams.PGABECE:
				case Exams.PWASSCE:
				case Exams.WASSCE:
					if (chkbGroupByDepot.Checked)
					{
						sqlStatement = $"SELECT * FROM qryPrePrintObj{exam.ToString()}Depot {GetSelectedDepots()};";
						//sqlStatement = $"SELECT * FROM qryPrePrintObjWassceDepot {GetSelectedDepots()};";

						//sqlStatement = $"SELECT YEAR, CsdSubjCode, CentNo, ExaminationNumber, IndexNo, CandName, Sex, PapType, Description, Examination, DepotID, DepotName, SubjectCount FROM qryPreP*/rintObjWassceDepot {GetSelectedDepots()};";
					}
					else
					{
						sqlStatement =
						"SELECT PrePrintObjDetails" + exam.ToString() + ".ExamYear AS [YEAR], PrePrintObjDetails" + exam.ToString() +
						".CsdSubjCode, PrePrintObjDetails" + exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() +
						".ExaminationNumber, PrePrintObjDetails" + exam.ToString() + ".IndexNo, [02OUT" + exam.ToString() + "].CandName, [02OUT" +
						exam.ToString() + "].Sex, SubjIndex" + exam.ToString() + ".PapType, " + exam.ToString() +
						"Subjects.Description, 'MAY/JUNE' AS Examination " +
						"FROM " + exam.ToString() + "Subjects INNER JOIN (SubjIndex" + exam.ToString() + " INNER JOIN (02OUT" + exam.ToString() +
						" INNER JOIN PrePrintObjDetails" + exam.ToString() + " ON ([02OUT" + exam.ToString() + "].CentNo = PrePrintObjDetails" + exam.ToString() +
						".[CentNo]) AND ([02OUT" + exam.ToString() + "].IndexNo = PrePrintObjDetails" + exam.ToString() + ".IndexNo)) ON SubjIndex" +
						exam.ToString() + ".CsdSubjCode = PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode) ON " + exam.ToString() +
						"Subjects.GenSubjCode = SubjIndex" + exam.ToString() + ".GenSubjCode " +
						buildWhereClause(centres, "PrePrintObjDetails" + exam.ToString() + ".CentNo") + " " + //-------------where clause
						"GROUP BY PrePrintObjDetails" + exam.ToString() + ".ExamYear, PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode, PrePrintObjDetails" +
						exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() + ".ExaminationNumber, PrePrintObjDetails" + exam.ToString() +
						".IndexNo, [02OUT" + exam.ToString() + "].CandName, [02OUT" + exam.ToString() + "].Sex, SubjIndex" + exam.ToString() + ".PapType, " +
						exam.ToString() + "Subjects.Description " +
						"ORDER BY PrePrintObjDetails" + exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode, PrePrintObjDetails" +
						exam.ToString() + ".IndexNo; ";
					}
					

					//sqlStatement =
					//    "SELECT PrePrintObjDetailsWassce.ExamYear AS [YEAR], PrePrintObjDetailsWassce.CsdSubjCode, PrePrintObjDetailsWassce.CentNo, PrePrintObjDetailsWassce.ExaminationNumber, PrePrintObjDetailsWassce.IndexNo, [02OUTWassce].CandName, [02OUTWassce].Sex, SubjIndexWassce.PapType, WassceSubjects.Description, 'MAY/JUNE' AS Examination " +
					//    "FROM WassceSubjects INNER JOIN (SubjIndexWassce INNER JOIN (02OUTWassce INNER JOIN PrePrintObjDetailsWassce ON ([02OUTWassce].CentNo = PrePrintObjDetailsWassce.[CentNo]) AND ([02OUTWassce].IndexNo = PrePrintObjDetailsWassce.IndexNo)) ON SubjIndexWassce.CsdSubjCode = PrePrintObjDetailsWassce.CsdSubjCode) ON WassceSubjects.GenSubjCode = SubjIndexWassce.GenSubjCode " +
					//    "GROUP BY PrePrintObjDetailsWassce.ExamYear, PrePrintObjDetailsWassce.CsdSubjCode, PrePrintObjDetailsWassce.CentNo, PrePrintObjDetailsWassce.ExaminationNumber, PrePrintObjDetailsWassce.IndexNo, [02OUTWassce].CandName, [02OUTWassce].Sex, SubjIndexWassce.PapType, WassceSubjects.Description " +
					//    "ORDER BY PrePrintObjDetailsWassce.CentNo, PrePrintObjDetailsWassce.CsdSubjCode, PrePrintObjDetailsWassce.IndexNo; ";

					tableName = "qryPrePrintObj";
					break;
				default:
					break;
			}

			try
			{
				try
				{
					ds.Tables.Remove("qryPrePrintObj");
				}
				catch (Exception ex)
				{
					Console.WriteLine("Error trying to delete qryPrePrintObj. Probably not there: " + ex.Message);
				}


				dsAdapter = new OleDbDataAdapter(sqlStatement, db.con);
				dsAdapter.Fill(ds, tableName);
				dsAdapter.Dispose();

				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error filling ds with preprintObj: " + ex.Message);
				return false;
			}
		}

		private string RetrieveDepotSqlString(Exams ex, List<String> centres, out Boolean success)
        {
			string sqlStatement = "";

            switch (ex)
            {
                
                case Exams.PWASSCE:
					sqlStatement =
						"SELECT PrePrintObjDetails" + exam.ToString() + ".ExamYear AS [YEAR], PrePrintObjDetails" + exam.ToString() +
						".CsdSubjCode, PrePrintObjDetails" + exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() +
						".ExaminationNumber, PrePrintObjDetails" + exam.ToString() + ".IndexNo, [02OUT" + exam.ToString() + "].CandName, [02OUT" +
						exam.ToString() + "].Sex, SubjIndex" + exam.ToString() + ".PapType, " + exam.ToString() +
						"Subjects.Description, 'MAY/JUNE' AS Examination " +
						"FROM " + exam.ToString() + "Subjects INNER JOIN (SubjIndex" + exam.ToString() + " INNER JOIN (02OUT" + exam.ToString() +
						" INNER JOIN PrePrintObjDetails" + exam.ToString() + " ON ([02OUT" + exam.ToString() + "].CentNo = PrePrintObjDetails" + exam.ToString() +
						".[CentNo]) AND ([02OUT" + exam.ToString() + "].IndexNo = PrePrintObjDetails" + exam.ToString() + ".IndexNo)) ON SubjIndex" +
						exam.ToString() + ".CsdSubjCode = PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode) ON " + exam.ToString() +
						"Subjects.GenSubjCode = SubjIndex" + exam.ToString() + ".GenSubjCode " +
						buildWhereClause(centres, "PrePrintObjDetails" + exam.ToString() + ".CentNo") + " " + //-------------where clause
						"GROUP BY PrePrintObjDetails" + exam.ToString() + ".ExamYear, PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode, PrePrintObjDetails" +
						exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() + ".ExaminationNumber, PrePrintObjDetails" + exam.ToString() +
						".IndexNo, [02OUT" + exam.ToString() + "].CandName, [02OUT" + exam.ToString() + "].Sex, SubjIndex" + exam.ToString() + ".PapType, " +
						exam.ToString() + "Subjects.Description " +
						"ORDER BY PrePrintObjDetails" + exam.ToString() + ".CentNo, PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode, PrePrintObjDetails" +
						exam.ToString() + ".IndexNo; ";


					success = true;
					return sqlStatement;
				
				case Exams.NATG3:
				case Exams.NATG5:
				case Exams.NATG8:

					success = false;
					return "";
				case Exams.GABECE:
				case Exams.WASSCE:
                case Exams.PGABECE:

					success = false;
					return "";
				default:
					success = false;
					return "";
			}            
        }

		private string GetSelectedDepots()
		{
			string whereClause = "WHERE ";
			var count = checkedListBoxDepot.CheckedItems.Count;
			List<object> selectedDepots = new List<object>(checkedListBoxDepot.CheckedItems.Cast<object>());

            switch (exam)
            {
                case Exams.NATG3:
                case Exams.NATG5:
                case Exams.NATG8:
					for (int i = 0; i < selectedDepots.Count; i++)
					{
						var temp = selectedDepots[i].ToString().Split('-');
						whereClause += $" DepotID = {temp[0].Trim()}{(i + 1 != selectedDepots.Count ? " OR " : "")} ";
					}

					if (whereClause.Equals("WHERE "))
					{
						return "";
					}
					break;
                default:
					for (int i = 0; i < selectedDepots.Count; i++)
					{
						whereClause += $" DepotID = '{selectedDepots[i].ToString().Substring(0, 3)}'{(i + 1 != selectedDepots.Count ? " OR " : "")} ";
					}

					if (whereClause.Equals("WHERE "))
					{
						return "";
					}
					break;
            }

			return whereClause;
		}

		private string buildWhereClause(List<string> centres, string col)
		{
			//if ((centres.Count == ds.Tables["CentresGabece"].Rows.Count)) // || (centres.Count > 50)
			//    return "";
			string whereClause = " WHERE (";
			string whereClauseS = "";
			bool loadSelectedSubject = false;

			if (cbSubject.SelectedIndex > 0)
			{
				loadSelectedSubject = true;
			}

			if (loadSelectedSubject)
			{
				loadSelectedSubject = true;

				if ((exam == Exams.NATG3) || (exam == Exams.NATG5) || (exam == Exams.NATG8))
				{
					whereClauseS = " WHERE (" + exam.ToString() + "Subjects.GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') ";
					whereClause = " WHERE (" + exam.ToString() + "Subjects.GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (";
				}
				else
				{
					whereClauseS = " WHERE (" + exam.ToString() + "Subjects.GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 6) + "') ";
					whereClause = " WHERE (" + exam.ToString() + "Subjects.GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 6) + "') AND (";
				}
			}
				

			switch (exam)
			{
				case Exams.GABECE:
					if ((centres.Count == ds.Tables["CentresGabece"].Rows.Count) || (centres.Count > 50))
					{
						if(loadSelectedSubject)
							return whereClauseS;
						else
							return "";
					}
						
					break;
				case Exams.NATG3:
					if ((centres.Count == ds.Tables["CentresNatG3"].Rows.Count) || (centres.Count > 50))
					{
						if (loadSelectedSubject)
							return whereClauseS;
						else
							return "";
					}
					else
						return "";
					//break;
				case Exams.NATG5:
					if ((centres.Count == ds.Tables["CentresNatG5"].Rows.Count) || (centres.Count > 50))
					{
						if (loadSelectedSubject)
							return whereClauseS;
						else
							return "";
					}
					break;
				case Exams.NATG8:
					if ((centres.Count == ds.Tables["CentresNatG8"].Rows.Count) || (centres.Count > 50))
					{
						if (loadSelectedSubject)
							return whereClauseS;
						else
							return "";
					}
					break;
				case Exams.PWASSCE:
                    //if ((centres.Count == ds.Tables["CentresGabece"].Rows.Count) || (centres.Count > 50))
                    //    return "";
                    //break;
                    if ((centres.Count == ds.Tables["CentresPwassce"].Rows.Count) || (centres.Count > 50))
                    {
						if (rbExcludeOralEnglish.Checked)
						{
							if (loadSelectedSubject)
								return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode <> '302333')";
							//else
							//    return "";
						}
							//return " WHERE (PrePrintObjDetails.CsdSubjCode <> '302333') ";
						else if (rbOralEnglishOnly.Checked)
						{
							if (loadSelectedSubject)
								return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode = '302333')";
							//else
							//    return "";
						}
							//return " WHERE (PrePrintObjDetails.CsdSubjCode = '302333') ";
						else
                            if (loadSelectedSubject)
                        {
                            //if (loadSelectedSubject)
                            string temp = " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode = '302333')";
                            string gensubjcode = String.Concat(cbSubject.SelectedItem.ToString().Substring(0, 3), "11", cbSubject.SelectedItem.ToString()[5]);
                            return " WHERE (PrePrintObjDetailsPWASSCE.CsdSubjCode = '" + gensubjcode + "') ";
                        }
                                
                        return "";
					}

                    else
                        
                        //    return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + " ";
                    break;

				case Exams.WASSCE:
					if ((centres.Count == ds.Tables["CentresWassce"].Rows.Count) || (centres.Count > 50))
					{
						//if (rbExcludeOralEnglish.Checked)
						//    return " WHERE (PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode <> '302333') ";
						//else if (rbOralEnglishOnly.Checked)
						//    return " WHERE (PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode = '302333') ";
						//else
						//    return "";
						if (rbExcludeOralArabicFrench.Checked)
						{
							if (loadSelectedSubject)
								return " WHERE ((PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode <> '301333') AND " +
									"(PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode <> '304333'))";
						}

						else if (rbExcludeOralEnglish.Checked)
						{
							if (loadSelectedSubject)
								return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (MID(PrePrintObjDetails.CsdSubjCode, 4,2) <> '33')";
							//return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode <> '302333')";
							//else
							//    return "";
						}
						//return " WHERE (PrePrintObjDetails.CsdSubjCode <> '302333') ";
						else if (rbOralEnglishOnly.Checked)
						{
							if (loadSelectedSubject)
								return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode = '302333')";
							//return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode = '302333')";
							//else
							//    return "";
						}
						else if (rbOralArabicOnly.Checked)
						{
							if (loadSelectedSubject)
								return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode = '301333')";
							//return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode = '302333')";
							//else
							//    return "";
						}
						else if (rbOralFrenchOnly.Checked)
						{
							if (loadSelectedSubject)
								return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode = '304333')";
							//return " WHERE (GenSubjCode = '" + cbSubject.SelectedItem.ToString().Substring(0, 2) + "') AND (PrePrintObjDetails.CsdSubjCode = '302333')";
							//else
							//    return "";
						}
						//return " WHERE (PrePrintObjDetails.CsdSubjCode = '302333') ";
						else
							return " ";
					}
						
					break;
				default:
					return "";
			}

			for (int i = 0; i < centres.Count; i++)
			{
				if ((i == 0))
					whereClause += "(" + col + " = '" + centres[i] + "') ";
				else
					whereClause += " OR (" + col + " = '" + centres[i] + "') ";
			}

			whereClause += " ) ";

			if (rbExcludeOralArabicFrench.Checked)
				whereClause += " AND ((PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode <> '301333') AND " +
					"(PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode <> '304333'))";
			else if (rbExcludeOralEnglish.Checked)
				whereClause += " AND (MID(PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode, 4,2) <> '33') ";
			else if (rbOralEnglishOnly.Checked)
				whereClause += " AND (PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode = '302333') ";
			else if (rbOralArabicOnly.Checked)
				whereClause += " AND (PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode = '301333') ";
			else if (rbOralFrenchOnly.Checked)
				whereClause += " AND (PrePrintObjDetails" + exam.ToString() + ".CsdSubjCode = '304333') ";
			else
				whereClause += " ";

			return whereClause;
		}

		private void btnShow_Click(object sender, EventArgs e)
		{
			scBottom.Panel2Collapsed = !scBottom.Panel2Collapsed;
			if (scBottom.Panel2Collapsed == true) btnShow.Text = "<";
			else btnShow.Text = ">";
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private bool ShowHide()
		{
			switch (Environment.UserName.ToLower())
			{
				case "palamin":
				case "mbowe":
				case "sosseh.jagne":
				case "palamin.mbowe":
					gbSelectPrinter.Visible = true;
					break;
				default:
					gbSelectPrinter.Visible = false;
					break;
			}
			return false;
		}

		private void panel5_Paint(object sender, PaintEventArgs e)
		{

		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void AreaCheckedChange(object sender, EventArgs e)
		{

		}

		private void clbSelectedSubjects_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btnClearRbOrals_Click(object sender, EventArgs e)
		{
			rbExcludeOralArabicFrench.Checked = false;
			rbExcludeOralEnglish.Checked = false;
			rbOralEnglishOnly.Checked = false;
			rbOralArabicOnly.Checked = false;
			rbOralFrenchOnly.Checked = false;
		}

		private void chkbGroupBySubjects_CheckedChanged(object sender, EventArgs e)
		{
			if (chkbGroupBySubjects.Checked)
			{
				chkbGroupByDepot.Checked = false;
				clbSelectedCentres.Enabled = true;
				scCentreDepot.Panel2Collapsed = true;
			}
		}

		private void chkbGroupByDepot_CheckedChanged(object sender, EventArgs e)
		{
			if (chkbGroupByDepot.Checked)
			{
				chkbGroupBySubjects.Checked = false;
				clbSelectedCentres.Enabled = false;
				scCentreDepot.Panel1Collapsed = true;
			}
			else
			{
				chkbGroupBySubjects.Checked = false;
				clbSelectedCentres.Enabled = true;
				scCentreDepot.Panel2Collapsed = true;
			}
		}

		private void btnSelectAllDepot_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < checkedListBoxDepot.Items.Count; i++)
			{
				checkedListBoxDepot.SetItemChecked(i, true);
			}
		}

		private void btnClearDepots_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < checkedListBoxDepot.Items.Count; i++)
			{
				checkedListBoxDepot.SetItemChecked(i, false);
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

		private void checkedChangedFont(object sender, EventArgs e)
		{
			RadioButton rb = (RadioButton)sender;
			rbExcludeOralArabicFrench.Font = new Font(rbExcludeOralArabicFrench.Font.FontFamily, 10, FontStyle.Regular);
			rbExcludeOralEnglish.Font = new Font(rbExcludeOralEnglish.Font.FontFamily, 10, FontStyle.Regular);
			rbOralArabicOnly.Font = new Font(rbOralArabicOnly.Font.FontFamily, 10, FontStyle.Regular);
			rbOralEnglishOnly.Font = new Font(rbOralEnglishOnly.Font.FontFamily, 10, FontStyle.Regular);
			rbOralFrenchOnly.Font = new Font(rbOralFrenchOnly.Font.FontFamily, 10, FontStyle.Regular);

			if (rb.Checked)
			{
				rb.Font = new Font(rbExcludeOralEnglish.Font.FontFamily, 13, FontStyle.Bold);
			}
		}

	}
}

/*
 * sqlStatement =
						"SELECT NatPrePrintObjDetails8.ExamYear AS [Year], NatPrePrintObjDetails8.CsdSubjCode, NatPrePrintObjDetails8.CentNo, (NatPrePrintObjDetails8.CentNo + NatPrePrintObjDetails8.IndexNo) AS ExaminationNumber, NatPrePrintObjDetails8.IndexNo, NATGRADE8.CandName, NATGRADE8.Sex, ('OBJECTIVE') AS PapType, NatSubjects.Description AS Description, 4 AS TotSubs, 'JUNE' AS Examination " +
							"FROM NatSubjects INNER JOIN (NatPrePrintObjDetails8 INNER JOIN NATGRADE8 ON (NatPrePrintObjDetails8.ExamYear = NATGRADE8.ExamYear) AND (NatPrePrintObjDetails8.CentNo = NATGRADE8.CentNo) AND (NatPrePrintObjDetails8.IndexNo = NATGRADE8.IndexNo)) ON NatSubjects.GenSubjCode = NatPrePrintObjDetails8.CsdSubjCode " +
							"ORDER BY NatPrePrintObjDetails8.CsdSubjCode, NatPrePrintObjDetails8.CentNo, NatPrePrintObjDetails8.IndexNo; ";
*/