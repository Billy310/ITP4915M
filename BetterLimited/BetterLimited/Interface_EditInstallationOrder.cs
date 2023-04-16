using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetterLimited
{
    public partial class Interface_EditInstallationOrder : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public Interface_EditInstallationOrder()
        {
            InitializeComponent();
        }
 

   
        private void EditInstallation_Load(object sender, EventArgs e)
        {
            cb_installationorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Istatus.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmb_Lid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int orderid = int.Parse(cb_installationorder.Text);
                    installationorder update = content.installationorders.First(i => i.InstallationOrderID == orderid);
                    update.I_status = cmb_Istatus.Text;
                    content.SaveChanges();
                    MessageBox.Show("Installation Status Updated");
                }
                cb_installationorder.Items.Clear();
                dataGridView1.Rows.Clear();

                DateTime a = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                using (var content = new betterlimitedEntities_Test1())
                {
                    var emp = (from list in content.installationorders
                               where list.InstallationDate == a
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        dataGridView1.Rows.Add(emp2.InstallationOrderID, emp2.InstallationDate, emp2.InstallationTime, emp2.I_status);
                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {
                    cb_installationorder.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                }
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("There is No Result Of that Day");

                }
            }
            catch (System.FormatException) { MessageBox.Show("The Installation Order ID Should Be Selected"); }
            }

        private void btn_search_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Refresh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Interface_EditInstallationOrder rf = new Interface_EditInstallationOrder();
                rf.Show();

                this.Hide();
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Interface_Login login = new Interface_Login();
                login.Show();
                this.Hide();
            }
            else { }
        }

        private void btn_search_Click_1(object sender, EventArgs e)
        {
            cb_installationorder.Items.Clear();
            dataGridView1.Rows.Clear();

            DateTime a = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
            using (var content = new betterlimitedEntities_Test1())
            {
                var emp = (from list in content.installationorders
                           where list.InstallationDate == a
                           select list);
                foreach (var emp2 in emp.ToList())
                {
                    dataGridView1.Rows.Add(emp2.InstallationOrderID, emp2.InstallationDate, emp2.InstallationTime,emp2.I_status);
                }
            }
            for (int x = 0; x < dataGridView1.RowCount; x++)
            {
                cb_installationorder.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

            }
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("There is No Result Of that Day");

            }
        }
    }
}
