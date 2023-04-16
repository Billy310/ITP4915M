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
    public partial class CreateReorder : Form
    {

        public CreateReorder()
        {
            
            InitializeComponent();
        }

        private void btn_add2reorder_Click(object sender, EventArgs e)
        {
           
            if (lb_searchresult.SelectedItem != null)
            {
                string itemTxt = lb_searchresult.SelectedItem.ToString();
              
                lb_reorderlist.Items.Add(itemTxt);
                lb_searchresult.Items.Remove(itemTxt);
                MessageBox.Show("Add Product Into Reorder List");
            }
            else
            {
                MessageBox.Show("Failed to Add!");


            }


        }

        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {
      
            lb_reorderlist.Enabled = false;

        }

        private void btn_additem_Click(object sender, EventArgs e)

        {
           
            try
            {
                int a;
                a = int.Parse(txt_ProductID.Text);
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    lb_searchresult.Items.Clear();
                    product c = content.products.First(i => i.ProductID == a);

                    if (c != null)
                    {
                        
                        lb_searchresult.Items.Add(c.SerialNum);

                    }

                }
            }

            catch (System.InvalidOperationException)
            {
                MessageBox.Show("Product is Not Existed");

            }


            catch (FormatException)
            {
                MessageBox.Show("Wrong Format");
            }
        }






        private void lb_reorderlist_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int x = 0; x < 10; x++)
                {
                    lb_reorderlist.Items.Add("Reorder Product");
                }
            

                


                {

                        using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())

                        {
                        string product1_str = lb_reorderlist.Items[0].ToString();
                        if (product1_str == "Reorder Product") {
                            product1_str = null;
                        }
                        string product2_str = lb_reorderlist.Items[1].ToString();
                        if (product2_str == "Reorder Product")
                        {
                            product2_str = null;
                        }
                        string product3_str = lb_reorderlist.Items[2].ToString();
                        if (product3_str == "Reorder Product")
                        {
                            product3_str = null;
                        }
                        string product4_str = lb_reorderlist.Items[3].ToString();
                        if (product4_str == "Reorder Product")
                        {
                            product4_str = null;
                        }
                        string product5_str = lb_reorderlist.Items[4].ToString();
                        if (product5_str == "Reorder Product")
                        {
                            product5_str = null;
                        }
                        string product6_str = lb_reorderlist.Items[5].ToString();
                        if (product6_str == "Reorder Product")
                        {
                            product6_str = null;
                        }
                        string product7_str = lb_reorderlist.Items[6].ToString();
                        if (product7_str == "Reorder Product")
                        {
                            product7_str = null;
                        }
                        string product8_str = lb_reorderlist.Items[7].ToString();
                        if (product8_str == "Reorder Product")
                        {
                            product8_str = null;
                        }
                        string product9_str = lb_reorderlist.Items[8].ToString();
                        if (product9_str == "Reorder Product")
                        {
                            product9_str = null;
                        }
                        string product10_str = lb_reorderlist.Items[9].ToString();
                        if (product10_str == "Reorder Product")
                        {
                            product10_str = null;
                        }







                        reorder re = new reorder
                        {
                            Product1 = product1_str,
                                Product2 = product2_str,
                                Product3= product3_str,
                                Product4 = product4_str,
                                Product5 = product5_str,
                                Product6 = product6_str,
                                Product7 = product7_str,
                                Product8 = product8_str,
                                Product9 = product9_str,
                                Product10 = product10_str
                        };
                    
                            content.reorders.Add(re);
                            content.SaveChanges();
                            MessageBox.Show("Reorder Created");
                     
                        }
                    }
                }


            catch (ArgumentOutOfRangeException) {
                MessageBox.Show("The Reorder List Can Not Be Empty");

            }
            {


            }
            this.Hide();
        }
    }
}











