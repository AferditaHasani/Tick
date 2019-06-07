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

        public DataTable GetAll(int id)
        {
            return ETrackingDAL_db.GetAll(id);
        }
        public DataTable GetByDate(DateTime dt,int id)
        {
            
            return ETrackingDAL_db.GetByDate(dt,id);
        }

        public bool Update(ExpensesTracking tsk)
        {
            return ETrackingDAL_db.Update(tsk);
        }
        public bool Delete(ExpensesTracking tsk)
        {
            return ETrackingDAL_db.Delete(tsk);
        }
        public DataTable GetComboBox(int id)
        {
            return ETrackingDAL_db.GetComboBox(id);
        }
        public DataTable GetByMonth(DateTime dt,int id)
        {
            return ETrackingDAL_db.GetByMonth(dt,id);
        }
        public DataTable GetForPie(DateTime dt,int id)
        {
            return ETrackingDAL_db.GetForPie(dt,id);
        }


        public decimal GetIncome( int id)
        {
            return ETrackingDAL_db.GetIncome(id);
        }
        public decimal GetExpenses(int id)
        {
            return ETrackingDAL_db.GetExpenses(id);
        }
    }
}
