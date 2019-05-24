using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Tick.BLL;
using Tick.BO;



namespace Tick
{
    public partial class LogIn : Telerik.WinControls.UI.RadForm
    {
        private Menu menu;
        public LogIn()
        {
            InitializeComponent();

        user = null;
         }

        private UserBLL userBLL = new UserBLL();
        public User activeUser = new User();
        private User user;

     

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            user = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
            };
            user = userBLL.GetLogIn(user);
            if (user!=null)
            {
       
                menu = new Menu(user);
                this.Hide();

                menu.Closed += (s, args) => this.Close();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Log In failed");
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnChooseSigIn_Click(object sender, EventArgs e)
        {
            separator1.Visible = true;
            separator.Visible = false;

            pnlForSignIn.Visible = true;
            btnSignIn.Visible = true;
            btnLogIn.Visible = false;

            pnlForSignIn.Location= new Point(79, 269);
            pnlForLogIn.Location = new Point(79, 438);
            btnSignIn.Location = new Point(177, 649);
        }

        private void btnChooseLogIn_Click(object sender, EventArgs e)
        {

            SignInLogInState();

        }


        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SignInLogInState()
        {
            separator.Visible = true;
            separator1.Visible = false;

            pnlForSignIn.Visible = false;
            btnSignIn.Visible = false;
            btnLogIn.Visible = true;

            pnlForLogIn.Location = new Point(79, 313);
            btnLogIn.Location = new Point(187, 611);
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            SignInLogInState();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (SaveSigIn())
            {

                menu=new Menu(user);
                this.Hide();
              
                menu.Closed += (s, args) => this.Close();
                menu.Show();
            }
            else
            {
                MessageBox.Show("Sign In failed");
            }

            this.Close();
        }
        public bool SaveSigIn()
        {
            try
            {
                activeUser= GetSignInUser();
                if (activeUser == null)
                {
                    MessageBox.Show("Error");
                    throw new Exception();
                }

                var saved = userBLL.Insert(activeUser);

                MessageBox.Show(saved ? "Saved Successfully" : "Saving failed , please try again");
                return true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return false;
            }
        }

        public User GetSignInUser()
        {
            try
            {
                user = new User
                {

                    Name = txtName.Text,
                   Lastname = txtLastname.Text,
                   
                    Username = txtUsername.Text,
                    Password= txtPassword.Text,
                    InsertBy = 1,
                    InsertDate = DateTime.Now


                };
                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
