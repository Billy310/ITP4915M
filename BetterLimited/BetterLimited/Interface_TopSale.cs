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
    public partial class Interface_TopSale : Form
    {
        public Interface_TopSale()
        {
            InitializeComponent();
        }

        private void Interface_TopSale_Load(object sender, EventArgs e)
        {
            using (var content = new betterlimitedEntities_Test1())
            {

                dataGridView_staff.Rows.Clear();

                var emp = (from list in content.staffs
                           where list.StoreID == 1
                           select list);
                foreach (var emp2 in emp.ToList())
                {
                    dataGridView_staff.Rows.Add(emp2.StaffID, emp2.Firstname);
                }
                for (int x = 0; x < dataGridView_staff.RowCount; x++)
                {
                    double total = 0;
                    int staffid = int.Parse(dataGridView_staff.Rows[x].Cells[0].Value.ToString());
                    dataGridView_saleorder.Rows.Clear();

                    var a = (from list in content.saleorders
                               where list.staffID==staffid
                               select list);
                    foreach (var a2 in a.ToList())
                    {
                        dataGridView_saleorder.Rows.Add(a2.orderID,a2.TotalCharge);
                    }
                    for (int y = 0; y < dataGridView_saleorder.RowCount; y++) {
                        total += double.Parse(dataGridView_saleorder.Rows[y].Cells[1].Value.ToString());

                    }
                    if (x == 0)
                    {
                        chart1.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), total);

                    }
                    if (x == 1)
                    {
                        chart1.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), total);
                    }
                    if (x == 2)
                    {
                        chart1.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), total);
                    }
                    if (x == 3)
                    {
                        chart1.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), total);
                    }
                    if (x == 4)
                    {
                        chart1.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart2.Series["Kowloon Bay Store"].Points.AddXY(dataGridView_staff.Rows[x].Cells[1].Value.ToString(), total);
                     
                    }

                }

  
                var xy = (from list in content.staffs
                          where list.StoreID == 2
                           select list);
                foreach (var xy2 in xy.ToList())
                {
                    dataGridView_stafftw.Rows.Add(xy2.StaffID, xy2.Firstname);
                }
                for (int x = 0; x < dataGridView_stafftw.RowCount; x++)
                {
                    double total = 0;
                    int staffid = int.Parse(dataGridView_stafftw.Rows[x].Cells[0].Value.ToString());
                    dataGridView_saleorder.Rows.Clear();

                    var a = (from list in content.saleorders
                             where list.staffID == staffid
                             select list);
                    foreach (var a2 in a.ToList())
                    {
                        dataGridView_saleorder.Rows.Add(a2.orderID, a2.TotalCharge);
                    }
                    for (int y = 0; y < dataGridView_saleorder.RowCount; y++)
                    {
                        total += double.Parse(dataGridView_saleorder.Rows[x].Cells[1].Value.ToString());

                    }
                    if (x == 0)
                    {
                        chart3.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart4.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), total);

                    }
                    if (x == 1)
                    {
                        chart3.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart4.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), total);
                    }
                    if (x == 2)
                    {
                        chart3.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart4.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), total);
                    }
                    if (x == 3)
                    {
                        chart3.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart4.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), total);
                    }
                    if (x == 4)
                    {
                        chart3.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), dataGridView_saleorder.RowCount);
                        chart4.Series["Tsuen Wan Store"].Points.AddXY(dataGridView_stafftw.Rows[x].Cells[1].Value.ToString(), total);
                    }

                }
            }
        }
    }
}

