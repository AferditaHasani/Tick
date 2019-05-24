﻿namespace Tick.ExpensesManagement
{
    partial class ExpensesTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesTracking));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAddTransaction = new System.Windows.Forms.Panel();
            this.ddlCategory = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.dpExpensesTrackingDate = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.btnSaveTransaction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteTransaction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelTransaction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.lblDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCategory = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtAmount = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lblAmount = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnAddTransaction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvTransaction = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlSearchByDate = new System.Windows.Forms.Panel();
            this.btnPreviousDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNextDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtpDataGridTime = new Syncfusion.Windows.Forms.Tools.DateTimePickerAdv();
            this.pnlAddTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.pnlSearchByDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpDataGridTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddTransaction
            // 
            this.pnlAddTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAddTransaction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAddTransaction.Controls.Add(this.ddlCategory);
            this.pnlAddTransaction.Controls.Add(this.lblDate);
            this.pnlAddTransaction.Controls.Add(this.dpExpensesTrackingDate);
            this.pnlAddTransaction.Controls.Add(this.btnSaveTransaction);
            this.pnlAddTransaction.Controls.Add(this.btnDeleteTransaction);
            this.pnlAddTransaction.Controls.Add(this.btnCancelTransaction);
            this.pnlAddTransaction.Controls.Add(this.txtDescription);
            this.pnlAddTransaction.Controls.Add(this.lblDescription);
            this.pnlAddTransaction.Controls.Add(this.lblCategory);
            this.pnlAddTransaction.Controls.Add(this.txtAmount);
            this.pnlAddTransaction.Controls.Add(this.lblAmount);
            this.pnlAddTransaction.Location = new System.Drawing.Point(581, 51);
            this.pnlAddTransaction.Name = "pnlAddTransaction";
            this.pnlAddTransaction.Size = new System.Drawing.Size(349, 675);
            this.pnlAddTransaction.TabIndex = 2;
            // 
            // ddlCategory
            // 
            this.ddlCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ddlCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddlCategory.BorderRadius = 5;
            this.ddlCategory.Color = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddlCategory.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ddlCategory.DisabledColor = System.Drawing.Color.Gray;
            this.ddlCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ddlCategory.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.ddlCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlCategory.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ddlCategory.FillDropDown = false;
            this.ddlCategory.FillIndicator = false;
            this.ddlCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ddlCategory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ddlCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Icon = null;
            this.ddlCategory.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddlCategory.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlCategory.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddlCategory.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddlCategory.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddlCategory.ItemHeight = 26;
            this.ddlCategory.ItemHighLightColor = System.Drawing.Color.DimGray;
            this.ddlCategory.Items.AddRange(new object[] {
            "one",
            "two",
            "three"});
            this.ddlCategory.Location = new System.Drawing.Point(150, 197);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(185, 32);
            this.ddlCategory.TabIndex = 25;
            this.ddlCategory.Text = " ";
            // 
            // lblDate
            // 
            this.lblDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDate.AutoEllipsis = false;
            this.lblDate.CursorType = null;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblDate.Location = new System.Drawing.Point(68, 439);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDate.Size = new System.Drawing.Size(41, 23);
            this.lblDate.TabIndex = 24;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dpExpensesTrackingDate
            // 
            this.dpExpensesTrackingDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dpExpensesTrackingDate.BorderRadius = 5;
            this.dpExpensesTrackingDate.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dpExpensesTrackingDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpExpensesTrackingDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dpExpensesTrackingDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dpExpensesTrackingDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpExpensesTrackingDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpExpensesTrackingDate.Color = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpExpensesTrackingDate.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.dpExpensesTrackingDate.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.dpExpensesTrackingDate.DisabledColor = System.Drawing.Color.Gray;
            this.dpExpensesTrackingDate.DisplayWeekNumbers = false;
            this.dpExpensesTrackingDate.DPHeight = 0;
            this.dpExpensesTrackingDate.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dpExpensesTrackingDate.FillDatePicker = false;
            this.dpExpensesTrackingDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dpExpensesTrackingDate.Icon = ((System.Drawing.Image)(resources.GetObject("dpExpensesTrackingDate.Icon")));
            this.dpExpensesTrackingDate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.dpExpensesTrackingDate.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.dpExpensesTrackingDate.Location = new System.Drawing.Point(150, 427);
            this.dpExpensesTrackingDate.MaxDate = new System.DateTime(2119, 5, 24, 0, 0, 0, 0);
            this.dpExpensesTrackingDate.MinDate = new System.DateTime(2019, 1, 1, 0, 0, 0, 0);
            this.dpExpensesTrackingDate.MinimumSize = new System.Drawing.Size(185, 35);
            this.dpExpensesTrackingDate.Name = "dpExpensesTrackingDate";
            this.dpExpensesTrackingDate.Size = new System.Drawing.Size(185, 35);
            this.dpExpensesTrackingDate.TabIndex = 23;
            this.dpExpensesTrackingDate.Value = new System.DateTime(2019, 5, 23, 0, 0, 0, 0);
            // 
            // btnSaveTransaction
            // 
            this.btnSaveTransaction.Active = false;
            this.btnSaveTransaction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveTransaction.BorderRadius = 0;
            this.btnSaveTransaction.ButtonText = "Save";
            this.btnSaveTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTransaction.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTransaction.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveTransaction.Iconimage = global::Tick.Properties.Resources.save;
            this.btnSaveTransaction.Iconimage_right = null;
            this.btnSaveTransaction.Iconimage_right_Selected = null;
            this.btnSaveTransaction.Iconimage_Selected = null;
            this.btnSaveTransaction.IconMarginLeft = 0;
            this.btnSaveTransaction.IconMarginRight = 0;
            this.btnSaveTransaction.IconRightVisible = true;
            this.btnSaveTransaction.IconRightZoom = 0D;
            this.btnSaveTransaction.IconVisible = true;
            this.btnSaveTransaction.IconZoom = 50D;
            this.btnSaveTransaction.IsTab = false;
            this.btnSaveTransaction.Location = new System.Drawing.Point(250, 8);
            this.btnSaveTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveTransaction.Name = "btnSaveTransaction";
            this.btnSaveTransaction.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTransaction.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnSaveTransaction.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveTransaction.selected = false;
            this.btnSaveTransaction.Size = new System.Drawing.Size(104, 47);
            this.btnSaveTransaction.TabIndex = 22;
            this.btnSaveTransaction.Text = "Save";
            this.btnSaveTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveTransaction.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveTransaction.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTransaction.Click += new System.EventHandler(this.btnSaveTransaction_Click);
            // 
            // btnDeleteTransaction
            // 
            this.btnDeleteTransaction.Active = false;
            this.btnDeleteTransaction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTransaction.BorderRadius = 0;
            this.btnDeleteTransaction.ButtonText = "Delete";
            this.btnDeleteTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTransaction.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTransaction.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteTransaction.Iconimage = global::Tick.Properties.Resources.delete;
            this.btnDeleteTransaction.Iconimage_right = null;
            this.btnDeleteTransaction.Iconimage_right_Selected = null;
            this.btnDeleteTransaction.Iconimage_Selected = null;
            this.btnDeleteTransaction.IconMarginLeft = 0;
            this.btnDeleteTransaction.IconMarginRight = 0;
            this.btnDeleteTransaction.IconRightVisible = true;
            this.btnDeleteTransaction.IconRightZoom = 0D;
            this.btnDeleteTransaction.IconVisible = true;
            this.btnDeleteTransaction.IconZoom = 50D;
            this.btnDeleteTransaction.IsTab = false;
            this.btnDeleteTransaction.Location = new System.Drawing.Point(122, 8);
            this.btnDeleteTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTransaction.Name = "btnDeleteTransaction";
            this.btnDeleteTransaction.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTransaction.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnDeleteTransaction.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteTransaction.selected = false;
            this.btnDeleteTransaction.Size = new System.Drawing.Size(104, 47);
            this.btnDeleteTransaction.TabIndex = 21;
            this.btnDeleteTransaction.Text = "Delete";
            this.btnDeleteTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteTransaction.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteTransaction.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTransaction.Click += new System.EventHandler(this.btnDeleteTransaction_Click);
            // 
            // btnCancelTransaction
            // 
            this.btnCancelTransaction.Active = false;
            this.btnCancelTransaction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelTransaction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelTransaction.BorderRadius = 0;
            this.btnCancelTransaction.ButtonText = "Cancel";
            this.btnCancelTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelTransaction.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelTransaction.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTransaction.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelTransaction.Iconimage = global::Tick.Properties.Resources.cancel;
            this.btnCancelTransaction.Iconimage_right = null;
            this.btnCancelTransaction.Iconimage_right_Selected = null;
            this.btnCancelTransaction.Iconimage_Selected = null;
            this.btnCancelTransaction.IconMarginLeft = 0;
            this.btnCancelTransaction.IconMarginRight = 0;
            this.btnCancelTransaction.IconRightVisible = true;
            this.btnCancelTransaction.IconRightZoom = 0D;
            this.btnCancelTransaction.IconVisible = true;
            this.btnCancelTransaction.IconZoom = 50D;
            this.btnCancelTransaction.IsTab = false;
            this.btnCancelTransaction.Location = new System.Drawing.Point(-8, 8);
            this.btnCancelTransaction.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelTransaction.Name = "btnCancelTransaction";
            this.btnCancelTransaction.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelTransaction.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCancelTransaction.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancelTransaction.selected = false;
            this.btnCancelTransaction.Size = new System.Drawing.Size(104, 47);
            this.btnCancelTransaction.TabIndex = 20;
            this.btnCancelTransaction.Text = "Cancel";
            this.btnCancelTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelTransaction.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancelTransaction.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTransaction.Click += new System.EventHandler(this.btnCancelTransaction_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDescription.Location = new System.Drawing.Point(150, 293);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(185, 105);
            this.txtDescription.TabIndex = 11;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescription.AutoEllipsis = false;
            this.lblDescription.CursorType = null;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblDescription.Location = new System.Drawing.Point(17, 293);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDescription.Size = new System.Drawing.Size(91, 23);
            this.lblDescription.TabIndex = 6;
            this.lblDescription.Text = "Description:";
            this.lblDescription.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblDescription.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblCategory
            // 
            this.lblCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategory.AutoEllipsis = false;
            this.lblCategory.CursorType = null;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblCategory.Location = new System.Drawing.Point(34, 206);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCategory.Size = new System.Drawing.Size(74, 23);
            this.lblCategory.TabIndex = 5;
            this.lblCategory.Text = "Category:";
            this.lblCategory.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblCategory.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // txtAmount
            // 
            this.txtAmount.AcceptsReturn = false;
            this.txtAmount.AcceptsTab = false;
            this.txtAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAmount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtAmount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtAmount.BackColor = System.Drawing.Color.Transparent;
            this.txtAmount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtAmount.BackgroundImage")));
            this.txtAmount.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.txtAmount.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAmount.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAmount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtAmount.BorderRadius = 1;
            this.txtAmount.BorderThickness = 2;
            this.txtAmount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtAmount.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.DefaultText = "";
            this.txtAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtAmount.HideSelection = true;
            this.txtAmount.IconLeft = null;
            this.txtAmount.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtAmount.IconPadding = 10;
            this.txtAmount.IconRight = null;
            this.txtAmount.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtAmount.Location = new System.Drawing.Point(150, 122);
            this.txtAmount.MaxLength = 4000;
            this.txtAmount.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtAmount.Modified = false;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.PasswordChar = '\0';
            this.txtAmount.ReadOnly = false;
            this.txtAmount.SelectedText = "";
            this.txtAmount.SelectionLength = 0;
            this.txtAmount.SelectionStart = 0;
            this.txtAmount.ShortcutsEnabled = true;
            this.txtAmount.Size = new System.Drawing.Size(185, 35);
            this.txtAmount.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextMarginLeft = 5;
            this.txtAmount.TextPlaceholder = "";
            this.txtAmount.UseSystemPasswordChar = false;
            this.txtAmount.TextChange += new System.EventHandler(this.txtAmount_TextChange);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAmount.AutoEllipsis = false;
            this.lblAmount.CursorType = null;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblAmount.Location = new System.Drawing.Point(42, 134);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmount.Size = new System.Drawing.Size(66, 23);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAmount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // btnAddTransaction
            // 
            this.btnAddTransaction.Active = false;
            this.btnAddTransaction.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddTransaction.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTransaction.BorderRadius = 0;
            this.btnAddTransaction.ButtonText = "Add Transaction";
            this.btnAddTransaction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTransaction.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddTransaction.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.Iconimage = global::Tick.Properties.Resources.add1;
            this.btnAddTransaction.Iconimage_right = null;
            this.btnAddTransaction.Iconimage_right_Selected = null;
            this.btnAddTransaction.Iconimage_Selected = null;
            this.btnAddTransaction.IconMarginLeft = 0;
            this.btnAddTransaction.IconMarginRight = 0;
            this.btnAddTransaction.IconRightVisible = true;
            this.btnAddTransaction.IconRightZoom = 0D;
            this.btnAddTransaction.IconVisible = true;
            this.btnAddTransaction.IconZoom = 80D;
            this.btnAddTransaction.IsTab = false;
            this.btnAddTransaction.Location = new System.Drawing.Point(12, 12);
            this.btnAddTransaction.Name = "btnAddTransaction";
            this.btnAddTransaction.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddTransaction.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAddTransaction.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTransaction.selected = false;
            this.btnAddTransaction.Size = new System.Drawing.Size(161, 36);
            this.btnAddTransaction.TabIndex = 1;
            this.btnAddTransaction.Text = "Add Transaction";
            this.btnAddTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddTransaction.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTransaction.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTransaction.Click += new System.EventHandler(this.btnAddTransaction_Click);
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvTransaction.DoubleBuffered = true;
            this.dgvTransaction.EnableHeadersVisualStyles = false;
            this.dgvTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTransaction.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.Location = new System.Drawing.Point(12, 121);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvTransaction.RowHeadersWidth = 17;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvTransaction.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTransaction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransaction.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTransaction.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvTransaction.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.RowTemplate.Height = 60;
            this.dgvTransaction.Size = new System.Drawing.Size(656, 564);
            this.dgvTransaction.TabIndex = 6;
            this.dgvTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellContentClick);
            this.dgvTransaction.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellContentClick);
            this.dgvTransaction.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTransaction_RowHeaderMouseClick);
            this.dgvTransaction.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTransaction_RowHeaderMouseClick);
            // 
            // pnlSearchByDate
            // 
            this.pnlSearchByDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchByDate.Controls.Add(this.btnPreviousDay);
            this.pnlSearchByDate.Controls.Add(this.btnNextDay);
            this.pnlSearchByDate.Controls.Add(this.dtpDataGridTime);
            this.pnlSearchByDate.Location = new System.Drawing.Point(69, 68);
            this.pnlSearchByDate.Name = "pnlSearchByDate";
            this.pnlSearchByDate.Size = new System.Drawing.Size(490, 40);
            this.pnlSearchByDate.TabIndex = 7;
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
            this.btnPreviousDay.Iconimage = global::Tick.Properties.Resources.Previous;
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
            this.btnNextDay.Iconimage = global::Tick.Properties.Resources.Next;
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
            // dtpDataGridTime
            // 
            this.dtpDataGridTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dtpDataGridTime.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dtpDataGridTime.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dtpDataGridTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dtpDataGridTime.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dtpDataGridTime.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.dtpDataGridTime.CalendarSize = new System.Drawing.Size(399, 220);
            this.dtpDataGridTime.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(88)))), ((int)(((byte)(88)))));
            this.dtpDataGridTime.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpDataGridTime.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpDataGridTime.DropDownImage = null;
            this.dtpDataGridTime.DropDownNormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.dtpDataGridTime.DropDownPressedColor = System.Drawing.Color.DimGray;
            this.dtpDataGridTime.DropDownSelectedColor = System.Drawing.Color.DimGray;
            this.dtpDataGridTime.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataGridTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dtpDataGridTime.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataGridTime.Location = new System.Drawing.Point(44, 3);
            this.dtpDataGridTime.MaxValue = new System.DateTime(2119, 5, 24, 0, 0, 0, 0);
            this.dtpDataGridTime.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.dtpDataGridTime.MinValue = new System.DateTime(((long)(0)));
            this.dtpDataGridTime.Name = "dtpDataGridTime";
            this.dtpDataGridTime.ShowCheckBox = false;
            this.dtpDataGridTime.ShowUpDownOnFocus = true;
            this.dtpDataGridTime.Size = new System.Drawing.Size(399, 33);
            this.dtpDataGridTime.StretchDropDownImage = true;
            this.dtpDataGridTime.Style = Syncfusion.Windows.Forms.VisualStyle.Office2016DarkGray;
            this.dtpDataGridTime.TabIndex = 4;
            this.dtpDataGridTime.Value = new System.DateTime(2019, 5, 23, 0, 0, 0, 0);
            this.dtpDataGridTime.ValueChanged += new System.EventHandler(this.dtpDataGridTime_ValueChanged);
            this.dgvTransaction.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellContentClick);
            this.dgvTransaction.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellContentClick);
            this.dgvTransaction.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTransaction_RowHeaderMouseClick);
            // 
            // ExpensesTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.pnlSearchByDate);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.pnlAddTransaction);
            this.Controls.Add(this.btnAddTransaction);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpensesTracking";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ExpensesTracking";
            this.Load += new System.EventHandler(this.ExpensesTracking_Load);
            this.pnlAddTransaction.ResumeLayout(false);
            this.pnlAddTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.pnlSearchByDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpDataGridTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAddTransaction;
        private System.Windows.Forms.Panel pnlAddTransaction;
        private Bunifu.UI.WinForms.BunifuLabel lblDescription;
        private Bunifu.UI.WinForms.BunifuLabel lblCategory;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAmount;
        private Bunifu.UI.WinForms.BunifuLabel lblAmount;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDescription;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelTransaction;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteTransaction;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveTransaction;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTransaction;
        private Bunifu.UI.WinForms.BunifuLabel lblDate;
        private Bunifu.UI.WinForms.BunifuDatePicker dpExpensesTrackingDate;
        private System.Windows.Forms.Panel pnlSearchByDate;
        private Bunifu.Framework.UI.BunifuFlatButton btnPreviousDay;
        private Bunifu.Framework.UI.BunifuFlatButton btnNextDay;
        private Syncfusion.Windows.Forms.Tools.DateTimePickerAdv dtpDataGridTime;
        private Bunifu.UI.WinForms.BunifuDropdown ddlCategory;
    }
}
