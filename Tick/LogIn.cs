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

            pnlForSignIn.Visible = true;
            btnSignIn.Visible = true;
            btnLogIn.Visible = false;

            pnlForSignIn.Location= new Point(361, 242);
            pnlForLogIn.Location = new Point(361, 423);
            btnSignIn.Location = new Point(475, 629);
        }

        private void btnChooseLogIn_Click(object sender, EventArgs e)
        {

            FormInLogInState();

        }


        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormInLogInState()
        {
            separator.Visible = true;
            separator1.Visible = false;

            pnlForSignIn.Visible = false;
            btnSignIn.Visible = false;
            btnLogIn.Visible = true;

            pnlForLogIn.Location = new Point(361, 253);
            btnLogIn.Location = new Point(475, 541);
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            FormInLogInState();
        }
    }
}
