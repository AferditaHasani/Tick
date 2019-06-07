using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Telerik.WinControls;
using Tick.BLL;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpensesChart));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.ExpensesPiechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlSearchByDate = new System.Windows.Forms.Panel();
            this.dtpDataGridExpenses = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnNextMonth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPreviousMonth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPreviousDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNextDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ExpensesLineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHelpECharts = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesPiechart)).BeginInit();
            this.pnlSearchByDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesLineChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ExpensesPiechart
            // 
            this.ExpensesPiechart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpensesPiechart.BackColor = System.Drawing.Color.Transparent;
            this.ExpensesPiechart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.ExpensesPiechart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.ExpensesPiechart.BorderlineColor = System.Drawing.Color.Transparent;
            this.ExpensesPiechart.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea1.Name = "ChartArea1";
            this.ExpensesPiechart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.Transparent;
            legend1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend1.HeaderSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend1.IsTextAutoFit = false;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend1.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ExpensesPiechart.Legends.Add(legend1);
            this.ExpensesPiechart.Location = new System.Drawing.Point(25, 374);
            this.ExpensesPiechart.Name = "ExpensesPiechart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.ExpensesPiechart.Series.Add(series1);
            this.ExpensesPiechart.Size = new System.Drawing.Size(610, 349);
            this.ExpensesPiechart.TabIndex = 8;
            this.ExpensesPiechart.Text = "TimePieChart";
            title1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            title1.Name = "Daily Expenses";
            title1.Text = "Daily Expenses";
            this.ExpensesPiechart.Titles.Add(title1);
            // 
            // pnlSearchByDate
            // 
            this.pnlSearchByDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSearchByDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSearchByDate.Controls.Add(this.dtpDataGridExpenses);
            this.pnlSearchByDate.Controls.Add(this.btnNextMonth);
            this.pnlSearchByDate.Controls.Add(this.btnPreviousMonth);
            this.pnlSearchByDate.Controls.Add(this.btnPreviousDay);
            this.pnlSearchByDate.Controls.Add(this.btnNextDay);
            this.pnlSearchByDate.Location = new System.Drawing.Point(57, 12);
            this.pnlSearchByDate.Name = "pnlSearchByDate";
            this.pnlSearchByDate.Size = new System.Drawing.Size(512, 38);
            this.pnlSearchByDate.TabIndex = 7;
            // 
            // dtpDataGridExpenses
            // 
            this.dtpDataGridExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDataGridExpenses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.dtpDataGridExpenses.Location = new System.Drawing.Point(81, 3);
            this.dtpDataGridExpenses.Name = "dtpDataGridExpenses";
            this.dtpDataGridExpenses.Size = new System.Drawing.Size(351, 31);
            this.dtpDataGridExpenses.TabIndex = 7;
            this.dtpDataGridExpenses.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.dtpDataGridExpenses_ValueChanged);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Active = false;
            this.btnNextMonth.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNextMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnNextMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNextMonth.BorderRadius = 0;
            this.btnNextMonth.ButtonText = "";
            this.btnNextMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNextMonth.DisabledColor = System.Drawing.Color.Gray;
            this.btnNextMonth.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNextMonth.Iconimage = global::Tick.Properties.Resources.nextMonth;
            this.btnNextMonth.Iconimage_right = null;
            this.btnNextMonth.Iconimage_right_Selected = null;
            this.btnNextMonth.Iconimage_Selected = null;
            this.btnNextMonth.IconMarginLeft = 0;
            this.btnNextMonth.IconMarginRight = 0;
            this.btnNextMonth.IconRightVisible = true;
            this.btnNextMonth.IconRightZoom = 0D;
            this.btnNextMonth.IconVisible = true;
            this.btnNextMonth.IconZoom = 65D;
            this.btnNextMonth.IsTab = false;
            this.btnNextMonth.Location = new System.Drawing.Point(477, 2);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNextMonth.OnHovercolor = System.Drawing.Color.Gray;
            this.btnNextMonth.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNextMonth.selected = false;
            this.btnNextMonth.Size = new System.Drawing.Size(32, 30);
            this.btnNextMonth.TabIndex = 5;
            this.btnNextMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNextMonth.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNextMonth.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.Active = false;
            this.btnPreviousMonth.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPreviousMonth.BackColor = System.Drawing.Color.Transparent;
            this.btnPreviousMonth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPreviousMonth.BorderRadius = 0;
            this.btnPreviousMonth.ButtonText = "";
            this.btnPreviousMonth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreviousMonth.DisabledColor = System.Drawing.Color.Gray;
            this.btnPreviousMonth.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPreviousMonth.Iconimage = global::Tick.Properties.Resources.previousMonth;
            this.btnPreviousMonth.Iconimage_right = null;
            this.btnPreviousMonth.Iconimage_right_Selected = null;
            this.btnPreviousMonth.Iconimage_Selected = null;
            this.btnPreviousMonth.IconMarginLeft = 0;
            this.btnPreviousMonth.IconMarginRight = 0;
            this.btnPreviousMonth.IconRightVisible = true;
            this.btnPreviousMonth.IconRightZoom = 0D;
            this.btnPreviousMonth.IconVisible = true;
            this.btnPreviousMonth.IconZoom = 65D;
            this.btnPreviousMonth.IsTab = false;
            this.btnPreviousMonth.Location = new System.Drawing.Point(5, 2);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPreviousMonth.OnHovercolor = System.Drawing.Color.Gray;
            this.btnPreviousMonth.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPreviousMonth.selected = false;
            this.btnPreviousMonth.Size = new System.Drawing.Size(32, 30);
            this.btnPreviousMonth.TabIndex = 6;
            this.btnPreviousMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPreviousMonth.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPreviousMonth.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
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
            this.btnPreviousDay.IconZoom = 65D;
            this.btnPreviousDay.IsTab = false;
            this.btnPreviousDay.Location = new System.Drawing.Point(43, 2);
            this.btnPreviousDay.Name = "btnPreviousDay";
            this.btnPreviousDay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnPreviousDay.OnHovercolor = System.Drawing.Color.Gray;
            this.btnPreviousDay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnPreviousDay.selected = false;
            this.btnPreviousDay.Size = new System.Drawing.Size(32, 30);
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
            this.btnNextDay.IconZoom = 65D;
            this.btnNextDay.IsTab = false;
            this.btnNextDay.Location = new System.Drawing.Point(438, 2);
            this.btnNextDay.Name = "btnNextDay";
            this.btnNextDay.Normalcolor = System.Drawing.Color.Transparent;
            this.btnNextDay.OnHovercolor = System.Drawing.Color.Gray;
            this.btnNextDay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNextDay.selected = false;
            this.btnNextDay.Size = new System.Drawing.Size(32, 30);
            this.btnNextDay.TabIndex = 4;
            this.btnNextDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNextDay.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnNextDay.TextFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextDay.Click += new System.EventHandler(this.btnNextDay_Click);
            // 
            // ExpensesLineChart
            // 
            this.ExpensesLineChart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExpensesLineChart.BackColor = System.Drawing.Color.Transparent;
            this.ExpensesLineChart.BackImageTransparentColor = System.Drawing.Color.Transparent;
            this.ExpensesLineChart.BackSecondaryColor = System.Drawing.Color.Transparent;
            this.ExpensesLineChart.BorderlineColor = System.Drawing.Color.Transparent;
            this.ExpensesLineChart.BorderSkin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisX.Title = "Date";
            chartArea2.AxisX.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisY.Title = "Amount";
            chartArea2.AxisY.TitleFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.BackColor = System.Drawing.Color.Transparent;
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea2.Name = "ChartArea1";
            this.ExpensesLineChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.Transparent;
            legend2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend2.HeaderSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend2.IsTextAutoFit = false;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend2.Name = "Legend1";
            legend2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend2.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ExpensesLineChart.Legends.Add(legend2);
            this.ExpensesLineChart.Location = new System.Drawing.Point(25, 56);
            this.ExpensesLineChart.Name = "ExpensesLineChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ExpensesLineChart.Series.Add(series2);
            this.ExpensesLineChart.Size = new System.Drawing.Size(610, 291);
            this.ExpensesLineChart.TabIndex = 6;
            this.ExpensesLineChart.Text = "TimeChart";
            title2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            title2.Name = "Monthly Expenses";
            title2.Text = "Monthly Expenses";
            this.ExpensesLineChart.Titles.Add(title2);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.panel1.Location = new System.Drawing.Point(25, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 3);
            this.panel1.TabIndex = 13;
            // 
            // btnHelpECharts
            // 
            this.btnHelpECharts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelpECharts.BackColor = System.Drawing.Color.Transparent;
            this.btnHelpECharts.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelpECharts.BackgroundImage")));
            this.btnHelpECharts.ButtonText = "";
            this.btnHelpECharts.ButtonTextMarginLeft = 0;
            this.btnHelpECharts.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnHelpECharts.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnHelpECharts.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnHelpECharts.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnHelpECharts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnHelpECharts.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnHelpECharts.IconPadding = 0;
            this.btnHelpECharts.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnHelpECharts.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnHelpECharts.IdleBorderRadius = 1;
            this.btnHelpECharts.IdleBorderThickness = 0;
            this.btnHelpECharts.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.btnHelpECharts.IdleIconLeftImage = global::Tick.Properties.Resources.icons8_help_48;
            this.btnHelpECharts.IdleIconRightImage = null;
            this.btnHelpECharts.Location = new System.Drawing.Point(635, 12);
            this.btnHelpECharts.Name = "btnHelpECharts";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties1.BorderRadius = 1;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(187)))), ((int)(((byte)(128)))));
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.btnHelpECharts.onHoverState = stateProperties1;
            this.btnHelpECharts.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnHelpECharts.Size = new System.Drawing.Size(30, 25);
            this.btnHelpECharts.TabIndex = 14;
            this.btnHelpECharts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelpECharts.Click += new System.EventHandler(this.btnHelpECharts_Click);
            // 
            // ExpensesChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(677, 788);
            this.Controls.Add(this.btnHelpECharts);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ExpensesPiechart);
            this.Controls.Add(this.pnlSearchByDate);
            this.Controls.Add(this.ExpensesLineChart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExpensesChart";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ExpensesChart";
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesPiechart)).EndInit();
            this.pnlSearchByDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesLineChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ExpensesPiechart;
        private System.Windows.Forms.Panel pnlSearchByDate;
        public Syncfusion.WinForms.Input.SfDateTimeEdit dtpDataGridExpenses;
        private Bunifu.Framework.UI.BunifuFlatButton btnNextMonth;
        private Bunifu.Framework.UI.BunifuFlatButton btnPreviousMonth;
        private Bunifu.Framework.UI.BunifuFlatButton btnPreviousDay;
        private Bunifu.Framework.UI.BunifuFlatButton btnNextDay;
        private System.Windows.Forms.DataVisualization.Charting.Chart ExpensesLineChart;
        private Panel panel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnHelpECharts;
    }
}
