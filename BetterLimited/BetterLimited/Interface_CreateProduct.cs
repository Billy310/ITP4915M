using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BetterLimited
{
    public partial class Interface_CreateProduct : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Interface_CreateProduct()
        {
            InitializeComponent();
        }
        void mySubjects()
        {
            string command_query = "SELECT SupplierName FROM betterlimited.supplier";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("SupplierName");
                    cb_supplierID.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");

            }

        }
        void Add2Type()
        {
            string command_query = "SELECT DISTINCT TypeName FROM betterlimited.type";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("TypeName");
                    cb_type.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Productname_TextChanged(object sender, EventArgs e)
        {
            cb_type.Items.Clear();
            Add2Type();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                string suppliername = cb_supplierID.SelectedItem.ToString();
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    if (numericUpDown_kb.Value + numericUpDown_tw.Value > numericAmount.Value)
                    {

                        throw new ReadOnlyException();
                    }
                    supplier suppliers = content.suppliers.First(i => i.SupplierName == suppliername);
                    if (suppliers != null)
                    {
                        txt_SupplierID.Text = suppliers.SupplierID.ToString();

                    }
                    if (radioButton1.Checked)
                    {
                        txt_available.Text = "1";



                    }
                    else if (radioButton2.Checked)
                    {
                        txt_available.Text = "0";
                    }
                    if (cb_type.Text != "")
                    {
                        string typename = cb_type.Text;
                        type types = content.types.First(i => i.TypeName == typename);
                        if (types != null)
                        {
                            txt_typeID.Text = types.TypeID.ToString();


                        }
                        string serialcode = txt_snum.Text;
                        if (txt_snum.Text == "")
                        {
                            serialcode = string.Empty;
                        }
                        product p = new product
                        {
                            ProductName = txt_Productname.Text,
                            Price = int.Parse(txt_price.Text),
                            SerialNum = txt_snum.Text,
                            SupplierID = int.Parse(txt_SupplierID.Text),
                            Available = int.Parse(txt_available.Text),
                            TypeID = int.Parse(txt_typeID.Text),
                            StockLevel = int.Parse(numericAmount.Value.ToString()),
                            Low_Standard = int.Parse(lowstocklevel_count.Value.ToString()),
                            Reorder = 0,
                            KBStore = int.Parse(numericUpDown_kb.Value.ToString()),
                            TWStore = int.Parse(numericUpDown_tw.Value.ToString()),








                        };
                        content.products.Add(p);
                        content.SaveChanges();
                        MessageBox.Show("Product Created. The ProductID is" + p.ProductID);
                    }
                    else
                    {
                        throw new System.NullReferenceException();
                    }










                }
            }
            catch (ReadOnlyException) { MessageBox.Show("Make Sure The Sum Of the two stores Stock Level Are Equal or Lower To The Stock Level"); }
            catch (System.NullReferenceException) { MessageBox.Show("Make Sure All The Information Are Filled"); }
            catch (FormatException) { MessageBox.Show("Make Sure All The Information Are Filled and the Information are correct data type"); }

        }



        private void txt_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Interface_EditProduct p = new Interface_EditProduct();
            p.Show();
            this.Hide();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void cb_supplierID_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_type.Items.Clear();
            Add2Type();
        }

        private void CreateProduct_Load(object sender, EventArgs e)
        {
            Add2Type();
            mySubjects();
            cb_supplierID.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_type.DropDownStyle = ComboBoxStyle.DropDownList;
            //txt_Typename.Enabled = false;
        }

        private void cb_type_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txt_typeID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_CreateSupplier_Click(object sender, EventArgs e)
        {
            CreateSupplier cs = new CreateSupplier();
            cs.Show();
        }

        private void lab_Title_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void RadioButtonAddtype_CheckedChanged(object sender, EventArgs e)
        {
            // txt_Typename.Enabled = true;
        }

        private void numericAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_price_TextChanged(object sender, EventArgs e)
        {
            cb_type.Items.Clear();
            Add2Type();
        }

        private void radioButtonProduct_CheckedChanged(object sender, EventArgs e)
        {
            //txt_Typename.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Interface_CreateType p = new Interface_CreateType();
            p.Show();

        }

        private void txt_Typename_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {

        }

        private void txt_snum_TextChanged(object sender, EventArgs e)
        {
            cb_type.Items.Clear();
            Add2Type();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // this.Close();
                    Interface_Login login = new Interface_Login();
                    login.Show();
                    this.Hide();
                }
                else { }
            }
        }

        private void txt_stock_keypress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txt_price_keypress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cb_supplierID.Items.Clear();
            mySubjects();
            cb_type.Items.Clear();
            Add2Type();
            
        }
    }
}
