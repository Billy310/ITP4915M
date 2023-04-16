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
    public partial class Interface_ViewDefectRecordList : Form
    {
        public Interface_ViewDefectRecordList()
        {
            InitializeComponent();
        }

        private void Interface_ViewDefectRecordList_Load(object sender, EventArgs e)
        {
            try
            {
                txt_pname.Enabled = false;
                txt_sname.Enabled = false;
                txt_pnum.Enabled = false;
                txt_city.Enabled = false;
                txt_building.Enabled = false;
                txt_Region.Enabled = false;
                txt_street.Enabled = false;
                using (var content = new betterlimitedEntities_Test1())
                {

                    dataGridView1.Rows.Clear();


                    var emp = (from list in content.defectitems

                               select list);
                    foreach (var emp2 in emp.ToList())
                    {
                        product products = content.products.First(i => i.ProductID == emp2.ProductID);
                        saleorder saleorders = content.saleorders.First(i => i.orderID == emp2.SaleOrderID);
                        store stores = content.stores.First(i => i.StoreID == saleorders.storeID);
                        if (products != null && stores != null)
                        {
                            dataGridView1.Rows.Add(emp2.defectItemID, emp2.dateofreturn, emp2.SaleOrderID, emp2.HandleMethod, emp2.ProductID, products.ProductName, emp2.Quantity, stores.StoreName);
                        }
                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {
                    cb_deID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());


                }
            }
            catch (System.InvalidOperationException) { MessageBox.Show(""); }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    int did = int.Parse(cb_deID.SelectedItem.ToString());
                    defectitem d = content.defectitems.First(i => i.defectItemID == did);
                    if (d != null)
                    {
                        d.SupplierReply = txt_supplierreply.Text;
                        d.Handle = "Handled";
                    }
                    content.SaveChanges();
                    MessageBox.Show("The Defect Record Updated");
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("The Defect Item ID Should be Selected"); }
            }

        private void cb_deID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                int did = int.Parse(cb_deID.SelectedItem.ToString());
                defectitem d = content.defectitems.First(i => i.defectItemID == did);
                if (d != null)
                {
                    product p = content.products.First(i => i.ProductID == d.ProductID);
                    if (p != null) {
                        txt_pname.Text = p.ProductName;
                        supplier s = content.suppliers.First(i => i.SupplierID == p.SupplierID);
                        if (s != null) {
                            txt_sname.Text = s.SupplierName;
                            txt_pnum.Text = s.PhoneNumber;
                            txt_city.Text = s.Address1;
                            txt_building.Text = s.Address2;
                            txt_street.Text = s.Address3;
                            txt_Region.Text = s.Region;

                        }
                    }


                }
            }

            }
    }
}
