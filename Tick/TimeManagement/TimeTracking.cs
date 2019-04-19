using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace Tick.TimeManagement
{
    public partial class TimeTracking : Telerik.WinControls.UI.RadForm
    {
        public TimeTracking()
        {
            InitializeComponent();
        }

        private void btnAddTimeTracking_Click(object sender, EventArgs e)
        {
            string[] row = new string[] { "Product 1", "1000" };
            dgvWorkUnits.Rows.Add(row);
            row = new string[] { "Product 2", "2000" };
            dgvWorkUnits.Rows.Add(row);
            row = new string[] { "Product 3", "3000" };
            dgvWorkUnits.Rows.Add(row);
            row = new string[] { "4", "Product 4", "4000" };
            dgvWorkUnits.Rows.Add(row);
            if (pnlAddWorkUnit.Size!= new Size(328, 756))
            {
                pnlAddWorkUnit.Size = new Size(328, 756);

                dgvWorkUnits.Size = new Size(dgvWorkUnits.Width - 318, 683);
                pnlAddWorkUnit.Location = new Point(dgvWorkUnits.Width + 2, 12);

            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            pnlAddWorkUnit.Size = new Size(10, 756);

            dgvWorkUnits.Size = new Size(dgvWorkUnits.Width + 318, 683);
            pnlAddWorkUnit.Location = new Point(dgvWorkUnits.Width + 2, 12);

        }
    }
}
