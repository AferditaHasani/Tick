﻿namespace Tick
{
    partial class LogIn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.dragLogIn = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragpnlSide = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnlSide = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlLogInContent = new System.Windows.Forms.Panel();
            this.btnSq = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnSignIn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnEng = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnLogIn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlForSignIn = new System.Windows.Forms.Panel();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtLastname = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.separator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.pnlForLogIn = new System.Windows.Forms.Panel();
            this.txtUsername = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.txtPassword = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnChooseLogIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnChooseSigIn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMini = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnX = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pbLogIn = new System.Windows.Forms.PictureBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.pnlLogInContent.SuspendLayout();
            this.pnlForSignIn.SuspendLayout();
            this.pnlForLogIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dragLogIn
            // 
            this.dragLogIn.Fixed = true;
            this.dragLogIn.Horizontal = true;
            this.dragLogIn.TargetControl = this;
            this.dragLogIn.Vertical = true;
            // 
            // dragpnlSide
            // 
            this.dragpnlSide.Fixed = true;
            this.dragpnlSide.Horizontal = true;
            this.dragpnlSide.TargetControl = this.pnlSide;
            this.dragpnlSide.Vertical = true;
            // 
            // pnlSide
            // 
            resources.ApplyResources(this.pnlSide, "pnlSide");
            this.pnlSide.Controls.Add(this.pbLogo);
            this.pnlSide.GradientBottomLeft = System.Drawing.Color.ForestGreen;
            this.pnlSide.GradientBottomRight = System.Drawing.Color.LightCyan;
            this.pnlSide.GradientTopLeft = System.Drawing.Color.MediumSeaGreen;
            this.pnlSide.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Quality = 10;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = global::Tick.Properties.Resources.logo1;
            resources.ApplyResources(this.pbLogo, "pbLogo");
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.TabStop = false;
            // 
            // pnlLogInContent
            // 
            this.pnlLogInContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.pnlLogInContent.Controls.Add(this.bunifuButton1);
            this.pnlLogInContent.Controls.Add(this.btnSq);
            this.pnlLogInContent.Controls.Add(this.btnSignIn);
            this.pnlLogInContent.Controls.Add(this.btnEng);
            this.pnlLogInContent.Controls.Add(this.btnLogIn);
            this.pnlLogInContent.Controls.Add(this.pnlForSignIn);
            this.pnlLogInContent.Controls.Add(this.separator1);
            this.pnlLogInContent.Controls.Add(this.pnlForLogIn);
            this.pnlLogInContent.Controls.Add(this.separator);
            this.pnlLogInContent.Controls.Add(this.btnChooseLogIn);
            this.pnlLogInContent.Controls.Add(this.btnChooseSigIn);
            this.pnlLogInContent.Controls.Add(this.btnMini);
            this.pnlLogInContent.Controls.Add(this.btnX);
            this.pnlLogInContent.Controls.Add(this.pbLogIn);
            resources.ApplyResources(this.pnlLogInContent, "pnlLogInContent");
            this.pnlLogInContent.Name = "pnlLogInContent";
            // 
            // btnSq
            // 
            this.btnSq.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSq, "btnSq");
            this.btnSq.ButtonText = "";
            this.btnSq.ButtonTextMarginLeft = 0;
            this.btnSq.CausesValidation = false;
            this.btnSq.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnSq.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnSq.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSq.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSq.IconPadding = 0;
            this.btnSq.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSq.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnSq.IdleBorderRadius = 1;
            this.btnSq.IdleBorderThickness = 0;
            this.btnSq.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnSq.IdleIconLeftImage = global::Tick.Properties.Resources.sq;
            this.btnSq.IdleIconRightImage = null;
            this.btnSq.Name = "btnSq";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnSq.onHoverState = stateProperties2;
            this.btnSq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSq.Click += new System.EventHandler(this.btnSq_Click);
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnSignIn, "btnSignIn");
            this.btnSignIn.ButtonText = "SIGNUP";
            this.btnSignIn.ButtonTextMarginLeft = 0;
            this.btnSignIn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSignIn.DisabledFillColor = System.Drawing.Color.DimGray;
            this.btnSignIn.DisabledForecolor = System.Drawing.Color.White;
            this.btnSignIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnSignIn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignIn.IconPadding = 10;
            this.btnSignIn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnSignIn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnSignIn.IdleBorderRadius = 15;
            this.btnSignIn.IdleBorderThickness = 2;
            this.btnSignIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSignIn.IdleIconLeftImage = null;
            this.btnSignIn.IdleIconRightImage = null;
            this.btnSignIn.Name = "btnSignIn";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties3.BorderRadius = 1;
            stateProperties3.BorderThickness = 2;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.btnSignIn.onHoverState = stateProperties3;
            this.btnSignIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            this.btnSignIn.Enter += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnEng
            // 
            this.btnEng.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnEng, "btnEng");
            this.btnEng.ButtonText = "";
            this.btnEng.ButtonTextMarginLeft = 0;
            this.btnEng.CausesValidation = false;
            this.btnEng.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnEng.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnEng.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnEng.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnEng.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEng.IconPadding = 0;
            this.btnEng.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEng.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnEng.IdleBorderRadius = 1;
            this.btnEng.IdleBorderThickness = 0;
            this.btnEng.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnEng.IdleIconLeftImage = global::Tick.Properties.Resources.uk;
            this.btnEng.IdleIconRightImage = null;
            this.btnEng.Name = "btnEng";
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties4.BorderRadius = 1;
            stateProperties4.BorderThickness = 1;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.btnEng.onHoverState = stateProperties4;
            this.btnEng.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEng.Click += new System.EventHandler(this.btnEng_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnLogIn, "btnLogIn");
            this.btnLogIn.ButtonText = "LOGIN";
            this.btnLogIn.ButtonTextMarginLeft = 0;
            this.btnLogIn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnLogIn.DisabledFillColor = System.Drawing.Color.DimGray;
            this.btnLogIn.DisabledForecolor = System.Drawing.Color.White;
            this.btnLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnLogIn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogIn.IconPadding = 10;
            this.btnLogIn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnLogIn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnLogIn.IdleBorderRadius = 15;
            this.btnLogIn.IdleBorderThickness = 2;
            this.btnLogIn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnLogIn.IdleIconLeftImage = null;
            this.btnLogIn.IdleIconRightImage = null;
            this.btnLogIn.Name = "btnLogIn";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties5.BorderRadius = 1;
            stateProperties5.BorderThickness = 2;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.btnLogIn.onHoverState = stateProperties5;
            this.btnLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            this.btnLogIn.Enter += new System.EventHandler(this.btnLogIn_Click);
            // 
            // pnlForSignIn
            // 
            this.pnlForSignIn.Controls.Add(this.txtName);
            this.pnlForSignIn.Controls.Add(this.txtLastname);
            resources.ApplyResources(this.pnlForSignIn, "pnlForSignIn");
            this.pnlForSignIn.Name = "pnlForSignIn";
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtName.BorderRadius = 15;
            this.txtName.BorderThickness = 2;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = global::Tick.Properties.Resources.user2;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.MaxLength = 32767;
            this.txtName.Modified = false;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "Name";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // txtLastname
            // 
            this.txtLastname.AcceptsReturn = false;
            this.txtLastname.AcceptsTab = false;
            this.txtLastname.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtLastname.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtLastname.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtLastname, "txtLastname");
            this.txtLastname.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtLastname.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtLastname.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtLastname.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtLastname.BorderRadius = 15;
            this.txtLastname.BorderThickness = 2;
            this.txtLastname.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtLastname.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtLastname.DefaultText = "";
            this.txtLastname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtLastname.HideSelection = true;
            this.txtLastname.IconLeft = global::Tick.Properties.Resources.user2;
            this.txtLastname.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtLastname.IconPadding = 10;
            this.txtLastname.IconRight = null;
            this.txtLastname.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtLastname.MaxLength = 32767;
            this.txtLastname.Modified = false;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.ReadOnly = false;
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.ShortcutsEnabled = true;
            this.txtLastname.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLastname.TextMarginLeft = 5;
            this.txtLastname.TextPlaceholder = "Lastname";
            this.txtLastname.UseSystemPasswordChar = false;
            // 
            // separator1
            // 
            this.separator1.BackColor = System.Drawing.Color.Transparent;
            this.separator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.separator1.LineThickness = 5;
            resources.ApplyResources(this.separator1, "separator1");
            this.separator1.Name = "separator1";
            this.separator1.Transparency = 255;
            this.separator1.Vertical = true;
            // 
            // pnlForLogIn
            // 
            this.pnlForLogIn.Controls.Add(this.txtUsername);
            this.pnlForLogIn.Controls.Add(this.txtPassword);
            resources.ApplyResources(this.pnlForLogIn, "pnlForLogIn");
            this.pnlForLogIn.Name = "pnlForLogIn";
            // 
            // txtUsername
            // 
            this.txtUsername.AcceptsReturn = false;
            this.txtUsername.AcceptsTab = false;
            this.txtUsername.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtUsername.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtUsername, "txtUsername");
            this.txtUsername.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtUsername.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtUsername.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtUsername.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtUsername.BorderRadius = 15;
            this.txtUsername.BorderThickness = 2;
            this.txtUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUsername.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsername.DefaultText = "";
            this.txtUsername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtUsername.HideSelection = true;
            this.txtUsername.IconLeft = global::Tick.Properties.Resources.username1;
            this.txtUsername.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtUsername.IconPadding = 10;
            this.txtUsername.IconRight = null;
            this.txtUsername.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtUsername.MaxLength = 32767;
            this.txtUsername.Modified = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.ReadOnly = false;
            this.txtUsername.SelectedText = "";
            this.txtUsername.SelectionLength = 0;
            this.txtUsername.SelectionStart = 0;
            this.txtUsername.ShortcutsEnabled = true;
            this.txtUsername.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.TextMarginLeft = 5;
            this.txtUsername.TextPlaceholder = "Username";
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            this.txtPassword.AcceptsReturn = false;
            this.txtPassword.AcceptsTab = false;
            this.txtPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtPassword, "txtPassword");
            this.txtPassword.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPassword.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(107)))));
            this.txtPassword.BorderRadius = 15;
            this.txtPassword.BorderThickness = 2;
            this.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPassword.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.DefaultText = "";
            this.txtPassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtPassword.HideSelection = true;
            this.txtPassword.IconLeft = global::Tick.Properties.Resources.Password2;
            this.txtPassword.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.IconPadding = 10;
            this.txtPassword.IconRight = null;
            this.txtPassword.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtPassword.MaxLength = 32767;
            this.txtPassword.Modified = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.ReadOnly = false;
            this.txtPassword.SelectedText = "";
            this.txtPassword.SelectionLength = 0;
            this.txtPassword.SelectionStart = 0;
            this.txtPassword.ShortcutsEnabled = true;
            this.txtPassword.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.TextMarginLeft = 5;
            this.txtPassword.TextPlaceholder = "Password";
            this.txtPassword.UseSystemPasswordChar = false;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.Transparent;
            this.separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.separator.LineThickness = 5;
            resources.ApplyResources(this.separator, "separator");
            this.separator.Name = "separator";
            this.separator.Transparency = 255;
            this.separator.Vertical = true;
            // 
            // btnChooseLogIn
            // 
            this.btnChooseLogIn.Active = false;
            this.btnChooseLogIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChooseLogIn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnChooseLogIn, "btnChooseLogIn");
            this.btnChooseLogIn.BorderRadius = 0;
            this.btnChooseLogIn.ButtonText = "LogIn";
            this.btnChooseLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseLogIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnChooseLogIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChooseLogIn.Iconimage = null;
            this.btnChooseLogIn.Iconimage_right = null;
            this.btnChooseLogIn.Iconimage_right_Selected = null;
            this.btnChooseLogIn.Iconimage_Selected = null;
            this.btnChooseLogIn.IconMarginLeft = 0;
            this.btnChooseLogIn.IconMarginRight = 0;
            this.btnChooseLogIn.IconRightVisible = true;
            this.btnChooseLogIn.IconRightZoom = 0D;
            this.btnChooseLogIn.IconVisible = true;
            this.btnChooseLogIn.IconZoom = 90D;
            this.btnChooseLogIn.IsTab = false;
            this.btnChooseLogIn.Name = "btnChooseLogIn";
            this.btnChooseLogIn.Normalcolor = System.Drawing.Color.Transparent;
            this.btnChooseLogIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChooseLogIn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnChooseLogIn.selected = false;
            this.btnChooseLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseLogIn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnChooseLogIn.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseLogIn.Click += new System.EventHandler(this.btnChooseLogIn_Click);
            // 
            // btnChooseSigIn
            // 
            this.btnChooseSigIn.Active = false;
            this.btnChooseSigIn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnChooseSigIn.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnChooseSigIn, "btnChooseSigIn");
            this.btnChooseSigIn.BorderRadius = 0;
            this.btnChooseSigIn.ButtonText = "SignUp";
            this.btnChooseSigIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseSigIn.DisabledColor = System.Drawing.Color.Gray;
            this.btnChooseSigIn.Iconcolor = System.Drawing.Color.Transparent;
            this.btnChooseSigIn.Iconimage = null;
            this.btnChooseSigIn.Iconimage_right = null;
            this.btnChooseSigIn.Iconimage_right_Selected = null;
            this.btnChooseSigIn.Iconimage_Selected = null;
            this.btnChooseSigIn.IconMarginLeft = 0;
            this.btnChooseSigIn.IconMarginRight = 0;
            this.btnChooseSigIn.IconRightVisible = true;
            this.btnChooseSigIn.IconRightZoom = 0D;
            this.btnChooseSigIn.IconVisible = true;
            this.btnChooseSigIn.IconZoom = 90D;
            this.btnChooseSigIn.IsTab = false;
            this.btnChooseSigIn.Name = "btnChooseSigIn";
            this.btnChooseSigIn.Normalcolor = System.Drawing.Color.Transparent;
            this.btnChooseSigIn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnChooseSigIn.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnChooseSigIn.selected = false;
            this.btnChooseSigIn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChooseSigIn.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnChooseSigIn.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseSigIn.Click += new System.EventHandler(this.btnChooseSigIn_Click);
            // 
            // btnMini
            // 
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnMini, "btnMini");
            this.btnMini.ButtonText = "-";
            this.btnMini.ButtonTextMarginLeft = 0;
            this.btnMini.CausesValidation = false;
            this.btnMini.DisabledBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMini.DisabledFillColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMini.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnMini.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnMini.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMini.IconPadding = 10;
            this.btnMini.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMini.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnMini.IdleBorderRadius = 1;
            this.btnMini.IdleBorderThickness = 0;
            this.btnMini.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnMini.IdleIconLeftImage = null;
            this.btnMini.IdleIconRightImage = null;
            this.btnMini.Name = "btnMini";
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties6.BorderRadius = 1;
            stateProperties6.BorderThickness = 1;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.btnMini.onHoverState = stateProperties6;
            this.btnMini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnX, "btnX");
            this.btnX.ButtonText = "X";
            this.btnX.ButtonTextMarginLeft = 0;
            this.btnX.DisabledBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnX.DisabledFillColor = System.Drawing.Color.MediumSpringGreen;
            this.btnX.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnX.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnX.IconPadding = 10;
            this.btnX.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnX.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnX.IdleBorderRadius = 1;
            this.btnX.IdleBorderThickness = 0;
            this.btnX.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnX.IdleIconLeftImage = null;
            this.btnX.IdleIconRightImage = null;
            this.btnX.Name = "btnX";
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties7.BorderRadius = 1;
            stateProperties7.BorderThickness = 1;
            stateProperties7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties7.IconLeftImage = null;
            stateProperties7.IconRightImage = null;
            this.btnX.onHoverState = stateProperties7;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // pbLogIn
            // 
            this.pbLogIn.BackColor = System.Drawing.Color.Transparent;
            this.pbLogIn.Image = global::Tick.Properties.Resources.Power;
            resources.ApplyResources(this.pbLogIn, "pbLogIn");
            this.pbLogIn.Name = "pbLogIn";
            this.pbLogIn.TabStop = false;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnlLogInContent;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuButton1
            // 
            resources.ApplyResources(this.bunifuButton1, "bunifuButton1");
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.ButtonText = "";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.bunifuButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 0;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.bunifuButton1.IdleBorderRadius = 1;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.bunifuButton1.IdleIconLeftImage = global::Tick.Properties.Resources.icons8_help_48;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties1;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click_1);
            // 
            // LogIn
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.Controls.Add(this.pnlLogInContent);
            this.Controls.Add(this.pnlSide);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.pnlSide.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.pnlLogInContent.ResumeLayout(false);
            this.pnlForSignIn.ResumeLayout(false);
            this.pnlForLogIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl dragLogIn;
        private Bunifu.Framework.UI.BunifuGradientPanel pnlSide;
        private System.Windows.Forms.PictureBox pbLogo;
        private Bunifu.Framework.UI.BunifuDragControl dragpnlSide;
        private System.Windows.Forms.Panel pnlLogInContent;
        protected internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSignIn;
        protected internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnLogIn;
        private System.Windows.Forms.Panel pnlForSignIn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtLastname;
        private Bunifu.Framework.UI.BunifuSeparator separator1;
        private System.Windows.Forms.Panel pnlForLogIn;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtUsername;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtPassword;
        private Bunifu.Framework.UI.BunifuSeparator separator;
        private Bunifu.Framework.UI.BunifuFlatButton btnChooseLogIn;
        private Bunifu.Framework.UI.BunifuFlatButton btnChooseSigIn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMini;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnX;
        private System.Windows.Forms.PictureBox pbLogIn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEng;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnSq;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}