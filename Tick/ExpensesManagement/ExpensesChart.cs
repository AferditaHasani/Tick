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

namespace Tick.ExpensesManagement
{
    public partial class ExpensesChart : Telerik.WinControls.UI.RadForm
    {
        public User user;

        public ExpensesChart()
        {
            InitializeComponent();
        }
      

        
        private ExpensesTrackingBLL tt_service = new ExpensesTrackingBLL();

       

        public void FillLineChart(DateTime dt)
        {
            DataTable t = tt_service.GetByMonth(dt,user.UserID);

            if (t != null)
            {

                ExpensesLineChart.Series.Clear();

                List<string> Category = (from p in t.AsEnumerable()
                                      select p.Field<string>("Category")).Distinct().ToList();


                foreach (string category in Category)
                {

                    string[] color = (from p in t.AsEnumerable()
                                      where p.Field<string>("Category") == category
                                      orderby p.Field<DateTime>("Date") ascending
                                      select p.Field<string>("Color")).ToArray();


                    DateTime[] x = (from p in t.AsEnumerable()
                                    where p.Field<string>("Category") == category
                                    orderby p.Field<DateTime>("Date") ascending
                                    select p.Field<DateTime>("Date")).ToArray();


                    decimal[] y = (from p in t.AsEnumerable()
                                   where p.Field<string>("Category") == category
                                   orderby p.Field<DateTime>("Date") ascending
                                   select p.Field<decimal>("Amount")).ToArray();


                    string[] colors = color[0].Split(',');


                    ExpensesLineChart.Series.Add(new Series(category));
                    ExpensesLineChart.Series[category].IsValueShownAsLabel = true;
                    ExpensesLineChart.Series[category].Color = Color.FromArgb(int.Parse(colors[1]), int.Parse(colors[2]),
                        int.Parse(colors[3]));
                    ExpensesLineChart.Series[category].BorderWidth = 3;
                    ExpensesLineChart.Series[category].ChartType = SeriesChartType.Line;
                    ExpensesLineChart.Series[category].Points.DataBindXY(x, y);
                }

                ExpensesLineChart.Legends[0].Enabled = true;
            }
            else
            {
                MessageBox.Show("No records for this date");
            }
        }

     

        public void FillPieChart(DateTime dt)
        {
            DataTable t = tt_service.GetForPie(dt,user.UserID);


            ExpensesPiechart.Series.Clear();


            string[] color = (from p in t.AsEnumerable()
                              orderby p.Field<string>("Category") ascending
                              select p.Field<string>("Color")).ToArray();


            string[] x = (from p in t.AsEnumerable()
                          orderby p.Field<string>("Category") ascending
                          select p.Field<string>("Category")).ToArray();

            decimal[] y = (from p in t.AsEnumerable()
                           orderby p.Field<string>("Category") ascending
                           select p.Field<decimal>("Amount")).ToArray();






            ExpensesPiechart.Series.Add(new Series("pie"));
            ExpensesPiechart.Series[0].IsValueShownAsLabel = true;



            ExpensesPiechart.Series[0].ChartType = SeriesChartType.Doughnut;
            ExpensesPiechart.Series[0].Points.DataBindXY(x, y);
            for (int i = 0; i < ExpensesPiechart.Series[0].Points.Count; i++)
            {
                string[] colors = color[i].Split(',');
                ExpensesPiechart.Series[0].Points[i].Color = Color.FromArgb(int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));

            }


            ExpensesPiechart.Legends[0].Enabled = true;
        }






        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridExpenses.Value.Value.Year, dtpDataGridExpenses.Value.Value.Month, dtpDataGridExpenses.Value.Value.Day - 1, 0, 0, 0);

            dtpDataGridExpenses.Value = dt;
            FillLineChart(dtpDataGridExpenses.Value.Value);
            FillPieChart(dtpDataGridExpenses.Value.Value);


        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridExpenses.Value.Value.Year, dtpDataGridExpenses.Value.Value.Month, dtpDataGridExpenses.Value.Value.Day + 1, 0, 0, 0);

            dtpDataGridExpenses.Value = dt;
            FillLineChart(dtpDataGridExpenses.Value.Value);
            FillPieChart(dtpDataGridExpenses.Value.Value);


        }

        private void btnNextMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridExpenses.Value.Value.Year, dtpDataGridExpenses.Value.Value.Month + 1, dtpDataGridExpenses.Value.Value.Day, 0, 0, 0);

            dtpDataGridExpenses.Value = dt;
            FillLineChart(dtpDataGridExpenses.Value.Value);
            FillPieChart(dtpDataGridExpenses.Value.Value);
     

        }

        private void btnPreviousMonth_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(dtpDataGridExpenses.Value.Value.Year, dtpDataGridExpenses.Value.Value.Month - 1, dtpDataGridExpenses.Value.Value.Day, 0, 0, 0);

            dtpDataGridExpenses.Value = dt;
            FillLineChart(dtpDataGridExpenses.Value.Value);
            FillPieChart(dtpDataGridExpenses.Value.Value);
           

        }

        private void dtpDataGridExpenses_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            FillLineChart(dtpDataGridExpenses.Value.Value);
            FillPieChart(dtpDataGridExpenses.Value.Value);
      
        }

        private void btnHelpECharts_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file:\\C:\\Users\\dita9\\Documents\\Tick\\Tick\\Tick.chm", HelpNavigator.Topic, "IDH_Topic100.htm");

        }
    }
}
