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
        private string[] categoryRow;
        
        public Category()
        {
            InitializeComponent();
        }


        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            pnlAddCategory.Visible = true;
            dgvCategory.Size=new Size(680,697);

           

        }
        private void btnCancelCategory_Click(object sender, EventArgs e)
        {
            pnlAddCategory.Visible = false;

            dgvCategory.Size = new Size(817, 697);
         

        }
        private void btnSaveCategory_Click(object sender, EventArgs e)
        {
            if (cbxExpense.Checked == true)
            {
                text = "Expense";
            }
            else
            {
                text = "Income";
            }


            categoryRow = new string[] {"", txtName.Text, text };

            dgvCategory.Rows.Add(categoryRow);

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
        

        }

        private void cbxIncome_OnChange(object sender, EventArgs e)
        {
          cbxExpense.Checked = false;
       

        }

        private void lblExpense_Click(object sender, EventArgs e)
        {
            cbxExpense.Checked = true;
            if (cbxExpense.Checked == true)
                cbxIncome.Checked = false;
          
        }

        private void lblIncome_Click(object sender, EventArgs e)
        {
            cbxIncome.Checked = true;
            if (cbxIncome.Checked == true)
                cbxExpense.Checked = false;
           
        }



        //private void OpenCategory()
        //{
        //    pnlAddCategory.Visible = false;
        // //   pnlGridViewCategory.Controls.Add(dgvCategory);

        //   // pnlGridViewCategory.Visible = true;
        //    pnlAddCategory.Visible = false;

        //   // pnlGridViewCategory.Location = new Point(12, 80);



        //    //FillGrid();
        //}

        //private void FillGrid()
        //{

        //    //  string[] categoryRow = new string[] { "Product 1", "1000"};
        //    // dgvCategory.Rows.Add(categoryRow);

        //    categoryRow = new string[] { "Salary", "Income" };
        //    dgvCategory.Rows.Add(categoryRow);
        //    categoryRow = new string[] { "Rent", "Expense" };
        //    dgvCategory.Rows.Add(categoryRow);
        //    categoryRow = new string[] { "Shopping", "Expense" };
        //    dgvCategory.Rows.Add(categoryRow);

        //}


        private void Category_Load(object sender, EventArgs e)
        {
           // OpenCategory();
           pnlAddCategory.Visible = false;
           dgvCategory.Visible = true;
           dgvCategory.Size = new Size(708, 697);
            categoryRow = new string[] { "","Name", "IsExpense" };
            dgvCategory.Rows.Add(categoryRow);

        }





    }
}
