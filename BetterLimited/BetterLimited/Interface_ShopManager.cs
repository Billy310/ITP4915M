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
    public partial class Interface_ShopManager : Form
    {
        public static Interface_ShopManager instance;
        public Label lab1;
        public Label lab2;
        public Interface_ShopManager()
        {
            
            InitializeComponent();
            instance = this;
            lab1 = label1;
            lab2 = lab_storeID;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Interface_CreateSaleOrder s = new Interface_CreateSaleOrder();
            Interface_CreateSaleOrder.instance.lab1.Text = lab1.Text;
            Interface_CreateSaleOrder.instance.lab2.Text = lab_storeID.Text;
            s.Show();
            

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Interface_OrderManagement ed = new Interface_OrderManagement();
            ed.Show();
         
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
       
        }

        private void Interface_ShopManager_Load(object sender, EventArgs e)
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

        private void button3_Click(object sender, EventArgs e)
        {
            Interface_CreateDeliveryOrder s = new Interface_CreateDeliveryOrder();
            //CreateDeliveryOrder.instance.lab1.Text = lab1.Text;
            s.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface_CreateInstallationOrder s = new Interface_CreateInstallationOrder();
            //CreateDeliveryOrder.instance.lab1.Text = lab1.Text;
            s.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface_ShopStaffEditDeliveryOrder s = new Interface_ShopStaffEditDeliveryOrder();
            //CreateDeliveryOrder.instance.lab1.Text = lab1.Text;
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_EditInstallationOrder s = new Interface_EditInstallationOrder();
            //CreateDeliveryOrder.instance.lab1.Text = lab1.Text;
            s.Show();
        }

        private void lab_storeID_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Interface_TodaySelling t = new Interface_TodaySelling();
            Interface_TodaySelling.instance.lab1.Text = lab2.Text;
            t.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            Interface_HandleDefectItem f = new Interface_HandleDefectItem();
            f.Show();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Interface_RecoverStock f = new Interface_RecoverStock();
            Interface_RecoverStock.instance.lab1.Text = lab2.Text;
            f.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Interface_ViewResultOfRequest f = new Interface_ViewResultOfRequest();
            Interface_ViewResultOfRequest.instance.lab1.Text = lab2.Text;
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Interface_ViewSellingProduct f = new Interface_ViewSellingProduct();
            f.Show();
        }
    }
}
