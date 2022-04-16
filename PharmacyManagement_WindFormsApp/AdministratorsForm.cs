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
        public AdministratorsForm()
        {
            InitializeComponent();
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
            btnDashBoard.PerformClick();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            userControl_AddUser.Visible = true;
            userControl_AddUser.BringToFront();
        }
    }
}
