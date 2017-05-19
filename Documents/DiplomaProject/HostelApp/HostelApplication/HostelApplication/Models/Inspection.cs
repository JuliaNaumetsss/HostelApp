using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelApplication.Model
{
    public class Inspection
    {
        public int InspectionId { get; set; }

        public DateTime InspectionDate { get; set; }

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
    }
}
