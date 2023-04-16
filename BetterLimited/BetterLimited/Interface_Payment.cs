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
    public partial class Interface_Payment : Form
    {
        public static Interface_Payment instance;
        public Label lab1;
        public static string Gid;
        public Interface_Payment()
        {
            InitializeComponent();
            instance = this;
            lab1 = label11;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            try
            {

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {

                    saleorder id = content.saleorders.First(i => i.orderID.ToString() == label11.Text);
                    if (id.orderType == "Sale Order")
                        txt_total.Text = id.TotalCharge.ToString();
                    if (id.orderType == "Deposit Order")
                    {
                        txt_total.Text = id.DepositCharge.ToString();
                    }
                    if (id.orderType == "Deposit Payment")
                    {
                        txt_total.Text = (id.TotalCharge - id.DepositCharge).ToString();
                    }
                    if (id.orderType == "New Item Order")
                    {
                        txt_total.Text = id.Addition_Charge.ToString();
                    }
                    if (Interface_OrderManagement.CheckCtoP == "2")
                        txt_total.Text = id.Addition_Charge.ToString();
                    Interface_CreateSaleOrder.CheckCtoP = "0";
                    btn_gen.Enabled = false;
                    btn_cal.Enabled = false;
                    btn_pay.Enabled = false;
                    txt_orderid.Enabled = true;
                    txt_total.Enabled = false;
                    cmb_card.Enabled = false;
                    txt_orderid.Enabled = false;
                    comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
                }
            }
            catch (System.FormatException) { MessageBox.Show("Please Check All The Information Are Filled"); }
            catch (System.InvalidOperationException) { MessageBox.Show("Bugs Existed Restart it"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                txt_pay.Text = txt_total.Text;
                double OutA;
                OutA = double.Parse(txt_pay.Text) - double.Parse(txt_total.Text);
                txt_out.Text = OutA.ToString();
            }
            catch (System.FormatException) {MessageBox.Show("Please Input The Pay Amount"); }
            }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                txt_pay.Enabled = true;
                txt_out.Enabled = true;
                btn_cal.Enabled = true;
                txt_cardnum.Enabled = false;
                txt_namecard.Enabled = false;
                txt_Edate.Enabled = false;
                txt_Scode.Enabled = false;
                txt_cardpay.Enabled = false;
                cmb_card.Text = null;
                cmb_card.Enabled = false;
                btn_pay.Enabled = false;
                btn_gen.Enabled = true;
            }
            if (comboBox1.Text == "Credit Card")
            {
                cmb_card.Enabled = true;
                txt_pay.Enabled = false;
                txt_out.Enabled = false;
                btn_cal.Enabled = false;
                txt_cardnum.Enabled = false;
                txt_namecard.Enabled = false;
                txt_Edate.Enabled = false;
                txt_Scode.Enabled = false;
                txt_cardpay.Enabled = false;
                btn_pay.Enabled = false;
                btn_gen.Enabled = false;
                MessageBox.Show("Please Choose The Card Type");
            }

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_pay_Click(object sender, EventArgs e)
        {
            if (txt_cardnum.Text == "0000 0000 0000 0000" || txt_namecard.Text == "" || txt_Edate.Text == "00/00" || txt_Scode.Text == "000" || txt_cardpay.Text == "")
                MessageBox.Show("There is Information Not Entered");

            if (txt_cardpay.Text != "")
            {
                if (double.Parse(txt_cardpay.Text) < double.Parse(txt_total.Text))
                    MessageBox.Show("Please Enter Sufficient Amount");
                else
                    MessageBox.Show("Submitted");
            }

        }

        private void txt_cardnum_TextChanged(object sender, EventArgs e)
        {
            if (txt_cardnum.Text == "")
                txt_cardnum.Text = "0000 0000 0000 0000";
        }

        private void cmb_card_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_card.Text == "VISA" || cmb_card.Text == "MasterCard")
            {
                txt_pay.Enabled = false;
                txt_out.Enabled = false;
                btn_cal.Enabled = false;
                txt_cardnum.Enabled = true;
                txt_namecard.Enabled = true;
                txt_Edate.Enabled = true;
                txt_Scode.Enabled = true;
                txt_cardpay.Enabled = true;
                btn_pay.Enabled = true;
                btn_gen.Enabled = true;
            }
        }

        private void txt_Edate_TextChanged(object sender, EventArgs e)
        {
            if (txt_Edate.Text == "")
                txt_Edate.Text = "00/00";
        }

        private void txt_Scode_TextChanged(object sender, EventArgs e)
        {
            if (txt_Scode.Text == "")
                txt_Scode.Text = "000";
        }

        private void btn_gen_Click(object sender, EventArgs e)
        {
            try
            {
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    double amount = 0;
                    saleorder pay = content.saleorders.First(i => i.orderID.ToString() == label11.Text);
                    if (comboBox1.Text == "Cash")
                    {
                        if (pay.PayMethod == "VISA")
                        {
                            amount = double.Parse(txt_pay.Text);
                        }
                        else
                        {
                            pay.PayMethod = "Cash";
                            amount = double.Parse(txt_pay.Text);
                        }
                    }
                    if (comboBox1.Text == "Credit Card")
                    {
                        if (cmb_card.Text == "VISA")
                        {
                            pay.PayMethod = "VISA";
                            amount = double.Parse(txt_cardpay.Text);
                        }
                        if (cmb_card.Text == "MasterCard")
                        {
                            pay.PayMethod = "MasterCard";
                            amount = double.Parse(txt_cardpay.Text);
                        }
                    }
                    pay.PayAmount += amount;

                    content.SaveChanges();
                    if (MessageBox.Show("Do Custumer Need Delivery Service.", "Delivery Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        Interface_CreateDeliveryOrder s = new Interface_CreateDeliveryOrder();
                        //CreateDeliveryOrder.instance.lab1.Text = lab1.Text;
                        s.Show();

                    }

                    Gid = label11.Text;
                    Interface_Print p = new Interface_Print();
                    p.Show();
                    this.Hide();


                }
            }
            catch (System.FormatException) { MessageBox.Show("Please Check The Information Is Not Missed.(Pay Amount)"); }
            catch (System.InvalidOperationException) { MessageBox.Show("The Page Is Bugged Please Restart It By Making Payment From Create Sale Order Or Order Management"); }
         
               
        }

        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
