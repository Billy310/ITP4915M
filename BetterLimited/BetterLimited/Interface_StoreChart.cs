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
    public partial class Interface_StoreChart : Form
    {
        public Interface_StoreChart()
        {
            InitializeComponent();
        }

        private void Interface_StoreChart_Load(object sender, EventArgs e)
        {
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Month",
                Labels = new[] {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep"
                ,"Oct","Nov","Dec"}
            });
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Revenue",
                LabelFormatter = value => value.ToString("C")
            });
            cartesianChart1.LegendLocation = LiveCharts.LegendLocation.Right;

        }
    }
}
