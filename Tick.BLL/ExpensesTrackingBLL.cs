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

        public bool Insert(ExpensesTracking track)
        {
            return ETrackingDAL_db.Add(track);
        }

        public DataTable GetByDate(DateTime dt)
        {
            return ETrackingDAL_db.GetByDate(dt);
        }

        public bool Update(ExpensesTracking tsk)
        {
            return ETrackingDAL_db.Update(tsk);
        }
        public bool Delete(ExpensesTracking tsk)
        {
            return ETrackingDAL_db.Delete(tsk);
        }
        public DataTable GetComboBox()
        {
            return ETrackingDAL_db.GetComboBox();
        }
       

    }
}
