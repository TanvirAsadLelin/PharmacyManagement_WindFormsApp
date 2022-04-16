using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement_WindFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtboxUsername.Clear();
            txtPassword.Clear();
        }

        private void checkBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            bool check = checkBoxShowPassword.Checked;
            switch (check)
            {
                case true:
                     txtPassword.PasswordChar = '\0';
                    break;
                default:
                    txtPassword.PasswordChar = '*';
                    break;
            }
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txtboxUsername.Text == "lelin" && txtPassword.Text == "123")
            {
                AdministratorsForm adminstratorsForm = new AdministratorsForm();
                this.Hide();
                adminstratorsForm.ShowDialog();
             
            }

            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
