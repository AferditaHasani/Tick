﻿using System;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ExpensesPiechart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pnlSearchByDate = new System.Windows.Forms.Panel();
            this.dtpDataGridExpenses = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.btnNextMonth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPreviousMonth = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPreviousDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNextDay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ExpensesLineChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            chartArea5.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.BackColor = System.Drawing.Color.Transparent;
            chartArea5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea5.Name = "ChartArea1";
            this.ExpensesPiechart.ChartAreas.Add(chartArea5);
            legend5.BackColor = System.Drawing.Color.Transparent;
            legend5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend5.HeaderSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend5.IsTextAutoFit = false;
            legend5.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend5.Name = "Legend1";
            legend5.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend5.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ExpensesPiechart.Legends.Add(legend5);
            this.ExpensesPiechart.Location = new System.Drawing.Point(25, 312);
            this.ExpensesPiechart.Name = "ExpensesPiechart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.ExpensesPiechart.Series.Add(series5);
            this.ExpensesPiechart.Size = new System.Drawing.Size(564, 295);
            this.ExpensesPiechart.TabIndex = 8;
            this.ExpensesPiechart.Text = "TimePieChart";
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
            chartArea6.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisX.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisX2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisX2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisY.MajorTickMark.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisY2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.AxisY2.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.BackColor = System.Drawing.Color.Transparent;
            chartArea6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            chartArea6.Name = "ChartArea1";
            this.ExpensesLineChart.ChartAreas.Add(chartArea6);
            legend6.BackColor = System.Drawing.Color.Transparent;
            legend6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            legend6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend6.HeaderSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend6.IsTextAutoFit = false;
            legend6.ItemColumnSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend6.Name = "Legend1";
            legend6.TitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            legend6.TitleSeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ExpensesLineChart.Legends.Add(legend6);
            this.ExpensesLineChart.Location = new System.Drawing.Point(25, 56);
            this.ExpensesLineChart.Name = "ExpensesLineChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.ExpensesLineChart.Series.Add(series6);
            this.ExpensesLineChart.Size = new System.Drawing.Size(564, 250);
            this.ExpensesLineChart.TabIndex = 6;
            this.ExpensesLineChart.Text = "TimeChart";
            // 
            // ExpensesChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(42)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(645, 676);
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
    }
}