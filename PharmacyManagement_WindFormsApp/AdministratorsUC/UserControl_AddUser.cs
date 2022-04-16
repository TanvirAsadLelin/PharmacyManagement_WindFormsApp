using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement_WindFormsApp.AdministratorsUC
{
    public partial class UserControl_AddUser : UserControl
    {   
        FunctionClass fn = new FunctionClass();
        string query;
        public UserControl_AddUser()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string userRole = comboBoxUserRole.Text;
            string name =  textBoxName.Text;
            string dob = dateTimePickerForAddUser.Text;
            Int64 mobile = Int64.Parse(textBoxMobileNumber.Text);
            string userName =  textBoxUserName.Text;
            string email = textBoxEmail.Text;   
            string pass = textBoxPassword.Text;

            try
            {
                query = "insert into Users_Tbl (UserRole,Name,DOB,Mobile,Email,UserName,Password) values ('" + userRole + "' ,'" + name + "' ,'" + dob + "', " + mobile + ",'" + email + "','" + userName + "','" + pass + "')";

                fn.SetData(query, "Sign up successful");

            }
            catch (Exception )
            {
                MessageBox.Show("Username already exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            CleanAll();
        }
        public void CleanAll()
        {
            comboBoxUserRole.SelectedIndex = -1;
            textBoxName.Clear();
            dateTimePickerForAddUser.ResetText();
            textBoxMobileNumber.Clear();
            textBoxEmail.Clear();
            textBoxUserName.Clear();
            textBoxPassword.Clear();

        }

        private void textBoxUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Users_Tbl where UserName = '" + textBoxUserName.Text + "'";
            DataSet ds = fn.GetData(query);

            if(ds.Tables[0].Rows.Count == 0)
            {
                pictureBoxCheckUserName.Image = Properties.Resources.yes;
            }
            else
            {
                pictureBoxCheckUserName.Image = Properties.Resources.no;
            }
        }
    }
}
