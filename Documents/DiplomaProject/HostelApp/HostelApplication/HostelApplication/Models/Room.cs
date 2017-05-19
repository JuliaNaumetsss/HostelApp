using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelApplication.Model
{
    public class Room
    {
        public string IdRoom { get; set; }

        public int RoomNumber { get; set; }

        public string RoomLetter { get; set; }

        public int TotalPlaceCount { get; set; }

        public int EmptyPlaceCount { get; set; }

        public Floor Floor { get; set; }
    }
}
