using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HostelApplication.DataAccessLayer;
using HostelApplication.Model;

namespace HostelApplication.BusinessLayer
{
    public class PaymentPage
    {
        public string AddPaymentInformation(Dictionary<string, string> infoToAdd)
        {
            string successMessage = "Информация была успешно добавлена.";
            string failedMessage = "Произошла ошибка при добавлении информации.";
            Payment payment = this.FormWorkedHoursObjectFromDictionary(infoToAdd);
            PaymentHandler hdl = new PaymentHandler();
            return hdl.AddPaymentInformation(payment) ? successMessage : failedMessage;
        }

        private Payment FormWorkedHoursObjectFromDictionary(Dictionary<string, string> infoToAdd)
        {
            Payment payment = new Payment();
            payment.EmployeeId = infoToAdd["employee"];
            payment.StudentId = infoToAdd["student"];
            payment.PaymentDate = infoToAdd["date"];
            payment.PaymentSum = int.Parse(infoToAdd["sum"]);
            return payment;
        }

        public List<Dictionary<string, string>> GetDebtorsList(int expectedHoursCount)
        {
            PaymentHandler hdl = new PaymentHandler();
            return hdl.GetDebtors(expectedHoursCount);
        }
    }
}
