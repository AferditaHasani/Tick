namespace Tick.TimeManagement
{
    partial class Tasks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tasks));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlAddTask = new System.Windows.Forms.Panel();
            this.cbTaskColor = new Telerik.WinControls.UI.RadColorBox();
            this.rtxtTaskDescription = new System.Windows.Forms.RichTextBox();
            this.txtTaskName = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.btnCancelTask = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTaskColor = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblDescription = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblTaskName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnDeleteTask = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSaveTask = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dgvTasks = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnAddTask = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlAddTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaskColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddTask
            // 
            this.pnlAddTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAddTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.pnlAddTask.Controls.Add(this.cbTaskColor);
            this.pnlAddTask.Controls.Add(this.rtxtTaskDescription);
            this.pnlAddTask.Controls.Add(this.txtTaskName);
            this.pnlAddTask.Controls.Add(this.btnCancelTask);
            this.pnlAddTask.Controls.Add(this.lblTaskColor);
            this.pnlAddTask.Controls.Add(this.lblDescription);
            this.pnlAddTask.Controls.Add(this.lblTaskName);
            this.pnlAddTask.Controls.Add(this.btnDeleteTask);
            this.pnlAddTask.Controls.Add(this.btnSaveTask);
            this.pnlAddTask.Location = new System.Drawing.Point(690, 12);
            this.pnlAddTask.Name = "pnlAddTask";
            this.pnlAddTask.Size = new System.Drawing.Size(10, 748);
            this.pnlAddTask.TabIndex = 5;
            // 
            // cbTaskColor
            // 
            this.cbTaskColor.BackgroundImage = global::Tick.Properties.Resources.Add;
            this.cbTaskColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cbTaskColor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTaskColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.cbTaskColor.Location = new System.Drawing.Point(36, 402);
            this.cbTaskColor.Name = "cbTaskColor";
            this.cbTaskColor.Size = new System.Drawing.Size(258, 27);
            this.cbTaskColor.TabIndex = 18;
            // 
            // rtxtTaskDescription
            // 
            this.rtxtTaskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.rtxtTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtxtTaskDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.rtxtTaskDescription.Location = new System.Drawing.Point(36, 231);
            this.rtxtTaskDescription.Name = "rtxtTaskDescription";
            this.rtxtTaskDescription.Size = new System.Drawing.Size(258, 96);
            this.rtxtTaskDescription.TabIndex = 17;
            this.rtxtTaskDescription.Text = "";
            // 
            // txtTaskName
            // 
            this.txtTaskName.AcceptsReturn = false;
            this.txtTaskName.AcceptsTab = false;
            this.txtTaskName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTaskName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTaskName.BackColor = System.Drawing.Color.Transparent;
            this.txtTaskName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtTaskName.BackgroundImage")));
            this.txtTaskName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTaskName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTaskName.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTaskName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.txtTaskName.BorderRadius = 5;
            this.txtTaskName.BorderThickness = 2;
            this.txtTaskName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtTaskName.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskName.DefaultText = "";
            this.txtTaskName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.txtTaskName.HideSelection = true;
            this.txtTaskName.IconLeft = null;
            this.txtTaskName.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.txtTaskName.IconPadding = 10;
            this.txtTaskName.IconRight = null;
            this.txtTaskName.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.txtTaskName.Location = new System.Drawing.Point(36, 140);
            this.txtTaskName.MaxLength = 32767;
            this.txtTaskName.MinimumSize = new System.Drawing.Size(100, 35);
            this.txtTaskName.Modified = false;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PasswordChar = '\0';
            this.txtTaskName.ReadOnly = false;
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.SelectionLength = 0;
            this.txtTaskName.SelectionStart = 0;
            this.txtTaskName.ShortcutsEnabled = true;
            this.txtTaskName.Size = new System.Drawing.Size(258, 35);
            this.txtTaskName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.txtTaskName.TabIndex = 16;
            this.txtTaskName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTaskName.TextMarginLeft = 5;
            this.txtTaskName.TextPlaceholder = "";
            this.txtTaskName.UseSystemPasswordChar = false;
            // 
            // btnCancelTask
            // 
            this.btnCancelTask.Active = false;
            this.btnCancelTask.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelTask.BorderRadius = 0;
            this.btnCancelTask.ButtonText = "Cancel";
            this.btnCancelTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelTask.DisabledColor = System.Drawing.Color.Gray;
            this.btnCancelTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTask.Iconcolor = System.Drawing.Color.Transparent;
            this.btnCancelTask.Iconimage = global::Tick.Properties.Resources.cancel;
            this.btnCancelTask.Iconimage_right = null;
            this.btnCancelTask.Iconimage_right_Selected = null;
            this.btnCancelTask.Iconimage_Selected = null;
            this.btnCancelTask.IconMarginLeft = 0;
            this.btnCancelTask.IconMarginRight = 0;
            this.btnCancelTask.IconRightVisible = true;
            this.btnCancelTask.IconRightZoom = 0D;
            this.btnCancelTask.IconVisible = true;
            this.btnCancelTask.IconZoom = 50D;
            this.btnCancelTask.IsTab = false;
            this.btnCancelTask.Location = new System.Drawing.Point(16, 22);
            this.btnCancelTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelTask.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCancelTask.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancelTask.selected = false;
            this.btnCancelTask.Size = new System.Drawing.Size(101, 47);
            this.btnCancelTask.TabIndex = 15;
            this.btnCancelTask.Text = "Cancel";
            this.btnCancelTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelTask.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancelTask.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // 
            // lblTaskColor
            // 
            this.lblTaskColor.AutoSize = true;
            this.lblTaskColor.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskColor.Location = new System.Drawing.Point(32, 357);
            this.lblTaskColor.Name = "lblTaskColor";
            this.lblTaskColor.Size = new System.Drawing.Size(50, 21);
            this.lblTaskColor.TabIndex = 6;
            this.lblTaskColor.Text = "Color";
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
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(32, 103);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(53, 21);
            this.lblTaskName.TabIndex = 4;
            this.lblTaskName.Text = "Name";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Active = false;
            this.btnDeleteTask.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteTask.BorderRadius = 0;
            this.btnDeleteTask.ButtonText = "Delete";
            this.btnDeleteTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTask.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteTask.Iconimage = global::Tick.Properties.Resources.delete;
            this.btnDeleteTask.Iconimage_right = null;
            this.btnDeleteTask.Iconimage_right_Selected = null;
            this.btnDeleteTask.Iconimage_Selected = null;
            this.btnDeleteTask.IconMarginLeft = 0;
            this.btnDeleteTask.IconMarginRight = 0;
            this.btnDeleteTask.IconRightVisible = true;
            this.btnDeleteTask.IconRightZoom = 0D;
            this.btnDeleteTask.IconVisible = true;
            this.btnDeleteTask.IconZoom = 50D;
            this.btnDeleteTask.IsTab = false;
            this.btnDeleteTask.Location = new System.Drawing.Point(111, 22);
            this.btnDeleteTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTask.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnDeleteTask.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteTask.selected = false;
            this.btnDeleteTask.Size = new System.Drawing.Size(104, 47);
            this.btnDeleteTask.TabIndex = 2;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteTask.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteTask.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // btnSaveTask
            // 
            this.btnSaveTask.Active = false;
            this.btnSaveTask.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSaveTask.BorderRadius = 0;
            this.btnSaveTask.ButtonText = "Save";
            this.btnSaveTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTask.DisabledColor = System.Drawing.Color.Gray;
            this.btnSaveTask.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTask.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSaveTask.Iconimage = global::Tick.Properties.Resources.save;
            this.btnSaveTask.Iconimage_right = null;
            this.btnSaveTask.Iconimage_right_Selected = null;
            this.btnSaveTask.Iconimage_Selected = null;
            this.btnSaveTask.IconMarginLeft = 0;
            this.btnSaveTask.IconMarginRight = 0;
            this.btnSaveTask.IconRightVisible = true;
            this.btnSaveTask.IconRightZoom = 0D;
            this.btnSaveTask.IconVisible = true;
            this.btnSaveTask.IconZoom = 50D;
            this.btnSaveTask.IsTab = false;
            this.btnSaveTask.Location = new System.Drawing.Point(223, 22);
            this.btnSaveTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTask.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnSaveTask.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveTask.selected = false;
            this.btnSaveTask.Size = new System.Drawing.Size(101, 47);
            this.btnSaveTask.TabIndex = 1;
            this.btnSaveTask.Text = "Save";
            this.btnSaveTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveTask.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveTask.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // dgvTasks
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTasks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTasks.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTasks.DoubleBuffered = true;
            this.dgvTasks.EnableHeadersVisualStyles = false;
            this.dgvTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvTasks.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTasks.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.Location = new System.Drawing.Point(12, 85);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTasks.RowHeadersWidth = 10;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTasks.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvTasks.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTasks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTasks.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTasks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvTasks.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.RowTemplate.Height = 60;
            this.dgvTasks.Size = new System.Drawing.Size(656, 675);
            this.dgvTasks.TabIndex = 4;
            this.dgvTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            this.dgvTasks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasks_RowHeaderMouseClick);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Active = false;
            this.btnAddTask.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddTask.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddTask.BorderRadius = 0;
            this.btnAddTask.ButtonText = "   Add Task";
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddTask.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddTask.Iconimage = global::Tick.Properties.Resources.add1;
            this.btnAddTask.Iconimage_right = null;
            this.btnAddTask.Iconimage_right_Selected = null;
            this.btnAddTask.Iconimage_Selected = null;
            this.btnAddTask.IconMarginLeft = 0;
            this.btnAddTask.IconMarginRight = 0;
            this.btnAddTask.IconRightVisible = true;
            this.btnAddTask.IconRightZoom = 0D;
            this.btnAddTask.IconVisible = true;
            this.btnAddTask.IconZoom = 80D;
            this.btnAddTask.IsTab = false;
            this.btnAddTask.Location = new System.Drawing.Point(12, 12);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddTask.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAddTask.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTask.selected = false;
            this.btnAddTask.Size = new System.Drawing.Size(161, 36);
            this.btnAddTask.TabIndex = 3;
            this.btnAddTask.Text = "   Add Task";
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTask.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // Tasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(752, 788);
            this.Controls.Add(this.pnlAddTask);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.btnAddTask);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tasks";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Task";
            this.Load += new System.EventHandler(this.Tasks_Load);
            this.pnlAddTask.ResumeLayout(false);
            this.pnlAddTask.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaskColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAddTask;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox txtTaskName;
        private Bunifu.Framework.UI.BunifuFlatButton btnCancelTask;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTaskColor;
        private Bunifu.Framework.UI.BunifuCustomLabel lblDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTaskName;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteTask;
        private Bunifu.Framework.UI.BunifuFlatButton btnSaveTask;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvTasks;
        private new string Name;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddTask;
        private System.Windows.Forms.RichTextBox rtxtTaskDescription;
        private Telerik.WinControls.UI.RadColorBox cbTaskColor;
    }
}
