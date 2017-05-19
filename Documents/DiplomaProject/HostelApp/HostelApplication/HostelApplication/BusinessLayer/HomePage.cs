using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.Page
{
    public class HomePage
    {
        User user = null;

        // Return true if user exists in Data Base
        public bool IsUserExists(string userLogin)
        {
            GetUserData(userLogin);
            return user != null;
        }

        // Return true if password is correct
        public bool IsPasswordCorrect(string password)
        {
            EncryptionClass encryption = new EncryptionClass();
            password = encryption.GetHashString(password);
            return user.Password.Equals(password);
        }

        // Return numeric user type
        public int GetUserType()
        {
            return user.UserTypeInt;
        }

        public string GetCommonUserInfoString()
        {
            return $"{user.Surname} {user.Name} {user.Patronymic}";
        }

        private void GetUserData(string userLogin)
        {
            UserHandler userHandler = new UserHandler();
            this.user = userHandler.GetUserByLogin(userLogin);
        }
    }
}
