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
    public partial class Interface_ApprovePurchaseItem : Form
    {
        public Interface_ApprovePurchaseItem()
        {
            InitializeComponent();
        }
        void getItem()
        {
            dataGridView1.Rows.Clear();
            cb_PID.Items.Clear();
            cb_PurID.Items.Clear();
            using (var content = new betterlimitedEntities_Test1())
            {

                var emp = (from list in content.purchaseitems
                           where list.Status== "Waiting Approve"
                           select list);



                foreach (var emp2 in emp.ToList())
                {
                    product id = content.products.First(i => i.ProductID ==emp2.ProductID);
                    if (id != null)
                    {
                        dataGridView1.Rows.Add(emp2.ProductID, id.ProductName,emp2.Quanity,emp2.Price, id.StockLevel,emp2.PurchaseOrderID);

                    }

                }
                for (int x = 0; x < dataGridView1.RowCount; x++) {
                    cb_PID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                    cb_PurID.Items.Add(dataGridView1.Rows[x].Cells[5].Value.ToString());
                }
            }
        }

private void Interface_ApprovePurchaseItem_Load(object sender, EventArgs e)
        {
            getItem();
            cb_PID.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_PurID.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int puchaseID = 0;
                    int productID = int.Parse(cb_PID.SelectedItem.ToString());
                    for (int x = 0; x < cb_PID.Items.Count; x++)
                    {
                        if (int.Parse(cb_PID.Items[x].ToString()) != productID)
                        {
                            count++;
                        }
                        else if (int.Parse(cb_PID.Items[x].ToString()) == productID)
                        {
                            puchaseID = int.Parse(cb_PurID.Items[count].ToString());
                        }


                    }

                    purchaseitem id = content.purchaseitems.First(i => i.ProductID == productID && i.PurchaseOrderID == puchaseID);
                    if (id != null)
                    {
                        id.Status = "Approved";


                    }
                    content.SaveChanges();
                    MessageBox.Show("Purchase Product Is Approved");
                    getItem();

                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Purchase ID First"); }
        }

        private void btn_refuse_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int count = 0;
                    int puchaseID = 0;
                    int productID = int.Parse(cb_PID.SelectedItem.ToString());
                    for (int x = 0; x < cb_PID.Items.Count; x++)
                    {
                        if (int.Parse(cb_PID.Items[x].ToString()) != productID)
                        {
                            count++;
                        }
                        else if (int.Parse(cb_PID.Items[x].ToString()) == productID)
                        {
                            puchaseID = int.Parse(cb_PurID.Items[count].ToString());
                        }


                    }

                    purchaseitem id = content.purchaseitems.First(i => i.ProductID == productID && i.PurchaseOrderID == puchaseID);
                    if (id != null)
                    {
                        id.Status = "Not Approved";


                    }
                    content.SaveChanges();
                    product products = content.products.First(i => i.ProductID == productID);
                    if (products != null)
                    {
                        products.Reorder = 2;

                    }
                }

            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Purchase Item ID First"); }
        }

        private void cb_PID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
