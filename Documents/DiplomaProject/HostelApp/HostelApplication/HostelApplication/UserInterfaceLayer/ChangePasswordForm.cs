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
    public partial class ChangePasswordForm : Form
    {
        string UserLogin = "";
        public ChangePasswordForm(string login)
        {
            this.UserLogin = login;
            InitializeComponent();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            string oldPassword = tbOldPassword.Text;
            string newPassword = tbNewPassword.Text;
            string confirmedPassword = tbConformPassword.Text;
            if(string.IsNullOrEmpty(oldPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(confirmedPassword))
            {
                MessageBox.Show("Все поля должны быть заполнены!");
            }
            else
            {
                if(oldPassword.Length <=5 || newPassword.Length <= 5 || confirmedPassword.Length <= 5)
                {
                    MessageBox.Show("Длина пароля должна быть от 6 до 16 символов.");
                }
                else
                {
                    Dictionary<string, string> passwords = this.FormPasswordsDictionary(oldPassword, newPassword, confirmedPassword);
                    ChangePasswordPage changePage = new ChangePasswordPage();
                    string resultMessage = changePage.ChangePassword(UserLogin, passwords);
                    MessageBox.Show(resultMessage);
                }
            }
        }

        private void tbOldPassword_KeyPress(object sender, KeyPressEventArgs e) => this.VerifyEnteredPassword(e);

        private void tbNewPassword_KeyPress(object sender, KeyPressEventArgs e) => this.VerifyEnteredPassword(e);

        private void tbConformPassword_KeyPress(object sender, KeyPressEventArgs e) => this.VerifyEnteredPassword(e);

        private KeyPressEventArgs VerifyEnteredPassword(KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if ((symbol >= 'а' && symbol <= 'я') || (symbol >= 'А' && symbol <= 'Я'))
            {
                e.Handled = true;
            }
            return e;
        }

        private Dictionary<string, string> FormPasswordsDictionary(string oldPassword, string newPassword, string confirmedPassword)
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary["old"] = oldPassword;
            dictionary["new"] = newPassword;
            dictionary["confirmed"] = confirmedPassword;
            return dictionary;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
