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

    public partial class Interface_ViewDeliveryOrder : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public static Interface_ViewDeliveryOrder instance;
        public Label lab1;
        public Interface_ViewDeliveryOrder()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
            //cb_OrderID
        }
     

        

        private void ViewDeliveryOrder_Load(object sender, EventArgs e)
        {
            txt_cname.Enabled = false;
            txt_building.Enabled = false;
            txt_city.Enabled = false;
            txt_cname.Enabled = false;
            txt_cnum.Enabled = false;
            txt_phone2.Enabled = false;
            txt_Region.Enabled = false;
            txt_street.Enabled = false;
            
            checkBox_mydeliveryOrder.Visible = false;
            using (var content1 = new betterlimitedEntities_Test1())
            {
                label1.Text = "10";
                int staffID = int.Parse(label1.Text);
                staff s = content1.staffs.First(i => i.StaffID == staffID);
                if (s != null)
                {
                    int dID = int.Parse(s.DepartmentID.ToString());
                    if (dID == 11)
                    {
                        checkBox_mydeliveryOrder.Visible = true;

                    }
                }
            }

 
            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);
            dayFrom.MinDate = DateTime.Now;
            dayFrom.MaxDate = lastDay;
            dayTo.MinDate = DateTime.Now;
            dayTo.MaxDate = lastDay;
            using (var content = new betterlimitedEntities_Test1())
            {
                {

                    var emp = (from list in content.deliveryorders
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {


                        dataGridView_order.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate, emp2.CustomerID);

                    }
                    lab_CountNum.Text = dataGridView_order.Rows.Count.ToString();
                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {




        }



        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime a = DateTime.Parse(dayFrom.SelectionRange.Start.ToString("yyyy-MM-dd"));
                DateTime b = DateTime.Parse(dayTo.SelectionRange.Start.ToString("yyyy-MM-dd"));
                DateTime c = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                if (a == DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")) && b == DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd")))
                {
                    checkBox_Today.Checked = true;
                }
                if (checkBox_Today.Checked)
                {
                    dataGridView_order.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {



                            var emp = (from list in content.deliveryorders
                                       where list.DeliveryDate == c
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {


                                session s = content.sessions.First(i => i.Session1 == emp2.SessionID);
                                dataGridView_order.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate,emp2.timeofDelivery,s.SessionTime);

                            }
                            lab_CountNum.Text = dataGridView_order.Rows.Count.ToString();
                            
                        }
                        for (int x = 0; x < dataGridView_order.Rows.Count; x++) {
                            cb_OrderID.Items.Add(dataGridView_order.Rows[x].Cells[0].Value.ToString());


                        }




                    }



                }
                else if (checkBox_Today.Checked && checkBox_mydeliveryOrder.Checked)
                {
                    dataGridView_order.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {



                            var emp = (from list in content.deliveryorders
                                       where list.DeliveryDate == c && list.DWorkerID == int.Parse(label1.Text)
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {



                                dataGridView_order.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate);

                            }
                            lab_CountNum.Text = dataGridView_order.Rows.Count.ToString();
                        }



                    }



                }
                else if (a > b)
                {
                    throw new FormatException();
                }



                else if (checkBox_mydeliveryOrder.Checked && a == b)
                {
                    dataGridView_order.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        int dworker = int.Parse(label1.Text);
                        {



                            var emp = (from list in content.deliveryorders
                                       where list.DeliveryDate == a && list.DWorkerID == dworker
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {


                                dataGridView_order.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate);

                            }
                            lab_CountNum.Text = dataGridView_order.Rows.Count.ToString();
                        }



                    }
                }

                else if (checkBox_mydeliveryOrder.Checked && a < b)
                {




                    dataGridView_order.Rows.Clear();
                    int staffID=int.Parse(label1.Text);
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {



                            var emp = (from list in content.deliveryorders
                                       where list.DeliveryDate >= a && list.DeliveryDate <= b && list.DWorkerID == staffID
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {



                                dataGridView_order.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate);

                            }
                            lab_CountNum.Text = dataGridView_order.Rows.Count.ToString();
                        }



                    }

                }
                else if (a == b)
                {
                    dataGridView_order.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {



                            var emp = (from list in content.deliveryorders
                                       where list.DeliveryDate == a
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {



                                dataGridView_order.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate);

                            }
                            lab_CountNum.Text = dataGridView_order.Rows.Count.ToString();
                        }



                    }


                }
                else if (a < b)
                {
                    dataGridView_order.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {



                            var emp = (from list in content.deliveryorders
                                       where list.DeliveryDate >= a && list.DeliveryDate <= b
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {



                                dataGridView_order.Rows.Add(emp2.DeliveryOrderID, emp2.DeliveryDate);

                            }
                            lab_CountNum.Text = dataGridView_order.Rows.Count.ToString();
                        }



                    }




                }
            }
            catch (FormatException) { MessageBox.Show("The Date Of Start Can Not Larger Than The End Date"); }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox_Today_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Today.Checked)
            {
                dayFrom.Enabled = false;
                dayTo.Enabled = false;
            }
            else
            {
                dayFrom.Enabled = true;
                dayTo.Enabled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_OrderID.SelectedItem.ToString() == "")
                {
                    throw new MissingMethodException();
                }
                Interface_UpdateDeliveryOrderStatus i = new Interface_UpdateDeliveryOrderStatus();
                Interface_UpdateDeliveryOrderStatus.instance.lab1.Text = cb_OrderID.Text;
                i.Show();
                this.Hide();
            }
            catch (MissingMethodException) { MessageBox.Show("Please Select The Delivery ID First"); }
            catch (NullReferenceException) { MessageBox.Show("Please Select The Delivery ID First"); }

        }

        private void checkBox_mydeliveryOrder_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // this.Close();
                Interface_Login login = new Interface_Login();
                login.Show();
                this.Close();
            }
            else { }
        }

        private void dayFrom_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void cb_OrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int orderID = int.Parse(cb_OrderID.SelectedItem.ToString());
            using (var content = new betterlimitedEntities_Test1())
            {




                var emp = (from list in content.deliveryorders
                           where list.DeliveryOrderID == orderID
                           select list);



                foreach (var emp2 in emp.ToList())
                {

                    if (emp2.DeliveryProductID_1 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_1);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_1, emp2.DeliveryProductID_1qty);

                        }
                    }
                    if (emp2.DeliveryProductID_2 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_2);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_2, emp2.DeliveryProductID_2qty);

                        }
                    }
                    if (emp2.DeliveryProductID_3 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_3);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_3, emp2.DeliveryProductID_3qty);

                        }
                    }
                    if (emp2.DeliveryProductID_4 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_4);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_4, emp2.DeliveryProductID_4qty);

                        }
                    }
                    if (emp2.DeliveryProductID_5 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_5);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_5, emp2.DeliveryProductID_5qty);

                        }
                    }
                    if (emp2.DeliveryProductID_6 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_6);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_6, emp2.DeliveryProductID_6qty);

                        }
                    }
                    if (emp2.DeliveryProductID_7 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_7);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_7, emp2.DeliveryProductID_7qty);

                        }
                    }
                    if (emp2.DeliveryProductID_8 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_8);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_8, emp2.DeliveryProductID_8qty);

                        }
                    }
                    if (emp2.DeliveryProductID_9 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_9);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_9, emp2.DeliveryProductID_9qty);

                        }
                    }
                    if (emp2.DeliveryProductID_10 != 0)
                    {
                        product products1 = content.products.First(i => i.ProductID == emp2.DeliveryProductID_10);
                        if (products1 != null)
                        {
                            dataGridView_item.Rows.Add(emp2.DeliveryProductID_10, emp2.DeliveryProductID_10qty);

                        }
                    }

                }
                for (int x = 0; x < dataGridView_item.RowCount; x++)
                {
                    lb_productname.Items.Add(dataGridView_item.Rows[x].Cells[0].Value.ToString());
                    lb_qty.Items.Add(dataGridView_item.Rows[x].Cells[1].Value.ToString());


                }
                //orderID
               
                saleorder s = content.saleorders.First(i => i.DeliveryOrderID == orderID);
                customer c= content.customers.First(i => i.CustomerID == s.CustomerID);
                if (c != null)
                {
                    txt_cname.Text = c.ContactPersion;
                    txt_cnum.Text = c.Phone1;
                    txt_phone2.Text = c.Phone2;
                    txt_city.Text = c.AddressLine1;
                    txt_building.Text = c.AddressLine2;
                    txt_street.Text = c.AddressLine3;
                    txt_Region.Text = c.Region;
                    
                    
                }

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
    

