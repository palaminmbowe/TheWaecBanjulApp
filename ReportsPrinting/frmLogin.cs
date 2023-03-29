using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReportsPrinting
{
    public partial class frmLogin : Form
    {
        //private bool fb;
        byte tries = 0;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            // do the check here and if successful, close form
            if ((txtUsername.Text == "ictd") && (txtPassword.Text == "ictd"))
            {
                DialogResult = System.Windows.Forms.DialogResult.OK;
                this.Close();
            }
            else
            {
                lblFeedback.Text = "Error logging in!";
                txtUsername.Text = txtPassword.Text = "";
                txtUsername.Focus();
                tries++;
            }

            if (tries == 3)
            {
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if ((txtPassword.Text == "") || (txtUsername.Text == ""))
                btnLogin.Enabled = false;
            else
                btnLogin.Enabled = true;
        }
    }
}
