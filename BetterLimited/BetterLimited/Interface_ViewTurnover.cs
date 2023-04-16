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
    public partial class Interface_ViewTurnover : Form
    {
        public Interface_ViewTurnover()
        {
            InitializeComponent();
        }
        void store1()
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                for (int x = 1; x <= 12; x++)
                {
                    var Day1OfMonth = new DateTime(DateTime.Now.Year, x, 1);
                    lb_month.Items.Add(Day1OfMonth);


                    DateTime firstDayOfMonth = DateTime.Parse(lb_month.Items[x - 1].ToString());
                    var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                    DateTime lastDayOfMonth_dt = DateTime.Parse(lastDayOfMonth.ToString());
                    dataGridView1.Rows.Clear();



                    var emp = (from list in content.saleorders
                               where list.Date_Of_Purchase >= firstDayOfMonth && list.Date_Of_Purchase < lastDayOfMonth_dt && list.storeID == 1 && list.Active=="Active"
                               select list);






                    foreach (var emp2 in emp.ToList())
                    {

                        dataGridView1.Rows.Add(emp2.TotalCharge);

                    }
                    label1.Text = "0";
                    int rowcount = dataGridView1.RowCount;
                    if (x == 1)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));



                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Kowloon Bay Store"].Points.AddXY("Jan", total);

                    }
                    if (x == 2)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Kowloon Bay Store"].Points.AddXY("Feb", total);
                    }
                    if (x == 3)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Kowloon Bay Store"].Points.AddXY("Mar", total);
                    }
                    if (x == 4)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Kowloon Bay Store"].Points.AddXY("Apr", total);
                    }
                    if (x == 5)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Kowloon Bay Store"].Points.AddXY("May", total);
                    }
                    if (x == 6)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Kowloon Bay Store"].Points.AddXY("Jun", total);

                    }
                    if (x == 7)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY("Jul", total);

                    }
                    if (x == 8)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY("Aug", total);

                    }
                    if (x == 9)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY("Step", total);

                    }
                    if (x == 10)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY("Oct", total);

                    }
                    if (x == 11)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY("Nov", total);

                    }
                    if (x == 12)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY("Dec", total);

                    }

                }

            }
        }
        void store2()
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {


                for (int x = 1; x <= 12; x++)
                {
                    var Day1OfMonth = new DateTime(DateTime.Now.Year, x, 1);
                    lb_month.Items.Add(Day1OfMonth);


                    DateTime firstDayOfMonth = DateTime.Parse(lb_month.Items[x - 1].ToString());
                    var lastDayOfMonth = firstDayOfMonth.AddMonths(1).AddDays(-1);
                    DateTime lastDayOfMonth_dt = DateTime.Parse(lastDayOfMonth.ToString());
                    dataGridView1.Rows.Clear();



                    var emp = (from list in content.saleorders
                               where list.Date_Of_Purchase >= firstDayOfMonth && list.Date_Of_Purchase < lastDayOfMonth_dt && list.storeID == 2 && list.Active == "Active"
                               select list);






                    foreach (var emp2 in emp.ToList())
                    {

                        dataGridView1.Rows.Add(emp2.TotalCharge);

                    }
                    label1.Text = "0";
                    int rowcount = dataGridView1.RowCount;
                    if (x == 1)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));



                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Tsuen Wan Store"].Points.AddXY("Jan", total);

                    }
                    if (x == 2)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Tsuen Wan Store"].Points.AddXY("Feb", total);
                    }
                    if (x == 3)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Tsuen Wan Store"].Points.AddXY("Mar", total);
                    }
                    if (x == 4)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Tsuen Wan Store"].Points.AddXY("Apr", total);
                    }
                    if (x == 5)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Tsuen Wan Store"].Points.AddXY("May", total);
                    }
                    if (x == 6)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart1.Series["Tsuen Wan Store"].Points.AddXY("Jun", total);
                    }
                   
                    if (x == 7)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Tsuen Wan Store"].Points.AddXY("Jul", total);

                    }
                    if (x == 8)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Tsuen Wan Store"].Points.AddXY("Aug", total);

                    }
                    if (x == 9)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Tsuen Wan Store"].Points.AddXY("Step", total);

                    }
                    if (x == 10)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Tsuen Wan Store"].Points.AddXY("Oct", total);

                    }
                    if (x == 11)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Tsuen Wan Store"].Points.AddXY("Nov", total);

                    }
                    if (x == 12)
                    {

                        for (int y = 0; y < rowcount; y++)
                        {
                            label1.Text = Convert.ToString(double.Parse(label1.Text) + double.Parse(dataGridView1.Rows[y].Cells[0].Value.ToString()));

                        }
                        double total = double.Parse(label1.Text);
                        chart2.Series["Tsuen Wan Store"].Points.AddXY("Dec", total);

                    }

                }

            }
        }

        private void Interface_ViewSellingProduct_Load(object sender, EventArgs e)
        {

           
         
            store1();
            store2();
           
            }











        }
        }
        
    

