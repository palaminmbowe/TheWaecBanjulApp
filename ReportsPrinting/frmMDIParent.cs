using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using WaecLibrary;
using ReportsPrinting.PrePrintObj;
using ReportsPrinting.Other_Reports;
using ICTDUtilities.Reports;
using WaecUtils;

namespace ReportsPrinting
{

    public enum Exams
    {
        GABECE,
        NATG3, NATG5, NATG8,
        PWASSCE,
        WASSCE,
        PGABECE
    }

    public enum ReportTypes
    {
        AMS, PrePrintObj
    }

    public partial class frmMDIParent : Form
    {
        private int childFormNumber = 0;
        private frmLogin frmlogin;
        private frmAmsReportsPrinting frmReportsWassce, frmReportsGabece, frmReportsNAT, frmReportsPgabece;

        private frmPrePrintObjPrinting frmPrePrintObjReport;
        static LoggedInUser currentUser;

        string userName, pcName, domain;
     
        public frmMDIParent()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frmMDIParent_Load(object sender, EventArgs e)
        {
            domain = Environment.UserDomainName.ToString();
            userName = Environment.UserName.ToString();
            pcName = Environment.MachineName.ToString();

            switch (domain.ToLower())
            {
                case "waec":
                case "ictd":
                case "palamin":
                case "palamin2":
                    break;
                default:
                    MessageBox.Show("Please log on to the domain to continue. Exiting!", "Error logging in.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    break;
            }

            setupUpComponents();
            //MountNetworkDrive("z");
        }

        private bool MountNetworkDrive(string driveLetter)
        {
            try
            {
                System.Diagnostics.Process.Start("cmd", "/c net use " + driveLetter + @": \\Server1\CSD");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error mounting drive " + driveLetter + ": " + ex.Message);
            }
            return false;
        }

        private void setupUpComponents()
        {
            msMain.Visible = false;

            this.frmlogin = new frmLogin();
            this.frmlogin.ShowInTaskbar = false;
            //this.frmlogin.MdiParent = this;
            if (!(this.frmlogin.ShowDialog() == System.Windows.Forms.DialogResult.OK))
            {
                Application.Exit();
            }

            //successfully logged in. do some work now.
            msMain.Visible = true;
            tssLabelVersion.Text = Application.ProductVersion.ToString();
        }

        private void attendanceAndMarkSheetToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            
        }

        private void wASSCEToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //WASSCE
            try
            {
                frmReportsWassce.Show();
                frmReportsWassce.WindowState = FormWindowState.Maximized;
            }
            catch (Exception)
            {

                frmReportsWassce = new frmAmsReportsPrinting(ExamsUtils.Exams.WASSCE, ExamsUtils.ReportTypes.AMS);
                frmReportsWassce.MdiParent = this;
                frmReportsWassce.Show();

                //if (frmReports.setupReport())
                //{
                //    this.UseWaitCursor = true;

                //    frmReports.MdiParent = this;
                //    frmReports.Show();

                //    this.UseWaitCursor = false;
                //}
                //else
                //{
                //    MessageBox.Show("Report not available! Please try again.", "Failed to load", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    frmReports.Close();
                //}
            }
        }

