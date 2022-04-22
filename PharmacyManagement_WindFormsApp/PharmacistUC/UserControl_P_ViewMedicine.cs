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
    public partial class UserControl_P_ViewMedicine : UserControl
    {   
        FunctionClass fn =  new FunctionClass();
        string query;
        public UserControl_P_ViewMedicine()
        {
            InitializeComponent();
        }

        private void UserControl_P_ViewMedicine_Load(object sender, EventArgs e)
        {
            query = "select * from Medicine_Tbl";
            SetDataGridView(query);

        }

        private void txtSearchByMedicineName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Medicine_Tbl where MedicineName like '"+txtSearchByMedicineName.Text+"%'";

            SetDataGridView(query);
        }
        private void SetDataGridView(string query)
        {
            DataSet ds = fn.GetData(query);
            dataGridViewFORViewMedicine.DataSource = ds.Tables[0];
        }

        string medicineId;
        private void dataGridViewFORViewMedicine_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                medicineId= dataGridViewFORViewMedicine.Rows[e.RowIndex].Cells[1].Value.ToString(); 

            }
            catch
            {

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Delete Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                query = "delete from Medicine_Tbl where MedicineID = '" + medicineId + "'";
                fn.SetData(query, "Deleted successfuly");
                UserControl_P_ViewMedicine_Load(this, null);
            }
        }

        private void btnSyncReload_Click(object sender, EventArgs e)
        {
            UserControl_P_ViewMedicine_Load(this, null);
        }
    }
}
