using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Telerik.WinControls.Layouts;
using Tick.ExpensesManagment;
using Tick.TimeManagement;

namespace Tick
{
    public partial class Menu : Telerik.WinControls.UI.RadForm
    {
        public Menu()
        {
            InitializeComponent();
            this.Bounds = Screen.PrimaryScreen.Bounds;
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
            TimeTracking t = new TimeTracking();
            FillContentPanel(t);

        }

        private void btnExpensesTracking_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
            ExpensesTracking et=new ExpensesTracking();
            FillContentPanel(et);
        }

        private void btnTimeCharts_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
        }

        private void btnExpensesChart_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
    
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn a = new LogIn();
            a.Show();
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            SeparatorClick(sender);
        }
    }
}
