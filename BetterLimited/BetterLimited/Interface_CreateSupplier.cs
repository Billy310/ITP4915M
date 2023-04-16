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
    public partial class CreateSupplier : Form
    {
        
        public CreateSupplier()
        {
            
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void lab_Phonenum_Click(object sender, EventArgs e)
        {

        }

        private void lab_adress3_Click(object sender, EventArgs e)
        {

        }

        private void lab_adress1_Click(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())

            {
                try
                {
                    if (cb_RegionPhone.SelectedItem.ToString() == "+852" && txt_pnum.TextLength < 8)
                    {
                        throw new FormatException();

                    }
                    if (cb_RegionPhone.SelectedItem.ToString() == "+86" && txt_pnum.TextLength < 11)
                    {
                        throw new FormatException();

                    }
                    if (txt_pnum.Text == "")
                    {
                        throw new FieldAccessException();
                    }
                    if (cb_RegionPhone.SelectedItem.ToString() == "+852" && txt_pnum.TextLength < 8)
                    {

                        throw new InvalidProgramException();
                    }
                    if (cb_RegionPhone.SelectedItem.ToString() == "+86" && txt_pnum.TextLength < 11)
                    {
                        throw new EvaluateException();
                    }
                    if (txt_address1.Text == "" || txt_address2.Text == "" || txt_address3.Text == "")
                    {
                        throw new FormatException();

                    }
                    string phone = cb_RegionPhone.SelectedItem.ToString() + txt_pnum.Text;
                    supplier s = new supplier
                    {
                        SupplierName = txt_name.Text,
                        Address1 = txt_address1.Text,
                        Address2 = txt_address2.Text,
                        Address3 = txt_address3.Text,
                        PhoneNumber = phone,
                        Available = 1,
                        Region = cb_regionname.SelectedItem.ToString() +"    " +combo_Region.SelectedItem.ToString()






                    };
                    content.suppliers.Add(s);
                    content.SaveChanges();
                    MessageBox.Show("Supplier:" + s.SupplierID + " Is Created");
                }
                catch (System.NullReferenceException) { MessageBox.Show("Make Sure All The Information Are Filled"); }
                catch (FormatException) { MessageBox.Show("Please Confirm All The Information Are Filled."); }
                catch (EvaluateException) { MessageBox.Show("The Phone Number Format is not correct.It should be 11 digits"); }
                catch (InvalidProgramException) { MessageBox.Show("The Phone Number Format is not correct.It should be 8 digits"); }
                catch (FieldAccessException) { MessageBox.Show("The Phone Number Can Not be Null."); }

            }
        }

        private void lab_adress2_Click(object sender, EventArgs e)
        {

        }

        private void txt_address3_TextChanged(object sender, EventArgs e)
        {
            {
                {
                    string line1 = txt_address1.Text;
                    string line2 = txt_address2.Text;
                    string line3 = txt_address3.Text;
                    string region = cb_regionname.Text + "," + combo_Region.Text;
                    StringBuilder queryaddress = new StringBuilder();
                    queryaddress.Append("http://google.com/maps?q=");
                    if (txt_address1.TextLength >= 5)
                    {
                        queryaddress.Append(line1 + "," + "+");
                    }
                    if (txt_address2.TextLength >= 5)
                    {
                        queryaddress.Append(line2 + "," + "+");
                    }
                    if (txt_address3.TextLength >= 5)
                    {
                        queryaddress.Append(line3 + "," + "+");
                    }
                    if (region != string.Empty)
                    {
                        queryaddress.Append(region + "," + "+");
                    }
                    webBrowser1.Navigate(queryaddress.ToString());
                }
            }
        }

        private void txt_address2_TextChanged(object sender, EventArgs e)
        {
            {
                {
                    string line1 = txt_address1.Text;
                    string line2 = txt_address2.Text;
                    string line3 = txt_address3.Text;
                    string region = cb_regionname.Text + "," + combo_Region.Text;
                    StringBuilder queryaddress = new StringBuilder();
                    queryaddress.Append("http://google.com/maps?q=");
                    if (txt_address1.TextLength >= 5)
                    {
                        queryaddress.Append(line1 + "," + "+");
                    }
                    if (txt_address2.TextLength >= 5)
                    {
                        queryaddress.Append(line2 + "," + "+");
                    }
                    if (txt_address3.TextLength >= 5)
                    {
                        queryaddress.Append(line3 + "," + "+");
                    }
                    if (region != string.Empty)
                    {
                        queryaddress.Append(region + "," + "+");
                    }
                    webBrowser1.Navigate(queryaddress.ToString());
                }
            }
        }

        private void txt_address1_TextChanged(object sender, EventArgs e)
        {
            {
                string line1 = txt_address1.Text;
                string line2 = txt_address2.Text;
                string line3 = txt_address3.Text;
                string region = cb_regionname.Text + "," + combo_Region.Text;
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://google.com/maps?q=");
                if (txt_address1.TextLength >= 5)
                {
                    queryaddress.Append(line1 + "," + "+");
                }
                if (txt_address2.TextLength >= 5)
                {
                    queryaddress.Append(line2 + "," + "+");
                }
                if (txt_address3.TextLength >= 5)
                {
                    queryaddress.Append(line3 + "," + "+");
                }
                if (region != string.Empty)
                {
                    queryaddress.Append(region + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());
            }
        }

        private void txt_pnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lab_name_Click(object sender, EventArgs e)
        {

        }

        private void lab_Title_Click(object sender, EventArgs e)
        {

        }

        private void cb_RegionPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cb_RegionPhone.SelectedItem.ToString() == "+852")
                {
                    txt_pnum.Enabled = true;
                    txt_pnum.MaxLength = 8;
                }
                if (cb_RegionPhone.SelectedItem.ToString() == "+86")
                {
                    txt_pnum.Enabled = true;
                    txt_pnum.MaxLength = 11;
                }
            }
            catch (System.NullReferenceException) { txt_pnum.Enabled = false; }


        }

        private void cb_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string line1 = txt_address1.Text;
                string line2 = txt_address2.Text;
                string line3 = txt_address3.Text;
                string region = cb_regionname.Text + "," + combo_Region.Text;
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://google.com/maps?q=");
                if (txt_address1.TextLength >= 5)
                {
                    queryaddress.Append(line1 + "," + "+");
                }
                if (txt_address2.TextLength >= 5)
                {
                    queryaddress.Append(line2 + "," + "+");
                }
                if (txt_address3.TextLength >= 5)
                {
                    queryaddress.Append(line3 + "," + "+");
                }
                if (region != string.Empty)
                {
                    queryaddress.Append(region + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());
            }
        }

        private void CreateSupplier_Load(object sender, EventArgs e)
        {
            combo_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_regionname.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_RegionPhone.DropDownStyle = ComboBoxStyle.DropDownList;
           
            cb_RegionPhone.Enabled = false;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_address1.Clear();
            txt_address2.Clear();
            txt_address3.Clear();
            txt_name.Clear();
            txt_pnum.Clear();
            combo_Region.Text=string.Empty;
            cb_regionname.Text = null;
            cb_RegionPhone.Text = null;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Interface_EditSupplier p = new Interface_EditSupplier();
            p.Show();
            this.Hide();
        }

        private void combo_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Region.SelectedItem.ToString() == "China")
            {
                cb_regionname.Items.Clear();
                cb_regionname.Items.Add("Guangzhou");
                cb_regionname.Items.Add("Shenzhen");


                cb_RegionPhone.SelectedItem = "+86";
                txt_pnum.MaxLength = 11;

            }
            if (combo_Region.SelectedItem.ToString() == "Hong Kong")
            {
                cb_regionname.Items.Clear();

                cb_regionname.Items.Add("New Territories");
                cb_regionname.Items.Add("Hong Kong Island");
                cb_regionname.Items.Add("Kowloon Peninsula");
                cb_RegionPhone.SelectedItem = "+852";
               txt_pnum.MaxLength = 8;
            }
            {
                {
                    string line1 = txt_address1.Text;
                    string line2 = txt_address2.Text;
                    string line3 = txt_address3.Text;
                    string region = cb_regionname.Text + "," + combo_Region.Text;
                    StringBuilder queryaddress = new StringBuilder();
                    queryaddress.Append("http://google.com/maps?q=");
                    if (txt_address1.TextLength >= 5)
                    {
                        queryaddress.Append(line1 + "," + "+");
                    }
                    if (txt_address2.TextLength >= 5)
                    {
                        queryaddress.Append(line2 + "," + "+");
                    }
                    if (txt_address3.TextLength >= 5)
                    {
                        queryaddress.Append(line3 + "," + "+");
                    }
                    if (region != string.Empty)
                    {
                        queryaddress.Append(region + "," + "+");
                    }
                    webBrowser1.Navigate(queryaddress.ToString());
                }
            }
        }

        private void cb_regionname_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string line1 = txt_address1.Text;
                string line2 = txt_address2.Text;
                string line3 = txt_address3.Text;
                string region = cb_regionname.Text + "," + combo_Region.Text;
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://google.com/maps?q=");
                if (txt_address1.TextLength >= 5)
                {
                    queryaddress.Append(line1 + "," + "+");
                }
                if (txt_address2.TextLength >= 5)
                {
                    queryaddress.Append(line2 + "," + "+");
                }
                if (txt_address3.TextLength >= 5)
                {
                    queryaddress.Append(line3 + "," + "+");
                }
                if (region != string.Empty)
                {
                    queryaddress.Append(region + "," + "+");
                }
                webBrowser1.Navigate(queryaddress.ToString());
            }
        }

        private void txt_tel_keypress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }


    }
}
