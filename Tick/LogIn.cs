using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tick
{
    public partial class LogIn : Telerik.WinControls.UI.RadForm
    {
        public LogIn()
        {
            InitializeComponent();
        }
        private void btnLogIn_Click(object sender, EventArgs e)
        {


            Menu m = new Menu();
            m.Show();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void btnChooseSigIn_Click(object sender, EventArgs e)
        {
            separator1.Visible = true;
            separator.Visible = false;
        }

        private void btnChooseLogIn_Click(object sender, EventArgs e)
        {
            separator.Visible = true;
            separator1.Visible = false;

        }

        private void pnlForLogIn_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
