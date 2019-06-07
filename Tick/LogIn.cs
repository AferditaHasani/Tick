using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Reflection;
using System.Resources;
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

     
         }

        CultureInfo ci = new CultureInfo("sq");
        CultureInfo ciEng = new CultureInfo("en-US");
        Assembly a = Assembly.Load("Tick");
    
       

        private UserBLL userBLL = new UserBLL();
        public User activeUser = new User();

        private bool lang = false;
     

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            activeUser = new User
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text,
            };
            activeUser = userBLL.GetLogIn(activeUser);
            if (activeUser != null)
            {
                ResourceManager r = new ResourceManager("Tick.Menu", a);

                if (lang)
                {
                    menu = new Menu(activeUser, this, ci, r);
                }
                else
                {
                    menu = new Menu(activeUser, this, ciEng, r);
                }
                this.Hide();

                menu.Closed += (s, args) => this.Close();
                menu.Show();

            }
            else
            {
                MessageBox.Show("Log In failed");
                ClearText();
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
                ResourceManager r = new ResourceManager("Tick.Menu", a);

                if (lang)
                {
                    menu = new Menu(activeUser, this, ci, r);
                }
                else
                {
                    menu = new Menu(activeUser, this, ciEng, r);
                }
                this.Hide();
              
                menu.Closed += (s, args) => this.Close();
                menu.Show();

             
            }
            else
            {
                MessageBox.Show("Sign In failed");
                ClearText();
            }

          
        }
        private bool SaveSigIn()
        {
            try
            {
                activeUser= GetSignInUser();
                if (activeUser != null)
                {


                    var saved = userBLL.Insert(activeUser);

                    MessageBox.Show(saved ? "Saved Successfully" : "Saving failed , please try again");
                    return true;
                }

                return false;
            }
            catch (Exception e)
            {
             
                return false;
            }
        }

        private User GetSignInUser()
        {
            try
            {
                if (txtName.Text!=""&& txtLastname.Text!=""&& txtUsername.Text!="" && txtPassword.Text!="")
                {


                    User user = new User
                    {

                        Name = txtName.Text,
                        Lastname = txtLastname.Text,

                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        InsertBy = 1,
                        InsertDate = DateTime.Now


                    };
                    return user;
                }
                
                    if (txtPassword.Text.Length < 6)
                    {
                        MessageBox.Show("Password should be 6 characters or longer");
                    }
                    else
                    {
                        MessageBox.Show("Fill all fields");
                    }

                    return null;

            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void ClearText()
        {
            txtName.Text = txtLastname.Text = txtUsername.Text = txtPassword.Text = "";
            activeUser = null;
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("Tick.LogIn", a);

            btnChooseLogIn.Text = rm.GetString("btnChooseLogIn.Text", ciEng);
            btnChooseSigIn.Text = rm.GetString("btnChooseSigIn.Text", ciEng);


            lang = false;
        }

        private void btnSq_Click(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager("Tick.LogIn", a);

            btnChooseLogIn.Text = rm.GetString("btnChooseLogIn.Text", ci);
            btnChooseSigIn.Text = rm.GetString("btnChooseSigIn.Text", ci);
           
         
          

           
           
            lang = true;
        }

    

        private void bunifuButton1_Click_1(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "file:\\C:\\Users\\dita9\\Documents\\Tick\\Tick\\Tick.chm",HelpNavigator.Topic, "IDH_Topic20.htm");
        }
    }
}
