using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class Interface_CreatePurchaseOrder : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public Interface_CreatePurchaseOrder()
        {
            InitializeComponent();
        }
        void searchreorder()
        {
            //  try
            // {
            dataGridView1.Rows.Clear();
            DateTime a = DateTime.Parse(dayFrom.SelectionRange.Start.ToString("yyyy-MM-dd"));
            DateTime b = DateTime.Parse(dayTo.SelectionRange.Start.ToString("yyyy-MM-dd"));
            DateTime c = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

            using (var content = new betterlimitedEntities_Test1())
            {

                var emp = (from list in content.reorders
                           where list.ReorderCreatedDate >= a && list.ReorderCreatedDate <= b && list.Approve == "Approved"
                           select list);



                foreach (var emp2 in emp.ToList())
                {


                    dataGridView1.Rows.Add(emp2.ReorderCreatedDate, emp2.ReorderID, emp2.Approve);

                }



            }
            for (int x = 0; x < dataGridView1.RowCount; x++)
            {
                cb_OrderID.Items.Add(dataGridView1.Rows[x].Cells[1].Value.ToString());

            }


        }


        private void CreatePurchaseOrder_Load(object sender, EventArgs e)
        {
            lb_items.Enabled = false;
            lb_Qty.Enabled = false;
            cb_additem.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_OrderID.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

        }

        private void btn_Ordsearch_Click(object sender, EventArgs e)
        {
            cb_OrderID.Items.Clear();
            dataGridView1.Rows.Clear();
            DateTime a = DateTime.Parse(dayFrom.SelectionRange.Start.ToString("yyyy-MM-dd"));
            DateTime b = DateTime.Parse(dayTo.SelectionRange.Start.ToString("yyyy-MM-dd"));
            DateTime c = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));

            using (var content = new betterlimitedEntities_Test1())
            {

                var emp = (from list in content.reorders
                           where list.ReorderCreatedDate >= a && list.ReorderCreatedDate <= b && list.Approve == "Approve"
                           select list);



                foreach (var emp2 in emp.ToList())
                {


                    dataGridView1.Rows.Add(emp2.ReorderCreatedDate, emp2.ReorderID, emp2.Approve);

                }



            }
            for (int x = 0; x < dataGridView1.RowCount; x++)
            {
                cb_OrderID.Items.Add(dataGridView1.Rows[x].Cells[1].Value.ToString());

            }
        

        }

        private void btn_add2reorder_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    string OrderID = cb_OrderID.SelectedItem.ToString();
                    reorder p1 = content.reorders.First(i => i.ReorderID.ToString() == OrderID);
                    product name1 = content.products.First(i => i.ProductID == p1.Product1);
                    product name2 = content.products.First(i => i.ProductID == p1.Product2);
                    product name3 = content.products.First(i => i.ProductID == p1.Product3);
                    product name4 = content.products.First(i => i.ProductID == p1.Product4);
                    product name5 = content.products.First(i => i.ProductID == p1.Product5);
                    product name6 = content.products.First(i => i.ProductID == p1.Product6);
                    product name7 = content.products.First(i => i.ProductID == p1.Product7);
                    product name8 = content.products.First(i => i.ProductID == p1.Product8);
                    product name9 = content.products.First(i => i.ProductID == p1.Product9);
                    product name10 = content.products.First(i => i.ProductID == p1.Product10);
                    lb_items.Items.Add(name1.ProductName);
                    lb_items.Items.Add(name2.ProductName);
                    lb_items.Items.Add(name3.ProductName);
                    lb_items.Items.Add(name4.ProductName);
                    lb_items.Items.Add(name5.ProductName);
                    lb_items.Items.Add(name6.ProductName);
                    lb_items.Items.Add(name7.ProductName);
                    lb_items.Items.Add(name8.ProductName);
                    lb_items.Items.Add(name9.ProductName);
                    lb_items.Items.Add(name10.ProductName);
                    lb_Qty.Items.Add("");
                    lb_Qty.Items.Add("");
                    lb_Qty.Items.Add("");
                    lb_Qty.Items.Add("");
                    lb_Qty.Items.Add("");
                    lb_Qty.Items.Add("");
                    lb_Qty.Items.Add("");
                    lb_Qty.Items.Add("");
                    lb_Qty.Items.Add("");
                    lb_Qty.Items.Add("");

                }
                if (cb_OrderID.Items.Count == 0)
                {
                    cb_OrderID.Text = "0";

                }

            }
            catch (System.NullReferenceException) { MessageBox.Show("select error"); }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_OrderID.SelectedItem.ToString() != "")
                {
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {




                        purchasingorder order = new purchasingorder()
                        {
                            PurchaseOrderCreateDate = DateTime.Now,
                            StaffID = 1



                        };

                        content.purchasingorders.Add(order);
                        content.SaveChanges();
                        txt_purorderID.Text = order.purchasingorderID.ToString();

                        for (int x = 0; x < lb_items.Items.Count; x++)
                        {
                            string productname_str = lb_items.Items[x].ToString();
                            if (int.Parse(lb_Qty.Items[x].ToString()) != 0 && double.Parse(lb_Price.Items[x].ToString()) != 0.0)
                            {

                                product id = content.products.First(i => i.ProductName == productname_str);
                                int quantity = int.Parse(lb_Qty.Items[x].ToString());
                                double price = double.Parse(lb_Price.Items[x].ToString());
                                purchaseitem item = new purchaseitem()
                                {
                                    PurchaseOrderID = int.Parse(txt_purorderID.Text),
                                    ProductID = int.Parse(id.ProductID.ToString()),
                                    Quanity = int.Parse(lb_Qty.Items[x].ToString()),
                                    Price = double.Parse((price*quantity).ToString()),
                                    Status = "Waiting Approve"

                                };
                                content.purchaseitems.Add(item);
                                content.SaveChanges();
                            }
                            else if (int.Parse(lb_Qty.Items[x].ToString()) == 0 && double.Parse(lb_Price.Items[x].ToString()) != 0.0)
                            {
                                throw new InvalidOperationException();
                            }
                            else
                            {
                                product id = content.products.First(i => i.ProductName == productname_str);
                                if (id != null)
                                {
                                    id.Reorder = 2;


                                }
                                content.SaveChanges();


                            }




                        }
                        int reorderID = int.Parse(cb_OrderID.SelectedItem.ToString());
                        reorder reid = content.reorders.First(i => i.ReorderID == reorderID);
                        if (reid != null)
                        {
                          reid.Approve= "Processed";


                        }
                        content.SaveChanges();

                        MessageBox.Show("Create Purchase Order");
                        cb_additem.Items.Clear();
                        lb_items.Items.Clear();
                        lb_Qty.Items.Clear();
                        lb_Price.Items.Clear();
                        txt_sname.Clear();
                        txt_pnum.Clear();
                        txt_city.Clear();
                        txt_building.Clear();
                        txt_street.Clear();
                        txt_Region.Clear();
                        searchreorder();





                    }
                }

            }
            catch (InvalidOperationException) { MessageBox.Show("The Quantity Can Not Be Blank If The Price is Not Blank "); }
            catch (System.NullReferenceException) { MessageBox.Show("The Reorder Can Not Be Blank."); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_price.Text == "" && numericUpDown_item.Value != 0)
                {
                    throw new InvalidTimeZoneException();

                }
                if (txt_price.Text != "" && numericUpDown_item.Value == 0)
                {
                    throw new MissingFieldException();

                }
                for (int i = 0; i < lb_items.Items.Count; i++)
                {
                    if (cb_additem.SelectedItem.ToString() == lb_items.Items[i].ToString())
                    {
                        lb_Qty.Items[i] = numericUpDown_item.Value.ToString();
                        lb_Price.Items[i] = txt_price.Text;
                        numericUpDown_item.Value = 0;
                        txt_price.Clear();
                    }
                }
            }
            catch (InvalidTimeZoneException) { MessageBox.Show("The Price Is Missed"); }
            catch (MissingFieldException) { MessageBox.Show("The Quantity Is Missed"); }
        }

        private void cb_OrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MessageBox.Show("If You Change The Reorder List ID,All The Information Will Lose.", "Change Reorder List ID", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cb_additem.Items.Clear();
                lb_items.Items.Clear();
                lb_Qty.Items.Clear();
                lb_Price.Items.Clear();

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    string OrderID = cb_OrderID.SelectedItem.ToString();
                    reorder p1 = content.reorders.First(i => i.ReorderID.ToString() == OrderID);
                    product name1 = content.products.First(i => i.ProductID == p1.Product1);
                    product name2 = content.products.First(i => i.ProductID == p1.Product2);
                    product name3 = content.products.First(i => i.ProductID == p1.Product3);
                    product name4 = content.products.First(i => i.ProductID == p1.Product4);
                    product name5 = content.products.First(i => i.ProductID == p1.Product5);
                    product name6 = content.products.First(i => i.ProductID == p1.Product6);
                    product name7 = content.products.First(i => i.ProductID == p1.Product7);
                    product name8 = content.products.First(i => i.ProductID == p1.Product8);
                    product name9 = content.products.First(i => i.ProductID == p1.Product9);
                    product name10 = content.products.First(i => i.ProductID == p1.Product10);
                    if (name1.ProductName != "")
                    {
                        lb_items.Items.Add(name1.ProductName);
                    }
                    if (name2.ProductName != "")
                    {
                        lb_items.Items.Add(name2.ProductName);
                    }
                    if (name3.ProductName != "")
                    {
                        lb_items.Items.Add(name3.ProductName);
                    }
                    if (name4.ProductName != "")
                    {
                        lb_items.Items.Add(name4.ProductName);
                    }
                    if (name5.ProductName != "")
                    {
                        lb_items.Items.Add(name5.ProductName);
                    }
                    if (name6.ProductName != "")
                    {
                        lb_items.Items.Add(name6.ProductName);
                    }
                    if (name7.ProductName != "")
                    {
                        lb_items.Items.Add(name7.ProductName);
                    }
                    if (name8.ProductName != "")
                    {
                        lb_items.Items.Add(name8.ProductName);
                    }
                    if (name9.ProductName != "")
                    {
                        lb_items.Items.Add(name9.ProductName);
                    }
                    if (name10.ProductName != "")
                    {
                        lb_items.Items.Add(name10.ProductName);
                    }
                    string[] productlist = { name1.ProductName, name2.ProductName, name3.ProductName, name4.ProductName, name5.ProductName, name6.ProductName, name7.ProductName, name8.ProductName, name9.ProductName, name10.ProductName };
                    for (int x = 0; x < productlist.Length; x++)
                    {
                        if (productlist[x] != "")
                        {
                            cb_additem.Items.Add(productlist[x]);
                        }
                    }
                    for (int x = 0; x < lb_items.Items.Count; x++)
                    {
                        lb_Qty.Items.Add(0);
                        lb_Price.Items.Add(0);

                    }

                }


            }
        }




        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cmb_qty_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                string productName = cb_additem.SelectedItem.ToString();
                product supplier = content.products.First(i => i.ProductName == productName);
                supplier s = content.suppliers.First(i => i.SupplierID == supplier.SupplierID);
                if (s != null)
                {
                    txt_sname.Text = s.SupplierName;
                    txt_pnum.Text = s.PhoneNumber;
                    txt_city.Text = s.Address1;
                    txt_building.Text = s.Address2;
                    txt_street.Text = s.Address3;
                    txt_Region.Text = s.Region;


                }
            }
        }

        private void numericUpDown_item_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (cb_OrderID.Text == "")
                {
                    throw new InvalidExpressionException();
                }
                int reorderid = int.Parse(cb_OrderID.SelectedItem.ToString());
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {

                    reorder reorders = content.reorders.First(i => i.ReorderID == reorderid);
                    if (reorders != null)
                    {
                        reorders.Approve = "Returned";


                    }
                    content.SaveChanges();
                    lb_items.Items.Clear();
                    lb_Qty.Items.Clear();
                    cb_OrderID.Items.Clear();
                    cb_additem.Items.Clear();
                    searchreorder();
                   

                    MessageBox.Show("The Reorder List Is Returned");
                }
            }

            catch (InvalidExpressionException) { MessageBox.Show("The Reorder Can Not Be Blank."); }
    }
        }
}
