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
    public partial class UserControl_UserProfile : UserControl
    {    
        FunctionClass fn = new FunctionClass();
        string query;
        public UserControl_UserProfile()
        {
            InitializeComponent();
        }

        public string Id
        {
            set { lblUserName.Text = value; }
        }
     
      

        private void UserControl_UserProfile_Enter(object sender, EventArgs e)
        {
            query = "select * from Users_Tbl where UserName = '" + lblUserName.Text + "'";
            DataSet ds = fn.GetData(query);

            comboBoxUserRole.Text = ds.Tables[0].Rows[0][1].ToString();
            textBoxName.Text = ds.Tables[0].Rows[0][2].ToString();
            dateTimePickerForAddUser.Text = ds.Tables[0].Rows[0][3].ToString();
            textBoxMobileNumber.Text = ds.Tables[0].Rows[0][4].ToString();
            textBoxEmail.Text = ds.Tables[0].Rows[0][5].ToString();
            textBoxPassword.Text = ds.Tables[0].Rows[0][7].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            UserControl_UserProfile_Enter(this,null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userRole = comboBoxUserRole.Text;
            string name = textBoxName.Text;
            string dob = dateTimePickerForAddUser.Text;
            Int64 mobile = Int64.Parse(textBoxMobileNumber.Text);
            string email = textBoxEmail.Text;
            string userName =  lblUserName.Text;
            string password = textBoxPassword.Text;

            query = "update Users_Tbl set UserRole = '" + userRole + "', Name = '" + name + "', DOB = '" + dob + "', Mobile = '" + mobile + "',Email = '" + email + "', Password = '" + password + "' where UserName = '" + userName + "'";

            fn.SetData(query, "Updation completed");


        }
    }
}
