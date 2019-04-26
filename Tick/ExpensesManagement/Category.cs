using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Tick.BO;
using Tick.BLL;


namespace Tick.ExpensesManagment
{
    public partial class Category : Telerik.WinControls.UI.RadForm
    {
        bool isExpense=true;
       
        private string[] categoryRow;
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
            }
            else
            {
                isExpense = false;
            }


         categoryRow = new string[] {"", txtName.Text, isExpense.ToString() };

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
           // OpenCategory();
           pnlAddCategory.Visible = false;
           dgvCategory.Visible = true;
           dgvCategory.Size = new Size(708, 697);
            categoryRow = new string[] { "","Name", "IsExpense" };
            dgvCategory.Rows.Add(categoryRow);

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
    }
}
