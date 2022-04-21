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
    public partial class UserControl_P_AddMedicine : UserControl
    {   
        FunctionClass fn = new FunctionClass();
        string query;
        public UserControl_P_AddMedicine()
        {
            InitializeComponent();
        }

        private void UserControl_P_AddMedicine_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            if(txtMedicineID.Text != "" && txtMedicineName.Text != "" && txtMedicineNumber.Text != "" && txtQuantity.Text != "" && txtPricePerUnit.Text != "")
            {
                string mId = txtMedicineID.Text;
                string mName = txtMedicineName.Text;
                string mNumber = txtMedicineNumber.Text;
                string mDate = dateTimeManufacturing.Text;
                string eDate = dateTimeExpire.Text;
                Int64 quantity = Int64.Parse(txtQuantity.Text);
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);

                query = "insert into Medicine_Tbl(MedicineID,MedicineName,MedicineNumber,ManufacturingDate,ExpireDate,Quantity ,PricePerUnit) values ('" + mId + "', '" + mName + "','" + mNumber + "','" + mDate + "', '" + eDate + "','" + quantity + "','" + unitPrice + "' )";

                fn.SetData(query, "Add Successful");
                ClearAll();
            }
            else
            {
                MessageBox.Show("Enter all data!", "Error" , MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        public void ClearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            dateTimeManufacturing.ResetText();
            dateTimeExpire.ResetText();
            txtQuantity.Clear();
            txtPricePerUnit.Clear();
        }
    }
}
