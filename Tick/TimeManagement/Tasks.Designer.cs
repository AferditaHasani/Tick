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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
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
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pnlAddTask.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbTaskColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlAddTask
            // 
            resources.ApplyResources(this.pnlAddTask, "pnlAddTask");
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
            this.pnlAddTask.Name = "pnlAddTask";
            // 
            // cbTaskColor
            // 
            this.cbTaskColor.BackgroundImage = global::Tick.Properties.Resources.Add;
            resources.ApplyResources(this.cbTaskColor, "cbTaskColor");
            this.cbTaskColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.cbTaskColor.Name = "cbTaskColor";
            this.cbTaskColor.ValueChanged += new System.EventHandler(this.cbTaskColor_ValueChanged);
            // 
            // rtxtTaskDescription
            // 
            this.rtxtTaskDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.rtxtTaskDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.rtxtTaskDescription, "rtxtTaskDescription");
            this.rtxtTaskDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.rtxtTaskDescription.Name = "rtxtTaskDescription";
            // 
            // txtTaskName
            // 
            this.txtTaskName.AcceptsReturn = false;
            this.txtTaskName.AcceptsTab = false;
            this.txtTaskName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtTaskName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtTaskName.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.txtTaskName, "txtTaskName");
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
            this.txtTaskName.MaxLength = 32767;
            this.txtTaskName.Modified = false;
            this.txtTaskName.Name = "txtTaskName";
            this.txtTaskName.PasswordChar = '\0';
            this.txtTaskName.ReadOnly = false;
            this.txtTaskName.SelectedText = "";
            this.txtTaskName.SelectionLength = 0;
            this.txtTaskName.SelectionStart = 0;
            this.txtTaskName.ShortcutsEnabled = true;
            this.txtTaskName.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
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
            resources.ApplyResources(this.btnCancelTask, "btnCancelTask");
            this.btnCancelTask.BorderRadius = 0;
            this.btnCancelTask.ButtonText = "Cancel";
            this.btnCancelTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelTask.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnCancelTask.Name = "btnCancelTask";
            this.btnCancelTask.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnCancelTask.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnCancelTask.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancelTask.selected = false;
            this.btnCancelTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCancelTask.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnCancelTask.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelTask.Click += new System.EventHandler(this.btnCancelTask_Click);
            // 
            // lblTaskColor
            // 
            resources.ApplyResources(this.lblTaskColor, "lblTaskColor");
            this.lblTaskColor.Name = "lblTaskColor";
            // 
            // lblDescription
            // 
            resources.ApplyResources(this.lblDescription, "lblDescription");
            this.lblDescription.Name = "lblDescription";
            // 
            // lblTaskName
            // 
            resources.ApplyResources(this.lblTaskName, "lblTaskName");
            this.lblTaskName.Name = "lblTaskName";
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Active = false;
            this.btnDeleteTask.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            resources.ApplyResources(this.btnDeleteTask, "btnDeleteTask");
            this.btnDeleteTask.BorderRadius = 0;
            this.btnDeleteTask.ButtonText = "Delete";
            this.btnDeleteTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteTask.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnDeleteTask.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnDeleteTask.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnDeleteTask.selected = false;
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
            resources.ApplyResources(this.btnSaveTask, "btnSaveTask");
            this.btnSaveTask.BorderRadius = 0;
            this.btnSaveTask.ButtonText = "Save";
            this.btnSaveTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveTask.DisabledColor = System.Drawing.Color.Gray;
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
            this.btnSaveTask.Name = "btnSaveTask";
            this.btnSaveTask.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnSaveTask.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnSaveTask.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveTask.selected = false;
            this.btnSaveTask.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSaveTask.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnSaveTask.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveTask.Click += new System.EventHandler(this.btnSaveTask_Click);
            // 
            // dgvTasks
            // 
            this.dgvTasks.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            resources.ApplyResources(this.dgvTasks, "dgvTasks");
            this.dgvTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTasks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTasks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTasks.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(15, 20, 15, 20);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTasks.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTasks.DoubleBuffered = true;
            this.dgvTasks.EnableHeadersVisualStyles = false;
            this.dgvTasks.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTasks.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(15);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTasks.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.dgvTasks.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTasks.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.dgvTasks.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DimGray;
            this.dgvTasks.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.dgvTasks.RowTemplate.Height = 60;
            this.dgvTasks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            this.dgvTasks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTasks_CellContentClick);
            this.dgvTasks.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTasks_RowHeaderMouseClick);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Active = false;
            this.btnAddTask.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddTask.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.btnAddTask, "btnAddTask");
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
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Normalcolor = System.Drawing.Color.Transparent;
            this.btnAddTask.OnHovercolor = System.Drawing.Color.Gray;
            this.btnAddTask.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTask.selected = false;
            this.btnAddTask.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTask.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnAddTask.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
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
            // Tasks
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.pnlAddTask);
            this.Controls.Add(this.dgvTasks);
            this.Controls.Add(this.btnAddTask);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Tasks";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
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
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}
