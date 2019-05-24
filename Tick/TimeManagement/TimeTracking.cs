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
    public partial class TimeTracking : Telerik.WinControls.UI.RadForm
    {
        private User user;
        public TimeTracking()
        {
            InitializeComponent();


        }
        public TimeTracking(User u)
        {
            InitializeComponent();

            user = u;
        }
        private TimeTrackingBLL timeBLL_service = new TimeTrackingBLL();
        BO.TimeTracking time = new BO.TimeTracking();
        private DateTime dateForGrid = new DateTime();

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
            
            ddTask.Text = rtxtTimeDescription.Text = ddStartHour.Text = ddStartMinute.Text = ddEndHour.Text = ddEndMinute.Text = "";
          
        }

        private void btnSaveTimeTracking_Click(object sender, EventArgs e)
        {
            if (time == null)
                Save();
            else
                Update();


            DisplayToDGrid(dateForGrid);
            CloseAddTimePannel();
            ClearTxt();
        }

        private void Update()
        {
            try
            {
                string[] date = dpTimeTrackingDate.Value.ToString().Split(' ');
                date = date[0].Split('/');

                if (time == null)
                {
                    MessageBox.Show("Error");
                    return;
                }


                time.TaskID = (int)ddTask.SelectedValue;
                time.Description = rtxtTimeDescription.Text;
                time.Date = dpTimeTrackingDate.Value;
              

                time.StartTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]),
                    int.Parse(ddStartHour.Text), int.Parse(ddStartMinute.Text), 0);
                if (int.Parse(ddStartHour.Text)> int.Parse(ddEndHour.Text)||(int.Parse(ddStartHour.Text) == int.Parse(ddEndHour.Text)&& int.Parse(ddStartMinute.Text) > int.Parse(ddEndMinute.Text)))
                {
                    time.EndTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0])+1,
                        int.Parse(ddEndHour.Text), int.Parse(ddEndMinute.Text), 0);
                }
                else
                {
                    time.EndTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]),
                        int.Parse(ddEndHour.Text), int.Parse(ddEndMinute.Text), 0);
                }
             

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

            ddTask.ValueMember = "TaskID";
            ddTask.DisplayMember = "Name";
            ddTask.DataSource = timeBLL_service.GetComboBox();
        }
        public void DisplayToDGrid(DateTime dt)
        {
            try
            {
          
                dgvWorkUnits.Refresh();
                DataTable t = timeBLL_service.GetByDate(dt);
                if (t != null)
                {
                   dgvWorkUnits.DataSource = t;





                   dgvWorkUnits.Columns["TaskID"].Visible = false;
                   dgvWorkUnits.Columns["Color"].Visible = false;
                   dgvWorkUnits.Columns["TTrackingID"].Width = 70;
                   dgvWorkUnits.Columns["TTrackingID"].HeaderText = "ID";


                    this.dgvWorkUnits.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dgvWorkUnits.Columns["Description"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    this.dgvWorkUnits.Columns["Date"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dgvWorkUnits.Columns["StartTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    this.dgvWorkUnits.Columns["EndTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



                    for (int i = 0; i < dgvWorkUnits.RowCount; i++)
                    {
                        DataGridViewRow row = dgvWorkUnits.Rows[i];
                        string c = row.Cells["Color"].Value.ToString();

                        string[] colors = c.Split(',');
                        dgvWorkUnits.Rows[i].HeaderCell.Style.BackColor =
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
                string[] date = dpTimeTrackingDate.Value.ToString().Split(' ');
                date = date[0].Split('/');
            
                BO.TimeTracking t = new BO.TimeTracking
                {

                    TaskID = (int) ddTask.SelectedValue,
                    
                    Description = rtxtTimeDescription.Text,
                    Date= dpTimeTrackingDate.Value,
                   StartTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]) ,
                    int.Parse(ddStartHour.Text), int.Parse(ddStartMinute.Text),0),
                   EndTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]),
                       int.Parse(ddEndHour.Text), int.Parse(ddEndMinute.Text), 0),
                    InsertBy = 1,
                    InsertDate = DateTime.Now


                };
                if (int.Parse(ddStartHour.Text) > int.Parse(ddEndHour.Text) ||
                    (int.Parse(ddStartHour.Text) == int.Parse(ddEndHour.Text) &&
                     int.Parse(ddStartMinute.Text) > int.Parse(ddEndMinute.Text)))
                {
                    t.EndTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0])+1,
                        int.Parse(ddEndHour.Text), int.Parse(ddEndMinute.Text), 0);
                }
                    MessageBox.Show(t.StartTime+"");
                return t;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
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

                string[] date = row.Cells["Date"].Value.ToString().Split(' ');
                date = date[0].Split('/');

                time.TTrackingID = int.Parse(row.Cells["TTrackingID"].Value.ToString());
                time.TaskID = int.Parse(row.Cells["TaskID"].Value.ToString());
                time.Description = row.Cells["Description"].Value.ToString();
                time.Date = new  DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                dpTimeTrackingDate.Value = time.Date;


                string[] a = row.Cells["StartTime"].Value.ToString().Split(':');
          
            
                time.StartTime=new DateTime (int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]), int.Parse(a[0]), int.Parse(a[1]),0) ;
                ddStartHour.Text = a[0];
                ddStartMinute.Text =  a[1];




                a = row.Cells["EndTime"].Value.ToString().Split(':');
                time.EndTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]) ,
                    int.Parse(a[0]),
                    int.Parse(a[1]), 0);

                if (int.Parse(ddStartHour.Text) > int.Parse(a[0]) ||
                    (int.Parse(ddStartHour.Text) == int.Parse(a[0]) &&
                     int.Parse(ddStartMinute.Text) > int.Parse(a[1])))
                {

                    time.EndTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]) + 1,
                        int.Parse(a[0]),
                        int.Parse(a[1]), 0);

                }
                

                ddTask.SelectedValue = time.TaskID;
                rtxtTimeDescription.Text = time.Description;
       
            

              
                ddEndHour.Text = a[0];
                ddEndMinute.Text = a[1];


            }
        }
        private void dgvdgvWorkUnits_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            time = new BO.TimeTracking();
            OpenAddTimePannel();
            if (e.RowIndex >= 0)
            {


                DataGridViewRow row = this.dgvWorkUnits.Rows[e.RowIndex];

                string[] date = row.Cells["Date"].Value.ToString().Split(' ');
                date = date[0].Split('/');

                time.TTrackingID = int.Parse(row.Cells["TTrackingID"].Value.ToString());
                time.TaskID = int.Parse(row.Cells["TaskID"].Value.ToString());
                time.Description = row.Cells["Description"].Value.ToString();
                time.Date = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]));
                dpTimeTrackingDate.Value = time.Date;
                string[] a = row.Cells["StartTime"].Value.ToString().Split(':');


                time.StartTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]), int.Parse(a[0]), int.Parse(a[1]), 0);
                ddStartHour.Text = a[0];
                ddStartMinute.Text = a[1];




                a = row.Cells["EndTime"].Value.ToString().Split(':');
                time.EndTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]),
                    int.Parse(a[0]),
                    int.Parse(a[1]), 0);

                if (int.Parse(ddStartHour.Text) > int.Parse(a[0]) ||
                    (int.Parse(ddStartHour.Text) == int.Parse(a[0]) &&
                     int.Parse(ddStartMinute.Text) > int.Parse(a[1])))
                {

                    time.EndTime = new DateTime(int.Parse(date[2]), int.Parse(date[1]), int.Parse(date[0]) + 1,
                        int.Parse(a[0]),
                        int.Parse(a[1]), 0);

                }


                ddTask.SelectedValue = time.TaskID;
                rtxtTimeDescription.Text = time.Description;




                ddEndHour.Text = a[0];
                ddEndMinute.Text = a[1];


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
            FillCombo();
            dateForGrid = (DateTime)dtpDataGridTime.Value;
            DisplayToDGrid(dateForGrid);
          
        }

        private void btnDeleteTimeTracking_Click(object sender, EventArgs e)
        {
          
            Delete();
            DisplayToDGrid(dateForGrid);
        }

        

        private void dtpDataGridTime_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            dateForGrid = (DateTime)dtpDataGridTime.Value;
            DisplayToDGrid(dateForGrid);
        }

        private void btnPreviousDay_Click(object sender, EventArgs e)
        {
            dateForGrid = new DateTime(dtpDataGridTime.Value.Value.Year, dtpDataGridTime.Value.Value.Month, dtpDataGridTime.Value.Value.Day-1);
            dtpDataGridTime.Value = dateForGrid;
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dateForGrid = new DateTime(dtpDataGridTime.Value.Value.Year, dtpDataGridTime.Value.Value.Month, dtpDataGridTime.Value.Value.Day +1);
            dtpDataGridTime.Value = dateForGrid;
        }
    }
}
