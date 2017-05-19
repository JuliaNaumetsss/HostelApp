using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.Handler;
using HostelApplication.Model;

namespace HostelApplication.Page
{
    public class RemoveEmployeePage
    {
        public string RemoveEmployee(string employeeLogin)
        {
            string resultMessage = "";
            string successMessage = "Сотрудник был успешно удалён.";
            string errorMessage = "Произошла ошибка при удалении сотрудника.";
            RemoveInformationHandler removeHandler = new RemoveInformationHandler();
            bool isOperationSuccessful = removeHandler.RemoveEmployee(employeeLogin);
            resultMessage = isOperationSuccessful ? successMessage : errorMessage;
            return resultMessage;
        }
    }
}
