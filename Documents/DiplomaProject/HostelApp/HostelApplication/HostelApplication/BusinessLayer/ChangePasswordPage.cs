using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.Page
{
    public class ChangePasswordPage
    {
        public string ChangePassword(string login, Dictionary<string, string> passwords)
        {
            string resultMessage = "";
            string oldPassword = passwords["old"];
            string newPassword = passwords["new"];
            string confirmedPassword = passwords["confirmed"];

            UserHandler userHandler = new UserHandler();
            User user = userHandler.GetUserByLogin(login);

            EncryptionClass encryption = new EncryptionClass();
            oldPassword = encryption.GetHashString(oldPassword);
            if(!oldPassword.Equals(user.Password))
            {
                resultMessage = "Введён неверный пароль пользователя.";
            }
            else
            {
                if(!newPassword.Equals(confirmedPassword))
                {
                    resultMessage = "Новый пароль не совпадает с паролем потверждения.";
                }
                else
                {
                    newPassword = encryption.GetHashString(newPassword);
                    if(userHandler.UpdateUserPassword(login, newPassword))
                    {
                        resultMessage = "Пароль был успешно обновлён.";
                    }
                    else
                    {
                        resultMessage = "Произошла ошибка при обновлении пароля.";
                    }

                }
            }
            return resultMessage;
        }
    }
}
