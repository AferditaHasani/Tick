using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Tick.ExpensesManagment
{
    public partial class ExpensesTracking : Telerik.WinControls.UI.RadForm
    {
        private string[] expensesRow;
        public ExpensesTracking()
        {
            InitializeComponent();
        }
        private void ExpensesTracking_Load(object sender, EventArgs e)
        {
            OpenTransaction();
            ddlCategory.Items.Clear();
            ddlCategory.Items.Add("Rent");
            ddlCategory.Items.Add("Salary");
            ddlCategory.Items.Add("Shopping");
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            pnlAddTransaction.Visible = true;
            pnlGridViewEx.Visible = true;

            pnlAddTransaction.Location = new Point(12, 80);
            pnlGridViewEx.Location = new Point(12, 371);

        }

        private void OpenTransaction()
        {
            pnlGridViewEx.Controls.Add(dgvTransaction);
           
            pnlGridViewEx.Visible = true;
            pnlAddTransaction.Visible = false;

            pnlGridViewEx.Location = new Point(12, 80);

           

           // FillGrid();
        }

        //private void FillGrid()
        //{
            
        //    string[] expensesRow = new string[] { "Product 1", "1000", "1", "1" };
        //    dgvTransaction.Rows.Add(expensesRow);

        //    expensesRow = new string[] { "Product 2", "2000", "1", "1" };
        //    dgvTransaction.Rows.Add(expensesRow);
        //    expensesRow = new string[] { "Product 3", "3000", "1", "1" };
        //    dgvTransaction.Rows.Add(expensesRow);
        //    expensesRow = new string[] { "4", "Product 4", "4000", "1", "1" };
        //    dgvTransaction.Rows.Add(expensesRow);
         

        //    expensesRow = new string[] { "Product 2", "2000", "1", "1" };
        //    dgvTransaction.Rows.Add(expensesRow);
        //    expensesRow = new string[] { "Product 3", "3000", "1", "1" };
        //    dgvTransaction.Rows.Add(expensesRow);
        //    expensesRow = new string[] { "4", "Product 4", "4000", "1", "1" };
        //    dgvTransaction.Rows.Add(expensesRow);
           
            
        //}

        private void btnAddT_Click(object sender, EventArgs e)
        {
            expensesRow = new string[] { txtAmount.Text, ddlCategory.SelectedItem.ToString(),txtDescription.Text };
            dgvTransaction.Rows.Add(expensesRow);

            Clear();
           // OpenTransaction();
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsDigit(e.KeyChar)
                && e.KeyChar != '.')
            {
                e.Handled = true;
            }

           
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
            
        }

        public void Clear()
        {
            txtAmount.Text = "";
            txtDescription.Text = "";
        }
    }
}
