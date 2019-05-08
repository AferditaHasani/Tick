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
            this.dvExpenses = new Bunifu.DataViz.WinForms.BunifuDataViz();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // dvExpenses
            // 
            this.dvExpenses.animationEnabled = false;
            this.dvExpenses.AxisLineColor = System.Drawing.Color.LightGray;
            this.dvExpenses.AxisXFontColor = System.Drawing.Color.Gray;
            this.dvExpenses.AxisXGridColor = System.Drawing.Color.Gray;
            this.dvExpenses.AxisXGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dvExpenses.AxisYFontColor = System.Drawing.Color.Gray;
            this.dvExpenses.AxisYGridColor = System.Drawing.Color.Gray;
            this.dvExpenses.AxisYGridThickness = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dvExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dvExpenses.Location = new System.Drawing.Point(41, 29);
            this.dvExpenses.Name = "dvExpenses";
            this.dvExpenses.Size = new System.Drawing.Size(732, 703);
            this.dvExpenses.TabIndex = 0;
            this.dvExpenses.Theme = Bunifu.DataViz.WinForms.BunifuDataViz._theme.theme1;
            this.dvExpenses.Title = "";
            this.dvExpenses.Click += new System.EventHandler(this.dvExpenses_Click);
            // 
            // ExpensesChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(808, 788);
            this.Controls.Add(this.dvExpenses);
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

        private Bunifu.DataViz.WinForms.BunifuDataViz dvExpenses;
    }
}
