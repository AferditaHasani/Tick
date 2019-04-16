using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tick.BLL
{
    public class ExpensesTracking:Base
    {
        public int ETrackingID { get; set; }
        public int UserID { get; set; }
        public int CategoryID { get; set; }
        public decimal Amount { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }

    }
}
