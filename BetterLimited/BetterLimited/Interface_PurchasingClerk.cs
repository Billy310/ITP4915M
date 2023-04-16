using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class Interface_PurchasingClerk : Form
    {
        public Interface_PurchasingClerk()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_CreatePurchaseOrder Shopm = new Interface_CreatePurchaseOrder();
            Shopm.Show();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // this.Close();
                Interface_Login login = new Interface_Login();
                login.Show();
                this.Hide();
            }
        }
    }
}
