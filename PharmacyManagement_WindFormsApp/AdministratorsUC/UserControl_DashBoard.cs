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
    public partial class UserControl_DashBoard : UserControl
    {   
        FunctionClass fn = new FunctionClass();
        string query;
        DataSet ds;
        public UserControl_DashBoard()
        {
            InitializeComponent();
        }

        private void UserControl_DashBoard_Load(object sender, EventArgs e)
        {
            query = "select count(UserRole) from Users_Tbl where UserRole = 'Administrator'";
            ds = fn.GetData(query);
            SetLabel(ds, lblCountTotalAdmin);

            query = "select count(UserRole) from Users_Tbl where UserRole = 'Pharmacist'";
            ds = fn.GetData(query);
            SetLabel(ds, lblCountTotalPharmaUser);
        }

        private void SetLabel(DataSet ds , Label lbl)
        {
            if(ds.Tables[0].Rows.Count != 0)
            {
                lbl.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            else 
            {
                lbl.Text = "0";
            }
        }

        private void btnSyncReload_Click(object sender, EventArgs e)
        {
            UserControl_DashBoard_Load(this, null);
        }
    }
}
