using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Bunifu.DataViz;
using Bunifu.DataViz.WinForms;
using Bunifu.DataViz.WinForms.Properties;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Telerik.WinControls;
using Tick.BLL;

namespace Tick.TimeManagement
{
    public partial class TimeCharts : Telerik.WinControls.UI.RadForm
    {
        public TimeCharts()
        {
            InitializeComponent();
        }

        private TimeTrackingBLL tt_service = new TimeTrackingBLL();

        private void TimeCharts_Load(object sender, EventArgs e)
        {
            FillLineChart(dtpDataGridTime.Value);
          
        }

        private void FillLineChart(DateTime dt)
        {
            DataTable t = tt_service.GetByMonth(dt);


            TimeLineChart.Series.Clear();

            List<string> Tasks = (from p in t.AsEnumerable()
                                  select p.Field<string>("Task")).Distinct().ToList();


            foreach (string task in Tasks)
            {

                string[] color = (from p in t.AsEnumerable()
                                  where p.Field<string>("Task") == task
                                  select p.Field<string>("Color")).ToArray();


                DateTime[] x = (from p in t.AsEnumerable()
                                where p.Field<string>("Task") == task
                                orderby p.Field<DateTime>("Date") ascending
                                select p.Field<DateTime>("Date")).ToArray();


                string[] y = (from p in t.AsEnumerable()
                              where p.Field<string>("Task") == task
                              orderby p.Field<DateTime>("Date") ascending
                              select p.Field<string>("Hours")).ToArray();
                decimal[] j = new decimal[y.Length];
                int counter = 0;
                foreach (var i in y)
                {
                    string z = i.Substring(0, 1);
                    if ("0" == z)
                    {
                        char[] l = i.ToCharArray();

                        z = l[1].ToString() + l[2] + l[3] + l[4];

                    }
                    else
                    {
                        z = i;
                    }
                    j[counter] = decimal.Parse(z);
                    counter++;
                }

                string[] colors = color[0].Split(',');


                TimeLineChart.Series.Add(new Series(task));
                // TimeLineChart.Series[task].IsValueShownAsLabel = true;
                TimeLineChart.Series[task].Color = Color.FromArgb(int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));
                TimeLineChart.Series[task].BorderWidth = 3;
                TimeLineChart.Series[task].ChartType = SeriesChartType.Line;
                TimeLineChart.Series[task].Points.DataBindXY(x, j);
            }

            TimeLineChart.Legends[0].Enabled = true;
        }

        private void dtpDataGridTime_ValueChanged(object sender, EventArgs e)
        {
            FillLineChart(dtpDataGridTime.Value);
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridTime.Value.Year, dtpDataGridTime.Value.Month, dtpDataGridTime.Value.Day-1,0,0,0);
     
            dtpDataGridTime.Value = dt;
            FillLineChart(dtpDataGridTime.Value);

        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridTime.Value.Year, dtpDataGridTime.Value.Month, dtpDataGridTime.Value.Day + 1, 0, 0, 0);

            dtpDataGridTime.Value = dt;
            FillLineChart(dtpDataGridTime.Value);

        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridTime.Value.Year, dtpDataGridTime.Value.Month + 1, dtpDataGridTime.Value.Day , 0, 0, 0);

            dtpDataGridTime.Value = dt;
            FillLineChart(dtpDataGridTime.Value);
        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridTime.Value.Year, dtpDataGridTime.Value.Month - 1, dtpDataGridTime.Value.Day, 0, 0, 0);

            dtpDataGridTime.Value = dt;
            FillLineChart(dtpDataGridTime.Value);
        }
    }
}

