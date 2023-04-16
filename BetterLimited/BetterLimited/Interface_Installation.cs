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
    public partial class Interface_Installation : Form
    {
        public static Interface_Installation instance;
        public Label lab1;
        public Interface_Installation()
        {
     

            InitializeComponent();
            instance = this;
            lab1 = label1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Interface_ViewInstallationOrder Shopm = new Interface_ViewInstallationOrder();
            Interface_ViewInstallationOrder.instance.lab1.Text = label1.Text;
            Shopm.Show();
      
        }

        private void Interface_Installation_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_ScheduleDutyList_Installation Shopm = new Interface_ScheduleDutyList_Installation();
            Interface_ScheduleDutyList_Installation.instance.lab1.Text = label1.Text;
            Shopm.Show();
           // this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e)
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
