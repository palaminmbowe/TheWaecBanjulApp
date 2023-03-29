using WaecCassUI.Models;
using WaecCassUI.Repository;

namespace WaecCassUI
{
    public partial class CassUiForm : Form
    {
        public CassUiForm()
        {
            InitializeComponent();
        }
        private void CassUiForm_Load(object sender, EventArgs e)
        {
            schoolPinsButton.PerformClick();
        }

        private async void schoolPinsButton_Click(object sender, EventArgs e)
        {
            // get school pins
            LogMessage(message: $"Loading School Pins...", from: "schoolPinsButton_Click", false);
            schoolPinsDataGridView.DataSource = await GetSchoolPinsAsync();
            LogMessage(message: $"\t completed\n\n", from: "schoolPinsButton_Click", false);
        }

        private async Task<List<SchoolPins>> GetSchoolPinsAsync()
        {
            SchoolPinsRepository schoolPins = new();

            return await schoolPins.GetSchoolPinsAsync();
        }

        private void dataGridView_DataSourceChanged(object sender, EventArgs e)
        {
            schoolPinsDataGridViewLabel.Text = $"Total Records = {schoolPinsDataGridView.RowCount}";
        }

        private async void getCassDataForSchoolButton_Click(object sender, EventArgs e)
        {
            if (selectedSchoolPinTextBox.Text.Equals("")) return;

            var centrePin = selectedSchoolPinTextBox.Text;
            var startYear = startYearTextBox.Text;
            var endYear = endYearTextBox.Text;

            //LoadCassDataFromServer

            LogMessage($"Getting CASS data for {centrePin.Substring(0, 7)} ... ", "getCassDataForSchoolButton_Click", false);

            if (await GetCassDataForSchoolAsync(centrePin, startYear, endYear))
            {
                LogMessage("completed\n");
            }
        }

        private async Task<bool> GetCassDataForSchoolAsync(string centrePin, string startYear, string endYear)
        {
            var results = await CassProcessor.LoadCass(centrePin, startYear, endYear);

            cassDataDataGridView.DataSource = results;
            cassDataDataGridViewLabel.Text = $"Total records = {cassDataDataGridView.RowCount}";

            if (saveDataCheckBox.Checked && (results.Count > 0))
            {
                var cbsRepo = new CandidateBioSubjectsRepository();

                //Todo: Make async
                cbsRepo.Insert(results);

                return true;
            }

            return false;
        }

        private void cassDataDataGridView_Validated(object sender, EventArgs e)
        {
            cassDataDataGridViewLabel.Text = cassDataDataGridView.RowCount.ToString();
        }

        private void schoolPinsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetSchoolPinsDataGridViewPin(sender);
        }

        private void GetSchoolPinsDataGridViewPin(object sender)
        {
            var dgv = (DataGridView)sender;
            var selectedRowCount = dgv.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                selectedSchoolPinTextBox.Text = dgv.SelectedRows[0].Cells[1].Value.ToString();
            }

            //var row = dgv.Rows.se;
            //var col = row.Cells[1].ToString();
        }

        private void schoolPinsDataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            GetSchoolPinsDataGridViewPin(sender);
        }

        private async void getAllCassDataButton_Click(object sender, EventArgs e)
        {
            // for each pin in grid view, get cass data
            var dgv = schoolPinsDataGridView;
            
            foreach (DataGridViewRow row in dgv.Rows)
            {
                var centrePin = row.Cells[1].Value.ToString();
                selectedSchoolPinTextBox.Text = centrePin;
                var startYear = startYearTextBox.Text;
                var endYear = endYearTextBox.Text;

                if (centrePin is not null)
                {
                    LogMessage($"Getting CASS data for {centrePin.Substring(0, 7)} ... ", "getCassDataForSchoolButton_Click", false);

                    if (await GetCassDataForSchoolAsync(centrePin, startYear, endYear))
                    {
                        LogMessage("completed\n");
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.PaleGoldenrod;
                }

                
            }
        }

        private void LogMessage(string message, string from, bool displaySource)
        {
            displayRichTextBox.AppendText(String.Concat($"{message}", displaySource ? $" - {from}" : ""));
            displayRichTextBox.AppendText(displaySource ? from : "");
        }

        private void LogMessage(string message, string from)
        {
            LogMessage(message, from, false);
        }
        private void LogMessage(string message)
        {
            LogMessage(message, "", false);
        }

        private void schoolPinsDataGridViewLabel_Click(object sender, EventArgs e)
        {

        }
    }
}