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
            string[] row = new string[] {  "Product 1", "1000" };
            dgvWorkUnits.Rows.Add(row);
            row = new string[] { "Product 2", "2000" };
            dgvWorkUnits.Rows.Add(row);
            row = new string[] { "Product 3", "3000" };
            dgvWorkUnits.Rows.Add(row);
            row = new string[] { "4", "Product 4", "4000" };
            dgvWorkUnits.Rows.Add(row);

          


        }
    }
}
