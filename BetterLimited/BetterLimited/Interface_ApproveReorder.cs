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
    public partial class Interface_ApproveReorder : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public Interface_ApproveReorder()
        {
            InitializeComponent();
        }



        void product()
        {
            string command_query = "SELECT DISTINCT ProductName FROM betterlimited.product WHERE StockLevel <= 10";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("ProductName");
                    cmb_prod.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("ERROR");

            }

        }


        private void ApproveReorder_Load(object sender, EventArgs e)
        {
            cb_reorderID.Items.Clear();
            cmb_approve.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_prod.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_reorderID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_status.DropDownStyle = ComboBoxStyle.DropDownList;


            product();


            txt_prod.Enabled = false;

        }

        private void cmb_EditID_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {
                int reorder = int.Parse(cb_reorderID.SelectedItem.ToString());
                var emp = (from list in content.reorders
                           where list.ReorderID == reorder
                           select list);
                foreach (var emp2 in emp.ToList())
                {
                    product product1s = content.products.First(i => i.ProductID == emp2.Product1);
                    product product2s = content.products.First(i => i.ProductID == emp2.Product2);
                    product product3s = content.products.First(i => i.ProductID == emp2.Product3);
                    product product4s = content.products.First(i => i.ProductID == emp2.Product4);
                    product product5s = content.products.First(i => i.ProductID == emp2.Product5);
                    product product6s = content.products.First(i => i.ProductID == emp2.Product6);
                    product product7s = content.products.First(i => i.ProductID == emp2.Product7);
                    product product8s = content.products.First(i => i.ProductID == emp2.Product8);
                    product product9s = content.products.First(i => i.ProductID == emp2.Product9);
                    product product10s = content.products.First(i => i.ProductID == emp2.Product10);
                    if (product1s != null && product2s != null && product3s != null && product4s != null && product5s != null && product6s != null
                        && product7s != null && product8s != null && product9s != null && product10s != null)
                    {
                        if (emp2.Product1 != 0)
                        {
                            supplier suppliers = content.suppliers.First(i => i.SupplierID == product1s.SupplierID);
                            type types = content.types.First(i => i.TypeID == product1s.TypeID);
                            if (types != null && suppliers != null)
                            {
                                dataGridView2.Rows.Add(product1s.ProductID, product1s.ProductName, types.TypeName, suppliers.SupplierName, product1s.StockLevel);
                            }
                        }
                        if (emp2.Product2 != 0)
                        {
                            supplier suppliers = content.suppliers.First(i => i.SupplierID == product2s.SupplierID);
                            type types = content.types.First(i => i.TypeID == product2s.TypeID);
                            if (types != null && suppliers != null)
                            {
                                dataGridView2.Rows.Add(product2s.ProductID, product2s.ProductName, types.TypeName, suppliers.SupplierName, product2s.StockLevel);
                            }
                        }
                        if (emp2.Product3 != 0)
                        {
                            supplier suppliers = content.suppliers.First(i => i.SupplierID == product3s.SupplierID);
                            type types = content.types.First(i => i.TypeID == product3s.TypeID);
                            if (types != null && suppliers != null)
                            {
                                dataGridView2.Rows.Add(product3s.ProductID, product3s.ProductName, types.TypeName, suppliers.SupplierName, product3s.StockLevel);
                            }
                        }
                        if (emp2.Product4 != 0)
                        {
                            {
                                supplier suppliers = content.suppliers.First(i => i.SupplierID == product4s.SupplierID);
                                type types = content.types.First(i => i.TypeID == product4s.TypeID);
                                if (types != null && suppliers != null)
                                {
                                    dataGridView2.Rows.Add(product4s.ProductID, product4s.ProductName, types.TypeName, suppliers.SupplierName, product4s.StockLevel);
                                }
                            }
                        }
                        if (emp2.Product5 != 0)
                        {
                            {
                                supplier suppliers = content.suppliers.First(i => i.SupplierID == product5s.SupplierID);
                                type types = content.types.First(i => i.TypeID == product5s.TypeID);
                                if (types != null && suppliers != null)
                                {
                                    dataGridView2.Rows.Add(product5s.ProductID, product5s.ProductName, types.TypeName, suppliers.SupplierName, product5s.StockLevel);
                                }
                            }
                        }
                        if (emp2.Product6 != 0)
                        {
                            {
                                supplier suppliers = content.suppliers.First(i => i.SupplierID == product6s.SupplierID);
                                type types = content.types.First(i => i.TypeID == product6s.TypeID);
                                if (types != null && suppliers != null)
                                {
                                    dataGridView2.Rows.Add(product6s.ProductID, product6s.ProductName, types.TypeName, suppliers.SupplierName, product6s.StockLevel);
                                }
                            }
                        }
                        if (emp2.Product7 != 0)
                        {
                            {
                                supplier suppliers = content.suppliers.First(i => i.SupplierID == product7s.SupplierID);
                                type types = content.types.First(i => i.TypeID == product7s.TypeID);
                                if (types != null && suppliers != null)
                                {
                                    dataGridView2.Rows.Add(product7s.ProductID, product7s.ProductName, types.TypeName, suppliers.SupplierName, product7s.StockLevel);
                                }
                            }
                        }
                        if (emp2.Product8 != 0)
                        {
                            {
                                supplier suppliers = content.suppliers.First(i => i.SupplierID == product8s.SupplierID);
                                type types = content.types.First(i => i.TypeID == product8s.TypeID);
                                if (types != null && suppliers != null)
                                {
                                    dataGridView2.Rows.Add(product8s.ProductID, product8s.ProductName, types.TypeName, suppliers.SupplierName, product8s.StockLevel);
                                }
                            }
                        }
                        if (emp2.Product9 != 0)
                        {
                            {
                                supplier suppliers = content.suppliers.First(i => i.SupplierID == product9s.SupplierID);
                                type types = content.types.First(i => i.TypeID == product9s.TypeID);
                                if (types != null && suppliers != null)
                                {
                                    dataGridView2.Rows.Add(product9s.ProductID, product9s.ProductName, types.TypeName, suppliers.SupplierName, product9s.StockLevel);
                                }
                            }
                        }
                        if (emp2.Product10 != 0)
                        {
                            {
                                supplier suppliers = content.suppliers.First(i => i.SupplierID == product10s.SupplierID);
                                type types = content.types.First(i => i.TypeID == product10s.TypeID);
                                if (types != null && suppliers != null)
                                {
                                    dataGridView2.Rows.Add(product10s.ProductID, product10s.ProductName, types.TypeName, suppliers.SupplierName, product10s.StockLevel);
                                }
                            }
                        }
                    }
                }
            }
    }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_status.Text != "" && cmb_status.Text != "Approve")
                {
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {
                        reorder save = content.reorders.First(i => i.ReorderID.ToString() == cb_reorderID.SelectedItem.ToString());
                        save.Approve = cmb_status.Text;
                        content.SaveChanges();
                    }
                    MessageBox.Show("Status Updated");
                    Interface_ApproveReorder re = new Interface_ApproveReorder();
                    re.Show();
                    this.Hide();
                }
                else if (cmb_status.Text == "Approve")
                {
                    if (MessageBox.Show("Once The Reorder List is Approved, There is No Chance to Change", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                        {
                            reorder save = content.reorders.First(i => i.ReorderID.ToString() == cb_reorderID.SelectedItem.ToString());
                            save.Approve = cmb_status.Text;
                            content.SaveChanges();
                        }
                        MessageBox.Show("Status Updated");
                        Interface_ApproveReorder re = new Interface_ApproveReorder();
                        re.Show();
                        this.Hide();


                    }
                    else
                    {
                        throw new KeyNotFoundException();
                    }

                }

            }
            catch (KeyNotFoundException) {MessageBox.Show("Please Select The ReorderID First"); }
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_status.Text != "")
            {
                btn_confirm.Enabled = true;
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
        }

        private void combobox_Type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void combobox_supplier_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Ordsearch_Click(object sender, EventArgs e)
        {
            try
            {
                cb_reorderID.Items.Clear();
                dataGridView1.Rows.Clear();

                if (Rbtn_Appr.Checked)
                {

                    using (var content = new betterlimitedEntities_Test1())
                    {


                        string status = cmb_approve.SelectedItem.ToString();

                        var emp = (from list in content.reorders
                                   where list.Approve == status
                                   select list);
                        foreach (var emp2 in emp.ToList())
                        {


                            dataGridView1.Rows.Add(emp2.ReorderID, emp2.Approve);


                        }

                    }
                }





                else if (Rbtn_Prod.Checked)
                {
                    using (var content = new betterlimitedEntities_Test1())
                    {

                        dataGridView1.Rows.Clear();

                        int pid = int.Parse(txt_prod.Text);



                        var emp = (from list in content.reorders
                                   where list.Product1 == pid || list.Product2 == pid || list.Product3 == pid || list.Product4 == pid || list.Product5 == pid || list.Product6 == pid || list.Product7 == pid || list.Product8 == pid || list.Product9 == pid || list.Product10 == pid
                                   select list);
                        foreach (var emp2 in emp.ToList())
                        {


                            dataGridView1.Rows.Add(emp2.ReorderID, emp2.Approve);


                        }

                    }

                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {
                    cb_reorderID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                }
                if (dataGridView1.RowCount == 0)
                {
                    MessageBox.Show("No Result");
                }
            }

            catch (System.FormatException) { MessageBox.Show("Please Select The Type Or The Supplier"); }
        }


        private void cmb_prod_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string name = cmb_prod.SelectedItem.ToString();
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    product nameid = content.products.First(i => i.ProductName == name);
                    if (name != null)
                    {
                        txt_prod.Text = nameid.ProductID.ToString();
                    }
                }


            }
            catch (System.NullReferenceException) { }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void combobox_supplier_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void combobox_Type_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Rbtn_Appr_CheckedChanged(object sender, EventArgs e)
        {
            if (Rbtn_Appr.Checked)
            {
                cmb_prod.SelectedItem = null;
                txt_prod.Text = string.Empty;
            }
            else if (Rbtn_Prod.Checked)
            {
                cmb_approve.SelectedItem = null;

            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_reorderID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
