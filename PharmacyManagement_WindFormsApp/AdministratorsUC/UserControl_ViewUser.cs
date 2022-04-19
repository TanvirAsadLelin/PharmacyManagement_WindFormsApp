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
    public partial class UserControl_ViewUser : UserControl
    {   
        FunctionClass fn = new FunctionClass();
        string query;
        string currentUser ="";
        public UserControl_ViewUser()
        {
            InitializeComponent();
        }

        public string Id
        {
            set { currentUser = value; }
        }

        private void UserControl_ViewUser_Load(object sender, EventArgs e)
        {
            query = "select * from Users_Tbl";

            DataSet ds = fn.GetData(query);

            dataGridViewFORViewUser.DataSource = ds.Tables[0];
        }

        private void txtSearchByUserName_TextChanged(object sender, EventArgs e)
        {
            query = "select * from Users_Tbl where UserName like '"+txtSearchByUserName.Text+"%'"; // % use for when press a letter then show data which has that letter also
            DataSet ds = fn.GetData(query);

            dataGridViewFORViewUser.DataSource = ds.Tables[0];
        }

        string userName;
        private void dataGridViewFORViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                userName = dataGridViewFORViewUser.Rows[e.RowIndex].Cells[6].Value.ToString();
            }
            catch
            {

            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {   
            if(MessageBox.Show("Are you sure?","Delete Confirmation!",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                if (currentUser != userName)
                {
                    query = "delete from Users_Tbl where UserName = '" + userName + "'";
                    fn.SetData(query, "User record deleted");
                    UserControl_ViewUser_Load(this,null);
                }
                else
                {
                    MessageBox.Show("You are trying to delete \n Your own profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

        }

        private void btnSyncReload_Click(object sender, EventArgs e)
        {
            UserControl_ViewUser_Load(this, null);
        }
    }
}
