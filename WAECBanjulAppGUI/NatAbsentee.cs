using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WAECBanjulAppGUI.Models;

namespace WAECBanjulAppGUI
{
    public partial class NatAbsentee : Form
    {
        List<TextBox> inputTextBoxes;
        public NatAbsentee()
        {
            InitializeComponent();
            examYearComboBox.Items.Add(DateTime.Now.Year);
            inputTextBoxes = new List<TextBox>();
            inputTextBoxes.Add(englishLanguagePresentsTextBox);
            inputTextBoxes.Add(mathematicsPresentsTextBox);
            inputTextBoxes.Add(sciencePresentsTextBox);
            inputTextBoxes.Add(sesPresentsTextBox);
            inputTextBoxes.Add(englishLanguageAbsentTextBox);
            inputTextBoxes.Add(mathematicsAbsentTextBox);
            inputTextBoxes.Add(scienceAbsentTextBox);
            inputTextBoxes.Add(sesAbsentTextBox);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ValidateTextBoxInput(object sender, EventArgs e)
        {
            var tb = (TextBox)sender;

            try
            {
                int num = int.Parse(tb.Text);
                tb.BackColor = Color.White;
            }
            catch (Exception)
            {
                tb.BackColor = Color.PaleGoldenrod;
                return;
            }

            EnableSaveButton();
        }

        private void EnableSaveButton()
        {
            bool allOk = true;

            foreach (var tb in inputTextBoxes)
            {
                allOk = allOk && !tb.Text.Equals(string.Empty);
            }

            saveButton.Enabled = allOk;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            foreach (var tb in inputTextBoxes)
            {
                tb.Text = string.Empty;
                saveButton.Enabled = false;
            }

            centreNumberTextBox.Clear();
            refreshButton.PerformClick();
        }

        private void NatAbsentee_Load(object sender, EventArgs e)
        {
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            var absenteeRepository = new AbsenteeRepository();
            var results = absenteeRepository.GetAbsentees();
            dataGridView.DataSource = results;
            totalRecordsLabel.Text = $"Total Rcords = {dataGridView.RowCount}";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var absenteeRepository = new AbsenteeRepository();
            var results = absenteeRepository.Insert(
                new Absentee {
                ExamId = examIdComboBox.Text,
                ExamYear = int.Parse(examYearComboBox.Text),
                CentreNumber = centreNumberTextBox.Text,
                EnglishLanguageAbsents = int.Parse(englishLanguageAbsentTextBox.Text),
                MathematicsAbsents = int.Parse(mathematicsAbsentTextBox.Text),
                ScienceAbsents = int.Parse(scienceAbsentTextBox.Text),
                SESAbsents = int.Parse(sesAbsentTextBox.Text),
                EnglishLanguagePresents = int.Parse(englishLanguagePresentsTextBox.Text),
                MathematicsPresents = int.Parse(mathematicsPresentsTextBox.Text),
                SciencePresents = int.Parse(sciencePresentsTextBox.Text),
                SESPresents = int.Parse(sesPresentsTextBox.Text),
                UserName = Environment.UserName,
                PcName = Environment.MachineName
                });

            ////saveButtonLabel.Text = $"{results.Item1}";
            clearButton.PerformClick();
            centreNumberTextBox.Focus();
        }

        private void centreNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (centreNumberTextBox.TextLength == 5)
            {
                englishLanguagePresentsTextBox.Focus();
            }
        }
    }
}
