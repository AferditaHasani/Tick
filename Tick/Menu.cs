﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Tick.BO;
using Tick.ExpensesManagement;
using Tick.TimeManagement;
using Category = Tick.ExpensesManagement.Category;
using ExpensesTracking = Tick.ExpensesManagement.ExpensesTracking;
using TimeTracking = Tick.TimeManagement.TimeTracking;


namespace Tick
{
    public partial class Menu : Telerik.WinControls.UI.RadForm
    {
        static User user;
        private static LogIn parent;
      static  private CultureInfo c;
       static private ResourceManager rm;
        public Menu()
        {
            InitializeComponent();

            
        }

        public Menu(User u,LogIn p ,CultureInfo ci, ResourceManager r)
        {

            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;
            user = u;
            lblUsername.Text = user.Name;
            et.user =t.user=ct.user=tsk.user=tch.user=ech.user= u;
           p.ClearText();
            parent = p;
            c = ci;
            rm = r;
            ChangeLanguage(r.GetString("btnExpensesChart.Text", ci),
                r.GetString("btnTimeCharts.Text", ci), r.GetString("btnCategory.Text", ci),
                r.GetString("btnTasks.Text", ci), r.GetString("btnExpensesTracking.Text", ci),
                r.GetString("btnLogOut.Text", ci), r.GetString("btnTimeTracking.Text", ci));
        }


        ExpensesTracking et = new ExpensesTracking();
        TimeTracking t = new TimeTracking();
        Category ct = new Category();
        Tasks tsk = new Tasks();
        TimeCharts tch = new TimeCharts();
        ExpensesChart ech = new ExpensesChart();

        public void  ChangeLanguage(string eChart,string tChart, string category,string task, string eTrack,string logout,string tTrack)
        {
            btnExpensesChart.Text = eChart;
            btnTimeCharts.Text = tChart;
            btnCategory.Text = category;
            btnTasks.Text = task;
            btnExpensesTracking.Text = eTrack;
            btnLogOut.Text = logout;
            btnTimeTracking.Text = tTrack;
        }
        //Metoda e cila vendos nje vije para objektit i cili  e therret
        private void SeparatorClick(object sender)
        {
            separator.Visible = true;
            separator.Height = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Height;
            separator.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;
        }
        //Metoda e cila  vendos formen e dhene si parameter ne panelin pnlContent
        private void FillContentPanel(Form f)
        {
            f.TopLevel = false;
            f.Parent = pnlContent;
            f.Dock = DockStyle.Fill;
            f.Show();



            switch (f)
            {
                case ExpensesTracking _:
                    t.Hide();
                    ct.Hide();
                    tsk.Hide();
                    tch.Hide();
                    ech.Hide();
                    break;
                case TimeTracking _:
                    et.Hide();
                    ct.Hide();
                    tsk.Hide();
                    tch.Hide();
                    ech.Hide();
                    break;
                case Tasks _:
                    et.Hide();
                    ct.Hide();
                    t.Hide();
                    tch.Hide();
                    ech.Hide();
                    break;
                case Category _:
                    et.Hide();
                    t.Hide();
                    tsk.Hide();
                    tch.Hide();
                    ech.Hide();
                    break;
                case TimeCharts _:

                    TimeCharts tc = (TimeCharts)f;

                    tc.FillLineChart(tc.dtpDataGridTime.Value.Value);
                    tc.FillPieChart(tc.dtpDataGridTime.Value.Value);
                    et.Hide();
                    t.Hide();
                    tsk.Hide();
                    ct.Hide();
                    ech.Hide();
                    break;
                case ExpensesChart _:

                    ExpensesChart e = (ExpensesChart)f;

                    e.FillLineChart(e.dtpDataGridExpenses.Value.Value);
                    e.FillPieChart(e.dtpDataGridExpenses.Value.Value);

                    t.Hide();
                    ct.Hide();
                    tsk.Hide();
                    tch.Hide();
                    et.Hide();
                    break;
            }


        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnTimeTracking_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
         t.ChangeLanguage(c);
         
         FillContentPanel(t);

        }

        private void btnExpensesTracking_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
          
            FillContentPanel(et);
        }

        private void btnTimeCharts_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
            
            FillContentPanel(tch);
        }

        private void btnExpensesChart_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
        

            FillContentPanel(ech);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            parent.ClearText();
            parent.Show();

        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
           
            FillContentPanel(tsk);

        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
           
            FillContentPanel(ct);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file:\\C:\\Users\\dita9\\Documents\\Tick\\Tick\\Tick.chm");
        }
    }
}
