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
    public partial class Interface_EditStore : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public Interface_EditStore()
        {
            InitializeComponent();
        }
        void mySubjects()
        {
            string command_query = "SELECT StoreID FROM betterlimited.store";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("StoreID");
                    combobox_storeID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");

            }

        }
        void mySubjects1()
        {
            string command_query = "SELECT StaffID FROM betterlimited.staff WHERE DepartmentID=3";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("StaffID");
                    combobox_staffID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                try
                {
                    string phonenum = txt_tel.Text;

                    if (checkBox_changephonenum.Checked)
                    {
                        phonenum = cb_Regionp.SelectedItem.ToString() + txt_pnum.Text;
                    }
                    store stores = content.stores.First(i => i.StoreID.ToString() == combobox_storeID.SelectedItem.ToString());


                    stores.Phonenumber = txt_tel.Text;
                    stores.Address1 = txt_address1.Text;
                    stores.Address2 = txt_address2.Text;
                    stores.Address3 = txt_address3.Text;
                    if (checkBox_changephonenum.Checked)
                    {
                        stores.Phonenumber = phonenum;
                    }
                    if (checkBox_region.Checked)
                    {
                        stores.Region = combo_Region.SelectedItem.ToString();
                    }
                    if (checkBox_storemanager.Checked)
                    {
                        stores.StoreManager = int.Parse(combobox_staffID.SelectedItem.ToString());
                    }
                    if (checkBox_changename.Checked)
                    {
                        stores.StoreName = txt_newname.Text;

                    }


                    content.SaveChanges();

                    MessageBox.Show("Save!");

                    dataGridView1.Rows.Clear();
                    {

                        var emp = (from list in content.stores
                                   where list.StoreID != 0
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            staff staffs = content.staffs.First(i => i.StaffID == emp2.StoreManager);
                            if (staffs != null)
                            {

                                dataGridView1.Rows.Add(emp2.StoreID, emp2.StoreName, staffs.Firstname);
                            }
                        }



                    }


                }
                catch (Exception) { MessageBox.Show("Check again"); }
            }
        }



            
        

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
          //  int a;
            

          //  using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
          //  {
          //      store c = content.stores.First(i => i.StoreID == a);
             
          //      if (c != null)
          //      {
          //          txt_address1.Text = c.Address1;
          //          txt_address2.Text = c.Address2;
          //          txt_address3.Text = c.Address3;
          //          txt_tel.Text = c.Phonenumber;
          //          int storeid = c.StoreID;
          //          string store_id = storeid.ToString();        
           //         MessageBox.Show("Search,"+c.StoreID);

              //  }

           // }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txt_StoreNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void combo_Region_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txt_address3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void EditStore_Load(object sender, EventArgs e)
        {
            try
            {

                txt_StoreName.Enabled = false;
                txt_region.Enabled = false;
                txt_tel.Enabled = false;
                txt_managername.Enabled = false;
                mySubjects1();
                using (var content = new betterlimitedEntities_Test1())
                {
                    {

                        var emp = (from list in content.stores
                                   where list.StoreID!=0
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            staff staffs = content.staffs.First(i => i.StaffID == emp2.StoreManager);
                            if (staffs != null)
                            {

                                dataGridView1.Rows.Add(emp2.StoreID, emp2.StoreName, staffs.Firstname);
                            }
                        }
                    }


                }

                mySubjects();
                cb_regionname.DropDownStyle = ComboBoxStyle.DropDownList;
                combobox_storeID.DropDownStyle = ComboBoxStyle.DropDownList;
                combobox_staffID.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception) { MessageBox.Show("EditStore ERROR"); }
        }

        private void lab_search_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            { 
                int a;
                a = int.Parse(combobox_storeID.Text);

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    store id = content.stores.First(i => i.StoreID.ToString() == combobox_storeID.SelectedItem.ToString());

                txt_StoreName.Text = id.StoreName;
                    txt_address1.Text = id.Address1;
                    txt_address2.Text = id.Address2;
                    txt_address3.Text = id.Address3;
                    txt_tel.Text = id.Phonenumber;
                txt_region.Text = id.Region;
                combobox_staffID.Text = id.StoreManager.ToString();
                    MessageBox.Show("Search, " + id.StoreID);

                }
            }
            catch (Exception) { MessageBox.Show("comboBox1 ERROR"); }
        }
        
            
        

        private void button1_Click(object sender, EventArgs e)
        {
        

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    store re = content.stores.First(i => i.StoreID.ToString() == combobox_storeID.SelectedItem.ToString());
                    re.Available = 0;

                    content.SaveChanges();
                    MessageBox.Show("Store Removed" + re.StoreID);


                }
            }
            catch (Exception) { MessageBox.Show("button2 ERROR"); }
        }

        private void combo_Region_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {         
                if (combo_Region.SelectedItem.ToString() == "China")
                {
                    cb_regionname.Items.Clear();
                    cb_regionname.Items.Add("Guangzhou");
                    cb_regionname.Items.Add("Shenzhen");


                    cb_Regionp.SelectedItem = "+86";
                    txt_pnum.MaxLength = 11;

                }
                if (combo_Region.SelectedItem.ToString() == "Hong Kong")
                {
                    cb_regionname.Items.Clear();

                    cb_regionname.Items.Add("New Territories");
                    cb_regionname.Items.Add("Hong Kong Island");
                    cb_regionname.Items.Add("Kowloon Peninsula");
                    cb_Regionp.SelectedItem = "+852";
                    txt_pnum.MaxLength = 8;
                }
            }
            catch (Exception) { MessageBox.Show("combo_Region ERROR"); }
        }

        private void label_region_Click(object sender, EventArgs e)
        {

        }

        private void cb_regionname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_region_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_region.Checked)
                {
        
                    combo_Region.Visible = true;
                    cb_regionname.Visible = true;
                }
                else
                {
               
                    combo_Region.Visible = false;
                    cb_regionname.Visible = false;
                }
            }
            catch (Exception) { MessageBox.Show("checkBox_region ERROR"); }
            
        }

        private void checkBox_changephonenum_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_changephonenum.Checked)
                {
                    lab_Phonenum.Visible = true;
                    cb_Regionp.Visible = true;
                    txt_tel.Visible = true;
                }
                else
                {
                    lab_Phonenum.Visible = false;
                    cb_Regionp.Visible = false;
                    txt_tel.Visible = false;
                }
            }
            catch (Exception) { MessageBox.Show("checkBox_changephonenum ERROR"); }
            
        }

        private void combobox_staffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {

                try
                {
                    int a = int.Parse(combobox_staffID.Text);
                    staff staffs = content.staffs.First(i => i.StaffID == a);

                    if (staffs != null)
                    {

                        txt_managername.Text = staffs.Firstname + "  " + staffs.Lastname;

                    }
                }
                catch (Exception) { MessageBox.Show("combobox_staffID ERROR"); }

            }
        }

        private void cb_Regionp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_available_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int storeid = int.Parse(combobox_storeID.SelectedItem.ToString());
                    store re = content.stores.First(i => i.StoreID == storeid);
                    if (re != null)
                    {
                        re.Available = 1;
                    }
                    content.SaveChanges();
                    MessageBox.Show("Store Enable: " + re.StoreID);


                }
            }
            catch (NullReferenceException) { MessageBox.Show("Make Sure That The Store is Already Selected "); }
            
        }

        private void txt_phonenum_keypress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }catch (Exception) { MessageBox.Show("txt_phonenum ERROR"); }

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // this.Close();
                    Interface_Login login = new Interface_Login();
                    login.Show();
                    this.Hide();
                }
            }
            catch (Exception) { MessageBox.Show("btn_Logout ERROR"); }

        }

        private void lab_Thirdaddress_Click(object sender, EventArgs e)
        {

        }
    }
}
