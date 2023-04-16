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
    public partial class Interface_ViewSellingProduct : Form
    {
        public static Interface_ViewSellingProduct instance;
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Label lab1;
        public Interface_ViewSellingProduct()
        {
            InitializeComponent();
            instance = this;
            
        }
        void mySubjects()
        {
            string command_query = "SELECT DISTINCT productID FROM betterlimited.soldproduct";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("productID");
                    comboBox1.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("Staff");

            }

        }
   
     
    

        private void btn_search_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime a = DateTime.Parse(dayFrom.SelectionRange.Start.ToString("yyyy-MM-dd"));
                DateTime b = DateTime.Parse(dayTo.SelectionRange.Start.ToString("yyyy-MM-dd"));
                lab_TWtotal.Visible = true;
                label6.Visible = true;
                label8.Visible = true;
                label7.Visible = true;
                lab_todayquantity.Visible = true;
                lab_amount.Visible = true;
                using (var content = new betterlimitedEntities_Test1())
                {


                    dataGridView1.Rows.Clear();
                    DateTime c = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    var emp = (from list in content.saleorders
                               where list.Date_Of_Purchase >= a && list.Date_Of_Purchase <= b
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        dataGridView1.Rows.Add(emp2.orderID, emp2.TotalCharge);
                    }

                }
                using (var content = new betterlimitedEntities_Test1())
                {
                    int countp = 0;
                    int pnum = 0;
                    double total = 0;
                    string productnameq = cb_pname.SelectedItem.ToString();
                    product p = content.products.First(i => i.ProductName == productnameq);
                    if (p != null)
                    {
                        pnum = p.ProductID;



                        dataGridView3.Rows.Clear();
                        for (int x = 0; x < dataGridView1.RowCount; x++)
                        {
                            int saleorder = int.Parse(dataGridView1.Rows[x].Cells[0].Value.ToString());
                            DateTime c = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                            var emp = (from list in content.soldproducts
                                       where list.SaleorderID == saleorder

                                       select list);
                            foreach (var emp2 in emp.ToList())
                            {
                                dataGridView3.Rows.Add(emp2.productID, emp2.Quantity, emp2.TotalAmount);
                            }
                        }
                        for (int x = 0; x < dataGridView3.RowCount; x++)
                        {
                            if (int.Parse(dataGridView3.Rows[x].Cells[0].Value.ToString()) == pnum)
                            {
                                countp += int.Parse(dataGridView3.Rows[x].Cells[1].Value.ToString());
                                total += double.Parse(dataGridView3.Rows[x].Cells[2].Value.ToString());
                            }
                        }
                        lab_todayquantity.Text = countp.ToString() + "Pieces";

                        lab_amount.Text = "$" + total.ToString();


                    }
                }


                using (var content = new betterlimitedEntities_Test1())
                {
                    dataGridView1.Rows.Clear();

                    dataGridView1.Rows.Clear();
                    DateTime c = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    var emp = (from list in content.saleorders
                               where list.storeID == 1 && list.Date_Of_Purchase >= a && list.Date_Of_Purchase <= b
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        dataGridView1.Rows.Add(emp2.orderID, emp2.TotalCharge);
                    }

                }
                using (var content = new betterlimitedEntities_Test1())
                {
                    int countp = 0;
                    int pnum = 0;
                    double total = 0;
                    string productnameq = cb_pname.SelectedItem.ToString();
                    product p = content.products.First(i => i.ProductName == productnameq);
                    if (p != null)
                    {
                        pnum = p.ProductID;



                        dataGridView3.Rows.Clear();
                        for (int x = 0; x < dataGridView1.RowCount; x++)
                        {
                            int saleorder = int.Parse(dataGridView1.Rows[x].Cells[0].Value.ToString());
                            DateTime c = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                            var emp = (from list in content.soldproducts
                                       where list.SaleorderID == saleorder

                                       select list);
                            foreach (var emp2 in emp.ToList())
                            {
                                dataGridView3.Rows.Add(emp2.productID, emp2.Quantity, emp2.TotalAmount);
                            }
                        }
                        for (int x = 0; x < dataGridView3.RowCount; x++)
                        {
                            if (int.Parse(dataGridView3.Rows[x].Cells[0].Value.ToString()) == pnum)
                            {
                                countp += int.Parse(dataGridView3.Rows[x].Cells[1].Value.ToString());
                                total += double.Parse(dataGridView3.Rows[x].Cells[2].Value.ToString());
                            }
                        }
                        label6.Text = countp.ToString() + "Pieces";

                        label8.Text = "$" + total.ToString();


                    }
                }
                using (var content = new betterlimitedEntities_Test1())
                {
                    dataGridView1.Rows.Clear();

                    dataGridView1.Rows.Clear();

                    DateTime c = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                    var emp = (from list in content.saleorders
                               where list.storeID == 2 && list.Date_Of_Purchase >= a && list.Date_Of_Purchase <= b
                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        dataGridView1.Rows.Add(emp2.orderID, emp2.TotalCharge);
                    }


                }
                using (var content = new betterlimitedEntities_Test1())
                {
                    int countp = 0;
                    int pnum = 0;
                    double total = 0;
                    string productnameq = cb_pname.SelectedItem.ToString();
                    product p = content.products.First(i => i.ProductName == productnameq);
                    if (p != null)
                    {
                        pnum = p.ProductID;



                        dataGridView3.Rows.Clear();
                        for (int x = 0; x < dataGridView1.RowCount; x++)
                        {
                            int saleorder = int.Parse(dataGridView1.Rows[x].Cells[0].Value.ToString());
                            DateTime c = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"));
                            var emp = (from list in content.soldproducts
                                       where list.SaleorderID == saleorder

                                       select list);
                            foreach (var emp2 in emp.ToList())
                            {
                                dataGridView3.Rows.Add(emp2.productID, emp2.Quantity, emp2.TotalAmount);
                            }
                        }
                        for (int x = 0; x < dataGridView3.RowCount; x++)
                        {
                            if (int.Parse(dataGridView3.Rows[x].Cells[0].Value.ToString()) == pnum)
                            {
                                countp += int.Parse(dataGridView3.Rows[x].Cells[1].Value.ToString());
                                total += double.Parse(dataGridView3.Rows[x].Cells[2].Value.ToString());
                            }
                        }
                        label7.Text = countp.ToString() + "Pieces";

                        lab_TWtotal.Text = "$" + total.ToString();


                    }
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Product First"); }


        }

        private void dataGridView_item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void Interface_ViewSellingProduct_Load(object sender, EventArgs e)
        {

            int year = DateTime.Now.Year;
            DateTime firstDay = new DateTime(year, 1, 1);
            DateTime lastDay = new DateTime(year, 12, 31);
           // dayFrom.MinDate = DateTime.Now;
            dayFrom.MaxDate = lastDay;
            dayTo.MinDate = DateTime.Now;
            dayTo.MaxDate = lastDay;
            using (var content = new betterlimitedEntities_Test1())
            {
                mySubjects();
                for (int x = 0; x < comboBox1.Items.Count; x++)
                {
                    int productid = int.Parse(comboBox1.Items[x].ToString());
                    product p = content.products.First(i => i.ProductID == productid);
                    if (p != null)
                    {
                        cb_pname.Items.Add(p.ProductName);
                    }
                }
            }




            }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

    

