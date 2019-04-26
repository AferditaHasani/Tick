using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tick.DAL;
using Tick.BO;

namespace Tick.BLL
{
   public class ExpensesTrackingBLL
    {
        private ExpensesTrackingDAL ETrackingDAL_db;

        public ExpensesTrackingBLL()
        {
            ETrackingDAL_db = new ExpensesTrackingDAL();
        }

        public bool Insert(ExpensesTracking task)
        {
            return ETrackingDAL_db.Add(task);
        }

        public DataTable GetAll()
        {
            return ETrackingDAL_db.GetAll();
        }

        public bool Update(ExpensesTracking tsk)
        {
            return ETrackingDAL_db.Update(tsk);
        }
        public bool Delete(ExpensesTracking tsk)
        {
            return ETrackingDAL_db.Delete(tsk);
        }

    }
}
