using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
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






        private void btnAddTask_Click(object sender, EventArgs e)
        {
            if (pnlAddTask.Size != new Size(328, 756))
            {
                pnlAddTask.Size = new Size(328, 756);

                dgvTasks.Size = new Size(dgvTasks.Width - 318, 683);
                pnlAddTask.Location = new Point(dgvTasks.Width + 2, 12);

            }
        }
        private void btnCancelTask_Click(object sender, EventArgs e)
        {
            pnlAddTask.Size = new Size(10, 756);

            dgvTasks.Size = new Size(dgvTasks.Width + 318, 683);
            pnlAddTask.Location = new Point(dgvTasks.Width + 2, 12);
        }



        private void btnSaveTask_Click(object sender, EventArgs e)
        {
            Save();
        }


        public void Save()
        {
            try
            {
                var task = Get();
                if (task == null)
                {
                    MessageBox.Show("Error");
                    return;
                }

                var saved = taskBLL_service.Insert(task);

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
               Task task = new Task
                {
                    
                    Name = txtTaskName.Text,
                    Description= rtxtTaskDescription.Text,
                    Color=cbTaskColor.Text,
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
    }
}
