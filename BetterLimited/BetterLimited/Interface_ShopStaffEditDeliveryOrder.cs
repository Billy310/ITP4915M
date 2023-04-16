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
    public partial class Interface_ShopStaffEditDeliveryOrder : Form
    {

        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public Interface_ShopStaffEditDeliveryOrder()
        {
            InitializeComponent();
        }
        void mySubjects()
        {
            string command_query = "SELECT DISTINCT DeliveryOrderID FROM betterlimited.deliveryorder WHERE DeliveryDate IS NOT NULL";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("DeliveryOrderID");
                    cb_Deliveryorder.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Delivery OrderID");

            }

        }
  
       
        private void EditDeliveryOrder_Load(object sender, EventArgs e)
        {
            cb_Deliveryorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_Dstatus.DropDownStyle = ComboBoxStyle.DropDownList;



            mySubjects();


        }

        private void cmb_Did_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                cb_Deliveryorder.Items.Clear();
                dataGridView1.Rows.Clear();

                DateTime a = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                using (var content = new betterlimitedEntities_Test1())
                {
                    var emp = (from list in content.deliveryorders
                               where list.DeliveryDate == a
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        dataGridView1.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate, emp2.timeofDelivery, emp2.D_Status);
                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {
                    cb_Deliveryorder.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                }
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("There is No Result Of that Day");

                }

            }
            catch (NullReferenceException) {MessageBox.Show("The Installation Order Should be Selected"); }



        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    deliveryorder update = content.deliveryorders.First(i => i.DeliveryOrderID.ToString() == cb_Deliveryorder.Text);
                    update.D_Status = cmb_Dstatus.Text;
                    content.SaveChanges();
                    MessageBox.Show("Delivery Status Updated");
                }

                cb_Deliveryorder.Items.Clear();
                dataGridView1.Rows.Clear();

                DateTime a = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                using (var content = new betterlimitedEntities_Test1())
                {
                    var emp = (from list in content.deliveryorders
                               where list.DeliveryDate == a
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        dataGridView1.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate, emp2.timeofDelivery);
                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {
                    cb_Deliveryorder.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                }
                cb_Deliveryorder.Items.Clear();
                dataGridView1.Rows.Clear();

                DateTime ab = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                using (var content = new betterlimitedEntities_Test1())
                {
                    var emp = (from list in content.deliveryorders
                               where list.DeliveryDate == ab
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        dataGridView1.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate, emp2.timeofDelivery,emp2.D_Status);
                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {
                    cb_Deliveryorder.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                }
            }
            catch (System.InvalidOperationException) { MessageBox.Show("Please Fill In All The Information"); }



            
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Refresh", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Interface_ShopStaffEditDeliveryOrder rf = new Interface_ShopStaffEditDeliveryOrder();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
