using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Tick
{
    public partial class Menu : Telerik.WinControls.UI.RadForm
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void BtnSeperator_Click(object sender, EventArgs e)
        {
            separator.Visible = true;
            separator.Height = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Height;
            separator.Top = ((Bunifu.Framework.UI.BunifuFlatButton)sender).Top;

        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
