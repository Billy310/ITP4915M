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
    public partial class Interface_AccountingClerk : Form
    {
        public Interface_AccountingClerk()
        {
            InitializeComponent();
        }

        private void Interface_AccountingClerk_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
               
                Interface_Login login = new Interface_Login();
                login.Show();
                this.Hide();
              
            }
        }

        private void btn_turnover_Click(object sender, EventArgs e)
        {
            Interface_ViewTurnover i = new Interface_ViewTurnover();
            i.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_approve_Click(object sender, EventArgs e)
        {
            Interface_ApprovePurchaseItem a = new Interface_ApprovePurchaseItem();
            a.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Interface_ViewSellingProduct f = new Interface_ViewSellingProduct();
            f.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Interface_TodaySelling t = new Interface_TodaySelling();
          
            t.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_TopSale t = new Interface_TopSale();
            t.Show();

        }
    }
}
