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
    public partial class UserControl_P_SellMedicine : UserControl
    {   
        FunctionClass fn  = new FunctionClass();
        string query;
        DataSet ds;
        public UserControl_P_SellMedicine()
        {
            InitializeComponent();
        }

        private void UserControl_P_SellMedicine_Load(object sender, EventArgs e)
        {
            listBoxMedicineList.Items.Clear();  
            query = "select MedicineName from Medicine_Tbl where ExpireDate >= getdate() and Quantity > '0' ";

            ds = fn.GetData(query);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicineList.Items.Add(ds.Tables[0].Rows[i][0].ToString()); 

            }
        }

        private void btnSyncReload_Click(object sender, EventArgs e)
        {
            UserControl_P_SellMedicine_Load(this, null);
        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxMedicineList.Items.Clear();
            query = "select MedicineName from Medicine_Tbl where MedicineName like '" + txtBoxSearch.Text + "%' and ExpireDate >= getdate() and Quantity > '0' ";
            ds = fn.GetData(query);

            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                listBoxMedicineList.Items.Add(ds.Tables[0].Rows[i][0].ToString());

            }
        }

        private void listBoxMedicineList_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNumberOfUnits.Clear();
            string name  = listBoxMedicineList.GetItemText(listBoxMedicineList.SelectedItem);

            txtMedicineName.Text = name;

            query = "select MedicineID,ExpireDate,PricePerUnit from Medicine_Tbl where MedicineName  = '" + name + "'";

            ds = fn.GetData(query); 

            txtMedicineID.Text = ds.Tables[0].Rows[0][0].ToString();
            dateTimeExpire.Text = ds.Tables[0].Rows[0][1].ToString();
            txtPricePerUnit.Text = ds.Tables[0].Rows[0][2].ToString();
        }

        private void txtNumberOfUnits_TextChanged(object sender, EventArgs e)
        {
            if (txtNumberOfUnits.Text != "")
            {
                Int64 unitPrice = Int64.Parse(txtPricePerUnit.Text);
                Int64 noUnit = Int64.Parse(txtNumberOfUnits.Text);

                Int64 totalPrice = unitPrice * noUnit;

                txtBoxTotalPrice.Text = totalPrice.ToString();

            }
            else
            {
                txtBoxTotalPrice.Clear();
            }
        }

        protected int n, totalAmount = 0;
        protected Int64 quantity, newQuantity;

      

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if(txtMedicineID.Text != "")
            {
                query = "select Quantity from Medicine_Tbl where MedicineID = '"+txtMedicineID.Text+"'";

                ds = fn.GetData(query);

                quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

                newQuantity = quantity - Int64.Parse(txtNumberOfUnits.Text);

                if(newQuantity >= 0)
                {
                    n = dataGridViewAddCartMedicineList.Rows.Add();
                    dataGridViewAddCartMedicineList.Rows[n].Cells[0].Value = txtMedicineID.Text;  
                    dataGridViewAddCartMedicineList.Rows[n].Cells[1].Value = txtMedicineName.Text;  
                    dataGridViewAddCartMedicineList.Rows[n].Cells[2].Value = dateTimeExpire.Text;  
                    dataGridViewAddCartMedicineList.Rows[n].Cells[3].Value = txtPricePerUnit.Text;  
                    dataGridViewAddCartMedicineList.Rows[n].Cells[4].Value = txtNumberOfUnits.Text;  
                    dataGridViewAddCartMedicineList.Rows[n].Cells[5].Value = txtBoxTotalPrice.Text; 
                    
                    totalAmount = totalAmount + int.Parse(txtBoxTotalPrice.Text);

                    lblPriceShow.Text = "BDT: " + totalAmount.ToString();

                    query = "update Medicine_Tbl set Quantity = '" + newQuantity + "' where MedicineID = '" + txtMedicineID.Text + "' ";
                    fn.SetData(query, "Medicine Added");
                }
                else
                {
                    MessageBox.Show("Medicine is Out of Stock.\n Only " + quantity + " Left.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                ClearAll();
                UserControl_P_SellMedicine_Load(this, null);
            }
            else
            {
                MessageBox.Show("Select Medicine First !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        int valueAmount;
        string valueId;
        protected Int64 noOfUnits;

     

        private void dataGridViewAddCartMedicineList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                valueAmount = int.Parse(dataGridViewAddCartMedicineList.Rows[e.RowIndex].Cells[5].Value.ToString());
                valueId = dataGridViewAddCartMedicineList.Rows[e.RowIndex].Cells[0].Value.ToString();
                noOfUnits = Int64.Parse(dataGridViewAddCartMedicineList.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch(Exception)
            {

            }
        }


        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(valueId != null)
            {
                try
                {
                    dataGridViewAddCartMedicineList.Rows.RemoveAt(this.dataGridViewAddCartMedicineList.SelectedRows[0].Index);

                }
                catch 
                {

                }
                finally
                {
                    query = "select Quantity from Medicine_Tbl where MedicineID = '" + valueId+ "'";
                    ds = fn.GetData(query);
                    quantity = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                    newQuantity = quantity + noOfUnits;

                    query = "update Medicine_Tbl set Quantity = '"+newQuantity+ "' where MedicineID = '" + valueId + "'";

                    fn.SetData(query, "Remove from the Cart");

                    totalAmount = totalAmount - valueAmount;
                    lblPriceShow.Text = "BDT: " + totalAmount.ToString();
                }

                UserControl_P_SellMedicine_Load(this,null);

            }
        }

        private void ClearAll()
        {
            txtMedicineID.Clear();
            txtMedicineName.Clear();
            dateTimeExpire.ResetText();
            txtPricePerUnit.Clear();
            txtNumberOfUnits.Clear();
        }
    }
}
