using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using Tick.BLL;

namespace Tick.TimeManagement
{
    public partial class TimeTracking : Telerik.WinControls.UI.RadForm
    {
        public TimeTracking()
        {
            InitializeComponent();
            DisplayToDGrid();
        }
        private TimeTrackingBLL timeBLL_service = new TimeTrackingBLL();
        BO.TimeTracking time = new BO.TimeTracking();

        private void btnAddTimeTracking_Click(object sender, EventArgs e)
        {

            OpenAddTimePannel();
            time = null;
            ClearTxt();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CloseAddTimePannel();
            ClearTxt();
        }
        private void ClearTxt()
        {
            //cbTaskColor.Value = new Color();
            //cbTaskColor.Text = "";
            //rtxtTaskDescription.Text = "";
            //txtTaskName.Text = "";
        }

        private void btnSaveTimeTracking_Click(object sender, EventArgs e)
        {
            if (time == null)
                Save();
            else
                Update();


            DisplayToDGrid();
            CloseAddTimePannel();
            ClearTxt();
        }

        private void Update()
        {
            try
            {

                if (time == null)
                {
                    MessageBox.Show("Error");
                    return;
                }
               

               // tsk.Name = txtTaskName.Text;
               // tsk.Description = rtxtTaskDescription.Text;
                //tsk.Color = $"{color[0]},{color[1]},{color[2]},{color[3]}";
                var saved = timeBLL_service.Update(time);

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
                DataTable t = timeBLL_service.GetAll();
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
        public void Save()
        {
            try
            {
                time = Get();
                if (time == null)
                {
                    MessageBox.Show("Error");
                    return;
                }

                var saved = timeBLL_service.Insert(time);

                MessageBox.Show(saved ? "Saved Successfully" : "Saving failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public BO.TimeTracking Get()
        {
            try
            {
                BO.TimeTracking t = new BO.TimeTracking
                {

                    //Name = txtTaskName.Text,
                    //Description = rtxtTaskDescription.Text,
                    //Color = $"{color[0]},{color[1]},{color[2]},{color[3]}",
                    //InsertBy = 1,
                    //InsertDate = DateTime.Now


                };
                return t;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        private void dgvWorkUnits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            time = new BO.TimeTracking();
            OpenAddTimePannel();
            if (e.RowIndex >= 0)
            {

                //DataGridViewRow row = this.dgvWorkUnits.Rows[e.RowIndex];
                //time.TaskID = int.Parse(row.Cells["TaskID"].Value.ToString());
                //time.Name = row.Cells["Name"].Value.ToString();
                //time.Description = row.Cells["Description"].Value.ToString();
               
                //txtTaskName.Text = tsk.Name;
                //rtxtTaskDescription.Text = tsk.Description;
              


              
            }
        }
        private void dgvdgvWorkUnits_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            time = new BO.TimeTracking();
            OpenAddTimePannel();
            if (e.RowIndex >= 0)
            {

                //DataGridViewRow row = this.dgvWorkUnits.Rows[e.RowIndex];
                //time.TaskID = int.Parse(row.Cells["TaskID"].Value.ToString());
               
                //time.Description = row.Cells["Description"].Value.ToString();
             
                //txtTaskName.Text = time.Name;
                //rtxtTaskDescription.Text = time.Description;
               }
        }

        private void OpenAddTimePannel()
        {

            if (pnlAddWorkUnit.Size != new Size(328, 756))
            {
                pnlAddWorkUnit.Size = new Size(328, 756);

                dgvWorkUnits.Size = new Size(dgvWorkUnits.Width - 258, 683);
                pnlAddWorkUnit.Location = new Point(dgvWorkUnits.Width + 2, 12);

            }
        }

        private void CloseAddTimePannel()
        {
            pnlAddWorkUnit.Size = new Size(10, 756);

            dgvWorkUnits.Size = new Size(dgvWorkUnits.Width + 258, 683);
            pnlAddWorkUnit.Location = new Point(dgvWorkUnits.Width + 2, 12);
            time = new BO.TimeTracking();
        }

    }
}
