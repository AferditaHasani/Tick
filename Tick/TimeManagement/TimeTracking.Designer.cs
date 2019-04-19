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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeTracking));
            this.dgvWorkUnits = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlAddWorkUnit = new System.Windows.Forms.Panel();
            this.ddEndMinute = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ddEndHour = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblEndTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ddStartMinute = new Bunifu.UI.WinForms.BunifuDropdown();
            this.ddStartHour = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblStartTime = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTimeTrackingDate = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTask = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ddTask = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnCancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dpTimeTrackingDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnDeleteTimeTracking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveTimeTracking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnAddTimeTracking = new Bunifu.Framework.UI.BunifuFlatButton();
            this.rtxtTimeDescription = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkUnits)).BeginInit();
            this.pnlAddWorkUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvWorkUnits
            // 
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
            this.dgvWorkUnits.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvWorkUnits.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvWorkUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWorkUnits.ColumnHeadersVisible = false;
            this.dgvWorkUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.StartTime,
            this.EndTime,
            this.WorkingTime});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvWorkUnits.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvWorkUnits.DoubleBuffered = true;
            this.dgvWorkUnits.EnableHeadersVisualStyles = false;
            this.dgvWorkUnits.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvWorkUnits.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvWorkUnits.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.Location = new System.Drawing.Point(12, 85);
            this.dgvWorkUnits.Name = "dgvWorkUnits";
            this.dgvWorkUnits.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle8.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvWorkUnits.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvWorkUnits.RowHeadersWidth = 10;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle9.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvWorkUnits.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvWorkUnits.RowTemplate.Height = 60;
            this.dgvWorkUnits.Size = new System.Drawing.Size(634, 675);
            this.dgvWorkUnits.TabIndex = 1;
            // 
            // Task
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Task.DefaultCellStyle = dataGridViewCellStyle3;
            this.Task.HeaderText = "Task";
            this.Task.Name = "Task";
            // 
            // StartTime
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.StartTime.DefaultCellStyle = dataGridViewCellStyle4;
            this.StartTime.HeaderText = "StartTime";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.EndTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.EndTime.HeaderText = "EndTime";
            this.EndTime.Name = "EndTime";
            // 
            // WorkingTime
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle6.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.WorkingTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.WorkingTime.HeaderText = "WorkingTime";
            this.WorkingTime.Name = "WorkingTime";
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
            // rtxtTimeDescription
            // 
            this.rtxtTimeDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.rtxtTimeDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtTimeDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.rtxtTimeDescription.Location = new System.Drawing.Point(36, 231);
            this.rtxtTimeDescription.Name = "rtxtTimeDescription";
            this.rtxtTimeDescription.Size = new System.Drawing.Size(258, 96);
            this.rtxtTimeDescription.TabIndex = 18;
            this.rtxtTimeDescription.Text = "";
            // 
            // TimeTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(688, 772);
            this.Controls.Add(this.pnlAddWorkUnit);
            this.Controls.Add(this.dgvWorkUnits);
            this.Controls.Add(this.btnAddTimeTracking);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimeTracking";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "TimeTracking";
            ((System.ComponentModel.ISupportInitialize)(this.dgvWorkUnits)).EndInit();
            this.pnlAddWorkUnit.ResumeLayout(false);
            this.pnlAddWorkUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAddTimeTracking;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvWorkUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingTime;
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
    }
}
