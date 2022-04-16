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
    public partial class AdminstratorsForm : Form
    {
        public AdminstratorsForm()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Hide();
        }
    }
}
