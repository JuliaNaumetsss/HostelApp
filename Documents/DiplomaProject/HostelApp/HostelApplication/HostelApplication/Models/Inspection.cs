using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelApplication.Model
{
    public class Inspection
    {
        public string InspectionDate { get; set; }

        public string Room { get; set; }

        public Estimation Estimation { get; set; }

        public List<string> EmployeeLoginList { get; set; }
    }
}
