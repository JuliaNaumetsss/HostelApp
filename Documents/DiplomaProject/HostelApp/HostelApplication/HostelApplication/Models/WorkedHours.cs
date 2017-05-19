using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelApplication.Model
{
    public class WorkedHours
    {
        public string WorkedDate { get; set; }

        public int HoursCount { get; set; }

        public string StudentId { get; set; }

        public string EmployeeId { get; set; }

        public string Description { get; set; }
    }
}
