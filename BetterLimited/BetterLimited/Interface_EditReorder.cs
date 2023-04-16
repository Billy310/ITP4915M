using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class Interface_EditReorder : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public Interface_EditReorder()
        {
            InitializeComponent();
        }
        void mySubjects()
        {
            string command_query = "SELECT DISTINCT SupplierName FROM betterlimited.supplier";
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
                MessageBox.Show("ERROR");

            }

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
                MessageBox.Show("ERROR");

            }

        }


  
        void add2product1()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p1.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        void add2product2()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p2.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        void add2product3()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p3.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        void add2product4()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p4.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        void add2product5()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p5.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        void add2product6()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p6.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        void add2product7()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p7.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        void add2product8()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p8.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        void add2product9()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p9.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        void add2product10()
        {
            string command_query = "SELECT ProductName FROM betterlimited.product WHERE stocklevel<=low_Standard";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cb_p10.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Reorder Error");

            }

        }
        private void EditReorder_Load(object sender, EventArgs e)
        {
            add2product1();
            add2product2();
            add2product3();
            add2product4();
            add2product5();
            add2product6();
            add2product7();
            add2product8();
            add2product9();
            add2product10();
            groupBox2.Visible = false;
            cb_p1.Visible = false;
            cb_p2.Visible = false;
            cb_p3.Visible = false;
            cb_p4.Visible = false;
            cb_p5.Visible = false;
            cb_p6.Visible = false;
            cb_p7.Visible = false;
            cb_p8.Visible = false;
            cb_p9.Visible = false;
            cb_p10.Visible = false;
            lab_p1.Visible = false;
            lab_p2.Visible = false;
            lab_p3.Visible = false;
            lab_p4.Visible = false;
            lab_p5.Visible = false;
            lab_p6.Visible = false;
            lab_p7.Visible = false;
            lab_p8.Visible = false;
            lab_p9.Visible = false;
            lab_p10.Visible = false;
            btn_addp2.Visible = false;
            btn_addp3.Visible = false;
            btn_addp4.Visible = false;
            btn_addp5.Visible = false;
            btn_addp6.Visible = false;
            btn_addp7.Visible = false;
            btn_addp8.Visible = false;
            btn_addp9.Visible = false;
            btn_addp10.Visible = false;
            cmb_EditID.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p1.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p2.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p3.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p4.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p5.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p6.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p7.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p8.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p9.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_p10.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_approve.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_supplier.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            mySubjects();
            add2ComboboxType();
            cmb_approve.Items.Add("Waiting Approve");

            
            txt_SupplierID.Enabled = false;
            txt_type.Enabled = false;
            txt_prod.Enabled = false;
            // btn_edit.Enabled = false;
            count.Hide();
            //  cmb_proName.Enabled = false;
            // txt_ProductID.Enabled = false;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            int typeID_int = 0;
            int supplierID_int = 0;
            if (txt_SupplierID.Text != "")
            {
                supplierID_int = int.Parse(txt_SupplierID.Text);
            }
            if (txt_type.Text != "")
            {
                typeID_int = int.Parse(txt_type.Text);
            }
            if (radioBtn_typeandSupplier.Checked)
            {
                dataGridView2.Rows.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {


                    int typeID = int.Parse(txt_type.Text);
                    var emp = (from list in content.products
                               where list.StockLevel <= list.Low_Standard && list.TypeID == typeID && list.SupplierID == supplierID_int
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {

                        dataGridView2.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.StockLevel);

                    }



                }


            }
            else if (radioBtn_type.Checked)
            {
                dataGridView2.Rows.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {



                    var emp = (from list in content.products
                               where list.StockLevel <= list.Low_Standard && list.TypeID == typeID_int
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {

                        dataGridView2.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.StockLevel);

                    }



                }

            }
            else if (radioButton_supplier.Checked)
            {
                dataGridView2.Rows.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {



                    var emp = (from list in content.products
                               where list.StockLevel <= list.Low_Standard && list.TypeID == supplierID_int
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {

                        dataGridView2.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.StockLevel);

                    }



                }

            }
            if (dataGridView2.RowCount == 0)
            {
                MessageBox.Show("No Result For The Product That Is Staying In Low Stock Level");
            }
        }

        private void txt_SupplierID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_type_TextChanged(object sender, EventArgs e)
        {

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

        private void btn_Ordsearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (Rbtn_status.Checked)
                {
                    dataGridView1.Rows.Clear();

                    using (var content = new betterlimitedEntities_Test1())
                    {
                        string status = cmb_approve.SelectedItem.ToString();
                        {

                            var emp = (from list in content.reorders
                                       where list.Approve == status
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                product product1 = content.products.First(i => i.ProductID == emp2.Product1);
                                product product2 = content.products.First(i => i.ProductID == emp2.Product2);
                                product product3 = content.products.First(i => i.ProductID == emp2.Product3);
                                product product4 = content.products.First(i => i.ProductID == emp2.Product4);
                                product product5 = content.products.First(i => i.ProductID == emp2.Product5);
                                product product6 = content.products.First(i => i.ProductID == emp2.Product6);
                                product product7 = content.products.First(i => i.ProductID == emp2.Product7);
                                product product8 = content.products.First(i => i.ProductID == emp2.Product8);
                                product product9 = content.products.First(i => i.ProductID == emp2.Product9);
                                product product10 = content.products.First(i => i.ProductID == emp2.Product10);

                                if (product1 != null && product2 != null && product3 != null && product4 != null && product5 != null && product6 != null && product7 != null && product8 != null
                                    && product9 != null && product10 != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ReorderCreatedDate, emp2.ReorderID, emp2.Approve, product1.ProductName, product2.ProductName, product3.ProductName, product4.ProductName,
                                        product5.ProductName, product6.ProductName, product7.ProductName, product8.ProductName, product9.ProductName, product10.ProductName);
                                }
                            }
                            for (int x = 0; x < dataGridView1.RowCount; x++)
                            {
                                cmb_EditID.Items.Add(dataGridView1.Rows[x].Cells[1].Value.ToString());
                            }
                        }



                    }

                }
                else if (Rbtn_Date.Checked)
                {
                    dataGridView1.Rows.Clear();
                    DateTime a = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                    using (var content = new betterlimitedEntities_Test1())
                    {
                        string status = cmb_approve.SelectedItem.ToString();
                        {

                            var emp = (from list in content.reorders
                                       where list.ReorderCreatedDate == a
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                product product1 = content.products.First(i => i.ProductID == emp2.Product1);
                                product product2 = content.products.First(i => i.ProductID == emp2.Product2);
                                product product3 = content.products.First(i => i.ProductID == emp2.Product3);
                                product product4 = content.products.First(i => i.ProductID == emp2.Product4);
                                product product5 = content.products.First(i => i.ProductID == emp2.Product5);
                                product product6 = content.products.First(i => i.ProductID == emp2.Product6);
                                product product7 = content.products.First(i => i.ProductID == emp2.Product7);
                                product product8 = content.products.First(i => i.ProductID == emp2.Product8);
                                product product9 = content.products.First(i => i.ProductID == emp2.Product9);
                                product product10 = content.products.First(i => i.ProductID == emp2.Product10);

                                if (product1 != null && product2 != null && product3 != null && product4 != null && product5 != null && product6 != null && product7 != null && product8 != null
                                    && product9 != null && product10 != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ReorderCreatedDate, emp2.ReorderID, emp2.Approve, product1.ProductName, product2.ProductName, product3.ProductName, product4.ProductName,
                                        product5.ProductName, product6.ProductName, product7.ProductName, product8.ProductName, product9.ProductName, product10.ProductName);
                                }
                            }
                        }


                    }

                }
                else if (radioBtn_dateandstatus.Checked)
                {
                    dataGridView1.Rows.Clear();
                    DateTime a = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd"));

                    using (var content = new betterlimitedEntities_Test1())
                    {
                        string status = cmb_approve.SelectedItem.ToString();
                        {

                            var emp = (from list in content.reorders
                                       where list.ReorderCreatedDate == a && list.Approve == status
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                product product1 = content.products.First(i => i.ProductID == emp2.Product1);
                                product product2 = content.products.First(i => i.ProductID == emp2.Product2);
                                product product3 = content.products.First(i => i.ProductID == emp2.Product3);
                                product product4 = content.products.First(i => i.ProductID == emp2.Product4);
                                product product5 = content.products.First(i => i.ProductID == emp2.Product5);
                                product product6 = content.products.First(i => i.ProductID == emp2.Product6);
                                product product7 = content.products.First(i => i.ProductID == emp2.Product7);
                                product product8 = content.products.First(i => i.ProductID == emp2.Product8);
                                product product9 = content.products.First(i => i.ProductID == emp2.Product9);
                                product product10 = content.products.First(i => i.ProductID == emp2.Product10);

                                if (product1 != null && product2 != null && product3 != null && product4 != null && product5 != null && product6 != null && product7 != null && product8 != null
                                    && product9 != null && product10 != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ReorderCreatedDate, emp2.ReorderID, emp2.Approve, product1.ProductName, product2.ProductName, product3.ProductName, product4.ProductName,
                                        product5.ProductName, product6.ProductName, product7.ProductName, product8.ProductName, product9.ProductName, product10.ProductName);
                                }
                            }
                        }


                    }
                  

                }
                if (dataGridView1.RowCount == 0)
                {

                    MessageBox.Show("There is No Result");
                }
            }
            catch (NullReferenceException) { MessageBox.Show("Please Select The Require Information That You Want To Select"); }
        }

        private void txt_prod_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmb_prod_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RT_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {

        }

        private void btn_view_Click(object sender, EventArgs e)
        {

        }

        private void btn_editing_Click(object sender, EventArgs e)
        {

        }

        private void cmb_EditID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                int reorderID = int.Parse(cmb_EditID.SelectedItem.ToString());

                reorder reorders = content.reorders.First(i => i.ReorderID == reorderID);
                if (reorders != null)
                {
                    txt_p1.Text = reorders.Product1.ToString();
                    txt_p2.Text = reorders.Product2.ToString();
                    txt_p3.Text = reorders.Product3.ToString();
                    txt_p4.Text = reorders.Product4.ToString();
                    txt_p5.Text = reorders.Product5.ToString();
                    txt_p6.Text = reorders.Product6.ToString();
                    txt_p7.Text = reorders.Product7.ToString();
                    txt_p8.Text = reorders.Product8.ToString();
                    txt_p9.Text = reorders.Product9.ToString();
                    txt_p10.Text = reorders.Product10.ToString();
                }
                string[] productname = { txt_p1.Text, txt_p2.Text, txt_p3.Text, txt_p4.Text, txt_p5.Text, txt_p6.Text, txt_p7.Text, txt_p8.Text, txt_p9.Text, txt_p10.Text };
                for (int x = 0; x < productname.Length; x++)
                {
                    int productID = int.Parse(productname[x].ToString());
                    product products = content.products.First(i => i.ProductID == productID);
                    if (reorders != null)
                    {
                        productname[x] = products.ProductName;

                    }
                }
                txt_p1.Text = productname[0];
                txt_p2.Text = productname[1];
                txt_p3.Text = productname[2];
                txt_p4.Text = productname[3];
                txt_p5.Text = productname[4];
                txt_p6.Text = productname[5];
                txt_p7.Text = productname[6];
                txt_p8.Text = productname[7];
                txt_p9.Text = productname[8];
                txt_p10.Text = productname[9];

                {
                    if (txt_p1.Text != "")
                    {
                        groupBox2.Visible = true;
                        lab_p1.Visible = true;
                        cb_p1.Visible = true;
                        cb_p1.SelectedItem = txt_p1.Text;
                    }


                    if (txt_p2.Text != "")
                    {
                        cb_p2.SelectedItem = txt_p2.Text;
                        lab_p2.Visible = true;
                        cb_p2.Visible = true;
                        btn_addp2.Visible = false;
                        btn_addp3.Visible = true;
                    }



                    if (txt_p3.Text != "")
                    {
                        cb_p3.SelectedItem = txt_p3.Text;
                        lab_p3.Visible = true;
                        cb_p3.Visible = true;
                        btn_addp3.Visible = false;
                        btn_addp4.Visible = true;
                    }






                    if (txt_p4.Text != "")
                    {
                        cb_p4.SelectedItem = txt_p4.Text;
                        lab_p4.Visible = true;
                        cb_p4.Visible = true;
                        btn_addp4.Visible = false;
                        btn_addp5.Visible = true;
                    }





                    if (txt_p5.Text != "")
                    {
                        cb_p5.SelectedItem = txt_p5.Text;
                        lab_p5.Visible = true;
                        cb_p5.Visible = true;
                        btn_addp5.Visible = false;
                        btn_addp6.Visible = true;
                    }



                    if (txt_p6.Text != "")
                    {
                        cb_p6.SelectedItem = txt_p6.Text;
                        lab_p6.Visible = true;
                        cb_p6.Visible = true;
                        btn_addp6.Visible = false;
                        btn_addp7.Visible = true;
                    }





                    if (txt_p7.Text != "")
                    {
                        cb_p7.SelectedItem = txt_p7.Text;
                        lab_p7.Visible = true;
                        cb_p7.Visible = true;
                        btn_addp7.Visible = false;
                        btn_addp8.Visible = true;
                    }





                    if (txt_p8.Text != "")
                    {
                        cb_p8.SelectedItem = txt_p8.Text;
                        lab_p8.Visible = true;
                        cb_p8.Visible = true;
                        btn_addp8.Visible = false;
                        btn_addp9.Visible = true;
                    }





                    if (txt_p9.Text != "")
                    {
                        cb_p9.SelectedItem = txt_p9.Text;
                        lab_p9.Visible = true;
                        cb_p9.Visible = true;
                        btn_addp9.Visible = false;
                        btn_addp10.Visible = true;
                    }





                    if (txt_p10.Text != "")
                    {
                        cb_p10.SelectedItem = txt_p10.Text;
                        lab_p10.Visible = true;
                        cb_p10.Visible = true;
                        btn_addp10.Visible = false;

                    }
                    else if (txt_p2.Text == "")
                    {
                        lab_p2.Visible = false;
                        cb_p2.Visible = false;
                        btn_addp2.Visible = true;
                    }
                    else if (txt_p3.Text == "")
                    {
                        lab_p3.Visible = false;
                        cb_p3.Visible = false;
                        btn_addp3.Visible = true;
                    }
                    else if (txt_p4.Text == "")
                    {
                        lab_p4.Visible = false;
                        cb_p4.Visible = false;
                        btn_addp4.Visible = true;
                    }
                    else if (txt_p5.Text == "")
                    {
                        lab_p5.Visible = false;
                        cb_p5.Visible = false;
                        btn_addp5.Visible = true;
                    }
                    else if (txt_p6.Text == "")
                    {
                        lab_p6.Visible = false;
                        cb_p6.Visible = false;
                        btn_addp6.Visible = true;
                    }
                    else if (txt_p7.Text == "")
                    {
                        lab_p7.Visible = false;
                        cb_p7.Visible = false;
                        btn_addp7.Visible = true;
                    }
                    else if (txt_p8.Text == "")
                    {
                        lab_p8.Visible = false;
                        cb_p8.Visible = false;
                        btn_addp8.Visible = true;
                    }

                    else if (txt_p9.Text == "")
                    {
                        lab_p9.Visible = false;
                        cb_p9.Visible = false;
                        btn_addp9.Visible = true;
                    }
                    else if (txt_p10.Text == "")
                    {
                        lab_p10.Visible = false;
                        cb_p10.Visible = false;
                        btn_addp10.Visible = true;
                    }





                }
            }

        }



        private void cmb_proName_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void cb_p2_SelectedIndexChanged(object sender, EventArgs e)
        {



        }






        private void btn_addp2_Click(object sender, EventArgs e)
        {
            try
            {
                lab_p2.Visible = true;
                cb_p2.Visible = true;
                btn_addp2.Visible = false;
                if (cb_p1.Text != "")
                {
                    btn_addp3.Visible = true;
                }
                else
                {
                    throw new FormatException();

                }
            }
            catch (FormatException) { MessageBox.Show("The Previous Product Do not Insert any ProductName."); }
        }

        private void btn_addp3_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_p2.Text != "")
                {
                    lab_p3.Visible = true;
                    cb_p3.Visible = true;
                    btn_addp3.Visible = false;
                    btn_addp4.Visible = true;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException) { MessageBox.Show("The Previous Product Do not Insert any ProductName."); }
        }

        private void btn_addp4_Click(object sender, EventArgs e)
        {

            try
            {
                if (cb_p3.Text != "")
                {
                    lab_p4.Visible = true;
                    cb_p4.Visible = true;
                    btn_addp4.Visible = false;
                    btn_addp5.Visible = true;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException) { MessageBox.Show("The Previous Product Do not Insert any ProductName."); }
        }


        private void btn_addp5_Click(object sender, EventArgs e)
        {

            try
            {
                if (cb_p4.Text != "")
                {
                    lab_p5.Visible = true;
                    cb_p5.Visible = true;
                    btn_addp5.Visible = false;
                    btn_addp6.Visible = true;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException) { MessageBox.Show("The Previous Product Do not Insert any ProductName."); }
        }


        private void btn_addp6_Click(object sender, EventArgs e)
        {

            try
            {
                if (cb_p5.Text != "")
                {
                    lab_p6.Visible = true;
                    cb_p6.Visible = true;
                    btn_addp6.Visible = false;
                    btn_addp7.Visible = true;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException) { MessageBox.Show("The Previous Product Do not Insert any ProductName."); }
        }

        private void btn_addp7_Click(object sender, EventArgs e)
        {

            try
            {
                if (cb_p6.Text != "")
                {
                    lab_p7.Visible = true;
                    cb_p7.Visible = true;
                    btn_addp7.Visible = false;
                    btn_addp8.Visible = true;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException) { MessageBox.Show("The Previous Product Do not Insert any ProductName."); }
        }

        private void btn_addp8_Click(object sender, EventArgs e)
        {

            try
            {
                if (cb_p7.Text != "")
                {
                    lab_p8.Visible = true;
                    cb_p8.Visible = true;
                    btn_addp8.Visible = false;
                    btn_addp9.Visible = true;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException) { MessageBox.Show("The Previous Product Do not Insert any ProductName."); }
        }

        private void btn_addp9_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_p8.Text != "")
                {
                    lab_p9.Visible = true;
                    cb_p9.Visible = true;
                    btn_addp9.Visible = false;
                    btn_addp10.Visible = true;
                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException) { MessageBox.Show("The Previous Product Do not Insert any ProductName."); }
        }

        private void btn_addp10_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_p9.Text != "")
                {
                    lab_p10.Visible = true;
                    cb_p10.Visible = true;
                    btn_addp10.Visible = false;

                }
                else
                {
                    throw new FormatException();
                }
            }
            catch (FormatException) { MessageBox.Show("The Previous Product Do not Insert any ProductName."); }

        }

        private void cb_p1_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void cb_p3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_p4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_p5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_p6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_p7_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cb_p8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_p9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_p10_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

            try
            {
                if (cb_p1.Text == "" && cb_p2.Text == "" && cb_p3.Text == ""
              && cb_p4.Text == "" && cb_p5.Text == ""
              && cb_p6.Text == "" && cb_p7.Text == ""
              && cb_p8.Text == "" && cb_p9.Text == ""
              && cb_p10.Text == "")
                {
                    throw new InvalidExpressionException();
                }

                txt_p1.Clear();
                txt_p2.Clear();
                txt_p3.Clear();
                txt_p4.Clear();
                txt_p5.Clear();
                txt_p6.Clear();
                txt_p7.Clear();
                txt_p8.Clear();
                txt_p9.Clear();
                txt_p10.Clear();
                if (cb_p1.Text != "")
                {
                    txt_p1.Text = cb_p1.SelectedItem.ToString();
                }
                if (cb_p2.Text != "")
                {
                    txt_p2.Text = cb_p2.SelectedItem.ToString();
                }
                if (cb_p3.Text != "")
                {
                    txt_p3.Text = cb_p3.SelectedItem.ToString();
                }
                if (cb_p4.Text != "")
                {
                    txt_p4.Text = cb_p4.SelectedItem.ToString();
                }
                if (cb_p5.Text != "")
                {
                    txt_p5.Text = cb_p5.SelectedItem.ToString();
                }
                if (cb_p6.Text != "")
                {
                    txt_p6.Text = cb_p6.SelectedItem.ToString();
                }
                if (cb_p7.Text != "")
                {
                    txt_p7.Text = cb_p7.SelectedItem.ToString();
                }
                if (cb_p8.Text != "")
                {
                    txt_p8.Text = cb_p8.SelectedItem.ToString();
                }

                if (cb_p9.Text != "")
                {

                    txt_p9.Text = cb_p9.SelectedItem.ToString();

                }
                if (cb_p10.Text != "")
                {
                    txt_p10.Text = cb_p10.SelectedItem.ToString();
                }
                string[] productname = { txt_p1.Text, txt_p2.Text, txt_p3.Text, txt_p4.Text, txt_p5.Text, txt_p6.Text, txt_p7.Text, txt_p8.Text, txt_p9.Text, txt_p10.Text };
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[0] == productname[x] && productname[x] != "" && x != 0)
                    {
                        throw new FormatException();
                    }
                }
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[1] == productname[x] && productname[x] != "" && x != 1)
                    {
                        throw new FormatException();
                    }
                }
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[2] == productname[x] && productname[x] != "" && x != 2)
                    {
                        throw new FormatException();
                    }
                }
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[3] == productname[x] && productname[x] != "" && x != 3)
                    {
                        throw new FormatException();
                    }
                }
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[4] == productname[x] && productname[x] != "" && x != 4)
                    {
                        throw new FormatException();
                    }
                }
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[5] == productname[x] && productname[x] != "" && x != 5)
                    {
                        throw new FormatException();
                    }
                }
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[6] == productname[x] && productname[x] != "" && x != 6)
                    {
                        throw new FormatException();
                    }
                }
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[7] == productname[x] && productname[x] != "" && x != 7)
                    {
                        throw new FormatException();
                    }
                }
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[8] == productname[x] && productname[x] != "" && x != 8)
                    {
                        throw new FormatException();
                    }
                }
                for (int x = 0; x < productname.Length; x++)
                {
                    if (productname[9] == productname[x] && productname[x] != "" && x != 9)
                    {
                        throw new FormatException();
                    }
                }
                string output = string.Empty;
                for (int x = 0; x < productname.Length; x++)
                {
                    if (x <= 8)
                    {
                        if (productname[x] == "" && productname[x+1] != "")
                        {
                            productname[x] = productname[x + 1];
                            productname[x + 1] = "";

                        }
                    }
                    if (x == 9) {
                        if (productname[8] == "" && productname[8] != productname[9]) {
                            productname[8] = productname[9];
                            productname[9] = "";
                        }
                    }
                }


                for (int i = 0; i < 9; i++)
                {
                    if (productname[i] == "")
                    {
                        int a = i;
                        for (int x = ++i; x < 10; x++)
                        {
                            if (productname[x] != "")
                            {
                                productname[a] = productname[x];
                                productname[x] = "";
                                a++;
                            }
                        }
                    }
                }
                

                // foreach (var item in productname)
                // {
                //    output += item + "\n";
                // }

                // MessageBox.Show(output);




                for (int x = 0; x < 10; x++)
                {
                    if (x == 0)
                    {
                        txt_p1.Text = productname[0];

                    }
                    if (x == 1)
                    {
                        txt_p2.Text = productname[1];

                    }
                    if (x == 3)
                    {
                        txt_p3.Text = productname[2];

                    }
                    if (x == 4)
                    {
                        txt_p4.Text = productname[3];

                    }
                    if (x == 5)
                    {
                        txt_p5.Text = productname[4];

                    }
                    if (x == 6)
                    {
                        txt_p6.Text = productname[5];

                    }
                    if (x == 7)
                    {
                        txt_p7.Text = productname[6];

                    }
                    if (x == 8)
                    {
                        txt_p8.Text = productname[7];

                    }
                    if (x == 9)
                    {
                        txt_p9.Text = productname[8];

                    }
                    if (x == 10)
                    {
                        txt_p10.Text = productname[9];

                    }



                }
                

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    {
                        if (txt_p1.Text != "")
                        {
                            product product1 = content.products.First(i => i.ProductName == txt_p1.Text);
                            if (product1 != null)
                            {
                                txt_p1.Text = product1.ProductID.ToString();

                            }
                        }
                        else
                        {
                            txt_p1.Text = "0";
                        }
                    }
                    {
                        if (txt_p2.Text != "")
                        {
                            product product2 = content.products.First(i => i.ProductName == txt_p2.Text);
                            if (product2 != null)
                            {
                                txt_p2.Text = product2.ProductID.ToString();

                            }
                        }
                        else
                        {
                            txt_p2.Text = "0";
                        }
                    }
                    {
                        if (txt_p3.Text != "")
                        {
                            product product3 = content.products.First(i => i.ProductName == txt_p3.Text);
                            if (product3 != null)
                            {
                                txt_p3.Text = product3.ProductID.ToString();

                            }
                        }
                        else
                        {
                            txt_p3.Text = "0";
                        }
                    }
                    {
                        if (txt_p4.Text != "")
                        {
                            product product4 = content.products.First(i => i.ProductName == txt_p4.Text);
                            if (product4 != null)
                            {
                                txt_p4.Text = product4.ProductID.ToString();

                            }
                        }
                        else
                        {
                            txt_p4.Text = "0";
                        }
                    }


                    {
                        if (txt_p5.Text != "")
                        {
                            product product5 = content.products.First(i => i.ProductName == txt_p5.Text);
                            if (product5 != null)
                            {
                                txt_p5.Text = product5.ProductID.ToString();

                            }
                        }
                        else
                        {
                            txt_p5.Text = "0";
                        }
                    }
                    {
                        if (txt_p6.Text != "")
                        {
                            product product6 = content.products.First(i => i.ProductName == txt_p6.Text);
                            if (product6 != null)
                            {
                                txt_p6.Text = product6.ProductID.ToString();

                            }
                        }
                        else
                        {
                            txt_p6.Text = "0";
                        }
                    }
                    {
                        if (txt_p7.Text != "")
                        {
                            product product7 = content.products.First(i => i.ProductName == txt_p7.Text);
                            if (product7 != null)
                            {
                                txt_p7.Text = product7.ProductID.ToString();

                            }
                        }
                        else
                        {
                            txt_p7.Text = "0";
                        }
                    }
                    {
                        if (txt_p8.Text != "")
                        {
                            product product8 = content.products.First(i => i.ProductName == txt_p8.Text);
                            if (product8 != null)
                            {
                                txt_p8.Text = product8.ProductID.ToString();

                            }
                        }
                        else
                        {
                            txt_p8.Text = "0";
                        }
                    }
                    {
                        if (txt_p9.Text != "")
                        {
                            product product9 = content.products.First(i => i.ProductName == txt_p9.Text);
                            if (product9 != null)
                            {
                                txt_p9.Text = product9.ProductID.ToString();

                            }
                        }
                        else
                        {
                            txt_p9.Text = "0";
                        }
                    }
                    {
                        if (txt_p9.Text == "0")
                        {
                            txt_p10.Text = "0";
                        }
                        else if (txt_p10.Text != "")
                        {
                            product product10 = content.products.First(i => i.ProductName == txt_p10.Text);
                            if (product10 != null)
                            {
                                txt_p10.Text = product10.ProductID.ToString();

                            }
                        }
                        if (txt_p9.Text == txt_p10.Text)
                        {
                            txt_p10.Text = "0";
                        }
                    }




                    int reorderID_int = int.Parse(cmb_EditID.SelectedItem.ToString());
                    reorder reorders = content.reorders.First(i => i.ReorderID == reorderID_int);
                    if (reorders != null)
                    {
                        reorders.Product1 = int.Parse(txt_p1.Text);
                        reorders.Product2 = int.Parse(txt_p2.Text);
                        reorders.Product3 = int.Parse(txt_p3.Text);
                        reorders.Product4 = int.Parse(txt_p4.Text);
                        reorders.Product5 = int.Parse(txt_p5.Text);
                        reorders.Product6 = int.Parse(txt_p6.Text);
                        reorders.Product7 = int.Parse(txt_p7.Text);
                        reorders.Product8 = int.Parse(txt_p8.Text);
                        reorders.Product9 = int.Parse(txt_p9.Text);
                        reorders.Product10 = int.Parse(txt_p10.Text);
                        reorders.ReorderCreatedDate = DateTime.Now;



                    }
                    content.SaveChanges();
                    MessageBox.Show(reorders.ReorderID + "  Is Saved  ");
                    dataGridView1.Rows.Clear();


                    string status = "Waiting Approve";
                    {

                        var emp = (from list in content.reorders
                                   where list.Approve == status
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            product product1 = content.products.First(i => i.ProductID == emp2.Product1);
                            product product2 = content.products.First(i => i.ProductID == emp2.Product2);
                            product product3 = content.products.First(i => i.ProductID == emp2.Product3);
                            product product4 = content.products.First(i => i.ProductID == emp2.Product4);
                            product product5 = content.products.First(i => i.ProductID == emp2.Product5);
                            product product6 = content.products.First(i => i.ProductID == emp2.Product6);
                            product product7 = content.products.First(i => i.ProductID == emp2.Product7);
                            product product8 = content.products.First(i => i.ProductID == emp2.Product8);
                            product product9 = content.products.First(i => i.ProductID == emp2.Product9);
                            product product10 = content.products.First(i => i.ProductID == emp2.Product10);

                            if (product1 != null && product2 != null && product3 != null && product4 != null && product5 != null && product6 != null && product7 != null && product8 != null
                                && product9 != null && product10 != null)
                            {

                                dataGridView1.Rows.Add(emp2.ReorderCreatedDate, emp2.ReorderID, emp2.Approve, product1.ProductName, product2.ProductName, product3.ProductName, product4.ProductName,
                                    product5.ProductName, product6.ProductName, product7.ProductName, product8.ProductName, product9.ProductName, product10.ProductName);
                            }
                        }
                    }
                }
            }







            catch (FormatException) { MessageBox.Show("Please Check If There Has The Same Items Please Remove It"); }
            catch (InvalidExpressionException) { MessageBox.Show("The Reorder Can Not Be Zero Item.If You Want To Delete The Reorder List." + "\n" + " Choose Cancel Reorder Instead."); }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p4remove.Checked)
            {
                cb_p4.Items.Clear();
                cb_p4.Enabled = false;

            }
            else
            {

                cb_p4.Enabled = true;
                add2product4();
            }
        }

        private void checkBox_p1remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p1remove.Checked)
            {
                cb_p1.Items.Clear();
                cb_p1.Enabled = false;

            }
            else {

                cb_p1.Enabled = true;
                add2product1();
            }
        }

        private void checkBox_p2remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p2remove.Checked)
            {
                cb_p2.Items.Clear();
                cb_p2.Enabled = false;

            }
            else
            {

                cb_p2.Enabled = true;
                add2product2();
            }
        }

        private void radioButton_supplier_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_p3remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p3remove.Checked)
            {
                cb_p3.Items.Clear();
                cb_p3.Enabled = false;

            }
            else
            {

                cb_p3.Enabled = true;
                add2product3();
            }
        }

        private void checkBox_p5remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p5remove.Checked)
            {
                cb_p5.Items.Clear();
                cb_p5.Enabled = false;

            }
            else
            {

                cb_p5.Enabled = true;
                add2product5();
            }
        

    }

        private void checkBox_p6remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p6remove.Checked)
            {
                cb_p6.Items.Clear();
                cb_p6.Enabled = false;

            }
            else
            {

                cb_p6.Enabled = true;
                add2product6();
            }
        }

        private void checkBox_p7remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p7remove.Checked)
            {
                cb_p7.Items.Clear();
                cb_p7.Enabled = false;

            }
            else
            {

                cb_p7.Enabled = true;
                add2product7();
            }
        }

        private void checkBox_p8remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p8remove.Checked)
            {
                cb_p8.Items.Clear();
                cb_p8.Enabled = false;

            }
            else
            {

                cb_p8.Enabled = true;
                add2product8();
            }
        }

        private void checkBox_p9remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p9remove.Checked)
            {
                cb_p9.Items.Clear();
                cb_p9.Enabled = false;

            }
            else
            {

                cb_p9.Enabled = true;
                add2product9();
            }
        }

        private void checkBox_p10remove_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_p10remove.Checked)
            {
                cb_p10.Items.Clear();
                cb_p10.Enabled = false;

            }
            else
            {

                cb_p10.Enabled = true;
                add2product10();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //   private void btn_edit_Click(object sender, EventArgs e)
        //  {

        //    }

        // private void groupBox1_Enter(object sender, EventArgs e)
        //  {

        // }

        // private void radioBtn_typeandSupplier_CheckedChanged(object sender, EventArgs e)
        //  {

        // }
    }
}

