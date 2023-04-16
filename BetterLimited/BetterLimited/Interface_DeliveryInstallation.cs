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
    public partial class Interface_DeliveryInstallation : Form
    {
        public Interface_DeliveryInstallation()
        {
            InitializeComponent();
        }

        private void btn_view_Click(object sender, EventArgs e)
        {
            using (betterlimitedEntities_Test1 content = new betterlimitedEntities_Test1())
            {
                

                RTBox_d1.Clear();
                RTBox_d1.Text += "Morning:\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Afternoon:\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Evening:\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";
                RTBox_d1.Text += "Order: 12   DWorker: 13   Dtime: 9:00am-10:00am   IWorker: 13   Itime: 11:00-12:00pm\n";


            }
        }
    }
}
