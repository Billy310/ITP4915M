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
    public partial class Interface_EditAccount : Form
    {
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Interface_EditAccount()
        {
            InitializeComponent();
        }
        void mySubjects()
        {
            string command_query = "SELECT StaffID FROM betterlimited.staff ORDER BY StaffID ASC";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("StaffID");
                    cb_StaffID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Staff");

            }

        }
        void staffd2()
        {
            int departmentid = int.Parse(txt_selectdid.Text);
            string command_query = "SELECT StaffID FROM betterlimited.staff WHERE DepartmentID=@did ORDER BY StaffID ASC";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            cmd.Parameters.AddWithValue("@did", departmentid);
            MySqlDataReader mydr;
            try
            {

                Conn.Open();
                mydr = cmd.ExecuteReader();

                while (mydr.Read())
                {
                    string subj = mydr.GetString("StaffID");
                    cb_StaffID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Staff");

            }

        }
        void staffdshop()
        {
            int departmentid = int.Parse(txt_selectdid.Text);
            string command_query = "SELECT StaffID FROM betterlimited.staff WHERE DepartmentID=3 OR DepartmentID=4 ORDER BY StaffID ASC";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            cmd.Parameters.AddWithValue("@did", departmentid);
            MySqlDataReader mydr;
            try
            {

                Conn.Open();
                mydr = cmd.ExecuteReader();

                while (mydr.Read())
                {
                    string subj = mydr.GetString("StaffID");
                    cb_StaffID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Staff");

            }

        }
        void staffdinventory()
        {

            string command_query = "SELECT StaffID FROM betterlimited.staff WHERE DepartmentID=7 OR DepartmentID=8 ORDER BY StaffID ASC";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);

            MySqlDataReader mydr;
            try
            {

                Conn.Open();
                mydr = cmd.ExecuteReader();

                while (mydr.Read())
                {
                    string subj = mydr.GetString("StaffID");
                    cb_StaffID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Staff");

            }

        }
        void staffdpurchase()
        {

            string command_query = "SELECT StaffID FROM betterlimited.staff WHERE DepartmentID=5 OR DepartmentID=6 ORDER BY StaffID ASC";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);

            MySqlDataReader mydr;
            try
            {

                Conn.Open();
                mydr = cmd.ExecuteReader();

                while (mydr.Read())
                {
                    string subj = mydr.GetString("StaffID");
                    cb_StaffID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Staff");

            }

        }
        void staffothers()
        {

            string command_query = "SELECT StaffID FROM betterlimited.staff WHERE DepartmentID=9 OR DepartmentID=12 OR DepartmentID=11 OR DepartmentID=0 OR DepartmentID=1 ORDER BY StaffID ASC";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);

            MySqlDataReader mydr;
            try
            {

                Conn.Open();
                mydr = cmd.ExecuteReader();

                while (mydr.Read())
                {
                    string subj = mydr.GetString("StaffID");
                    cb_StaffID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Staff");

            }

        }
        void addpost()
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
                MessageBox.Show("Department");

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

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {





        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {


                    int staffID = int.Parse(cb_StaffID.SelectedItem.ToString());
                    staff s = content.staffs.First(i => i.StaffID == staffID);
                    DateTime today = DateTime.Today;
                    DateTime borndate = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                    int age = today.Year - borndate.Year;
                    if (age < 18&&checkBox_Dateofbrith.Checked)
                    {
                        throw new InvalidCastException();
                    }
                    if (s != null)
                    {
                        if (checkBox_Dateofbrith.Checked)
                        {

                            s.BrithDate = borndate;
                        }
                        if (checkBox_username.Checked)
                        {
                            s.Username = txt_username.Text;
                        }

                        if (checkBox_lastname.Checked)
                        {
                            s.Lastname = txt_lastname.Text;
                        }
                        if (checkBox_FirstName.Checked)
                        {
                            s.Firstname = txt_firstname.Text;
                        }
                        if (radioButton7.Checked)
                        {
                            s.Gender = "M";
                        }
                        if (radioButton8.Checked)
                        {
                            s.Gender = "F";
                        }
                        s.Username = txt_username.Text;
                        if (checkBox_newpwd.Checked)
                        {
                            s.Password = txt_newpwd.Text;
                        }
                        if (checkBox2.Checked)
                        {
                            s.PhoneNumber = cb_Regionp.SelectedItem.ToString() + txt_tel.Text;
                        }
                        if (checkBox_POST.Checked)
                        {
                            s.DepartmentID = int.Parse(txt_selectdid.Text);
                        }
                        if (checkBox_address.Checked)
                        {
                            s.AddressLine1 = txt_first.Text;
                            s.AddressLine2 = txt_second.Text;
                            s.AddressLine3 = txt_third.Text;
                        }
                        if (checkBox_email.Checked)
                        {
                            s.EmailAddress = txt_email.Text;
                        }
                        if (checkBox_region.Checked)
                        {
                            s.Region = combo_Region.SelectedItem.ToString() + "," + cb_regionname.SelectedItem.ToString();
                        }
                        if (checkBox_HKID.Checked)
                        {
                            s.HKID = txt_HKID_first.Text + txt_HKIDnum.Text + "(" + txt_hkidlastdigit.Text + ")";

                        }

                    }
                    content.SaveChanges();
                    MessageBox.Show("The Account Username: " + s.Username + "  Has Changed the Details");
                }
            }
            catch (NullReferenceException) { MessageBox.Show("Please Select The StaffID First"); }
            catch (InvalidCastException) { MessageBox.Show("The Age Is Not Vaild.Please Check Is It Larger Than 18 Years Old."); }
        }

        private void txt_StaffID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Interface_CreateAccount a = new Interface_CreateAccount();
            a.Show();
            this.Hide();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {

        }

        private void aEdit_Load(object sender, EventArgs e)
        {
            mySubjects();
            //  cb_Regionaddress.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_StaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_post.DropDownStyle = ComboBoxStyle.DropDownList;


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
            cb_StaffID.Enabled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {


        }

        private void cb_StaffID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_access_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click_1(object sender, EventArgs e)
        {
            cb_StaffID.Text = "";
            cb_StaffID.Items.Clear();
            mySubjects();
            txt_pwd.Clear();
            txt_firstname.Clear();
            txt_lastname.Clear();
            txt_newpwd.Clear();
            txt_Phonenum.Clear();
            txt_re9ion.Clear();
            txt_first.Clear();
            txt_second.Clear();
            txt_third.Clear();
            txt_username.Clear();
            checkBox_newpwd.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            cb_Regionp.Enabled = false;
            txt_tel.Enabled = false;
            txt_username.Enabled = false;
            txt_tel.Enabled = false;
            txt_re9ion.Enabled = false;
            combo_post.Enabled = false;
            txt_Phonenum.Enabled = false;
            txt_pwd.Enabled = false;
            txt_firstname.Enabled = false;
            txt_lastname.Enabled = false;
            checkBox_newpwd.Enabled = false;
            checkBox2.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            txt_email.Enabled = false;
            cb_Regionp.Enabled = false;

            txt_re9ion.Enabled = false;
            txt_newpwd.Enabled = false;
            combo_post.Enabled = false;
            combo_post.Enabled = false;




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {

                    int staffID = int.Parse(cb_StaffID.SelectedItem.ToString());
                    staff s = content.staffs.First(i => i.StaffID == staffID);
                    if (s != null)
                    {
                        s.DepartmentID = 0;


                    }
                    content.SaveChanges();
                    MessageBox.Show("Account:" + s.StaffID + " Disabled");
                }
            }
            catch (NullReferenceException) { MessageBox.Show("Please Select The StaffID First"); }
        }

        private void EditAccount_Load(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {
                {

                    var emp = (from list in content.staffs
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                        department departments = content.departments.First(i => i.DepartmentID == emp2.DepartmentID);
                        if (departments != null)
                        {

                            dataGridView1.Rows.Add(emp2.StaffID, departments.DepartmentName, emp2.PhoneNumber, emp2.Username);
                        }
                    }
                }


            }
            txt_HKID_first.MaxLength = 1;
            txt_HKIDnum.MaxLength = 6;
            txt_HKID_first.MaxLength = 1;
            getstoreName();
            mySubjects();
            addpost();
            dateTimePicker1.Enabled = false;
            txt_first.Enabled = false;
            txt_second.Enabled = false;
            txt_third.Enabled = false;
            txt_email.Enabled = false;
            lab_store.Visible = false;
            cb_store.Visible = false;
            txt_HKID.Enabled = false;
            txt_HKID_first.Enabled = false;
            txt_HKIDnum.Enabled = false;
            txt_hkidlastdigit.Enabled = false;
            combo_post.Enabled = false;
            cb_store.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_StaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_regionname.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_store.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Region.Enabled = false;
            cb_regionname.Enabled = false;
            txt_tel.Enabled = false;
            txt_username.Enabled = false;
            txt_tel.Enabled = false;
            txt_re9ion.Enabled = false;
            combo_post.Enabled = false;
            txt_Phonenum.Enabled = false;
            txt_pwd.Enabled = false;
            txt_firstname.Enabled = false;
            txt_lastname.Enabled = false;
            checkBox_newpwd.Enabled = false;
            checkBox2.Enabled = false;
            radioButton7.Enabled = false;
            radioButton8.Enabled = false;
            txt_email.Enabled = false;
            cb_Regionp.Enabled = false;
            txt_first.Enabled = false;
            txt_second.Enabled = false;
            txt_third.Enabled = false;
            txt_re9ion.Enabled = false;
            txt_newpwd.Enabled = false;
            combo_post.Enabled = false;
            if (checkBox2.Checked)
            {
                cb_Regionp.Enabled = true;
                txt_tel.Enabled = true;

            }
            else if (checkBox2.Checked == false)
            {
                cb_Regionp.Enabled = false;
                txt_tel.Enabled = false;
            }

        }

        private void cb_StaffID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (txt_firstname.Text == "")
            {
                txt_re9ion.Enabled = false;
                cb_StaffID.Enabled = true;
                checkBox_newpwd.Enabled = true;
                checkBox2.Enabled = true;
                radioButton7.Enabled = true;
                radioButton8.Enabled = true;
            }
            if (MessageBox.Show("Edit Another Account? All Unsaved Information Will Be Lost.", "Edit Another Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int staffID;
                    staffID = int.Parse(cb_StaffID.SelectedItem.ToString());
                    staff s = content.staffs.First(i => i.StaffID == staffID);
                    if (s != null)
                    {

                        txt_username.Text = s.Username;
                        txt_pwd.Text = s.Password;
                        string gender = s.Gender;
                        if (gender == "M")
                        {
                            radioButton7.Checked = true;
                        }
                        if (gender == "F")
                        {
                            radioButton8.Checked = true;
                        }
                        txt_firstname.Text = s.Firstname;
                        txt_lastname.Text = s.Lastname;
                        txt_Phonenum.Text = s.PhoneNumber;
                        txt_first.Text = s.AddressLine1;
                        txt_second.Text = s.AddressLine2;
                        txt_third.Text = s.AddressLine3;
                        txt_email.Text = s.EmailAddress;
                        txt_re9ion.Text = s.Region;
                        txt_DID.Text = s.DepartmentID.ToString();
                        if (s.BrithDate != null)
                        {
                            DateTime born = DateTime.Parse(s.BrithDate.ToString());
                            DateTime born_real = DateTime.Parse(born.ToString("yyyy-MM-dd"));
                            dateTimePicker1.Value = born_real;
                        }
                        if (s.BrithDate == null)
                        {
                            dateTimePicker1.Value = DateTime.Now;
                        }


                        //combo_post
                        if (int.Parse(txt_DID.Text) == 3 || int.Parse(txt_DID.Text) == 4)
                        {


                        }
                        txt_HKID.Text = s.HKID;
                        txt_storeID.Text = s.StoreID.ToString();
                        if (txt_storeID.Text != "")
                        {
                            int storeID_int = int.Parse(txt_storeID.Text);
                            store stores = content.stores.First(i => i.StoreID == storeID_int);
                            if (stores != null)
                            {
                                cb_store.SelectedItem = stores.StoreName;

                            }
                        }
                        int departmentID_int = int.Parse(txt_DID.Text);
                        department departments = content.departments.First(i => i.DepartmentID == departmentID_int);
                        if (departments != null)
                        {
                            combo_post.SelectedItem = departments.DepartmentName;

                        }
                    }
                }


            }
        }













        private void combo_post_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                string departmentname = combo_post.SelectedItem.ToString();
                department departments = content.departments.First(i => i.DepartmentName == departmentname);
                if (departments != null)
                {
                    txt_selectedItemdepartment.Text = departments.DepartmentID.ToString();
                }


            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButton1.Checked == true)
            {
                cb_StaffID.Items.Clear();

                txt_selectdid.Text = "2";
                staffd2();
                using (var content = new betterlimitedEntities_Test1())
                { //keyword search

                    dataGridView1.Rows.Clear();


                    var emp = (from list in content.staffs
                               where list.DepartmentID == 2
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        department departments = content.departments.First(i => i.DepartmentID == emp2.DepartmentID);
                        if (departments != null)
                        {
                            dataGridView1.Rows.Add(emp2.StaffID, departments.DepartmentName, emp2.PhoneNumber, emp2.Username);
                        }
                    }
                }
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cb_StaffID.Items.Clear();
            staffdshop();
            if (radioButton2.Checked == true)
            {
                using (var content = new betterlimitedEntities_Test1())
                { //keyword search

                    dataGridView1.Rows.Clear();


                    var emp = (from list in content.staffs
                               where list.DepartmentID == 3 || list.DepartmentID == 4
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        department departments = content.departments.First(i => i.DepartmentID == emp2.DepartmentID);
                        if (departments != null)
                        {
                            dataGridView1.Rows.Add(emp2.StaffID, departments.DepartmentName, emp2.PhoneNumber, emp2.Username);
                        }
                    }
                }
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cb_StaffID.Items.Clear();
            staffdpurchase();
            if (radioButton3.Checked == true)
            {
                using (var content = new betterlimitedEntities_Test1())
                { //keyword search

                    dataGridView1.Rows.Clear();


                    var emp = (from list in content.staffs
                               where list.DepartmentID == 5 || list.DepartmentID == 6
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        department departments = content.departments.First(i => i.DepartmentID == emp2.DepartmentID);
                        if (departments != null)
                        {
                            dataGridView1.Rows.Add(emp2.StaffID, departments.DepartmentName, emp2.PhoneNumber, emp2.Username);
                        }
                    }
                }
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

            cb_StaffID.Items.Clear();
            staffdinventory();
            if (radioButton4.Checked == true)
            {
                using (var content = new betterlimitedEntities_Test1())
                { //keyword search

                    dataGridView1.Rows.Clear();


                    var emp = (from list in content.staffs
                               where list.DepartmentID == 7 || list.DepartmentID == 8
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        department departments = content.departments.First(i => i.DepartmentID == emp2.DepartmentID);
                        if (departments != null)
                        {
                            dataGridView1.Rows.Add(emp2.StaffID, departments.DepartmentName, emp2.PhoneNumber, emp2.Username);
                        }
                    }
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            txt_selectdid.Text = "11";
            cb_StaffID.Items.Clear();
            staffd2();
            if (radioButton5.Checked == true)
            {
                using (var content = new betterlimitedEntities_Test1())
                { //keyword search

                    dataGridView1.Rows.Clear();


                    var emp = (from list in content.staffs
                               where list.DepartmentID == 10
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        department departments = content.departments.First(i => i.DepartmentID == emp2.DepartmentID);
                        if (departments != null)
                        {
                            dataGridView1.Rows.Add(emp2.StaffID, departments.DepartmentName, emp2.PhoneNumber, emp2.Username);
                        }
                    }
                }
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            cb_StaffID.Items.Clear();
            staffothers();
            if (radioButton6.Checked == true)
            {
                using (var content = new betterlimitedEntities_Test1())
                { //keyword search

                    dataGridView1.Rows.Clear();


                    var emp = (from list in content.staffs
                               where list.DepartmentID == 0 || list.DepartmentID == 11 || list.DepartmentID == 12 || list.DepartmentID == 1
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        department departments = content.departments.First(i => i.DepartmentID == emp2.DepartmentID);
                        if (departments != null)
                        {
                            dataGridView1.Rows.Add(emp2.StaffID, departments.DepartmentName, emp2.PhoneNumber, emp2.Username);
                        }
                    }
                }
            }
        }

        private void cb_Regionp_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cb_Regionp.SelectedItem.ToString() == "+852")
                {
                    txt_tel.MaxLength = 8;
                }
                if (cb_Regionp.SelectedItem.ToString() == "+86")
                {
                    txt_tel.MaxLength = 11;
                }
            }
        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_newpwd.Checked)
            {
                txt_newpwd.Enabled = true;

            }
            else if (checkBox_newpwd.Checked == false)
            {

                txt_newpwd.Enabled = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                cb_Regionp.Enabled = true;
                txt_tel.Enabled = true;

            }
            else if (checkBox2.Checked == false)
            {
                cb_Regionp.Enabled = false;
                txt_tel.Enabled = false;
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

        private void txt_tel2_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_regionname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combo_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Region.SelectedItem.ToString() == "China")
            {
                cb_regionname.Items.Clear();
                cb_regionname.Items.Add("Guangzhou");
                cb_regionname.Items.Add("Shenzhen");


                cb_Regionp.SelectedItem = "+86";
                txt_tel.MaxLength = 11;

            }
            if (combo_Region.SelectedItem.ToString() == "Hong Kong")
            {
                cb_regionname.Items.Clear();

                cb_regionname.Items.Add("New Territories");
                cb_regionname.Items.Add("Hong Kong Island");
                cb_regionname.Items.Add("Kowloon Peninsula");
                cb_Regionp.SelectedItem = "+852";
                txt_tel.MaxLength = 8;
            }

        }

        private void label_region_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_POST_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_POST.Checked)
            {
                combo_post.Enabled = true;


            }
            else
            {
                combo_post.Enabled = false;
            }
        }

        private void checkBox_region_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_region.Checked)
            {
                combo_Region.Enabled = true;
                cb_regionname.Enabled = true;

            }
            else
            {
                combo_Region.Enabled = false;
                cb_regionname.Enabled = false;
            }
        }

        private void lab_Secondaddress_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_HKID.Checked)
            {
                txt_HKID_first.Enabled = true;
                txt_HKIDnum.Enabled = true;
                txt_hkidlastdigit.Enabled = true;
            }
            else
            {


                txt_HKID_first.Enabled = false;
                txt_HKIDnum.Enabled = false;
                txt_hkidlastdigit.Enabled = false;

            }
        }

        private void txt_DID_TextChanged(object sender, EventArgs e)
        {
            if (txt_DID.Text == "3" || txt_DID.Text == "4")
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

        private void lab_store_Click(object sender, EventArgs e)
        {

        }

        private void cb_store_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_selectedItemdepartment_TextChanged(object sender, EventArgs e)
        {


            if (int.Parse(txt_selectedItemdepartment.Text) == 3 || int.Parse(txt_selectedItemdepartment.Text) == 4)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox_email_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_email.Checked)
            {
                txt_email.Enabled = true;

            }
            else
            {
                txt_email.Enabled = false;

            }
        }

        private void checkBox_address_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_address.Checked)
            {
                txt_first.Enabled = true;
                txt_second.Enabled = true;
                txt_third.Enabled = true;


            }
            else
            {
                txt_first.Enabled = false;
                txt_second.Enabled = false;
                txt_third.Enabled = false;

            }
        }

        private void checkBox_username_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_username.Checked)
            {
                txt_username.Enabled = true;

            }
            else
            {
                txt_username.Enabled = false;
            }
        }

        private void checkBox_FirstName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_FirstName.Checked)
            {
                txt_firstname.Enabled = true;

            }
            else
            {
                txt_firstname.Enabled = false;
            }

        }

        private void checkBox_lastname_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_lastname.Checked)
            {
                txt_lastname.Enabled = true;

            }
            else
            {
                txt_lastname.Enabled = false;
            }
        }

        private void txt_Firstdigit_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
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

        private void checkBox_Dateofbrith_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Dateofbrith.Checked)
            {
                dateTimePicker1.Enabled = true;

            }
            else
            {
                dateTimePicker1.Enabled = false;

            }
        }
    }
}






