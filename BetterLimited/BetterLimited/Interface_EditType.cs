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
    public partial class Interface_EditType : Form
    {
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Interface_EditType()
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
                    cb_selectype.Items.Add(subj);

                }
                Conn.Close();


            }
            catch (Exception)
            {
                MessageBox.Show("TypeName ERROR");

            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                string typename = cb_selectype.SelectedItem.ToString();
                type types = content.types.First(i => i.TypeName== typename);
                if (cb_selectype.SelectedItem.ToString() != "")
                {
                    if (types != null)
                    {
                        txt_Typename.Text = types.TypeName;
                        //lowstocklevel_count.Value = types.LowStockLevel;
                        txt_TID.Text = types.TypeID.ToString();
                      
                    }

                }
            }
        }

        private void EditType_Load(object sender, EventArgs e)
        {
            cb_selectype.DropDownStyle = ComboBoxStyle.DropDownList;
            add2Type();
            using (var content = new betterlimitedEntities_Test1())
            {
                {

                    var emp = (from list in content.types
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                  
                 

                            dataGridView1.Rows.Add(emp2.TypeID,emp2.TypeName);
                        
                    }
                }
            }
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
              
            {
                int typeID = int.Parse(txt_TID.Text);
                type types= content.types.First(i => i.TypeID == typeID);
                if (types!= null)
                {
                   // types.LowStockLevel = int.Parse(lowstocklevel_count.Value.ToString());
                    types.TypeName = txt_Typename.Text;

                    

                }
                content.SaveChanges();

            }
          
        }
        }
}
