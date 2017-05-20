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

        private Estimation estimationRoom;

        public Estimation Estimation
        {
            get
            {
                return estimationRoom;
            }

            set
            {
                value = estimationRoom;
            }
        }

        public List<string> EmployeeLoginList { get; set; }
    }
}
