using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelApplication.Model
{
    public class Employee : User
    {
        public string WorkPhoneNumber { get; set; }

        public Room Room { get; set; }
    }
}
