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
    public partial class UserRemoveForm : Form
    {
        string user = "";
        public UserRemoveForm(string userType)
        {
            user = userType;
            InitializeComponent();
            switch(userType)
            {
                case "employee":
                    this.InitializeEmployeeComponent();
                    break;
                case "student":
                    this.InitializeStudentComponent();
                    break;
            }
        }

        private void InitializeEmployeeComponent()
        {
            this.Text = "Удаление сотрудника";
            gridEmployee.Visible = true;
            gridStudent.Visible = false;
            this.FillEmployeeTable();
        }

        private void InitializeStudentComponent()
        {
            this.Text = "Удаление студента";
            gridEmployee.Visible = false;
            gridStudent.Visible = true;
            this.FillStudentTable();
        }

        public void FillStudentTable()
        {
            gridStudent.Rows.Clear();
            gridStudent.Columns[6].Visible = false;
            UsersInformationPage infoPage = new UsersInformationPage();
            foreach (Dictionary<string, string> dict in infoPage.GetStudentListInfoForDisplaying())
            {
                gridStudent.Rows.Add(dict["surname"], dict["name"], dict["patronymic"], dict["floor"], dict["room"], dict["phone"], dict["login"]);
            }
        }

        public void FillEmployeeTable()
        {
            gridEmployee.Rows.Clear();
            gridEmployee.Columns[6].Visible = false;
            UsersInformationPage infoPage = new UsersInformationPage();
            foreach (Dictionary<string, string> dict in infoPage.GetEmployeeListInfoForDisplay())
            {
                gridEmployee.Rows.Add(dict["surname"], dict["name"], dict["patronymic"], dict["userType"], dict["room"], dict["phone"], dict["login"]);
            }
        }

        private void gridStudent_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedRow = gridStudent.CurrentRow.Index;
            string surname = gridStudent.Rows[selectedRow].Cells[0].Value.ToString();
            string name = gridStudent.Rows[selectedRow].Cells[1].Value.ToString();
            string patronymic = gridStudent.Rows[selectedRow].Cells[2].Value.ToString();
            string login = gridStudent.Rows[selectedRow].Cells[6].Value.ToString();
            var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить студента: {surname} {name} {patronymic} ?", "Подтвердите удаление", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                RemoveStudentPage removePage = new RemoveStudentPage();
                string resultMessage = removePage.RemoveStudent(login);
                MessageBox.Show(resultMessage);
                this.FillStudentTable();
            }
        }

        private void gridEmployee_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int selectedRow = gridEmployee.CurrentRow.Index;
            string surname = gridEmployee.Rows[selectedRow].Cells[0].Value.ToString();
            string name = gridEmployee.Rows[selectedRow].Cells[1].Value.ToString();
            string patronymic = gridEmployee.Rows[selectedRow].Cells[2].Value.ToString();
            string login = gridEmployee.Rows[selectedRow].Cells[6].Value.ToString();
            var confirmResult = MessageBox.Show($"Вы уверены, что хотите удалить сотрудника: {surname} {name} {patronymic} ?", "Подтвердите удаление", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                RemoveEmployeePage removePage = new RemoveEmployeePage();
                string resultMessage = removePage.RemoveEmployee(login);
                MessageBox.Show(resultMessage);
                this.FillEmployeeTable();
            }
        }
    }
}
