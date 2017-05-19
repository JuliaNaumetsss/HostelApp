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
    public partial class UserEditingForm : Form
    {
        string user = "";
        string UserLogin = "";
        public UserEditingForm(string userType, string login)
        {
            InitializeComponent();
            this.user = userType;
            this.UserLogin = login;
            switch(userType)
            {
                case "student":
                    this.InitializeStudentComponent();
                    break;
                case "employee":
                    this.InitializeEmployeeComponent();
                    break;
            }
        }

        public void InitializeStudentComponent()
        {
            this.Text = "Редактирование информации о студенте";
            panelEmployeeInfo.Visible = false;
            panelStudentInfo.Visible = true;
            EditStudentPage editPage = new EditStudentPage();
            cmbFloorStudent.DataSource = editPage.GetAllFloorList();
            if(!string.IsNullOrEmpty(cmbFloorStudent.Text))
            {
                cmbRoomStudent.DataSource = editPage.GetEmptyRoomListByFloorNumber(int.Parse(cmbFloorStudent.Text));
            }
            this.FillStudentFields(editPage.GetStudentInfoDictionaryByLogin(this.UserLogin));
        }

        public void InitializeEmployeeComponent()
        {
            this.Text = "Редактирование информации о сотруднике";
            panelEmployeeInfo.Visible = true;
            panelStudentInfo.Visible = false;
            EditEmployeePage editPage = new EditEmployeePage();
            cmbFloor.DataSource = editPage.GetAllFloorList();
            cmbUserType.DataSource = editPage.GetUsersTypeForEmployee();
            if (!string.IsNullOrEmpty(cmbFloor.Text))
            {
                cmbRoom.DataSource = editPage.GetEmptyRoomListByFloorNumber(int.Parse(cmbFloor.Text));
            }
            this.FillEmployeeFields(editPage.GetEmployeeInfoDictionaryByLogin(this.UserLogin));
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (this.AreAllFieldsFilled())
            {
                switch (user)
                {
                    case "student":
                        this.EditStudent();
                        break;
                    case "employee":
                        this.EditEmployee();
                        break;
                }
            }
        }

        private void EditStudent()
        {
            EditStudentPage editPage = new EditStudentPage();
            Dictionary<string, string> studentInfo = this.FormStudentDictionaryInfo();
            string resultMessage = editPage.EditStudentInformation(studentInfo);
            MessageBox.Show(resultMessage);
        }

        private void EditEmployee()
        {
            EditEmployeePage editPage = new EditEmployeePage();
            Dictionary<string, string> employeeInfo = this.FormEmployeeDictionaryInfo();
            string resultMessage = editPage.EditEmployeeInformation(employeeInfo);
            MessageBox.Show(resultMessage);
        }

        private Dictionary<string, string> FormStudentDictionaryInfo()
        {
            Dictionary<string, string> resultDict = this.GetCommonUserInfo();
            resultDict["group"] = tbGruop.Text;
            resultDict["course"] = cmbCourse.Text;
            resultDict["room"] = cmbRoomStudent.Text;
            resultDict["headFloor"] = checkBoxHeadFloor.Checked ? "1" : "0";
            return resultDict;
        }

        private Dictionary<string, string> FormEmployeeDictionaryInfo()
        {
            Dictionary<string, string> resultDict = this.GetCommonUserInfo();
            resultDict["userType"] = cmbUserType.Text;
            resultDict["workPhone"] = tbWorkPhone.Text;
            resultDict["room"] = cmbRoom.Text;
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
            resultDict["room"] = cmbRoom.Text;
            resultDict["login"] = this.UserLogin;
            return resultDict;
        }

        private void FillStudentFields(Dictionary<string, string> infoDict)
        {
            checkBoxHeadFloor.Checked = false;
            tbName.Text = infoDict["name"];
            tbSurname.Text = infoDict["surname"];
            tbPatronymic.Text = infoDict["patronymic"];
            tbPhone.Text = infoDict["phone"];
            tbAddress.Text = infoDict["address"];
            tbPassport.Text = infoDict["passport"];
            tbGruop.Text = infoDict["group"];
            cmbCourse.Text = infoDict["course"];
            cmbFloorStudent.Text = infoDict["floor"];
            this.AddStudentRoomToComboBoxIfNotExist(infoDict["room"]);
            cmbRoomStudent.Text = infoDict["room"];
            if(infoDict["headFloor"].Trim().Equals("да"))
            {
                checkBoxHeadFloor.Checked = true;
            }
        }

        private void FillEmployeeFields(Dictionary<string, string> infoDict)
        {
            tbName.Text = infoDict["name"];
            tbSurname.Text = infoDict["surname"];
            tbPatronymic.Text = infoDict["patronymic"];
            tbPhone.Text = infoDict["phone"];
            tbAddress.Text = infoDict["address"];
            tbPassport.Text = infoDict["passport"];
            cmbFloor.Text = infoDict["floor"];
            this.AddEmployeeRoomToComboBoxIfNotExist(infoDict["room"]);
            cmbRoom.Text = infoDict["room"];
            cmbUserType.Text = infoDict["userType"];
            tbWorkPhone.Text = infoDict["workPhone"];
        }

        private void cmbFloorStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditStudentPage editPage = new EditStudentPage();
            if (!string.IsNullOrEmpty(cmbFloorStudent.Text))
            {
                cmbRoomStudent.DataSource = editPage.GetEmptyRoomListByFloorNumber(int.Parse(cmbFloorStudent.Text));
            }
        }

        private void AddStudentRoomToComboBoxIfNotExist(string room)
        {
            if (!cmbRoomStudent.Items.Contains(room))
            {
                List<string> roomList = new List<string>();
                foreach (var item in cmbRoomStudent.Items)
                {
                    roomList.Add(cmbRoomStudent.GetItemText(item));
                }
                roomList.Add(room);
                cmbRoomStudent.DataSource = roomList;
            }
        }

        private void AddEmployeeRoomToComboBoxIfNotExist(string room)
        {
            if (!cmbRoom.Items.Contains(room))
            {
                List<string> roomList = new List<string>();
                foreach (var item in cmbRoom.Items)
                {
                    roomList.Add(cmbRoom.GetItemText(item));
                }
                roomList.Add(room);
                cmbRoom.DataSource = roomList;
            }
        }

        private bool AreAllFieldsFilled()
        {
            bool isFieldsFillCorrect = true;
            bool isUserFieldsEmpty = true;
            switch (user)
            {
                case "student":
                    isUserFieldsEmpty = this.AreStudentFieldsEmpty();
                    break;
                case "employee":
                    isUserFieldsEmpty = this.AreEmployeeFormFieldsEmpty();
                    break;
            }
            if (this.AreCommonFormFieldsEmpty() || isUserFieldsEmpty)
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
                !tbPhone.MaskCompleted || string.IsNullOrEmpty(tbAddress.Text) || string.IsNullOrEmpty(tbPassport.Text); 
            return isEmpty;
        }

        private bool AreStudentFieldsEmpty()
        {
            bool isEmpty = string.IsNullOrEmpty(tbGruop.Text) || string.IsNullOrEmpty(cmbCourse.Text) || string.IsNullOrEmpty(cmbFloorStudent.Text) ||
                string.IsNullOrEmpty(cmbRoomStudent.Text);
            return isEmpty;
        }
    }
}
