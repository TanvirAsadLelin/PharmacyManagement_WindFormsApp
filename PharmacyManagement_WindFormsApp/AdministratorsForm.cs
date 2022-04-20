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
    public partial class AdministratorsForm : Form
    {
        string user = "";
        public AdministratorsForm()
        {
            InitializeComponent();
        }
    public string Id
        {
            get { return user.ToString(); }
        }

        public AdministratorsForm(string username)
        {
            InitializeComponent();
            lblUsername.Text = username;
            user = username; 
            userControl_ViewUser1.Id = Id;
            userControl_UserProfile1.Id = Id;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            userControl_DashBoard.Visible = true;
            userControl_DashBoard.BringToFront(); 
        }

        private void AdministratorsForm_Load(object sender, EventArgs e)
        {
            userControl_DashBoard.Visible=false;
            userControl_AddUser.Visible=false;
            userControl_ViewUser1.Visible=false;
            userControl_UserProfile1.Visible=false;
            btnDashBoard.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            userControl_AddUser.Visible = true;
            userControl_AddUser.BringToFront();
        }

        private void btnViewUser_Click(object sender, EventArgs e)
        {
            userControl_ViewUser1.Visible = true;
            userControl_ViewUser1.BringToFront();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            userControl_UserProfile1.Visible = true;
            userControl_UserProfile1.BringToFront();
        }
    }
}
