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
    public partial class Interface_CreateReorder : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public Interface_CreateReorder()
        {


            InitializeComponent();



        }

        private void btn_add2reorder_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < lb_DproductID.Items.Count; x++)
                {
                    int productID1 = int.Parse(cb_productID.SelectedItem.ToString());

                    if (int.Parse(lb_DproductID.Items[x].ToString()) == productID1)
                    {
                        throw new FormatException();
                    }
                }
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int productID1 = int.Parse(cb_productID.SelectedItem.ToString());
                    cb_productID.Items.Remove(productID1);
                    cb_remove.Items.Add(productID1);
                    product p1 = content.products.First(i => i.ProductID == productID1);

                    lb_DeliverItems.Items.Add(p1.ProductName);
                    lb_stocklevel.Items.Add(p1.StockLevel);
                    lb_DproductID.Items.Add(p1.ProductID);

                }
                if (cb_productID.Items.Count == 0)
                {
                    cb_productID.Text = "";

                }


            }
            catch (FormatException) { MessageBox.Show("This Product Already Existed In Reorder List"); }
            catch (System.NullReferenceException) { MessageBox.Show("This is Not Allow Blank"); }









        }

        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {



        }

        private void btn_additem_Click(object sender, EventArgs e)
        { }








        private void lb_reorderlist_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lb_DproductID.Items.Count < 1)
                {
                    throw new IndexOutOfRangeException();
                }
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    string[] productname = new string[10];

                    for (int x = 0; x < lb_DproductID.Items.Count; x++)
                    {
                        productname[x] = lb_DproductID.Items[x].ToString();


                    }
                    for (int x = 0; x < 10; x++)
                    {
                        if (productname[x] == null)
                        {
                            productname[x] = "0";

                        }

                    }
                    for (int x = 0; x < 10; x++)
                    {
                        if (productname[x] != "0")
                        {
                            int productID = int.Parse(productname[x]);
                            product products = content.products.First(i => i.ProductID == productID);
                            if (products != null)
                            {
                                products.Reorder = 1;



                            }
                            content.SaveChanges();
                        }
                    }





                    reorder reorders = new reorder()
                    {
                        Product1 = int.Parse(productname[0]),
                        Product2 = int.Parse(productname[1]),
                        Product3 = int.Parse(productname[2]),
                        Product4 = int.Parse(productname[3]),
                        Product5 = int.Parse(productname[4]),
                        Product6 = int.Parse(productname[5]),
                        Product7 = int.Parse(productname[6]),
                        Product8 = int.Parse(productname[7]),
                        Product9 = int.Parse(productname[8]),
                        Product10 = int.Parse(productname[9]),
                        Approve = "Waiting Approve",
                        ReorderCreatedDate = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd"))


                    };
                    content.reorders.Add(reorders);
                    content.SaveChanges();
                    MessageBox.Show("Create Reorder And Send To Purchase");










                }
            }
            catch (IndexOutOfRangeException) { MessageBox.Show("The Reorder List Can Not Be Empty"); }
        }


        private void lb_searchresult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_ProductID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CreateReorder_Load(object sender, EventArgs e)
        {
            cb_productID.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_remove.DropDownStyle = ComboBoxStyle.DropDownList;
            using (var content = new betterlimitedEntities_Test1())
            { 

                dataGridView1.Rows.Clear();
                cb_productID.Items.Clear();


                var emp = (from list in content.products
                           where list.StockLevel<=list.Low_Standard && list.Reorder == 0
                           select list);
                foreach (var emp2 in emp.ToList())
                {
                    dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.StockLevel);
                }
                }
            for (int x = 0; x < dataGridView1.RowCount; x++)
            {
                cb_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
            }
            }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Reset", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lb_DeliverItems.Items.Clear();
                    lb_DproductID.Items.Clear();
                    lb_stocklevel.Items.Clear();
                    cb_productID.Items.Clear();
                    cb_remove.Items.Clear();
               
                }

            }




        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {

                    string productID1 = cb_remove.SelectedItem.ToString();
                    cb_remove.Items.Remove(productID1);
                    cb_productID.Items.Add(productID1);
                    cb_remove.Text = null;

                    product p1 = content.products.First(i => i.ProductName == productID1);
                    txt_productID1.Text = p1.ProductID.ToString();
                    int productID_int = int.Parse(txt_productID1.Text);
                }
                if (lb_DproductID.Items.Count == 1)
                {
                    if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[0].ToString()))
                    {
                        lb_DproductID.Items.Remove(lb_DproductID.Items[0]);
                        lb_stocklevel.Items.Remove(lb_stocklevel.Items[0]);
                        lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[0]);
                    }
                }
                if (lb_DproductID.Items.Count == 2)
                {
                    for (int x = 1; x >= 0; x--)
                    {
                        if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[x].ToString()))
                        {
                            lb_DproductID.Items.Remove(lb_DproductID.Items[x]);
                            lb_stocklevel.Items.Remove(lb_stocklevel.Items[x]);
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x]);
                        }
                    }
                }
                if (lb_DproductID.Items.Count == 3)
                {
                    for (int x = 2; x >= 0; x--)
                    {
                        if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[x].ToString()))
                        {
                            lb_DproductID.Items.Remove(lb_DproductID.Items[x]);
                            lb_stocklevel.Items.Remove(lb_stocklevel.Items[x]);
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x]);
                        }
                    }
                }
                if (lb_DproductID.Items.Count == 4)
                {
                    for (int x = 3; x >= 0; x--)
                    {
                        if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[x].ToString()))
                        {
                            lb_DproductID.Items.Remove(lb_DproductID.Items[x]);
                            lb_stocklevel.Items.Remove(lb_stocklevel.Items[x]);
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x]);
                        }
                    }
                }
                if (lb_DproductID.Items.Count == 5)
                {
                    for (int x = 4; x >= 0; x--)
                    {
                        if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[x].ToString()))
                        {
                            lb_DproductID.Items.Remove(lb_DproductID.Items[x]);
                            lb_stocklevel.Items.Remove(lb_stocklevel.Items[x]);
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x]);
                        }
                    }
                }
                if (lb_DproductID.Items.Count == 6)
                {
                    for (int x = 5; x >= 0; x--)
                    {
                        if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[x].ToString()))
                        {
                            lb_DproductID.Items.Remove(lb_DproductID.Items[x]);
                            lb_stocklevel.Items.Remove(lb_stocklevel.Items[x]);
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x]);
                        }
                    }
                }
                if (lb_DproductID.Items.Count == 7)
                {
                    for (int x = 6; x >= 0; x--)
                    {
                        if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[x].ToString()))
                        {
                            lb_DproductID.Items.Remove(lb_DproductID.Items[x]);
                            lb_stocklevel.Items.Remove(lb_stocklevel.Items[x]);
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x]);
                        }
                    }
                }
                if (lb_DproductID.Items.Count == 8)
                {
                    for (int x = 7; x >= 0; x--)
                    {
                        if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[x].ToString()))
                        {
                            lb_DproductID.Items.Remove(lb_DproductID.Items[x]);
                            lb_stocklevel.Items.Remove(lb_stocklevel.Items[x]);
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x]);
                        }
                    }
                }
                if (lb_DproductID.Items.Count == 9)
                {
                    for (int x = 8; x >= 0; x--)
                    {
                        if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[x].ToString()))
                        {
                            lb_DproductID.Items.Remove(lb_DproductID.Items[x]);
                            lb_stocklevel.Items.Remove(lb_stocklevel.Items[x]);
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x]);
                        }
                    }
                }
                if (lb_DproductID.Items.Count == 10)
                {
                    for (int x = 9; x >= 0; x--)
                    {
                        if (int.Parse(txt_productID1.Text) == int.Parse(lb_DproductID.Items[x].ToString()))
                        {
                            lb_DproductID.Items.Remove(lb_DproductID.Items[x]);
                            lb_stocklevel.Items.Remove(lb_stocklevel.Items[x]);
                            lb_DeliverItems.Items.Remove(lb_DeliverItems.Items[x]);
                        }
                    }
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("The Remove Product Name Should Not Be Blanked"); }
        }

        private void lb_sproductID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {

                dataGridView1.Rows.Clear();
                cb_productID.Items.Clear();


                var emp = (from list in content.products
                           where list.StockLevel == 0 && list.Available == 0 && list.Reorder == 0
                           select list);
                foreach (var emp2 in emp.ToList())
                {
                    dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.StockLevel);
                }
            }
            for (int x = 0; x < dataGridView1.RowCount; x++)
            {
                cb_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
            }



        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {

                dataGridView1.Rows.Clear();
                cb_productID.Items.Clear();


                var emp = (from list in content.products
                           where list.StockLevel <=list.Low_Standard && list.Reorder == 0
                           select list);
                foreach (var emp2 in emp.ToList())
                {
                    dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.StockLevel);
                }
            }
            for (int x = 0; x < dataGridView1.RowCount; x++)
            {
                cb_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cb_listbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_productID1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                   
                    Interface_Login login = new Interface_Login();
                    login.Show();
                    this.Hide();
                }
                else { }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}















