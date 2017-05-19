using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostelApplication.Model
{
    public class User
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public string UserType { get; set; }

        public int UserTypeInt { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Patronymic { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }

        public string PassportData { get; set; }
    }
}