        private void attendanceAndMarkSheetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void IntepretSelectedMenuItem(object sender, EventArgs e)
        {
            ToolStripMenuItem tsmi = (ToolStripMenuItem)sender;

            switch (tsmi.Name)
            {
                case "miWasscePrePrintObj":
                    //Wassce PrePrintObj
                    MessageBox.Show("Wassce Pre Print obj");
                    break;
                case "tsmiWassceAms":
                    //WASSCE AMS
                    try
                    {
                        //frmReportsWassce.Show();
                        //

                        frmReportsWassce = new frmAmsReportsPrinting(ExamsUtils.Exams.WASSCE, ExamsUtils.ReportTypes.AMS);
                        frmReportsWassce.MdiParent = this;
                        frmReportsWassce.WindowState = FormWindowState.Maximized;
                        frmReportsWassce.Show();
                    }
                    catch (Exception)
                    {

                        //frmReportsWassce = new frmAmsReportsPrinting(Exams.WASSCE, ReportTypes.AMS);
                        //frmReportsWassce.MdiParent = this;
                        //frmReportsWassce.Show();
                    }
                    break;
                case "tsmiPwassceAms":
                    //PWASSCE AMS
                    try
                    {
                        frmReportsWassce = new frmAmsReportsPrinting(ExamsUtils.Exams.PWASSCE, ExamsUtils.ReportTypes.AMS);
                        frmReportsWassce.MdiParent = this;
                        frmReportsWassce.WindowState = FormWindowState.Maximized;
                        frmReportsWassce.Show();
                        
                    }
                    catch (Exception)
                    {

                        
                    }
                    break;
                case "tsmiPgabeceAms":
                    //GABECE
                    try
                    {
                        frmReportsPgabece = new frmAmsReportsPrinting(ExamsUtils.Exams.PGABECE, ExamsUtils.ReportTypes.AMS);
                        frmReportsPgabece.MdiParent = this;
                        frmReportsPgabece.WindowState = FormWindowState.Maximized;
                        frmReportsPgabece.Show();
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case "tsmiGabeceAms":
                    //GABECE
                    try
                    {
                        frmReportsGabece = new frmAmsReportsPrinting(ExamsUtils.Exams.GABECE, ExamsUtils.ReportTypes.AMS);
                        frmReportsGabece.MdiParent = this;
                        frmReportsGabece.WindowState = FormWindowState.Maximized;
                        frmReportsGabece.Show();
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case "tsmiNat3Ams":
                    //
                    try
                    {
                        frmReportsNAT.Show();
                        frmReportsNAT.WindowState = FormWindowState.Maximized;
                    }
                    catch (Exception)
                    {
                        frmReportsNAT = new frmAmsReportsPrinting(ExamsUtils.Exams.NATG3, ExamsUtils.ReportTypes.AMS);
                        frmReportsNAT.MdiParent = this;
                        frmReportsNAT.Show();
                    }
                    break;
                case "tsmiNat5Ams":
                    //
                    try
                    {
                        frmReportsNAT.Show();
                        frmReportsNAT.WindowState = FormWindowState.Maximized;
                    }
                    catch (Exception)
                    {
                        frmReportsNAT = new frmAmsReportsPrinting(ExamsUtils.Exams.NATG5, ExamsUtils.ReportTypes.AMS);
                        frmReportsNAT.MdiParent = this;
                        frmReportsNAT.Show();
                    }
                    break;
                case "tsmiNat8Ams":
                    //
                    try
                    {
                        frmReportsNAT.Show();
                        frmReportsNAT.WindowState = FormWindowState.Maximized;
                    }
                    catch (Exception)
                    {
                        frmReportsNAT = new frmAmsReportsPrinting(ExamsUtils.Exams.NATG8, ExamsUtils.ReportTypes.AMS);
                        frmReportsNAT.MdiParent = this;
                        frmReportsNAT.Show();
                    }
                    break;
                case "timetableToolStripMenuItem":
                    //
                    try
                    {
                        frmTimeTable timetable = new frmTimeTable();
                        timetable.MdiParent = this;
                        timetable.Show();
                    }
                    catch (Exception)
                    {
                    }
                    break;
                default:
                    MessageBox.Show("Sorry, report is not yet available!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void PrePrintObjs(object sender, EventArgs e)
        {
            //try
            //{
            //    frmPrePrintObjReport.Show();
            //    frmPrePrintObjReport.WindowState = FormWindowState.Maximized;
            // }
            // catch (Exception)
            // {
            //     frmPrePrintObjReport = new frmPrePrintObjPrinting(ReportTypes.PrePrintObj);
            //     frmPrePrintObjReport.MdiParent = this;
            //     frmPrePrintObjReport.Show();
            //  }
            ShowPrePrintObjForm();
        }

        private void schoolConfirmationOfEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void testObjFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrePrintObjPrinting2 frm = new frmPrePrintObjPrinting2();
            frm.Show();
        }

        private void otherReportsExperimentalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReports formReports = new FormReports();
            formReports.MdiParent = this;
            formReports.Show();
        }

        private void otherReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOtherReports report = new frmOtherReports();
            report.MdiParent = this;
            report.Show();
        }

        private void prePrintObjectiveAnswerSheetsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            try
            {
                frmPrePrintObjReport.Show();
                frmPrePrintObjReport.WindowState = FormWindowState.Maximized;
            }
            catch (Exception)
            {
                try
                {
                    frmPrePrintObjReport = new frmPrePrintObjPrinting(ReportTypes.PrePrintObj);
                    frmPrePrintObjReport.MdiParent = this;
                    frmPrePrintObjReport.Show();
                }
                catch (Exception)
                {
                    MessageBox.Show("There was an error loading form. Please report it to your IT support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void attendanceAndMarkSheetToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private bool ShowPrePrintObjForm()
        {
            try
            {
                frmPrePrintObjReport = new frmPrePrintObjPrinting(ReportTypes.PrePrintObj);
                frmPrePrintObjReport.MdiParent = this;
                frmPrePrintObjReport.WindowState = FormWindowState.Maximized;
                frmPrePrintObjReport.Show();

            }
            catch (Exception)
            {
                //try
                //{
                //    frmPrePrintObjReport = new frmPrePrintObjPrinting(ReportTypes.PrePrintObj);
                //    frmPrePrintObjReport.MdiParent = this;
                //    frmPrePrintObjReport.Show();
                //    return true;
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("There was an error loading form. Please report it to your IT support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                MessageBox.Show("There was an error loading form. Please report it to your IT support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return false;
        }
    }
}
