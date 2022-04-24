using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyManagement_WindFormsApp
{
    public partial class Form1 : Form
    {    
        FunctionClass fn = new FunctionClass();
        string query;
        DataSet ds;
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

            query = "select * from Users_Tbl";
            ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count == 0)
            {
                if (txtboxUsername.Text == "root" && txtPassword.Text == "root")
                {
                    AdministratorsForm admin = new AdministratorsForm();
                    admin.Show();
                    this.Hide();
                }
            }


            else
            {
                query = "select * from Users_Tbl where UserName = '" + txtboxUsername.Text + "' and Password= '" + txtPassword.Text + "'";

                ds = fn.GetData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    string role = ds.Tables[0].Rows[0][1].ToString();

                    if (role == "Administrator")
                    {
                        AdministratorsForm admin = new AdministratorsForm(txtboxUsername.Text);
                        admin.Show();
                        this.Hide();
                    }
                    else if (role == "Pharmacist")
                    {
                        PharmacistForm pharmacist = new PharmacistForm();
                        pharmacist.Show();
                        this.Hide();
                    }

                    else if (role == "Customer")
                    {
                        // no code here
                    }
                    
                }

                else
                {
                    MessageBox.Show("Wrong Username Or Password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        




            //if(txtboxUsername.Text == "lelin" && txtPassword.Text == "123")
            //{
            //    AdministratorsForm adminstratorsForm = new AdministratorsForm();
            //    this.Hide();
            //    adminstratorsForm.ShowDialog();

            //}

            //else
            //{
            //    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}


        }
    }
}
