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
    public partial class Interface_ViewInstallationOrder : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public static Interface_ViewInstallationOrder instance;
        public Label lab1;
        public Interface_ViewInstallationOrder()
        {
            InitializeComponent();
            instance = this;
            lab1 = label1;
        }
        void mySubjects()
        {
            string command_query = "SELECT InstallationOrderID FROM betterlimited.installationorder";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("InstallationOrderID");
                    cb_OrderID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("InstallationOrder");

            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Interface_ViewInstallationOrder_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            mySubjects();
            DateTime lastDay = new DateTime(year, 12, 31);
            dayFrom.MinDate = DateTime.Now;
            dayFrom.MaxDate = lastDay;
            dayTo.MinDate = DateTime.Now;
            dayTo.MaxDate = lastDay;
            using (var content = new betterlimitedEntities_Test1())
            {
                {

                    var emp = (from list in content.installationorders
                               where list.InstallationDate>= DateTime.Now
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {


                        dataGridView1.Rows.Add(emp2.InstallationOrderID, emp2.InstallationDate);

                    }
                    lab_CountNum.Text = dataGridView1.Rows.Count.ToString();
                }


            }
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            try
            {
                Interface_UpdateInstallationStatus i = new Interface_UpdateInstallationStatus();
                Interface_UpdateInstallationStatus.instance.lab1.Text = cb_OrderID.SelectedItem.ToString();
                i.Show();
                this.Hide();
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Installation Order First"); }
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
                if (a > b)
                {
                    throw new FormatException();
                }
                else if (checkBox_Today.Checked && checkBox_mydeliveryOrder.Checked)
                {
                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {


                            int staffid = int.Parse(label1.Text);
                            var emp = (from list in content.installationorders
                                       where list.InstallationDate == c && list.I_Worker == staffid
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {



                                dataGridView1.Rows.Add(emp2.InstallationOrderID, emp2.InstallationDate);

                            }
                            lab_CountNum.Text = dataGridView1.Rows.Count.ToString();
                        }



                    }



                }
                else if (checkBox_Today.Checked)
                {
                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {



                            var emp = (from list in content.installationorders
                                       where list.InstallationDate == c
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {



                                dataGridView1.Rows.Add(emp2.InstallationOrderID, emp2.InstallationDate);

                            }
                            lab_CountNum.Text = dataGridView1.Rows.Count.ToString();
                        }




                    }



                }

                else if (checkBox_mydeliveryOrder.Checked && a == b)
                {
                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {



                            var emp = (from list in content.installationorders
                                       where list.InstallationDate == a && list.I_Worker == int.Parse(label1.Text)
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {



                                dataGridView1.Rows.Add(emp2.InstallationOrderID, emp2.InstallationDate);

                            }
                            lab_CountNum.Text = dataGridView1.Rows.Count.ToString();
                        }



                    }
                }

                else if (checkBox_mydeliveryOrder.Checked && a < b)
                {




                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {



                            var emp = (from list in content.installationorders
                                       where list.InstallationDate >= a && list.InstallationDate <= b && list.I_Worker == int.Parse(label1.Text)
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {



                                dataGridView1.Rows.Add(emp2.InstallationOrderID, emp2.InstallationDate);

                            }
                            lab_CountNum.Text = dataGridView1.Rows.Count.ToString();
                        }



                    }

                }
                else if (a == b)
                {
                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {



                            var emp = (from list in content.installationorders
                                       where list.InstallationDate == a
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {



                                dataGridView1.Rows.Add(emp2.InstallationOrderID, emp2.InstallationDate);

                            }
                            lab_CountNum.Text = dataGridView1.Rows.Count.ToString();
                        }



                    }


                }
            }
            catch (FormatException) { MessageBox.Show("The Date Of Start Can Not Larger Than The End Date"); }
        }

        private void cb_OrderID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_productname.Items.Clear();
            lb_qty.Items.Clear();
            dataGridView_item.Rows.Clear();
            try
            {
          
                int orderID = int.Parse(cb_OrderID.SelectedItem.ToString());
                using (var content = new betterlimitedEntities_Test1())
                {
                    var emp = (from list in content.installationorders
                               where list.InstallationOrderID == orderID
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {

                        if (emp2.InstallProduct1 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct1);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct1, emp2.InstallProduct1_qty);

                            }
                        }
                        if (emp2.InstallProduct2 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct2);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct2, emp2.InstallProduct2_qty);

                            }
                        }
                        if (emp2.InstallProduct3 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct3);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct3, emp2.InstallProduct3_qty);

                            }
                        }
                        if (emp2.InstallProduct4 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct4);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct4, emp2.InstallProduct4_qty);

                            }
                        }
                        if (emp2.InstallProduct5 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct5);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct5, emp2.InstallProduct5_qty);

                            }
                        }
                        if (emp2.InstallProduct6 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct6);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct6, emp2.InstallProduct6_qty);

                            }
                        }
                        if (emp2.InstallProduct7 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct7);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct7, emp2.InstallProduct7_qty);

                            }
                        }
                        if (emp2.InstallProduct8 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct8);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct8, emp2.InstallProduct8_qty);

                            }
                        }
                        if (emp2.InstallProduct9 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct9);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct9, emp2.InstallProduct9_qty);

                            }
                        }
                        if (emp2.InstallProduct10 != 0)
                        {
                            product products1 = content.products.First(i => i.ProductID == emp2.InstallProduct10);
                            if (products1 != null)
                            {
                                dataGridView_item.Rows.Add(emp2.InstallProduct10, emp2.InstallProduct10_qty);

                            }
                        }

                    }
               

                    int dorderID = 0;
                    saleorder s = content.saleorders.First(i => i.InstallationOrderID == orderID);
                    if (s != null)
                    {
                        dorderID = int.Parse(s.DeliveryOrderID.ToString());

                    }
                    deliveryorder a = content.deliveryorders.First(i => i.DeliveryOrderID == dorderID);
                    if (a != null)
                    {
                        txt_deliverystatus.Text = a.D_Status;

                    }
                    customer c = content.customers.First(i => i.CustomerID == s.CustomerID);
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
                for (int x = 0; x < dataGridView_item.RowCount; x++)
                {
                    int pid = int.Parse(dataGridView_item.Rows[x].Cells[0].Value.ToString());
                    product products1 = content.products.First(i => i.ProductID == pid);
                    if (products1 != null)
                    {
                        lb_productname.Items.Add(products1.ProductName);
                    }

                    lb_qty.Items.Add(dataGridView_item.Rows[x].Cells[1].Value.ToString());


                }

            }
           }
            catch (System.InvalidOperationException) { MessageBox.Show("This Installation Order Do Not Contain Any Delivery Order."); }
        }
    }
    }

