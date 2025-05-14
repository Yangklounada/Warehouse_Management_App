using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp3
{
    public partial class WelcomeWindow : Form
    {
        public WelcomeWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationWindow reg = new RegistrationWindow();
            reg.Show();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            string username = LogWelcome.Text.Trim();
            string password = PasswordWelcome.Text.Trim();

            string path = "users.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show("Нет зарегистрированных пользователей.");
                return;
            }

            var lines = File.ReadAllLines(path);
            foreach (var line in lines)
            {
                var parts = line.Split('|');
                if (parts.Length == 3 && parts[1] == username && parts[2] == password)
                {
                    MessageBox.Show("Вход выполнен успешно!");
                    this.Close();
                    App AppForm = new App();
                    AppForm.Show();
                    return;
                }
            }
            MessageBox.Show("Неверный логин или пароль.");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PasswordWelcome.UseSystemPasswordChar = !PasswordWelcome.UseSystemPasswordChar;
            button4.Text = PasswordWelcome.UseSystemPasswordChar ? "Показать" : "Скрыть";
        }

        private void WelcomeWindow_Load(object sender, EventArgs e)
        {

        }
    }
    }

