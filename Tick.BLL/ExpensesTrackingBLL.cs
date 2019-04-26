using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tick.DAL;
using Tick.BO;

namespace Tick.BLL
{
   public class ExpensesTrackingBLL
    {
        private ExpensesTrackingDAL expensesTrackingDAL_db;

        public ExpensesTrackingBLL()
        {
            expensesTrackingDAL_db = new ExpensesTrackingDAL();
        }

        public bool Insert(ExpensesTracking eTracking)
        {
            return expensesTrackingDAL_db.Add(eTracking);
        }
        public bool GetTransaction(ExpensesTracking user)
        {
            return expensesTrackingDAL_db.GetTransaction(user);
        }
    }
}
