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
    public partial class aDelete : Form
    {
        public aDelete()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            {
                int a;
                a = int.Parse(txt_StaffID.Text);
                using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
                {
                    staff s = content.staffs.First(i => i.StaffID == a);
                    if (s != null)
                    {
                        txt_Username.Text = s.Username;
                        


                    }

                }
            }
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {
            if (txt_Username.Text != null) {
                txt_Username.Enabled = false;
            }
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                int a;
                a = int.Parse(txt_StaffID.Text);
                staff s = content.staffs.First(i => i.StaffID == a);
                if (s != null) {
                    s.Able = 0;

                }
                content.SaveChanges();
                MessageBox.Show("Delete Account:"+txt_Username.Text+"!");
            }
            }

        private void btn_create_Click(object sender, EventArgs e)
        {
            aCreate a = new aCreate();
            a.Show();
            this.Hide();

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            aEdit a = new aEdit();
            a.Show();
            this.Hide();
        }
    }
}
