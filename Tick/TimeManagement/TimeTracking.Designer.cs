namespace Tick.TimeManagement
{
    partial class TimeTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTracking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pnlAddWorkUnit = new System.Windows.Forms.Panel();
            this.rtxtTimeDescription = new System.Windows.Forms.RichTextBox();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ddEndMinute = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ddEndHour = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblEndTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ddStartMinute = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ddStartHour = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblStartTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpTimeTrackingDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.lblTimeTrackingDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTask = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDeleteTimeTracking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveTimeTracking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ddTask = new Bunifu.UI.WinForms.BunifuDropdown();
            this.pnlSearchByDate = new System.Windows.Forms.Panel();
            this.dtpDataGridTime = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnPreviousDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNextDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddTimeTracking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvWorkUnits = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlAddWorkUnit.SuspendLayout();
            this.pnlSearchByDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddWorkUnit
            // 
            resources.ApplyResources(this.pnlAddWorkUnit, "pnlAddWorkUnit");
            this.pnlAddWorkUnit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.pnlAddWorkUnit.Controls.Add(this.rtxtTimeDescription);
            this.pnlAddWorkUnit.Controls.Add(this.btnCancel);
            this.pnlAddWorkUnit.Controls.Add(this.ddEndMinute);
            this.pnlAddWorkUnit.Controls.Add(this.ddEndHour);
            this.pnlAddWorkUnit.Controls.Add(this.lblEndTime);
            this.pnlAddWorkUnit.Controls.Add(this.ddStartMinute);
            this.pnlAddWorkUnit.Controls.Add(this.ddStartHour);
            this.pnlAddWorkUnit.Controls.Add(this.lblStartTime);
            this.pnlAddWorkUnit.Controls.Add(this.dpTimeTrackingDate);
            this.pnlAddWorkUnit.Controls.Add(this.lblTimeTrackingDate);
            this.pnlAddWorkUnit.Controls.Add(this.lblDescription);
            this.pnlAddWorkUnit.Controls.Add(this.lblTask);
            this.pnlAddWorkUnit.Controls.Add(this.btnDeleteTimeTracking);
            this.pnlAddWorkUnit.Controls.Add(this.btnSaveTimeTracking);
            this.pnlAddWorkUnit.Controls.Add(this.ddTask);
            this.pnlAddWorkUnit.Name = "pnlAddWorkUnit";
            // 
            // rtxtTimeDescription
            // 
            this.rtxtTimeDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.rtxtTimeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.rtxtTimeDescription, "rtxtTimeDescription");
            this.rtxtTimeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.rtxtTimeDescription.Name = "rtxtTimeDescription";
            // 
            // btnCancel
            // 
            this.btnCancel.Active = false;
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancel.Iconimage = global::Tick.Properties.Resources.cancel;
            this.btnCancel.Iconimage_right = null;
            this.btnCancel.Iconimage_right_Selected = null;
            this.btnCancel.Iconimage_Selected = null;
            this.btnCancel.IconMarginLeft = 0;
            this.btnCancel.IconMarginRight = 0;
            this.btnCancel.IconRightVisible = true;
            this.btnCancel.IconRightZoom = 0D;
            this.btnCancel.IconVisible = true;
            this.btnCancel.IconZoom = 50D;
            this.btnCancel.IsTab = false;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancel.selected = false;
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancel.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancel.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ddEndMinute
            // 
            this.ddEndMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddEndMinute.BorderRadius = 5;
            this.ddEndMinute.Color = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndMinute.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddEndMinute.DisabledColor = System.Drawing.Color.Gray;
            this.ddEndMinute.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddEndMinute.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ddEndMinute.DropDownHeight = 130;
            this.ddEndMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddEndMinute.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddEndMinute.FillDropDown = false;
            this.ddEndMinute.FillIndicator = false;
            resources.ApplyResources(this.ddEndMinute, "ddEndMinute");
            this.ddEndMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndMinute.FormattingEnabled = true;
            this.ddEndMinute.Icon = null;
            this.ddEndMinute.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddEndMinute.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddEndMinute.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddEndMinute.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndMinute.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndMinute.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddEndMinute.Items.AddRange(new object[] {
            resources.GetString("ddEndMinute.Items"),
            resources.GetString("ddEndMinute.Items1"),
            resources.GetString("ddEndMinute.Items2"),
            resources.GetString("ddEndMinute.Items3"),
            resources.GetString("ddEndMinute.Items4"),
            resources.GetString("ddEndMinute.Items5"),
            resources.GetString("ddEndMinute.Items6"),
            resources.GetString("ddEndMinute.Items7"),
            resources.GetString("ddEndMinute.Items8"),
            resources.GetString("ddEndMinute.Items9"),
            resources.GetString("ddEndMinute.Items10"),
            resources.GetString("ddEndMinute.Items11"),
            resources.GetString("ddEndMinute.Items12"),
            resources.GetString("ddEndMinute.Items13"),
            resources.GetString("ddEndMinute.Items14"),
            resources.GetString("ddEndMinute.Items15"),
            resources.GetString("ddEndMinute.Items16"),
            resources.GetString("ddEndMinute.Items17"),
            resources.GetString("ddEndMinute.Items18"),
            resources.GetString("ddEndMinute.Items19"),
            resources.GetString("ddEndMinute.Items20"),
            resources.GetString("ddEndMinute.Items21"),
            resources.GetString("ddEndMinute.Items22"),
            resources.GetString("ddEndMinute.Items23"),
            resources.GetString("ddEndMinute.Items24"),
            resources.GetString("ddEndMinute.Items25"),
            resources.GetString("ddEndMinute.Items26"),
            resources.GetString("ddEndMinute.Items27"),
            resources.GetString("ddEndMinute.Items28"),
            resources.GetString("ddEndMinute.Items29"),
            resources.GetString("ddEndMinute.Items30"),
            resources.GetString("ddEndMinute.Items31"),
            resources.GetString("ddEndMinute.Items32"),
            resources.GetString("ddEndMinute.Items33"),
            resources.GetString("ddEndMinute.Items34"),
            resources.GetString("ddEndMinute.Items35"),
            resources.GetString("ddEndMinute.Items36"),
            resources.GetString("ddEndMinute.Items37"),
            resources.GetString("ddEndMinute.Items38"),
            resources.GetString("ddEndMinute.Items39"),
            resources.GetString("ddEndMinute.Items40"),
            resources.GetString("ddEndMinute.Items41"),
            resources.GetString("ddEndMinute.Items42"),
            resources.GetString("ddEndMinute.Items43"),
            resources.GetString("ddEndMinute.Items44"),
            resources.GetString("ddEndMinute.Items45"),
            resources.GetString("ddEndMinute.Items46"),
            resources.GetString("ddEndMinute.Items47"),
            resources.GetString("ddEndMinute.Items48"),
            resources.GetString("ddEndMinute.Items49"),
            resources.GetString("ddEndMinute.Items50"),
            resources.GetString("ddEndMinute.Items51"),
            resources.GetString("ddEndMinute.Items52"),
            resources.GetString("ddEndMinute.Items53"),
            resources.GetString("ddEndMinute.Items54"),
            resources.GetString("ddEndMinute.Items55"),
            resources.GetString("ddEndMinute.Items56"),
            resources.GetString("ddEndMinute.Items57"),
            resources.GetString("ddEndMinute.Items58"),
            resources.GetString("ddEndMinute.Items59")});
            this.ddEndMinute.Name = "ddEndMinute";
            // 
            // ddEndHour
            // 
            this.ddEndHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddEndHour.BorderRadius = 5;
            this.ddEndHour.Color = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndHour.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddEndHour.DisabledColor = System.Drawing.Color.Gray;
            this.ddEndHour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddEndHour.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ddEndHour.DropDownHeight = 130;
            this.ddEndHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddEndHour.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddEndHour.FillDropDown = false;
            this.ddEndHour.FillIndicator = false;
            resources.ApplyResources(this.ddEndHour, "ddEndHour");
            this.ddEndHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndHour.FormattingEnabled = true;
            this.ddEndHour.Icon = null;
            this.ddEndHour.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddEndHour.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddEndHour.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddEndHour.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndHour.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndHour.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddEndHour.Items.AddRange(new object[] {
            resources.GetString("ddEndHour.Items"),
            resources.GetString("ddEndHour.Items1"),
            resources.GetString("ddEndHour.Items2"),
            resources.GetString("ddEndHour.Items3"),
            resources.GetString("ddEndHour.Items4"),
            resources.GetString("ddEndHour.Items5"),
            resources.GetString("ddEndHour.Items6"),
            resources.GetString("ddEndHour.Items7"),
            resources.GetString("ddEndHour.Items8"),
            resources.GetString("ddEndHour.Items9"),
            resources.GetString("ddEndHour.Items10"),
            resources.GetString("ddEndHour.Items11"),
            resources.GetString("ddEndHour.Items12"),
            resources.GetString("ddEndHour.Items13"),
            resources.GetString("ddEndHour.Items14"),
            resources.GetString("ddEndHour.Items15"),
            resources.GetString("ddEndHour.Items16"),
            resources.GetString("ddEndHour.Items17"),
            resources.GetString("ddEndHour.Items18"),
            resources.GetString("ddEndHour.Items19"),
            resources.GetString("ddEndHour.Items20"),
            resources.GetString("ddEndHour.Items21"),
            resources.GetString("ddEndHour.Items22"),
            resources.GetString("ddEndHour.Items23")});
            this.ddEndHour.Name = "ddEndHour";
            // 
            // lblEndTime
            // 
            resources.ApplyResources(this.lblEndTime, "lblEndTime");
            this.lblEndTime.Name = "lblEndTime";
            // 
            // ddStartMinute
            // 
            this.ddStartMinute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddStartMinute.BorderRadius = 5;
            this.ddStartMinute.Color = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartMinute.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddStartMinute.DisabledColor = System.Drawing.Color.Gray;
            this.ddStartMinute.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddStartMinute.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ddStartMinute.DropDownHeight = 130;
            this.ddStartMinute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStartMinute.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddStartMinute.FillDropDown = false;
            this.ddStartMinute.FillIndicator = false;
            resources.ApplyResources(this.ddStartMinute, "ddStartMinute");
            this.ddStartMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartMinute.FormattingEnabled = true;
            this.ddStartMinute.Icon = null;
            this.ddStartMinute.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddStartMinute.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddStartMinute.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddStartMinute.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartMinute.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartMinute.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddStartMinute.Items.AddRange(new object[] {
            resources.GetString("ddStartMinute.Items"),
            resources.GetString("ddStartMinute.Items1"),
            resources.GetString("ddStartMinute.Items2"),
            resources.GetString("ddStartMinute.Items3"),
            resources.GetString("ddStartMinute.Items4"),
            resources.GetString("ddStartMinute.Items5"),
            resources.GetString("ddStartMinute.Items6"),
            resources.GetString("ddStartMinute.Items7"),
            resources.GetString("ddStartMinute.Items8"),
            resources.GetString("ddStartMinute.Items9"),
            resources.GetString("ddStartMinute.Items10"),
            resources.GetString("ddStartMinute.Items11"),
            resources.GetString("ddStartMinute.Items12"),
            resources.GetString("ddStartMinute.Items13"),
            resources.GetString("ddStartMinute.Items14"),
            resources.GetString("ddStartMinute.Items15"),
            resources.GetString("ddStartMinute.Items16"),
            resources.GetString("ddStartMinute.Items17"),
            resources.GetString("ddStartMinute.Items18"),
            resources.GetString("ddStartMinute.Items19"),
            resources.GetString("ddStartMinute.Items20"),
            resources.GetString("ddStartMinute.Items21"),
            resources.GetString("ddStartMinute.Items22"),
            resources.GetString("ddStartMinute.Items23"),
            resources.GetString("ddStartMinute.Items24"),
            resources.GetString("ddStartMinute.Items25"),
            resources.GetString("ddStartMinute.Items26"),
            resources.GetString("ddStartMinute.Items27"),
            resources.GetString("ddStartMinute.Items28"),
            resources.GetString("ddStartMinute.Items29"),
            resources.GetString("ddStartMinute.Items30"),
            resources.GetString("ddStartMinute.Items31"),
            resources.GetString("ddStartMinute.Items32"),
            resources.GetString("ddStartMinute.Items33"),
            resources.GetString("ddStartMinute.Items34"),
            resources.GetString("ddStartMinute.Items35"),
            resources.GetString("ddStartMinute.Items36"),
            resources.GetString("ddStartMinute.Items37"),
            resources.GetString("ddStartMinute.Items38"),
            resources.GetString("ddStartMinute.Items39"),
            resources.GetString("ddStartMinute.Items40"),
            resources.GetString("ddStartMinute.Items41"),
            resources.GetString("ddStartMinute.Items42"),
            resources.GetString("ddStartMinute.Items43"),
            resources.GetString("ddStartMinute.Items44"),
            resources.GetString("ddStartMinute.Items45"),
            resources.GetString("ddStartMinute.Items46"),
            resources.GetString("ddStartMinute.Items47"),
            resources.GetString("ddStartMinute.Items48"),
            resources.GetString("ddStartMinute.Items49"),
            resources.GetString("ddStartMinute.Items50"),
            resources.GetString("ddStartMinute.Items51"),
            resources.GetString("ddStartMinute.Items52"),
            resources.GetString("ddStartMinute.Items53"),
            resources.GetString("ddStartMinute.Items54"),
            resources.GetString("ddStartMinute.Items55"),
            resources.GetString("ddStartMinute.Items56"),
            resources.GetString("ddStartMinute.Items57"),
            resources.GetString("ddStartMinute.Items58"),
            resources.GetString("ddStartMinute.Items59")});
            this.ddStartMinute.Name = "ddStartMinute";
            // 
            // ddStartHour
            // 
            this.ddStartHour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddStartHour.BorderRadius = 5;
            this.ddStartHour.Color = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartHour.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddStartHour.DisabledColor = System.Drawing.Color.Gray;
            this.ddStartHour.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddStartHour.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ddStartHour.DropDownHeight = 130;
            this.ddStartHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddStartHour.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddStartHour.FillDropDown = false;
            this.ddStartHour.FillIndicator = false;
            resources.ApplyResources(this.ddStartHour, "ddStartHour");
            this.ddStartHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartHour.FormattingEnabled = true;
            this.ddStartHour.Icon = null;
            this.ddStartHour.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddStartHour.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddStartHour.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddStartHour.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartHour.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartHour.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddStartHour.Items.AddRange(new object[] {
            resources.GetString("ddStartHour.Items"),
            resources.GetString("ddStartHour.Items1"),
            resources.GetString("ddStartHour.Items2"),
            resources.GetString("ddStartHour.Items3"),
            resources.GetString("ddStartHour.Items4"),
            resources.GetString("ddStartHour.Items5"),
            resources.GetString("ddStartHour.Items6"),
            resources.GetString("ddStartHour.Items7"),
            resources.GetString("ddStartHour.Items8"),
            resources.GetString("ddStartHour.Items9"),
            resources.GetString("ddStartHour.Items10"),
            resources.GetString("ddStartHour.Items11"),
            resources.GetString("ddStartHour.Items12"),
            resources.GetString("ddStartHour.Items13"),
            resources.GetString("ddStartHour.Items14"),
            resources.GetString("ddStartHour.Items15"),
            resources.GetString("ddStartHour.Items16"),
            resources.GetString("ddStartHour.Items17"),
            resources.GetString("ddStartHour.Items18"),
            resources.GetString("ddStartHour.Items19"),
            resources.GetString("ddStartHour.Items20"),
            resources.GetString("ddStartHour.Items21"),
            resources.GetString("ddStartHour.Items22"),
            resources.GetString("ddStartHour.Items23")});
            this.ddStartHour.Name = "ddStartHour";
            // 
            // lblStartTime
            // 
            resources.ApplyResources(this.lblStartTime, "lblStartTime");
            this.lblStartTime.Name = "lblStartTime";
            // 
            // dpTimeTrackingDate
            // 
            this.dpTimeTrackingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dpTimeTrackingDate.BorderRadius = 5;
            resources.ApplyResources(this.dpTimeTrackingDate, "dpTimeTrackingDate");
            this.dpTimeTrackingDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpTimeTrackingDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dpTimeTrackingDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dpTimeTrackingDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpTimeTrackingDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpTimeTrackingDate.Color = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpTimeTrackingDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dpTimeTrackingDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpTimeTrackingDate.DisabledColor = System.Drawing.Color.Gray;
            this.dpTimeTrackingDate.DisplayWeekNumbers = false;
            this.dpTimeTrackingDate.DPHeight = 0;
            this.dpTimeTrackingDate.FillDatePicker = false;
            this.dpTimeTrackingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpTimeTrackingDate.Icon = ((System.Drawing.Image)(resources.GetObject("dpTimeTrackingDate.Icon")));
            this.dpTimeTrackingDate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.dpTimeTrackingDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpTimeTrackingDate.Name = "dpTimeTrackingDate";
            // 
            // lblTimeTrackingDate
            // 
            resources.ApplyResources(this.lblTimeTrackingDate, "lblTimeTrackingDate");
            this.lblTimeTrackingDate.Name = "lblTimeTrackingDate";
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // lblTask
            // 
            resources.ApplyResources(this.lblTask, "lblTask");
            this.lblTask.Name = "lblTask";
            // 
            // btnDeleteTimeTracking
            // 
            this.btnDeleteTimeTracking.Active = false;
            this.btnDeleteTimeTracking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTimeTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.btnDeleteTimeTracking, "btnDeleteTimeTracking");
            this.btnDeleteTimeTracking.BorderRadius = 0;
            this.btnDeleteTimeTracking.ButtonText = "Delete";
            this.btnDeleteTimeTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTimeTracking.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteTimeTracking.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteTimeTracking.Iconimage = global::Tick.Properties.Resources.delete;
            this.btnDeleteTimeTracking.Iconimage_right = null;
            this.btnDeleteTimeTracking.Iconimage_right_Selected = null;
            this.btnDeleteTimeTracking.Iconimage_Selected = null;
            this.btnDeleteTimeTracking.IconMarginLeft = 0;
            this.btnDeleteTimeTracking.IconMarginRight = 0;
            this.btnDeleteTimeTracking.IconRightVisible = true;
            this.btnDeleteTimeTracking.IconRightZoom = 0D;
            this.btnDeleteTimeTracking.IconVisible = true;
            this.btnDeleteTimeTracking.IconZoom = 50D;
            this.btnDeleteTimeTracking.IsTab = false;
            this.btnDeleteTimeTracking.Name = "btnDeleteTimeTracking";
            this.btnDeleteTimeTracking.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTimeTracking.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnDeleteTimeTracking.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteTimeTracking.selected = false;
            this.btnDeleteTimeTracking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteTimeTracking.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteTimeTracking.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTimeTracking.Click += new System.EventHandler(this.btnDeleteTimeTracking_Click);
            // 
            // btnSaveTimeTracking
            // 
            this.btnSaveTimeTracking.Active = false;
            this.btnSaveTimeTracking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTimeTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.btnSaveTimeTracking, "btnSaveTimeTracking");
            this.btnSaveTimeTracking.BorderRadius = 0;
            this.btnSaveTimeTracking.ButtonText = "Save";
            this.btnSaveTimeTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTimeTracking.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveTimeTracking.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveTimeTracking.Iconimage = global::Tick.Properties.Resources.save;
            this.btnSaveTimeTracking.Iconimage_right = null;
            this.btnSaveTimeTracking.Iconimage_right_Selected = null;
            this.btnSaveTimeTracking.Iconimage_Selected = null;
            this.btnSaveTimeTracking.IconMarginLeft = 0;
            this.btnSaveTimeTracking.IconMarginRight = 0;
            this.btnSaveTimeTracking.IconRightVisible = true;
            this.btnSaveTimeTracking.IconRightZoom = 0D;
            this.btnSaveTimeTracking.IconVisible = true;
            this.btnSaveTimeTracking.IconZoom = 50D;
            this.btnSaveTimeTracking.IsTab = false;
            this.btnSaveTimeTracking.Name = "btnSaveTimeTracking";
            this.btnSaveTimeTracking.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTimeTracking.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnSaveTimeTracking.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveTimeTracking.selected = false;
            this.btnSaveTimeTracking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveTimeTracking.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveTimeTracking.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTimeTracking.Click += new System.EventHandler(this.btnSaveTimeTracking_Click);
            // 
            // ddTask
            // 
            this.ddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddTask.BorderRadius = 5;
            this.ddTask.Color = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddTask.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddTask.DisabledColor = System.Drawing.Color.Gray;
            this.ddTask.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddTask.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ddTask.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddTask.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddTask.FillDropDown = false;
            this.ddTask.FillIndicator = false;
            resources.ApplyResources(this.ddTask, "ddTask");
            this.ddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddTask.FormattingEnabled = true;
            this.ddTask.Icon = null;
            this.ddTask.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddTask.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddTask.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddTask.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddTask.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddTask.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddTask.Items.AddRange(new object[] {
            resources.GetString("ddTask.Items"),
            resources.GetString("ddTask.Items1"),
            resources.GetString("ddTask.Items2")});
            this.ddTask.Name = "ddTask";
            // 
            // pnlSearchByDate
            // 
            this.pnlSearchByDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchByDate.Controls.Add(this.dtpDataGridTime);
            this.pnlSearchByDate.Controls.Add(this.btnPreviousDay);
            this.pnlSearchByDate.Controls.Add(this.btnNextDay);
            resources.ApplyResources(this.pnlSearchByDate, "pnlSearchByDate");
            this.pnlSearchByDate.Name = "pnlSearchByDate";
            // 
            // dtpDataGridTime
            // 
            resources.ApplyResources(this.dtpDataGridTime, "dtpDataGridTime");
            this.dtpDataGridTime.Name = "dtpDataGridTime";
            this.dtpDataGridTime.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.dtpDataGridTime_ValueChanged);
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Active = false;
            this.btnPreviousDay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPreviousDay.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnPreviousDay, "btnPreviousDay");
            this.btnPreviousDay.BorderRadius = 0;
            this.btnPreviousDay.ButtonText = "";
            this.btnPreviousDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousDay.DisabledColor = System.Drawing.Color.Gray;
            this.btnPreviousDay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPreviousDay.Iconimage = global::Tick.Properties.Resources.previousDay;
            this.btnPreviousDay.Iconimage_right = null;
            this.btnPreviousDay.Iconimage_right_Selected = null;
            this.btnPreviousDay.Iconimage_Selected = null;
            this.btnPreviousDay.IconMarginLeft = 0;
            this.btnPreviousDay.IconMarginRight = 0;
            this.btnPreviousDay.IconRightVisible = true;
            this.btnPreviousDay.IconRightZoom = 0D;
            this.btnPreviousDay.IconVisible = true;
            this.btnPreviousDay.IconZoom = 80D;
            this.btnPreviousDay.IsTab = false;
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPreviousDay.OnHovercolor = System.Drawing.Color.Gray;
            this.btnPreviousDay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPreviousDay.selected = false;
            this.btnPreviousDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPreviousDay.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPreviousDay.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousDay.Click += new System.EventHandler(this.btnPreviousDay_Click);
            // 
            // btnNextDay
            // 
            this.btnNextDay.Active = false;
            this.btnNextDay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNextDay.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnNextDay, "btnNextDay");
            this.btnNextDay.BorderRadius = 0;
            this.btnNextDay.ButtonText = "";
            this.btnNextDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextDay.DisabledColor = System.Drawing.Color.Gray;
            this.btnNextDay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNextDay.Iconimage = global::Tick.Properties.Resources.nextDay;
            this.btnNextDay.Iconimage_right = null;
            this.btnNextDay.Iconimage_right_Selected = null;
            this.btnNextDay.Iconimage_Selected = null;
            this.btnNextDay.IconMarginLeft = 0;
            this.btnNextDay.IconMarginRight = 0;
            this.btnNextDay.IconRightVisible = true;
            this.btnNextDay.IconRightZoom = 0D;
            this.btnNextDay.IconVisible = true;
            this.btnNextDay.IconZoom = 80D;
            this.btnNextDay.IsTab = false;
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNextDay.OnHovercolor = System.Drawing.Color.Gray;
            this.btnNextDay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNextDay.selected = false;
            this.btnNextDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNextDay.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNextDay.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // btnAddTimeTracking
            // 
            this.btnAddTimeTracking.Active = false;
            this.btnAddTimeTracking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddTimeTracking.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAddTimeTracking, "btnAddTimeTracking");
            this.btnAddTimeTracking.BorderRadius = 0;
            this.btnAddTimeTracking.ButtonText = "Add Work Unit";
            this.btnAddTimeTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTimeTracking.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddTimeTracking.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddTimeTracking.Iconimage = global::Tick.Properties.Resources.add1;
            this.btnAddTimeTracking.Iconimage_right = null;
            this.btnAddTimeTracking.Iconimage_right_Selected = null;
            this.btnAddTimeTracking.Iconimage_Selected = null;
            this.btnAddTimeTracking.IconMarginLeft = 0;
            this.btnAddTimeTracking.IconMarginRight = 0;
            this.btnAddTimeTracking.IconRightVisible = true;
            this.btnAddTimeTracking.IconRightZoom = 0D;
            this.btnAddTimeTracking.IconVisible = true;
            this.btnAddTimeTracking.IconZoom = 80D;
            this.btnAddTimeTracking.IsTab = false;
            this.btnAddTimeTracking.Name = "btnAddTimeTracking";
            this.btnAddTimeTracking.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddTimeTracking.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAddTimeTracking.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTimeTracking.selected = false;
            this.btnAddTimeTracking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTimeTracking.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTimeTracking.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTimeTracking.Click += new System.EventHandler(this.btnAddTimeTracking_Click);
            // 
            // dgvWorkUnits
            // 
            this.dgvWorkUnits.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvWorkUnits, "dgvWorkUnits");
            this.dgvWorkUnits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvWorkUnits.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvWorkUnits.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvWorkUnits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkUnits.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvWorkUnits.DoubleBuffered = true;
            this.dgvWorkUnits.EnableHeadersVisualStyles = false;
            this.dgvWorkUnits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvWorkUnits.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.Name = "dgvWorkUnits";
            this.dgvWorkUnits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkUnits.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.RowTemplate.Height = 60;
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
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // TimeTracking
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.dgvWorkUnits);
            this.Controls.Add(this.pnlSearchByDate);
            this.Controls.Add(this.pnlAddWorkUnit);
            this.Controls.Add(this.btnAddTimeTracking);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeTracking";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Load += new System.EventHandler(this.TimeTracking_Load);
            this.pnlAddWorkUnit.ResumeLayout(false);
            this.pnlAddWorkUnit.PerformLayout();
            this.pnlSearchByDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAddTimeTracking;
        private System.Windows.Forms.Panel pnlAddWorkUnit;
        private Bunifu.UI.WinForms.BunifuDropdown ddTask;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveTimeTracking;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteTimeTracking;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTask;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescription;
        private Bunifu.UI.WinForms.BunifuDatePicker dpTimeTrackingDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTimeTrackingDate;
        private Bunifu.Framework.UI.BunifuCustomLabel lblStartTime;
        private Bunifu.UI.WinForms.BunifuDropdown ddStartMinute;
        private Bunifu.UI.WinForms.BunifuDropdown ddStartHour;
        private Bunifu.UI.WinForms.BunifuDropdown ddEndMinute;
        private Bunifu.UI.WinForms.BunifuDropdown ddEndHour;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEndTime;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancel;
        private System.Windows.Forms.RichTextBox rtxtTimeDescription;
        private System.Windows.Forms.Panel pnlSearchByDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnNextDay;
        private Bunifu.Framework.UI.BunifuFlatButton btnPreviousDay;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpDataGridTime;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvWorkUnits;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}
