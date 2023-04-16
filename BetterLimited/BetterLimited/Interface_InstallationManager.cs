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
    public partial class Interface_InstallationManager : Form
    {
        public static Interface_InstallationManager instance;
        public Label lab1;
        public Interface_InstallationManager()
        {

            InitializeComponent();
            instance = this;
            lab1 = label1;
        }

        private void Interface_InstallationManager_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_ScheduleDutyList_Installation install = new Interface_ScheduleDutyList_Installation();
            Interface_ScheduleDutyList_Installation.instance.lab1.Text = label1.Text;
            install.Show();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            Interface_ViewInstallationOrder i = new Interface_ViewInstallationOrder();
            i.Show();
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
