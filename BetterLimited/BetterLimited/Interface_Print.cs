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
    public partial class Interface_Print : Form
    {
        public Interface_Print()
        {
            InitializeComponent();
        }

        private void Interface_Generate_Load(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                saleorder oid = content.saleorders.First(i => i.orderID.ToString() == Interface_Payment.Gid); 
                double s1, s2, s3, s4, s5, s6, s7, s8, s9, s10 = 0;

                product o1 = content.products.First(i => i.ProductID == oid.Product1_ID);
                string p1 = oid.Product1_Qty.ToString();
                string d1 = oid.Product1_display.ToString();
                if (oid.Product1_display.ToString() == "1")
                {
                    s1 = o1.Price * 0.7 * int.Parse(p1);
                }
                else
                {
                    s1 = o1.Price * int.Parse(p1);
                }
                   

                product o2 = content.products.First(i => i.ProductID == oid.Product2_ID);
                string p2 = oid.Product2_Qty.ToString();
                string d2 = oid.Product2_display.ToString();
                if (oid.Product2_display.ToString() == "1")
                {
                    s2 = o2.Price * 0.7 * int.Parse(p2);
                }
                else
                {
                    s2 = o2.Price * int.Parse(p2);
                }

                product o3 = content.products.First(i => i.ProductID == oid.Product3_ID);
                string p3 = oid.Product3_Qty.ToString();
                string d3 = oid.Product3_display.ToString();
                if (oid.Product3_display.ToString() == "1")
                {
                    s3 = o3.Price * 0.7 * int.Parse(p3);
                }
                else
                {
                    s3 = o3.Price * int.Parse(p3);
                }

                product o4 = content.products.First(i => i.ProductID == oid.Product4_ID);
                string p4 = oid.Product4_Qty.ToString();
                string d4 = oid.Product4_display.ToString();
                if (oid.Product4_display.ToString() == "1")
                {
                    s4 = o4.Price * 0.7 * int.Parse(p4);
                }
                else
                {
                    s4 = o4.Price * int.Parse(p4);
                }

                product o5 = content.products.First(i => i.ProductID == oid.Product5_ID);
                string p5 = oid.Product5_Qty.ToString();
                string d5 = oid.Product5_display.ToString();
                if (oid.Product5_display.ToString() == "1")
                {
                    s5 = o5.Price * int.Parse(p5);
                }
                else
                {
                    s5 = o5.Price * int.Parse(p5);
                }

                product o6 = content.products.First(i => i.ProductID == oid.Product6_ID);
                string p6 = oid.Product6_Qty.ToString();
                string d6 = oid.Product6_display.ToString();
                if (oid.Product6_display.ToString() == "1")
                {
                    s6 = o6.Price * 0.7 * int.Parse(p6);
                }
                else
                {
                    s6 = o6.Price * int.Parse(p6);
                }

                product o7 = content.products.First(i => i.ProductID == oid.Product7_ID);
                string p7 = oid.Product7_Qty.ToString();
                string d7 = oid.Product7_display.ToString();
                if (oid.Product7_display.ToString() == "1")
                {
                    s7 = o7.Price * 0.7 * int.Parse(p7);
                }
                else
                {
                    s7 = o7.Price * int.Parse(p7);
                }

                product o8 = content.products.First(i => i.ProductID == oid.Product8_ID);
                string p8 = oid.Product8_Qty.ToString();
                string d8 = oid.Product8_display.ToString();
                if (oid.Product8_display.ToString() == "1")
                {
                    s8 = o8.Price * 0.7 * int.Parse(p8);
                }
                else
                {
                    s8 = o8.Price * int.Parse(p8);
                }

                product o9 = content.products.First(i => i.ProductID == oid.Product9_ID);
                string p9 = oid.Product9_Qty.ToString();
                string d9 = oid.Product9_display.ToString();
                if (oid.Product9_display.ToString() == "1")
                {
                    s9 = o9.Price * 0.7 * int.Parse(p9);
                }
                else
                {
                    s9 = o9.Price * int.Parse(p9);
                }

                product o10 = content.products.First(i => i.ProductID == oid.Product10_ID);
                string p10 = oid.Product10_Qty.ToString();
                string d10 = oid.Product10_display.ToString();
                if (oid.Product10_display.ToString() == "1")
                {
                    s10 = o10.Price * 0.7 * int.Parse(p10);
                }
                else
                {
                    s10 = o10.Price * int.Parse(p10);
                }

                double total = 0;
                double cal = 0;
                if (oid.Addition_Charge != 0)
                {
                    total = double.Parse(oid.TotalCharge.ToString()) + double.Parse(oid.Addition_Charge.ToString());
                }
                else
                {
                    total = double.Parse(oid.TotalCharge.ToString());
                }         
                cal = total * 0.2;
                
                double change = 0;
                if (oid.orderType == "Deposit Order")
                {
                    change = double.Parse(oid.PayAmount.ToString()) - cal;
                }
                else
                {
                    change = double.Parse(oid.PayAmount.ToString()) - total;
                }
                RTB_view.Clear();
                RTB_view.Text += "******************************************\n";
                RTB_view.Text += "              Better Limited              \n";
                if(oid.orderType == "Deposit Order") { 
                    RTB_view.Text += "           --DEPOSIT--RECEIPT--           \n";
                } else { 
                RTB_view.Text += "           --PAYMENT--RECEIPT--           \n";
                }
                RTB_view.Text += "******************************************\n";
                RTB_view.Text += "OrderID " + oid.orderID.ToString().PadRight(10) + "     " + oid.Date_Of_Purchase.ToString("MM/dd/yyyy HH:mm:ss").PadLeft(8) + "\n\n";
                RTB_view.Text += "Product                  Qty   DIS   Price\n";
                RTB_view.Text += "------------------------------------------\n";
                RTB_view.Text += o1.ProductName.PadRight(25) + p1.PadLeft(3) + d1.PadLeft(6) + s1.ToString().PadLeft(8) + "\n";
                if (o2.ProductName != "")
                    RTB_view.Text += o2.ProductName.PadRight(25) + p2.PadLeft(3) + d2.PadLeft(6) + s2.ToString().PadLeft(8) + "\n";
                if (o3.ProductName != "")
                    RTB_view.Text += o3.ProductName.PadRight(25) + p3.PadLeft(3) + d3.PadLeft(6) + s3.ToString().PadLeft(8) + "\n";
                if (o4.ProductName != "")
                    RTB_view.Text += o4.ProductName.PadRight(25) + p4.PadLeft(3) + d4.PadLeft(6) + s4.ToString().PadLeft(8) + "\n";
                if (o5.ProductName != "")
                    RTB_view.Text += o5.ProductName.PadRight(25) + p5.PadLeft(3) + d5.PadLeft(6) + s5.ToString().PadLeft(8) + "\n";
                if (o6.ProductName != "")
                    RTB_view.Text += o6.ProductName.PadRight(25) + p6.PadLeft(3) + d6.PadLeft(6) + s6.ToString().PadLeft(8) + "\n";
                if (o7.ProductName != "")
                    RTB_view.Text += o7.ProductName.PadRight(25) + p7.PadLeft(3) + d7.PadLeft(6) + s7.ToString().PadLeft(8) + "\n";
                if (o8.ProductName != "")
                    RTB_view.Text += o8.ProductName.PadRight(25) + p8.PadLeft(3) + d8.PadLeft(6) + s8.ToString().PadLeft(8) + "\n";
                if (o9.ProductName != "")
                    RTB_view.Text += o9.ProductName.PadRight(25) + p9.PadLeft(3) + d9.PadLeft(6) + s9.ToString().PadLeft(8) + "\n";
                if (o10.ProductName != "")
                    RTB_view.Text += o10.ProductName.PadRight(25) + p10.PadLeft(3) + d10.PadLeft(6) + s10.ToString().PadLeft(8) + "\n";
                RTB_view.Text += "------------------------------------------\n";
                if (oid.Addition_Charge > 0) { 
                    RTB_view.Text += "Addition_Charge" + oid.Addition_Charge.ToString().PadLeft(27) + "\n";
                }
                if (oid.orderType == "Deposit Order") {              
                    RTB_view.Text += "ToTal Deposit" + cal.ToString().PadLeft(29) + "\n";
                }
                else {
                    RTB_view.Text += "ToTal" + total.ToString().PadLeft(37) + "\n";
                }
                RTB_view.Text += oid.PayMethod.PadRight(35) + oid.PayAmount.ToString().PadLeft(7) + "\n";
                RTB_view.Text += "Change" + change.ToString().PadLeft(36) + "\n";
                RTB_view.Text += "------------------------------------------\n";
                RTB_view.Text += "                THANK YOU!                \n";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Back To Lobby", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                Interface_ShopManager s = new Interface_ShopManager();
                s.Show();
                this.Hide();


            }
            else { }
        }
    }
}
