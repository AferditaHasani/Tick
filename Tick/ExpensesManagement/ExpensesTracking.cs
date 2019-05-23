using System;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private DateTime dateForGrid = new DateTime();

        private void ExpensesTracking_Load(object sender, EventArgs e)
        {
            pnlAddTransaction.Visible = false;
            dgvTransaction.Visible = true;
            dgvTransaction.Size = new Size(708, 697);
            FillCombo();
            DisplayToDGrid(dateForGrid);
        }

        private void btnAddTransaction_Click(object sender, EventArgs e)
        {
            pnlAddTransaction.Visible = true;
            dgvTransaction.Size = new Size(680, 697);
            transaction = null;
            
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

                string[] date = dpExpensesTrackingDate.Value.ToString().Split(' ');
                date = date[0].Split('/');
                BO.ExpensesTracking expenses = new BO.ExpensesTracking()
                {
                 
                    Amount =decimal.Parse(txtAmount.Text),
                    Description = txtDescription.Text,
                    CategoryID = (int)ddlCategory.SelectedValue,
                    Date = dpExpensesTrackingDate.Value,
                    InsertBy = 1,
                    InsertDate = DateTime.Now
                };
                return expenses;
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

            DisplayToDGrid(dateForGrid);
            Clear();
            transaction = null;
        }

        private void Update()
        {
            try
            {
                string[] date = dpExpensesTrackingDate.Value.ToString().Split(' ');
                date = date[0].Split('/');
                if (transaction == null)
                {
                    MessageBox.Show("Error");
                    return;
                }            
                transaction.Amount = decimal.Parse(txtAmount.Text);
                transaction.CategoryID = (int)ddlCategory.SelectedValue;
                transaction.Description = txtDescription.Text;
                transaction.Date = dpExpensesTrackingDate.Value;
                var saved = eTracking_service.Update(transaction);
                MessageBox.Show(saved ? "Updated Successfully" : "Updating failed , please try again");
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void DisplayToDGrid(DateTime dt)
        {
            try
            {
                dgvTransaction.Refresh();
                DataTable t = eTracking_service.GetByDate(dt);
                if (t != null)
                {
                    dgvTransaction.DataSource = t;
                    dgvTransaction.Columns["Amount"].DefaultCellStyle.Alignment =
                    DataGridViewContentAlignment.MiddleRight;


                    dgvTransaction.Columns["CategoryID"].Visible = false;
                    dgvTransaction.Columns["Color"].Visible = false;
                    dgvTransaction.Columns["ETrackingID"].Width = 70;
                    dgvTransaction.Columns["ETrackingID"].HeaderText = "ID";


                    this.dgvTransaction.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dgvTransaction.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;



                    for (int i = 0; i < dgvTransaction.RowCount; i++)
                    {
                        DataGridViewRow row = dgvTransaction.Rows[i];
                        string c = row.Cells["Color"].Value.ToString();

                        string[] colors = c.Split(',');
                        dgvTransaction.Rows[i].HeaderCell.Style.BackColor =
                            Color.FromArgb(int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));
                    }
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
            transaction = null;
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
            transaction = null;
            DisplayToDGrid(dateForGrid);
        }

        private void dgvTransaction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            transaction = new BO.ExpensesTracking();
            pnlAddTransaction.Visible = true;
            dgvTransaction.Size = new Size(680, 697);
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvTransaction.Rows[e.RowIndex];
                string[] date = row.Cells["Date"].Value.ToString().Split(' ');
                date = date[0].Split('/');
                transaction.ETrackingID = int.Parse(row.Cells["ETrackingID"].Value.ToString());
                transaction.Amount =decimal.Parse(row.Cells["Amount"].Value.ToString());
                ddlCategory.DisplayMember = row.Cells["Category"].Value.ToString();
                transaction.CategoryID = (int)ddlCategory.SelectedValue;
                transaction.Description = row.Cells["Description"].Value.ToString();
                transaction.Date=new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                dpExpensesTrackingDate.Value = transaction.Date;
            }
        }

        private void dgvTransaction_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            transaction = new BO.ExpensesTracking();
            transaction = new BO.ExpensesTracking();
            pnlAddTransaction.Visible = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvTransaction.Rows[e.RowIndex];
                string[] date = row.Cells["Date"].Value.ToString().Split(' ');
                date = date[0].Split('/');

                transaction.ETrackingID = int.Parse(row.Cells["ETrackingID"].Value.ToString());
                transaction.Amount = decimal.Parse(row.Cells["Amount"].Value.ToString());
                ddlCategory.DisplayMember = row.Cells["Category"].Value.ToString();
                transaction.CategoryID = (int)ddlCategory.SelectedValue;
                transaction.Description = row.Cells["Description"].Value.ToString();
                transaction.Date = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                dpExpensesTrackingDate.Value = transaction.Date;
            }
        }

        private void txtAmount_TextChange(object sender, EventArgs e)
        {
            string enteredText = (sender as TextBox).Text;
            int cursorPosition = (sender as TextBox).SelectionStart;

            string[] splitByDecimal = enteredText.Split('.');

            if (splitByDecimal.Length > 1 && splitByDecimal[1].Length > 2)
            {
                (sender as TextBox).Text = enteredText.Remove(enteredText.Length - 1);
                (sender as TextBox).SelectionStart = cursorPosition - 1;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
        //    Double value;
        //    if (Double.TryParse(txtAmount.Text, out value))
        //        txtAmount.Text = String.Format(CultureInfo.CreateSpecificCulture(null), "{0:C2}", value);
        //    else
        //        txtAmount.Text = String.Empty;
        }

        private void dtpDataGridTime_ValueChanged(object sender, EventArgs e)
        {
            dateForGrid = dtpDataGridTime.Value;
            DisplayToDGrid(dateForGrid);
        }
    }
}
