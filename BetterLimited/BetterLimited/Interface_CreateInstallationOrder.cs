using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Nager.Date;

namespace BetterLimited
{
    public partial class Interface_CreateInstallationOrder : Form
    {
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Interface_CreateInstallationOrder()
        {
            InitializeComponent();
        }

        void mySubjects()
        {
            string command_query = "SELECT OrderID FROM betterlimited.saleorder WHERE InstallationOrderID IS NULL";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("OrderID");
                    combobox_sorder.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");

            }

        }
        void addtoStore()
        {
            string command_query = "SELECT StoreName FROM betterlimited.store";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("StoreName");
                    cb_StoreName.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Store Error");

            }

        }
        void datecount1()
        {
            DateTime dateod = DateTime.Parse(mc_date_installation.SelectionRange.Start.ToString("yyyy-MM-dd"));

            // int sessionid = int.Parse(txt_SessionID.Text);
            MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
            string command_query = "SELECT Count(SessionID) FROM betterlimited.deliveryorder WHERE SessionID=1 && DeliveryDate=@dateofdelivery;";

            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            //cmd.Parameters.AddWithValue(" @sessionid", sessionid);
            cmd.Parameters.AddWithValue("@dateofdelivery", dateod);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {

                    string subj = mydr.GetString("Count(SessionID)");
                    //cb_StaffID.Items.Add(subj);
                    cb_count.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
        }
        void datecount2()
        {
            DateTime dateod = DateTime.Parse(mc_date_installation.SelectionRange.Start.ToString("yyyy-MM-dd"));

            // int sessionid = int.Parse(txt_SessionID.Text);
            MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
            string command_query = "SELECT Count(SessionID) FROM betterlimited.deliveryorder WHERE SessionID=2 && DeliveryDate=@dateofdelivery;";

            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            //cmd.Parameters.AddWithValue(" @sessionid", sessionid);
            cmd.Parameters.AddWithValue("@dateofdelivery", dateod);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {

                    string subj = mydr.GetString("Count(SessionID)");
                    //cb_StaffID.Items.Add(subj);
                    cb_count.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
        }
        void datecount3()
        {
            DateTime dateod = DateTime.Parse(mc_date_installation.SelectionRange.Start.ToString("yyyy-MM-dd"));

            // int sessionid = int.Parse(txt_SessionID.Text);
            MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
            string command_query = "SELECT Count(SessionID) FROM betterlimited.deliveryorder WHERE SessionID=3 && DeliveryDate=@dateofdelivery;";

            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            //cmd.Parameters.AddWithValue(" @sessionid", sessionid);
            cmd.Parameters.AddWithValue("@dateofdelivery", dateod);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {

                    string subj = mydr.GetString("Count(SessionID)");
                    //cb_StaffID.Items.Add(subj);
                    cb_count.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }
        }
        void add2Time()
        {
            string command_query = "SELECT SessionTime FROM betterlimited.session";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("SessionTime");
                    cb_session.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Session Error");

            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try { 
            if (radioButton1.Checked && txt_cname.Text != "")
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();
                dataGridView1.Rows.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {
                    {

                        var emp = (from list in content.saleorders
                                   where list.InstallationOrderID == null
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            string cname = txt_cname.Text;
                            customer customers = content.customers.First(i => i.FirstName == cname);
                            store stores = content.stores.First(i => i.StoreID == emp2.storeID);
                            if (customers != null && stores != null)
                            {

                                dataGridView1.Rows.Add(emp2.orderID, emp2.Date_Of_Purchase,  customers.Phone1, stores.StoreName);
                            }
                        }
                    }


                }

            }
            else if (radioButton2.Checked && txt_tel.Text != "")
            {
                string phonenumber = combobox_RegionPhone.SelectedItem.ToString() + txt_tel.Text;
                MessageBox.Show("Searching for  Customers that the phonenumber is  " + phonenumber + "'s    Orders");
                {

                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {

                            var emp = (from list in content.saleorders
                                       where list.InstallationOrderID == null
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                string cname = txt_cname.Text;
                                customer customers = content.customers.First(i => i.Phone1 == phonenumber || i.Phone2 == phonenumber);
                                store stores = content.stores.First(i => i.StoreID == emp2.storeID);
                                if (customers != null && stores != null)
                                    {

                                        dataGridView1.Rows.Add(emp2.orderID, emp2.Date_Of_Purchase, customers.Phone1, stores.StoreName);
                                    }
                                }
                        }


                    }

                }
            }
            else if (radioButton3.Checked && cb_StoreName.SelectedItem.ToString() != "") {
                string storeName = cb_StoreName.SelectedItem.ToString();
                dataGridView1.Rows.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {
                    {

                        var emp = (from list in content.saleorders
                                   where list.InstallationOrderID == null
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            string cname = txt_cname.Text;
                            
                            store stores = content.stores.First(i => i.StoreName == storeName);
                            customer customers = content.customers.First(i => i.CustomerID==emp2.CustomerID);
                            if (customers != null && stores != null)
                            {

                                dataGridView1.Rows.Add(emp2.orderID, emp2.Date_Of_Purchase, customers.Phone1, stores.StoreName);
                            }
                        }
                    }


                }






            }
            }
            catch (System.InvalidOperationException) { MessageBox.Show("There is no Result of the following Name:" + txt_cname.Text + "Or Phone:" + combobox_RegionPhone.Text + txt_tel.Text); }















        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lb_SelectProduct_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_CreateInstall_Click(object sender, EventArgs e)
        {


        }

        private void Client_SendCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Error");
                return;
            }
          //  else { MessageBox.Show("Success"); }
        }


        private void btn_add2Install_Click(object sender, EventArgs e)
        {
            if (listbox_pname.Items.Count < 1)
            {
                btn_add2Install.Enabled = false;

            }
            else
            {
                btn_add2Install.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_remove.Enabled = false;

            }
            else
            {
                btn_remove.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_create.Enabled = false;
            }
            else { btn_create.Enabled = true; }
            try
            {
                if (listbox_pname.Items.Count == 1)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }

                }
                if (listbox_pname.Items.Count == 2)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[1].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[1].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[1].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[1].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[1].ToString());
                    }
                }
                if (listbox_pname.Items.Count == 3)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[1].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[1].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[1].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[1].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[1].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[2].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[2].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[2].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[2].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[2].ToString());
                    }
                }
                if (listbox_pname.Items.Count == 4)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[1].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[1].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[1].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[1].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[1].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[2].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[2].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[2].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[2].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[2].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[3].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[3].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[3].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[3].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[3].ToString());
                    }
                }
                if (listbox_pname.Items.Count == 5)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[1].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[1].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[1].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[1].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[1].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[2].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[2].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[2].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[2].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[2].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[3].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[3].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[3].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[3].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[3].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[4].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[4].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[4].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[4].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[4].ToString());
                    }
                }
                if (listbox_pname.Items.Count == 6)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[1].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[1].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[1].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[1].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[1].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[2].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[2].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[2].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[2].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[2].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[3].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[3].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[3].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[3].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[3].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[4].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[4].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[4].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[4].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[4].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[5].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[5].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[5].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[5].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[5].ToString());
                    }
                }
                if (listbox_pname.Items.Count == 7)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[1].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[1].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[1].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[1].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[1].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[2].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[2].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[2].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[2].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[2].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[3].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[3].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[3].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[3].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[3].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[4].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[4].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[4].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[4].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[4].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[5].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[5].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[5].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[5].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[5].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[6].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[6].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[6].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[6].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[6].ToString());
                    }
                }
                if (listbox_pname.Items.Count == 8)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[1].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[1].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[1].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[1].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[1].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[2].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[2].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[2].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[2].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[2].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[3].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[3].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[3].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[3].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[3].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[4].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[4].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[4].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[4].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[4].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[5].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[5].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[5].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[5].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[5].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[6].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[6].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[6].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[6].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[6].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[7].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[7].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[7].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[7].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[7].ToString());
                    }
                }
                if (listbox_pname.Items.Count == 9)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[1].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[1].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[1].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[1].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[1].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[2].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[2].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[2].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[2].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[2].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[3].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[3].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[3].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[3].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[3].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[4].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[4].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[4].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[4].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[4].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[5].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[5].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[5].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[5].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[5].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[6].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[6].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[6].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[6].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[6].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[7].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[7].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[7].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[7].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[7].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[8].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[8].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[8].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[8].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[8].ToString());
                    }
                }
                if (listbox_pname.Items.Count == 10)
                {
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[0].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[0].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[0].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[0].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[0].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[1].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[1].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[1].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[1].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[1].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[2].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[2].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[2].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[2].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[2].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[3].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[3].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[3].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[3].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[3].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[4].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[4].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[4].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[4].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[4].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[5].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[5].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[5].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[5].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[5].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[6].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[6].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[6].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[6].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[6].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[7].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[7].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[7].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[7].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[7].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[8].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[8].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[8].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[8].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[8].ToString());
                    }
                    if (listbox_pname.SelectedItem.ToString() == listbox_pname.Items[9].ToString())
                    {
                        listbox_Ipname.Items.Add(listbox_pname.Items[9].ToString());
                        listbox_Iqty.Items.Add(listbox_qty.Items[9].ToString());
                        listbox_pname.Items.Remove(listbox_pname.Items[9].ToString());
                        listbox_qty.Items.Remove(listbox_qty.Items[9].ToString());
                    }
                }





            }
            catch (NullReferenceException) { }
        }

        private void timeofInstall_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CreateInstallationOrder_Load(object sender, EventArgs e)
        {
            addtoStore();
            add2Time();
            
            cb_session.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_time.DropDownStyle = ComboBoxStyle.DropDownList;
            DateTime lastDay = new DateTime(DateTime.Now.Year, 12, 31);
            mc_date_installation.MinDate = DateTime.Now;
            mc_date_installation.MaxDate = lastDay;
        
            combobox_sorder.DropDownStyle = ComboBoxStyle.DropDownList;
            btn_Search.Enabled = false;
   
            mc_date_installation.MaxDate = DateTime.Now.AddDays(14);
            cb_StoreName.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_RegionPhone.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_customerID.Enabled = false;
            if (combobox_sorder.Text == null) { btn_Search.Enabled = false; }
            else { btn_Search.Enabled = true; }
            if (listbox_pname.Items.Count < 1)
            {
                btn_add2Install.Enabled = false;

            }
            else
            {
                btn_add2Install.Enabled = true;
            }

            if (listbox_Ipname.Items.Count < 1)
            {
                btn_remove.Enabled = false;

            }
            else
            {
                btn_remove.Enabled = true;
            }
            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }
            else
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
            }

           
            mySubjects();
            cb_StoreName.Enabled = false;
            listbox_Iqty.Enabled = false;
            listbox_qty.Enabled = false;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            combobox_RegionPhone.DropDownStyle = ComboBoxStyle.DropDownList;
            if (combobox_RegionPhone.SelectedItem.ToString() == "+852")
            {
                txt_tel.MaxLength = 8;
                txt_tel.Clear();
            }
            if (combobox_RegionPhone.SelectedItem.ToString() == "+86")
            {
                txt_tel.MaxLength = 11;
                txt_tel.Clear();
            }
            if (txt_cname.Text == "" && txt_tel.Text == "")
            {
                btn_Search.Enabled = false;


            }
            else
            {
                btn_Search.Enabled = true;
            }
            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combobox_sorder.SelectedItem.ToString() == null) { btn_Search.Enabled = false; }
            else { btn_Search.Enabled = true; }
            listbox_pname.Items.Clear();
            listbox_qty.Items.Clear();
            listbox_Ipname.Items.Clear();
            listbox_Iqty.Items.Clear();

        }

        private void btn_Searchproduct_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int orderID = int.Parse(combobox_sorder.SelectedItem.ToString());
                    saleorder saleorders = content.saleorders.First(i => i.orderID == orderID);
                    if (saleorders != null)
                    {
                        txt_dorder.Text = saleorders.DeliveryOrderID.ToString();
                    }
                    int dorderID = int.Parse(txt_dorder.Text);
                    deliveryorder deliveryorders = content.deliveryorders.First(i => i.DeliveryOrderID == dorderID);
                    {
                        mc_date_installation.MinDate = DateTime.Parse(deliveryorders.DeliveryDate.ToString());

                    }
                }
                if (listbox_pname.Items.Count < 1)
                {
                    btn_add2Install.Enabled = false;

                }
                else
                {
                    btn_add2Install.Enabled = true;
                }

                if (listbox_Ipname.Items.Count < 1)
                {
                    btn_remove.Enabled = false;

                }
                else
                {
                    btn_remove.Enabled = true;
                }

                int saleorderID;
                saleorderID = int.Parse(combobox_sorder.SelectedItem.ToString());
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    {
                        int saleorderIDD = int.Parse(combobox_sorder.SelectedItem.ToString());
                        saleorder saleorders1 = content.saleorders.First(i => i.orderID == saleorderIDD);
                        if (saleorders1 != null)
                        {
                            int customerIDD = int.Parse(saleorders1.CustomerID.ToString());
                            txt_customerID.Text = customerIDD.ToString();

                        }


                    }
                    listbox_pname.Items.Clear();
                    listbox_qty.Items.Clear();
                    listbox_Ipname.Items.Clear();
                    listbox_Iqty.Items.Clear();

                    saleorder c = content.saleorders.First(i => i.orderID == saleorderID);


                    if (c != null)
                    {
                        if (c.Product1_ID != 0)
                        {
                            txt_product1ID.Text = c.Product1_ID.ToString();
                            if (c.Product1_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product1_Qty.ToString());
                            }


                        }
                        if (c.Product2_ID != 0)
                        {
                            txt_product2ID.Text = c.Product2_ID.ToString();
                            if (c.Product2_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product2_Qty.ToString());
                            }


                        }
                        if (c.Product3_ID != 0)
                        {
                            txt_product3ID.Text = c.Product3_ID.ToString();
                            if (c.Product3_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product3_Qty.ToString());
                            }

                        }
                        if (c.Product4_ID != 0)
                        {
                            txt_product4ID.Text = c.Product4_ID.ToString();
                            if (c.Product4_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product4_Qty.ToString());
                            }

                        }
                        if (c.Product5_ID != 0)
                        {
                            txt_product5ID.Text = c.Product5_ID.ToString();
                            if (c.Product5_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product5_Qty.ToString());
                            }

                        }
                        if (c.Product6_ID != 0)
                        {
                            txt_product6ID.Text = c.Product6_ID.ToString();
                            if (c.Product6_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product6_Qty.ToString());
                            }

                        }
                        if (c.Product7_ID != 0)
                        {
                            txt_product7ID.Text = c.Product7_ID.ToString();
                            if (c.Product7_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product7_Qty.ToString());
                            }

                        }
                        if (c.Product8_ID != 0)
                        {
                            txt_product8ID.Text = c.Product8_ID.ToString();
                            if (c.Product8_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product8_Qty.ToString());
                            }

                        }
                        if (c.Product9_ID != 0)
                        {
                            txt_product9ID.Text = c.Product9_ID.ToString();
                            if (c.Product9_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product9_Qty.ToString());
                            }

                        }
                        if (c.Product10_ID != 0)
                        {
                            txt_product9ID.Text = c.Product10_ID.ToString();
                            if (c.Product10_Qty != 0)
                            {
                                listbox_qty.Items.Add(c.Product10_Qty.ToString());
                            }

                        }




                    }
                    int Product1ID;
                    int Product2ID;
                    int Product3ID;
                    int Product4ID;
                    int Product5ID;
                    int Product6ID;
                    int Product7ID;
                    int Product8ID;
                    int Product9ID;
                    int Product10ID;

                    if (txt_product1ID.Text != "")
                    {
                        Product1ID = int.Parse(txt_product1ID.Text);
                    }
                    else { Product1ID = 0; }
                    if (txt_product2ID.Text != "")
                    {
                        Product2ID = int.Parse(txt_product2ID.Text);
                    }
                    else { Product2ID = 0; }
                    if (txt_product3ID.Text != "")
                    { Product3ID = int.Parse(txt_product3ID.Text); }
                    else { Product3ID = 0; }
                    if (txt_product4ID.Text != "")
                    {
                        Product4ID = int.Parse(txt_product4ID.Text);
                    }
                    else { Product4ID = 0; }
                    if (txt_product5ID.Text != "")
                    {
                        Product5ID = int.Parse(txt_product5ID.Text);
                    }
                    else { Product5ID = 0; }
                    if (txt_product6ID.Text != "")
                    {
                        Product6ID = int.Parse(txt_product6ID.Text);
                    }
                    else { Product6ID = 0; }
                    if (txt_product7ID.Text != "")
                    {
                        Product7ID = int.Parse(txt_product7ID.Text);
                    }
                    else { Product7ID = 0; }
                    if (txt_product8ID.Text != "")
                    {
                        Product8ID = int.Parse(txt_product8ID.Text);
                    }
                    else { Product8ID = 0; }
                    if (txt_product9ID.Text != "")
                    {
                        Product9ID = int.Parse(txt_product9ID.Text);
                    }
                    else { Product9ID = 0; }
                    if (txt_product10ID.Text != "")
                    {
                        Product10ID = int.Parse(txt_product10ID.Text);
                    }
                    else { Product10ID = 0; }

                    product p1 = content.products.First(i => i.ProductID == Product1ID);
                    if (p1 != null)
                    {
                        if (p1.ProductName != "")
                        {
                            listbox_pname.Items.Add(p1.ProductName);
                        }
                    }
                    product p2 = content.products.First(i => i.ProductID == Product2ID);
                    if (p2 != null)
                    {
                        if (p2.ProductName != "")
                        {
                            listbox_pname.Items.Add(p2.ProductName);
                        }
                    }
                    product p3 = content.products.First(i => i.ProductID == Product3ID);
                    if (p3 != null)
                    {
                        if (p3.ProductName != "")
                        {
                            listbox_pname.Items.Add(p3.ProductName);
                        }
                    }
                    product p4 = content.products.First(i => i.ProductID == Product4ID);
                    if (p4 != null)
                    {
                        if (p4.ProductName != "")
                        {
                            listbox_pname.Items.Add(p4.ProductName);
                        }
                    }
                    product p5 = content.products.First(i => i.ProductID == Product5ID);
                    if (p5 != null)
                    {
                        if (p5.ProductName != "")
                        {
                            listbox_pname.Items.Add(p5.ProductName);
                        }
                    }
                    product p6 = content.products.First(i => i.ProductID == Product6ID);
                    if (p6 != null)
                    {
                        if (p6.ProductName != "")
                        {
                            listbox_pname.Items.Add(p6.ProductName);
                        }
                    }
                    product p7 = content.products.First(i => i.ProductID == Product7ID);
                    if (p7 != null)
                    {
                        if (p7.ProductName != "")
                        {
                            listbox_pname.Items.Add(p7.ProductName);
                        }
                    }
                    product p8 = content.products.First(i => i.ProductID == Product8ID);
                    if (p8 != null)
                    {
                        if (p8.ProductName != "")
                        {
                            listbox_pname.Items.Add(p8.ProductName);
                        }
                    }
                    product p9 = content.products.First(i => i.ProductID == Product9ID);
                    if (p9 != null)
                    {
                        if (p9.ProductName != "")
                        {
                            listbox_pname.Items.Add(p9.ProductName);
                        }
                    }
                    product p10 = content.products.First(i => i.ProductID == Product10ID);
                    if (p10 != null)
                    {
                        if (p10.ProductName != "")
                        {
                            listbox_pname.Items.Add(p10.ProductName);
                        }



                        txt_product1ID.Clear();
                        txt_product2ID.Clear();
                        txt_product3ID.Clear();
                        txt_product4ID.Clear();
                        txt_product5ID.Clear();
                        txt_product6ID.Clear();
                        txt_product7ID.Clear();
                        txt_product8ID.Clear();
                        txt_product9ID.Clear();
                        txt_product10ID.Clear();
                    }

             
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Order"); }
            catch (System.FormatException) { MessageBox.Show("The Sale Order Do Not Contain Delivery Order. Please Check if The Sale Order Has Delivery Order. You May Need To Make a Delivery Order First"); }
            }

        private void listbox_qty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_pname.Items.Count < 1)
            {
                btn_add2Install.Enabled = false;

            }
            else
            {
                btn_add2Install.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_remove.Enabled = false;

            }
            else
            {
                btn_remove.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_create.Enabled = false;
            }
            else { btn_create.Enabled = true; }


        }

        private void listbox_pname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_pname.Items.Count < 1)
            {
                btn_add2Install.Enabled = false;

            }
            else
            {
                btn_add2Install.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_remove.Enabled = false;

            }
            else
            {
                btn_remove.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_create.Enabled = false;
            }
            else { btn_create.Enabled = true; }

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listbox_Ipname_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_pname.Items.Count < 1)
            {
                btn_add2Install.Enabled = false;

            }
            else
            {
                btn_add2Install.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_remove.Enabled = false;

            }
            else
            {
                btn_remove.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_create.Enabled = false;
            }
            else { btn_create.Enabled = true; }
        }

        private void dateofInstall_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {

                    DateTime dateod = DateTime.Parse(mc_date_installation.SelectionRange.Start.ToString("yyyy-MM-dd"));
                    if (dateod.DayOfWeek == DayOfWeek.Sunday)
                    {
                        throw new KeyNotFoundException();

                    }
                    DateSystem.LicenseKey = "LostTimeIsNeverFoundAgain";
                    // var publicHolidays = DateSystem.GetPublicHolidays(2022, CountryCode.HK);
                    if (DateSystem.IsPublicHoliday(dateod, CountryCode.GB))
                    {
                        throw new InvalidCastException();

                    }
                    if (DateSystem.IsPublicHoliday(dateod, CountryCode.CN))
                    {
                        throw new InvalidCastException();

                    }
                    if (listbox_Ipname.Items.Count < 1)
                    {
                        throw new NotSupportedException();
                    }
                    DateTimePicker d = new DateTimePicker();
                    cb_count.Items.Clear();
              
                    if (cb_session.SelectedItem.ToString() == "Morning")
                    {
                        txt_SessionID.Text = "1";
                        datecount1();
                    }
                    if (cb_session.SelectedItem.ToString() == "Afternoon")
                    {
                        txt_SessionID.Text = "2";
                        datecount2();
                    }
                    if (cb_session.SelectedItem.ToString() == "Evening")
                    {
                        txt_SessionID.Text = "3";
                        datecount3();
                    }



                    if (int.Parse(cb_count.Items[0].ToString()) >= 5)
                    {
                        //MessageBox.Show("The Time is Not Available");
                        throw new EvaluateException();
                    }










                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())

                    {
                        string productIID1;
                        string productIID2;
                        string productIID3;
                        string productIID4;
                        string productIID5;
                        string productIID6;
                        string productIID7;
                        string productIID8;
                        string productIID9;
                        string productIID10;
                        productIID1 = "";
                        productIID2 = "";
                        productIID3 = "";
                        productIID4 = "";
                        productIID5 = "";
                        productIID6 = "";
                        productIID7 = "";
                        productIID8 = "";
                        productIID9 = "";
                        productIID10 = "";

                        if (listbox_Ipname.Items.Count == 1)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                        }

                        if (listbox_Ipname.Items.Count == 2)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                            productIID2 = listbox_Ipname.Items[1].ToString();

                        }

                        if (listbox_Ipname.Items.Count == 3)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                            productIID2 = listbox_Ipname.Items[1].ToString();
                            productIID3 = listbox_Ipname.Items[2].ToString();
                        }


                        if (listbox_Ipname.Items.Count == 4)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                            productIID2 = listbox_Ipname.Items[1].ToString();
                            productIID3 = listbox_Ipname.Items[2].ToString();
                            productIID4 = listbox_Ipname.Items[3].ToString();
                        }

                        if (listbox_Ipname.Items.Count == 5)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                            productIID2 = listbox_Ipname.Items[1].ToString();
                            productIID3 = listbox_Ipname.Items[2].ToString();
                            productIID4 = listbox_Ipname.Items[3].ToString();
                            productIID5 = listbox_Ipname.Items[4].ToString();
                        }

                        if (listbox_Ipname.Items.Count == 6)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                            productIID2 = listbox_Ipname.Items[1].ToString();
                            productIID3 = listbox_Ipname.Items[2].ToString();
                            productIID4 = listbox_Ipname.Items[3].ToString();
                            productIID5 = listbox_Ipname.Items[4].ToString();
                            productIID6 = listbox_Ipname.Items[5].ToString();
                        }

                        if (listbox_Ipname.Items.Count == 7)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                            productIID2 = listbox_Ipname.Items[1].ToString();
                            productIID3 = listbox_Ipname.Items[2].ToString();
                            productIID4 = listbox_Ipname.Items[3].ToString();
                            productIID5 = listbox_Ipname.Items[4].ToString();
                            productIID6 = listbox_Ipname.Items[5].ToString();
                            productIID7 = listbox_Ipname.Items[6].ToString();
                        }

                        if (listbox_Ipname.Items.Count == 8)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                            productIID2 = listbox_Ipname.Items[1].ToString();
                            productIID3 = listbox_Ipname.Items[2].ToString();
                            productIID4 = listbox_Ipname.Items[3].ToString();
                            productIID5 = listbox_Ipname.Items[4].ToString();
                            productIID6 = listbox_Ipname.Items[5].ToString();
                            productIID7 = listbox_Ipname.Items[6].ToString();
                            productIID8 = listbox_Ipname.Items[7].ToString();
                        }

                        if (listbox_Ipname.Items.Count == 9)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                            productIID2 = listbox_Ipname.Items[1].ToString();
                            productIID3 = listbox_Ipname.Items[2].ToString();
                            productIID4 = listbox_Ipname.Items[3].ToString();
                            productIID5 = listbox_Ipname.Items[4].ToString();
                            productIID6 = listbox_Ipname.Items[5].ToString();
                            productIID7 = listbox_Ipname.Items[6].ToString();
                            productIID8 = listbox_Ipname.Items[7].ToString();
                            productIID9 = listbox_Ipname.Items[8].ToString();
                        }

                        if (listbox_Ipname.Items.Count == 10)
                        {
                            productIID1 = listbox_Ipname.Items[0].ToString();
                            productIID2 = listbox_Ipname.Items[1].ToString();
                            productIID3 = listbox_Ipname.Items[2].ToString();
                            productIID4 = listbox_Ipname.Items[3].ToString();
                            productIID5 = listbox_Ipname.Items[4].ToString();
                            productIID6 = listbox_Ipname.Items[5].ToString();
                            productIID7 = listbox_Ipname.Items[6].ToString();
                            productIID8 = listbox_Ipname.Items[7].ToString();
                            productIID9 = listbox_Ipname.Items[8].ToString();
                            productIID10 = listbox_Ipname.Items[9].ToString();
                        }





                        if (productIID1 != "")


                        {

                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                        }
                        else if (productIID2 != "")


                        {

                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                            product p2 = content.products.First(i => i.ProductName == productIID2);
                            if (p2 != null)
                            {
                                int PIID2 = p2.ProductID;
                                txt_PID2.Text = PIID2.ToString();

                            }
                        }
                        else if (productIID3 != "")


                        {


                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                            product p2 = content.products.First(i => i.ProductName == productIID2);
                            if (p2 != null)
                            {
                                int PIID2 = p2.ProductID;
                                txt_PID2.Text = PIID2.ToString();

                            }
                            product p3 = content.products.First(i => i.ProductName == productIID3);
                            if (p3 != null)
                            {
                                int PIID3 = p3.ProductID;
                                txt_PID3.Text = PIID3.ToString();

                            }

                        }
                        else if (productIID4 != "")


                        {


                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                            product p2 = content.products.First(i => i.ProductName == productIID2);
                            if (p2 != null)
                            {
                                int PIID2 = p2.ProductID;
                                txt_PID2.Text = PIID2.ToString();

                            }
                            product p3 = content.products.First(i => i.ProductName == productIID3);
                            if (p3 != null)
                            {
                                int PIID3 = p3.ProductID;
                                txt_PID3.Text = PIID3.ToString();

                            }
                            product p4 = content.products.First(i => i.ProductName == productIID4);
                            if (p4 != null)
                            {
                                int PIID4 = p4.ProductID;
                                txt_PID4.Text = PIID4.ToString();

                            }





                        }
                        else if (productIID5 != "")


                        {


                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                            product p2 = content.products.First(i => i.ProductName == productIID2);
                            if (p2 != null)
                            {
                                int PIID2 = p2.ProductID;
                                txt_PID2.Text = PIID2.ToString();

                            }
                            product p3 = content.products.First(i => i.ProductName == productIID3);
                            if (p3 != null)
                            {
                                int PIID3 = p3.ProductID;
                                txt_PID3.Text = PIID3.ToString();

                            }
                            product p4 = content.products.First(i => i.ProductName == productIID4);
                            if (p4 != null)
                            {
                                int PIID4 = p4.ProductID;
                                txt_PID4.Text = PIID4.ToString();

                            }
                            product p5 = content.products.First(i => i.ProductName == productIID5);
                            if (p5 != null)
                            {
                                int PIID5 = p5.ProductID;
                                txt_PID5.Text = PIID5.ToString();

                            }


                        }
                        else if (productIID6 != "")


                        {


                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                            product p2 = content.products.First(i => i.ProductName == productIID2);
                            if (p2 != null)
                            {
                                int PIID2 = p2.ProductID;
                                txt_PID2.Text = PIID2.ToString();

                            }
                            product p3 = content.products.First(i => i.ProductName == productIID3);
                            if (p3 != null)
                            {
                                int PIID3 = p3.ProductID;
                                txt_PID3.Text = PIID3.ToString();

                            }
                            product p4 = content.products.First(i => i.ProductName == productIID4);
                            if (p4 != null)
                            {
                                int PIID4 = p4.ProductID;
                                txt_PID4.Text = PIID4.ToString();

                            }
                            product p5 = content.products.First(i => i.ProductName == productIID5);
                            if (p5 != null)
                            {
                                int PIID5 = p5.ProductID;
                                txt_PID5.Text = PIID5.ToString();

                            }
                            product p6 = content.products.First(i => i.ProductName == productIID6);
                            if (p6 != null)
                            {
                                int PIID6 = p6.ProductID;
                                txt_PID6.Text = PIID6.ToString();

                            }

                        }
                        else if (productIID7 != "")


                        {


                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                            product p2 = content.products.First(i => i.ProductName == productIID2);
                            if (p2 != null)
                            {
                                int PIID2 = p2.ProductID;
                                txt_PID2.Text = PIID2.ToString();

                            }
                            product p3 = content.products.First(i => i.ProductName == productIID3);
                            if (p3 != null)
                            {
                                int PIID3 = p3.ProductID;
                                txt_PID3.Text = PIID3.ToString();

                            }
                            product p4 = content.products.First(i => i.ProductName == productIID4);
                            if (p4 != null)
                            {
                                int PIID4 = p4.ProductID;
                                txt_PID4.Text = PIID4.ToString();

                            }
                            product p5 = content.products.First(i => i.ProductName == productIID5);
                            if (p5 != null)
                            {
                                int PIID5 = p5.ProductID;
                                txt_PID5.Text = PIID5.ToString();

                            }
                            product p6 = content.products.First(i => i.ProductName == productIID6);
                            if (p6 != null)
                            {
                                int PIID6 = p6.ProductID;
                                txt_PID6.Text = PIID6.ToString();

                            }
                            product p7 = content.products.First(i => i.ProductName == productIID7);
                            if (p7 != null)
                            {
                                int PIID7 = p7.ProductID;
                                txt_PID7.Text = PIID7.ToString();

                            }

                        }
                        else if (productIID8 != "")


                        {


                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                            product p2 = content.products.First(i => i.ProductName == productIID2);
                            if (p2 != null)
                            {
                                int PIID2 = p2.ProductID;
                                txt_PID2.Text = PIID2.ToString();

                            }
                            product p3 = content.products.First(i => i.ProductName == productIID3);
                            if (p3 != null)
                            {
                                int PIID3 = p3.ProductID;
                                txt_PID3.Text = PIID3.ToString();

                            }
                            product p4 = content.products.First(i => i.ProductName == productIID4);
                            if (p4 != null)
                            {
                                int PIID4 = p4.ProductID;
                                txt_PID4.Text = PIID4.ToString();

                            }
                            product p5 = content.products.First(i => i.ProductName == productIID5);
                            if (p5 != null)
                            {
                                int PIID5 = p5.ProductID;
                                txt_PID5.Text = PIID5.ToString();

                            }
                            product p6 = content.products.First(i => i.ProductName == productIID6);
                            if (p6 != null)
                            {
                                int PIID6 = p6.ProductID;
                                txt_PID6.Text = PIID6.ToString();

                            }
                            product p7 = content.products.First(i => i.ProductName == productIID7);
                            if (p7 != null)
                            {
                                int PIID7 = p7.ProductID;
                                txt_PID7.Text = PIID7.ToString();

                            }
                            product p8 = content.products.First(i => i.ProductName == productIID8);
                            if (p8 != null)
                            {
                                int PIID8 = p8.ProductID;
                                txt_PID8.Text = PIID8.ToString();

                            }

                        }
                        else if (productIID9 != "")


                        {


                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                            product p2 = content.products.First(i => i.ProductName == productIID2);
                            if (p2 != null)
                            {
                                int PIID2 = p2.ProductID;
                                txt_PID2.Text = PIID2.ToString();

                            }
                            product p3 = content.products.First(i => i.ProductName == productIID3);
                            if (p3 != null)
                            {
                                int PIID3 = p3.ProductID;
                                txt_PID3.Text = PIID3.ToString();

                            }
                            product p4 = content.products.First(i => i.ProductName == productIID4);
                            if (p4 != null)
                            {
                                int PIID4 = p4.ProductID;
                                txt_PID4.Text = PIID4.ToString();

                            }
                            product p5 = content.products.First(i => i.ProductName == productIID5);
                            if (p5 != null)
                            {
                                int PIID5 = p5.ProductID;
                                txt_PID5.Text = PIID5.ToString();

                            }
                            product p6 = content.products.First(i => i.ProductName == productIID6);
                            if (p6 != null)
                            {
                                int PIID6 = p6.ProductID;
                                txt_PID6.Text = PIID6.ToString();

                            }
                            product p7 = content.products.First(i => i.ProductName == productIID7);
                            if (p7 != null)
                            {
                                int PIID7 = p7.ProductID;
                                txt_PID7.Text = PIID7.ToString();

                            }
                            product p8 = content.products.First(i => i.ProductName == productIID8);
                            if (p8 != null)
                            {
                                int PIID8 = p8.ProductID;
                                txt_PID8.Text = PIID8.ToString();

                            }
                            product p9 = content.products.First(i => i.ProductName == productIID9);
                            if (p9 != null)
                            {
                                int PIID9 = p9.ProductID;
                                txt_PID9.Text = PIID9.ToString();

                            }

                        }
                        else if (productIID10 != "")


                        {


                            product p1 = content.products.First(i => i.ProductName == productIID1);

                            if (p1 != null)
                            {
                                int PIID1 = p1.ProductID;
                                txt_PID1.Text = PIID1.ToString();

                            }
                            product p2 = content.products.First(i => i.ProductName == productIID2);
                            if (p2 != null)
                            {
                                int PIID2 = p2.ProductID;
                                txt_PID2.Text = PIID2.ToString();

                            }
                            product p3 = content.products.First(i => i.ProductName == productIID3);
                            if (p3 != null)
                            {
                                int PIID3 = p3.ProductID;
                                txt_PID3.Text = PIID3.ToString();

                            }
                            product p4 = content.products.First(i => i.ProductName == productIID4);
                            if (p4 != null)
                            {
                                int PIID4 = p4.ProductID;
                                txt_PID4.Text = PIID4.ToString();

                            }
                            product p5 = content.products.First(i => i.ProductName == productIID5);
                            if (p5 != null)
                            {
                                int PIID5 = p5.ProductID;
                                txt_PID5.Text = PIID5.ToString();

                            }
                            product p6 = content.products.First(i => i.ProductName == productIID6);
                            if (p6 != null)
                            {
                                int PIID6 = p6.ProductID;
                                txt_PID6.Text = PIID6.ToString();

                            }
                            product p7 = content.products.First(i => i.ProductName == productIID7);
                            if (p7 != null)
                            {
                                int PIID7 = p7.ProductID;
                                txt_PID7.Text = PIID7.ToString();

                            }
                            product p8 = content.products.First(i => i.ProductName == productIID8);
                            if (p8 != null)
                            {
                                int PIID8 = p8.ProductID;
                                txt_PID8.Text = PIID8.ToString();

                            }
                            product p9 = content.products.First(i => i.ProductName == productIID9);
                            if (p9 != null)
                            {
                                int PIID9 = p9.ProductID;
                                txt_PID9.Text = PIID9.ToString();

                            }
                            product p10 = content.products.First(i => i.ProductName == productIID10);
                            if (p10 != null)
                            {
                                int PIID10 = p10.ProductID;
                                txt_PID10.Text = PIID10.ToString();

                            }

                        }
                        //TimeSpan ts_time = TimeSpan.Parse(timeofInstall.Value.ToString("HH:mm"));

                        // DateTime dateod = DateTime.Parse(mc_date_installation.SelectionRange.Start.ToString("yyyy-MM-dd"));
                        if (txt_PID1.Text == "")
                        {
                            txt_PID1.Text = "0";
                        }
                        if (txt_PID2.Text == "")
                        {
                            txt_PID2.Text = "0";
                        }
                        if (txt_PID3.Text == "")
                        {
                            txt_PID3.Text = "0";
                        }
                        if (txt_PID4.Text == "")
                        {
                            txt_PID4.Text = "0";
                        }
                        if (txt_PID5.Text == "")
                        {
                            txt_PID5.Text = "0";
                        }
                        if (txt_PID6.Text == "")
                        {
                            txt_PID6.Text = "0";
                        }
                        if (txt_PID7.Text == "")
                        {
                            txt_PID7.Text = "0";
                        }
                        if (txt_PID8.Text == "")
                        {
                            txt_PID8.Text = "0";
                        }
                        if (txt_PID9.Text == "")
                        {
                            txt_PID9.Text = "0";
                        }
                        if (txt_PID10.Text == "")
                        {
                            txt_PID10.Text = "0";
                        }
                        if (listbox_Iqty.Items.Count == 1)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();


                        }
                        if (listbox_Iqty.Items.Count == 2)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();
                            p2qty.Text = listbox_Iqty.Items[1].ToString();

                        }
                        if (listbox_Iqty.Items.Count == 3)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();
                            p2qty.Text = listbox_Iqty.Items[1].ToString();
                            p3qty.Text = listbox_Iqty.Items[2].ToString();

                        }
                        if (listbox_Iqty.Items.Count == 4)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();
                            p2qty.Text = listbox_Iqty.Items[1].ToString();
                            p3qty.Text = listbox_Iqty.Items[2].ToString();
                            p4qty.Text = listbox_Iqty.Items[3].ToString();

                        }
                        if (listbox_Iqty.Items.Count == 5)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();
                            p2qty.Text = listbox_Iqty.Items[1].ToString();
                            p3qty.Text = listbox_Iqty.Items[2].ToString();
                            p4qty.Text = listbox_Iqty.Items[3].ToString();
                            p5qty.Text = listbox_Iqty.Items[4].ToString();

                        }
                        if (listbox_Iqty.Items.Count == 6)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();
                            p2qty.Text = listbox_Iqty.Items[1].ToString();
                            p3qty.Text = listbox_Iqty.Items[2].ToString();
                            p4qty.Text = listbox_Iqty.Items[3].ToString();
                            p5qty.Text = listbox_Iqty.Items[4].ToString();
                            p6qty.Text = listbox_Iqty.Items[5].ToString();

                        }
                        if (listbox_Iqty.Items.Count == 7)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();
                            p2qty.Text = listbox_Iqty.Items[1].ToString();
                            p3qty.Text = listbox_Iqty.Items[2].ToString();
                            p4qty.Text = listbox_Iqty.Items[3].ToString();
                            p5qty.Text = listbox_Iqty.Items[4].ToString();
                            p6qty.Text = listbox_Iqty.Items[5].ToString();
                            p7qty.Text = listbox_Iqty.Items[6].ToString();


                        }
                        if (listbox_Iqty.Items.Count == 8)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();
                            p2qty.Text = listbox_Iqty.Items[1].ToString();
                            p3qty.Text = listbox_Iqty.Items[2].ToString();
                            p4qty.Text = listbox_Iqty.Items[3].ToString();
                            p5qty.Text = listbox_Iqty.Items[4].ToString();
                            p6qty.Text = listbox_Iqty.Items[5].ToString();
                            p7qty.Text = listbox_Iqty.Items[6].ToString();
                            p8qty.Text = listbox_Iqty.Items[7].ToString();


                        }
                        if (listbox_Iqty.Items.Count == 9)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();
                            p2qty.Text = listbox_Iqty.Items[1].ToString();
                            p3qty.Text = listbox_Iqty.Items[2].ToString();
                            p4qty.Text = listbox_Iqty.Items[3].ToString();
                            p5qty.Text = listbox_Iqty.Items[4].ToString();
                            p6qty.Text = listbox_Iqty.Items[5].ToString();
                            p7qty.Text = listbox_Iqty.Items[6].ToString();
                            p8qty.Text = listbox_Iqty.Items[7].ToString();
                            p9qty.Text = listbox_Iqty.Items[8].ToString();

                        }
                        if (listbox_Iqty.Items.Count == 10)
                        {
                            p1qty.Text = listbox_Iqty.Items[0].ToString();
                            p2qty.Text = listbox_Iqty.Items[1].ToString();
                            p3qty.Text = listbox_Iqty.Items[2].ToString();
                            p4qty.Text = listbox_Iqty.Items[3].ToString();
                            p5qty.Text = listbox_Iqty.Items[4].ToString();
                            p6qty.Text = listbox_Iqty.Items[5].ToString();
                            p7qty.Text = listbox_Iqty.Items[6].ToString();
                            p8qty.Text = listbox_Iqty.Items[7].ToString();
                            p9qty.Text = listbox_Iqty.Items[8].ToString();
                            p10qty.Text = listbox_Iqty.Items[9].ToString();
                        }
                        if (p1qty.Text == "")
                        {
                            p1qty.Text = "0";
                        }
                        if (p2qty.Text == "")
                        {
                            p2qty.Text = "0";
                        }
                        if (p3qty.Text == "")
                        {
                            p3qty.Text = "0";
                        }
                        if (p4qty.Text == "")
                        {
                            p4qty.Text = "0";
                        }
                        if (p5qty.Text == "")
                        {
                            p5qty.Text = "0";
                        }
                        if (p6qty.Text == "")
                        {
                            p6qty.Text = "0";
                        }
                        if (p7qty.Text == "")
                        {
                            p7qty.Text = "0";
                        }
                        if (p8qty.Text == "")
                        {
                            p8qty.Text = "0";
                        }
                        if (p9qty.Text == "")
                        {
                            p9qty.Text = "0";
                        }
                        if (p10qty.Text == "")
                        {
                            p10qty.Text = "0";
                        }
                        int dorder = int.Parse(txt_dorder.Text);
                        deliveryorder deliveryorders = content.deliveryorders.First(i => i.DeliveryOrderID == dorder);
                        if (deliveryorders != null)
                        {
                            TimeSpan dTime = TimeSpan.Parse(deliveryorders.timeofDelivery.ToString());
                            txt_Time.Text = dTime.ToString();


                            DateTime installationdate = DateTime.Parse(mc_date_installation.SelectionRange.Start.ToString("yyyy-MM-dd"));
                            TimeSpan z1 = TimeSpan.Parse("02:00:00");
                            TimeSpan iTime = TimeSpan.Parse(cb_time.SelectedItem.ToString());
                            TimeSpan diff = iTime - dTime;
                            //MessageBox.Show(diff.ToString());
                            if (installationdate == deliveryorders.DeliveryDate)
                            {
                                if (diff < z1)
                                {
                                    throw new InvalidTimeZoneException();

                                }





                            }



                        }
                        int sessionID = int.Parse(txt_SessionID.Text);
                        schedule schedules = content.schedules.First(i => i.dateofservice == dateod && i.SessionID == sessionID);
                        if (schedules != null)
                        {
                            txt_Iworker.Text = schedules.I_staffID.ToString();

                        }






                        TimeSpan iTime1 = TimeSpan.Parse(cb_time.SelectedItem.ToString());
                        installationorder installations = new installationorder
                        {
                            InstallProduct1 = int.Parse(txt_PID1.Text),
                            InstallProduct2 = int.Parse(txt_PID2.Text),
                            InstallProduct3 = int.Parse(txt_PID3.Text),
                            InstallProduct4 = int.Parse(txt_PID4.Text),
                            InstallProduct5 = int.Parse(txt_PID5.Text),
                            InstallProduct6 = int.Parse(txt_PID6.Text),
                            InstallProduct7 = int.Parse(txt_PID7.Text),
                            InstallProduct8 = int.Parse(txt_PID8.Text),
                            InstallProduct9 = int.Parse(txt_PID9.Text),
                            InstallProduct10 = int.Parse(txt_PID10.Text),
                            InstallProduct1_qty = int.Parse(p1qty.Text),
                            InstallProduct2_qty = int.Parse(p2qty.Text),
                            InstallProduct3_qty = int.Parse(p3qty.Text),
                            InstallProduct4_qty = int.Parse(p4qty.Text),
                            InstallProduct5_qty = int.Parse(p5qty.Text),
                            InstallProduct6_qty = int.Parse(p6qty.Text),
                            InstallProduct7_qty = int.Parse(p7qty.Text),
                            InstallProduct8_qty = int.Parse(p8qty.Text),
                            InstallProduct9_qty = int.Parse(p9qty.Text),
                            InstallProduct10_qty = int.Parse(p10qty.Text),
                            I_Worker = int.Parse(txt_Iworker.Text),
                            InstallationDate = dateod,
                            I_status = "Not Installing",
                            SessionID = int.Parse(txt_SessionID.Text),
                            InstallationTime = iTime1,
                            SaleOrderID = int.Parse(combobox_sorder.SelectedItem.ToString())






                        };





                        content.installationorders.Add(installations);
                        content.SaveChanges();
                        txt_installorder.Text = installations.InstallationOrderID.ToString();

                        {
                            int sorder = int.Parse(combobox_sorder.SelectedItem.ToString());
                            saleorder s = content.saleorders.First(i => i.orderID == sorder);
                            if (s != null)
                            {
                                s.InstallationOrderID = int.Parse(txt_installorder.Text);
                            }
                            content.SaveChanges();

                        }
                        MessageBox.Show("Installation Order Created");
                        MessageBox.Show("Installation Order" + installations.InstallationOrderID);










                        {











                        }
                        if (checkBox_mail.Checked)
                        {
                            int saleorderIDD = int.Parse(combobox_sorder.SelectedItem.ToString());
                            saleorder saleorders = content.saleorders.First(i => i.orderID == saleorderIDD);
                            {
                                int customerIDD = int.Parse(saleorders.CustomerID.ToString());
                                txt_customerID.Text = customerIDD.ToString();

                            }



                            int customerID = int.Parse(txt_customerID.Text);
                            customer customers = content.customers.First(i => i.CustomerID == customerID);
                            if (customers != null)
                            {
                                txt_email.Text = customers.EmailAddress;


                            }



                            SmtpClient Client = new SmtpClient()
                            {
                                Host = "smtp.gmail.com",
                                Port = 587,
                                EnableSsl = true,
                                DeliveryMethod = SmtpDeliveryMethod.Network,
                                UseDefaultCredentials = false,
                                Credentials = new NetworkCredential()
                                {
                                    UserName = "test.betterlimited@gmail.com",
                                    Password = "BetterLimited!@"

                                }
                            };
                            string XD = "Hi";
                            MailAddress FromEmail = new MailAddress("test.betterlimited@gmail.com", "BetterLimited");
                            MailAddress ToEmail = new MailAddress(txt_email.Text, "Someone");
                            MailMessage Message = new MailMessage()
                            {

                                From = FromEmail,
                                Subject = XD,
                                Body = XD,

                            };

                            Message.To.Add(ToEmail);
                            Client.SendCompleted += Client_SendCompleted;
                            Client.SendMailAsync(Message);




                        }
                    }
                }
                catch (NotSupportedException)
                {
                    MessageBox.Show("Please Add At least One Item in the Installation List");
                }
                catch (InvalidTimeZoneException) { MessageBox.Show("The Time Can Not Smaller Than The Delivery Time In 2 Hours"); }
                catch (KeyNotFoundException) { MessageBox.Show("Sorry!The Day Can not be Sunday. Please Try Again."); }
                catch (InvalidCastException) { MessageBox.Show("The Installation Date Can not be Public Holiday Please Try Again"); }
                catch (EvaluateException) { MessageBox.Show("The time is not Available Please try Again!"); }
                catch (System.NullReferenceException) { MessageBox.Show("Please Select the Order That You Want to Make Installation Order"); }
            }

            }
        

        private void btn_remove_Click(object sender, EventArgs e)
        { }


        private void listbox_Iqty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listbox_pname.Items.Count < 1)
            {
                btn_add2Install.Enabled = false;

            }
            else
            {
                btn_add2Install.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_remove.Enabled = false;

            }
            else
            {
                btn_remove.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_create.Enabled = false;
            }
            else { btn_create.Enabled = true; }
        }

        private void txt_cname_TextChanged(object sender, EventArgs e)
        {
            if (txt_cname.Text == "" && txt_tel.Text == "")
            {
                btn_Search.Enabled = false;


            }
            else
            {
                btn_Search.Enabled = true;
            }
            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }





            if (txt_cname.Text == "" && txt_tel.Text == "")
            {
                btn_Search.Enabled = false;


            }
            else
            {
                btn_Search.Enabled = true;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }
        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_tel.Text, "[^0-9]"))
            {

                txt_tel.Text = txt_tel.Text.Remove(txt_tel.Text.Length - 1);
            }
            if (txt_cname.Text == "" && txt_tel.Text == "")
            {
                btn_Search.Enabled = false;


            }
            else
            {
                btn_Search.Enabled = true;
            }
            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }

        }

        private void btn_remove_Click_1(object sender, EventArgs e)
        {
            if (listbox_pname.Items.Count < 1)
            {
                btn_add2Install.Enabled = false;

            }
            else
            {
                btn_add2Install.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_remove.Enabled = false;

            }
            else
            {
                btn_remove.Enabled = true;
            }
            if (listbox_Ipname.Items.Count < 1)
            {
                btn_create.Enabled = false;
            }
            else { btn_create.Enabled = true; }
            try
            {
                if (listbox_Ipname.Items.Count == 1)
                {
                    if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[0].ToString())
                    {
                        listbox_pname.Items.Add(listbox_Ipname.Items[0].ToString());
                        listbox_qty.Items.Add(listbox_Iqty.Items[0].ToString());
                        listbox_Ipname.Items.Remove(listbox_Ipname.Items[0].ToString());
                        listbox_Iqty.Items.Remove(listbox_Iqty.Items[0].ToString());
                    }

                }
                if (listbox_Ipname.Items.Count == 2)
                {
                    for (int x = 0; x <= 1; x++)
                    {
                        if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[x].ToString())
                        {
                            listbox_pname.Items.Add(listbox_Ipname.Items[x].ToString());
                            listbox_qty.Items.Add(listbox_Iqty.Items[x].ToString());
                            listbox_Ipname.Items.Remove(listbox_Ipname.Items[x].ToString());
                            listbox_Iqty.Items.Remove(listbox_Iqty.Items[x].ToString());

                        }
                    }
                }
                if (listbox_Ipname.Items.Count == 3)
                {
                    for (int x = 0; x <= 2; x++)
                    {
                        if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[x].ToString())
                        {
                            listbox_pname.Items.Add(listbox_Ipname.Items[x].ToString());
                            listbox_qty.Items.Add(listbox_Iqty.Items[x].ToString());
                            listbox_Ipname.Items.Remove(listbox_Ipname.Items[x].ToString());
                            listbox_Iqty.Items.Remove(listbox_Iqty.Items[x].ToString());

                        }
                    }
                }
                if (listbox_Ipname.Items.Count == 4)
                {
                    for (int x = 0; x <= 3; x++)
                    {
                        if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[x].ToString())
                        {
                            listbox_pname.Items.Add(listbox_Ipname.Items[x].ToString());
                            listbox_qty.Items.Add(listbox_Iqty.Items[x].ToString());
                            listbox_Ipname.Items.Remove(listbox_Ipname.Items[x].ToString());
                            listbox_Iqty.Items.Remove(listbox_Iqty.Items[x].ToString());

                        }
                    }
                }
                if (listbox_Ipname.Items.Count == 5)
                {
                    for (int x = 0; x <= 4; x++)
                    {
                        if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[x].ToString())
                        {
                            listbox_pname.Items.Add(listbox_Ipname.Items[x].ToString());
                            listbox_qty.Items.Add(listbox_Iqty.Items[x].ToString());
                            listbox_Ipname.Items.Remove(listbox_Ipname.Items[x].ToString());
                            listbox_Iqty.Items.Remove(listbox_Iqty.Items[x].ToString());

                        }
                    }
                }
                if (listbox_Ipname.Items.Count == 6)
                {
                    for (int x = 0; x <= 5; x++)
                    {
                        if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[x].ToString())
                        {
                            listbox_pname.Items.Add(listbox_Ipname.Items[x].ToString());
                            listbox_qty.Items.Add(listbox_Iqty.Items[x].ToString());
                            listbox_Ipname.Items.Remove(listbox_Ipname.Items[x].ToString());
                            listbox_Iqty.Items.Remove(listbox_Iqty.Items[x].ToString());

                        }
                    }
                }
                if (listbox_Ipname.Items.Count == 7)
                {
                    for (int x = 0; x <= 6; x++)
                    {
                        if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[x].ToString())
                        {
                            listbox_pname.Items.Add(listbox_Ipname.Items[x].ToString());
                            listbox_qty.Items.Add(listbox_Iqty.Items[x].ToString());
                            listbox_Ipname.Items.Remove(listbox_Ipname.Items[x].ToString());
                            listbox_Iqty.Items.Remove(listbox_Iqty.Items[x].ToString());

                        }
                    }
                }
                if (listbox_Ipname.Items.Count == 8)
                {
                    for (int x = 0; x <= 7; x++)
                    {
                        if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[x].ToString())
                        {
                            listbox_pname.Items.Add(listbox_Ipname.Items[x].ToString());
                            listbox_qty.Items.Add(listbox_Iqty.Items[x].ToString());
                            listbox_Ipname.Items.Remove(listbox_Ipname.Items[x].ToString());
                            listbox_Iqty.Items.Remove(listbox_Iqty.Items[x].ToString());

                        }
                    }

                }
                if (listbox_Ipname.Items.Count == 9)
                {
                    for (int x = 0; x <= 8; x++)
                    {
                        if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[x].ToString())
                        {
                            listbox_pname.Items.Add(listbox_Ipname.Items[x].ToString());
                            listbox_qty.Items.Add(listbox_Iqty.Items[x].ToString());
                            listbox_Ipname.Items.Remove(listbox_Ipname.Items[x].ToString());
                            listbox_Iqty.Items.Remove(listbox_Iqty.Items[x].ToString());

                        }
                    }
                }
                if (listbox_Ipname.Items.Count == 10)
                {
                    for (int x = 0; x <= 9; x++)
                    {
                        if (listbox_Ipname.SelectedItem.ToString() == listbox_Ipname.Items[x].ToString())
                        {
                            listbox_pname.Items.Add(listbox_Ipname.Items[x].ToString());
                            listbox_qty.Items.Add(listbox_Iqty.Items[x].ToString());
                            listbox_Ipname.Items.Remove(listbox_Ipname.Items[x].ToString());
                            listbox_Iqty.Items.Remove(listbox_Iqty.Items[x].ToString());

                        }
                    }
                }
            }
            catch (NullReferenceException) { }








        }

        private void mc_date_installation_DateChanged(object sender, DateRangeEventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }
            if (txt_cname.Text == "" && txt_tel.Text == "")
            {
                btn_Search.Enabled = false;


            }
            else
            {
                btn_Search.Enabled = true;
            }
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }
            if (txt_cname.Text == "" && txt_tel.Text == "")
            {
                btn_Search.Enabled = false;


            }
            else
            {
                btn_Search.Enabled = true;
            }






        }

        private void txt_cname_TextChanged_1(object sender, EventArgs e)
        {
            if (txt_cname.Text == "" && txt_tel.Text == "")
            {
                btn_Search.Enabled = false;


            }
            else
            {
                btn_Search.Enabled = true;
            }
            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }
        }

        private void txt_tel_TextChanged_1(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txt_tel.Text, "[^0-9]"))
            {

                txt_tel.Text = txt_tel.Text.Remove(txt_tel.Text.Length - 1);
            }
            if (txt_cname.Text == "" && txt_tel.Text == "")
            {
                btn_Search.Enabled = false;


            }
            else
            {
                btn_Search.Enabled = true;
            }
            if (radioButton1.Checked)
            {
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;
                txt_cname.Enabled = true;
                txt_tel.Clear();

            }
            else if (radioButton2.Checked)
            {
                txt_cname.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Clear();

            }

        }

        private void btn_check_Click(object sender, EventArgs e)
        {
           
      

        }

        private void cb_session_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_session.SelectedItem.ToString() == "Morning")
            {
                cb_time.Items.Clear();
                cb_time.Items.Add("9:00");
                cb_time.Items.Add("10:00");
                cb_time.Items.Add("11:00");
                cb_time.Items.Add("12:00");
            }
            if (cb_session.SelectedItem.ToString() == "Afternoon")
            {
                cb_time.Items.Clear();
                cb_time.Items.Add("13:00");
                cb_time.Items.Add("14:00");
                cb_time.Items.Add("15:00");
                cb_time.Items.Add("16:00");
                cb_time.Items.Add("17:00");
            }
            if (cb_session.SelectedItem.ToString() == "Evening")
            {
                cb_time.Items.Clear();
                cb_time.Items.Add("18:00");
                cb_time.Items.Add("19:00");
                cb_time.Items.Add("20:00");
                cb_time.Items.Add("21:00");
                cb_time.Items.Add("22:00");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox_mail_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked ==true) {
                cb_StoreName.Enabled = true;
                combobox_RegionPhone.Enabled = false;
                txt_tel.Enabled = false;
                txt_cname.Enabled = false;

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}





