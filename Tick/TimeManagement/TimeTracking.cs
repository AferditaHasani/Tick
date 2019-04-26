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
            
            ddTask.Text = "";
            rtxtTimeDescription.Text = "";
            ddStartHour.Text = "";
            ddStartMinute.Text = "";
            ddEndHour.Text = "";
            ddEndMinute.Text = "";
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


                time.TaskID = (int)ddTask.SelectedValue;
                time.Description = rtxtTimeDescription.Text;
                time.Date = dpTimeTrackingDate.Value;
                time.StartTime = ddStartHour.Text+":"+ddStartMinute.Text;
                time.StartTime=ddEndHour.Text + ":"+ddEndMinute.Text ;

                var saved = timeBLL_service.Update(time);

                MessageBox.Show(saved ? "Updated Successfully" : "Updating failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void FillCombo()
        {

            ddTask.ValueMember = "CategoryID";
            ddTask.DisplayMember = "Name";
            ddTask.DataSource = timeBLL_service.GetComboBox();
        }
        public void DisplayToDGrid()
        {
            try
            {
                dgvWorkUnits.Refresh();
                DataTable t = timeBLL_service.GetAll();
                if (t != null)
                {
                   dgvWorkUnits.DataSource = t;
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

                   TaskID=(int) ddTask.SelectedValue ,
                  Description=  rtxtTimeDescription.Text,
                  StartTime = ddStartHour.Text + ":" + ddStartMinute.Text,
                  EndTime = ddEndHour.Text + ":" + ddEndMinute.Text,
                   InsertBy = 1,
                    InsertDate = DateTime.Now


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

                DataGridViewRow row = this.dgvWorkUnits.Rows[e.RowIndex];
                time.TTrackingID = int.Parse(row.Cells["TTrackingID"].Value.ToString());
                time.TaskID = int.Parse(row.Cells["TaskID"].Value.ToString());
               
                time.Description = row.Cells["Description"].Value.ToString();
              //  time.Date = new  DateTime(row.Cells["Date"].Value.ToString());
                time.StartTime= row.Cells["StartTime"].Value.ToString();
                time.EndTime = row.Cells["EndTime"].Value.ToString();

                ddTask.SelectedValue = time.TaskID;
                rtxtTimeDescription.Text = time.Description;
                string[] tt = time.StartTime.Split(':');
                ddStartHour.Text = tt[0];
                ddStartMinute.Text = tt[1];

                tt = time.EndTime.Split(':');
                ddEndHour.Text = tt[0];
                ddEndMinute.Text = tt[1];


            }
        }
        private void dgvdgvWorkUnits_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            time = new BO.TimeTracking();
            OpenAddTimePannel();
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.dgvWorkUnits.Rows[e.RowIndex];
                time.TaskID = int.Parse(row.Cells["TaskID"].Value.ToString());

                time.Description = row.Cells["Description"].Value.ToString();
                time.StartTime = row.Cells["StartTime"].Value.ToString();
                time.EndTime = row.Cells["EndTime"].Value.ToString();

                ddTask.SelectedValue = time.TaskID;
                rtxtTimeDescription.Text = time.Description;
                string[] tt = time.StartTime.Split(':');
                ddStartHour.Text = tt[0];
                ddStartMinute.Text = tt[1];

                tt = time.EndTime.Split(':');
                ddEndHour.Text = tt[0];
                ddEndMinute.Text = tt[1];
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
        private void Delete()
        {
            try
            {

                if (time == null)
                {
                    MessageBox.Show("No record to delete");
                    return;
                }

                var deleted = timeBLL_service.Delete(time);

                MessageBox.Show(deleted ? "Deleted Successfully" : "Deleting failed , please try again");

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void TimeTracking_Load(object sender, EventArgs e)
        {
            DisplayToDGrid();
            FillCombo();
       
        }

        private void btnDeleteTimeTracking_Click(object sender, EventArgs e)
        {
          
            Delete();
            DisplayToDGrid();
        }
    }
}
