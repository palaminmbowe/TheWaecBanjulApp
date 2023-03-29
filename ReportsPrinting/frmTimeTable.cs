using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReportsPrinting
{
    public partial class frmTimeTable : Form
    {
        public frmTimeTable()
        {
            InitializeComponent();
        }

        private void frmTimeTable_Load(object sender, EventArgs e)
        {
            scBody.Panel2Collapsed = true;
            nupFontSize.Value = (decimal)dataGridView1.Font.Size;
            panelFontSize.Visible = false;

            //Data Source = waecgmvdbs; Initial Catalog = WaecCommon; Persist Security Info = True; User ID = ictdstaff; Password = StaffIctd.11
            timetableTableAdapter.Connection = new System.Data.SqlClient.SqlConnection(@"Data Source = waecgmvdbs; Initial Catalog = WaecCommon; Persist Security Info = True; User ID = ictdstaff; Password = StaffIctd.11");
            
            DateTime dtNow = DateTime.Now;
            DateTime endEdit = new DateTime(2020, 08, 31);
            if (dtNow < endEdit)
            {
                dataGridView1.ReadOnly = false;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var updateStringOriginal = timetableTableAdapter.Adapter.UpdateCommand.CommandText;
                var updateString = updateStringOriginal;

                timetableTableAdapter.Adapter.UpdateCommand.CommandText = timetableTableAdapter.Adapter.UpdateCommand.CommandText.Replace("WHERE", $" , UserName='{System.Environment.UserName}', PcName='{System.Environment.MachineName}', DomainName='{System.Environment.UserDomainName}' WHERE");
                var results = timetableTableAdapter.Update(waecCommonDataSet.Timetable);

                MessageBox.Show($"{results} record{(results < 2 ? "" : "s")} affected.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                buttonUpdate.Enabled = false;
                timetableTableAdapter.Adapter.UpdateCommand.CommandText = updateStringOriginal;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to Server [{ex.Message}]");
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            buttonUpdate.Enabled = true;
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            labelTimetable.Text = $"{b.Text} TIMETABLE";
            UpdateDataGrid(b.Name);
            panelFontSize.Visible = true;
        }

        private void UpdateDataGrid(string senderText)
        {
            try
            {
                switch (senderText)
                {
                    case "buttonWassceSc":
                        this.timetableTableAdapter.Fill(this.waecCommonDataSet.Timetable);
                        break;
                    case "buttonWasscePc":
                        //this.timetableTableAdapter.Fill(this.waecCommonDataSet.Timetable);
                        break;
                    case "buttonGabeceSc":
                        //this.timetableTableAdapter.Fill(this.waecCommonDataSet.Timetable);
                        break;
                    case "buttonGabecePc":
                        //this.timetableTableAdapter.Fill(this.waecCommonDataSet.Timetable);
                        break;
                    case "buttonNat":
                        //this.timetableTableAdapter.Fill(this.waecCommonDataSet.Timetable);
                        break;
                    default:
                        break;
                }
                
                scBody.Panel2Collapsed = false;
                buttonUpdate.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error connecting to Server [{ex.Message}]");
            }
        }

        private void nupFontSize_ValueChanged(object sender, EventArgs e)
        {
            Font f = dataGridView1.Font;
            Font fG = new Font(f.FontFamily, (float)nupFontSize.Value, f.Style);
            dataGridView1.Font = fG;
        }
    }
}
