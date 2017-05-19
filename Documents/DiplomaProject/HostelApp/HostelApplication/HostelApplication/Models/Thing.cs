using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelApplication.Model
{
    public class Thing
    {
        public int IdThing { get; set; }

        public string ThingName { get; set; }

        public int TotalCount { get; set; }

        public int ActualCount { get; set; }
    }
}
