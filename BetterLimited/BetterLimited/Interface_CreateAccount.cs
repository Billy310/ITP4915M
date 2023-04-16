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
    public partial class Interface_CreateAccount : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Interface_CreateAccount()
        {
            InitializeComponent();
        }
        void getdepartmentname()
        {
            string command_query = "SELECT DepartmentName FROM betterlimited.department";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("DepartmentName");
                    combo_post.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Department Error");
                
            }

        }
        void getstoreName()
        {
            string command_query = "SELECT StoreName FROM betterlimited.store WHERE Available=1";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("StoreName");
                    cb_store.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Store Error");
                
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt_hkidlastdigit.MaxLength = 1;
            txt_HKIDnum.MaxLength = 6;
            txt_HKID_first.MaxLength = 1;
            lab_store.Visible = false;
            cb_store.Visible = false;
            getstoreName();
            txt_Phonenum.Enabled = false;
            getdepartmentname();
            combo_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_regionname.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_post.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_Regionp.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_store.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_pwd.Text != txt_2pwd.Text)
                {
                    throw new IndexOutOfRangeException();
                }
                if (cb_Regionp.SelectedItem.ToString() == "+852" && txt_Phonenum.TextLength < 8)
                {
                    throw new SyntaxErrorException();

                }
                if (cb_Regionp.SelectedItem.ToString() == "+86" && txt_Phonenum.TextLength < 11)
                {
                    throw new SyntaxErrorException();

                }
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                {
                    throw new FormatException();
                }

                if (txt_username.Text.Length < 8)
                {
                    throw new TypeAccessException();
                }
                DateTime today = DateTime.Today;
                DateTime borndate = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                int age = today.Year - borndate.Year;
                if (age < 18)
                {
                    throw new InvalidCastException();
                }

                if (radioButton1.Checked)
                {
                    txt_gender.Text = "M";

                }
                if (radioButton2.Checked)
                {
                    txt_gender.Text = "F";
                }

                if (txt_pwd.Text == txt_2pwd.Text)
                {
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {
                        string departmentpost = combo_post.SelectedItem.ToString();
                        department departments = content.departments.First(i => i.DepartmentName == departmentpost);

                        if (departments != null)
                        {
                            txt_DID.Text = departments.DepartmentID.ToString();

                        }

                        if (int.Parse(txt_DID.Text) == 3 || int.Parse(txt_DID.Text) == 4)
                        {
                            if (cb_store.Text == "")
                            {
                                throw new InvalidOperationException();

                            }
                            else
                            {
                                string sstoreName = cb_store.SelectedItem.ToString();
                                store stores = content.stores.First(i => i.StoreName == sstoreName);
                                if (stores != null)
                                {
                                    txt_storeID.Text = stores.StoreID.ToString();


                                }
                            }
                        }
                        string staffHKID = txt_HKID_first.Text + txt_HKIDnum.Text + "(" + txt_hkidlastdigit.Text + ")";

                        staff staffs = new staff
                        {

                            HKID = staffHKID,
                            BrithDate = borndate,
                            Username = txt_username.Text,
                            Password = txt_pwd.Text,
                            EmailAddress = txt_mail.Text,
                            PhoneNumber = cb_Regionp.SelectedItem.ToString() + txt_Phonenum.Text,
                            AddressLine1 = txt_first.Text,
                            AddressLine2 = txt_second.Text,
                            AddressLine3 = txt_third.Text,
                            Firstname = txt_firstname.Text,
                            Lastname = txt_lastname.Text,
                            Region = combo_Region.SelectedItem.ToString() + "," + cb_regionname.SelectedItem.ToString(),
                            DepartmentID = int.Parse(txt_DID.Text),
                            Gender = txt_gender.Text


                        };

                        content.staffs.Add(staffs);
                        content.SaveChanges();
                        int staffID_int = staffs.StaffID;
                        if (txt_storeID.Text != "")
                        {
                            staff s = content.staffs.First(i => i.StaffID == staffID_int);
                            if (s != null)
                            {
                                s.StoreID = int.Parse(txt_storeID.Text);
                            }
                            content.SaveChanges();
                        }
                        MessageBox.Show("The Account is Created." + "\n" + "Username:" + staffs.Username + "\n" + "Full Name:" + staffs.Lastname + staffs.Firstname);
                    }
                    Interface_CreateAccount c = new Interface_CreateAccount();
                    c.Show();
                    this.Hide();



                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("The Phone Number is Missed"); }
            catch (InvalidCastException) { MessageBox.Show("The Age Should be Larger Than 18 Years Old."); }
            catch (InvalidOperationException) { MessageBox.Show("The Store Do Not Selected.Please Select The Store If You Register As Shop Staffs."); }
            catch (TypeAccessException) { MessageBox.Show("The Username Can Not Shorter Than 8 Digits."); }
            catch (SyntaxErrorException) { MessageBox.Show("The PhoneNumber Is Not On a Correct Format."); }
            catch (IndexOutOfRangeException) { MessageBox.Show("The Passwords that You Entered Are Not The Same, Please Check The Password Is Correctly Entered."); }
            catch (System.Data.Entity.Infrastructure.DbUpdateException) { MessageBox.Show("There is Already Have Username" + txt_username.Text + "Existed." + "\n" + "Please Change the Username"); }
            
          
           

        }
            
            

        private void txt_username_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_EditAccount ed = new Interface_EditAccount();
            ed.Show();
            this.Hide();
        }

        private void combo_access_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                string departmentpost = combo_post.SelectedItem.ToString();
                department departments = content.departments.First(i => i.DepartmentName == departmentpost);

                if (departments != null)
                {
                    txt_DID.Text = departments.DepartmentID.ToString();

                }
              
                if (int.Parse(txt_DID.Text) == 3 || int.Parse(txt_DID.Text) == 4)
                {
                    lab_store.Visible = true;
                    cb_store.Visible = true;
                }
                else
                {

                    lab_store.Visible = false;
                    cb_store.Visible = false;
                }
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
      
        }

        private void cb_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Regionp.SelectedItem.ToString() == "+852")
            {
                txt_Phonenum.MaxLength = 8;
                txt_Phonenum.Enabled = true;
                txt_Phonenum.Clear();
            }
            if (cb_Regionp.SelectedItem.ToString() == "+86")
            {
                txt_Phonenum.MaxLength = 11;
                txt_Phonenum.Enabled = true;
                txt_Phonenum.Clear();
            }
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_Phonenum.Clear();
            txt_pwd.Clear();
            txt_first.Clear();
            txt_second.Clear();
            txt_third.Clear();
            txt_username.Clear();
            txt_2pwd.Clear();
            
            
           
            
        }

        private void cb_gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_pwd.UseSystemPasswordChar = false;

            }
            else
            {

                txt_pwd.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Phonenum_TextChanged(object sender, EventArgs e)
        {
          //  if (System.Text.RegularExpressions.Regex.IsMatch(txt_Phonenum.Text, "[^0-9]"))
           // {

            //    txt_Phonenum.Text = txt_Phonenum.Text.Remove(txt_Phonenum.Text.Length - 1);
          //  }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                txt_gender.Text = "M";
            }
        }

        private void txt_gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txt_gender.Text = "F";
            }
        }

        private void btn_Logout_Click(object sender, EventArgs e)
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

        private void txt_phone_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            //e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void cb_Regionaddress_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_lastname_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void txt_email_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }

        private void combo_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Region.SelectedItem.ToString() == "China")
            {
                cb_regionname.Items.Clear();
                cb_regionname.Items.Add("Guangzhou");
                cb_regionname.Items.Add("Shenzhen");
            }
            if (combo_Region.SelectedItem.ToString() == "Hong Kong")
            {
                cb_regionname.Items.Clear();

                cb_regionname.Items.Add("New Territories");
                cb_regionname.Items.Add("Hong Kong Island");
                cb_regionname.Items.Add("Kowloon Peninsula");
            
            }
        }

        private void lab_access_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void txt_hkidnum_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_lastnum_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_HKID_first_TextChanged(object sender, EventArgs e)
        {
            txt_HKID_first.SelectionStart = txt_HKID_first.Text.Length;
            txt_HKID_first.Text = txt_HKID_first.Text.ToUpper();
        }

        private void txt_Firstdigit_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
    }
}
