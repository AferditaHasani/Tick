namespace Tick.ExpensesManagement
{
    partial class ExpensesChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesChart));
            this.dvTime = new Bunifu.DataViz.WinForms.BunifuDataViz();
            this.btnWeek = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMonth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDay = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dvTime
            // 
            this.dvTime.animationEnabled = false;
            this.dvTime.AxisLineColor = System.Drawing.Color.LightGray;
            this.dvTime.AxisXFontColor = System.Drawing.Color.Gray;
            this.dvTime.AxisXGridColor = System.Drawing.Color.Gray;
            this.dvTime.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dvTime.AxisYFontColor = System.Drawing.Color.Gray;
            this.dvTime.AxisYGridColor = System.Drawing.Color.Gray;
            this.dvTime.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dvTime.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dvTime.Location = new System.Drawing.Point(12, 115);
            this.dvTime.Name = "dvTime";
            this.dvTime.Size = new System.Drawing.Size(758, 419);
            this.dvTime.TabIndex = 0;
            this.dvTime.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.dvTime.Title = "";
            this.dvTime.Click += new System.EventHandler(this.dvExpenses_Click);
            // 
            // btnWeek
            // 
            this.btnWeek.Active = false;
            this.btnWeek.Activecolor = System.Drawing.Color.Transparent;
            this.btnWeek.BackColor = System.Drawing.Color.Transparent;
            this.btnWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWeek.BorderRadius = 0;
            this.btnWeek.ButtonText = "Week";
            this.btnWeek.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWeek.DisabledColor = System.Drawing.Color.Gray;
            this.btnWeek.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWeek.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnWeek.Iconimage")));
            this.btnWeek.Iconimage_right = null;
            this.btnWeek.Iconimage_right_Selected = null;
            this.btnWeek.Iconimage_Selected = null;
            this.btnWeek.IconMarginLeft = 0;
            this.btnWeek.IconMarginRight = 0;
            this.btnWeek.IconRightVisible = true;
            this.btnWeek.IconRightZoom = 0D;
            this.btnWeek.IconVisible = true;
            this.btnWeek.IconZoom = 90D;
            this.btnWeek.IsTab = false;
            this.btnWeek.Location = new System.Drawing.Point(417, 44);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Normalcolor = System.Drawing.Color.Transparent;
            this.btnWeek.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnWeek.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnWeek.selected = false;
            this.btnWeek.Size = new System.Drawing.Size(163, 45);
            this.btnWeek.TabIndex = 2;
            this.btnWeek.Text = "Week";
            this.btnWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeek.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnWeek.TextFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnMonth
            // 
            this.btnMonth.Active = false;
            this.btnMonth.Activecolor = System.Drawing.Color.Transparent;
            this.btnMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMonth.BorderRadius = 0;
            this.btnMonth.ButtonText = "Month";
            this.btnMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMonth.DisabledColor = System.Drawing.Color.Gray;
            this.btnMonth.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMonth.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMonth.Iconimage")));
            this.btnMonth.Iconimage_right = null;
            this.btnMonth.Iconimage_right_Selected = null;
            this.btnMonth.Iconimage_Selected = null;
            this.btnMonth.IconMarginLeft = 0;
            this.btnMonth.IconMarginRight = 0;
            this.btnMonth.IconRightVisible = true;
            this.btnMonth.IconRightZoom = 0D;
            this.btnMonth.IconVisible = true;
            this.btnMonth.IconZoom = 90D;
            this.btnMonth.IsTab = false;
            this.btnMonth.Location = new System.Drawing.Point(586, 44);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Normalcolor = System.Drawing.Color.Transparent;
            this.btnMonth.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMonth.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnMonth.selected = false;
            this.btnMonth.Size = new System.Drawing.Size(163, 45);
            this.btnMonth.TabIndex = 3;
            this.btnMonth.Text = "Month";
            this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonth.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnMonth.TextFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnDay
            // 
            this.btnDay.Active = false;
            this.btnDay.Activecolor = System.Drawing.Color.Transparent;
            this.btnDay.BackColor = System.Drawing.Color.Transparent;
            this.btnDay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDay.BorderRadius = 0;
            this.btnDay.ButtonText = "Day";
            this.btnDay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDay.DisabledColor = System.Drawing.Color.Gray;
            this.btnDay.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDay.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDay.Iconimage")));
            this.btnDay.Iconimage_right = null;
            this.btnDay.Iconimage_right_Selected = null;
            this.btnDay.Iconimage_Selected = null;
            this.btnDay.IconMarginLeft = 0;
            this.btnDay.IconMarginRight = 0;
            this.btnDay.IconRightVisible = true;
            this.btnDay.IconRightZoom = 0D;
            this.btnDay.IconVisible = true;
            this.btnDay.IconZoom = 90D;
            this.btnDay.IsTab = false;
            this.btnDay.Location = new System.Drawing.Point(248, 44);
            this.btnDay.Name = "btnDay";
            this.btnDay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnDay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDay.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.btnDay.selected = false;
            this.btnDay.Size = new System.Drawing.Size(163, 45);
            this.btnDay.TabIndex = 4;
            this.btnDay.Text = "Day";
            this.btnDay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDay.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnDay.TextFont = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ExpensesChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(784, 788);
            this.Controls.Add(this.btnDay);
            this.Controls.Add(this.btnMonth);
            this.Controls.Add(this.btnWeek);
            this.Controls.Add(this.dvTime);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpensesChart";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ExpensesChart";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.DataViz.WinForms.BunifuDataViz dvTime;
        private Bunifu.Framework.UI.BunifuFlatButton btnWeek;
        private Bunifu.Framework.UI.BunifuFlatButton btnMonth;
        private Bunifu.Framework.UI.BunifuFlatButton btnDay;
    }
}
