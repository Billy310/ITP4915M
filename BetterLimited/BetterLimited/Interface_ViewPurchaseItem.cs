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
    public partial class Interface_ViewPurchaseItem : Form
    {
        public Interface_ViewPurchaseItem()
        {
            InitializeComponent();
        }
        void getItem()
        {
            dataGridView1.Rows.Clear();
            cb_pID.Items.Clear();
            cb_PurID.Items.Clear();
            using (var content = new betterlimitedEntities_Test1())
            {

                var emp = (from list in content.purchaseitems
                           where list.Status != "Finish"
                           select list);



                foreach (var emp2 in emp.ToList())
                {
                    product id = content.products.First(i => i.ProductID == emp2.ProductID);
                    if (id != null)
                    {
                        dataGridView1.Rows.Add(emp2.ProductID, id.ProductName, emp2.Quanity, emp2.PurchaseOrderID);

                    }

                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {
                    cb_pID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                    cb_PurID.Items.Add(dataGridView1.Rows[x].Cells[3].Value.ToString());
                }
            }
        }

        private void cb_pID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = 0;
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                int puchaseID = 0;
                int productID = int.Parse(cb_pID.SelectedItem.ToString());
                for (int x = 0; x < cb_pID.Items.Count; x++)
                {
                    if (int.Parse(cb_pID.Items[x].ToString()) != productID)
                    {
                        count++;
                    }
                    else if (int.Parse(cb_pID.Items[x].ToString()) == productID)
                    {
                        puchaseID = int.Parse(cb_PurID.Items[count].ToString());
                    }


                }

                product supplier = content.products.First(i => i.ProductID == productID);
                supplier s = content.suppliers.First(i => i.SupplierID== supplier.SupplierID);
                if (s != null)
                {
                    txt_sname.Text = s.SupplierName;
                    txt_pnum.Text = s.PhoneNumber;
                    txt_city.Text = s.Address1;
                    txt_building.Text = s.Address2;
                    txt_street.Text = s.Address3;
                    txt_Region.Text = s.Region;


                }



            }
        }

        private void Interface_ViewPurchaseItem_Load(object sender, EventArgs e)
        {
            getItem();
            txt_sname.Enabled = false;
            txt_building.Enabled = false;
            txt_city.Enabled = false;
            txt_pnum.Enabled = false;
            txt_street.Enabled = false;
            txt_Region.Enabled = false;
            cb_pID.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_PurID.DropDownStyle = ComboBoxStyle.DropDownList;


        }

        private void btn_status_Click(object sender, EventArgs e)
        {
            int count = 0;
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                int puchaseID = 0;
                int productID = int.Parse(cb_pID.SelectedItem.ToString());
                for (int x = 0; x < cb_pID.Items.Count; x++)
                {
                    if (int.Parse(cb_pID.Items[x].ToString()) != productID)
                    {
                        count++;
                    }
                    else if (int.Parse(cb_pID.Items[x].ToString()) == productID)
                    {
                        puchaseID = int.Parse(cb_PurID.Items[count].ToString());
                    }


                }

                purchaseitem id = content.purchaseitems.First(i => i.ProductID == productID && i.PurchaseOrderID == puchaseID);
                if (id != null)
                {
                    id.Status = cb_status.SelectedItem.ToString();


                }
                content.SaveChanges();
                MessageBox.Show("Purchase Product Status Is Updated");
                getItem();

            }
        }
    }
}
