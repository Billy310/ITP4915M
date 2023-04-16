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
    public partial class Interface_Admin : Form
    {
        public Interface_Admin()
        {
            InitializeComponent();
        }

        private void brn_Create_Click(object sender, EventArgs e)
        {
            Interface_CreateAccount ed = new Interface_CreateAccount();
            ed.Show();
            
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            Interface_EditAccount a = new Interface_EditAccount();
            a.Show();
           
        }

        private void btn_aDelete_Click(object sender, EventArgs e)
        {
         
        }

        private void btn_pCreate_Click(object sender, EventArgs e)
        {
            Interface_CreateProduct p = new Interface_CreateProduct();
            p.Show();
            
        }

        private void btn_pEdit_Click(object sender, EventArgs e)
        {
            Interface_EditProduct p = new Interface_EditProduct();
            p.Show();
            
        }

        private void btn_pDelete_Click(object sender, EventArgs e)
        {
       
           
        }

        private void lab_Product_Click(object sender, EventArgs e)
        {

        }

        private void btn_sCreate_Click(object sender, EventArgs e)
        {
            CreateSupplier p = new CreateSupplier();
            p.Show();
            
        }

        private void btn_sEdit_Click(object sender, EventArgs e)
        {
            Interface_EditStore p = new Interface_EditStore();
            p.Show();
            
        }

        private void btn_sDelete_Click(object sender, EventArgs e)
        {
         
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Create_Store s = new Create_Store();
            s.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Interface_EditSupplier s = new Interface_EditSupplier();
            s.Show();

        }

        private void btn_storedel_Click(object sender, EventArgs e)
        {
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
        

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All Unsaved Information Will Be Lost.", "Logout Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // this.Close();
                Interface_Login login = new Interface_Login();
                login.Show();
                this.Hide();
            }
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Interface_CreateSaleOrder s = new Interface_CreateSaleOrder();
           
            s.Show();
        }
    }
    }

