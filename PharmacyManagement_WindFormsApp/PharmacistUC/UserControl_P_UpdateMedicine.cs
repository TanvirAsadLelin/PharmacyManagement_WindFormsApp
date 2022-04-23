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
    public partial class UserControl_P_UpdateMedicine : UserControl
    {   
        FunctionClass fn  = new FunctionClass();
        string query;
        public UserControl_P_UpdateMedicine()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtMedicineID.Text != "")
            {
                query = "select * from Medicine_Tbl where MedicineID = '" + txtMedicineID.Text + "'";

                DataSet ds = fn.GetData(query);
                
                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtMedicineName.Text = ds.Tables[0].Rows[0][2].ToString();
                    txtMedicineNumber.Text = ds.Tables[0].Rows[0][3].ToString();    
                    dateTimeManufacturing.Text = ds.Tables[0].Rows[0][4].ToString();
                    dateTimeExpire.Text = ds.Tables[0].Rows[0][5].ToString();
                    txtAvailableQuantity.Text = ds.Tables[0].Rows[0][6].ToString(); 
                    txtPricePerUnit.Text = ds.Tables[0].Rows[0][7].ToString();
                }
                else
                {
                    MessageBox.Show("No Medicine With Id : " + txtMedicineID.Text + " exist.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                
            }
            else
            {
                ClearAll();
            }
        }

        private void ClearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            txtMedicineNumber.Clear();
            dateTimeManufacturing.ResetText();
            dateTimeExpire.ResetText();
            txtAvailableQuantity.Clear();
            txtPricePerUnit.Clear();

            if(txtAddQuantity.Text != "0")
            {
                txtAddQuantity.Text = "0";
            }
            else
            {
                txtAddQuantity.Text = "0";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ClearAll();
        }


        Int64 totalQuantity;
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string mName = txtMedicineName.Text; 
            string mNumber = txtMedicineNumber.Text;
            string mDate = dateTimeManufacturing.Text;
            string eDate = dateTimeExpire.Text;

            Int64 availableQuantity = Int64.Parse( txtAvailableQuantity.Text);
            Int64 addQuantity = Int64.Parse(txtAddQuantity.Text);
            Int64 pricePerUnit = Int64.Parse(txtPricePerUnit.Text);

            totalQuantity = availableQuantity + addQuantity;

            query = "update Medicine_Tbl set MedicineName = '" + mName + "', MedicineNumber = '" + mNumber + "', ManufacturingDate = '" + mDate + "', ExpireDate = '" + eDate + "', Quantity = '" + totalQuantity + "', PricePerUnit = '" + pricePerUnit + "' where MedicineID = '"+txtMedicineID.Text+"'";

            fn.SetData(query, "Updated Successfuly");
            ClearAll();
        }
    }
}
