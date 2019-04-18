﻿namespace Tick.ExpensesManagment
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAddTransaction = new System.Windows.Forms.Panel();
            this.btnAddT = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.txtDescription = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ddlCategory = new Bunifu.UI.WinForms.BunifuDropdown();
            this.lblDescription = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblCategory = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtAmount = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lblAmount = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvTransaction = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Task = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlGridViewEx = new System.Windows.Forms.Panel();
            this.btnAddTransaction = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlAddTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddTransaction
            // 
            this.pnlAddTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddTransaction.Controls.Add(this.btnAddT);
            this.pnlAddTransaction.Controls.Add(this.txtDescription);
            this.pnlAddTransaction.Controls.Add(this.ddlCategory);
            this.pnlAddTransaction.Controls.Add(this.lblDescription);
            this.pnlAddTransaction.Controls.Add(this.lblCategory);
            this.pnlAddTransaction.Controls.Add(this.txtAmount);
            this.pnlAddTransaction.Controls.Add(this.lblAmount);
            this.pnlAddTransaction.Controls.Add(this.dgvTransaction);
            this.pnlAddTransaction.Location = new System.Drawing.Point(12, 80);
            this.pnlAddTransaction.Name = "pnlAddTransaction";
            this.pnlAddTransaction.Size = new System.Drawing.Size(624, 274);
            this.pnlAddTransaction.TabIndex = 2;
            // 
            // btnAddT
            // 
            this.btnAddT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddT.BackColor = System.Drawing.Color.Transparent;
            this.btnAddT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddT.BackgroundImage")));
            this.btnAddT.ButtonText = "ADD";
            this.btnAddT.ButtonTextMarginLeft = 0;
            this.btnAddT.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddT.DisabledFillColor = System.Drawing.Color.DimGray;
            this.btnAddT.DisabledForecolor = System.Drawing.Color.White;
            this.btnAddT.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnAddT.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddT.IconPadding = 10;
            this.btnAddT.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddT.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.btnAddT.IdleBorderRadius = 15;
            this.btnAddT.IdleBorderThickness = 2;
            this.btnAddT.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnAddT.IdleIconLeftImage = null;
            this.btnAddT.IdleIconRightImage = null;
            this.btnAddT.Location = new System.Drawing.Point(487, 205);
            this.btnAddT.Name = "btnAddT";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 2;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.btnAddT.onHoverState = stateProperties2;
            this.btnAddT.Size = new System.Drawing.Size(116, 54);
            this.btnAddT.TabIndex = 12;
            this.btnAddT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddT.Click += new System.EventHandler(this.btnAddT_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtDescription.Location = new System.Drawing.Point(149, 154);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(234, 105);
            this.txtDescription.TabIndex = 11;
            // 
            // ddlCategory
            // 
            this.ddlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ddlCategory.BorderRadius = 1;
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
            this.ddlCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddlCategory.FormattingEnabled = true;
            this.ddlCategory.Icon = null;
            this.ddlCategory.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddlCategory.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ddlCategory.ItemBackColor = System.Drawing.Color.White;
            this.ddlCategory.ItemBorderColor = System.Drawing.Color.White;
            this.ddlCategory.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ddlCategory.ItemHeight = 26;
            this.ddlCategory.ItemHighLightColor = System.Drawing.Color.Thistle;
            this.ddlCategory.Location = new System.Drawing.Point(149, 86);
            this.ddlCategory.Name = "ddlCategory";
            this.ddlCategory.Size = new System.Drawing.Size(234, 32);
            this.ddlCategory.TabIndex = 8;
            this.ddlCategory.Text = null;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoEllipsis = false;
            this.lblDescription.CursorType = null;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblDescription.Location = new System.Drawing.Point(16, 163);
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
            this.lblCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCategory.AutoEllipsis = false;
            this.lblCategory.CursorType = null;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblCategory.Location = new System.Drawing.Point(33, 95);
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
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.txtAmount.Location = new System.Drawing.Point(149, 11);
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
            this.txtAmount.Size = new System.Drawing.Size(234, 35);
            this.txtAmount.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtAmount.TabIndex = 4;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtAmount.TextMarginLeft = 5;
            this.txtAmount.TextPlaceholder = "";
            this.txtAmount.UseSystemPasswordChar = false;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // lblAmount
            // 
            this.lblAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAmount.AutoEllipsis = false;
            this.lblAmount.CursorType = null;
            this.lblAmount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblAmount.Location = new System.Drawing.Point(41, 23);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblAmount.Size = new System.Drawing.Size(66, 23);
            this.lblAmount.TabIndex = 3;
            this.lblAmount.Text = "Amount:";
            this.lblAmount.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblAmount.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvTransaction
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle10.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTransaction.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransaction.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.ColumnHeadersVisible = false;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Task,
            this.StartTime,
            this.EndTime,
            this.WorkingTime});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle16.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvTransaction.DoubleBuffered = true;
            this.dgvTransaction.EnableHeadersVisualStyles = false;
            this.dgvTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTransaction.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTransaction.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTransaction.Location = new System.Drawing.Point(3, 3);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle17.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvTransaction.RowHeadersWidth = 5;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle18.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvTransaction.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTransaction.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransaction.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTransaction.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvTransaction.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTransaction.RowTemplate.Height = 60;
            this.dgvTransaction.Size = new System.Drawing.Size(618, 674);
            this.dgvTransaction.TabIndex = 2;
            // 
            // Task
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle12.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.Task.DefaultCellStyle = dataGridViewCellStyle12;
            this.Task.HeaderText = "Amount";
            this.Task.Name = "Task";
            // 
            // StartTime
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle13.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.StartTime.DefaultCellStyle = dataGridViewCellStyle13;
            this.StartTime.HeaderText = "Date";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle14.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.EndTime.DefaultCellStyle = dataGridViewCellStyle14;
            this.EndTime.HeaderText = "Category";
            this.EndTime.Name = "EndTime";
            // 
            // WorkingTime
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle15.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.WorkingTime.DefaultCellStyle = dataGridViewCellStyle15;
            this.WorkingTime.HeaderText = "Description";
            this.WorkingTime.Name = "WorkingTime";
            // 
            // pnlGridViewEx
            // 
            this.pnlGridViewEx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlGridViewEx.BackColor = System.Drawing.Color.Transparent;
            this.pnlGridViewEx.Location = new System.Drawing.Point(12, 80);
            this.pnlGridViewEx.Name = "pnlGridViewEx";
            this.pnlGridViewEx.Size = new System.Drawing.Size(624, 677);
            this.pnlGridViewEx.TabIndex = 3;
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
            // ExpensesTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(672, 788);
            this.Controls.Add(this.pnlGridViewEx);
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
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAddTransaction;
        private System.Windows.Forms.Panel pnlAddTransaction;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTransaction;
        private Bunifu.UI.WinForms.BunifuDropdown ddlCategory;
        private Bunifu.UI.WinForms.BunifuLabel lblDescription;
        private Bunifu.UI.WinForms.BunifuLabel lblCategory;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtAmount;
        private Bunifu.UI.WinForms.BunifuLabel lblAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Task;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkingTime;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtDescription;
        protected internal Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddT;
        private System.Windows.Forms.Panel pnlGridViewEx;
    }
}