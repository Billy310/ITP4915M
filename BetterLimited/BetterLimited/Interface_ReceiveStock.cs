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
    public partial class Interface_ReceiveStock : Form
    {
        public Interface_ReceiveStock()
        {
            InitializeComponent();
        }

        void getProduct()

        {
            dataGridView1.Rows.Clear();
            using (var content = new betterlimitedEntities_Test1())
            {
            




                var emp = (from list in content.purchaseitems
                           where list.Status == "Finish"
                           select list);



                foreach (var emp2 in emp.ToList())
                {
                    product products = content.products.First(i => i.ProductID == emp2.ProductID);
                    if (products != null)
                    {
                        dataGridView1.Rows.Add(emp2.PurchaseOrderID, emp2.ProductID, products.ProductName, emp2.Quanity);

                    }

                }
            }
            for (int x = 0; x<dataGridView1.RowCount; x++)
            {
                combo_PurID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                combo_pID.Items.Add(dataGridView1.Rows[x].Cells[1].Value.ToString());
            }
            if (dataGridView1.RowCount == 0) {
                MessageBox.Show("There Is No Product Has Finished Purhcasing Step.");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void Interface_GetStock_Load(object sender, EventArgs e)
        {
            combo_PurID.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_pID.DropDownStyle = ComboBoxStyle.DropDownList;
            getProduct();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    if (combo_PurID.SelectedItem.ToString() != "" && combo_pID.SelectedItem.ToString() != "")
                    {
                        int productID = int.Parse(combo_pID.SelectedItem.ToString());
                        int purID = int.Parse(combo_PurID.SelectedItem.ToString());
                        purchaseitem p = content.purchaseitems.First(i => i.ProductID == productID && i.PurchaseOrderID == purID);
                        if (p != null)
                        {
                            numericUpDown_item.Value = int.Parse(p.Quanity.ToString());
                            numericUpDown_item.Enabled = false;
                        }




                    }
                }
            }
            catch (System.NullReferenceException) { }
        }

        private void combo_pID_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    if (combo_PurID.SelectedItem.ToString() != "" && combo_pID.SelectedItem.ToString() != "")
                    {
                        int productID = int.Parse(combo_pID.SelectedItem.ToString());
                        int purID = int.Parse(combo_PurID.SelectedItem.ToString());
                        purchaseitem p = content.purchaseitems.First(i => i.ProductID == productID && i.PurchaseOrderID == purID);
                        if (p != null)
                        {
                            numericUpDown_item.Value = int.Parse(p.Quanity.ToString());
                            numericUpDown_item.Enabled = false;

                        }




                    }
                }
            }
            catch (System.NullReferenceException) { }
        }

        private void checkBox_receivewithspecficnum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_receivewithspecficnum.Checked)
            {
                numericUpDown_item.Enabled = true;

            }
            else {
                try
                {
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {
                        if (combo_PurID.SelectedItem.ToString() != "" && combo_pID.SelectedItem.ToString() != "")
                        {
                            int productID = int.Parse(combo_pID.SelectedItem.ToString());
                            int purID = int.Parse(combo_PurID.SelectedItem.ToString());
                            purchaseitem p = content.purchaseitems.First(i => i.ProductID == productID && i.PurchaseOrderID == purID);
                            if (p != null)
                            {
                                numericUpDown_item.Value = int.Parse(p.Quanity.ToString());
                                numericUpDown_item.Enabled = false;

                            }




                        }
                    }
                }
                catch (System.NullReferenceException) { }
            }


        }


        private void btn_completereceive_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int productID = int.Parse(combo_pID.SelectedItem.ToString());
                    int purID = int.Parse(combo_PurID.SelectedItem.ToString());
                    product p = content.products.First(i => i.ProductID == productID);
                    if (p != null)
                    {
                        int stocklevel = int.Parse(p.StockLevel.ToString());

                        p.StockLevel = stocklevel + int.Parse(numericUpDown_item.Value.ToString());
                        p.Reorder = 0;

                    }
                    purchaseitem pu = content.purchaseitems.First(i => i.ProductID == productID && i.PurchaseOrderID == purID);
                    if (pu != null)
                    {
                        pu.Status = "Processed";

                    }
                    content.SaveChanges();
                    MessageBox.Show("Stock Received");

                }
                checkBox_receivewithspecficnum.Checked = false;
                numericUpDown_item.Value = 0;
                combo_pID.Items.Clear();
                combo_PurID.Items.Clear();
                getProduct();


            }
            catch (System.NullReferenceException) {MessageBox.Show("Please Select The Product That You Want to Receive First"); }
            }
        
    }
}
