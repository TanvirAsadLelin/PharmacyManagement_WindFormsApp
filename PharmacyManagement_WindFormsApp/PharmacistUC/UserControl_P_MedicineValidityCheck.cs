using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagement_WindFormsApp.PharmacistUC
{
    public partial class UserControl_P_MedicineValidityCheck : UserControl
    {    
        FunctionClass fn =  new FunctionClass();
        string query;
        public UserControl_P_MedicineValidityCheck()
        {
            InitializeComponent();
        }

        private void comboboxForSelectCheckStyle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboboxForSelectCheckStyle.SelectedIndex == 0)
            {
                query = "select * from Medicine_Tbl where ExpireDate >= getdate()";
                DataSet ds = fn.GetData(query);
                dataGridViewFORMedicineValidityCheck.DataSource = ds.Tables[0];
                lblNameCheckStyle.Text = "Valid Medicines";
                lblNameCheckStyle.Visible = true;
                lblNameCheckStyle.ForeColor = Color.Black;

            }
            else if (comboboxForSelectCheckStyle.SelectedIndex == 1)
            {
                query = "select * from Medicine_Tbl where ExpireDate <= getdate()";
                DataSet ds = fn.GetData(query);
                dataGridViewFORMedicineValidityCheck.DataSource = ds.Tables[0];
                lblNameCheckStyle.Text = "Expire Medicines";
                lblNameCheckStyle.Visible = true;
                lblNameCheckStyle.ForeColor = Color.Red;

            }
            else if (comboboxForSelectCheckStyle.SelectedIndex == 2)
            {
                query = "select * from Medicine_Tbl";
                DataSet ds = fn.GetData(query);
                dataGridViewFORMedicineValidityCheck.DataSource = ds.Tables[0];
                lblNameCheckStyle.Text = "All Medicines";
                lblNameCheckStyle.Visible = true;
                lblNameCheckStyle.ForeColor = Color.Black;
            }
        }
    }
}
