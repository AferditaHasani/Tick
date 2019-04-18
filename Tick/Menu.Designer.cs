namespace Tick
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dragMenuForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragPnlContent = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.dragPnlMenu = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnMini = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnX = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTasks = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLogOut = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExpensesChart = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimeCharts = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnExpensesTracking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTimeTracking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.pnlMenu.Controls.Add(this.btnCategory);
            this.pnlMenu.Controls.Add(this.btnTasks);
            this.pnlMenu.Controls.Add(this.btnLogOut);
            this.pnlMenu.Controls.Add(this.separator);
            this.pnlMenu.Controls.Add(this.btnExpensesChart);
            this.pnlMenu.Controls.Add(this.btnTimeCharts);
            this.pnlMenu.Controls.Add(this.btnExpensesTracking);
            this.pnlMenu.Controls.Add(this.btnTimeTracking);
            this.pnlMenu.Controls.Add(this.lblUsername);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(233, 752);
            this.pnlMenu.TabIndex = 0;
            // 
            // separator
            // 
            this.separator.BackColor = System.Drawing.Color.Transparent;
            this.separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.separator.LineThickness = 5;
            this.separator.Location = new System.Drawing.Point(1, 212);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(10, 56);
            this.separator.TabIndex = 1;
            this.separator.Transparency = 255;
            this.separator.Vertical = true;
            this.separator.Visible = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(53, 115);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(83, 21);
            this.lblUsername.TabIndex = 1;
            this.lblUsername.Text = "Username";
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Location = new System.Drawing.Point(239, 43);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(632, 667);
            this.pnlContent.TabIndex = 8;
            // 
            // dragMenuForm
            // 
            this.dragMenuForm.Fixed = true;
            this.dragMenuForm.Horizontal = true;
            this.dragMenuForm.TargetControl = this;
            this.dragMenuForm.Vertical = true;
            // 
            // dragPnlContent
            // 
            this.dragPnlContent.Fixed = true;
            this.dragPnlContent.Horizontal = true;
            this.dragPnlContent.TargetControl = this.pnlContent;
            this.dragPnlContent.Vertical = true;
            // 
            // dragPnlMenu
            // 
            this.dragPnlMenu.Fixed = true;
            this.dragPnlMenu.Horizontal = true;
            this.dragPnlMenu.TargetControl = this.pnlMenu;
            this.dragPnlMenu.Vertical = true;
            // 
            // btnMini
            // 
            this.btnMini.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMini.BackColor = System.Drawing.Color.Transparent;
            this.btnMini.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMini.BackgroundImage")));
            this.btnMini.ButtonText = "-";
            this.btnMini.ButtonTextMarginLeft = 0;
            this.btnMini.DisabledBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMini.DisabledFillColor = System.Drawing.Color.MediumSpringGreen;
            this.btnMini.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnMini.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnMini.Location = new System.Drawing.Point(798, 12);
            this.btnMini.Name = "btnMini";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnMini.onHoverState = stateProperties1;
            this.btnMini.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMini.Size = new System.Drawing.Size(27, 25);
            this.btnMini.TabIndex = 9;
            this.btnMini.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMini.Click += new System.EventHandler(this.btnMini_Click);
            // 
            // btnX
            // 
            this.btnX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnX.BackColor = System.Drawing.Color.Transparent;
            this.btnX.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnX.BackgroundImage")));
            this.btnX.ButtonText = "X";
            this.btnX.ButtonTextMarginLeft = 0;
            this.btnX.DisabledBorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btnX.DisabledFillColor = System.Drawing.Color.MediumSpringGreen;
            this.btnX.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnX.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnX.Location = new System.Drawing.Point(844, 12);
            this.btnX.Name = "btnX";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnX.onHoverState = stateProperties2;
            this.btnX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnX.Size = new System.Drawing.Size(27, 25);
            this.btnX.TabIndex = 6;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // btnCategory
            // 
            this.btnCategory.Active = false;
            this.btnCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCategory.BorderRadius = 0;
            this.btnCategory.ButtonText = "      Category";
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCategory.Iconimage = global::Tick.Properties.Resources.category;
            this.btnCategory.Iconimage_right = null;
            this.btnCategory.Iconimage_right_Selected = null;
            this.btnCategory.Iconimage_Selected = null;
            this.btnCategory.IconMarginLeft = 15;
            this.btnCategory.IconMarginRight = 0;
            this.btnCategory.IconRightVisible = true;
            this.btnCategory.IconRightZoom = 0D;
            this.btnCategory.IconVisible = true;
            this.btnCategory.IconZoom = 50D;
            this.btnCategory.IsTab = false;
            this.btnCategory.Location = new System.Drawing.Point(3, 373);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnCategory.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCategory.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCategory.selected = false;
            this.btnCategory.Size = new System.Drawing.Size(229, 56);
            this.btnCategory.TabIndex = 6;
            this.btnCategory.Text = "      Category";
            this.btnCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCategory.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnTasks
            // 
            this.btnTasks.Active = false;
            this.btnTasks.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTasks.BorderRadius = 0;
            this.btnTasks.ButtonText = "      Tasks";
            this.btnTasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTasks.DisabledColor = System.Drawing.Color.Gray;
            this.btnTasks.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTasks.Iconimage = global::Tick.Properties.Resources.tasks;
            this.btnTasks.Iconimage_right = null;
            this.btnTasks.Iconimage_right_Selected = null;
            this.btnTasks.Iconimage_Selected = null;
            this.btnTasks.IconMarginLeft = 15;
            this.btnTasks.IconMarginRight = 0;
            this.btnTasks.IconRightVisible = true;
            this.btnTasks.IconRightZoom = 0D;
            this.btnTasks.IconVisible = true;
            this.btnTasks.IconZoom = 45D;
            this.btnTasks.IsTab = false;
            this.btnTasks.Location = new System.Drawing.Point(3, 265);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnTasks.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnTasks.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnTasks.selected = false;
            this.btnTasks.Size = new System.Drawing.Size(229, 56);
            this.btnTasks.TabIndex = 5;
            this.btnTasks.Text = "      Tasks";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnTasks.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Active = true;
            this.btnLogOut.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnLogOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogOut.BorderRadius = 0;
            this.btnLogOut.ButtonText = "    LOG OUT";
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogOut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.btnLogOut.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogOut.Iconimage = global::Tick.Properties.Resources.logout_xxl;
            this.btnLogOut.Iconimage_right = null;
            this.btnLogOut.Iconimage_right_Selected = null;
            this.btnLogOut.Iconimage_Selected = null;
            this.btnLogOut.IconMarginLeft = 0;
            this.btnLogOut.IconMarginRight = 0;
            this.btnLogOut.IconRightVisible = true;
            this.btnLogOut.IconRightZoom = 0D;
            this.btnLogOut.IconVisible = true;
            this.btnLogOut.IconZoom = 90D;
            this.btnLogOut.IsTab = false;
            this.btnLogOut.Location = new System.Drawing.Point(3, 689);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnLogOut.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnLogOut.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogOut.selected = true;
            this.btnLogOut.Size = new System.Drawing.Size(227, 60);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "    LOG OUT";
            this.btnLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnLogOut.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnExpensesChart
            // 
            this.btnExpensesChart.Active = false;
            this.btnExpensesChart.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnExpensesChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnExpensesChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpensesChart.BorderRadius = 0;
            this.btnExpensesChart.ButtonText = "      Expenses Chart";
            this.btnExpensesChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpensesChart.DisabledColor = System.Drawing.Color.Gray;
            this.btnExpensesChart.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExpensesChart.Iconimage = global::Tick.Properties.Resources.EChart;
            this.btnExpensesChart.Iconimage_right = null;
            this.btnExpensesChart.Iconimage_right_Selected = null;
            this.btnExpensesChart.Iconimage_Selected = null;
            this.btnExpensesChart.IconMarginLeft = 0;
            this.btnExpensesChart.IconMarginRight = 0;
            this.btnExpensesChart.IconRightVisible = true;
            this.btnExpensesChart.IconRightZoom = 0D;
            this.btnExpensesChart.IconVisible = true;
            this.btnExpensesChart.IconZoom = 40D;
            this.btnExpensesChart.IsTab = false;
            this.btnExpensesChart.Location = new System.Drawing.Point(3, 485);
            this.btnExpensesChart.Name = "btnExpensesChart";
            this.btnExpensesChart.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnExpensesChart.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnExpensesChart.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExpensesChart.selected = false;
            this.btnExpensesChart.Size = new System.Drawing.Size(229, 56);
            this.btnExpensesChart.TabIndex = 4;
            this.btnExpensesChart.Text = "      Expenses Chart";
            this.btnExpensesChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpensesChart.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExpensesChart.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpensesChart.Click += new System.EventHandler(this.btnExpensesChart_Click);
            // 
            // btnTimeCharts
            // 
            this.btnTimeCharts.Active = false;
            this.btnTimeCharts.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnTimeCharts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnTimeCharts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimeCharts.BorderRadius = 0;
            this.btnTimeCharts.ButtonText = "      Time Charts";
            this.btnTimeCharts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeCharts.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimeCharts.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimeCharts.Iconimage = global::Tick.Properties.Resources.TChart;
            this.btnTimeCharts.Iconimage_right = null;
            this.btnTimeCharts.Iconimage_right_Selected = null;
            this.btnTimeCharts.Iconimage_Selected = null;
            this.btnTimeCharts.IconMarginLeft = 0;
            this.btnTimeCharts.IconMarginRight = 0;
            this.btnTimeCharts.IconRightVisible = true;
            this.btnTimeCharts.IconRightZoom = 0D;
            this.btnTimeCharts.IconVisible = true;
            this.btnTimeCharts.IconZoom = 45D;
            this.btnTimeCharts.IsTab = false;
            this.btnTimeCharts.Location = new System.Drawing.Point(3, 429);
            this.btnTimeCharts.Name = "btnTimeCharts";
            this.btnTimeCharts.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnTimeCharts.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnTimeCharts.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnTimeCharts.selected = false;
            this.btnTimeCharts.Size = new System.Drawing.Size(229, 56);
            this.btnTimeCharts.TabIndex = 3;
            this.btnTimeCharts.Text = "      Time Charts";
            this.btnTimeCharts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeCharts.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnTimeCharts.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeCharts.Click += new System.EventHandler(this.btnTimeCharts_Click);
            // 
            // btnExpensesTracking
            // 
            this.btnExpensesTracking.Active = false;
            this.btnExpensesTracking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnExpensesTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnExpensesTracking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpensesTracking.BorderRadius = 0;
            this.btnExpensesTracking.ButtonText = "      Expenses Tracking";
            this.btnExpensesTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpensesTracking.DisabledColor = System.Drawing.Color.Gray;
            this.btnExpensesTracking.Iconcolor = System.Drawing.Color.Transparent;
            this.btnExpensesTracking.Iconimage = global::Tick.Properties.Resources.dollar;
            this.btnExpensesTracking.Iconimage_right = null;
            this.btnExpensesTracking.Iconimage_right_Selected = null;
            this.btnExpensesTracking.Iconimage_Selected = null;
            this.btnExpensesTracking.IconMarginLeft = 15;
            this.btnExpensesTracking.IconMarginRight = 0;
            this.btnExpensesTracking.IconRightVisible = true;
            this.btnExpensesTracking.IconRightZoom = 0D;
            this.btnExpensesTracking.IconVisible = true;
            this.btnExpensesTracking.IconZoom = 45D;
            this.btnExpensesTracking.IsTab = false;
            this.btnExpensesTracking.Location = new System.Drawing.Point(3, 317);
            this.btnExpensesTracking.Name = "btnExpensesTracking";
            this.btnExpensesTracking.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnExpensesTracking.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnExpensesTracking.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExpensesTracking.selected = false;
            this.btnExpensesTracking.Size = new System.Drawing.Size(229, 56);
            this.btnExpensesTracking.TabIndex = 2;
            this.btnExpensesTracking.Text = "      Expenses Tracking";
            this.btnExpensesTracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExpensesTracking.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnExpensesTracking.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpensesTracking.Click += new System.EventHandler(this.btnExpensesTracking_Click);
            // 
            // btnTimeTracking
            // 
            this.btnTimeTracking.Active = false;
            this.btnTimeTracking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnTimeTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnTimeTracking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimeTracking.BorderRadius = 0;
            this.btnTimeTracking.ButtonText = "      Time Tracking";
            this.btnTimeTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeTracking.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimeTracking.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeTracking.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimeTracking.Iconimage = global::Tick.Properties.Resources.time;
            this.btnTimeTracking.Iconimage_right = null;
            this.btnTimeTracking.Iconimage_right_Selected = null;
            this.btnTimeTracking.Iconimage_Selected = null;
            this.btnTimeTracking.IconMarginLeft = 0;
            this.btnTimeTracking.IconMarginRight = 0;
            this.btnTimeTracking.IconRightVisible = true;
            this.btnTimeTracking.IconRightZoom = 0D;
            this.btnTimeTracking.IconVisible = true;
            this.btnTimeTracking.IconZoom = 45D;
            this.btnTimeTracking.IsTab = false;
            this.btnTimeTracking.Location = new System.Drawing.Point(3, 212);
            this.btnTimeTracking.Name = "btnTimeTracking";
            this.btnTimeTracking.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(31)))), ((int)(((byte)(37)))));
            this.btnTimeTracking.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnTimeTracking.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnTimeTracking.selected = false;
            this.btnTimeTracking.Size = new System.Drawing.Size(229, 56);
            this.btnTimeTracking.TabIndex = 1;
            this.btnTimeTracking.Text = "      Time Tracking";
            this.btnTimeTracking.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimeTracking.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnTimeTracking.TextFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimeTracking.Click += new System.EventHandler(this.btnTimeTracking_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(891, 752);
            this.Controls.Add(this.btnMini);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.pnlMenu);
            this.EnableKeyMap = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(1, 0);
            this.Name = "Menu";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUsername;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimeTracking;
        private Bunifu.Framework.UI.BunifuFlatButton btnExpensesChart;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimeCharts;
        private Bunifu.Framework.UI.BunifuFlatButton btnExpensesTracking;
        private Bunifu.Framework.UI.BunifuSeparator separator;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogOut;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnX;
        private System.Windows.Forms.Panel pnlContent;
        private Bunifu.Framework.UI.BunifuDragControl dragMenuForm;
        private Bunifu.Framework.UI.BunifuDragControl dragPnlContent;
        private Bunifu.Framework.UI.BunifuDragControl dragPnlMenu;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMini;
        private Bunifu.Framework.UI.BunifuFlatButton btnTasks;
        private Bunifu.Framework.UI.BunifuFlatButton btnCategory;
    }
}
