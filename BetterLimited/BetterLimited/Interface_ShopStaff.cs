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
    public partial class Interface_ShopStaff : Form
    {
        public static Interface_ShopStaff instance;
        public Label lab1;
        public Label lab2;
        public Interface_ShopStaff()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
            lab2 = label2;
        }

        private void Interface_ShopStaff_Load(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Interface_CreateSaleOrder s = new Interface_CreateSaleOrder();
            Interface_CreateSaleOrder.instance.lab1.Text = lab1.Text;
            s.Show();
  

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Interface_OrderManagement s = new Interface_OrderManagement();
            s.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interface_CreateDeliveryOrder s = new Interface_CreateDeliveryOrder();
            //CreateDeliveryOrder.instance.lab1.Text = lab1.Text;
            s.Show();
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface_ViewDeliveryOrder s = new Interface_ViewDeliveryOrder();
            Interface_ViewDeliveryOrder.instance.lab1.Text = lab1.Text;
            s.Show();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Logout?", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // this.Close();
                Interface_Login login = new Interface_Login();
                login.Show();
                this.Hide();
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Interface_CreateInstallationOrder s = new Interface_CreateInstallationOrder();
            //CreateDeliveryOrder.instance.lab1.Text = lab1.Text;
            s.Show();

        }
    }
}
