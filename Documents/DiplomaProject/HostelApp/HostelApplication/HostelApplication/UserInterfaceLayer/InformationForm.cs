using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelApplication.Enum;
using HostelApplication.Model;
using HostelApplication.Page;

namespace HostelApplication
{
    public partial class InformationForm : Form
    {
        public InformationForm()
        {
            InitializeComponent();
        }

        public InformationForm(string login, string userType) : this()
        {
            switch(userType)
            {
                case "student":
                    this.DisplayStudentInformation(login);
                    break;
                case "employee":
                    this.DisplayEmployeeInformation(login);
                    break;
            }
        }

        public InformationForm(int userType, string login) : this()
        {
            switch(userType)
            {
                case (int)UserTypeEnum.Student:
                    this.DisplayPersonalInfoForStudent(login);
                    break;
                default:
                    this.DisplayPersonalInfoForEmployee(login);
                    break;
            }
        }

        private Dictionary<string, string> DisplayStudentInformation(string login)
        {
            this.Width = infoTextBox.Width + 10;
            this.Text = "Информация о студенте";
            UsersInformationPage infoPage = new UsersInformationPage();
            Dictionary<string, string> studentInfoDictionary = infoPage.GetStudentInfoByLogin(login);
            infoTextBox.Clear();
            infoTextBox.AppendText($"Фамилия: {studentInfoDictionary["surname"]} \r\n");
            infoTextBox.AppendText($"Имя: {studentInfoDictionary["name"]} \r\n");
            infoTextBox.AppendText($"Отчество: {studentInfoDictionary["patronymic"]} \r\n");
            infoTextBox.AppendText($"Домашний адрес: {studentInfoDictionary["address"]} \r\n");
            infoTextBox.AppendText($"Номер группы: {studentInfoDictionary["group"]} \r\n");
            infoTextBox.AppendText($"Курс: {studentInfoDictionary["course"]} \r\n");
            infoTextBox.AppendText($"Номер комнаты: {studentInfoDictionary["room"]} \r\n");
            infoTextBox.AppendText($"Староста этажа: {studentInfoDictionary["headFloor"]} \r\n");
            infoTextBox.AppendText($"Номер телефона: {studentInfoDictionary["phone"]} \r\n");
            infoTextBox.AppendText($"Номер паспорта: {studentInfoDictionary["passport"]} \r\n");

            Image studentPhoto = infoPage.GetStudentPhotoFromDataBase(login);
            if (studentPhoto != null)
            {
                this.Width = infoTextBox.Width + pictureBoxPhoto.Width + 50;
                studentPhoto = infoPage.CompressImage(studentPhoto, pictureBoxPhoto.Width, pictureBoxPhoto.Height);
                pictureBoxPhoto.Image = studentPhoto;
            }

            return studentInfoDictionary;
        }

        private Dictionary<string, string> DisplayEmployeeInformation(string login)
        {
            this.Width = infoTextBox.Width + 10;
            this.Text = "Информация о сотруднике";
            UsersInformationPage infoPage = new UsersInformationPage();
            Dictionary<string, string> employeeInfoDictionary = infoPage.GetEmployeeInfoByLogin(login);
            infoTextBox.Clear();
            infoTextBox.AppendText($"Фамилия: {employeeInfoDictionary["surname"]} \r\n");
            infoTextBox.AppendText($"Имя: {employeeInfoDictionary["name"]} \r\n");
            infoTextBox.AppendText($"Отчество: {employeeInfoDictionary["patronymic"]} \r\n");
            infoTextBox.AppendText($"Домашний адрес: {employeeInfoDictionary["address"]} \r\n");
            infoTextBox.AppendText($"Должность: {employeeInfoDictionary["userType"]} \r\n");
            infoTextBox.AppendText($"Номер комнаты: {employeeInfoDictionary["room"]} \r\n");
            infoTextBox.AppendText($"Рабочий телефон: {employeeInfoDictionary["workPhone"]} \r\n");
            infoTextBox.AppendText($"Номер телефона: {employeeInfoDictionary["phone"]} \r\n");
            infoTextBox.AppendText($"Номер паспорта: {employeeInfoDictionary["passport"]} \r\n");
            return employeeInfoDictionary;
        }

        private void DisplayPersonalInfoForStudent(string login)
        {            
            Dictionary<string, string> dict = this.DisplayStudentInformation(login);
            infoTextBox.AppendText($"Общее число отработанных часов: {dict["workedHours"]} \r\n");
            infoTextBox.AppendText($"Общая сумма оплаты: {dict["payment"]} \r\n");
            infoTextBox.AppendText($"Логин: {login}");
        }

        private void DisplayPersonalInfoForEmployee(string login)
        {
            Dictionary<string, string> dict = this.DisplayEmployeeInformation(login);
            infoTextBox.AppendText($"Логин: {login}");
        }

    }
}
