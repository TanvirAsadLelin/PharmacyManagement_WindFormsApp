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
    public partial class UserControl_P_DashBoard : UserControl
    {   
        FunctionClass fn = new FunctionClass();
        string query;
        DataSet ds;
        Int64 count;
        public UserControl_P_DashBoard()
        {
            InitializeComponent();
        }

        private void UserControl_P_DashBoard_Load(object sender, EventArgs e)
        {
            LoadChart();
        }

        public void LoadChart()
        {   
            // For valid Medicine

            query = "select count(MedicineName) from Medicine_Tbl where ExpireDate >= getdate()";

            ds = fn.GetData(query);

            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            this.chart1.Series["Valid Medicines"].Points.AddXY("Medicine validity chart", count);


            // For Expired Medicines

            query = "select count(MedicineName) from Medicine_Tbl where ExpireDate <= getdate()";

            ds = fn.GetData(query);
            count = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            this.chart1.Series["Expired Medicines"].Points.AddXY("Medicine Validity Chart", count);

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Valid Medicines"].Points.Clear();
            this.chart1.Series["Expired Medicines"].Points.Clear();
            LoadChart();
        }
    }
}
