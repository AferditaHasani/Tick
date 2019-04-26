﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Tick.BLL;

namespace Tick.ExpensesManagement
{
    public partial class Category : Telerik.WinControls.UI.RadForm
    {
        bool isExpense=true;
        private string text;
     
        private CategoryBLL categoryBLL_service = new CategoryBLL();
        BO.Category cat= new BO.Category();

        public Category()
        {
            InitializeComponent();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            pnlAddCategory.Visible = true;
            dgvCategory.Size=new Size(680,697);

            cat = null;
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
                isExpense = true;
                text = "Expense";
            }
            else
            {
                isExpense = false;
                text = "Income";
            }
            if (cat == null)
                Save();
            else
                Update();


            DisplayToDGrid();

            Clear();
        }



        public void Clear()
        {
            txtName.Text = "";
            cbxExpense.Checked = true;
            cbxIncome.Checked = false;
            cat = null;
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


        public void DisplayToDGrid()
        {
            try
            {
                dgvCategory.Refresh();
                DataTable t = categoryBLL_service.GetAll();
                if (t != null)
                {
                    dgvCategory.DataSource = t;
                    
                }
                else
                {
                    MessageBox.Show("No records");

                }

            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }

        public void Save()
        {
            try
            {
                cat = Get();
                if (cat == null)
                {
                    MessageBox.Show("Error");
                    return;
                }

                var saved = categoryBLL_service.Insert(cat);

                MessageBox.Show(saved ? "Saved Successfully" : "Saving failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Update()
        {
            try
            {

                if (cat == null)
                {
                    MessageBox.Show("Error");
                    return;
                }


                cat.Name = txtName.Text;
                cat.IsExpenses = isExpense;
                var saved = categoryBLL_service.Update(cat);

                MessageBox.Show(saved ? "Updated Successfully" : "Updating failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public BO.Category Get()
        {
            try
            {
                BO.Category category = new BO.Category
                {
                    Name=txtName.Text,
                    IsExpenses = isExpense,
                    InsertBy = 1,
                    InsertDate = DateTime.Now
                      

                };
                return category;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void Category_Load(object sender, EventArgs e)
        {
     
            DisplayToDGrid();
            pnlAddCategory.Visible = false;
           dgvCategory.Visible = true;
           dgvCategory.Size = new Size(708, 697);

        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cat = new BO.Category();

            pnlAddCategory.Visible = true;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
                cat.CategoryID = int.Parse(row.Cells["CategoryID"].Value.ToString());
                cat.Name = row.Cells["Name"].Value.ToString();
               
             
                cat.IsExpenses =(bool)row.Cells["IsExpenses"].Value;
            }

        }

        private void dgvCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cat = new BO.Category();
            pnlAddCategory.Visible = true;
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
                cat.CategoryID = int.Parse(row.Cells["CategoryID"].Value.ToString());
                cat.Name = row.Cells["Name"].Value.ToString();
                cat.IsExpenses = (bool)row.Cells["IsExpenses"].Value;
            }
        }

        private void Delete()
        {
            try
            {

                if (cat == null)
                {
                    MessageBox.Show("No record to delete");
                    return;
                }

                var deleted = categoryBLL_service.Delete(cat);

                MessageBox.Show(deleted ? "Deleted Successfully" : "Deleting failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            cat = null;
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            Delete();
            DisplayToDGrid();
        }
    }
}
