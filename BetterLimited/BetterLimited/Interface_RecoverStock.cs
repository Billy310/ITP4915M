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
    public partial class Interface_RecoverStock : Form
    {
        public static Interface_RecoverStock instance;
        public Label lab1;
        public Interface_RecoverStock()
        {
            InitializeComponent();
            instance = this;
            lab1 = label_storeID;
        }

        private void Interface_RecoverStock_Load(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {

                {
                    if (label_storeID.Text == "1")
                    {

                        var emp = (from list in content.products
                                   where list.KBStore > 0
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            {

                                dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.KBStore, emp2.StockLevel);
                            }
                        }
                    }
                    if (label_storeID.Text == "2")
                    {

                        var emp = (from list in content.products
                                   where list.TWStore > 0
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {
                            {

                                dataGridView1.Rows.Add(emp2.ProductID, emp2.ProductName, emp2.TWStore, emp2.StockLevel);
                            }
                        }
                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {
                    cb_pid.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                }
                int storeID = int.Parse(label_storeID.Text);
                store s = content.stores.First(i => i.StoreID == storeID);
                if (s != null)
                {
                    lab_storeName.Text = s.StoreName;

                }


            }

        }

        private void btn_recovery_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("If You Click Yes, There is No Chance To Change The Detail. Are You Sure?", "Are You Sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {

                    shoprecovery sc = new shoprecovery
                    {
                        ProductID = int.Parse(cb_pid.SelectedItem.ToString()),
                        dateofcreate = DateTime.Now,
                        Quanity = int.Parse(numericUpDown_Quantity.Value.ToString()),
                        status = "Waiting For Reply",
                        StoreID = int.Parse(label_storeID.Text)

                    };
                    content.shoprecoveries.Add(sc);
                    content.SaveChanges();
                    product p = content.products.First(i => i.ProductID == sc.ProductID);
                    string pname = "";
                    if (p != null)
                    {
                        pname = p.ProductName;
                    }
                    MessageBox.Show(pname + "is Created A Recover The Store Stock Level");
                }

            }
        }
    }
}
