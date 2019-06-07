using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Telerik.WinControls;
using Tick.BLL;
using Tick.BO;

namespace Tick.TimeManagement
{
    public partial class TimeCharts : Telerik.WinControls.UI.RadForm
    {
        public User user;
        public TimeCharts()
        {
            InitializeComponent();
        }
     

        private TimeTrackingBLL tt_service = new TimeTrackingBLL();

        private void TimeCharts_Load(object sender, EventArgs e)
        {
          
        }

       public  void FillLineChart(DateTime dt)
        {
            DataTable t = tt_service.GetByMonth(dt,user.UserID);

            if (t != null)
            {

                TimeLineChart.Series.Clear();

                List<string> Tasks = (from p in t.AsEnumerable()
                    select p.Field<string>("Task")).Distinct().ToList();


                foreach (string task in Tasks)
                {

                    string[] color = (from p in t.AsEnumerable()
                        where p.Field<string>("Task") == task
                        orderby p.Field<DateTime>("Date") ascending
                        select p.Field<string>("Color")).ToArray();


                    DateTime[] x = (from p in t.AsEnumerable()
                        where p.Field<string>("Task") == task
                        orderby p.Field<DateTime>("Date") ascending
                        select p.Field<DateTime>("Date")).ToArray();


                    decimal[] y = (from p in t.AsEnumerable()
                        where p.Field<string>("Task") == task
                        orderby p.Field<DateTime>("Date") ascending
                        select p.Field<decimal>("Hours")).ToArray();


                    string[] colors = color[0].Split(',');


                    TimeLineChart.Series.Add(new Series(task));
                    TimeLineChart.Series[task].IsValueShownAsLabel = true;
                    TimeLineChart.Series[task].Color = Color.FromArgb(int.Parse(colors[1]), int.Parse(colors[2]),
                        int.Parse(colors[3]));
                    TimeLineChart.Series[task].BorderWidth = 3;
                    TimeLineChart.Series[task].ChartType = SeriesChartType.Line;
                    TimeLineChart.Series[task].Points.DataBindXY(x, y);
                }

                TimeLineChart.Legends[0].Enabled = true;
            }
            else
            {
                MessageBox.Show("No records for this date");
            }
        }



        public void FillPieChart(DateTime dt)
        {
            DataTable t = tt_service.GetForPie(dt,user.UserID);


            TimePiechart.Series.Clear();

            
                string[] color = (from p in t.AsEnumerable()
                    orderby p.Field<string>("Task") ascending
                                  select p.Field<string>("Color")).ToArray();


                string[] x = (from p in t.AsEnumerable()
                    orderby p.Field<string>("Task") ascending
                    select p.Field<string>("Task")).ToArray();

                decimal[] y = (from p in t.AsEnumerable()
                    orderby p.Field<string>("Task") ascending
                               select p.Field<decimal>("Hours")).ToArray();

              

               


               TimePiechart.Series.Add(new Series("pie"));
               TimePiechart.Series[0].IsValueShownAsLabel = true;
               
            //   TimePiechart.Series[0].Color = Color.FromArgb(int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));

            TimePiechart.Series[0].ChartType = SeriesChartType.Doughnut;
                TimePiechart.Series[0].Points.DataBindXY(x, y);
                for (int i = 0; i < TimePiechart.Series[0].Points.Count; i++)
                {
                    string[] colors = color[i].Split(',');
                TimePiechart.Series[0].Points[i].Color = Color.FromArgb(int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));
                    
                }
          

            TimePiechart.Legends[0].Enabled = true;
        }





        private void dtpDataGridTime_ValueChanged(object sender, EventArgs e)
        {
            FillLineChart(dtpDataGridTime.Value.Value);
            FillPieChart(dtpDataGridTime.Value.Value);
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridTime.Value.Value.Year, dtpDataGridTime.Value.Value.Month, dtpDataGridTime.Value.Value.Day - 1,0,0,0);
     
            dtpDataGridTime.Value = dt;
            FillLineChart(dtpDataGridTime.Value.Value);
            FillPieChart(dtpDataGridTime.Value.Value);


        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridTime.Value.Value.Year, dtpDataGridTime.Value.Value.Month, dtpDataGridTime.Value.Value.Day + 1, 0, 0, 0);

            dtpDataGridTime.Value = dt;
            FillLineChart(dtpDataGridTime.Value.Value);
            FillPieChart(dtpDataGridTime.Value.Value);


        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridTime.Value.Value.Year, dtpDataGridTime.Value.Value.Month + 1, dtpDataGridTime.Value.Value.Day, 0, 0, 0);

            dtpDataGridTime.Value = dt;
            FillLineChart(dtpDataGridTime.Value.Value);
            FillPieChart(dtpDataGridTime.Value.Value);

        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridTime.Value.Value.Year, dtpDataGridTime.Value.Value.Month - 1, dtpDataGridTime.Value.Value.Day, 0, 0, 0);

            dtpDataGridTime.Value = dt;
            FillLineChart(dtpDataGridTime.Value.Value);
            FillPieChart(dtpDataGridTime.Value.Value);

        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file:\\C:\\Users\\dita9\\Documents\\Tick\\Tick\\Tick.chm", HelpNavigator.Topic, "IDH_Topic60.htm");
        }
    }
}

