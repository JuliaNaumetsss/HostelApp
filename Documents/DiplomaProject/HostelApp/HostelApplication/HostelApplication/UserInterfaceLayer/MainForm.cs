using System;
using System.Collections.Generic;
using System.Windows.Forms;
using HostelApplication.Enum;
using HostelApplication.Page;
using HostelApplication.ReportGenerator;
using HostelApplication.UserInterfaceLayer;


namespace HostelApplication
{
    public partial class MainForm : Form
    {
        bool IsEditUserOptionChoose = false;
        string UserLogin = "";
        int Usertype = -1;

        public MainForm(int userType, string login)
        {
            this.UserLogin = login;
            this.Usertype = userType;
            InitializeComponent();
            InitializeComponentOnForm(userType);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormLogin loginForm = new FormLogin();
            loginForm.Show();
        }

        private void InitializeComponentOnForm(int userType)
        {
            labelLogin.Text = this.UserLogin;
            dataGridViewStudents.Visible = false;
            dataGridViewEmployees.Visible = false;
            switch (userType)
            {
                case (int)UserTypeEnum.Admistrator:
                    this.DisplayFunctionForAdministrator();
                    break;
                case (int)UserTypeEnum.Student:
                    this.DisplayFunctionForStudent();
                    break;
                case (int)UserTypeEnum.Director:
                    this.DisplayFunctionForDirector();
                   // mainFunctionMenuItem.Visible = true;
                    break;
                case (int)UserTypeEnum.Castellant:
                    this.DisplayFunctionForCastellant();
                    break;
                case (int)UserTypeEnum.Waggon:
                    this.DisplayFunctionForWaggon();
                    break;
                case (int)UserTypeEnum.Mentor:
                    this.DisplayFunctionForMentor();
                    break;
            }
        }

        private void studentInfoMenuItem_Click(object sender, EventArgs e)
        {
            this.IsEditUserOptionChoose = false;
            dataGridViewStudents.Visible = true;
            dataGridViewEmployees.Visible = false;
            this.DisplayStudentList();
        }

