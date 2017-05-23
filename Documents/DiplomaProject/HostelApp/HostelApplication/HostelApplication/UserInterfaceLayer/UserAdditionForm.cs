using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HostelApplication.Page;

namespace HostelApplication
{
    public partial class UserAdditionForm : Form
    {
        string user = "";
        public UserAdditionForm(string userType)
        {
            this.user = userType;
            InitializeComponent();
            switch(userType)
            {
                case "employee":
                    this.InitializeComponentForEmployee();
                    break;
                case "student":
                    this.InitializeComponentForStudent();
                    break;
            }
        }

        private void InitializeComponentForStudent()
        {
            labelFilePath.Text = "";
            this.Text = "Добавление студента";
            panelEmployeeInfo.Visible = false;
            panelStudentInfo.Visible = true;
            AddStudentPage addStudentPage = new AddStudentPage();
            cmbFloorStudent.DataSource = addStudentPage.GetFloorList();
            if(!string.IsNullOrEmpty(cmbFloorStudent.Text))
            {
                cmbRoomStudent.DataSource = addStudentPage.GetEmptyRoomListByFloorNumber(int.Parse(cmbFloorStudent.Text));
            }
        }

        private void InitializeComponentForEmployee()
        {            
            this.Text = "Добавление сотрудника";
            panelEmployeeInfo.Visible = true;
            panelStudentInfo.Visible = false;

            AddEmployeePage addEmployeePage = new AddEmployeePage();
            cmbUserType.DataSource = addEmployeePage.GetUsersTypeForEmployee();
            cmbFloor.DataSource = addEmployeePage.GetFloorList();
            
            if (!string.IsNullOrEmpty(cmbFloor.Text))
            {
                cmbRoom.DataSource = addEmployeePage.GetEmptyRoomListByFloorNumber(int.Parse(cmbFloor.Text));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddEmployeePage addEmployeePage = new AddEmployeePage();
            if (!string.IsNullOrEmpty(cmbFloor.Text))
            {
                cmbRoom.DataSource = addEmployeePage.GetEmptyRoomListByFloorNumber(int.Parse(cmbFloor.Text));
            }
        }

        private void cmbFloorStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddStudentPage addStudentPage = new AddStudentPage();
            if (!string.IsNullOrEmpty(cmbFloorStudent.Text))
            {
                cmbRoomStudent.DataSource = addStudentPage.GetEmptyRoomListByFloorNumber(int.Parse(cmbFloorStudent.Text));
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (this.AreAllFieldsFilled() && this.IsPasswordLengthCorrect() && this.IsLoginLengthCorrect() && this.ArePasswordsMatch())
            {
                switch (user)
                {
                    case "employee":
                        this.AddEmployee();
                        break;
                    case "student":
                        this.AddStudent();
                        break;
                }
                
            }
        }

        private void AddEmployee()
        {
            AddEmployeePage additionPage = new AddEmployeePage();
            Dictionary<string, string> employeeInfo = this.FormEmployeeInfoDictionary();
            string str = additionPage.AddEmployee(employeeInfo);
            MessageBox.Show(str);
        }

        private void AddStudent()
        {
            AddStudentPage additionPage = new AddStudentPage();
            Dictionary<string, string> studentInfo = this.FormStudentInfoDictionary();
            string resultMessage = additionPage.AddStudent(studentInfo);
            MessageBox.Show(resultMessage);
        }

        private bool AreAllFieldsFilled()
        {
            bool isFieldsFillCorrect = true;
            bool isUserFieldsEmpty = true;
            switch(user)
            {
                case "student":
                    isUserFieldsEmpty = this.AreStudentFieldsEmpty();
                    break;
                case "employee":
                    isUserFieldsEmpty = this.AreEmployeeFormFieldsEmpty();
                    break;
            }
            if(this.AreCommonFormFieldsEmpty() || isUserFieldsEmpty)
            {
                isFieldsFillCorrect = false;
                MessageBox.Show("Пожалуйста, заполните все поля!");
            }
            return isFieldsFillCorrect;
        }

        private bool AreEmployeeFormFieldsEmpty()
        {
            bool isEmpty = string.IsNullOrEmpty(cmbUserType.Text) ||
                string.IsNullOrEmpty(tbWorkPhone.Text) || string.IsNullOrEmpty(cmbRoom.Text);
            return isEmpty;
        }

        private bool AreCommonFormFieldsEmpty()
        {
            bool isEmpty = string.IsNullOrEmpty(tbName.Text) || string.IsNullOrEmpty(tbSurname.Text) || string.IsNullOrEmpty(tbPatronymic.Text) ||
                !tbPhone.MaskCompleted || string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(tbPassport.Text) ||
                string.IsNullOrEmpty(tbLogin.Text) || string.IsNullOrEmpty(tbPassword.Text) || string.IsNullOrEmpty(tbConfirmPassword.Text);
            return isEmpty;
        }

        private bool AreStudentFieldsEmpty()
        {
            bool isEmpty = string.IsNullOrEmpty(tbGruop.Text) || string.IsNullOrEmpty(cmbCourse.Text) || string.IsNullOrEmpty(cmbFloorStudent.Text) ||
                string.IsNullOrEmpty(cmbRoomStudent.Text);
            return isEmpty;
        }

        private bool ArePasswordsMatch()
        {
            bool isMatch = tbPassword.Text.Equals(tbConfirmPassword.Text);
            if (!isMatch)
                MessageBox.Show("Пароли не совпадают!");
            return isMatch;
        }

        private bool IsPasswordLengthCorrect()
        {
            bool isLengthCorrect = tbPassword.Text.Length > 5;
            if (!isLengthCorrect)
                MessageBox.Show("Пароль должен быть от 6 до 16 символов.");
            return isLengthCorrect;
        }

        private bool IsLoginLengthCorrect()
        {
            bool isLengthCorrect = tbLogin.Text.Length > 5;
            if (!isLengthCorrect)
                MessageBox.Show("Логин должен быть от 6 до 15 символов.");
            return isLengthCorrect;
        }

        private Dictionary<string, string> FormEmployeeInfoDictionary()
        {
            Dictionary<string, string> resultDict = this.GetCommonUserInfo();
            resultDict["userType"] = cmbUserType.Text;
            resultDict["workPhone"] = tbWorkPhone.Text;
            resultDict["room"] = cmbRoom.Text;

            return resultDict;
        }

        private Dictionary<string, string> FormStudentInfoDictionary()
        {
            Dictionary<string, string> resultDict = this.GetCommonUserInfo();
            resultDict["group"] = tbGruop.Text;
            resultDict["course"] = cmbCourse.Text;
            resultDict["room"] = cmbRoomStudent.Text;
            resultDict["headFloor"] = checkBoxHeadFloor.Checked ? "1" : "0";
            resultDict["filePath"] = labelFilePath.Text;
            return resultDict;
        }

        private Dictionary<string, string> GetCommonUserInfo()
        {
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            resultDict["name"] = tbName.Text;
            resultDict["surname"] = tbSurname.Text;
            resultDict["patronymic"] = tbPatronymic.Text;
            resultDict["phone"] = tbPhone.Text;
            resultDict["address"] = tbAddress.Text;
            resultDict["passport"] = tbPassport.Text;
            resultDict["login"] = tbLogin.Text;
            resultDict["password"] = tbPassword.Text;
            return resultDict;
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = this.PasswordLimitations(e);
        }

        private void tbLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol < 'A' || symbol > 'Z') && (symbol < 'a' || symbol > 'z') && (symbol < '0' || symbol > '9') &&
                symbol != '\b' && symbol != '-' && symbol != '_' && symbol != '.')
            {
                e.Handled = true;
            }
        }

        private void tbConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            e = this.PasswordLimitations(e);
        }

        private KeyPressEventArgs PasswordLimitations(KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol >= 'а' && symbol <= 'я') || (symbol >= 'А' && symbol <= 'Я') || char.IsWhiteSpace(symbol))
            {
                e.Handled = true;
            }
            return e;
        }

        private void buttonChooseImage_Click(object sender, EventArgs e)
        {
            labelFilePath.Text = "";
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.FileName;

                labelFilePath.Visible = true;
                labelFilePath.Text = path;
            }         
        }
    }
}
