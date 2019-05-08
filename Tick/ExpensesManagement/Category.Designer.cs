namespace Tick.ExpensesManagement
{
    partial class Category
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Category));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAddCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlAddCategory = new System.Windows.Forms.Panel();
            this.lblColor = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbTaskColor = new Telerik.WinControls.UI.RadColorBox();
            this.btnSaveCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnCancelCategory = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblIncome = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblExpense = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbxIncome = new Bunifu.Framework.UI.BunifuCheckbox();
            this.cbxExpense = new Bunifu.Framework.UI.BunifuCheckbox();
            this.txtName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.lblChoose = new Bunifu.UI.WinForms.BunifuLabel();
            this.lblName = new Bunifu.UI.WinForms.BunifuLabel();
            this.dgvCategory = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlAddCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaskColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Active = false;
            this.btnAddCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCategory.BorderRadius = 0;
            this.btnAddCategory.ButtonText = "Add Category";
            this.btnAddCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCategory.Iconimage = global::Tick.Properties.Resources.add1;
            this.btnAddCategory.Iconimage_right = null;
            this.btnAddCategory.Iconimage_right_Selected = null;
            this.btnAddCategory.Iconimage_Selected = null;
            this.btnAddCategory.IconMarginLeft = 0;
            this.btnAddCategory.IconMarginRight = 0;
            this.btnAddCategory.IconRightVisible = true;
            this.btnAddCategory.IconRightZoom = 0D;
            this.btnAddCategory.IconVisible = true;
            this.btnAddCategory.IconZoom = 80D;
            this.btnAddCategory.IsTab = false;
            this.btnAddCategory.Location = new System.Drawing.Point(12, 12);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddCategory.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAddCategory.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddCategory.selected = false;
            this.btnAddCategory.Size = new System.Drawing.Size(161, 36);
            this.btnAddCategory.TabIndex = 2;
            this.btnAddCategory.Text = "Add Category";
            this.btnAddCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCategory.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddCategory.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // pnlAddCategory
            // 
            this.pnlAddCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAddCategory.Controls.Add(this.lblColor);
            this.pnlAddCategory.Controls.Add(this.cbTaskColor);
            this.pnlAddCategory.Controls.Add(this.btnSaveCategory);
            this.pnlAddCategory.Controls.Add(this.btnDeleteCategory);
            this.pnlAddCategory.Controls.Add(this.btnCancelCategory);
            this.pnlAddCategory.Controls.Add(this.lblIncome);
            this.pnlAddCategory.Controls.Add(this.lblExpense);
            this.pnlAddCategory.Controls.Add(this.cbxIncome);
            this.pnlAddCategory.Controls.Add(this.cbxExpense);
            this.pnlAddCategory.Controls.Add(this.txtName);
            this.pnlAddCategory.Controls.Add(this.lblChoose);
            this.pnlAddCategory.Controls.Add(this.lblName);
            this.pnlAddCategory.Location = new System.Drawing.Point(540, 10);
            this.pnlAddCategory.Name = "pnlAddCategory";
            this.pnlAddCategory.Size = new System.Drawing.Size(349, 750);
            this.pnlAddCategory.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblColor.AutoEllipsis = false;
            this.lblColor.CursorType = null;
            this.lblColor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblColor.Location = new System.Drawing.Point(26, 361);
            this.lblColor.Name = "lblColor";
            this.lblColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblColor.Size = new System.Drawing.Size(47, 23);
            this.lblColor.TabIndex = 23;
            this.lblColor.Text = "Color:";
            this.lblColor.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblColor.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // cbTaskColor
            // 
            this.cbTaskColor.BackgroundImage = global::Tick.Properties.Resources.Add;
            this.cbTaskColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbTaskColor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaskColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.cbTaskColor.Location = new System.Drawing.Point(105, 357);
            this.cbTaskColor.Name = "cbTaskColor";
            this.cbTaskColor.Size = new System.Drawing.Size(223, 27);
            this.cbTaskColor.TabIndex = 22;
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Active = false;
            this.btnSaveCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSaveCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveCategory.BorderRadius = 0;
            this.btnSaveCategory.ButtonText = "Save";
            this.btnSaveCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveCategory.Iconimage = global::Tick.Properties.Resources.save;
            this.btnSaveCategory.Iconimage_right = null;
            this.btnSaveCategory.Iconimage_right_Selected = null;
            this.btnSaveCategory.Iconimage_Selected = null;
            this.btnSaveCategory.IconMarginLeft = 0;
            this.btnSaveCategory.IconMarginRight = 0;
            this.btnSaveCategory.IconRightVisible = true;
            this.btnSaveCategory.IconRightZoom = 0D;
            this.btnSaveCategory.IconVisible = true;
            this.btnSaveCategory.IconZoom = 50D;
            this.btnSaveCategory.IsTab = false;
            this.btnSaveCategory.Location = new System.Drawing.Point(233, 89);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveCategory.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnSaveCategory.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveCategory.selected = false;
            this.btnSaveCategory.Size = new System.Drawing.Size(104, 47);
            this.btnSaveCategory.TabIndex = 21;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveCategory.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveCategory.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Active = false;
            this.btnDeleteCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteCategory.BorderRadius = 0;
            this.btnDeleteCategory.ButtonText = "Delete";
            this.btnDeleteCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteCategory.Iconimage = global::Tick.Properties.Resources.delete;
            this.btnDeleteCategory.Iconimage_right = null;
            this.btnDeleteCategory.Iconimage_right_Selected = null;
            this.btnDeleteCategory.Iconimage_Selected = null;
            this.btnDeleteCategory.IconMarginLeft = 0;
            this.btnDeleteCategory.IconMarginRight = 0;
            this.btnDeleteCategory.IconRightVisible = true;
            this.btnDeleteCategory.IconRightZoom = 0D;
            this.btnDeleteCategory.IconVisible = true;
            this.btnDeleteCategory.IconZoom = 50D;
            this.btnDeleteCategory.IsTab = false;
            this.btnDeleteCategory.Location = new System.Drawing.Point(123, 89);
            this.btnDeleteCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteCategory.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnDeleteCategory.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteCategory.selected = false;
            this.btnDeleteCategory.Size = new System.Drawing.Size(104, 47);
            this.btnDeleteCategory.TabIndex = 20;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteCategory.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteCategory.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // btnCancelCategory
            // 
            this.btnCancelCategory.Active = false;
            this.btnCancelCategory.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelCategory.BorderRadius = 0;
            this.btnCancelCategory.ButtonText = "Cancel";
            this.btnCancelCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelCategory.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelCategory.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCategory.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelCategory.Iconimage = global::Tick.Properties.Resources.cancel;
            this.btnCancelCategory.Iconimage_right = null;
            this.btnCancelCategory.Iconimage_right_Selected = null;
            this.btnCancelCategory.Iconimage_Selected = null;
            this.btnCancelCategory.IconMarginLeft = 0;
            this.btnCancelCategory.IconMarginRight = 0;
            this.btnCancelCategory.IconRightVisible = true;
            this.btnCancelCategory.IconRightZoom = 0D;
            this.btnCancelCategory.IconVisible = true;
            this.btnCancelCategory.IconZoom = 50D;
            this.btnCancelCategory.IsTab = false;
            this.btnCancelCategory.Location = new System.Drawing.Point(11, 89);
            this.btnCancelCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelCategory.Name = "btnCancelCategory";
            this.btnCancelCategory.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelCategory.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCancelCategory.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancelCategory.selected = false;
            this.btnCancelCategory.Size = new System.Drawing.Size(104, 47);
            this.btnCancelCategory.TabIndex = 19;
            this.btnCancelCategory.Text = "Cancel";
            this.btnCancelCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelCategory.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancelCategory.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelCategory.Click += new System.EventHandler(this.btnCancelCategory_Click);
            // 
            // lblIncome
            // 
            this.lblIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblIncome.AutoEllipsis = false;
            this.lblIncome.CursorType = null;
            this.lblIncome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIncome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblIncome.Location = new System.Drawing.Point(270, 294);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblIncome.Size = new System.Drawing.Size(58, 23);
            this.lblIncome.TabIndex = 18;
            this.lblIncome.Text = "Income";
            this.lblIncome.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblIncome.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblIncome.Click += new System.EventHandler(this.lblIncome_Click);
            // 
            // lblExpense
            // 
            this.lblExpense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpense.AutoEllipsis = false;
            this.lblExpense.CursorType = null;
            this.lblExpense.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblExpense.Location = new System.Drawing.Point(140, 300);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblExpense.Size = new System.Drawing.Size(63, 23);
            this.lblExpense.TabIndex = 17;
            this.lblExpense.Text = "Expense";
            this.lblExpense.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblExpense.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblExpense.Click += new System.EventHandler(this.lblExpense_Click);
            // 
            // cbxIncome
            // 
            this.cbxIncome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxIncome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxIncome.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxIncome.Checked = false;
            this.cbxIncome.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbxIncome.ForeColor = System.Drawing.Color.White;
            this.cbxIncome.Location = new System.Drawing.Point(244, 297);
            this.cbxIncome.Name = "cbxIncome";
            this.cbxIncome.Size = new System.Drawing.Size(20, 20);
            this.cbxIncome.TabIndex = 16;
            this.cbxIncome.OnChange += new System.EventHandler(this.cbxIncome_OnChange);
            // 
            // cbxExpense
            // 
            this.cbxExpense.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxExpense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbxExpense.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.cbxExpense.Checked = true;
            this.cbxExpense.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.cbxExpense.ForeColor = System.Drawing.Color.White;
            this.cbxExpense.Location = new System.Drawing.Point(114, 300);
            this.cbxExpense.Name = "cbxExpense";
            this.cbxExpense.Size = new System.Drawing.Size(20, 20);
            this.cbxExpense.TabIndex = 15;
            this.cbxExpense.OnChange += new System.EventHandler(this.cbxExpense_OnChange);
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = false;
            this.txtName.AcceptsTab = false;
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtName.BackColor = System.Drawing.Color.Transparent;
            this.txtName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtName.BackgroundImage")));
            this.txtName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(191)))), ((int)(((byte)(131)))));
            this.txtName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtName.BorderRadius = 1;
            this.txtName.BorderThickness = 2;
            this.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.DefaultText = "";
            this.txtName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtName.HideSelection = true;
            this.txtName.IconLeft = null;
            this.txtName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.IconPadding = 10;
            this.txtName.IconRight = null;
            this.txtName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtName.Location = new System.Drawing.Point(105, 233);
            this.txtName.MaxLength = 32767;
            this.txtName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtName.Modified = false;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = false;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(223, 35);
            this.txtName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtName.TabIndex = 14;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtName.TextMarginLeft = 5;
            this.txtName.TextPlaceholder = "";
            this.txtName.UseSystemPasswordChar = false;
            // 
            // lblChoose
            // 
            this.lblChoose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChoose.AutoEllipsis = false;
            this.lblChoose.CursorType = null;
            this.lblChoose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChoose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblChoose.Location = new System.Drawing.Point(40, 297);
            this.lblChoose.Name = "lblChoose";
            this.lblChoose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblChoose.Size = new System.Drawing.Size(33, 23);
            this.lblChoose.TabIndex = 5;
            this.lblChoose.Text = "Is it:";
            this.lblChoose.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblChoose.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoEllipsis = false;
            this.lblName.CursorType = null;
            this.lblName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.lblName.Location = new System.Drawing.Point(23, 245);
            this.lblName.Name = "lblName";
            this.lblName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblName.Size = new System.Drawing.Size(50, 23);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            this.lblName.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.lblName.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // dgvCategory
            // 
            this.dgvCategory.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvCategory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvCategory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategory.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCategory.DoubleBuffered = true;
            this.dgvCategory.EnableHeadersVisualStyles = false;
            this.dgvCategory.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvCategory.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvCategory.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvCategory.Location = new System.Drawing.Point(18, 63);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvCategory.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategory.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategory.RowHeadersWidth = 17;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvCategory.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCategory.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvCategory.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCategory.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvCategory.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvCategory.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvCategory.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvCategory.RowTemplate.Height = 60;
            this.dgvCategory.Size = new System.Drawing.Size(656, 675);
            this.dgvCategory.TabIndex = 5;
            // 
            // Category
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(800, 788);
            this.Controls.Add(this.dgvCategory);
            this.Controls.Add(this.pnlAddCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Category";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Category";
            this.Load += new System.EventHandler(this.Category_Load);
            this.pnlAddCategory.ResumeLayout(false);
            this.pnlAddCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaskColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnAddCategory;
        private System.Windows.Forms.Panel pnlAddCategory;
        private Bunifu.UI.WinForms.BunifuLabel lblChoose;
        private Bunifu.UI.WinForms.BunifuLabel lblName;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtName;
        private Bunifu.UI.WinForms.BunifuLabel lblIncome;
        private Bunifu.UI.WinForms.BunifuLabel lblExpense;
        private Bunifu.Framework.UI.BunifuCheckbox cbxIncome;
        private Bunifu.Framework.UI.BunifuCheckbox cbxExpense;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelCategory;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteCategory;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveCategory;
        private Bunifu.UI.WinForms.BunifuLabel lblColor;
        private Telerik.WinControls.UI.RadColorBox cbTaskColor;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvCategory;
    }
}
