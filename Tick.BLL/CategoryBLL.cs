using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public bool GetCategory(Category category)
        {
            return categoryDAL_db.GetCategory(category);
        }
    }
}
