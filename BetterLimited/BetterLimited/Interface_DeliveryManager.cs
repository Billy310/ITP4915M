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
    public partial class Interface_DeliveryManager : Form
    {
        public static Interface_DeliveryManager instance;
        public Label lab1;
        public Interface_DeliveryManager()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_ScheduleDutyList_Delivery Shopm = new Interface_ScheduleDutyList_Delivery();
            Interface_ScheduleDutyList_Delivery.instance.lab1.Text = lab1.Text;


            Shopm.Show();
        }

        private void Interface_DeliveryManager_Load(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            Interface_ViewDeliveryOrder Shopm = new Interface_ViewDeliveryOrder();
            Interface_ViewDeliveryOrder.instance.lab1.Text = lab1.Text;


            Shopm.Show();

        }
    }
}
