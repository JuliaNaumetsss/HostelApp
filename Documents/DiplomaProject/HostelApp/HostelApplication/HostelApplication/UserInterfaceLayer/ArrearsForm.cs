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
using HostelApplication.ReportGenerator;

namespace HostelApplication.UserInterfaceLayer
{
    public partial class ArrearsForm : Form
    {
        string OperationType = "";
        public ArrearsForm(string operation)
        {
            this.OperationType = operation;
            InitializeComponent();
            switch(operation)
            {
                case "hours":
                    this.InitializeWorkedHoursComponents();
                    break;
                case "payment":
                    this.InitializePaymentComponents();
                    break;
            }
        }

        private void buttonShowDebtors_Click(object sender, EventArgs e)
        {
            dataGridViewDebtors.Rows.Clear();
            switch(this.OperationType)
            {
                case "hours":
                    this.ShowWorkedHoursDebtors();
                    break;
                case "payment":
                    this.ShowPaymentDebtors();
                    break;
            }
        }

        private void ShowWorkedHoursDebtors()
        {
            WorkedHoursPage workedHoursPage = new WorkedHoursPage();
            if (this.IsWorkedHoursFieldsEmpty() || string.IsNullOrEmpty(tbHoursCount.Text))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                List<Dictionary<string, string>> debtors = workedHoursPage.GetDebtorsList(int.Parse(tbHoursCount.Text));
                foreach (Dictionary<string, string> debtorInfo in debtors)
                {
                    dataGridViewDebtors.Rows.Add(debtorInfo["surname"], debtorInfo["name"], debtorInfo["patronymic"], debtorInfo["totalWorkedHours"], tbHoursCount.Text);
                }
            }
        }

        private void ShowPaymentDebtors()
        {
            PaymentPage paymentPage = new PaymentPage();
            if(this.IsPaymentFieldsEmpty() || string.IsNullOrEmpty(tbExpectedSum.Text))
            {
                MessageBox.Show("Заполните все поля!");
            }
            else
            {
                List<Dictionary<string, string>> debtors = paymentPage.GetDebtorsList(int.Parse(tbExpectedSum.Text));
                foreach (Dictionary<string, string> debtorInfo in debtors)
                {
                    dataGridViewDebtors.Rows.Add(debtorInfo["surname"], debtorInfo["name"], debtorInfo["patronymic"], debtorInfo["paymentSum"], tbExpectedSum.Text);
                }
            }
        }

        private int GetMonthNumber(string month)
        {
            int number = -1;
            switch (month)
            {
                case "январь":
                    number = 1;
                    break;
                case "февраль":
                    number = 2;
                    break;
                case "март":
                    number = 3;
                    break;
                case "апрель":
                    number = 4;
                    break;
                case "май":
                    number = 5;
                    break;
                case "июнь":
                    number = 6;
                    break;
                case "июль":
                    number = 7;
                    break;
                case "август":
                    number = 8;
                    break;
                case "сентябрь":
                    number = 9;
                    break;
                case "октябрь":
                    number = 10;
                    break;
                case "ноябрь":
                    number = 11;
                    break;
                case "декабрь":
                    number = 12;
                    break;
            }
            return number;
        }

        private int GetExpectedPaymentOrWorkedHoursValue()
        {
            int result = -1;
            int startMonth = this.GetMonthNumber(cmbStartMonth.Text);
            int endMonth = this.GetMonthNumber(cmbEndMonth.Text);
            int norm = -1;
            switch(this.OperationType)
            {
                case "hours":
                    norm = int.Parse(cmbNormCount.Text);
                    break;
                case "payment":
                    norm = int.Parse(tbNormSum.Text);
                    break;
            }
            
            if(startMonth > endMonth)
            {
                result = 12 - (startMonth - endMonth) + 1;
                result = norm * result;
            }
            else
            {
                result = endMonth - startMonth + 1;
                result = norm * result;
            }
            return result;
        }

        private void tbHoursCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbEndMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.OperationType)
            {
                case "hours":
                    if (!this.IsWorkedHoursFieldsEmpty())
                    {
                        tbHoursCount.Text = this.GetExpectedPaymentOrWorkedHoursValue().ToString();
                    }
                    break;
                case "payment":
                    if (!this.IsPaymentFieldsEmpty())
                    {

                        tbExpectedSum.Text = this.GetExpectedPaymentOrWorkedHoursValue().ToString();
                    }
                    break;
            }
        }

        private bool IsWorkedHoursFieldsEmpty()
        {
            bool isEmpty = string.IsNullOrEmpty(cmbStartMonth.Text) || string.IsNullOrEmpty(cmbEndMonth.Text) || string.IsNullOrEmpty(cmbNormCount.Text);
            return isEmpty;
        }

        private bool IsPaymentFieldsEmpty()
        {
            bool isEmpty = string.IsNullOrEmpty(cmbStartMonth.Text) || string.IsNullOrEmpty(cmbEndMonth.Text) || string.IsNullOrEmpty(tbNormSum.Text);
            return isEmpty;
        }

        private void InitializeWorkedHoursComponents()
        {
            this.Text = "Задолженности по ОХЧ";
            lbNormSum.Visible = false;
            lbNormHours.Visible = true;
            lbExpectedSum.Visible = false;
            lbExpectedHours.Visible = true;
            tbNormSum.Visible = false;
            cmbNormCount.Visible = true;
            tbExpectedSum.Visible = false;
            tbHoursCount.Visible = true;
            dataGridViewDebtors.Columns[3].HeaderText = "Отработанное количество";
            dataGridViewDebtors.Columns[4].HeaderText = "Необходимое число часов";
        }

        private void InitializePaymentComponents()
        {
            this.Text = "Задолженности по оплате";
            lbNormSum.Visible = true;
            lbNormHours.Visible = false;
            lbExpectedSum.Visible = true;
            lbExpectedHours.Visible = false;
            tbNormSum.Visible = true;
            cmbNormCount.Visible = false;
            tbExpectedSum.Visible = true;
            tbHoursCount.Visible = false;
            dataGridViewDebtors.Columns[3].HeaderText = "Оплаченная сумма";
            dataGridViewDebtors.Columns[4].HeaderText = "Необходимая сумма";
        }

        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            if(dataGridViewDebtors.Rows.Count > 1)
            {
                if(string.IsNullOrEmpty(cmbFileFormat.Text))
                {
                    MessageBox.Show("Выберите формат файла");
                }
                else
                {
                    switch(cmbFileFormat.Text)
                    {
                        case "MS Word":
                            WordFileCreator wordCreator = new WordFileCreator();
                            wordCreator.ExportToWord(dataGridViewDebtors);
                            break;
                        case "MS Excel":
                            ExcelFileCreator excelCreator = new ExcelFileCreator();
                            excelCreator.ExportToExcel(dataGridViewDebtors);
                            break;
                    }
                }
            }
        }
    }
}
