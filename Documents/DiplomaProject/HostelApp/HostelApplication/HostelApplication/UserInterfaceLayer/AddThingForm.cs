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
    public partial class AddThingForm : Form
    {
        List<Dictionary<string, string>> StudentList = new List<Dictionary<string, string>>();
        WorkedHoursPage hoursPage = new WorkedHoursPage();

        public AddThingForm()
        {
            InitializeComponent();
            this.InitializeFormComponent();
        }

        private void InitializeFormComponent()
        {
            
            ThingPage page = new ThingPage();
            List<string> thingList = page.GetAvailableThingList();
            foreach(string thing in thingList)
            {
                
                cmbThing.Items.Add(thing);
            }
            cmbFloor.DataSource = hoursPage.GetFloorList();
            this.FillRoomComboBox();
            this.FillStudentComboBox();
        }

        private void buttonAddThing_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cmbThing.Text) || string.IsNullOrEmpty(cmbThingCount.Text))
            {
                MessageBox.Show("Выберите вещь и её количество.");
            }
            else
            {
                string text = cmbThing.Text;
                dataGridView.Rows.Add(text, cmbThingCount.Text);
                cmbThing.Items.Remove(text);
            }
        }

        private void dataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            int row = dataGridView.CurrentCell.RowIndex;
            cmbThing.Items.Add(dataGridView[0, row].Value.ToString());
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            if(this.AreEmptyFieldsExist())
            {
                MessageBox.Show("Заполните все поля.");
            }
            else
            {
                if(!IsGridFilled())
                {
                    MessageBox.Show("Для лобавления записи необходимо выбрать вещи.");
                }
                else
                {
                    ThingPage page = new ThingPage();
                    Dictionary<string, string> commonInfo = this.FormCommonInfoThingsDictionaryToAdd();
                    Dictionary<int, int> thingsInfo = this.FormThingsDictionary();
                    string resultMessage = page.AddThings(commonInfo, thingsInfo);
                    MessageBox.Show(resultMessage);
                }
            }
        }

        private bool AreEmptyFieldsExist()
        {
            bool isEmpty = string.IsNullOrEmpty(dateTime.Text) || string.IsNullOrEmpty(cmbFloor.Text) || string.IsNullOrEmpty(cmbRoom.Text)
                || string.IsNullOrEmpty(cmbStudent.Text);
            return isEmpty;
        }

        private bool IsGridFilled()
        {
            return dataGridView.Rows.Count > 1;
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
                if (this.StudentList.Count != 0)
                {
                    List<string> infoList = this.StudentList.Select(elem => elem["surnameName"]).ToList();
                    cmbStudent.DataSource = infoList;
                }
                else
                {
                    List<string> list = new List<string>();
                    list.Add("");
                    cmbStudent.DataSource = list;
                }
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

        private string GetStudentLogin()
        {
            string result = "";
            string userName = cmbStudent.Text;
            var aa = this.StudentList.FirstOrDefault(elem => elem["surnameName"].Equals(userName)).TryGetValue("login", out result);
            return result;
        }

        private Dictionary<string, string> FormCommonInfoThingsDictionaryToAdd()
        {
            Dictionary<string, string> resultDict = new Dictionary<string, string>();
            resultDict["date"] = dateTime.Value.ToString("dd/MM/yyy");
            resultDict["student"] = this.GetStudentLogin();
            return resultDict;
        }

        // key - id thing, value - count thing
        private Dictionary<int, int> FormThingsDictionary()
        {
            ThingPage page = new ThingPage();
            Dictionary<int, int> resultDict = new Dictionary<int, int>();
            for(int rowNumber = 0; rowNumber < dataGridView.Rows.Count-1; rowNumber++)
            {
                resultDict[page.GetIdThingByName(dataGridView[0, rowNumber].Value.ToString())] = int.Parse(dataGridView[1, rowNumber].Value.ToString());
            }
            return resultDict;
        }

        private void cmbThing_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbThingCount.Items.Clear();
            ThingPage page = new ThingPage();
            for (int i = 1; i <= page.GetAvailableThingCount(cmbThing.Text); i++)
            {
                cmbThingCount.Items.Add(i);
                if (i == 5)
                    break;
            }
        }
    }
}
