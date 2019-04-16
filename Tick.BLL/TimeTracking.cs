using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tick.BLL
{
    class TimeTracking :Base
    {
        public int TTrackingID { get; set; }
        public int TaskID { get; set; }
        public int UserID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
