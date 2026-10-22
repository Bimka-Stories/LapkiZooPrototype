using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LapkiZooPrototype
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            // Простая проверка для теста
            if (login == "admin" && password == "123")
            {
                MainForm main = new MainForm(); // Создаем главную форму
                main.Show(); // Показываем её
                this.Hide(); // Прячем форму логина
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Функция восстановления пароля в разработке.");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Форма регистрации будет добавлена позже.");
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
