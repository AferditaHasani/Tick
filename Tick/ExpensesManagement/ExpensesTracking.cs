using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Tick.BLL;

namespace Tick.ExpensesManagement
{
    public partial class ExpensesTracking : Telerik.WinControls.UI.RadForm
    {
    
        public ExpensesTracking()
        {
            InitializeComponent();
        }

        private ExpensesTrackingBLL eTracking_service=new ExpensesTrackingBLL();
        BO.ExpensesTracking transaction= new BO.ExpensesTracking();

        private void ExpensesTracking_Load(object sender, EventArgs e)
        {
            pnlAddTransaction.Visible = false;
            dgvTransaction.Visible = true;
            dgvTransaction.Size = new Size(708, 697);
            FillCombo();
            DisplayToDGrid();



            //  OpenTransaction();


        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            pnlAddTransaction.Visible = true;
            dgvTransaction.Size = new Size(680, 697);



        }

     

        private void btnAddT_Click(object sender, EventArgs e)
        {
       

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


        public void Save()
        {
            try
            {
                transaction = Get();
                if (transaction == null)
                {
                    MessageBox.Show("Error");
                    return;
                }

                var saved = eTracking_service.Insert(transaction);

                MessageBox.Show(saved ? "Saved Successfully" : "Saving failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public BO.ExpensesTracking Get()
        {
            try { 
             
                BO.ExpensesTracking expenses = new BO.ExpensesTracking()
                {

                    Amount =decimal.Parse(txtAmount.Text),
                    Description = txtDescription.Text,
                    CategoryID = (int)ddlCategory.SelectedValue
                };
                return transaction;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public void FillCombo()
        {

            ddlCategory.ValueMember = "CategoryID";
            ddlCategory.DisplayMember = "Name";
            ddlCategory.DataSource = eTracking_service.GetComboBox();
        }


        private void btnSaveTransaction_Click(object sender, EventArgs e)
        {
            if (transaction == null)
                Save();
            else
                Update();


            DisplayToDGrid();

            Clear();

        }
        private void Update()
        {
            try
            {

                if (transaction == null)
                {
                    MessageBox.Show("Error");
                    return;
                }


                // tsk.Name = txtTaskName.Text;
                // tsk.Description = rtxtTaskDescription.Text;
                //tsk.Color = $"{color[0]},{color[1]},{color[2]},{color[3]}";
                var saved = eTracking_service.Update(transaction);

                MessageBox.Show(saved ? "Updated Successfully" : "Updating failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void DisplayToDGrid()
        {
            try
            {
                // dgvTime.Refresh();
                DataTable t = eTracking_service.GetAll();
                if (t != null)
                {
                    // dgvTasks.DataSource = t;
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

        private void btnCancelTransaction_Click(object sender, EventArgs e)
        {

            pnlAddTransaction.Visible = false;

            dgvTransaction.Size = new Size(817, 697);
        }

        private void Delete()
        {
            try
            {

                if (transaction == null)
                {
                    MessageBox.Show("No record to delete");
                    return;
                }

                var deleted = eTracking_service.Delete(transaction);

                MessageBox.Show(deleted ? "Deleted Successfully" : "Deleting failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void btnDeleteTransaction_Click(object sender, EventArgs e)
        {
            Delete();
            //DisplayToDGrid();
        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transaction = new BO.ExpensesTracking();
           // OpenAddTaskPannel();
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvTransaction.Rows[e.RowIndex];
                transaction.ETrackingID = int.Parse(row.Cells["ExpensesTrackingID"].Value.ToString());
                transaction.Amount =decimal.Parse(row.Cells["Amount"].Value.ToString());
                ddlCategory.DisplayMember = row.Cells["Category"].Value.ToString();
                transaction.CategoryID = (int)ddlCategory.SelectedValue;

                transaction.Description = row.Cells["Description"].Value.ToString();
               }

        }

        private void dgvTransaction_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            transaction = new BO.ExpensesTracking();
          //  OpenAddTaskPannel();
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvTransaction.Rows[e.RowIndex];
                transaction.ETrackingID = int.Parse(row.Cells["ExpensesTrackingID"].Value.ToString());
                transaction.Amount = decimal.Parse(row.Cells["Amount"].Value.ToString());
                ddlCategory.DisplayMember = row.Cells["Category"].Value.ToString();
                transaction.CategoryID = (int)ddlCategory.SelectedValue;

                transaction.Description = row.Cells["Description"].Value.ToString();

            }

        }
    }
}
