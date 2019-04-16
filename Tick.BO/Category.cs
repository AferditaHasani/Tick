using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tick.BO
{
    public class Category:Base
    {
        public int CategoryID { get; set; }
        public bool IsExpenses { get; set; }
        public string Name { get; set; }
     
    }
}
