using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (dbchartEntities db = new dbchartEntities())
            {
                ChartRevenue.DataSource = db.Revenues.ToList();
                ChartRevenue.Series["Revenue"].XValueMember = "Year";
                ChartRevenue.Series["Revenue"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
                ChartRevenue.Series["Revenue"].YValueMembers = "Total";
                ChartRevenue.Series["Revenue"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //ChartSalary.Series["Salary"].Points.AddXY("Peter", 1000);
            //ChartSalary.Series["Salary"].Points.AddXY("John", 5000);
            //ChartSalary.Series["Salary"].Points.AddXY("Tan", 1500);
            //ChartSalary.Series["Salary"].Points.AddXY("Manda", 2000);
            ChartSalary.Series["Salary"].Points.Add(1000);
            ChartSalary.Series["Salary"].Points[0].Color = Color.Red;
            ChartSalary.Series["Salary"].Points[0].AxisLabel = "Peter";
            ChartSalary.Series["Salary"].Points[0].LegendText = "Peter";
            ChartSalary.Series["Salary"].Points[0].Label = "1000";

            ChartSalary.Series["Salary"].Points.Add(5000);
            ChartSalary.Series["Salary"].Points[1].Color = Color.Green;
            ChartSalary.Series["Salary"].Points[1].AxisLabel = "John";
            ChartSalary.Series["Salary"].Points[1].LegendText = "John";
            ChartSalary.Series["Salary"].Points[1].Label = "5000";

            ChartSalary.Series["Salary"].Points.Add(1500);
            ChartSalary.Series["Salary"].Points[2].Color = Color.Yellow;
            ChartSalary.Series["Salary"].Points[2].AxisLabel = "Tan";
            ChartSalary.Series["Salary"].Points[2].LegendText = "Tan";
            ChartSalary.Series["Salary"].Points[2].Label = "1500";

            ChartSalary.Series["Salary"].Points.Add(7000);
            ChartSalary.Series["Salary"].Points[3].Color = Color.Blue;
            ChartSalary.Series["Salary"].Points[3].AxisLabel = "Manda";
            ChartSalary.Series["Salary"].Points[3].LegendText = "Manda";
            ChartSalary.Series["Salary"].Points[3].Label = "1000";
        }
    }
}
