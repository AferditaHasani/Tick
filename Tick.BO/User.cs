using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tick.BO
{
    public class User:Base
    {
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int RoleID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
