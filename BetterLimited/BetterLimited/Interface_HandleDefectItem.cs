using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class Interface_HandleDefectItem : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");

        public Interface_HandleDefectItem()
        {
            InitializeComponent();
        }
        void add2Store()
        {
            string command_query = "SELECT StoreName FROM betterlimited.store WHERE StoreID!=0 ";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            //try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("StoreName");
                    cb_storeName.Items.Add(subj);

                }
                Conn.Close();


            }
            //catch (Exception)
            {
                //MessageBox.Show("Store Error");

            }

        }


        private void defectItemApply_Load(object sender, EventArgs e)
        {
            Interface_CreateSaleOrder s = new Interface_CreateSaleOrder();
            s.Show();
            cb_productName.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_handle.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_saleorder.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_storeName.DropDownStyle = ComboBoxStyle.DropDownList;
            add2Store();

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Rows.Clear();
                cb_saleorder.Items.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {

                    DateTime dateod = DateTime.Parse(monthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd"));

                    string storename = cb_storeName.SelectedItem.ToString();
                    store stores = content.stores.First(i => i.StoreName == storename);
                    if (stores != null)
                    {
                        int storeid = stores.StoreID;
                        int price = int.Parse(txt_price.Text);

                        {


                            var emp = (from list in content.saleorders
                                       where list.storeID == storeid && list.TotalCharge == price && list.Date_Of_Purchase == dateod
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                store stores1 = content.stores.First(i => i.StoreID == emp2.storeID);
                                if (stores1 != null)
                                {

                                    dataGridView1.Rows.Add(emp2.orderID, emp2.Date_Of_Purchase, stores1.StoreName, emp2.TotalCharge);
                                }
                            }
                        }



                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {
                    cb_saleorder.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                }
                if (dataGridView1.RowCount == 0) {
                    MessageBox.Show("No Result");
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Fill In All The Boxes"); }
        }

        private void btn_SelectSaleorder_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.Rows.Clear();
                cb_productName.Items.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {
                    int storeID = int.Parse(cb_saleorder.SelectedItem.ToString());
                    {
                        var emp = (from list in content.saleorders
                                   where list.orderID == storeID
                                   select list);
                        foreach (var emp2 in emp.ToList())
                        {
                            product product1s = content.products.First(i => i.ProductID == emp2.Product1_ID);
                            product product2s = content.products.First(i => i.ProductID == emp2.Product2_ID);
                            product product3s = content.products.First(i => i.ProductID == emp2.Product3_ID);
                            product product4s = content.products.First(i => i.ProductID == emp2.Product4_ID);
                            product product5s = content.products.First(i => i.ProductID == emp2.Product5_ID);
                            product product6s = content.products.First(i => i.ProductID == emp2.Product6_ID);
                            product product7s = content.products.First(i => i.ProductID == emp2.Product7_ID);
                            product product8s = content.products.First(i => i.ProductID == emp2.Product8_ID);
                            product product9s = content.products.First(i => i.ProductID == emp2.Product9_ID);
                            product product10s = content.products.First(i => i.ProductID == emp2.Product10_ID);
                            if (product1s != null && product2s != null && product3s != null && product4s != null && product5s != null && product6s != null
                                && product7s != null && product8s != null && product9s != null && product10s != null)
                            {
                                if (emp2.Product1_ID != 0)
                                {

                                    dataGridView2.Rows.Add(product1s.ProductID, product1s.ProductName, emp2.Product1_Qty);

                                }
                                if (emp2.Product2_ID != 0)
                                {

                                    dataGridView2.Rows.Add(product2s.ProductID, product2s.ProductName, emp2.Product2_Qty);

                                }
                                if (emp2.Product3_ID != 0)
                                {

                                    dataGridView2.Rows.Add(product3s.ProductID, product3s.ProductName, emp2.Product3_Qty);

                                }
                                if (emp2.Product4_ID != 0)
                                {

                                    dataGridView2.Rows.Add(product4s.ProductID, product4s.ProductName, emp2.Product4_Qty);

                                }
                            }
                            if (emp2.Product5_ID != 0)
                            {
                                {

                                    dataGridView2.Rows.Add(product5s.ProductID, product5s.ProductName, emp2.Product5_Qty);

                                }
                            }
                            if (emp2.Product6_ID != 0)
                            {
                                {

                                    dataGridView2.Rows.Add(product6s.ProductID, product6s.ProductName, emp2.Product6_Qty);

                                }
                            }
                            if (emp2.Product7_ID != 0)
                            {
                                {

                                    dataGridView2.Rows.Add(product7s.ProductID, product7s.ProductName, emp2.Product7_Qty);

                                }
                            }
                            if (emp2.Product8_ID != 0)
                            {
                                {

                                    dataGridView2.Rows.Add(product8s.ProductID, product8s.ProductName, emp2.Product8_Qty);

                                }
                            }
                            if (emp2.Product9_ID != 0)
                            {
                                {

                                    dataGridView2.Rows.Add(product9s.ProductID, product9s.ProductName, emp2.Product9_Qty);

                                }
                            }
                            if (emp2.Product10_ID != 0)
                            {
                                {

                                    dataGridView2.Rows.Add(product10s.ProductID, product10s.ProductName, emp2.Product10_Qty);

                                }

                            }
                        }
                    }

                }
                for (int x = 0; x < dataGridView2.RowCount; x++)
                {
                    cb_productName.Items.Add(dataGridView2.Rows[x].Cells[1].Value.ToString());
                }
            }
            catch (System.FormatException) { MessageBox.Show("Please Fill In All The Require Information"); }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Sale Order ID To View The Product"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int saleorderid = int.Parse(cb_saleorder.SelectedItem.ToString());
                int storeID = int.Parse(cb_saleorder.SelectedItem.ToString());
                if (MessageBox.Show("The Defect Record Will Be Saved And There Is No Chance For Editing", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
               
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {


                    
                        if (cb_handle.SelectedItem.ToString() == "Refund")
                        {

                            string productname = cb_productName.SelectedItem.ToString();
                            product products = content.products.First(i => i.ProductName == productname);
                            if (products != null)
                            {
                                int productID_int = products.ProductID;
                                var emp = (from list in content.soldproducts
                                           where list.SaleorderID == saleorderid && list.productID == productID_int
                                           select list);
                                foreach (var emp2 in emp.ToList())
                                {
                                    dataGridView3.Rows.Add(emp2.productID, emp2.SaleorderID, emp2.ProductPrePrice);
                                }
                                double refundprice = double.Parse(dataGridView3.Rows[0].Cells[2].Value.ToString()) * int.Parse(numericUpDown_quanitiy.Value.ToString());
                                txt_refundprice.Text = refundprice.ToString();
                                defectitem defectitems = new defectitem
                                {
                                    SaleOrderID = int.Parse(cb_saleorder.SelectedItem.ToString()),
                                    ProductID = productID_int,
                                    dateofreturn = DateTime.Now,
                                    Reason = txt_reason.Text,
                                    HandleMethod = "Refund",
                                    Quantity = int.Parse(numericUpDown_quanitiy.Value.ToString()),
                                    RefundAmount = refundprice,
                                    Handle = "Waiting For The Next Step"




                                };

                                content.defectitems.Add(defectitems);
                                content.SaveChanges();
                                MessageBox.Show("Refund Successful");



                                saleorder saleorder1 = content.saleorders.First(i => i.orderID == saleorderid);
                                if (saleorder1 != null)
                                {
                                    if (saleorder1.Product1_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product1_ID = 0;
                                        saleorder1.Product1_Qty = 0;
                                        saleorder1.Product1_display = 0;

                                    }
                                    if (saleorder1.Product2_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product2_ID = 0;
                                        saleorder1.Product2_Qty = 0;
                                        saleorder1.Product2_display = 0;

                                    }
                                    if (saleorder1.Product3_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product3_ID = 0;
                                        saleorder1.Product3_Qty = 0;
                                        saleorder1.Product3_display = 0;

                                    }
                                    if (saleorder1.Product4_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product4_ID = 0;
                                        saleorder1.Product4_Qty = 0;
                                        saleorder1.Product4_display = 0;

                                    }
                                    if (saleorder1.Product5_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product5_ID = 0;
                                        saleorder1.Product5_Qty = 0;
                                        saleorder1.Product5_display = 0;

                                    }
                                    if (saleorder1.Product6_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product6_ID = 0;
                                        saleorder1.Product6_Qty = 0;
                                        saleorder1.Product6_display = 0;

                                    }
                                    if (saleorder1.Product7_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product7_ID = 0;
                                        saleorder1.Product7_Qty = 0;
                                        saleorder1.Product7_display = 0;

                                    }
                                    if (saleorder1.Product8_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product8_ID = 0;
                                        saleorder1.Product8_Qty = 0;
                                        saleorder1.Product8_display = 0;

                                    }
                                    if (saleorder1.Product9_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product9_ID = 0;
                                        saleorder1.Product9_Qty = 0;
                                        saleorder1.Product9_display = 0;

                                    }
                                    if (saleorder1.Product10_ID == productID_int)
                                    {
                                        saleorder1.TotalCharge = saleorder1.TotalCharge - refundprice;
                                        saleorder1.Product10_ID = 0;
                                        saleorder1.Product10_Qty = 0;
                                        saleorder1.Product10_display = 0;

                                    }
                                }







                                content.SaveChanges();





                            }

                        }
                        else if (cb_handle.SelectedItem.ToString() == "Exchange")
                        {
                            string productname = cb_productName.SelectedItem.ToString();
                            product products = content.products.First(i => i.ProductName == productname);
                            if (products != null)
                            {
                                int productID_int = products.ProductID;


                                defectitem defectitems = new defectitem
                                {
                                    SaleOrderID = int.Parse(cb_saleorder.SelectedItem.ToString()),
                                    ProductID = productID_int,
                                    dateofreturn = DateTime.Now,
                                    Reason = txt_reason.Text,
                                    HandleMethod = "Exchange",
                                    Quantity = int.Parse(numericUpDown_quanitiy.Value.ToString())






                                };

                                content.defectitems.Add(defectitems);
                                content.SaveChanges();

                                int sorderID = int.Parse(cb_saleorder.SelectedItem.ToString());
                                saleorder saleorders = content.saleorders.First(i => i.orderID == sorderID);
                                if (saleorders != null)
                                {



                                    if (saleorders.storeID == 1)
                                    {
                                        string productname1 = cb_productName.SelectedItem.ToString();
                                        product products1 = content.products.First(i => i.ProductName == productname1);
                                        if (products1 != null)
                                        {
                                            products1.StockLevel = products1.StockLevel - int.Parse(numericUpDown_quanitiy.Value.ToString());
                                            products1.KBStore = products1.KBStore - int.Parse(numericUpDown_quanitiy.Value.ToString());


                                        }
                                        content.SaveChanges();

                                    }
                                }
                                else if (saleorders.storeID == 2)
                                {
                                    string productname1 = cb_productName.SelectedItem.ToString();
                                    product products1 = content.products.First(i => i.ProductName == productname1);
                                    if (products1 != null)
                                    {
                                        products1.StockLevel = products1.StockLevel - int.Parse(numericUpDown_quanitiy.Value.ToString());
                                        products1.TWStore = products1.TWStore - int.Parse(numericUpDown_quanitiy.Value.ToString());


                                    }
                                    content.SaveChanges();




                                }
                            }

                        }
                    }
                }
                MessageBox.Show("The Defect Item Record Created");

            }
            catch (NullReferenceException) { MessageBox.Show("Please Fill All The Require Information For The Defect Record."); }

         
        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
    


