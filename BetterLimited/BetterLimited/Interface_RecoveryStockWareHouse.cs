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
    public partial class Interface_RecoveryStockWareHouse : Form
    {
        public Interface_RecoveryStockWareHouse()
        {
            InitializeComponent();
        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {

                using (var content = new betterlimitedEntities_Test1())
                {
                    int storeid = 0;
                    int id = int.Parse(cb_recoveryID.SelectedItem.ToString());
                    int pid = 0;
                    int qty = 0;
                    shoprecovery sc = content.shoprecoveries.First(i => i.recoveryid == id);
                    if (sc != null)
                    {
                        qty = sc.Quanity;
                        pid = sc.ProductID;
                        sc.status = "Accepted";
                        sc.dateofrecover = DateTime.Parse(monthCalendar_recovery.SelectionRange.Start.ToString("yyyy-MM-dd"));
                        storeid = sc.StoreID;
                    }
                    product p = content.products.First(i => i.ProductID == pid);
                    if (p != null)
                    {
                        if (storeid == 1)
                        {
                            p.KBStore += qty;
                        }
                        if (storeid == 2)
                        {
                            p.TWStore += qty;
                        }
                    }

                    content.SaveChanges();


                }
                dataGridView1.Rows.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {
                    var emp = (from list in content.shoprecoveries
                               where list.status == "Waiting For Reply"
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                        {
                            product p = content.products.First(i => i.ProductID == emp2.ProductID);
                            store s = content.stores.First(i => i.StoreID == emp2.StoreID);
                            if (p != null && s != null)
                            {

                                dataGridView1.Rows.Add(emp2.recoveryid, emp2.ProductID, p.ProductName, emp2.Quanity, p.StockLevel - p.KBStore - p.TWStore, p.KBStore, p.TWStore, s.StoreName);
                            }
                        }
                    }
                    for (int x = 0; x < dataGridView1.RowCount; x++)
                    {
                        cb_recoveryID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                    }


                }

                MessageBox.Show("The Product Will Be Refill At" + monthCalendar_recovery.SelectionRange.Start.ToString("yyyy-MM-dd"));
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Refill Request ID"); }

        }

        private void Interface_RecoveryStockWareHouse_Load(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {
                    var emp = (from list in content.shoprecoveries
                               where list.status == "Waiting For Reply"
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                        {
                            product p = content.products.First(i => i.ProductID == emp2.ProductID);
                            store s = content.stores.First(i => i.StoreID == emp2.StoreID);
                            if (p != null && s != null)
                            {

                                dataGridView1.Rows.Add(emp2.recoveryid, emp2.ProductID, p.ProductName, emp2.Quanity,p.StockLevel- p.KBStore- p.TWStore, p.KBStore, p.TWStore, s.StoreName);
                            }
                        }
                    }
                for (int x = 0; x < dataGridView1.RowCount;x++)
                {
                    cb_recoveryID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                }

                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_refuse_Click(object sender, EventArgs e)
        {
            try {
                using (var content = new betterlimitedEntities_Test1())
                {
                    int id = int.Parse(cb_recoveryID.SelectedItem.ToString());
                    shoprecovery sc = content.shoprecoveries.First(i => i.recoveryid == id);
                    if (sc != null)
                    {
                        sc.status = "Refused";
                        sc.Reason = txt_reason.Text;
                    }
                    content.SaveChanges();


                }
                dataGridView1.Rows.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {
                    var emp = (from list in content.shoprecoveries
                               where list.status == "Waiting For Reply"
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                        {
                            product p = content.products.First(i => i.ProductID == emp2.ProductID);
                            store s = content.stores.First(i => i.StoreID == emp2.StoreID);
                            if (p != null && s != null)
                            {

                                dataGridView1.Rows.Add(emp2.recoveryid, emp2.ProductID, p.ProductName, emp2.Quanity, p.StockLevel - p.KBStore - p.TWStore, p.KBStore, p.TWStore, s.StoreName);
                            }
                        }
                    }
                    for (int x = 0; x < dataGridView1.RowCount; x++)
                    {
                        cb_recoveryID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                    }


                }
                MessageBox.Show("The Request Refused With Providing Reason");

            }
                
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Refill Request ID"); }
}

    }
}
