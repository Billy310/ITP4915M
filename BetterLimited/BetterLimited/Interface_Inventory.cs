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
    public partial class Interface_Inventory : Form
    {
        public Interface_Inventory()
        {
            InitializeComponent();
        }

        private void btn_pCreate_Click(object sender, EventArgs e)
        {
            Interface_CreateProduct p = new Interface_CreateProduct();
            p.Show();
           
        }

        private void btn_pEdit_Click(object sender, EventArgs e)
        {
            Interface_EditProduct p = new Interface_EditProduct();
            p.Show();
         
        }

        private void btn_pDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_CreateReorder cr = new Interface_CreateReorder();
            cr.Show();

        }

        private void btn_ReEdit_Click(object sender, EventArgs e)
        {
            Interface_EditReorder cr = new Interface_EditReorder();
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

        private void button5_Click(object sender, EventArgs e)
        {
            Interface_CreateProduct p = new Interface_CreateProduct();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface_EditProduct p = new Interface_EditProduct();
            p.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {


        }

        private void Interface_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_request_Click(object sender, EventArgs e)
        {
            Interface_RecoveryStockWareHouse s = new Interface_RecoveryStockWareHouse();
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface_ViewDefectRecordList a = new Interface_ViewDefectRecordList();
            a.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Interface_ReceiveStock r = new Interface_ReceiveStock();
            r.Show();
        }
    }
}
