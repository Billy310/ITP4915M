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
    public partial class Interface_CreateSaleOrder : Form
    {
        public static Interface_CreateSaleOrder instance;
        public Label lab1;
        public Label lab2;
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public static string CtoP, CheckCtoP;
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public Interface_CreateSaleOrder()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
            lab2 = lab_storeID;


        }
        void mySubjects()
        {
            string command_query = "SELECT DISTINCT SupplierName FROM betterlimited.supplier WHERE Available=1";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("SupplierName");
                    combobox_supplier.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Suppliername");

            }

        }
        void id()
        {
            string command_query = "SELECT DISTINCT OrderID FROM betterlimited.saleorder";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    int subj = mydr.GetInt16("OrderID");
                    cmb_test.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Error");

            }

        }
        void depositupdate()
        {
            double percentage = double.Parse(numericUpDown_percentage.Value.ToString());
            double totalprice = double.Parse(lb_total.Items[0].ToString());
            numericUpDown_percentage.Minimum = 20;
            numericUpDown_percentage.Value = 20;
            txt_depositamount.Text = (totalprice * percentage * 0.01).ToString();


        }
        void add2ComboboxType()
        {
            string command_query = "SELECT DISTINCT TypeName FROM betterlimited.type";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("TypeName");
                    combobox_Type.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Typename Error");

            }


        }
       
       
      

    
     
      
      


        private void Sale_Load(object sender, EventArgs e)
        {

            checkBox_newcustomer.Enabled = false;
            comboBox_customerID.Enabled = false;
            comboBox_customerID.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_RegionPhone.DropDownStyle = ComboBoxStyle.DropDownList;
            

            txt_contact.Enabled = false;
            txt_city.Enabled = false;
            txt_firstname.Enabled = false;
            txt_lastname.Enabled = false;
            txt_email.Enabled = false;
            txt_phone1.Enabled = false;
            txt_phone2.Enabled = false;
            txt_street.Enabled = false;
            txt_compName.Enabled = false;
            txt_building.Enabled = false;
            btn_search4cid.Enabled = false;
            radioButton4.Enabled = false;
            radioButton5.Enabled = false;
            txt_cname.Enabled = false;
            txt_tel.Enabled = false;
            txt_depositamount.Enabled = false;
            btn_sRemove.Enabled = false;
            numericUpDown_qty.Enabled = false;
            txt_depositamount.Enabled = false;
            lab_percent.Visible = false;
            txt_depositamount.Visible = false;
            lab_depositamount.Visible = false;
            numericUpDown_percentage.Visible = false;

            numericUpDown_Rqty.Enabled = false;
            combobox_PID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_RPID.DropDownStyle = ComboBoxStyle.DropDownList;
            radioButton1.Enabled = false;
            radioButton2.Enabled = false;
            radioButton3.Enabled = false;
            combobox_PID.Enabled = false;
            combobox_supplier.Enabled = false;
            combobox_Type.Enabled = false;
            btn_Search.Enabled = false;

          

            btn_additem.Enabled = false;
           // btn_place.Enabled = false;
            lb_id.Enabled = false;
            lb_price.Enabled = false;
            lb_qty.Enabled = false;
            lb_total.Enabled = false;
            id();
            GetIDToPayment.Hide();
            cmb_test.Hide();
            txt_orderid.Enabled = false;

            //comboBox_customerID.Enabled = false;
            mySubjects();
            add2ComboboxType();
            combobox_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_supplier.DropDownStyle = ComboBoxStyle.DropDownList;
            lb_id.Items.Add("ID");
            lb_name.Items.Add("Name");
            lb_qty.Items.Add("Qty");
            lb_price.Items.Add("Price");
            lb_display.Items.Add("DIS");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_back_Click_1(object sender, EventArgs e)
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

        private void txt_ProductID_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_qty_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_additem_Click_1(object sender, EventArgs e)
        {
            comboBox_RPID.Items.Clear();
            if (lb_total.Items.Count == 0) {
                lb_total.Items.Add("0");
            }

            try
            {
                if (lb_id.Items.Count == 10)
                {
                    btn_additem.Enabled = false;
                }

                int a, b;
                a = int.Parse(combobox_PID.SelectedItem.ToString());
                b = int.Parse(numericUpDown_qty.Value.ToString());
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    product p1 = content.products.First(i => i.ProductID == a);
                    //if (p1.StockLevel == 0)
                    // MessageBox.Show("Product Is Out Of Stock");

                    if (lb_id.Items.Count == 1)
                    {
                        lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                        lb_name.Items.Add(p1.ProductName);
                        lb_qty.Items.Add(b);
                        if (chb_display.Checked)
                        {
                            lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                            lb_display.Items.Add(1);
                        }
                        else
                        {
                            lb_price.Items.Add(p1.Price * b);
                            lb_display.Items.Add(0);
                        }
                        lb_total.Items[0] = (int.Parse(lb_price.Items[1].ToString()));



                    }

                    else if (lb_id.Items.Count == 2)
                    {
                        int check = 0;
                        for (int i = 1; i < 2; i++)
                        {
                            if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * b;
                                check = 1;
                            }
                            else if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * 0.7 * b;
                                check = 1;
                            }
                        }
                        if (check == 0)
                        {
                            lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                            lb_name.Items.Add(p1.ProductName);
                            lb_qty.Items.Add(b);
                            if (chb_display.Checked)
                            {
                                lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                                lb_display.Items.Add(1);
                            }
                            else
                            {
                                lb_price.Items.Add(p1.Price * b);
                                lb_display.Items.Add(0);
                            }
                            lb_total.Items[0] = int.Parse(lb_price.Items[1].ToString()) + int.Parse(lb_price.Items[2].ToString());

                        }


                        //lb_price.Items.Add(c.Price * b);
                    }
                    else if (lb_id.Items.Count == 3)
                    {
                        int check = 0;
                        for (int i = 1; i < 3; i++)
                        {
                            if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * b;
                                check = 1;
                            }
                            else if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * 0.7 * b;
                                check = 1;
                            }
                        }
                        if (check == 0)
                        {
                            lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                            lb_name.Items.Add(p1.ProductName);
                            lb_qty.Items.Add(b);
                            if (chb_display.Checked)
                            {
                                lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                                lb_display.Items.Add(1);
                            }
                            else
                            {
                                lb_price.Items.Add(p1.Price * b);
                                lb_display.Items.Add(0);
                            }
                            lb_total.Items[0] = int.Parse(lb_price.Items[1].ToString()) + int.Parse(lb_price.Items[2].ToString()) + int.Parse(lb_price.Items[3].ToString());

                        }

                    }
                    else if (lb_id.Items.Count == 4)
                    {
                        int check = 0;
                        for (int i = 1; i < 4; i++)
                        {
                            if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * b;
                                check = 1;
                            }
                            else if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * 0.7 * b;
                                check = 1;
                            }
                        }
                        if (check == 0)
                        {
                            lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                            lb_name.Items.Add(p1.ProductName);
                            lb_qty.Items.Add(b);
                            if (chb_display.Checked)
                            {
                                lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                                lb_display.Items.Add(1);
                            }
                            else
                            {
                                lb_price.Items.Add(p1.Price * b);
                                lb_display.Items.Add(0);
                            }
                            lb_total.Items[0] = int.Parse(lb_price.Items[1].ToString()) + int.Parse(lb_price.Items[2].ToString()) + int.Parse(lb_price.Items[3].ToString()) + int.Parse(lb_price.Items[4].ToString());

                        }

                    }
                    else if (lb_id.Items.Count == 5)
                    {
                        int check = 0;
                        for (int i = 1; i < 5; i++)
                        {
                            if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * b;
                                check = 1;
                            }
                            else if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * 0.7 * b;
                                check = 1;
                            }
                        }
                        if (check == 0)
                        {
                            lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                            lb_name.Items.Add(p1.ProductName);
                            lb_qty.Items.Add(b);
                            if (chb_display.Checked)
                            {
                                lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                                lb_display.Items.Add(1);
                            }
                            else
                            {
                                lb_price.Items.Add(p1.Price * b);
                                lb_display.Items.Add(0);
                            }
                            lb_total.Items[0] = int.Parse(lb_price.Items[1].ToString()) + int.Parse(lb_price.Items[2].ToString()) + int.Parse(lb_price.Items[3].ToString()) + int.Parse(lb_price.Items[4].ToString()) + int.Parse(lb_price.Items[5].ToString());

                        }

                    }
                    else if (lb_id.Items.Count == 6)
                    {
                        int check = 0;
                        for (int i = 1; i < 6; i++)
                        {
                            if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * b;
                                check = 1;
                            }
                            else if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * 0.7 * b;
                                check = 1;
                            }
                        }
                        if (check == 0)
                        {
                            lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                            lb_name.Items.Add(p1.ProductName);
                            lb_qty.Items.Add(b);
                            if (chb_display.Checked)
                            {
                                lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                                lb_display.Items.Add(1);
                            }
                            else
                            {
                                lb_price.Items.Add(p1.Price * b);
                                lb_display.Items.Add(0);
                            }
                            lb_total.Items[0] = int.Parse(lb_price.Items[1].ToString()) + int.Parse(lb_price.Items[2].ToString()) + int.Parse(lb_price.Items[3].ToString()) + int.Parse(lb_price.Items[4].ToString()) + int.Parse(lb_price.Items[5].ToString())
                                + int.Parse(lb_price.Items[6].ToString());

                        }

                    }
                    else if (lb_id.Items.Count == 7)
                    {
                        int check = 0;
                        for (int i = 1; i < 7; i++)
                        {
                            if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * b;
                                check = 1;
                            }
                            else if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * 0.7 * b;
                                check = 1;
                            }
                        }
                        if (check == 0)
                        {
                            lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                            lb_name.Items.Add(p1.ProductName);
                            lb_qty.Items.Add(b);
                            if (chb_display.Checked)
                            {
                                lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                                lb_display.Items.Add(1);
                            }
                            else
                            {
                                lb_price.Items.Add(p1.Price * b);
                                lb_display.Items.Add(0);
                            }
                            lb_total.Items[0] = int.Parse(lb_price.Items[1].ToString()) + int.Parse(lb_price.Items[2].ToString()) + int.Parse(lb_price.Items[3].ToString()) + int.Parse(lb_price.Items[4].ToString()) + int.Parse(lb_price.Items[5].ToString())
                                + int.Parse(lb_price.Items[6].ToString()) + int.Parse(lb_price.Items[7].ToString());

                        }

                    }
                    else if (lb_id.Items.Count == 8)
                    {
                        int check = 0;
                        for (int i = 1; i < 8; i++)
                        {
                            if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * b;
                                check = 1;
                            }
                            else if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * 0.7 * b;
                                check = 1;
                            }
                        }
                        if (check == 0)
                        {
                            lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                            lb_name.Items.Add(p1.ProductName);
                            lb_qty.Items.Add(b);
                            if (chb_display.Checked)
                            {
                                lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                                lb_display.Items.Add(1);
                            }
                            else
                            {
                                lb_price.Items.Add(p1.Price * b);
                                lb_display.Items.Add(0);
                            }
                            lb_total.Items[0] = int.Parse(lb_price.Items[1].ToString()) + int.Parse(lb_price.Items[2].ToString()) + int.Parse(lb_price.Items[3].ToString()) + int.Parse(lb_price.Items[4].ToString()) + int.Parse(lb_price.Items[5].ToString())
                                + int.Parse(lb_price.Items[6].ToString()) + int.Parse(lb_price.Items[7].ToString()) + int.Parse(lb_price.Items[8].ToString());

                        }

                    }
                    else if (lb_id.Items.Count == 9)
                    {
                        int check = 0;
                        for (int i = 1; i < 9; i++)
                        {
                            if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * b;
                                check = 1;
                            }
                            else if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * 0.7 * b;
                                check = 1;
                            }
                        }
                        if (check == 0)
                        {
                            lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                            lb_name.Items.Add(p1.ProductName);
                            lb_qty.Items.Add(b);
                            if (chb_display.Checked)
                            {
                                lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                                lb_display.Items.Add(1);
                            }
                            else
                            {
                                lb_price.Items.Add(p1.Price * b);
                                lb_display.Items.Add(0);
                            }
                            lb_total.Items[0] = int.Parse(lb_price.Items[1].ToString()) + int.Parse(lb_price.Items[2].ToString()) + int.Parse(lb_price.Items[3].ToString()) + int.Parse(lb_price.Items[4].ToString()) + int.Parse(lb_price.Items[5].ToString())
                                + int.Parse(lb_price.Items[6].ToString()) + int.Parse(lb_price.Items[7].ToString()) + int.Parse(lb_price.Items[8].ToString()) + int.Parse(lb_price.Items[9].ToString());

                        }

                    }
                    else if (lb_id.Items.Count == 10)
                    {
                        int check = 0;
                        for (int i = 1; i < 10; i++)
                        {
                            if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * b;
                                check = 1;
                            }
                            else if (a.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) + b;
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) + p1.Price * 0.7 * b;
                                check = 1;
                            }
                        }
                        if (check == 0)
                        {
                            lb_id.Items.Add(combobox_PID.SelectedItem.ToString());
                            lb_name.Items.Add(p1.ProductName);
                            lb_qty.Items.Add(b);
                            if (chb_display.Checked)
                            {
                                lb_price.Items.Add(int.Parse((p1.Price * 0.7 * b).ToString("00")));
                                lb_display.Items.Add(1);
                            }
                            else
                            {
                                lb_price.Items.Add(p1.Price * b);
                                lb_display.Items.Add(0);
                            }
                            lb_total.Items[0] = int.Parse(lb_price.Items[1].ToString()) + int.Parse(lb_price.Items[2].ToString()) + int.Parse(lb_price.Items[3].ToString()) + int.Parse(lb_price.Items[4].ToString()) + int.Parse(lb_price.Items[5].ToString())
                                + int.Parse(lb_price.Items[6].ToString()) + int.Parse(lb_price.Items[7].ToString()) + int.Parse(lb_price.Items[8].ToString()) + int.Parse(lb_price.Items[9].ToString()) + int.Parse(lb_price.Items[10].ToString());

                        }


                    }


                }



                double total = 0;

                for (int i = 1; i < lb_id.Items.Count; i++)
                    total += int.Parse(lb_price.Items[i].ToString());


                lb_total.Items.Clear();
                lb_total.Items.Add(total);
                if (int.Parse(lb_total.Items[0].ToString()) >= 5000)
                {
                    depositupdate();

                }

                if (radioButton_dorder.Checked==true&&int.Parse(lb_total.Items[0].ToString())>=5000)
                {
                    total = int.Parse(lb_total.Items[0].ToString());
                    double percentage = double.Parse(numericUpDown_percentage.Value.ToString()) / 100;
                    txt_depositamount.Text = (total * percentage).ToString();
                }




                for (int x = 1; x < lb_id.Items.Count; x++)
                {
                    comboBox_RPID.Items.Add(lb_id.Items[x].ToString());
                }
            }
            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Product is Not Existed");
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong 1");
            }
        }

        private void btn_place_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_newcustomer.Checked == false && comboBox_customerID.SelectedItem.ToString() == "" || lb_qty.Items[1].ToString() == "")
                {
                    throw new InvalidOperationException();
                }
                if (lb_id.Items.Count < 2)
                {
                    throw new NotSupportedException();
                }

                if (checkBox_newcustomer.Checked)
                {
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {
                        Random R = new Random();
                        customer c = new customer
                        {
                            FirstName = txt_firstname.Text,
                            LastName = txt_lastname.Text,
                            CompanyName = txt_compName.Text,
                            ContactPersion = txt_contact.Text,
                            Phone1 = txt_phone1.Text,
                            Phone2 = txt_phone2.Text,
                            AddressLine1 = txt_city.Text,
                            AddressLine2 = txt_building.Text,
                            AddressLine3 = txt_street.Text,
                            EmailAddress = txt_email.Text,
                            CustomerID = R.Next(100)
                        };
                        content.customers.Add(c);
                        content.SaveChanges();
                        txt_newcustomer.Text = c.CustomerID.ToString();

                        customer id = content.customers.First(i => i.Phone1 == txt_phone1.Text);


                        MessageBox.Show("Customer Information Created");
                    }
                }

                if (txt_depositamount.Text == "" || numericUpDown_percentage.Value == 0)
                {
                    //throw new ArgumentException();

                }

                for (int i = 1; i < 11; i++)
                {
                    lb_id.Items.Add(0);
                    lb_qty.Items.Add(0);
                    lb_display.Items.Add(0);
                }
                string x;
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())

                {

                    for (int c = 1; c < 11; c++)
                    {
                        lb_id.Items.Add("");
                        lb_qty.Items.Add("");
                        lb_display.Items.Add("");


                        if (lb_id.Items[c].ToString() == "")
                            break;
                        else
                            x = lb_id.Items[c].ToString();

                        product pr = content.products.First(i => i.ProductID.ToString() == x);

                        if (lab_storeID.Text == "1" && radioButton_sorder.Checked)
                        {
                            pr.KBStore -= int.Parse(lb_qty.Items[c].ToString());
                            if (pr.KBStore < 10 && pr.ProductID != 0)
                            {
                                MessageBox.Show("ProductID " + x + " Low Level Warning !");
                            }
                        }
                        else if (lab_storeID.Text == "2" && radioButton_sorder.Checked)
                        {
                            pr.TWStore -= int.Parse(lb_qty.Items[c].ToString());
                            if (pr.TWStore < 10 && pr.ProductID != 0)
                            {
                                MessageBox.Show("ProductID " + x + " Low Level Warning !");
                            }
                        }

                    }


                    int product1_ID_int;
                    int product2_ID_int;
                    int product3_ID_int;
                    int product4_ID_int;
                    int product5_ID_int;
                    int product6_ID_int;
                    int product7_ID_int;
                    int product8_ID_int;
                    int product9_ID_int;
                    int product10_ID_int;
                    if (lb_id.Items[1].ToString() == "")
                    {
                        product1_ID_int = 0;
                    }
                    else { product1_ID_int = int.Parse(lb_id.Items[1].ToString()); }
                    if (lb_id.Items[2].ToString() == "")
                    {
                        product2_ID_int = 0;
                    }
                    else { product2_ID_int = int.Parse(lb_id.Items[2].ToString()); }
                    if (lb_id.Items[3].ToString() == "")
                    {
                        product3_ID_int = 0;
                    }
                    else { product3_ID_int = int.Parse(lb_id.Items[3].ToString()); }
                    if (lb_id.Items[4].ToString() == "")
                    {
                        product4_ID_int = 0;
                    }
                    else { product4_ID_int = int.Parse(lb_id.Items[4].ToString()); }
                    if (lb_id.Items[5].ToString() == "")
                    {
                        product5_ID_int = 0;
                    }
                    else { product5_ID_int = int.Parse(lb_id.Items[5].ToString()); }
                    if (lb_id.Items[6].ToString() == "")
                    {
                        product6_ID_int = 0;
                    }
                    else { product6_ID_int = int.Parse(lb_id.Items[6].ToString()); }
                    if (lb_id.Items[7].ToString() == "")
                    {
                        product7_ID_int = 0;
                    }
                    else { product7_ID_int = int.Parse(lb_id.Items[7].ToString()); }
                    if (lb_id.Items[8].ToString() == "")
                    {
                        product8_ID_int = 0;
                    }
                    else { product8_ID_int = int.Parse(lb_id.Items[8].ToString()); }
                    if (lb_id.Items[9].ToString() == "")
                    {
                        product9_ID_int = 0;
                    }
                    else { product9_ID_int = int.Parse(lb_id.Items[9].ToString()); }
                    if (lb_id.Items[10].ToString() == "")
                    {
                        product10_ID_int = 0;
                    }
                    else { product10_ID_int = int.Parse(lb_id.Items[10].ToString()); }
                    int product1_qty_int;
                    int product2_qty_int;
                    int product3_qty_int;
                    int product4_qty_int;
                    int product5_qty_int;
                    int product6_qty_int;
                    int product7_qty_int;
                    int product8_qty_int;
                    int product9_qty_int;
                    int product10_qty_int;
                    if (lb_qty.Items[1].ToString() == "")
                    {
                        product1_qty_int = 0;
                    }
                    else { product1_qty_int = int.Parse(lb_qty.Items[1].ToString()); }
                    if (lb_qty.Items[2].ToString() == "")
                    {
                        product2_qty_int = 0;
                    }
                    else { product2_qty_int = int.Parse(lb_qty.Items[2].ToString()); }
                    if (lb_qty.Items[3].ToString() == "")
                    {
                        product3_qty_int = 0;
                    }
                    else { product3_qty_int = int.Parse(lb_qty.Items[3].ToString()); }
                    if (lb_qty.Items[4].ToString() == "")
                    {
                        product4_qty_int = 0;
                    }
                    else { product4_qty_int = int.Parse(lb_qty.Items[4].ToString()); }
                    if (lb_qty.Items[5].ToString() == "")
                    {
                        product5_qty_int = 0;
                    }
                    else { product5_qty_int = int.Parse(lb_qty.Items[5].ToString()); }
                    if (lb_qty.Items[6].ToString() == "")
                    {
                        product6_qty_int = 0;
                    }
                    else { product6_qty_int = int.Parse(lb_qty.Items[6].ToString()); }
                    if (lb_qty.Items[7].ToString() == "")
                    {
                        product7_qty_int = 0;
                    }
                    else { product7_qty_int = int.Parse(lb_qty.Items[7].ToString()); }
                    if (lb_qty.Items[8].ToString() == "")
                    {
                        product8_qty_int = 0;
                    }
                    else { product8_qty_int = int.Parse(lb_qty.Items[8].ToString()); }
                    if (lb_qty.Items[9].ToString() == "")
                    {
                        product9_qty_int = 0;
                    }
                    else { product9_qty_int = int.Parse(lb_qty.Items[9].ToString()); }
                    if (lb_qty.Items[10].ToString() == "")
                    {
                        product10_qty_int = 0;
                    }
                    else { product10_qty_int = int.Parse(lb_qty.Items[10].ToString()); }
                    int product1_display;
                    int product2_display;
                    int product3_display;
                    int product4_display;
                    int product5_display;
                    int product6_display;
                    int product7_display;
                    int product8_display;
                    int product9_display;
                    int product10_display;
                    if (lb_display.Items[1].ToString() == "")
                    {
                        product1_display = 0;
                    }
                    else { product1_display = int.Parse(lb_display.Items[1].ToString()); }
                    if (lb_display.Items[2].ToString() == "")
                    {
                        product2_display = 0;
                    }
                    else { product2_display = int.Parse(lb_display.Items[2].ToString()); }
                    if (lb_display.Items[3].ToString() == "")
                    {
                        product3_display = 0;
                    }
                    else { product3_display = int.Parse(lb_display.Items[3].ToString()); }
                    if (lb_display.Items[4].ToString() == "")
                    {
                        product4_display = 0;
                    }
                    else { product4_display = int.Parse(lb_display.Items[4].ToString()); }
                    if (lb_display.Items[5].ToString() == "")
                    {
                        product5_display = 0;
                    }
                    else { product5_display = int.Parse(lb_display.Items[5].ToString()); }
                    if (lb_display.Items[6].ToString() == "")
                    {
                        product6_display = 0;
                    }
                    else { product6_display = int.Parse(lb_display.Items[6].ToString()); }
                    if (lb_display.Items[7].ToString() == "")
                    {
                        product7_display = 0;
                    }
                    else { product7_display = int.Parse(lb_display.Items[7].ToString()); }
                    if (lb_display.Items[8].ToString() == "")
                    {
                        product8_display = 0;
                    }
                    else { product8_display = int.Parse(lb_display.Items[8].ToString()); }
                    if (lb_display.Items[9].ToString() == "")
                    {
                        product9_display = 0;
                    }
                    else { product9_display = int.Parse(lb_display.Items[9].ToString()); }
                    if (lb_display.Items[10].ToString() == "")
                    {
                        product10_display = 0;
                    }
                    else { product10_display = int.Parse(lb_display.Items[10].ToString()); }



                    int product1_str = int.Parse(lb_id.Items[1].ToString());
                    if (product1_str == 0)
                    {
                        product1_str = 0;
                        if (product1_str == 0)
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                    }
                    if (radioButton_sorder.Checked)
                    {
                        txt_ordertype.Text = "Sale Order";
                        txt_depositamount.Text = "0";

                    }
                    if (radioButton_dorder.Checked)
                    {
                        txt_ordertype.Text = "Deposit Order";

                    }
                    if (txt_depositamount.Text == "")
                    {

                        txt_depositamount.Text = "0";
                    }





                    if (checkBox_newcustomer.Checked == false)
                    {
                        saleorder sal = new saleorder
                        {
                            staffID= int.Parse(label1.Text),
                            orderType = txt_ordertype.Text,
                            Product1_ID = product1_ID_int,
                            Product2_ID = product2_ID_int,
                            Product3_ID = product3_ID_int,
                            Product4_ID = product4_ID_int,
                            Product5_ID = product5_ID_int,
                            Product6_ID = product6_ID_int,
                            Product7_ID = product7_ID_int,
                            Product8_ID = product8_ID_int,
                            Product9_ID = product9_ID_int,
                            Product10_ID = product10_ID_int,
                            Product1_Qty = int.Parse(lb_qty.Items[1].ToString()),
                            Product2_Qty = int.Parse(lb_qty.Items[2].ToString()),
                            Product3_Qty = int.Parse(lb_qty.Items[3].ToString()),
                            Product4_Qty = int.Parse(lb_qty.Items[4].ToString()),
                            Product5_Qty = int.Parse(lb_qty.Items[5].ToString()),
                            Product6_Qty = int.Parse(lb_qty.Items[6].ToString()),
                            Product7_Qty = int.Parse(lb_qty.Items[7].ToString()),
                            Product8_Qty = int.Parse(lb_qty.Items[8].ToString()),
                            Product9_Qty = int.Parse(lb_qty.Items[9].ToString()),
                            Product10_Qty = int.Parse(lb_qty.Items[10].ToString()),
                            Product1_display = int.Parse(lb_display.Items[1].ToString()),
                            Product2_display = int.Parse(lb_display.Items[2].ToString()),
                            Product3_display = int.Parse(lb_display.Items[3].ToString()),
                            Product4_display = int.Parse(lb_display.Items[4].ToString()),
                            Product5_display = int.Parse(lb_display.Items[5].ToString()),
                            Product6_display = int.Parse(lb_display.Items[6].ToString()),
                            Product7_display = int.Parse(lb_display.Items[7].ToString()),
                            Product8_display = int.Parse(lb_display.Items[8].ToString()),
                            Product9_display = int.Parse(lb_display.Items[9].ToString()),
                            Product10_display = int.Parse(lb_display.Items[10].ToString()),
                            DepositCharge = double.Parse(txt_depositamount.Text),
                            TotalCharge = double.Parse(lb_total.Items[0].ToString()),
                            Addition_Charge = 0,
                            Active = "Active",
                            CustomerID = int.Parse(comboBox_customerID.SelectedItem.ToString()),
                            storeID = int.Parse(lab_storeID.Text),
                            PayAmount = 0,
                            Date_Of_Purchase = DateTime.Now

                        };

                        content.saleorders.Add(sal);

                        content.SaveChanges();
                        txt_orderid.Text = sal.orderID.ToString();
                    }
                    if (checkBox_newcustomer.Checked == true)
                    {
                        saleorder sal = new saleorder
                        {
                            orderType = txt_ordertype.Text,
                            Product1_ID = product1_ID_int,
                            Product2_ID = product2_ID_int,
                            Product3_ID = product3_ID_int,
                            Product4_ID = product4_ID_int,
                            Product5_ID = product5_ID_int,
                            Product6_ID = product6_ID_int,
                            Product7_ID = product7_ID_int,
                            Product8_ID = product8_ID_int,
                            Product9_ID = product9_ID_int,
                            Product10_ID = product10_ID_int,
                            Product1_Qty = int.Parse(lb_qty.Items[1].ToString()),
                            Product2_Qty = int.Parse(lb_qty.Items[2].ToString()),
                            Product3_Qty = int.Parse(lb_qty.Items[3].ToString()),
                            Product4_Qty = int.Parse(lb_qty.Items[4].ToString()),
                            Product5_Qty = int.Parse(lb_qty.Items[5].ToString()),
                            Product6_Qty = int.Parse(lb_qty.Items[6].ToString()),
                            Product7_Qty = int.Parse(lb_qty.Items[7].ToString()),
                            Product8_Qty = int.Parse(lb_qty.Items[8].ToString()),
                            Product9_Qty = int.Parse(lb_qty.Items[9].ToString()),
                            Product10_Qty = int.Parse(lb_qty.Items[10].ToString()),
                            Product1_display = int.Parse(lb_display.Items[1].ToString()),
                            Product2_display = int.Parse(lb_display.Items[2].ToString()),
                            Product3_display = int.Parse(lb_display.Items[3].ToString()),
                            Product4_display = int.Parse(lb_display.Items[4].ToString()),
                            Product5_display = int.Parse(lb_display.Items[5].ToString()),
                            Product6_display = int.Parse(lb_display.Items[6].ToString()),
                            Product7_display = int.Parse(lb_display.Items[7].ToString()),
                            Product8_display = int.Parse(lb_display.Items[8].ToString()),
                            Product9_display = int.Parse(lb_display.Items[9].ToString()),
                            Product10_display = int.Parse(lb_display.Items[10].ToString()),
                            DepositCharge = double.Parse(txt_depositamount.Text),
                            TotalCharge = double.Parse(lb_total.Items[0].ToString()),
                            Addition_Charge = 0,
                            Active = "Active",
                            CustomerID = int.Parse(txt_newcustomer.Text),
                            storeID = int.Parse(lab_storeID.Text),
                            PayAmount = 0,
                            Date_Of_Purchase = DateTime.Now

                        };

                        content.saleorders.Add(sal);

                        content.SaveChanges();
                        txt_orderid.Text = sal.orderID.ToString();
                    }

                    for (int y = 1; y <= lb_name.Items.Count; y++)
                    {
                        int productID = int.Parse(lb_id.Items[y].ToString());
                        double total = 0;


                        product s = content.products.First(i => i.ProductID == productID);
                        if (s != null)
                        {
                            if (int.Parse(lb_display.Items[y].ToString()) == 0)
                            {
                                total = s.Price * int.Parse(lb_qty.Items[y].ToString());
                            }
                            if (int.Parse(lb_display.Items[y].ToString()) == 1)
                            {
                                total = s.Price * int.Parse(lb_qty.Items[y].ToString()) * 0.7;
                            }
                            if (int.Parse(lb_id.Items[y].ToString()) != 0)
                            {
                                dataGridView_sold.Rows.Add(productID, lb_qty.Items[y].ToString(), s.Price, lb_display.Items[y].ToString(), total);
                            }


                        }
                    }

                    for (int z = 0; z < dataGridView_sold.RowCount; z++)
                    {
                        soldproduct sol = new soldproduct
                        {
                            SaleorderID = int.Parse(txt_orderid.Text),
                            productID = int.Parse(dataGridView_sold.Rows[z].Cells[0].Value.ToString()),
                            Quantity = int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString()),
                            ProductPrePrice = double.Parse(dataGridView_sold.Rows[z].Cells[2].Value.ToString()),
                            Displayed = int.Parse(dataGridView_sold.Rows[z].Cells[3].Value.ToString()),
                            TotalAmount = double.Parse(dataGridView_sold.Rows[z].Cells[4].Value.ToString()),
                            Able = "Enable"




                        };
                        content.soldproducts.Add(sol);
                        int productid = int.Parse(dataGridView_sold.Rows[z].Cells[0].Value.ToString());
                        if (int.Parse(lab_storeID.Text) == 1 && int.Parse(dataGridView_sold.Rows[z].Cells[3].Value.ToString()) == 1)
                        {
                            product p = content.products.First(i => i.ProductID == productid);
                            if (p != null)
                            {
                                p.KBdisplay = p.KBdisplay - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());
                                p.KBStore = p.KBStore - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());
                                p.StockLevel = p.StockLevel - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());


                            }
                        }
                        if (int.Parse(lab_storeID.Text) == 2 && int.Parse(dataGridView_sold.Rows[z].Cells[3].Value.ToString()) == 1)
                        {
                            product p = content.products.First(i => i.ProductID == productid);
                            if (p != null)
                            {
                                p.TWdisplay = p.TWdisplay - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());
                                p.TWStore = p.TWStore - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());
                                p.StockLevel = p.StockLevel - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());


                            }
                        }
                        if (int.Parse(lab_storeID.Text) == 1 && int.Parse(dataGridView_sold.Rows[z].Cells[3].Value.ToString()) == 0)
                        {
                            product p = content.products.First(i => i.ProductID == productid);
                            if (p != null)
                            {
                                p.KBStore = p.KBStore - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());
                                p.StockLevel = p.StockLevel - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());


                            }
                        }
                        if (int.Parse(lab_storeID.Text) == 2 && int.Parse(dataGridView_sold.Rows[z].Cells[3].Value.ToString()) == 0)
                        {
                            product p = content.products.First(i => i.ProductID == productid);
                            if (p != null)
                            {
                                p.TWStore = p.TWStore - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());
                                p.StockLevel = p.StockLevel - int.Parse(dataGridView_sold.Rows[z].Cells[1].Value.ToString());


                            }
                        }


                    }
                    content.SaveChanges();






                    MessageBox.Show("Saleorder Created and Product Available Updated");
                    btn_additem.Enabled = true;
                    //btn_payment.Enabled = true;
                    if (radioButton_sorder.Checked)
                    {
                        //CtoP = txt_orderid.Text;
                        CtoP = GetIDToPayment.Text;
                        CheckCtoP = "1";
                        Interface_Payment p = new Interface_Payment();
                        Interface_Payment.instance.lab1.Text = txt_orderid.Text;
                        p.Show();
                        this.Hide();
                        MessageBox.Show("Choose The Payment Method.");
                    }
                    else if (radioButton_dorder.Checked && int.Parse(lb_total.Items[0].ToString()) >= 5000)
                    {

                        Interface_Payment p = new Interface_Payment();
                        Interface_Payment.instance.lab1.Text = txt_orderid.Text;
                        p.Show();
                        MessageBox.Show("The Deposit Order is Created and The Reference Order Number is" + txt_orderid.Text);
                        this.Hide();



                    }
                    else if (radioButton_dorder.Checked && int.Parse(lb_total.Items[0].ToString()) < 5000)
                    {
                        Interface_Payment p = new Interface_Payment();
                        Interface_Payment.instance.lab1.Text = txt_orderid.Text;
                        p.Show();
                        MessageBox.Show("The Deposit Order is Created and The Reference Order Number is" + txt_orderid.Text);
                        this.Hide();

                    }
                }
            }
            catch (System.ArgumentOutOfRangeException) {MessageBox.Show("Check If There has some Information Are Missed"); }
            catch (System.NullReferenceException) { MessageBox.Show("Check If There Has Some Information Is Missed"); }
            catch (NotSupportedException) { MessageBox.Show("Please Add At least One Item in the Shooping Cart"); }


        }

        private void btn_addCus_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_firstname.Text == "" || txt_contact.Text == "" || txt_phone1.Text == "")
                {
                    throw new FormatException();
                }
                if (checkBox_newcustomer.Checked)
                {

                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {
                        Random R = new Random();
                        customer c = new customer
                        {
                            FirstName = txt_firstname.Text,
                            CompanyName = txt_compName.Text,
                            ContactPersion = txt_contact.Text,
                            Phone1 = txt_phone1.Text,
                            Phone2 = txt_phone2.Text,
                            AddressLine1 = txt_city.Text,
                            AddressLine2 = txt_building.Text,
                            AddressLine3 = txt_street.Text,
                            EmailAddress = txt_email.Text,
                            CustomerID = R.Next(100)
                        };
                        content.customers.Add(c);
                        content.SaveChanges();

                        customer id = content.customers.First(i => i.Phone1 == txt_phone1.Text);
   
                        comboBox_customerID.SelectedItem = id.CustomerID.ToString();
                        MessageBox.Show("Customer Information Created");
                    }
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Wrong 3");
            }
        }




        private void btn_remove_Click(object sender, EventArgs e)
        {

            try
            {
                
                if (lb_name.Items.Count == 2)
                {
                    if (int.Parse(comboBox_RPID.SelectedItem.ToString()) == int.Parse(lb_id.Items[1].ToString()))
                    {

                        lb_id.Items.Remove(lb_id.Items[1]);
                        lb_name.Items.Remove(lb_name.Items[1]);
                        lb_qty.Items.Remove(lb_qty.Items[1]);
                        lb_display.Items.Remove(lb_display.Items[1]);
                        lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(lb_price.Items[1].ToString());
                        lb_price.Items.Remove(lb_price.Items[1]);
                    }
                    if (lb_name.Items.Count == 1)
                    {
                        txt_depositamount.Text = "0";
                        numericUpDown_percentage.Minimum = 1;
                        numericUpDown_percentage.Value = 1;

                    }

                }
                if (lb_name.Items.Count == 3)
                {
                    for (int i = 1; i < 3; i++)
                    {
                        if (int.Parse(comboBox_RPID.SelectedItem.ToString()) == int.Parse(lb_id.Items[i].ToString()))
                        {

                            lb_id.Items.Remove(lb_id.Items[i]);
                            lb_name.Items.Remove(lb_name.Items[i]);
                            lb_qty.Items.Remove(lb_qty.Items[i]);
                            lb_display.Items.Remove(lb_display.Items[i]);
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(lb_price.Items[i].ToString());
                            lb_price.Items.Remove(lb_price.Items[i]);
                            break;
                        }
                    }


                }
                if (lb_name.Items.Count == 4)
                {
                    for (int i = 1; i < 4; i++)
                    {
                        if (int.Parse(comboBox_RPID.SelectedItem.ToString()) == int.Parse(lb_id.Items[i].ToString()))
                        {

                            lb_id.Items.Remove(lb_id.Items[i]);
                            lb_name.Items.Remove(lb_name.Items[i]);
                            lb_qty.Items.Remove(lb_qty.Items[i]);
                            lb_display.Items.Remove(lb_display.Items[i]);
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(lb_price.Items[i].ToString());
                            lb_price.Items.Remove(lb_price.Items[i]);
                            break;
                        }
                    }


                }
                if (lb_name.Items.Count == 5)
                {
                    for (int i = 1; i < 5; i++)
                    {
                        if (int.Parse(comboBox_RPID.SelectedItem.ToString()) == int.Parse(lb_id.Items[i].ToString()))
                        {

                            lb_id.Items.Remove(lb_id.Items[i]);
                            lb_name.Items.Remove(lb_name.Items[i]);
                            lb_qty.Items.Remove(lb_qty.Items[i]);
                            lb_display.Items.Remove(lb_display.Items[i]);
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(lb_price.Items[i].ToString());
                            lb_price.Items.Remove(lb_price.Items[i]);
                            break;

                        }
                    }
                }
                if (lb_name.Items.Count == 6)
                {
                    for (int i = 1; i < 6; i++)
                    {
                        if (int.Parse(comboBox_RPID.SelectedItem.ToString()) == int.Parse(lb_id.Items[i].ToString()))
                        {

                            lb_id.Items.Remove(lb_id.Items[i]);
                            lb_name.Items.Remove(lb_name.Items[i]);
                            lb_qty.Items.Remove(lb_qty.Items[i]);
                            lb_display.Items.Remove(lb_display.Items[i]);
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(lb_price.Items[i].ToString());
                            lb_price.Items.Remove(lb_price.Items[i]);
                            break;
                        }
                    }
                }
                if (lb_name.Items.Count == 7)
                {
                    for (int i = 1; i < 7; i++)
                    {
                        if (int.Parse(comboBox_RPID.SelectedItem.ToString()) == int.Parse(lb_id.Items[i].ToString()))
                        {

                            lb_id.Items.Remove(lb_id.Items[i]);
                            lb_name.Items.Remove(lb_name.Items[i]);
                            lb_qty.Items.Remove(lb_qty.Items[i]);
                            lb_display.Items.Remove(lb_display.Items[i]);
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(lb_price.Items[i].ToString());
                            lb_price.Items.Remove(lb_price.Items[i]);
                            break;
                        }
                    }
                }
                if (lb_name.Items.Count == 8)
                {
                    for (int i = 1; i < 8; i++)
                    {
                        if (int.Parse(comboBox_RPID.SelectedItem.ToString()) == int.Parse(lb_id.Items[i].ToString()))
                        {

                            lb_id.Items.Remove(lb_id.Items[i]);
                            lb_name.Items.Remove(lb_name.Items[i]);
                            lb_qty.Items.Remove(lb_qty.Items[i]);
                            lb_display.Items.Remove(lb_display.Items[i]);
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(lb_price.Items[i].ToString());
                            lb_price.Items.Remove(lb_price.Items[i]);
                            break;
                        }
                    }
                }
                if (lb_name.Items.Count == 9)
                {
                    for (int i = 1; i < 9; i++)
                    {
                        if (int.Parse(comboBox_RPID.SelectedItem.ToString()) == int.Parse(lb_id.Items[i].ToString()))
                        {

                            lb_id.Items.Remove(lb_id.Items[i]);
                            lb_name.Items.Remove(lb_name.Items[i]);
                            lb_qty.Items.Remove(lb_qty.Items[i]);
                            lb_display.Items.Remove(lb_display.Items[i]);
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(lb_price.Items[i].ToString());
                            lb_price.Items.Remove(lb_price.Items[i]);
                            break;
                        }
                    }

                }
                if (lb_name.Items.Count == 10)
                {
                    for (int i = 1; i < 10; i++)
                    {
                        if (int.Parse(comboBox_RPID.SelectedItem.ToString()) == int.Parse(lb_id.Items[i].ToString()))
                        {

                            lb_id.Items.Remove(lb_id.Items[i]);
                            lb_name.Items.Remove(lb_name.Items[i]);
                            lb_qty.Items.Remove(lb_qty.Items[i]);
                            lb_display.Items.Remove(lb_display.Items[i]);
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(lb_price.Items[i].ToString());
                            lb_price.Items.Remove(lb_price.Items[i]);
                            break;
                        }
                    }
                    comboBox_RPID.Items.Clear();
                    for (int x = 1; x < lb_id.Items.Count; x++)
                    {
                        comboBox_RPID.Items.Add(lb_id.Items[x].ToString());
                    }


                }
            }
            catch (System.IndexOutOfRangeException) { MessageBox.Show("Please Check the Quantity Of the Product That you want to remove is Correct"); }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The ProductID That You Want To Remove First."); }
        
        }
            
        

   

                private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btn_payment_Click(object sender, EventArgs e)
        {

        }



        private void combobox_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            string suppliernames = combobox_supplier.SelectedItem.ToString();
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                supplier suppliers = content.suppliers.First(i => i.SupplierName == suppliernames);
                if (suppliernames != null)
                {
                    int supplierID_str = suppliers.SupplierID;
                    txt_SupplierID.Text = supplierID_str.ToString();


                }

            }

        }

        private void combobox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string typenames = combobox_Type.SelectedItem.ToString();
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    type types = content.types.First(i => i.TypeName == typenames);
                    if (typenames != null)
                    {
                        txt_type.Text = types.TypeID.ToString();


                    }
                }
            }
            catch (NullReferenceException) { }

        }

        private void txt_SupplierID_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt_type_TextChanged(object sender, EventArgs e)
        {




        }

        private void checkbox_together_CheckedChanged(object sender, EventArgs e)
        {
            combobox_Type.Enabled = true;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                combobox_PID.Items.Clear();
                dataGridView1.Rows.Clear();
                
                using (var content = new betterlimitedEntities_Test1())
                {
                    int storeID =int.Parse( lab_storeID.Text);

                    if (radioButton_sorder.Checked&&radioButton1.Checked&& storeID==1)
                    {
                        string supplername = combobox_supplier.SelectedItem.ToString();
                        supplier suppliers = content.suppliers.First(i => i.SupplierName == supplername);
                        if (suppliers != null)
                        {
                            int supplierID_int = suppliers.SupplierID;





                            var emp = (from list in content.products
                                       where list.SupplierID == supplierID_int&&list.KBStore>0
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                supplier suppliers1 = content.suppliers.First(i => i.SupplierID == emp2.SupplierID);
                                dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, types.TypeName, suppliers1.SupplierName);

                            }
                        }
                    }
                   else if (radioButton_sorder.Checked && radioButton1.Checked && storeID == 2)
                    {
                        string supplername = combobox_supplier.SelectedItem.ToString();
                        supplier suppliers = content.suppliers.First(i => i.SupplierName == supplername);
                        if (suppliers != null)
                        {
                            int supplierID_int = suppliers.SupplierID;





                            var emp = (from list in content.products
                                       where list.SupplierID == supplierID_int && list.TWStore > 0
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                supplier suppliers1 = content.suppliers.First(i => i.SupplierID == emp2.SupplierID);
                                dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, types.TypeName, suppliers1.SupplierName);

                            }
                        }
                    }

                    else if (radioButton_sorder.Checked && radioButton2.Checked && storeID == 1)
                    {
                        string typename = combobox_Type.SelectedItem.ToString();
                        type t = content.types.First(i => i.TypeName == typename);
                        if (t != null)
                        {
                            int typeID_int = t.TypeID;




                            int typeID = int.Parse(txt_type.Text);
                            var emp = (from list in content.products
                                       where list.TypeID == typeID_int && list.KBStore > 0
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                supplier suppliers1 = content.suppliers.First(i => i.SupplierID == emp2.SupplierID);
                                dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, types.TypeName, suppliers1.SupplierName);

                            }
                        }


                    }
                    else if (radioButton_sorder.Checked && radioButton2.Checked && storeID == 1)
                    {
                        string typename = combobox_Type.SelectedItem.ToString();
                        type t = content.types.First(i => i.TypeName == typename);
                        if (t != null)
                        {
                            int typeID_int = t.TypeID;




                            int typeID = int.Parse(txt_type.Text);
                            var emp = (from list in content.products
                                       where list.TypeID == typeID_int && list.TWStore > 0
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                supplier suppliers1 = content.suppliers.First(i => i.SupplierID == emp2.SupplierID);
                                dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, types.TypeName, suppliers1.SupplierName);

                            }
                        }


                    }
                    else if (radioButton_sorder.Checked&&radioButton3.Checked && storeID == 1)
                    {


                        string supplername = combobox_supplier.SelectedItem.ToString();

                        string typename = combobox_Type.SelectedItem.ToString();
                        type t = content.types.First(i => i.TypeName == typename);
                        supplier suppliers = content.suppliers.First(i => i.SupplierName == supplername);
                        if (t != null && suppliers != null)
                        {
                            int typeID_int = t.TypeID;
                            int supplierID_int = suppliers.SupplierID;

                            int typeID = int.Parse(txt_type.Text);
                            var emp = (from list in content.products
                                       where list.TypeID == typeID_int && list.supplier.SupplierID == supplierID_int && list.KBStore > 0
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                supplier suppliers1 = content.suppliers.First(i => i.SupplierID == emp2.SupplierID);
                                dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, types.TypeName, suppliers1.SupplierName);

                            }
                        }
                    }
                    else if (radioButton_sorder.Checked && radioButton3.Checked && storeID == 2)
                    {


                        string supplername = combobox_supplier.SelectedItem.ToString();

                        string typename = combobox_Type.SelectedItem.ToString();
                        type t = content.types.First(i => i.TypeName == typename);
                        supplier suppliers = content.suppliers.First(i => i.SupplierName == supplername);
                        if (t != null && suppliers != null)
                        {
                            int typeID_int = t.TypeID;
                            int supplierID_int = suppliers.SupplierID;

                            int typeID = int.Parse(txt_type.Text);
                            var emp = (from list in content.products
                                       where list.TypeID == typeID_int && list.supplier.SupplierID == supplierID_int && list.TWStore > 0
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                supplier suppliers1 = content.suppliers.First(i => i.SupplierID == emp2.SupplierID);
                                dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, types.TypeName, suppliers1.SupplierName);

                            }
                        }
                    }
                    if (dataGridView1.RowCount == 0)
                    {
                        MessageBox.Show("No Result");
                    }
                    for (int x = 0; x < dataGridView1.RowCount; x++)
                    {
                        combobox_PID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                    }
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Fill In All The Require Information Such as Supplier Name Or Type Name"); }
            }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {



        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void combobox_PID_SelectedIndexChanged(object sender, EventArgs e)
        {
            numericUpDown_qty.Enabled = true;
            btn_additem.Enabled = true;
        }

        private void lb_addid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_name.Items.Count == 1)
            {
                lb_total.Items[0] = "0";

            }
            if (lb_id.Items.Count > 1)
            {

                btn_place.Enabled = true;
            }
        
       

        }

        private void lb_addname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (lb_name.Items.Count == 1)
                {
                    lb_total.Items[0] = "0";

                }
                if (lb_id.Items.Count > 1)
                {

                    btn_place.Enabled = true;
                }
            }
            catch (System.ArgumentOutOfRangeException) { }
      



        }

        private void lb_addqty_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if (lb_name.Items.Count == 1)
            {
                lb_total.Items[0] = "0";

            }
            if (lb_id.Items.Count > 1)
            {

                btn_place.Enabled = true;
            }
    


        }

        private void lb_price_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_name.Items.Count == 1)
            {
                lb_total.Items[0] = "0";

            }
            if (lb_id.Items.Count > 1)
            {

                btn_place.Enabled = true;
            }
     


        }

        private void lb_total_SelectedIndexChanged(object sender, EventArgs e)
        {

           


        }

        private void checkBox_depositorder_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (radioButton_sorder.Checked)
                {
              

                    if (MessageBox.Show("The Order Will Be Defined As Sale Order. Are You Sure?", "Sale Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        
                            combobox_PID.Items.Clear();
           
                      
                            using (var content = new betterlimitedEntities_Test1())
                            { 

                                dataGridView1.Rows.Clear();


                                var emp = (from list in content.products
                                           where list.Available==1
                                           select list);
                                foreach (var emp2 in emp.ToList())
                                {
                                    type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                    supplier suppliers = content.suppliers.First(i => i.SupplierID == emp2.SupplierID);
                                    if (types != null&& suppliers!=null)
                                    {
                                        dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, types.TypeName, suppliers.SupplierName);
                                    }
                                }
                            }
                        

                        checkBox_newcustomer.Enabled = true;
                       
                       // btn_place.Enabled = false;
                        comboBox_customerID.Enabled = true;
                        btn_search4cid.Enabled = true;
                        radioButton4.Enabled = true;
                        radioButton5.Enabled = true;
                        combobox_PID.Enabled = true;
                        radioButton_sorder.Enabled = false;
                        radioButton_dorder.Enabled = false;
                        radioButton1.Enabled = true;
                        radioButton2.Enabled = true;
                        radioButton3.Enabled = true;
                        combobox_supplier.Enabled = true;
                        combobox_Type.Enabled = true;
                      
                        btn_Search.Enabled = true;
                        //btn_rowremove.Enabled = true;
            

                        //btn_place.Enabled = true;

                        
                        MessageBox.Show("The Order Define As Sale Order, Please Choose The Store to Add Product");
                    }
                    else
                    {
                        radioButton_sorder.Checked = false;
                    }
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            
               

                    if (MessageBox.Show("The Order Will Be Defined As Deposit Order. Are You Sure?", "Deposit Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                lab_storeID.Text = "1";
                if (radioButton_dorder.Checked)
                    {

                        combobox_PID.Items.Clear();
                  

                        using (var content = new betterlimitedEntities_Test1())
                        { //keyword search

                            dataGridView1.Rows.Clear();


                            var emp = (from list in content.products
                                       where list.Available == 0
                                       select list);
                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                supplier suppliers = content.suppliers.First(i => i.SupplierID == emp2.SupplierID);
                                if (types != null && suppliers != null)
                                {
                                    dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, types.TypeName, suppliers.SupplierName);
                                }
                            }

                        }






                        checkBox_newcustomer.Enabled = true;
                        btn_sRemove.Enabled = false;

                    combobox_PID.Enabled = true;
                        radioButton_sorder.Enabled = false;
                        radioButton_dorder.Enabled = false;
                        
             
                        comboBox_customerID.Enabled = true;
                        radioButton4.Enabled = true;
                        radioButton5.Enabled = true;
                        radioButton1.Enabled = true;
                        radioButton2.Enabled = true;
                        radioButton3.Enabled = true;
                    
                        combobox_supplier.Enabled = true;
                        combobox_Type.Enabled = true;
                        btn_Search.Enabled = true;
                        combobox_PID.Enabled = true;


                 

                        MessageBox.Show("The Order Define As Deposit Order, Please Choose The Store to Add Product");
                        lab_percent.Visible = true;
                        txt_depositamount.Visible = true;
                        lab_depositamount.Visible = true;
                        numericUpDown_percentage.Visible = true;


                    }
                    else
                    {
                        radioButton_dorder.Checked = false;
                    }
                }
            

        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lab_percent.Visible = false;
                txt_depositamount.Visible = false;
                lab_depositamount.Visible = false;
                numericUpDown_percentage.Visible = false;
                comboBox_customerID.Items.Clear();
      
                txt_depositamount.Clear();
                lb_id.Items.Clear();
                lb_name.Items.Clear();
                lb_qty.Items.Clear();
                lb_total.Items.Clear();
                lb_price.Items.Clear();
                lb_display.Items.Clear();
                combobox_PID.Items.Clear();
                lb_id.Items.Add("ID");
                lb_name.Items.Add("Name");
                lb_qty.Items.Add("Qty");
                lb_price.Items.Add("Price");
                lb_display.Items.Add("DIS");
            

                

                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                combobox_PID.Enabled = false;
                combobox_supplier.Enabled = false;
                combobox_Type.Enabled = false;
               
               
                btn_Search.Enabled = false;
            

                btn_additem.Enabled = false;
        

                radioButton_dorder.Enabled = true;
                radioButton_sorder.Enabled = true;
                radioButton_dorder.Checked = false;
                radioButton_sorder.Checked = false;
                MessageBox.Show("Reset Order Interface.", "Reset Success.");

            }
            else { }
        }

        private void txt_customerID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Back To Lobby", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Interface_ShopStaff s = new Interface_ShopStaff();
                s.Show();
                this.Hide();


            }
            else { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int a = int.Parse(comboBox_RPID.SelectedItem.ToString());

                    product p1 = content.products.First(i => i.ProductID == a);
                    {
                        int price = p1.Price;
                        txt_price.Text = price.ToString();


                    }
                    if (lb_name.Items.Count == 1)
                    {
                        lb_total.Items[0] = "0";
                        numericUpDown_percentage.Minimum = 1;
                        numericUpDown_percentage.Value = 1;
                    }
                    if (lb_name.Items.Count == 2)
                    {


                        if (int.Parse(numericUpDown_Rqty.Value.ToString()) > int.Parse(lb_qty.Items[1].ToString()))
                        {
                            throw new IndexOutOfRangeException();

                        }

                        if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[1].ToString() && lb_display.Items[1].ToString() == "0" && chb_display.Checked == false)
                        {

                            lb_qty.Items[1] = int.Parse(lb_qty.Items[1].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                            lb_price.Items[1] = int.Parse(lb_price.Items[1].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                        }
                        else if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[1].ToString() && lb_display.Items[1].ToString() == "1" && chb_display.Checked == true)
                        {
                            lb_qty.Items[1] = int.Parse(lb_qty.Items[1].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                            lb_price.Items[1] = int.Parse(lb_price.Items[1].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                            lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                        }



                        if (int.Parse(lb_qty.Items[1].ToString()) == 0)
                        {

                            // lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text);
                            lb_id.Items.Remove(lb_id.Items[1]);
                            lb_name.Items.Remove(lb_name.Items[1]);
                            lb_qty.Items.Remove(lb_qty.Items[1]);
                            lb_price.Items.Remove(lb_price.Items[1]);
                            lb_display.Items.Remove(lb_display.Items[1]);
                            lb_total.Items[0] = "0";



                        }
                        if (radioButton_dorder.Checked && int.Parse(lb_total.Items[0].ToString()) >= 5000)
                        {
                            depositupdate();

                        }
                        if (lb_name.Items.Count == 1)
                        {
                            txt_depositamount.Text = "0";

                        }
                    }
                    if (lb_name.Items.Count == 3)
                    {


                        if (int.Parse(numericUpDown_Rqty.Value.ToString()) > int.Parse(lb_qty.Items[2].ToString()))
                        {
                            throw new IndexOutOfRangeException();

                        }
                        for (int i = 1; i < 3; i++)
                        {
                            if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {

                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                            else if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                        }

                        for (int i = 2; i > 0; i--)
                        {
                            if (int.Parse(lb_qty.Items[i].ToString()) == 0)
                            {
                                lb_id.Items.Remove(lb_id.Items[i]);
                                lb_name.Items.Remove(lb_name.Items[i]);
                                lb_qty.Items.Remove(lb_qty.Items[i]);
                                lb_price.Items.Remove(lb_price.Items[i]);
                                lb_display.Items.Remove(lb_display.Items[i]);
                                break;
                            }
                        }

                        if (int.Parse(lb_total.Items[0].ToString()) >= 5000)
                        {
                            depositupdate();

                        }
                        if (lb_name.Items.Count == 1)
                        {
                            txt_depositamount.Text = "0";

                        }


                    }
                    if (lb_name.Items.Count == 4)
                    {


                        if (int.Parse(numericUpDown_Rqty.Value.ToString()) > int.Parse(lb_qty.Items[2].ToString()))
                        {
                            throw new IndexOutOfRangeException();

                        }
                        for (int i = 1; i < 4; i++)
                        {
                            if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {

                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                            else if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                        }

                        for (int i = 3; i > 0; i--)
                        {
                            if (int.Parse(lb_qty.Items[i].ToString()) == 0)
                            {
                                lb_id.Items.Remove(lb_id.Items[i]);
                                lb_name.Items.Remove(lb_name.Items[i]);
                                lb_qty.Items.Remove(lb_qty.Items[i]);
                                lb_price.Items.Remove(lb_price.Items[i]);
                                lb_display.Items.Remove(lb_display.Items[i]);
                                break;
                            }
                        }
                        if (int.Parse(lb_total.Items[0].ToString()) >= 5000)
                        {
                            depositupdate();

                        }
                        if (lb_name.Items.Count == 1)
                        {
                            txt_depositamount.Text = "0";

                        }


                    }
                    if (lb_name.Items.Count == 5)
                    {


                        if (int.Parse(numericUpDown_Rqty.Value.ToString()) > int.Parse(lb_qty.Items[2].ToString()))
                        {
                            throw new IndexOutOfRangeException();

                        }
                        for (int i = 1; i < 5; i++)
                        {
                            if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {

                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                            else if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                        }

                        for (int i = 4; i > 0; i--)
                        {
                            if (int.Parse(lb_qty.Items[i].ToString()) == 0)
                            {
                                lb_id.Items.Remove(lb_id.Items[i]);
                                lb_name.Items.Remove(lb_name.Items[i]);
                                lb_qty.Items.Remove(lb_qty.Items[i]);
                                lb_price.Items.Remove(lb_price.Items[i]);
                                lb_display.Items.Remove(lb_display.Items[i]);
                                break;
                            }
                        }
                        if (int.Parse(lb_total.Items[0].ToString()) >= 5000)
                        {
                            depositupdate();

                        }
                        if (lb_name.Items.Count == 1)
                        {
                            txt_depositamount.Text = "0";

                        }


                    }
                    if (lb_name.Items.Count == 6)
                    {


                        if (int.Parse(numericUpDown_Rqty.Value.ToString()) > int.Parse(lb_qty.Items[2].ToString()))
                        {
                            throw new IndexOutOfRangeException();

                        }
                        for (int i = 1; i < 6; i++)
                        {
                            if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {

                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                            else if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                        }

                        for (int i = 5; i > 0; i--)
                        {
                            if (int.Parse(lb_qty.Items[i].ToString()) == 0)
                            {
                                lb_id.Items.Remove(lb_id.Items[i]);
                                lb_name.Items.Remove(lb_name.Items[i]);
                                lb_qty.Items.Remove(lb_qty.Items[i]);
                                lb_price.Items.Remove(lb_price.Items[i]);
                                lb_display.Items.Remove(lb_display.Items[i]);
                                break;
                            }
                        }
                        if (int.Parse(lb_total.Items[0].ToString()) >= 5000)
                        {
                            depositupdate();

                        }
                        if (lb_name.Items.Count == 1)
                        {
                            txt_depositamount.Text = "0";

                        }


                    }
                    if (lb_name.Items.Count == 7)
                    {


                        if (int.Parse(numericUpDown_Rqty.Value.ToString()) > int.Parse(lb_qty.Items[2].ToString()))
                        {
                            throw new IndexOutOfRangeException();

                        }
                        for (int i = 1; i < 7; i++)
                        {
                            if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {

                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                            else if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                        }

                        for (int i = 6; i > 0; i--)
                        {
                            if (int.Parse(lb_qty.Items[i].ToString()) == 0)
                            {
                                lb_id.Items.Remove(lb_id.Items[i]);
                                lb_name.Items.Remove(lb_name.Items[i]);
                                lb_qty.Items.Remove(lb_qty.Items[i]);
                                lb_price.Items.Remove(lb_price.Items[i]);
                                lb_display.Items.Remove(lb_display.Items[i]);
                                break;
                            }
                        }
                        if (int.Parse(lb_total.Items[0].ToString()) >= 5000)
                        {
                            depositupdate();

                        }
                        if (lb_name.Items.Count == 1)
                        {
                            txt_depositamount.Text = "0";

                        }


                    }
                    if (lb_name.Items.Count == 8)
                    {


                        if (int.Parse(numericUpDown_Rqty.Value.ToString()) > int.Parse(lb_qty.Items[2].ToString()))
                        {
                            throw new IndexOutOfRangeException();

                        }
                        for (int i = 1; i < 8; i++)
                        {
                            if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {

                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                            else if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                        }

                        for (int i = 7; i > 0; i--)
                        {
                            if (int.Parse(lb_qty.Items[i].ToString()) == 0)
                            {
                                lb_id.Items.Remove(lb_id.Items[i]);
                                lb_name.Items.Remove(lb_name.Items[i]);
                                lb_qty.Items.Remove(lb_qty.Items[i]);
                                lb_price.Items.Remove(lb_price.Items[i]);
                                lb_display.Items.Remove(lb_display.Items[i]);
                                break;
                            }
                        }
                        if (int.Parse(lb_total.Items[0].ToString()) >= 5000)
                        {
                            depositupdate();

                        }
                        if (lb_name.Items.Count == 1)
                        {
                            txt_depositamount.Text = "0";

                        }



                    }
                    if (lb_name.Items.Count == 9)
                    {


                        if (int.Parse(numericUpDown_Rqty.Value.ToString()) > int.Parse(lb_qty.Items[2].ToString()))
                        {
                            throw new IndexOutOfRangeException();

                        }
                        for (int i = 1; i < 9; i++)
                        {
                            if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {

                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                            else if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                        }

                        for (int i = 8; i > 0; i--)
                        {
                            if (int.Parse(lb_qty.Items[i].ToString()) == 0)
                            {
                                lb_id.Items.Remove(lb_id.Items[i]);
                                lb_name.Items.Remove(lb_name.Items[i]);
                                lb_qty.Items.Remove(lb_qty.Items[i]);
                                lb_price.Items.Remove(lb_price.Items[i]);
                                lb_display.Items.Remove(lb_display.Items[i]);
                                break;
                            }
                        }
                        if (int.Parse(lb_total.Items[0].ToString()) >= 5000)
                        {
                            depositupdate();

                        }
                        if (lb_name.Items.Count == 1)
                        {
                            txt_depositamount.Text = "0";

                        }


                    }
                    if (lb_name.Items.Count == 10)
                    {


                        if (int.Parse(numericUpDown_Rqty.Value.ToString()) > int.Parse(lb_qty.Items[2].ToString()))
                        {
                            throw new IndexOutOfRangeException();

                        }
                        for (int i = 1; i < 10; i++)
                        {
                            if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "0" && chb_display.Checked == false)
                            {

                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                            else if (comboBox_RPID.SelectedItem.ToString() == lb_id.Items[i].ToString() && lb_display.Items[i].ToString() == "1" && chb_display.Checked == true)
                            {
                                lb_qty.Items[i] = int.Parse(lb_qty.Items[i].ToString()) - int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_price.Items[i] = int.Parse(lb_price.Items[i].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                lb_total.Items[0] = int.Parse(lb_total.Items[0].ToString()) - int.Parse(txt_price.Text) * 0.7 * int.Parse(numericUpDown_Rqty.Value.ToString());
                                break;
                            }
                        }

                        for (int i = 9; i > 0; i--)
                        {
                            if (int.Parse(lb_qty.Items[i].ToString()) == 0)
                            {
                                lb_id.Items.Remove(lb_id.Items[i]);
                                lb_name.Items.Remove(lb_name.Items[i]);
                                lb_qty.Items.Remove(lb_qty.Items[i]);
                                lb_price.Items.Remove(lb_price.Items[i]);
                                lb_display.Items.Remove(lb_display.Items[i]);
                                break;
                            }
                        }
                        if (int.Parse(lb_total.Items[0].ToString()) >= 5000)
                        {
                            depositupdate();

                        }
                        if (lb_name.Items.Count == 1)
                        {
                            txt_depositamount.Text = "0";

                        }


                    }
                    comboBox_RPID.Items.Clear();
                    for (int x = 1; x < lb_id.Items.Count; x++)
                    {
                        comboBox_RPID.Items.Add(lb_id.Items[x].ToString());
                    }
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The ProductID That You Want To Remove First."); }
            catch (IndexOutOfRangeException) { MessageBox.Show("The Order Do Not Have Enough Quantity to Remove"); }
            }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_quantity.Checked)
            {
                numericUpDown_Rqty.Enabled = true;
                btn_sRemove.Enabled = true;

            }
            else {
                numericUpDown_Rqty.Enabled = false;
                btn_sRemove.Enabled = false;
            }
        }

        private void numericUpDown_Rqty_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_quantity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_quantity.Checked)
            {
                numericUpDown_Rqty.Enabled = true;
                btn_sRemove.Enabled = true;
            }
            else {
                numericUpDown_Rqty.Enabled = false;
                btn_sRemove.Enabled = false;

            }

            }

        private void numericUpDown_qty_ValueChanged(object sender, EventArgs e)
        {
            btn_additem.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int total = int.Parse(lb_total.Items[0].ToString());
                double percentage = double.Parse(numericUpDown_percentage.Value.ToString()) / 100;
                txt_depositamount.Text = (total * percentage).ToString();
            }
            catch (System.ArgumentOutOfRangeException) { MessageBox.Show("Please Add The Order Item First"); }

            }

        

        private void lab_depositamount_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_newcustomer.Checked)
            {

                comboBox_customerID.Enabled = false;
                txt_city.Enabled = true;
                txt_firstname.Enabled = true;
                txt_lastname.Enabled = true;
                txt_email.Enabled = true;
                txt_phone1.Enabled = true;
                txt_phone2.Enabled = true;
                txt_street.Enabled = true;
                txt_compName.Enabled = true;
                txt_building.Enabled = true;
                txt_contact.Enabled = true;
                txt_firstname.Text = "/";
                txt_lastname.Text = "/";
                txt_compName.Text = "/";
                txt_contact.Text = "/";
                txt_phone1.Text = "/";
                txt_phone2.Text = "/";
                txt_city.Text = "/";
                txt_building.Text = "/";
                txt_street.Text = "/";
                txt_email.Text = "/";
                
               
            }
            else {
                txt_contact.Enabled = false;
                comboBox_customerID.Enabled = true;
                txt_city.Enabled = false;
                txt_firstname.Enabled = false;
                txt_lastname.Enabled = false;
                txt_email.Enabled = false;
                txt_phone1.Enabled = false;
                txt_phone2.Enabled = false;
                txt_street.Enabled = false;
                txt_compName.Enabled = false;
                txt_building.Enabled = false;
                txt_firstname.Text = "";
                txt_lastname.Text = "";
                txt_compName.Text = "";
                txt_contact.Text = "";
                txt_phone1.Text = "";
                txt_phone2.Text = "";
                txt_city.Text = "";
                txt_building.Text = "";
                txt_street.Text = "";
                txt_email.Text = "";
            }
        }

        private void radioButton4_CheckedChanged_1(object sender, EventArgs e)
        {
            
            if (radioButton5.Checked)
            {
                btn_search4cid.Enabled = false;
                txt_tel.Enabled = true;
                combobox_RegionPhone.Enabled = true;
                txt_cname.Enabled = false;

            }

        }

        private void radioButton5_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton4.Checked) {

                btn_search4cid.Enabled = true;
                txt_cname.Enabled = true;
                txt_tel.Enabled = false;
                combobox_RegionPhone.Enabled = false;

            }

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            comboBox_customerID.Items.Clear();
            using (var content = new betterlimitedEntities_Test1())
            {
                if (radioButton4.Checked)
                {
                    string cname = txt_cname.Text;
                    var emp = (from list in content.customers
                               where list.FirstName==cname
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                        dataGridView2.Rows.Add(emp2.CustomerID, emp2.LastName, emp2.FirstName, emp2.Phone1, emp2.Phone2,emp2.EmailAddress);

                    }

                }
                else if (radioButton5.Checked)
                {
                    string phone = combobox_RegionPhone.SelectedItem.ToString() + txt_tel.Text;
                    var emp = (from list in content.customers
                               where list.Phone1 == phone||list.Phone2== phone
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                        dataGridView2.Rows.Add(emp2.CustomerID,emp2.LastName, emp2.FirstName, emp2.Phone1, emp2.Phone2, emp2.EmailAddress);

                    }


                }
                
            }
            if (dataGridView2.RowCount == 0) {
                MessageBox.Show("No Result");
            }
            if (dataGridView2.RowCount > 0)
            {
                for (int x = 0; x < dataGridView2.RowCount; x++)
                {
                    comboBox_customerID.Items.Add(dataGridView2.Rows[x].Cells[0].Value.ToString());
                }
            }
        }

        private void txt_cname_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chb_display_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_tel_TextChanged(object sender, EventArgs e)
        {
            if (txt_tel.Text != "") { }
            btn_search4cid.Enabled = true;

        }

        private void txt_phonenum_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void cmb_store_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
    }

