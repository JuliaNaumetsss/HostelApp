using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelApplication.BusinessLayer;

namespace HostelApplication.UserInterfaceLayer
{
    public partial class WorkedHoursForm : Form
    {
        WorkedHoursPage hoursPage = new WorkedHoursPage();
        string EmployeeLogin = "";
        List<Dictionary<string, string>> StudentList = new List<Dictionary<string, string>>();
        string TypeOperation = "";

        public WorkedHoursForm(string employeeLogin, string typeOperation)
        {
            this.EmployeeLogin = employeeLogin;
            this.TypeOperation = typeOperation;
            InitializeComponent();
            InitializeFormComponent();            
        }

        private void buttonAddInspection_Click(object sender, EventArgs e)
        {
            switch (this.TypeOperation)
            {
                case "hours":
                    this.AddWorkedHours();
                    break;
                case "payment":
                    this.AddPayment();
                    break;
            }
        }

        private void AddWorkedHours()
        {
            if (!this.IsEmptyWorkHoursFieldsExist())
            {
                Dictionary<string, string> infoDict = new Dictionary<string, string>();
                infoDict["date"] = dateInspection.Value.ToString("dd/MM/yyy");
                infoDict["hoursCount"] = tbHoursCount.Text;
                infoDict["description"] = richTextBoxDescription.Text;
                infoDict["student"] = this.GetStudentLogin();
                infoDict["employee"] = this.EmployeeLogin;
                string operationResultMessage = hoursPage.AddWorkedHoursInformation(infoDict);
                MessageBox.Show(operationResultMessage);
            }
            else
            {
                MessageBox.Show("Для добавление информации об отработках необходимо заполнить все поля.");
            }
        }

        private void AddPayment()
        {
            if(!this.IsEmptyPaymentsFieldsExist())
            {
                Dictionary<string, string> infoDict = new Dictionary<string, string>();
                infoDict["date"] = dateInspection.Value.ToString("dd/MM/yyy");
                infoDict["sum"] = textBoxPaymentSum.Text;
                infoDict["student"] = this.GetStudentLogin();
                infoDict["employee"] = this.EmployeeLogin;
                PaymentPage paymentPage = new PaymentPage();
                string operationResultMessage = paymentPage.AddPaymentInformation(infoDict);
                MessageBox.Show(operationResultMessage);
            }
            else
            {
                MessageBox.Show("Для добавление информации о платежах необходимо заполнить все поля.");
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tbHoursCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 48 || e.KeyChar >= 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void InitializeFormComponent()
        {            
            cmbFloor.DataSource = hoursPage.GetFloorList();
            this.FillRoomComboBox();
            this.FillStudentComboBox();
            tbEmployee.Text = this.GetEmployeeSurnameName();
            switch(this.TypeOperation)
            {
                case "hours":
                    this.Text = "Добавление ОХЧ";
                    textBoxPaymentSum.Visible = false;
                    tbHoursCount.Visible = true;
                    label1.Visible = false;
                    labelCountHours.Visible = true;
                    richTextBoxDescription.Visible = true;
                    labelDescription.Visible = true;
                    break;
                case "payment":
                    this.Text = "Добавление оплаты";
                    textBoxPaymentSum.Visible = true;
                    tbHoursCount.Visible = false;
                    label1.Visible = true;
                    labelCountHours.Visible = false;
                    richTextBoxDescription.Visible = false;
                    labelDescription.Visible = false;
                    break;
            }
        }

        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillRoomComboBox();
        }

        private void cmbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillStudentComboBox();
        }

        private void FillRoomComboBox()
        {
            if (!string.IsNullOrEmpty(cmbFloor.Text))
            {
                cmbRoom.DataSource = hoursPage.GetRoomList(int.Parse(cmbFloor.Text));
            }
        }

        private void FillStudentComboBox()
        {
            if (!string.IsNullOrEmpty(cmbRoom.Text))
            {
                this.StudentList = hoursPage.GetStudentListDictionary(cmbRoom.Text);
                List<string> infoList = this.StudentList.Select(elem => elem["surnameName"]).ToList();
                cmbStudent.DataSource = infoList;
            }
        }

        private string GetStudentLogin()
        {
            string result = "";
            string userName = cmbStudent.Text;
            var aa  =this.StudentList.FirstOrDefault(elem => elem["surnameName"].Equals(userName)).TryGetValue("login", out result);
            return result;
        }

        private string GetEmployeeSurnameName()
        {
            return hoursPage.GetEmployeeSurnameName(this.EmployeeLogin);
        }

        private void tbEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private bool IsEmptyWorkHoursFieldsExist()
        {
            bool result = string.IsNullOrEmpty(dateInspection.Text) || string.IsNullOrEmpty(tbHoursCount.Text) ||
                string.IsNullOrEmpty(cmbFloor.Text) || string.IsNullOrEmpty(cmbRoom.Text) || string.IsNullOrEmpty(cmbStudent.Text) || 
                string.IsNullOrEmpty(tbEmployee.Text) || string.IsNullOrEmpty(richTextBoxDescription.Text);
                return result;
        }

        private bool IsEmptyPaymentsFieldsExist()
        {
            bool result = string.IsNullOrEmpty(dateInspection.Text) || string.IsNullOrEmpty(textBoxPaymentSum.Text) ||
                string.IsNullOrEmpty(cmbFloor.Text) || string.IsNullOrEmpty(cmbRoom.Text) || string.IsNullOrEmpty(cmbStudent.Text) ||
                string.IsNullOrEmpty(tbEmployee.Text);
            return result;
        }
    }
}
