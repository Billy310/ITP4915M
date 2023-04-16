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
    public partial class Interface_ViewResultOfRequest : Form
    {
        public static Interface_ViewResultOfRequest instance;
        public Label lab1;
        public Interface_ViewResultOfRequest()
        {

            InitializeComponent();
            instance = this;
            lab1 = lab_storeID;
        }

        private void Interface_ViewResultOfRequest_Load(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {

                {
                    int id = int.Parse(lab_storeID.Text);

                    var emp = (from list in content.shoprecoveries
                               where list.StoreID == id
                               select list);



                    foreach (var emp2 in emp.ToList())
                    {
                        {
                            product s = content.products.First(i => i.ProductID == emp2.ProductID);
                            if (s != null) {

                                dataGridView1.Rows.Add(emp2.recoveryid,emp2.dateofcreate, emp2.ProductID,s.ProductName,emp2.Quanity);
                            }
                        }

                    }
                }
                for (int x = 0; x < dataGridView1.RowCount; x++)
                {

                    cb_recoverID.Items.Add(dataGridView1.Rows[x].Cells[0].Value.ToString());
                }
            }
        }

                

        private void btn_getdata_Click(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {
                int id = int.Parse(cb_recoverID.SelectedItem.ToString());
                shoprecovery sc = content.shoprecoveries.First(i => i.recoveryid == id);
                if (sc != null)
                {
                    txt_result.Text = sc.status;
                    if (sc.status == "Accepted")
                    {
                        txt_reason.Visible = false;
                        label2.Visible = true;
                        dateTimePicker_recoverdata.Visible = true;
                        dateTimePicker_recoverdata.Text = sc.dateofrecover.ToString();
                    }
                    if (sc.status == "Refused")
                    {
                        txt_reason.Visible = true;
                        label2.Visible = false;
                        dateTimePicker_recoverdata.Visible = false;
                        txt_reason.Text = sc.Reason;
                    }


                    }
            }
        }
    }
}
