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
    public partial class Interface_EditSupplier : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Interface_EditSupplier()
        {
            InitializeComponent();
        }
       

        private void lab_Title_Click(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBox_changephonenum.Checked) { 
                if (cb_Regionp.SelectedItem.ToString() == "+852" && txt_tel.TextLength < 8)
                {
                    throw new FormatException();

                }
                    if (cb_Regionp.SelectedItem.ToString() == "+86" && txt_tel.TextLength < 11)
                    {
                        throw new FormatException();

                    }
                }

                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    supplier suppliers = content.suppliers.First(i => i.SupplierID.ToString() == txt_supid.Text);
                    suppliers.SupplierName = txt_name.Text;
                    suppliers.PhoneNumber = txt_pum.Text;
                    suppliers.Address1 = txt_address1.Text;
                    suppliers.Address2 = txt_address2.Text;
                    suppliers.Address3 = txt_address3.Text;
                    if (checkBox_region.Checked)
                    {
                        suppliers.Region = combo_Region.SelectedItem.ToString() + cb_regionname.SelectedItem.ToString();
                    }
                    if (checkBox_changephonenum.Checked)
                    {
                        suppliers.PhoneNumber = cb_Regionp.SelectedItem.ToString() + txt_tel.Text;
                    }

                    content.SaveChanges();
                    MessageBox.Show("Supplier Updated" + suppliers.SupplierID);

               
        
                }
                dataGridView1.Rows.Clear();
                cb_suppliername.Items.Clear();
                using (var content = new betterlimitedEntities_Test1())
                {
                    {

                        var emp = (from list in content.suppliers
                                   where list.SupplierID != 0
                                   select list);



                        foreach (var emp2 in emp.ToList())
                        {


                            dataGridView1.Rows.Add(emp2.SupplierID, emp2.SupplierName, emp2.PhoneNumber);
                        }
                    }
                    for (int x = 0; x < dataGridView1.RowCount; x++)
                    {

                        cb_suppliername.Items.Add(dataGridView1.Rows[x].Cells[1].Value.ToString());

                    }
                }
            }
            catch (FormatException) { MessageBox.Show("Make Sure Your Information is Correct Format"); }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                string suppliername=cb_suppliername.SelectedItem.ToString();
                supplier s = content.suppliers.First(i => i.SupplierName == suppliername);
                {
                    int supid = s.SupplierID;
                    txt_supid.Text = supid.ToString();

                }
                int supid_int = int.Parse(txt_supid.Text);
                supplier s1 = content.suppliers.First(i => i.SupplierID == supid_int);

                if (s != null)
                {
                    txt_name.Text = s.SupplierName;
                    txt_address1.Text = s.Address1;
                    txt_address2.Text = s.Address2;
                    txt_address3.Text = s.Address3;
                    txt_region.Text = s.Region;
                    int supplierID = s.SupplierID;
                    txt_pum.Text = s.PhoneNumber;
                    txt_region.Text = s.Region;
                    MessageBox.Show("Search, " + s.SupplierID);


                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_SupplierID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_address3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_address1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_pnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab_Phonenum_Click(object sender, EventArgs e)
        {

        }

        private void lab_adress2_Click(object sender, EventArgs e)
        {

        }

        private void lab_adress1_Click(object sender, EventArgs e)
        {

        }

        private void lab_name_Click(object sender, EventArgs e)
        {

        }

        private void EditSupplier_Load(object sender, EventArgs e)
        {
           
            cb_Regionp.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_Region.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_regionname.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_suppliername.DropDownStyle = ComboBoxStyle.DropDownList;
            lab_Phonenum.Visible = false;
            cb_Regionp.Visible = false;
            txt_tel.Visible = false;
            label_region.Visible = false;
            combo_Region.Visible = false;
            cb_regionname.Visible = false;
            txt_region.Enabled = false;
            txt_pum.Enabled = false;
            using (var content = new betterlimitedEntities_Test1())
            {
                {

                    var emp = (from list in content.suppliers
                               where list.SupplierID != 0
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                       

                            dataGridView1.Rows.Add(emp2.SupplierID, emp2.SupplierName, emp2.PhoneNumber);
                    }
                    }
                for (int x = 0; x < dataGridView1.RowCount; x++) {

                    cb_suppliername.Items.Add(dataGridView1.Rows[x].Cells[1].Value.ToString());

                }
                }


            }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                supplier suppliers = content.suppliers.First(i => i.SupplierID.ToString() == txt_supid.Text);
                suppliers.Available = 0;
          
                content.SaveChanges();
                MessageBox.Show("Supplier Removed" + suppliers.SupplierID);


            }
            dataGridView1.Rows.Clear();
            cb_suppliername.Items.Clear();
            using (var content = new betterlimitedEntities_Test1())
            {
                {

                    var emp = (from list in content.suppliers
                               where list.SupplierID != 0
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {


                        dataGridView1.Rows.Add(emp2.SupplierID, emp2.SupplierName, emp2.PhoneNumber);
                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {

                    cb_suppliername.Items.Add(dataGridView1.Rows[x].Cells[1].Value.ToString());

                }
            }
        }

        private void cb_Regionp_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                if (cb_Regionp.SelectedItem.ToString() == "+852")
                {
                    txt_tel.MaxLength = 8;
                    txt_tel.Clear();
                }
                if (cb_Regionp.SelectedItem.ToString() == "+86")
                {
                    txt_tel.MaxLength = 11;
                    txt_tel.Clear();
                }
            }
        }

        private void combo_Region_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Region.SelectedItem.ToString() == "China")
            {
                cb_regionname.Items.Clear();
                cb_regionname.Items.Add("Guangzhou");
                cb_regionname.Items.Add("Shenzhen");


                cb_Regionp.SelectedItem = "+86";
                txt_tel.MaxLength = 11;

            }
            if (combo_Region.SelectedItem.ToString() == "Hong Kong")
            {
                cb_regionname.Items.Clear();

                cb_regionname.Items.Add("New Territories");
                cb_regionname.Items.Add("Hong Kong Island");
                cb_regionname.Items.Add("Kowloon Peninsula");
                cb_Regionp.SelectedItem = "+852";
                txt_tel.MaxLength = 8;
            }
        }

        private void cb_regionname_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_changephonenum_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_changephonenum.Checked)
            {
                lab_Phonenum.Visible = true;
                cb_Regionp.Visible = true;
                txt_tel.Visible = true;
            }
            else {
                lab_Phonenum.Visible = false;
                cb_Regionp.Visible = false;
                txt_tel.Visible = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_region.Checked)
            {
                label_region.Visible = true;
                combo_Region.Visible = true;
                cb_regionname.Visible = true;
            }
            else {
                label_region.Visible = false;
                combo_Region.Visible = false;
                cb_regionname.Visible = false;
            }
        }

        private void txt_tel_keypress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_Logout_Click(object sender, EventArgs e)
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

        private void btn_available_Click(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                supplier suppliers = content.suppliers.First(i => i.SupplierID.ToString() == txt_supid.Text);
                suppliers.Available = 1;

                content.SaveChanges();
                MessageBox.Show("Supplier Removed" + suppliers.SupplierID);


            }
            dataGridView1.Rows.Clear();
            cb_suppliername.Items.Clear();
            using (var content = new betterlimitedEntities_Test1())
            {
                {

                    var emp = (from list in content.suppliers
                               where list.SupplierID != 0
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {


                        dataGridView1.Rows.Add(emp2.SupplierID, emp2.SupplierName, emp2.PhoneNumber);
                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {

                    cb_suppliername.Items.Add(dataGridView1.Rows[x].Cells[1].Value.ToString());

                }
            }
        }

        private void cb_suppliername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
