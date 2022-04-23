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
    public partial class PharmacistForm : Form
    {
        public PharmacistForm()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnDashBoardPharmacist_Click(object sender, EventArgs e)
        {
            userControl_P_DashBoard1.Visible = true;
            userControl_P_DashBoard1.BringToFront();
        }

        private void PharmacistForm_Load(object sender, EventArgs e)
        {
            userControl_P_DashBoard1.Visible=false;
            userControl_P_AddMedicine1.Visible=false;
            userControl_P_ViewMedicine1.Visible = false;
            userControl_P_UpdateMedicine1.Visible = false;  
            userControl_P_MedicineValidityCheck1.Visible=false;
            btnDashBoardPharmacist.PerformClick();
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            userControl_P_AddMedicine1.Visible = true;
            userControl_P_AddMedicine1.BringToFront();
        }

        private void btnViewMedicine_Click(object sender, EventArgs e)
        {
            userControl_P_ViewMedicine1.Visible= true;
            userControl_P_ViewMedicine1.BringToFront();
        }

        private void btnModifyMedicine_Click(object sender, EventArgs e)
        {
            userControl_P_UpdateMedicine1.Visible = true ;
            userControl_P_UpdateMedicine1.BringToFront();
        }

        private void btnValidityCheck_Click(object sender, EventArgs e)
        {
            userControl_P_MedicineValidityCheck1.Visible=true;
            userControl_P_MedicineValidityCheck1.BringToFront();
        }
    }
}
