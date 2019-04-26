using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Tick.DAL;
using Tick.BO;

namespace Tick.BLL
{
    public class CategoryBLL
    {
        private CategoryDAL categoryDAL_db;

        public CategoryBLL()
        {
            categoryDAL_db = new CategoryDAL();
        }

        public bool Insert(Category category)
        {
            return categoryDAL_db.Add(category);
        }

        public DataTable GetAll()
        {
            return categoryDAL_db.GetAll();
        }

        public bool Update(Category category)
        {
            return categoryDAL_db.Update(category);
        }
        public bool Delete(Category category)
        {
            return categoryDAL_db.Delete(category);
        }


    }
}
