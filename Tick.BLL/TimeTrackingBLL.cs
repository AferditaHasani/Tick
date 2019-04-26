using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tick.BO;
using Tick.DAL;

namespace Tick.BLL
{
   public class TimeTrackingBLL

    {
        private TimeTrackingDAL timeDAL_db;

        public TimeTrackingBLL()
        {
            timeDAL_db = new TimeTrackingDAL();
        }
        public bool Insert(TimeTracking model)
        {
            return timeDAL_db.Add(model);
        }

        public DataTable GetAll()
        {
            return timeDAL_db.GetAll();
        }

        public bool Update(TimeTracking model)
        {
            return timeDAL_db.Update(model);
        }

        public bool Delete(TimeTracking model)
        {
            return timeDAL_db.Delete(model);
        }
    }
}
