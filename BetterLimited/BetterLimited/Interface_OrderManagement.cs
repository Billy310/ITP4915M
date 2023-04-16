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
    public partial class Interface_OrderManagement : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public static string CtoP, CheckCtoP;
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public static Interface_OrderManagement instance;
        public TextBox tb1;
        public Interface_OrderManagement()
        {
            InitializeComponent();
            instance = this;
            tb1 = txt_leftpayment;
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
        void Store()
        {
            string command_query = "SELECT DISTINCT StoreName FROM betterlimited.store WHERE Available=1 && StoreID != 0";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("StoreName");
                    cmb_store.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ProductID available Error");

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

        void KBStore()
        {
            string command_query = "SELECT DISTINCT OrderID FROM betterlimited.saleorder WHERE StoreID = 1";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("OrderID");
                    cb_editorder.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ProductID available Error");

            }
        }
        void TWStore()
        {
            string command_query = "SELECT DISTINCT OrderID FROM betterlimited.saleorder WHERE StoreID = 2";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("OrderID");
                    cb_editorder.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ProductID available Error");

            }
        }

        private void EditSaleOrder_Load(object sender, EventArgs e)
        {
            Interface_CreateSaleOrder c = new Interface_CreateSaleOrder();
            c.Show();
            cb_productsell.DropDownStyle = ComboBoxStyle.DropDownList;
            txt_add.Enabled = false;
            cmb_proNum.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_sellingproductID.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_pID.DropDownStyle = ComboBoxStyle.DropDownList;

            txt_SupplierID.Enabled = false;
            txt_type.Enabled = false;
            mySubjects();
            add2ComboboxType();
            cmb_store.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_editorder.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_Type.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_supplier.DropDownStyle = ComboBoxStyle.DropDownList;
   
   
            txt_add.Enabled = false;
            txt_ProductID.Enabled = false;
            txt_Prodnum.Enabled = false;
            count.Hide();
            Store();
      
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                cmb_proNum.Items.Clear();
                cb_pID.Items.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {
                    string ordertype = "";
                    int saleorderID = int.Parse(cb_editorder.SelectedItem.ToString());
                    saleorder sa = content.saleorders.First(i => i.orderID == saleorderID);
                    if (sa != null) {
                        ordertype = sa.orderType;


                    }
                        dataGridView1.Rows.Clear();
                    cmb_proNum.Items.Clear();



                    if (cmb_store.SelectedItem.ToString() == "Kowloon Bay Store" && ordertype == "Sale Order")
                    {
                        
                            if (radioButtonSupplier.Checked)
                            {
                                string suppliername = combobox_supplier.SelectedItem.ToString();
                                supplier s = content.suppliers.First(i => i.SupplierName == suppliername);
                                if (s != null)
                                {
                                    var emp = (from list in content.products
                                               where list.ProductID != 0 && list.SupplierID == s.SupplierID && list.Available == 1 && list.KBStore > 0
                                               select list);

                                    foreach (var emp2 in emp.ToList())
                                    {
                                        if (emp2.Available == 0)
                                        {
                                            dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.Price, emp2.KBStore, emp2.KBdisplay, "Inavailable");
                                        }
                                        if (emp2.Available == 1)
                                        {
                                            dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.Price, emp2.KBStore, emp2.KBdisplay, "Available");
                                        }
                                    }
                                }
                            }
                            else if (radioButtontype.Checked) {
                                string typename = combobox_Type.SelectedItem.ToString();
                                type t = content.types.First(i => i.TypeName == typename);
                                if (t != null)
                                {
                                    var emp = (from list in content.products
                                               where list.ProductID != 0 && list.TypeID == t.TypeID && list.Available == 1 && list.KBStore > 0
                                               select list);

                                    foreach (var emp2 in emp.ToList())
                                    {
                                        if (emp2.Available == 0)
                                        {
                                            dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.Price, emp2.KBStore, emp2.KBdisplay, "Inavailable");
                                        }
                                        if (emp2.Available == 1)
                                        {
                                            dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.Price, emp2.KBStore, emp2.KBdisplay, "Available");
                                        }
                                    }
                                }
                            }
                            else if (radioButtonST.Checked) {
                                string suppliername = combobox_supplier.SelectedItem.ToString();
                                supplier s = content.suppliers.First(i => i.SupplierName == suppliername);
                                string typename = combobox_Type.SelectedItem.ToString();
                                type t = content.types.First(i => i.TypeName == typename);
                                if (t != null&&s!=null)
                                {
                                    var emp = (from list in content.products
                                               where list.ProductID != 0 && list.TypeID == t.TypeID && list.Available == 1 && list.KBStore > 0 && list.SupplierID == s.SupplierID
                                               select list);

                                    foreach (var emp2 in emp.ToList())
                                    {
                                        if (emp2.Available == 0)
                                        {
                                            dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.Price, emp2.KBStore, emp2.KBdisplay, "Inavailable");
                                        }
                                        if (emp2.Available == 1)
                                        {
                                            dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.Price, emp2.KBStore, emp2.KBdisplay, "Available");
                                        }
                                    }
                                }
                        }
                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++) {
                    cmb_proNum.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                    cb_pID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                }
                if (dataGridView1.RowCount == 0) {
                    MessageBox.Show("There is No Result");
                }
                   
            }
            catch (NullReferenceException) { MessageBox.Show("Please Select The Sale Order ID First"); }
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

        private void cmb_Phone_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Ordsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cb_editorder.Items.Clear();
                DateTime a = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));
                using (var content = new betterlimitedEntities_Test1())
                {
                    double total = double.Parse(txt_total.Text);

                    dataGridView_orderlist.Rows.Clear();
                    if (cmb_store.SelectedItem.ToString() == "Kowloon Bay Store")
                    {
                        string ordertype = "";
                        if (radioButton_s.Checked)
                        {
                            ordertype = "Sale Order";
                        }
                        if (radioButton_d.Checked)
                        {
                            ordertype = "Deposit Order";
                        }

                        var emp = (from list in content.saleorders
                                   where list.storeID == 1 && list.Date_Of_Purchase == a && list.orderType == ordertype && list.Active == "Active" && list.TotalCharge == total
                                   select list);
                        foreach (var emp2 in emp.ToList())
                        {
                            dataGridView_orderlist.Rows.Add(emp2.Date_Of_Purchase, emp2.orderID, emp2.orderType, emp2.TotalCharge);
                        }
                    }
                    else if (cmb_store.Text == "Tsuen Wan Store")
                    {
                        string ordertype = "";
                        if (radioButton_s.Checked)
                        {
                            ordertype = "Sale Order";
                        }
                        if (radioButton_d.Checked)
                        {
                            ordertype = "Deposit Order";
                        }

                        var emp = (from list in content.saleorders
                                   where list.storeID == 2 && list.Date_Of_Purchase == a && list.orderType == ordertype && list.Active == "Active" && list.TotalCharge == total
                                   select list);
                        foreach (var emp2 in emp.ToList())
                        {
                            dataGridView_orderlist.Rows.Add(emp2.Date_Of_Purchase, emp2.orderID, emp2.orderType, emp2.TotalCharge);
                        }
                    }

                }
                if (dataGridView_orderlist.RowCount < 1)
                {
                    MessageBox.Show("Sorry, There is No Result For Fulfill Requirement Of the Order");
                }
                for (int x = 0; x < dataGridView_orderlist.RowCount; x++)
                {
                    cb_editorder.Items.Add(dataGridView_orderlist.Rows[x].Cells[1].Value.ToString());

                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Fill In All The Require Information Including Date Of Purchase,Order Type, The Total Charge Of The Order And Place Of Purchase"); }
            catch (System.FormatException) { MessageBox.Show("Please Fill In All The Require Information Including Date Of Purchase,Order Type, The Total Charge Of The Order And Place Of Purchase"); }
            }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("The Order Will Disabled And You Never Can Make It To Be Enabled", "Are You Sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (cb_editorder.Text != "")
                {
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {
                        saleorder id = content.saleorders.First(i => i.orderID.ToString() == cb_editorder.Text);
                        if (id != null)
                        {
                            id.Active = "InActive";
                        }
                        content.SaveChanges();
                        dataGridView_orderlist.Rows.Clear();
                        MessageBox.Show("The Order Is Disabled");
                    }
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_solditem.Rows.Clear();
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int saleorderID = int.Parse(cb_editorder.SelectedItem.ToString());
                    int sellingid = int.Parse(cb_sellingproductID.SelectedItem.ToString());
                    int newproductID = int.Parse(cb_pID.SelectedItem.ToString());
                    saleorder saleorders = content.saleorders.First(i => i.orderID == saleorderID);
                    double oldtotal = 0;
                    if (saleorders != null)
                    {
                        oldtotal = saleorders.TotalCharge;


                    }

                    int originalpid = int.Parse(cb_originalpID.Text);
                    soldproduct sorder1 = content.soldproducts.First(i => i.soldproductid == sellingid && i.productID == originalpid);
                    double newtotal = 0;
                    if (sorder1 != null)
                    {
                        newtotal = oldtotal - sorder1.TotalAmount;


                    }

                    product p = content.products.First(i => i.ProductID == newproductID);
                    int displayed = 0;
                    if (cb_displaynew.Checked)
                    {
                        displayed = 1;
                    }

                    double total = 0;
                    if (p != null)
                    {
                        if (displayed == 0)
                        {
                            total = p.Price * int.Parse(numericUpDown_orderqty.Value.ToString());
                        }
                        if (displayed == 1)
                        {
                            total = p.Price * int.Parse(numericUpDown_orderqty.Value.ToString()) * 0.7;
                        }
                        newtotal += total;
                        saleorder saleorders1 = content.saleorders.First(i => i.orderID == saleorderID);
                        if (saleorders1 != null)
                        {
                            saleorders1.TotalCharge = newtotal;

                        };
                        content.SaveChanges();


                        soldproduct sorder = content.soldproducts.First(i => i.soldproductid == sellingid);
                        if (sorder != null)
                        {
                            sorder.productID = int.Parse(cb_pID.SelectedItem.ToString());
                            sorder.Quantity = int.Parse(numericUpDown_orderqty.Value.ToString());
                            sorder.ProductPrePrice = int.Parse(p.Price.ToString());
                            sorder.Displayed = displayed;
                            sorder.TotalAmount = total;



                        };
                        content.SaveChanges();

                    }
                    var emp = (from list in content.soldproducts
                               where list.SaleorderID == saleorderID && list.Able == "Enable"
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        product p1 = content.products.First(i => i.ProductID == emp2.productID);
                        if (p1 != null)
                        {
                            if (emp2.Displayed == 0)
                            {
                                dataGridView_solditem.Rows.Add(emp2.soldproductid, emp2.productID, p1.ProductName, emp2.Quantity, emp2.ProductPrePrice, emp2.TotalAmount, "New Item");
                            }
                            if (emp2.Displayed == 1)
                            {
                                dataGridView_solditem.Rows.Add(emp2.soldproductid, emp2.productID, p1.ProductName, emp2.Quantity, emp2.ProductPrePrice, emp2.TotalAmount, "Displayed Item");
                            }
                        }
                    }
                }
                MessageBox.Show("The Selling Product Is Edited");
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Order Number First"); }

        }

        private void cmb_proNum_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {


            }
         
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                saleorder oid = content.saleorders.First(i => i.orderID.ToString() == cb_editorder.Text);
                double s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 = 0;

                product o1 = content.products.First(i => i.ProductID == oid.Product1_ID);
                string p1 = oid.Product1_Qty.ToString();
                string d1 = oid.Product1_display.ToString();
                if (oid.Product1_display.ToString() == "1")
                {
                    s1 = o1.Price * 0.7 * int.Parse(p1);
                }
                else
                {
                    s1 = o1.Price * int.Parse(p1);
                }


                product o2 = content.products.First(i => i.ProductID == oid.Product2_ID);
                string p2 = oid.Product2_Qty.ToString();
                string d2 = oid.Product2_display.ToString();
                if (oid.Product2_display.ToString() == "1")
                {
                    s2 = o2.Price * 0.7 * int.Parse(p2);
                }
                else
                {
                    s2 = o2.Price * int.Parse(p2);
                }

                product o3 = content.products.First(i => i.ProductID == oid.Product3_ID);
                string p3 = oid.Product3_Qty.ToString();
                string d3 = oid.Product3_display.ToString();
                if (oid.Product3_display.ToString() == "1")
                {
                    s3 = o3.Price * 0.7 * int.Parse(p3);
                }
                else
                {
                    s3 = o3.Price * int.Parse(p3);
                }

                product o4 = content.products.First(i => i.ProductID == oid.Product4_ID);
                string p4 = oid.Product4_Qty.ToString();
                string d4 = oid.Product4_display.ToString();
                if (oid.Product4_display.ToString() == "1")
                {
                    s4 = o4.Price * 0.7 * int.Parse(p4);
                }
                else
                {
                    s4 = o4.Price * int.Parse(p4);
                }

                product o5 = content.products.First(i => i.ProductID == oid.Product5_ID);
                string p5 = oid.Product5_Qty.ToString();
                string d5 = oid.Product5_display.ToString();
                if (oid.Product5_display.ToString() == "1")
                {
                    s5 = o5.Price * int.Parse(p5);
                }
                else
                {
                    s5 = o5.Price * int.Parse(p5);
                }

                product o6 = content.products.First(i => i.ProductID == oid.Product6_ID);
                string p6 = oid.Product6_Qty.ToString();
                string d6 = oid.Product6_display.ToString();
                if (oid.Product6_display.ToString() == "1")
                {
                    s6 = o6.Price * 0.7 * int.Parse(p6);
                }
                else
                {
                    s6 = o6.Price * int.Parse(p6);
                }

                product o7 = content.products.First(i => i.ProductID == oid.Product7_ID);
                string p7 = oid.Product7_Qty.ToString();
                string d7 = oid.Product7_display.ToString();
                if (oid.Product7_display.ToString() == "1")
                {
                    s7 = o7.Price * 0.7 * int.Parse(p7);
                }
                else
                {
                    s7 = o7.Price * int.Parse(p7);
                }

                product o8 = content.products.First(i => i.ProductID == oid.Product8_ID);
                string p8 = oid.Product8_Qty.ToString();
                string d8 = oid.Product8_display.ToString();
                if (oid.Product8_display.ToString() == "1")
                {
                    s8 = o8.Price * 0.7 * int.Parse(p8);
                }
                else
                {
                    s8 = o8.Price * int.Parse(p8);
                }

                product o9 = content.products.First(i => i.ProductID == oid.Product9_ID);
                string p9 = oid.Product9_Qty.ToString();
                string d9 = oid.Product9_display.ToString();
                if (oid.Product9_display.ToString() == "1")
                {
                    s9 = o9.Price * 0.7 * int.Parse(p9);
                }
                else
                {
                    s9 = o9.Price * int.Parse(p9);
                }

                product o10 = content.products.First(i => i.ProductID == oid.Product10_ID);
                string p10 = oid.Product10_Qty.ToString();
                string d10 = oid.Product10_display.ToString();
                if (oid.Product10_display.ToString() == "1")
                {
                    s10 = o10.Price * 0.7 * int.Parse(p10);
                }
                else
                {
                    s10 = o10.Price * int.Parse(p10);
                }

                double total = 0;
                double cal = 0;
                if (oid.Addition_Charge != 0)
                {
                    total = double.Parse(oid.TotalCharge.ToString()) + double.Parse(oid.Addition_Charge.ToString());
                }
                else
                {
                    total = double.Parse(oid.TotalCharge.ToString());
                }
                cal = total * 0.2;

                double change = 0;
                if (oid.orderType == "Deposit Order")
                {
                    change = double.Parse(oid.PayAmount.ToString()) - cal;
                }
                else
                {
                    change = double.Parse(oid.PayAmount.ToString()) - total;
                }
                RTB_view.Clear();
                RTB_view.Text += "******************************************\n";
                RTB_view.Text += "              Better Limited              \n";
                if (oid.orderType == "Deposit Order")
                {
                    RTB_view.Text += "           --DEPOSIT--RECEIPT--           \n";
                }
                else
                {
                    RTB_view.Text += "           --PAYMENT--RECEIPT--           \n";
                }
                RTB_view.Text += "******************************************\n";
                RTB_view.Text += "OrderID " + oid.orderID.ToString().PadRight(10) + "     " + oid.Date_Of_Purchase.ToString("MM/dd/yyyy HH:mm:ss").PadLeft(8) + "\n\n";
                RTB_view.Text += "Product                  Qty   DIS   Price\n";
                RTB_view.Text += "------------------------------------------\n";
                RTB_view.Text += o1.ProductName.PadRight(25) + p1.PadLeft(3) + d1.PadLeft(6) + s1.ToString().PadLeft(8) + "\n";
                if (o2.ProductName != "")
                    RTB_view.Text += o2.ProductName.PadRight(25) + p2.PadLeft(3) + d2.PadLeft(6) + s2.ToString().PadLeft(8) + "\n";
                if (o3.ProductName != "")
                    RTB_view.Text += o3.ProductName.PadRight(25) + p3.PadLeft(3) + d3.PadLeft(6) + s3.ToString().PadLeft(8) + "\n";
                if (o4.ProductName != "")
                    RTB_view.Text += o4.ProductName.PadRight(25) + p4.PadLeft(3) + d4.PadLeft(6) + s4.ToString().PadLeft(8) + "\n";
                if (o5.ProductName != "")
                    RTB_view.Text += o5.ProductName.PadRight(25) + p5.PadLeft(3) + d5.PadLeft(6) + s5.ToString().PadLeft(8) + "\n";
                if (o6.ProductName != "")
                    RTB_view.Text += o6.ProductName.PadRight(25) + p6.PadLeft(3) + d6.PadLeft(6) + s6.ToString().PadLeft(8) + "\n";
                if (o7.ProductName != "")
                    RTB_view.Text += o7.ProductName.PadRight(25) + p7.PadLeft(3) + d7.PadLeft(6) + s7.ToString().PadLeft(8) + "\n";
                if (o8.ProductName != "")
                    RTB_view.Text += o8.ProductName.PadRight(25) + p8.PadLeft(3) + d8.PadLeft(6) + s8.ToString().PadLeft(8) + "\n";
                if (o9.ProductName != "")
                    RTB_view.Text += o9.ProductName.PadRight(25) + p9.PadLeft(3) + d9.PadLeft(6) + s9.ToString().PadLeft(8) + "\n";
                if (o10.ProductName != "")
                    RTB_view.Text += o10.ProductName.PadRight(25) + p10.PadLeft(3) + d10.PadLeft(6) + s10.ToString().PadLeft(8) + "\n";
                RTB_view.Text += "------------------------------------------\n";
                if (oid.Addition_Charge > 0)
                {
                    RTB_view.Text += "Addition_Charge" + oid.Addition_Charge.ToString().PadLeft(27) + "\n";
                }
                if (oid.orderType == "Deposit Order")
                {
                    RTB_view.Text += "ToTal Deposit" + cal.ToString().PadLeft(29) + "\n";
                }
                else
                {
                    RTB_view.Text += "ToTal" + total.ToString().PadLeft(37) + "\n";
                }
                RTB_view.Text += oid.PayMethod.PadRight(35) + oid.PayAmount.ToString().PadLeft(7) + "\n";
                RTB_view.Text += "Change" + change.ToString().PadLeft(36) + "\n";
                RTB_view.Text += "------------------------------------------\n";
                RTB_view.Text += "                THANK YOU!                \n";



            }
        }

        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmb_EditID_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cb_editorder.Text != "")
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    saleorder id = content.saleorders.First(i => i.orderID.ToString() == cb_editorder.Text);
                    id.Active = "Active";
                    content.SaveChanges();

                    if (cmb_store.Text == "Kowloon Bay Store")
                    {
                        dataGridView_orderlist.Rows.Clear();


                        var emp = (from list in content.saleorders
                                   where list.storeID == 1
                                   select list);
                        foreach (var emp2 in emp.ToList())
                        {


                            dataGridView_orderlist.Rows.Add(emp2.Date_Of_Purchase, emp2.orderID, emp2.orderType, emp2.staffID, emp2.Addition_Charge, emp2.TotalCharge, emp2.Active);

                        }
                    }
                    else if (cmb_store.Text == "Tsuen Wan Store")
                    {
                        dataGridView_orderlist.Rows.Clear();


                        var emp = (from list in content.saleorders
                                   where list.storeID == 2
                                   select list);
                        foreach (var emp2 in emp.ToList())
                        {


                            dataGridView_orderlist.Rows.Add(emp2.Date_Of_Purchase, emp2.orderID, emp2.orderType, emp2.staffID, emp2.Addition_Charge, emp2.TotalCharge, emp2.Active);

                        }
                    }
                    MessageBox.Show("Updated");
                }
            }
        }

        private void cmb_store_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txt_Prodnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_getproduct_Click(object sender, EventArgs e)
        {
            try
            {
                cb_productsell.Items.Clear();
                dataGridView_solditem.Rows.Clear();
                cmb_proNum.Items.Clear();
                cb_sellingproductID.Items.Clear();
                string ordertype = "";
                using (var content = new betterlimitedEntities_Test1())
                {
                    int saleorderID = int.Parse(cb_editorder.SelectedItem.ToString());
                    var emp = (from list in content.soldproducts
                               where list.SaleorderID == saleorderID && list.Able == "Enable"
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        product p = content.products.First(i => i.ProductID == emp2.productID);
                        if (emp2.Displayed == 0)
                        {
                            dataGridView_solditem.Rows.Add(emp2.soldproductid, emp2.productID, p.ProductName, emp2.Quantity, emp2.ProductPrePrice, emp2.TotalAmount, "New Item");
                        }
                        if (emp2.Displayed == 1)
                        {
                            dataGridView_solditem.Rows.Add(emp2.soldproductid, emp2.productID, p.ProductName, emp2.Quantity, emp2.ProductPrePrice, emp2.TotalAmount, "Displayed Item");
                        }
                    }
                    saleorder sale = content.saleorders.First(i => i.orderID == saleorderID);
                    if (sale != null)
                    {
                        ordertype = sale.orderType;
                        txt_updatetotal.Text = sale.TotalCharge.ToString();
                        txt_leftpayment.Text = (sale.TotalCharge - sale.DepositCharge).ToString();
                    }
                    if (ordertype == "Deposit Order")
                    {
                        btn_pay.Visible = true;
                        txt_leftpayment.Visible = true;
                        lab_left.Visible = true;

                    }


                }
                for (int x = 0; x < dataGridView_solditem.RowCount; x++)
                {
                    cb_productsell.Items.Add(dataGridView_solditem.Rows[x].Cells[1].Value.ToString());

                    cb_sellingproductID.Items.Add(dataGridView_solditem.Rows[x].Cells[0].Value.ToString());
                }
                if (dataGridView_solditem.RowCount == 0)
                {
                    MessageBox.Show("Please Disable The Sale Order. It does not Contain Any Product");

                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Order Number First."); }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {

                using (var content = new betterlimitedEntities_Test1())
                {
                    int saleorderid = int.Parse(cb_editorder.SelectedItem.ToString());
                    int productid = int.Parse(cb_productsell.SelectedItem.ToString());
                    soldproduct s = content.soldproducts.First(i => i.SaleorderID == saleorderid && i.productID == productid);
                    if (s != null)
                    {
                        s.Able = "Disabled";
                    }
                    content.SaveChanges();

                    dataGridView_solditem.Rows.Clear();
                    var emp = (from list in content.soldproducts
                               where list.SaleorderID == saleorderid && list.Able == "Enable"
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        product p = content.products.First(i => i.ProductID == emp2.productID);
                        if (emp2.Displayed == 0)
                        {
                            dataGridView_solditem.Rows.Add(emp2.soldproductid, emp2.productID, p.ProductName, emp2.Quantity, emp2.ProductPrePrice, emp2.TotalAmount, "New Item");
                        }
                        if (emp2.Displayed == 1)
                        {
                            dataGridView_solditem.Rows.Add(emp2.soldproductid, emp2.productID, p.ProductName, emp2.Quantity, emp2.ProductPrePrice, emp2.TotalAmount, "Displayed Item");
                        }
                    }


                    double total = 0;
                    for (int x = 0; x < dataGridView_solditem.RowCount; x++)
                    {
                        total += double.Parse(dataGridView_solditem.Rows[x].Cells[5].Value.ToString());

                    }
                    MessageBox.Show(total.ToString());
                    saleorder sale = content.saleorders.First(i => i.orderID == saleorderid);

                    if (sale != null)
                    {
                        sale.TotalCharge = total;
                    }
                    content.SaveChanges();
                }
                MessageBox.Show("The Product Is Deleted");
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Order Number First"); }
            }



            
            

        private void cb_sellingproductID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                int sellingid = int.Parse(cb_sellingproductID.SelectedItem.ToString());
                soldproduct s = content.soldproducts.First(i => i.soldproductid == sellingid);
                if (s != null)
                {
                    cb_originalpID.Text = s.productID.ToString();
                    numericUpDown_oqty.Value = s.Quantity;
                    if (s.Displayed == 1) {
                        cb_displayold.Checked = true;
                    }
                }
              
            }
            }

        private void cb_originalpID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_productsell_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_add_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                saleorder id = content.saleorders.First(i => i.orderID.ToString() == cb_editorder.Text);
                if (id != null)
                {
                    id.orderType = "Deposit Payment";
                }
                content.SaveChanges();

            }
                Interface_Payment pay = new Interface_Payment();
            Interface_Payment.instance.lab1.Text = cb_editorder.SelectedItem.ToString();
            pay.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView_solditem.Rows.Clear();
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int saleorderID = int.Parse(cb_editorder.SelectedItem.ToString());
                    int productID = int.Parse(cmb_proNum.SelectedItem.ToString());
                    int quantity = int.Parse(numericUpDown_qty.Value.ToString());
                    int display = 0;
                    double totalprice = 0;
                    if (chb_display.Checked)
                    {
                        display = 1;
                    }
                    int priceofper = 0;
                    product p = content.products.First(i => i.ProductID == productID);
                    if (p != null)
                    {

                        priceofper = p.Price;
                    }
                    if (display == 0)
                    {
                        totalprice = (double)priceofper * quantity;
                    }
                    if (display == 1)
                    {
                        totalprice = (double)priceofper * quantity * 0.7;
                    }

                    txt_add.Text = totalprice.ToString();
                    saleorder id = content.saleorders.First(i => i.orderID.ToString() == cb_editorder.Text);
                    if (id != null)
                    {
                        id.Addition_Charge = double.Parse(txt_add.Text);
                        id.orderType = "New Item Order";
                        id.TotalCharge += totalprice;
                        txt_updatetotal.Text = id.TotalCharge.ToString();
                    }
                    content.SaveChanges();
                    soldproduct sol = new soldproduct
                    {
                        ProductPrePrice = priceofper,
                        SaleorderID = saleorderID,
                        productID = productID,
                        Quantity = quantity,
                        Displayed = display,
                        TotalAmount = totalprice,
                        Able = "Enable"
                    };

                    content.soldproducts.Add(sol);
                    content.SaveChanges();
                    Interface_Payment pay = new Interface_Payment();
                    Interface_Payment.instance.lab1.Text = cb_editorder.SelectedItem.ToString();
                    pay.Show();



                    dataGridView_solditem.Rows.Clear();

                    var emp = (from list in content.soldproducts
                               where list.SaleorderID == saleorderID && list.Able == "Enable"
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        product p1 = content.products.First(i => i.ProductID == emp2.productID);
                        if (emp2.Displayed == 0)
                        {
                            dataGridView_solditem.Rows.Add(emp2.soldproductid, emp2.productID, p1.ProductName, emp2.Quantity, emp2.ProductPrePrice, emp2.TotalAmount, "New Item");
                        }
                        if (emp2.Displayed == 1)
                        {
                            dataGridView_solditem.Rows.Add(emp2.soldproductid, emp2.productID, p1.ProductName, emp2.Quantity, emp2.ProductPrePrice, emp2.TotalAmount, "Displayed Item");
                        }
                    }

                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Order Number First"); }

            
        }
    }
}
