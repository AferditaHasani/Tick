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
            this.pnlAddWorkUnit.SuspendLayout();
            this.pnlSearchByDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddWorkUnit
            // 
            this.pnlAddWorkUnit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.pnlAddWorkUnit.Location = new System.Drawing.Point(666, 12);
            this.pnlAddWorkUnit.Name = "pnlAddWorkUnit";
            this.pnlAddWorkUnit.Size = new System.Drawing.Size(10, 748);
            this.pnlAddWorkUnit.TabIndex = 2;
            // 
            // rtxtTimeDescription
            // 
            this.rtxtTimeDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.rtxtTimeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtTimeDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtTimeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.rtxtTimeDescription.Location = new System.Drawing.Point(36, 231);
            this.rtxtTimeDescription.Name = "rtxtTimeDescription";
            this.rtxtTimeDescription.Size = new System.Drawing.Size(258, 96);
            this.rtxtTimeDescription.TabIndex = 18;
            this.rtxtTimeDescription.Text = "";
            // 
            // btnCancel
            // 
            this.btnCancel.Active = false;
            this.btnCancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancel.BorderRadius = 0;
            this.btnCancel.ButtonText = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnCancel.Location = new System.Drawing.Point(16, 22);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancel.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCancel.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancel.selected = false;
            this.btnCancel.Size = new System.Drawing.Size(101, 47);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
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
            this.ddEndMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddEndMinute.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ddEndMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndMinute.FormattingEnabled = true;
            this.ddEndMinute.Icon = null;
            this.ddEndMinute.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddEndMinute.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddEndMinute.IntegralHeight = false;
            this.ddEndMinute.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddEndMinute.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndMinute.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndMinute.ItemHeight = 26;
            this.ddEndMinute.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddEndMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.ddEndMinute.Location = new System.Drawing.Point(166, 596);
            this.ddEndMinute.Name = "ddEndMinute";
            this.ddEndMinute.Size = new System.Drawing.Size(128, 32);
            this.ddEndMinute.TabIndex = 14;
            this.ddEndMinute.Text = " ";
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
            this.ddEndHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddEndHour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ddEndHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndHour.FormattingEnabled = true;
            this.ddEndHour.Icon = null;
            this.ddEndHour.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddEndHour.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddEndHour.IntegralHeight = false;
            this.ddEndHour.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddEndHour.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndHour.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddEndHour.ItemHeight = 26;
            this.ddEndHour.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddEndHour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.ddEndHour.Location = new System.Drawing.Point(36, 596);
            this.ddEndHour.MaxDropDownItems = 5;
            this.ddEndHour.Name = "ddEndHour";
            this.ddEndHour.Size = new System.Drawing.Size(128, 32);
            this.ddEndHour.TabIndex = 13;
            this.ddEndHour.Text = " ";
            // 
            // lblEndTime
            // 
            this.lblEndTime.AutoSize = true;
            this.lblEndTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndTime.Location = new System.Drawing.Point(32, 557);
            this.lblEndTime.Name = "lblEndTime";
            this.lblEndTime.Size = new System.Drawing.Size(77, 21);
            this.lblEndTime.TabIndex = 12;
            this.lblEndTime.Text = "End Time";
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
            this.ddStartMinute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddStartMinute.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ddStartMinute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartMinute.FormattingEnabled = true;
            this.ddStartMinute.Icon = null;
            this.ddStartMinute.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddStartMinute.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddStartMinute.IntegralHeight = false;
            this.ddStartMinute.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddStartMinute.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartMinute.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartMinute.ItemHeight = 26;
            this.ddStartMinute.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddStartMinute.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.ddStartMinute.Location = new System.Drawing.Point(166, 484);
            this.ddStartMinute.Name = "ddStartMinute";
            this.ddStartMinute.Size = new System.Drawing.Size(128, 32);
            this.ddStartMinute.TabIndex = 10;
            this.ddStartMinute.Text = " ";
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
            this.ddStartHour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddStartHour.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ddStartHour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartHour.FormattingEnabled = true;
            this.ddStartHour.Icon = null;
            this.ddStartHour.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddStartHour.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddStartHour.IntegralHeight = false;
            this.ddStartHour.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddStartHour.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartHour.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddStartHour.ItemHeight = 26;
            this.ddStartHour.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddStartHour.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "00"});
            this.ddStartHour.Location = new System.Drawing.Point(36, 484);
            this.ddStartHour.MaxDropDownItems = 5;
            this.ddStartHour.Name = "ddStartHour";
            this.ddStartHour.Size = new System.Drawing.Size(128, 32);
            this.ddStartHour.TabIndex = 9;
            this.ddStartHour.Text = " ";
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartTime.Location = new System.Drawing.Point(32, 445);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(85, 21);
            this.lblStartTime.TabIndex = 8;
            this.lblStartTime.Text = "Start Time";
            // 
            // dpTimeTrackingDate
            // 
            this.dpTimeTrackingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dpTimeTrackingDate.BorderRadius = 5;
            this.dpTimeTrackingDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dpTimeTrackingDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpTimeTrackingDate.FillDatePicker = false;
            this.dpTimeTrackingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpTimeTrackingDate.Icon = ((System.Drawing.Image)(resources.GetObject("dpTimeTrackingDate.Icon")));
            this.dpTimeTrackingDate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.dpTimeTrackingDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpTimeTrackingDate.Location = new System.Drawing.Point(36, 378);
            this.dpTimeTrackingDate.MinimumSize = new System.Drawing.Size(258, 35);
            this.dpTimeTrackingDate.Name = "dpTimeTrackingDate";
            this.dpTimeTrackingDate.Size = new System.Drawing.Size(258, 35);
            this.dpTimeTrackingDate.TabIndex = 7;
            // 
            // lblTimeTrackingDate
            // 
            this.lblTimeTrackingDate.AutoSize = true;
            this.lblTimeTrackingDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeTrackingDate.Location = new System.Drawing.Point(32, 345);
            this.lblTimeTrackingDate.Name = "lblTimeTrackingDate";
            this.lblTimeTrackingDate.Size = new System.Drawing.Size(44, 21);
            this.lblTimeTrackingDate.TabIndex = 6;
            this.lblTimeTrackingDate.Text = "Date";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(32, 193);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(94, 21);
            this.lblDescription.TabIndex = 5;
            this.lblDescription.Text = "Description";
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.Location = new System.Drawing.Point(32, 103);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(40, 21);
            this.lblTask.TabIndex = 4;
            this.lblTask.Text = "Task";
            // 
            // btnDeleteTimeTracking
            // 
            this.btnDeleteTimeTracking.Active = false;
            this.btnDeleteTimeTracking.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTimeTracking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTimeTracking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTimeTracking.BorderRadius = 0;
            this.btnDeleteTimeTracking.ButtonText = "Delete";
            this.btnDeleteTimeTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTimeTracking.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteTimeTracking.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnDeleteTimeTracking.Location = new System.Drawing.Point(111, 22);
            this.btnDeleteTimeTracking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTimeTracking.Name = "btnDeleteTimeTracking";
            this.btnDeleteTimeTracking.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTimeTracking.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnDeleteTimeTracking.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteTimeTracking.selected = false;
            this.btnDeleteTimeTracking.Size = new System.Drawing.Size(104, 47);
            this.btnDeleteTimeTracking.TabIndex = 2;
            this.btnDeleteTimeTracking.Text = "Delete";
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
            this.btnSaveTimeTracking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveTimeTracking.BorderRadius = 0;
            this.btnSaveTimeTracking.ButtonText = "Save";
            this.btnSaveTimeTracking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTimeTracking.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveTimeTracking.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnSaveTimeTracking.Location = new System.Drawing.Point(223, 22);
            this.btnSaveTimeTracking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveTimeTracking.Name = "btnSaveTimeTracking";
            this.btnSaveTimeTracking.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTimeTracking.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnSaveTimeTracking.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveTimeTracking.selected = false;
            this.btnSaveTimeTracking.Size = new System.Drawing.Size(101, 47);
            this.btnSaveTimeTracking.TabIndex = 1;
            this.btnSaveTimeTracking.Text = "Save";
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
            this.ddTask.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddTask.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ddTask.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddTask.FormattingEnabled = true;
            this.ddTask.Icon = null;
            this.ddTask.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.ddTask.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddTask.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddTask.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddTask.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddTask.ItemHeight = 26;
            this.ddTask.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddTask.Items.AddRange(new object[] {
            "one",
            "two",
            "three"});
            this.ddTask.Location = new System.Drawing.Point(36, 139);
            this.ddTask.Name = "ddTask";
            this.ddTask.Size = new System.Drawing.Size(258, 32);
            this.ddTask.TabIndex = 0;
            this.ddTask.Text = " ";
            // 
            // pnlSearchByDate
            // 
            this.pnlSearchByDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchByDate.Controls.Add(this.dtpDataGridTime);
            this.pnlSearchByDate.Controls.Add(this.btnPreviousDay);
            this.pnlSearchByDate.Controls.Add(this.btnNextDay);
            this.pnlSearchByDate.Location = new System.Drawing.Point(64, 70);
            this.pnlSearchByDate.Name = "pnlSearchByDate";
            this.pnlSearchByDate.Size = new System.Drawing.Size(490, 40);
            this.pnlSearchByDate.TabIndex = 3;
            // 
            // dtpDataGridTime
            // 
            this.dtpDataGridTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataGridTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataGridTime.Location = new System.Drawing.Point(44, 4);
            this.dtpDataGridTime.Name = "dtpDataGridTime";
            this.dtpDataGridTime.Size = new System.Drawing.Size(399, 31);
            this.dtpDataGridTime.TabIndex = 6;
            this.dtpDataGridTime.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.dtpDataGridTime_ValueChanged);
            // 
            // btnPreviousDay
            // 
            this.btnPreviousDay.Active = false;
            this.btnPreviousDay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPreviousDay.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.btnPreviousDay.Location = new System.Drawing.Point(4, 3);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPreviousDay.OnHovercolor = System.Drawing.Color.Gray;
            this.btnPreviousDay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPreviousDay.selected = false;
            this.btnPreviousDay.Size = new System.Drawing.Size(34, 32);
            this.btnPreviousDay.TabIndex = 5;
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
            this.btnNextDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.btnNextDay.Location = new System.Drawing.Point(449, 3);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNextDay.OnHovercolor = System.Drawing.Color.Gray;
            this.btnNextDay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNextDay.selected = false;
            this.btnNextDay.Size = new System.Drawing.Size(34, 32);
            this.btnNextDay.TabIndex = 4;
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
            this.btnAddTimeTracking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.btnAddTimeTracking.Location = new System.Drawing.Point(12, 12);
            this.btnAddTimeTracking.Name = "btnAddTimeTracking";
            this.btnAddTimeTracking.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddTimeTracking.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAddTimeTracking.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTimeTracking.selected = false;
            this.btnAddTimeTracking.Size = new System.Drawing.Size(161, 36);
            this.btnAddTimeTracking.TabIndex = 0;
            this.btnAddTimeTracking.Text = "Add Work Unit";
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
            this.dgvWorkUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvWorkUnits.Location = new System.Drawing.Point(12, 131);
            this.dgvWorkUnits.Name = "dgvWorkUnits";
            this.dgvWorkUnits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvWorkUnits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkUnits.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvWorkUnits.RowHeadersWidth = 17;
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
            this.dgvWorkUnits.Size = new System.Drawing.Size(648, 675);
            this.dgvWorkUnits.TabIndex = 5;
            this.dgvWorkUnits.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkUnits_CellContentClick);
            this.dgvWorkUnits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWorkUnits_CellContentClick);
            this.dgvWorkUnits.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvdgvWorkUnits_RowHeaderMouseClick);
            // 
            // TimeTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(760, 788);
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
            this.Text = "TimeTracking";
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
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvWorkUnits;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpDataGridTime;
    }
}
