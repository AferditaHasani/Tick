
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace Tick.DAL
{
    class Connection
    {
        public static string GetConnectionString
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["TickEntities"].ConnectionString;
            }
        }

      
    }
}
