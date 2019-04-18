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
    public partial class Category : Telerik.WinControls.UI.RadForm
    {
        string text="Expense";
        private string[] expensesRow;
        
        public Category()
        {
            InitializeComponent();
        }

        private void btnAddC_Click(object sender, EventArgs e)
        {
            expensesRow = new string[] { txtName.Text, text };
            dgvCategory.Rows.Add(expensesRow);

            Clear();
        }

        public void Clear()
        {
            txtName.Text = "";
            cbxExpense.Checked = true;
            cbxIncome.Checked = false;
        }

        private void cbxExpense_OnChange(object sender, EventArgs e)
        {
           cbxIncome.Checked = false;
           text = "Expense";

        }

        private void cbxIncome_OnChange(object sender, EventArgs e)
        {
          cbxExpense.Checked = false;
          text = "Income";

        }

        private void lblExpense_Click(object sender, EventArgs e)
        {
            cbxExpense.Checked = true;
            if (cbxExpense.Checked == true)
                cbxIncome.Checked = false;
            text = "Expense";
        }

        private void lblIncome_Click(object sender, EventArgs e)
        {
            cbxIncome.Checked = true;
            if (cbxIncome.Checked == true)
                cbxExpense.Checked = false;
            text = "Income";
        }



        private void OpenCategory()
        {
            pnlAddCategory.Visible = false;
            pnlGridViewCategory.Controls.Add(dgvCategory);

            pnlGridViewCategory.Visible = true;
            pnlAddCategory.Visible = false;

            pnlGridViewCategory.Location = new Point(12, 80);



            //FillGrid();
        }

        //private void FillGrid()
        //{

        //    //  string[] expensesRow = new string[] { "Product 1", "1000"};
        //    // dgvCategory.Rows.Add(expensesRow);

        //    expensesRow = new string[] { "Product 2", "2000" };
        //    dgvCategory.Rows.Add(expensesRow);
        //    expensesRow = new string[] { "Product 3", "3000" };
        //    dgvCategory.Rows.Add(expensesRow);
        //    expensesRow = new string[] { "4", "Product 4" };
        //    dgvCategory.Rows.Add(expensesRow);


        //    expensesRow = new string[] { "Product 2", "2000" };
        //    dgvCategory.Rows.Add(expensesRow);
        //    expensesRow = new string[] { "Product 3", "3000" };
        //    dgvCategory.Rows.Add(expensesRow);
        //    expensesRow = new string[] { "4", "Product 4" };
        //    dgvCategory.Rows.Add(expensesRow);

        //}

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            pnlAddCategory.Visible = true;
            pnlGridViewCategory.Visible = true;

            pnlAddCategory.Location = new Point(12, 80);
            pnlGridViewCategory.Location = new Point(12, 320);
        }

        private void Category_Load(object sender, EventArgs e)
        {
            OpenCategory();
        }
    }
}
