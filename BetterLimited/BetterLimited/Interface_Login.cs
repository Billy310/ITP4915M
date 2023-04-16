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
    public partial class Interface_Login : Form
    {
        public static Interface_Login instance;
        public TextBox tb1;
        public TextBox tb2;

        public static string userid;

        void alert()
        {
            MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
            string command_query = "SELECT Count(ProductID) FROM betterlimited.product WHERE stocklevel<=low_Standard && Reorder=0";

            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;

            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    cbm_low.Items.Clear();
                    string subj = mydr.GetString("Count(ProductID)");
                    cbm_low.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");

            }

        }

        public Interface_Login()
        {
            InitializeComponent();
            instance = this;
            tb1 =txt_sid;
            tb2 = txt_storeID;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                string username = txt_username.Text;
                string password = txt_pwd.Text;
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    staff staffs = content.staffs.First(i => i.Username == username);
                    if (staffs != null)
                    {
                        int dpId = int.Parse(staffs.DepartmentID.ToString());
                        txt_DepartmentID.Text = dpId.ToString();
                        txt_sid.Text = staffs.StaffID.ToString();
                        





                    }
                    int dpID = int.Parse(txt_DepartmentID.Text);
                    department dp = content.departments.First(i => i.DepartmentID == dpID);
                    if (dp != null)
                    {
                        txt_DepartmentName.Text = dp.DepartmentName;


                    }
                    //.instance.lab1.Text = txt_sid.Text;
                    staff s1 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 2);
                    if (s1!= null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");

                        Interface_Admin admin = new Interface_Admin();
                        admin.Show();
                        this.Hide();
                    }



                    staff s2 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 3);
                    if (s2 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");

                        Interface_ShopManager shopm = new Interface_ShopManager();
                        
                        int staffID_int = int.Parse(txt_sid.Text);
                        staff s2s = content.staffs.First(i => i.StaffID == staffID_int);
                        if (s2s != null)
                        {
                            txt_storeID.Text = s2s.StoreID.ToString();
                        }
                        Interface_ShopManager.instance.lab1.Text = txt_sid.Text;
                        Interface_ShopManager.instance.lab2.Text = txt_storeID.Text;
                        shopm.Show();
                        this.Hide();
                    }

                    staff s3 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 4);
                    if (s3 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                        Interface_ShopStaff shopm = new Interface_ShopStaff();
                      
                        int staffID_int = int.Parse(txt_sid.Text);
                        staff s3s = content.staffs.First(i => i.StaffID == staffID_int);
                        if (s3s != null)
                        {
                            txt_storeID.Text = s3s.StoreID.ToString();
                        }
                        Interface_ShopStaff.instance.lab1.Text = txt_sid.Text;
                        Interface_ShopStaff.instance.lab2.Text = txt_storeID.Text;
                        shopm.Show();
                        this.Hide();


                    }
                    staff s4 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 5);
                    if (s4 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                       Interface_PurchasingManager Shops = new Interface_PurchasingManager();
                        Shops.Show();
                        this.Hide();

                    }
                    staff s5 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 6);
                    if (s5 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                        Interface_PurchasingClerk purchasem = new Interface_PurchasingClerk();
                        purchasem.Show();
                        this.Hide();
                    }
                    staff s6 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 7);
                    if (s6 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                        if (int.Parse(cbm_low.Items[0].ToString()) > 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("There Has " + cbm_low.Items[0].ToString() + " Product Are Low Level, Please Make a Re-order List to Purchase !", "Reorder", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                Interface_CreateReorder go = new Interface_CreateReorder();
                                go.Show();
                                this.Hide();
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                Interface_Inventory Shopm = new Interface_Inventory();
                                Shopm.Show();
                                this.Hide();
                            }

                        }
                        else {
                            Interface_Inventory Shopm = new Interface_Inventory();
                            Shopm.Show();
                            this.Hide();
                        }
                    }
                    staff s7 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 8);
                    if (s7 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                        if (int.Parse(cbm_low.Items[0].ToString()) > 0)
                        {
                            DialogResult dialogResult = MessageBox.Show("Have " + cbm_low.Items[0].ToString() + " Product Are Low Level, Please Send Re-order to Purchase !", "Warning", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                Interface_CreateReorder go = new Interface_CreateReorder();
                                go.Show();
                                Interface_Inventory Shopm = new Interface_Inventory();
                                Shopm.Show();
                                this.Hide();
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                Interface_Inventory Shopm = new Interface_Inventory();
                                Shopm.Show();
                                this.Hide();
                            }

                        }
                        else
                        {
                            Interface_Inventory Shopm = new Interface_Inventory();
                            Shopm.Show();
                            this.Hide();
                        }
                    }
                    staff s8 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 9);
                    if (s8 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                        Interface_DeliveryManager accountM = new Interface_DeliveryManager();
                        Interface_DeliveryManager.instance.lab1.Text= txt_sid.Text;
                        accountM.Show();
                        this.Hide();
                    }
                    staff s11 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 10);
                    if (s11 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                        Interface_AccountingClerk accountC = new Interface_AccountingClerk();
                        accountC.Show();
                        this.Hide();
                    }
                    staff s12 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 11);
                    if (s12 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                        
                        Interface_Delivery d = new Interface_Delivery();
                        Interface_Delivery.instance.lab1.Text = txt_sid.Text;
                        d.Show();
                        
                        this.Hide();
                    }
                    staff s13 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 12);
                    if (s13 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                       
                        Interface_Installation i = new Interface_Installation();
                        Interface_Installation.instance.lab1.Text = txt_sid.Text;

                        i.Show();
                        this.Hide();
                    }
                    staff s15 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 15);
                    if (s15 != null)
                    {
                        MessageBox.Show("Login As   " + txt_DepartmentName.Text, "Login Success");
                        
                        Interface_InstallationManager i = new Interface_InstallationManager();
Interface_InstallationManager.instance.lab1.Text = txt_sid.Text;
                        i.Show();
                        this.Hide();
                    }
                    staff s14 = content.staffs.SingleOrDefault(i => i.Username == txt_username.Text && i.Password == txt_pwd.Text && i.DepartmentID == 1);
                    if (s14 != null)
                    {
                        MessageBox.Show("Testing Login Function Success", "Login Success");
                    }
                    if (s1 == null && s2 == null && s3 == null && s4 == null && s5 == null && s6 == null && s7 == null && s8 == null && s11 == null&& s12==null && s13==null&&s14==null&&s15==null)
                    {
                        MessageBox.Show("Login Failure! Please Try Again.", "Login Failure");
                    }





                }
            }
            catch (System.InvalidOperationException) { MessageBox.Show("The Username And Password Blank Are Not Filled." +"\n"+"                        Please Try Again.","Login Failure"); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Enter Username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.Black;

            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            if (txt_username.Text == "")
            {
                txt_username.Text = "Enter Username";
                txt_username.ForeColor = Color.DarkGray;
            }
        }

        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_pwd.Text == "Enter Password")
            {
                txt_pwd.Text = "";
                txt_pwd.ForeColor = Color.Black;

            }

        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_pwd.Text == "")
            {
                txt_pwd.Text = "Enter Password";
                txt_pwd.ForeColor = Color.DarkGray;
            }

        }

        private void Interface_Login_Load(object sender, EventArgs e)
        {
            alert();

            if (txt_username.Text == "" && txt_pwd.Text == "")
            {
                btn_Login.Enabled = false;

            }
            else {
                btn_Login.Enabled = true;
            }
        }

        private void checkbox_Showpwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_Showpwd.Checked)
            {
                txt_pwd.UseSystemPasswordChar = false;

            }
            else {

                txt_pwd.UseSystemPasswordChar = true;
            }
        }

        private void txt_username_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar == (char)Keys.Space);
        }
    }
}

