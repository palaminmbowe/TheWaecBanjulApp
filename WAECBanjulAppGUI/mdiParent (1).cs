using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using WaecUtils;
using NAT_8_Processing;
using ReportsPrinting;
using ICTDUtilities.Objects;
using GABECE_NAT;

namespace WAECBanjulAppGUI
{
    public partial class mdiParent : Form
    {
        private frmAmsReportsPrinting frmReportsWassce, frmReportsGabece, frmReportsNAT, frmReportsPgabece;

        Thread timerThread;

        public mdiParent()
        {
            InitializeComponent();
        }

        private void GeneralReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralReports.FormGeneralReports frm = new GeneralReports.FormGeneralReports
            {
                MdiParent = this
            };
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }

        private void nAT8ProcessingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNat8Main frm = new frmNat8Main
            {
                MdiParent = this
            };
            frm.Show();
        }

        private void mdiParent_Load(object sender, EventArgs e)
        {
            HeartBeat();
            timerThread = new Thread(new ThreadStart(HeartBeat));
            timerThread.Start();

            if (SetupUserInterface())
            {

            }

            //System.Reflection.Assembly executingAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            //var fileVersionInfo = System.Diagnostics.FileVersionInfo.GetVersionInfo(executingAssembly.Location);
            //var version = fileVersionInfo.FileVersion;
            //var v2 = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;

            //toolStripLabelParentCurrentVersion.Text = $"Version: {v2.Major}.{v2.Minor}.{v2.Build}.{v2.Revision}";

            //toolStripLabelParentVersion.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            //toolStripLabelParentVersion.Text = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
            toolStripLabelParentCurrentVersion.Text = CurrentVersion;
            //toolStripLabelParentExecutingVersion.Text = CurrentVersion[1];
        }

        public string CurrentVersion { 
            get
            {
                return System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed ?
                    System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString() :
                    System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        private void wASSCEPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void gABECESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void gABECPCToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void nATGrade3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void nATGrade5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void nATGrade8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
        }

        private void candidateDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gABECEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICTDUtilities.Objects.frmViewModifyCandidates frmCandidate = new ICTDUtilities.Objects.frmViewModifyCandidates();
            frmCandidate.MdiParent = this;
            frmCandidate.Show();
        }

        private void wASSCEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ICTDUtilities.Objects.frmViewModifyCandidatesWassce frmCandidateW = new ICTDUtilities.Objects.frmViewModifyCandidatesWassce();
            frmCandidateW.MdiParent = this;
            frmCandidateW.Show();
        }

        private void nATToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Not yet implemented. :-(");
            NAT8Processing.frmEditNatCandidate frmCandidateNat8 = new NAT8Processing.frmEditNatCandidate();
            frmCandidateNat8.MdiParent = this;
            frmCandidateNat8.Show();
        }

        private void timerHeartBeat_Tick(object sender, EventArgs e)
        {
            HeartBeat();
        }

        private void HeartBeat()
        {
            try
            {
                using (var db = new NAT8Processing.Model.WaecNatEntities())
                {
                    var serverDateTime = db.fServerGetDateTime().ToList();
                    if (serverDateTime.Count > 0)
                    {
                        toolStripLabelParentCurrentDateTime.Text = serverDateTime[0].CurrentDate.ToLongDateString().ToString();
                        toolStripButtonParentConnectionStatus.Text = "CONNECTED!";
                        toolStripButtonParentConnectionStatus.BackColor = Color.Green;
                    }
                    else
                    {
                        toolStripButtonParentConnectionStatus.Text = "NOT CONNECTED!";
                        toolStripButtonParentConnectionStatus.BackColor = Color.Red;
                    }
                }
            }
            catch (Exception)
            {
                toolStripButtonParentConnectionStatus.Text = "NOT CONNECTED!";
                toolStripButtonParentConnectionStatus.BackColor = Color.Red;
            }            
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            toolStripLabelParentCurrentTime.Text = DateTime.Now.ToLongTimeString().ToString();
        }

        private void g3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNatG3 frm = new frmNatG3();
            frm.MdiParent = this;
            frm.Show();
        }

        private bool SetupUserInterface()
        {
            // sets up what to display for each user.
            switch (UserUtils.UserDomainName.ToLower())
            {
                case "waec":

                    break;
                case "ictd":
                    ICTDepartmentToolStripMenuItem.Visible = true;
                    break;
                default:
                    break;
            }

            return true;
        }

        private void reportsPrintingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string domain = UserUtils.UserDomainName;
            string userName = UserUtils.UserName;
            string pcName = UserUtils.MachineName;

            switch (domain.ToLower())
            {
                case "ictd":
                case "palamin":
                case "palamin2":
                    break;
                default:
                    MessageBox.Show("Please log on to the domain to continue. Exiting!", "Error logging in.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    break;
            }
        }

        private void wASSCESCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportsWassce = new frmAmsReportsPrinting(ExamsUtils.Exams.WASSCE, ExamsUtils.ReportTypes.AMS);
            frmReportsWassce.MdiParent = this;
            frmReportsWassce.WindowState = FormWindowState.Maximized;
            frmReportsWassce.Show();
        }
    }
}
