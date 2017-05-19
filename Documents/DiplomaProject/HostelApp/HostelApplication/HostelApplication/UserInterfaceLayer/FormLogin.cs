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
    public partial class FormLogin : Form
    {
        bool waterMarkActiveLogin = true;
        bool waterMarkActivePassword = true;

        public FormLogin()
        {
            InitializeComponent();

            this.textBoxLogin.ForeColor = Color.Gray;
            this.textBoxLogin.Text = "Login";
            this.textBoxPassword.ForeColor = Color.Gray;
            this.textBoxPassword.Text = "Password";

            // Perform if cursor focused in login textbox
            FocusLoginInputCursor();

            // Perform if cursor is not focused in login textbox
            LostLoginInputCursor();

            // Perform if cursor focused in password textbox
            FocusPasswordInputCursor();

            // Perform if cursor is not focused in password textbox
            LostPasswordInputCursor();
        }

        #region Private methods

        private void FocusLoginInputCursor()
        {
            this.textBoxLogin.GotFocus += (source, e) =>
            {
                if (waterMarkActiveLogin)
                {
                    waterMarkActiveLogin = false;
                    this.textBoxLogin.Text = "";
                    this.textBoxLogin.ForeColor = Color.Black;
                }
            };
        }

        private void LostLoginInputCursor()
        {
            this.textBoxLogin.LostFocus += (source, e) =>
            {
                if (!waterMarkActiveLogin && string.IsNullOrEmpty(this.textBoxLogin.Text))
                {
                    waterMarkActiveLogin = true;
                    this.textBoxLogin.Text = "Login";
                    this.textBoxLogin.ForeColor = Color.Gray;
                }
            };
        }

        private void FocusPasswordInputCursor()
        {
            this.textBoxPassword.GotFocus += (source, e) =>
            {
                if (waterMarkActivePassword)
                {
                    waterMarkActivePassword = false;
                    this.textBoxPassword.Text = "";
                    textBoxPassword.PasswordChar = '*';
                    this.textBoxPassword.ForeColor = Color.Black;
                }
            };
        }

        private void LostPasswordInputCursor()
        {
            this.textBoxPassword.LostFocus += (source, e) =>
            {
                if (!waterMarkActivePassword && string.IsNullOrEmpty(this.textBoxPassword.Text))
                {
                    waterMarkActivePassword = true;
                    this.textBoxPassword.Text = "Password";
                    this.textBoxPassword.ForeColor = Color.Gray;
                    textBoxPassword.PasswordChar = '\0';
                }
            };
        }
        #endregion

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            string login = this.textBoxLogin.Text;
            string password = this.textBoxPassword.Text;
            if((textBoxLogin.ForeColor==Color.Gray && login.Equals("Login")) ||
                textBoxPassword.ForeColor == Color.Gray && password.Equals("Password"))
            {
                MessageBox.Show("Поля логин и пароль далжны быть заполнены!");
            }
            else
            {
                if (login.Length < 6 || password.Length < 6)
                {
                    MessageBox.Show("Длина логина и пароля должны быть не менее 6 символов!");
                }
                else
                {
                    this.VerifyPasswordAndLogin(login, password);
                }
            }           
        }

        private void VerifyPasswordAndLogin(string login, string password)
        {
            try
            {
                HomePage homePage = new HomePage();
                if (homePage.IsUserExists(login))
                {
                    if (homePage.IsPasswordCorrect(password))
                    {
                        
                        this.Hide();
                        MainForm mainForm = new MainForm(homePage.GetUserType(), login);
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверный пароль пользователя!");
                    }
                }
                else
                {
                    MessageBox.Show("Пользователя с таким логином не существует!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBoxLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if((symbol<'A' || symbol > 'Z') && (symbol < 'a' || symbol > 'z') && (symbol < '0' || symbol > '9') &&
                symbol != '\b' && symbol != '-' && symbol != '_' && symbol!='.')
            {
                e.Handled = true;
            }
        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            char symbol = e.KeyChar;
            if((symbol >= 'а' && symbol <= 'я') || (symbol >= 'А' && symbol <= 'Я'))
            {
                e.Handled = true;
            }
        }
    }
}
