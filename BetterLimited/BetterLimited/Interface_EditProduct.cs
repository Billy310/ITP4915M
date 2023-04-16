using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BetterLimited
{
    public partial class Interface_EditProduct : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        betterlimitedEntities_Test1 db = new betterlimitedEntities_Test1();
        public Interface_EditProduct()
        {

            InitializeComponent();
        }
        void add2Type()
        {
            string command_query = "SELECT TypeName FROM betterlimited.type";
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
                MessageBox.Show("TypeName ERROR");

            }

        }
        void add2Type_ver1()
        {
            string command_query = "SELECT TypeName FROM betterlimited.type";
            MySqlCommand cmd = new MySqlCommand(command_query, Conn);
            MySqlDataReader mydr;
            try
            {
                Conn.Open();
                mydr = cmd.ExecuteReader();
                while (mydr.Read())
                {
                    string subj = mydr.GetString("TypeName");
                    comboBox_type.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("TypeName ERROR");

            }

        }
        void add2Supplier()
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
                MessageBox.Show("Supplier Name ERROR");

            }

        }
     

        



        private void byn_Search_Click(object sender, EventArgs e)

        {

        }


        private void btn_Save_Click(object sender, EventArgs e)
        {


        }

        private void combo_available_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_ProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Supplier_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            Interface_CreateProduct p = new Interface_CreateProduct();
            p.Show();
            this.Hide();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void EditProduct_Load(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {
                {

                    var emp = (from list in content.products
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                        type types = content.types.First(i => i.TypeID == emp2.TypeID);
                        if (types != null)
                        {

                            dataGridView1.Rows.Add(emp2.ProductID, types.TypeName, emp2.ProductName, emp2.StockLevel, emp2.KBStore, emp2.KBdisplay, emp2.TWStore, emp2.TWdisplay);
                        }
                    }
                }
            }
            cmb_display.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_storeitem.DropDownStyle = ComboBoxStyle.DropDownList;
            combobox_productID.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_type.DropDownStyle = ComboBoxStyle.DropDownList;
          cb_type.DropDownStyle = ComboBoxStyle.DropDownList;
         cb_supplierID.DropDownStyle = ComboBoxStyle.DropDownList;
            add2Type_ver1();
            add2Type();
            add2Supplier();

        }

        private void txt_snum_TextChanged(object sender, EventArgs e)
        {

        }

        private void combobox_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                int productID = int.Parse(combobox_productID.SelectedItem.ToString());


                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    product p = content.products.First(i => i.ProductID == productID);
                    type ty = content.types.First(i => i.TypeID == p.TypeID);
                    supplier su = content.suppliers.First(i => i.SupplierID == p.SupplierID);

                    if (p != null)
                    {
                        int price = p.Price;
                        txt_price.Text = price.ToString();
                        int supplierID_int = p.SupplierID;
                        txt_SupplierID.Text = supplierID_int.ToString();
                        txt_Productname.Text = p.ProductName;
                        txt_snum.Text = p.SerialNum;
                        txt_typeID.Text = p.TypeID.ToString();
                        txt_totalamount.Value = int.Parse(p.StockLevel.ToString());
                        cb_type.SelectedText = ty.TypeName;
                        cb_supplierID.Text = su.SupplierName;
                        lowstocklevel_count.Value = int.Parse(p.Low_Standard.ToString());
                    }
                    int supplierID_int2 = int.Parse(txt_SupplierID.Text);
                    supplier s = content.suppliers.First(i => i.SupplierID == supplierID_int2);
                    if (s != null)
                    {
                        cb_supplierID.SelectedItem = s.SupplierName;
                        cb_supplierID.Items.Clear();
                        add2Supplier();


                    }
                    int type = int.Parse(txt_typeID.Text);
                    type t = content.types.First(i => i.TypeID == type);
                    if (t != null)
                    {
                        cb_type.SelectedItem = t.TypeName;
                        cb_type.Items.Clear();
                        add2Type();
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("The Product information will be changed after clicking Yes button", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {
                        if (checkBox_supplier.Checked)
                        {
                            supplier suppliers = content.suppliers.First(i => i.SupplierName == cb_supplierID.Text);

                            if (suppliers != null)
                            {
                                int suppliersID_int = suppliers.SupplierID;
                                txt_SupplierID.Text = suppliersID_int.ToString();

                            }
                        }
                        if (checkBox_type.Checked)
                        {
                            type types = content.types.First(i => i.TypeName == cb_type.Text);
                            if (types != null)
                            {
                                int typeID_int = types.TypeID;
                                txt_typeID.Text = typeID_int.ToString();
                            }
                        }


                        int x = int.Parse(combobox_productID.SelectedItem.ToString());
                        product products = content.products.First(i => i.ProductID == x);
                        if (products != null)
                        {
                            products.Low_Standard = int.Parse(lowstocklevel_count.Value.ToString());
                            products.ProductName = txt_Productname.Text;
                            products.Price = int.Parse(txt_price.Text);
                            products.TypeID = int.Parse(txt_typeID.Text);
                            products.SupplierID = int.Parse(txt_SupplierID.Text);
                            products.StockLevel = int.Parse(txt_totalamount.Value.ToString());
                            if (cmb_display.Text != string.Empty)
                            {
                                if (cmb_display.SelectedItem.ToString() == "KBdisplay" && checkBox_display.Checked)
                                    products.KBdisplay = int.Parse(txt_disAmount.Text);
                                if (cmb_storeitem.SelectedItem.ToString() == "KBStore" && checkBox_storeStock.Checked)
                                    products.KBStore = int.Parse(txt_amount.Text);
                                if (cmb_display.SelectedItem.ToString() == "TWdisplay" && checkBox_display.Checked)
                                    products.TWdisplay = int.Parse(txt_disAmount.Text);
                                if (cmb_storeitem.SelectedItem.ToString() == "TWStore" && checkBox_storeStock.Checked)
                                    products.TWStore = int.Parse(txt_amount.Text);
                            }


                        }
                        content.SaveChanges();
                        MessageBox.Show("Save ProductID: " + products.ProductID, "Information Successful");


                    }
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Product That You Want To Edit First!"); }


            //else { }
            //  }
            // catch (System.NotSupportedException) { MessageBox.Show("Make Sure You Have Assign the Changes of the Product"); }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton3.Checked && comboBox_type.SelectedItem.ToString() != "")
                {
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {
                            string typename = comboBox_type.SelectedItem.ToString();
                            type types = content.types.First(i => i.TypeName == typename);
                            if (types != null)
                            {
                                int typeID = types.TypeID;
                                txt_typeID1.Text = typeID.ToString();

                            }
                            int TypeID = int.Parse(txt_typeID1.Text);
                            var emp = (from list in content.products
                                       where list.TypeID == TypeID
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types2 = content.types.First(i => i.TypeID == emp2.TypeID);
                                if (types2 != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ProductID, types.TypeName, emp2.ProductName, emp2.StockLevel, emp2.KBStore, emp2.KBdisplay, emp2.TWStore, emp2.TWdisplay);
                                }




                            }
                        }
                    }

                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select The Type From the comboBox"); }

        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked == true && comboBox_type.SelectedItem.ToString() != "")
                {
                    dataGridView1.Rows.Clear();
                     combobox_productID.Items.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {
                            string typename = comboBox_type.SelectedItem.ToString();
                            type types = content.types.First(i => i.TypeName == typename);
                            if (types != null)
                            {
                                int typeID = types.TypeID;
                                txt_typeID1.Text = typeID.ToString();

                            }
                            int TypeID = int.Parse(txt_typeID1.Text);
                            var emp = (from list in content.products
                                       where list.Available == 0 && list.TypeID == TypeID
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types2 = content.types.First(i => i.TypeID == emp2.TypeID);
                                if (types2 != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ProductID, types.TypeName, emp2.ProductName, emp2.StockLevel, emp2.KBStore, emp2.KBdisplay, emp2.TWStore, emp2.TWdisplay);
                                }
                                for (int x = 0; x < dataGridView1.RowCount; x++)
                                {

                                    combobox_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                                }




                            }
                        }
                    }
                }
                else if (radioButton2.Checked == true && comboBox_type.SelectedItem.ToString() !="")
                {
                    dataGridView1.Rows.Clear();
                    combobox_productID.Items.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {
                            string typename = comboBox_type.SelectedItem.ToString();
                            type types = content.types.First(i => i.TypeName == typename);
                            if (types != null)
                            {
                                int typeID = types.TypeID;
                                txt_typeID1.Text = typeID.ToString();

                            }
                            int TypeID = int.Parse(txt_typeID1.Text);
                            var emp = (from list in content.products
                                       where list.Available == 1 && list.TypeID == TypeID
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types2 = content.types.First(i => i.TypeID == emp2.TypeID);
                                if (types2 != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ProductID, types.TypeName, emp2.ProductName, emp2.StockLevel, emp2.KBStore, emp2.KBdisplay, emp2.TWStore, emp2.TWdisplay);
                                }
                                for (int x = 0; x < dataGridView1.RowCount; x++)
                                {

                                    combobox_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                                }




                            }
                        }
                    }
                }

                         
               
                else if (comboBox_type.SelectedItem.ToString() != "" && radioButton3.Checked == true)
                {
                    dataGridView1.Rows.Clear();
                    combobox_productID.Items.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        string typename = comboBox_type.SelectedItem.ToString();
                        type types = content.types.First(i => i.TypeName == typename);
                        if (types != null)
                        {
                            int typeID = types.TypeID;
                            txt_typeID1.Text = typeID.ToString();

                        }

                        {
                            int TypeID = int.Parse(txt_typeID1.Text);

                            var emp = (from list in content.products
                                       where list.TypeID == TypeID
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types2 = content.types.First(i => i.TypeID == emp2.TypeID);
                                if (types2 != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ProductID, types.TypeName, emp2.ProductName, emp2.StockLevel, emp2.KBStore, emp2.KBdisplay, emp2.TWStore, emp2.TWdisplay);
                                }
                            }
                            for (int x = 0; x < dataGridView1.RowCount; x++)
                            {

                                combobox_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                            }
                        }


                    }
                }

                else if (radioButton1.Checked == true)
                {
                    combobox_productID.Items.Clear();
                    dataGridView1.Rows.Clear();
                    combobox_productID.Items.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {

                            var emp = (from list in content.products
                                       where list.Available == 0
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                if (types != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ProductID, types.TypeName, emp2.ProductName, emp2.StockLevel, emp2.KBStore, emp2.KBdisplay, emp2.TWStore, emp2.TWdisplay);
                                }
                            }
                            for (int x = 0; x < dataGridView1.RowCount; x++)
                            {

                                combobox_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                            }
                        }
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    combobox_productID.Items.Clear();
                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {

                            var emp = (from list in content.products
                                       where list.Available == 1
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                if (types != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ProductID, types.TypeName, emp2.ProductName, emp2.StockLevel, emp2.KBStore, emp2.KBdisplay, emp2.TWStore, emp2.TWdisplay);
                                }
                            }
                            for (int x = 0; x < dataGridView1.RowCount; x++)
                            {

                                combobox_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                            }
                        }
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    combobox_productID.Items.Clear();
                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        {

                            var emp = (from list in content.products

                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types = content.types.First(i => i.TypeID == emp2.TypeID);
                                if (types != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ProductID, types.TypeName, emp2.ProductName, emp2.StockLevel, emp2.KBStore, emp2.KBdisplay, emp2.TWStore, emp2.TWdisplay);
                                }
                            }
                            for (int x = 0; x < dataGridView1.RowCount; x++)
                            {

                                combobox_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                            }
                        }
                    }
                }
                else if (comboBox_type.SelectedItem.ToString() != null)
                {
                    combobox_productID.Items.Clear();
                    dataGridView1.Rows.Clear();
                    using (var content = new betterlimitedEntities_Test1())
                    {
                        string typename = comboBox_type.SelectedItem.ToString();
                        type types = content.types.First(i => i.TypeName == typename);
                        if (types != null)
                        {
                            int typeID = types.TypeID;
                            txt_typeID1.Text = typeID.ToString();

                        }

                        {
                            int TypeID = int.Parse(txt_typeID1.Text);

                            var emp = (from list in content.products
                                       where list.TypeID == TypeID
                                       select list);



                            foreach (var emp2 in emp.ToList())
                            {
                                type types2 = content.types.First(i => i.TypeID == emp2.TypeID);
                                if (types2 != null)
                                {

                                    dataGridView1.Rows.Add(emp2.ProductID, types.TypeName, emp2.ProductName, emp2.StockLevel, emp2.KBStore, emp2.KBdisplay, emp2.TWStore, emp2.TWdisplay);
                                }
                            }
                            for (int x = 0; x < dataGridView1.RowCount; x++)
                            {

                                combobox_productID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());

                            }
                        }


                    }
                }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Comfirm all the Boxes are not blanked."); }

        }

        private void btn_available_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("The Product  will be Available after clicking Yes button", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                    {
                        int x = int.Parse(combobox_productID.SelectedItem.ToString());
                        product products = content.products.First(i => i.ProductID == x);
                        if (products != null)
                        {
                            products.Available = 1;
                        }




                        content.SaveChanges();
                        MessageBox.Show("Save ProductID: " + products.ProductID, "Information Successful");
                        //radioButton2.Checked = true;
                        //dataGridView1.DataSource = db.products.Where(y => y.Available == 1).ToList();

                    }
                else { }
            }
            catch (System.NullReferenceException) { MessageBox.Show("Please Select the ProductID that You Want to Edit First"); }


        }

        private void btn_inavailable_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    if (MessageBox.Show("The Product will  be Inavailable after clicking Yes button", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                        {
                            int x = int.Parse(combobox_productID.SelectedItem.ToString());
                            product products = content.products.First(i => i.ProductID == x);
                            if (products != null)
                            {
                                products.Available = 0;
                            }




                            content.SaveChanges();
                            MessageBox.Show("Save ProductID: " + products.ProductID, "Information Successful");
                            //radioButton1.Checked = true;
                            //dataGridView1.DataSource = db.products.Where(y => y.Available == 0).ToList();

                        }
                }
                catch (System.NullReferenceException) { MessageBox.Show("Please Select the ProductID that You Want to Edit First"); }

            }
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmb_storeitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                int productid = int.Parse(combobox_productID.SelectedItem.ToString());
                product p = content.products.First(i => i.ProductID == productid);

                if (cmb_storeitem.SelectedItem.ToString() == "KBStore")
                    txt_amount.Text = p.KBStore.ToString();
                if (cmb_storeitem.SelectedItem.ToString() == "TWStore")
                    txt_amount.Text = p.TWStore.ToString();

            }
        }

        private void cmb_display_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                int productid = int.Parse(combobox_productID.SelectedItem.ToString());
                product p = content.products.First(i => i.ProductID == productid);

                if (cmb_display.SelectedItem.ToString() == "KBdisplay")
                    txt_disAmount.Text = p.KBdisplay.ToString();
                if (cmb_display.SelectedItem.ToString() == "TWdisplay")
                    txt_disAmount.Text = p.TWdisplay.ToString();

            }
        }

        private void comboBox_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
