using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows;
using Telerik.WinControls;
using Tick.BLL;
using Tick.BO;

namespace Tick.TimeManagement
{
    public partial class Tasks : Telerik.WinControls.UI.RadForm
    {
        public Tasks()
        {
            InitializeComponent();
           
        }

        private TaskBLL taskBLL_service = new TaskBLL ();
        Task tsk = new Task();


        private void btnAddTask_Click(object sender, EventArgs e)
        {
            OpenAddTaskPannel();
            tsk = null;
            ClearTxt();
        }
        private void btnCancelTask_Click(object sender, EventArgs e)
        {
            CloseAddTaskPannel();
            ClearTxt();
        }

        private void ClearTxt()
        {
            cbTaskColor.Value = new Color ();
            cbTaskColor.Text = "";
            rtxtTaskDescription.Text = "";
            txtTaskName.Text = "";
        }
        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            if (tsk == null)
                Save();
            else
                Update();

            
            DisplayToDGrid();
            CloseAddTaskPannel();
            ClearTxt();
        }

        private void Update()
        {
            try
            {
                
                if (tsk == null)
                {
                    MessageBox.Show("Error");
                    return;
                }
                int[] color = GetArgb(cbTaskColor.Value.ToString());

                tsk.Name =txtTaskName.Text;
                tsk.Description = rtxtTaskDescription.Text;
                tsk.Color = $"{color[0]},{color[1]},{color[2]},{color[3]}";
                var saved = taskBLL_service.Update(tsk);

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
                dgvTasks.Refresh();
                DataTable t= taskBLL_service.GetAll();
                if (t!=null)
                {
                    dgvTasks.DataSource = t;

                    dgvTasks.Columns["Color"].Visible = false;
                    dgvTasks.Columns["TaskID"].Width = 100;
                    for (int i = 0; i < dgvTasks.RowCount-1; i++)
                    {
                        DataGridViewRow row = dgvTasks.Rows[i];
                        string c =  row.Cells["Color"].Value.ToString();

                        string[] colors = c.Split(',');
                        dgvTasks.Rows[i].HeaderCell.Style.BackColor =
                            Color.FromArgb( int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));
                           


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
                tsk = Get();
                if (tsk == null)
                {
                    MessageBox.Show("Error");
                    return;
                }

                var saved = taskBLL_service.Insert(tsk);

                MessageBox.Show(saved ? "Saved Successfully" : "Saving failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public Task Get()
        {
            try
            {
                int[] color = GetArgb(cbTaskColor.Value.ToString());
               Task task = new Task
                {
                    
                    Name = txtTaskName.Text,
                    Description= rtxtTaskDescription.Text,
                    Color=$"{color[0]},{color[1]},{color[2]},{color[3]}",
                    InsertBy = 1,
                    InsertDate = DateTime.Now
                  
                   
                };
                return task;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void dgvTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            tsk = new Task();
            OpenAddTaskPannel();
            if (e.RowIndex>=0)
            {
               
                DataGridViewRow row = this.dgvTasks.Rows[e.RowIndex];
                tsk.TaskID =int.Parse( row.Cells["TaskID"].Value.ToString());
                tsk.Name = row.Cells["Name"].Value.ToString();
                tsk.Description= row.Cells["Description"].Value.ToString();
                tsk.Color= row.Cells["Color"].Value.ToString();
                txtTaskName.Text = tsk.Name;
                rtxtTaskDescription.Text = tsk.Description;
                string[] colors = tsk.Color.Split(',');


                cbTaskColor.Value = Color.FromArgb(int.Parse(colors[0]), int.Parse(colors[1]), int.Parse(colors[2]), int.Parse(colors[3]));
            }
        }
        private void dgvTasks_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tsk = new Task();
            OpenAddTaskPannel();
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvTasks.Rows[e.RowIndex];
                tsk.TaskID = int.Parse(row.Cells["TaskID"].Value.ToString());
                tsk.Name = row.Cells["Name"].Value.ToString();
                tsk.Description = row.Cells["Description"].Value.ToString();
                tsk.Color = row.Cells["Color"].Value.ToString();
                txtTaskName.Text = tsk.Name;
                rtxtTaskDescription.Text = tsk.Description;
                string[] colors = tsk.Color.Split(',');


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

        private void OpenAddTaskPannel()
        {

            if (pnlAddTask.Size != new Size(328, 756))
            {
                pnlAddTask.Size = new Size(328, 756);

                dgvTasks.Size = new Size(dgvTasks.Width - 258, 683);
                pnlAddTask.Location = new Point(dgvTasks.Width + 2, 12);

            }
        }

        private void CloseAddTaskPannel()
        {
            pnlAddTask.Size = new Size(10, 756);

            dgvTasks.Size = new Size(dgvTasks.Width + 258, 683);
            pnlAddTask.Location = new Point(dgvTasks.Width + 2, 12);
            tsk = new Task();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            Delete();
            DisplayToDGrid();
            CloseAddTaskPannel();
            ClearTxt();
        }

        private void Delete()
        {
            try
            {

                if (tsk == null)
                {
                    MessageBox.Show("No record to delete");
                    return;
                }
               
                var deleted = taskBLL_service.Delete(tsk);

                MessageBox.Show(deleted ? "Deleted Successfully" : "Deleting failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Tasks_Load(object sender, EventArgs e)
        {
            DisplayToDGrid();
        }
    }
}
