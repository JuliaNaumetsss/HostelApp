using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace HostelApplication.Model
{
    public class Payment
    {
        public string PaymentDate { get; set; }

        public int PaymentSum { get; set; }

        public string StudentId { get; set; }

        public string EmployeeId { get; set; }
    }
}
