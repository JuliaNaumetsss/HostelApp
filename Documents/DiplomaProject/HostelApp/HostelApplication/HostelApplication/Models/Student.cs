using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HostelApplication.Model
{
    public class Student : User
    {
        public string GroupNumber { get; set; }

        public int Course { get; set; }

        public string IsHeadFloor { get; set; }

        public int TotalWorkedHours { get; set; }

        public int PaymentSum { get; set; }

        public Room Room { get; set; }

        public string PathToPhoto { get; set; }
    }
}
