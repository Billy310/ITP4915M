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
    public partial class Interface_TodaySelling : Form
    {
        public static Interface_TodaySelling instance;
        public Label lab1;
        MySqlConnection Conn = new MySqlConnection(@"datasource=localhost;port=3306;username=root;password=");
        public Interface_TodaySelling()
        {
            InitializeComponent();
            instance = this;
            lab1 = label_storeID;

        }
        private void TopSell_Load(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {

                dataGridView_todaySaleorder.Rows.Clear();

               // label_storeID.Text = "1";
                int storeID = int.Parse(label_storeID.Text);
                var emp = (from list in content.saleorders
                           where list.storeID == storeID
                           select list);
                foreach (var emp2 in emp.ToList())
                {
                        dataGridView_todaySaleorder.Rows.Add(emp2.Date_Of_Purchase,emp2.orderID,emp2.orderType,emp2.TotalCharge,emp2.Addition_Charge,emp2.DepositCharge);
                }
                int depositcount = 0;
                int saleordercount = 0;
                double total = 0;
                for (int x = 0; x < dataGridView_todaySaleorder.RowCount; x++) {
                    if (dataGridView_todaySaleorder.Rows[x].Cells[2].Value.ToString() == "Deposit Order" || dataGridView_todaySaleorder.Rows[x].Cells[2].Value.ToString() == "Deposit Payment")
                    {
                        depositcount++;
                    }
                    if (dataGridView_todaySaleorder.Rows[x].Cells[2].Value.ToString() == "Sale Order" || dataGridView_todaySaleorder.Rows[x].Cells[2].Value.ToString() == "New Item Order")
                    {
                        saleordercount++;
                    }
            if (dataGridView_todaySaleorder.Rows[x].Cells[2].Value.ToString() == "Deposit Order")
                    {
                        total += double.Parse(dataGridView_todaySaleorder.Rows[x].Cells[5].Value.ToString());
                    }
           if (dataGridView_todaySaleorder.Rows[x].Cells[2].Value.ToString() == "Deposit Payment")
                    {
                        total += double.Parse(dataGridView_todaySaleorder.Rows[x].Cells[3].Value.ToString());
                    }
            if (dataGridView_todaySaleorder.Rows[x].Cells[2].Value.ToString() == "Sale Order")
                    {
                        total += double.Parse(dataGridView_todaySaleorder.Rows[x].Cells[3].Value.ToString());
                    }
                  if (dataGridView_todaySaleorder.Rows[x].Cells[2].Value.ToString() == "New Item Order")
                    {
                        total += double.Parse(dataGridView_todaySaleorder.Rows[x].Cells[4].Value.ToString());
                    }

                }
                lab_countd.Text = depositcount.ToString();
                lab_counts.Text = saleordercount.ToString();
                lab_total.Text = total.ToString();

        
                store s = content.stores.First(i => i.StoreID == storeID);
                if (s != null)
                {
                    lab_shop.Text = s.StoreName;

                }
            }
     


        }
    }
}
