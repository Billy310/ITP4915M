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
    public partial class Create_Store : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Create_Store()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }
        void mySubjects()
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



        private void btn_Create_Click(object sender, EventArgs e)
        {
            {

                {
                    try
                       
                    {
                        if (cb_Regiontel.SelectedItem.ToString() == "+852" && txt_tel.TextLength < 8)
                        {
                            throw new FormatException();

                        }
                        if (cb_Regiontel.SelectedItem.ToString() == "+86" && txt_tel.TextLength < 11)
                        {
                            throw new FormatException();

                        }
                        if (txt_tel.Text == null)
                        {
                            throw new FormatException();
                        }
                        using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())

                        {
                            string phonenum = cb_Regiontel.SelectedItem.ToString() + txt_tel.Text;
                            store stores = new store
                            {
                                Region = cb_regionname.SelectedItem.ToString() + combo_Region.SelectedItem.ToString(),
                                //Region = "a",
                                Phonenumber = phonenum,
                                //Phonenumber = "a",
                                Address1 = txt_address1.Text,
                                //Address1 = "a",
                                Address2 = txt_address2.Text,
                                // Address2 = "a",
                                Address3 = txt_address3.Text,
                                //Address3= "a",
                                Available = 1,
                                StoreManager = int.Parse(combobox_staffID.SelectedItem.ToString()),
                                StoreName = txt_StoreName.Text


                            };
                            content.stores.Add(stores);
                            content.SaveChanges();
                            MessageBox.Show("Store:   " + stores.StoreID + "Is Created And The Shop Manager is"+stores.StoreManager);

                        }
                    }
                    catch(FormatException) {
                        MessageBox.Show("Please Check the Telephone Textbox is already Enter Phone Number");

                    }
                    catch (System.NullReferenceException) { MessageBox.Show("Make Sure All The Information Are Filled"); }


                }

            }
        }

        private void combo_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (combo_Region.SelectedItem.ToString() == "China")
                {
                    cb_regionname.Items.Clear();
                    cb_regionname.Items.Add("Guangzhou");
                    cb_regionname.Items.Add("Shenzhen");


                    cb_Regiontel.SelectedItem = "+86";
                    txt_tel.MaxLength = 11;

                }
                if (combo_Region.SelectedItem.ToString() == "Hong Kong")
                {
                    cb_regionname.Items.Clear();
                    
                    cb_regionname.Items.Add("New Territories");
                    cb_regionname.Items.Add("Hong Kong Island");
                    cb_regionname.Items.Add("Kowloon Peninsula");
                    cb_Regiontel.SelectedItem = "+852";
                    txt_tel.MaxLength = 8;
                }
                {
                    string line1 = txt_address1.Text;
                    string line2 = txt_address2.Text;
                    string line3 = txt_address3.Text;
                    string region = combo_Region.Text+cb_regionname.Text;
                    StringBuilder queryaddress = new StringBuilder();
                    queryaddress.Append("http://google.com/maps?q=");
                    if (line1 != string.Empty)
                    {
                        queryaddress.Append(line1 + "," + "+");
                    }
                    if (line2 != string.Empty)
                    {
                        queryaddress.Append(line2 + "," + "+");
                    }
                    if (line3 != string.Empty)
                    {
                        queryaddress.Append(line3 + "," + "+");
                    }
                    if (region != string.Empty)
                    {
                        queryaddress.Append(region + "," + "+");
                    }
                    webBrowser1.Navigate(queryaddress.ToString());
                }
            }
            catch (NullReferenceException) { }
        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void CreateStore_Load(object sender, EventArgs e)
        {
            mySubjects();
            cb_regionname.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_staffID.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Regiontel.Enabled = false;
            txt_tel.Enabled = false;
            txt_managername.Enabled = false;
        }

        private void cb_Regiontel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Regiontel != null)
            {
                txt_tel.Enabled = true;


            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                combo_Region.SelectedItem = null;
                cb_regionname.SelectedItem = null;
                txt_tel.Text = null;
                txt_address1.Text = null;
                txt_address2.Text = null;
                txt_address3.Text = null;
                cb_Regiontel.Text = null;
                txt_managername.Text = null;
                combobox_staffID.SelectedItem = null;

            }
        }

        private void combobox_staffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                int a;
                a = int.Parse(combobox_staffID.Text);

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    staff staffs = content.staffs.First(i => i.StaffID == a);

                    if (staffs != null)
                    {

                        txt_managername.Text = staffs.Firstname + "  " + staffs.Lastname;


                    }

                }
            }
            catch { }
        }

        private void txt_managername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txt_address1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string line1 = txt_address1.Text;
                string line2 = txt_address2.Text;
                string line3 = txt_address3.Text;
                string region = cb_regionname.Text + ","+ combo_Region.Text;
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://google.com/maps?q=");
                if (txt_address1.TextLength>=5)
                {
                    queryaddress.Append(line1 + "," + "+");
                }
                if (txt_address2.TextLength >= 5)
                {
                    queryaddress.Append(line2 + "," + "+");
                }
                if (txt_address3.TextLength >= 5)
                {
                    queryaddress.Append(line3 + "," + "+");
                }
                if (region != string.Empty)
                {
                    queryaddress.Append(region + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception) { MessageBox.Show("txt_address1 Error"); }
        }

        private void txt_address2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string line1 = txt_address1.Text;
                string line2 = txt_address2.Text;
                string line3 = txt_address3.Text;
                string region = cb_regionname.Text + "," + combo_Region.Text;
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://google.com/maps?q=");
                if (txt_address1.TextLength >= 5)
                {
                    queryaddress.Append(line1 + "," + "+");
                }
                if (txt_address2.TextLength >= 5)
                {
                    queryaddress.Append(line2 + "," + "+");
                }
                if (txt_address3.TextLength >= 5)
                {
                    queryaddress.Append(line3 + "," + "+");
                }
                if (region != string.Empty)
                {
                    queryaddress.Append(region + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception) { MessageBox.Show("txt_address2 ERROR"); }
        }

        private void txt_address3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string line1 = txt_address1.Text;
                string line2 = txt_address2.Text;
                string line3 = txt_address3.Text;
                string region = cb_regionname.Text + "," + combo_Region.Text;
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://google.com/maps?q=");
                if (txt_address1.TextLength >= 5)
                {
                    queryaddress.Append(line1 + "," + "+");
                }
                if (txt_address2.TextLength >= 5)
                {
                    queryaddress.Append(line2 + "," + "+");
                }
                if (txt_address3.TextLength >= 5)
                {
                    queryaddress.Append(line3 + "," + "+");
                }
                if (region != string.Empty)
                {
                    queryaddress.Append(region + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception) { MessageBox.Show("txt_address3 ERROR"); }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

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
                else { }
            }
            catch (Exception) { MessageBox.Show("btn_Logout_Click ERROR"); }
        }

        private void cb_regionname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string line1 = txt_address1.Text;
                string line2 = txt_address2.Text;
                string line3 = txt_address3.Text;
                string region = cb_regionname.Text + "," + combo_Region.Text;
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://google.com/maps?q=");
                if (txt_address1.TextLength >= 5)
                {
                    queryaddress.Append(line1 + "," + "+");
                }
                if (txt_address2.TextLength >= 5)
                {
                    queryaddress.Append(line2 + "," + "+");
                }
                if (txt_address3.TextLength >= 5)
                {
                    queryaddress.Append(line3 + "," + "+");
                }
                if (region != string.Empty)
                {
                    queryaddress.Append(region + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch (Exception) { MessageBox.Show("cb_regionname ERROR"); }
        }

        private void txt_tel_keypress(object sender, KeyPressEventArgs e)
        {
            try { 
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            }
            catch (Exception) { MessageBox.Show("txt_tel ERROR"); }
        }
    }
}