        private void dataGridViewStudents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Usertype.Equals((int)UserTypeEnum.Admistrator) || this.Usertype.Equals((int)UserTypeEnum.Mentor) || this.Usertype.Equals((int)UserTypeEnum.Director))
            {
                int currentStudentIndex = dataGridViewStudents.CurrentRow.Index;
                string login = dataGridViewStudents.Rows[currentStudentIndex].Cells[5].Value.ToString();

                if (this.IsEditUserOptionChoose)
                {
                    // open form for edit Student
                    UserEditingForm editUserForm = new UserEditingForm("student", login);
                    editUserForm.Show();
                }
                else
                {
                    // open Information Form
                    InformationForm infoForm = new InformationForm(login, "student");
                    infoForm.Show();
                }
            }
        }

        private void DisplayStudentList()
        {
            dataGridViewStudents.Rows.Clear();
            dataGridViewStudents.Columns[5].Visible = false;
            UsersInformationPage infoPage = new UsersInformationPage();            
            foreach(Dictionary<string,string> dict in infoPage.GetStudentListInfoForDisplaying())
            {
                dataGridViewStudents.Rows.Add(dict["surname"], dict["name"], dict["patronymic"], dict["floor"], dict["room"], dict["login"]);
            }
        }

        private void employeeInfoMenuItem_Click(object sender, EventArgs e)
        {
            this.IsEditUserOptionChoose = false;
            dataGridViewEmployees.Visible = true;
            dataGridViewStudents.Visible = false;
            this.DisplayEmployeeList();
        }

        private void DisplayEmployeeList()
        {
            dataGridViewEmployees.Rows.Clear();
            dataGridViewEmployees.Columns[5].Visible = false;
            UsersInformationPage infoPage = new UsersInformationPage();
            foreach (Dictionary<string, string> dict in infoPage.GetEmployeeListInfoForDisplay())
            {
                dataGridViewEmployees.Rows.Add(dict["surname"], dict["name"], dict["patronymic"], dict["userType"], dict["room"], dict["login"]);
            }
        }

        private void dataGridViewEmployees_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.Usertype.Equals((int)UserTypeEnum.Admistrator) || this.Usertype.Equals((int)UserTypeEnum.Mentor) || this.Usertype.Equals((int)UserTypeEnum.Director))
            {
                int currentEmployeeIndex = dataGridViewEmployees.CurrentRow.Index;
                string login = dataGridViewEmployees.Rows[currentEmployeeIndex].Cells[5].Value.ToString();
                if (this.IsEditUserOptionChoose)
                {
                    // Open form for edit employee
                    UserEditingForm editUserForm = new UserEditingForm("employee", login);
                    editUserForm.Show();
                }
                else
                {
                    // Open form for view information
                    InformationForm infoForm = new InformationForm(login, "employee");
                    infoForm.Show();
                }
            }
        }

        private void addEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            UserAdditionForm userAdditionForm = new UserAdditionForm("employee");
            userAdditionForm.Show();
        }

        private void addStudentMenuItem_Click(object sender, EventArgs e)
        {
            UserAdditionForm userAdditionForm = new UserAdditionForm("student");
            userAdditionForm.Show();
        }

        private void removeEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            UserRemoveForm removeUserForm = new UserRemoveForm("employee");
            removeUserForm.Show();
        }

        private void removeStudentMenuItem_Click(object sender, EventArgs e)
        {
            UserRemoveForm removeUserForm = new UserRemoveForm("student");
            removeUserForm.Show();
        }

        private void editEmployeeMenuItem_Click(object sender, EventArgs e)
        {
            this.IsEditUserOptionChoose = true;
            dataGridViewEmployees.Visible = true;
            dataGridViewStudents.Visible = false;
            this.DisplayEmployeeList();
        }

        private void editStudentMenuItem_Click(object sender, EventArgs e)
        {
            this.IsEditUserOptionChoose = true;
            dataGridViewStudents.Visible = true;
            dataGridViewEmployees.Visible = false;
            this.DisplayStudentList();
        }

        private void editPasswordMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm(this.UserLogin);
            changePasswordForm.Show();
        }

        private void showPersonalInfoMenuItem_Click(object sender, EventArgs e)
        {
            InformationForm informationForm = new InformationForm(this.Usertype, this.UserLogin);
            informationForm.Show();
        }

        private void WorkedHoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkedHoursForm form = new WorkedHoursForm(UserLogin, "hours");
            form.Show();
        }

        private void WorkedHoursArrearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrearsForm form = new ArrearsForm("hours");
            form.Show();
        }

        private void PaymentArrearsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrearsForm form = new ArrearsForm("payment");
            form.Show();
        }

        private void PaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WorkedHoursForm form = new WorkedHoursForm(UserLogin, "payment");
            form.Show();
        }

        private void InspectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InspectionForm inspectionForm = new InspectionForm(this.UserLogin);
            inspectionForm.Show();
        }

        private void AddThingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddThingForm addThingRecordForm = new AddThingForm();
            addThingRecordForm.Show();
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            DataGridView grid = null;
            if (dataGridViewEmployees.Visible)
                grid = dataGridViewEmployees;
            if (dataGridViewStudents.Visible)
                grid = dataGridViewStudents;
            if (grid != null && grid.Rows.Count > 1)
            {
                if (string.IsNullOrEmpty(cmbFileFormat.Text))
                {
                    MessageBox.Show("Выберите формат файла.");
                }
                else
                {
                    switch (cmbFileFormat.Text)
                    {
                        case "MS Word":
                            WordFileCreator word = new WordFileCreator();
                            word.ExportToWord(grid);
                            break;
                        case "MS Excel":
                            ExcelFileCreator excelCreator = new ExcelFileCreator();
                            excelCreator.ExportToExcel(grid);
                            break;
                    }
                }
            }
        }

        #region Display components for different users type

        private void DisplayFunctionForAdministrator()
        {
            // main function
            mainFunctionMenuItem.Visible = true;
            removeEmployeeMenuItem.Visible = true;
            removeStudentMenuItem.Visible = true;
            addEmployeeMenuItem.Visible = true;
            addStudentMenuItem.Visible = true;
            editEmployeeMenuItem.Visible = true;
            editStudentMenuItem.Visible = true;

            ArrearsToolStripMenuItem.Visible = true;

            // other function
            OtherToolStripMenuItem.Visible = true;
            buttonOpenFile.Visible = true;
            cmbFileFormat.Visible = true;
        }

        private void DisplayFunctionForStudent()
        {
            mainFunctionMenuItem.Visible = false;
            ArrearsToolStripMenuItem.Visible = false;
            OtherToolStripMenuItem.Visible = false;
            buttonOpenFile.Visible = false;
            cmbFileFormat.Visible = false;
        }

        private void DisplayFunctionForDirector()
        {
            mainFunctionMenuItem.Visible = true;
            removeEmployeeMenuItem.Visible = false;
            removeStudentMenuItem.Visible = true;
            addEmployeeMenuItem.Visible = false;
            addStudentMenuItem.Visible = true;
            editEmployeeMenuItem.Visible = false;
            editStudentMenuItem.Visible = true;

            ArrearsToolStripMenuItem.Visible = true;

            OtherToolStripMenuItem.Visible = true;
            InspectionToolStripMenuItem.Visible = true;
            WorkedHoursArrearsToolStripMenuItem.Visible = true;
            PaymentToolStripMenuItem.Visible = true;
            AddThingsToolStripMenuItem.Visible = false;
            buttonOpenFile.Visible = true;
            cmbFileFormat.Visible = true;
        }

        private void DisplayFunctionForCastellant()
        {
            mainFunctionMenuItem.Visible = false;
            removeEmployeeMenuItem.Visible = false;
            ArrearsToolStripMenuItem.Visible = false;

            OtherToolStripMenuItem.Visible = true;
            InspectionToolStripMenuItem.Visible = false;
            WorkedHoursArrearsToolStripMenuItem.Visible = false;
            PaymentToolStripMenuItem.Visible = false;
            AddThingsToolStripMenuItem.Visible = true;
            buttonOpenFile.Visible = true;
            cmbFileFormat.Visible = true;
        }

        private void DisplayFunctionForWaggon()
        {
            mainFunctionMenuItem.Visible = false;
            removeEmployeeMenuItem.Visible = false;
            ArrearsToolStripMenuItem.Visible = false;
            OtherToolStripMenuItem.Visible = false;
            buttonOpenFile.Visible = true;
            cmbFileFormat.Visible = true;
        }

        private void DisplayFunctionForMentor()
        {
            mainFunctionMenuItem.Visible = true;
            removeEmployeeMenuItem.Visible = false;
            removeStudentMenuItem.Visible = false;
            addEmployeeMenuItem.Visible = false;
            addStudentMenuItem.Visible = false;
            editEmployeeMenuItem.Visible = false;
            editStudentMenuItem.Visible = true;


            ArrearsToolStripMenuItem.Visible = true;

            OtherToolStripMenuItem.Visible = true;
            InspectionToolStripMenuItem.Visible = true;
            WorkedHoursArrearsToolStripMenuItem.Visible = true;
            PaymentToolStripMenuItem.Visible = true;
            AddThingsToolStripMenuItem.Visible = false;
            buttonOpenFile.Visible = true;
            cmbFileFormat.Visible = true;
        }
        #endregion
    }
}
