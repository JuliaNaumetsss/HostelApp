using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.Page
{
    public class RemoveStudentPage
    {
        public string RemoveStudent(string studentLogin)
        {
            string resultMessage = "";
            string successMessage = "Студент был успешно удалён.";
            string errorMessage = "Произошла ошибка при удалении студента.";
            RemoveInformationHandler removeHandler = new RemoveInformationHandler();
            bool isOperationSuccessful = removeHandler.RemoveStudent(studentLogin);
            resultMessage = isOperationSuccessful ? successMessage : errorMessage;
            return resultMessage;
        }
    }
}
