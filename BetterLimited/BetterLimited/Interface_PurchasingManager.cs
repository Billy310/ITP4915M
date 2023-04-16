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
    public partial class Interface_PurchasingManager : Form
    {
        public Interface_PurchasingManager()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface_ApproveReorder cr = new Interface_ApproveReorder();
            cr.Show();
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

        private void btn_edit_Click(object sender, EventArgs e)
        {
            Interface_ViewPurchaseItem v = new Interface_ViewPurchaseItem();
            v.Show();
        }

        private void btn_createpurchase_Click(object sender, EventArgs e)
        {
            Interface_CreatePurchaseOrder v = new Interface_CreatePurchaseOrder();
            v.Show();
        }
    }
}
