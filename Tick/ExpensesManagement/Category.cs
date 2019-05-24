using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Telerik.WinControls.UI;
using Tick.BLL;
using Utilities.BunifuCheckBox.Transitions;
using Tick.BO;

namespace Tick.ExpensesManagement
{
    public partial class Category : Telerik.WinControls.UI.RadForm
    {
        private bool isExpense=true;
        private CategoryBLL categoryBLL_service = new CategoryBLL();
        private BO.Category cat= new BO.Category();
        public User user;

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
               
            }
            else
            {
                isExpense = false;
              
            }
            if (cat == null)
                Save();
            else
                Update();

            DisplayToDGrid();
            pnlAddCategory.Visible = true;
            dgvCategory.Size = new Size(680, 697);
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
                DataTable t = categoryBLL_service.GetAll(user.UserID);
                if (t != null)
                {
                   

                    t.Columns.Add("Type", typeof(string));
                    int j = 0;
                    foreach (var row in t.Rows)
                    {
                        if((bool)t.Rows[j]["IsExpenses"])
                        { t.Rows[j]["Type"] = "Expense";}
                        else
                        {
                            t.Rows[j]["Type"] = "Income";
                        }



                        j++;
                    }
                    dgvCategory.DataSource = t;

                    dgvCategory.Columns["Color"].Visible = false;

                    dgvCategory.Columns["IsExpenses"].Visible = false;



                    for (int i = 0; i < dgvCategory.RowCount; i++)
                    {
                        DataGridViewRow row = dgvCategory.Rows[i];
                        string c = row.Cells["Color"].Value.ToString();

                        string[] colors = c.Split(',');
                        dgvCategory.Rows[i].HeaderCell.Style.BackColor =
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
                int[] color = GetArgb(cbTaskColor.Value.ToString());

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
                int[] color = GetArgb(cbTaskColor.Value.ToString());

                BO.Category category = new BO.Category
                {
                    Name=txtName.Text,
                    IsExpenses = isExpense,
                    InsertBy = user.UserID,
                    InsertDate = DateTime.Now,
                    Color = $"{color[0]},{color[1]},{color[2]},{color[3]}"

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
            dgvCategory.Size = new Size(680, 697);
            pnlAddCategory.Visible = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvCategory.Rows[e.RowIndex];
                cat.CategoryID = int.Parse(row.Cells["CategoryID"].Value.ToString());
                cat.Name = row.Cells["Name"].Value.ToString();
                txtName.Text = cat.Name;  
                cat.IsExpenses =(bool)row.Cells["IsExpenses"].Value;
                cat.Color = row.Cells["Color"].Value.ToString();
                string[] colors = cat.Color.Split(',');


                cbTaskColor.Value = Color.FromArgb(int.Parse(colors[0]), int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));
            }
        }
        private int[] GetArgb(string color)
        {
            int[] result = new int[4];
            string[] temp = color.Split('[');
            temp = temp[1].Split(']');
            temp = temp[0].Split(',');
            for (int i = 0; i < temp.Length; i++)
            {
                string[] t = temp[i].Split('=');
                result[i] = int.Parse(t[1]);
            }

            return result;
        }

        private void dgvCategory_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cat = new BO.Category();
            dgvCategory.Size = new Size(680, 697);
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
