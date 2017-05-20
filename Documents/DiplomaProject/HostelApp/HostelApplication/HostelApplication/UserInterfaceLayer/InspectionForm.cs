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
    public partial class InspectionForm : Form
    {
        string FirstEmployee = "";
        List<Dictionary<string, string>> InspectorsListDictionary = new List<Dictionary<string, string>>();

        public InspectionForm(string firstEmployeeLogin)
        {
            this.FirstEmployee = firstEmployeeLogin;
            InitializeComponent();
            this.InitializeFormComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void InitializeFormComponent()
        {
            InspectionPage inspection = new InspectionPage();
            cmbFloor.DataSource = inspection.GetFloorList();
            tbFirstEmployee.Text = inspection.GetEmployeeSurnameName(this.FirstEmployee);
            this.InspectorsListDictionary = inspection.GetInspectorList();
            List<string> inspectors = this.InspectorsListDictionary.Select(elem => elem["commonInfo"]).ToList();
            inspectors.Add("-");
            cmbSecondEmployee.DataSource = inspectors;
        }

        private void buttonAddInspection_Click(object sender, EventArgs e)
        {
            InspectionPage inspection = new InspectionPage();
            if(!this.IsEmptyFieldsExist())
            {
                Dictionary<string, string> inspectionInfo = this.FormInspectionDictionary();
                string resultMessage = inspection.AddInspectionInfo(inspectionInfo);
                MessageBox.Show(resultMessage);
            }
            else
            {
                MessageBox.Show("Заполните все обязательные поля.");
            }
        }

        private void cmbFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            InspectionPage inspection = new InspectionPage();
            if (!string.IsNullOrEmpty(cmbFloor.Text))
            {
                cmbRoom.DataSource = inspection.GetRoomList(int.Parse(cmbFloor.Text));
            }
        }

        private void tbFirstEmployee_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private Dictionary<string, string> FormInspectionDictionary()
        {
            Dictionary<string, string> infoDict = new Dictionary<string, string>();
            infoDict["date"] = dateInspection.Value.ToString("dd/MM/yyy");
            infoDict["room"] = cmbRoom.Text;
            infoDict["firstEmployee"] = this.FirstEmployee;
            if(cmbSecondEmployee.Text.Equals("-") || string.IsNullOrEmpty(cmbSecondEmployee.Text))
            {
                infoDict["secondEmploye"] = "";
            }
            else
            {
                string employeeLogin = "";
                this.InspectorsListDictionary.FirstOrDefault(elem => elem["commonInfo"].Equals(cmbSecondEmployee.Text)).TryGetValue("login", out employeeLogin);
                infoDict["secondEmploye"] = employeeLogin;
            }
            
            infoDict["restRoom"] = cmbRestRoom.Text;
            infoDict["bathroom"] = cmbBathroom.Text;
            infoDict["hall"] = cmbHall.Text;
            infoDict["kitchen"] = cmbKitchen.Text;
            infoDict["roomA"] = cmbRoomA.Text;
            infoDict["roomB"] = cmbRoomB.Text;
            return infoDict;
        }

        private bool IsEmptyFieldsExist()
        {
            bool isEmpty = string.IsNullOrEmpty(dateInspection.Text) || string.IsNullOrEmpty(cmbFloor.Text) || string.IsNullOrEmpty(cmbRoom.Text) ||
                string.IsNullOrEmpty(tbFirstEmployee.Text) || string.IsNullOrEmpty(cmbRestRoom.Text) || string.IsNullOrEmpty(cmbBathroom.Text) ||
                string.IsNullOrEmpty(cmbHall.Text) || string.IsNullOrEmpty(cmbKitchen.Text) || string.IsNullOrEmpty(cmbRoomA.Text) || string.IsNullOrEmpty(cmbRoomB.Text);
            return isEmpty;
        }
    }
}
