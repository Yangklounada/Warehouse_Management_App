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
    
    public partial class RegistrationWindow : Form
    {
        string password = "";
        string login = "";

        public RegistrationWindow()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            string username = Username.Text.Trim();
            string password = PasswordReg.Text.Trim();

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, заполните все поля.");
                return;
            }

            string path = "users.txt";

            if (File.Exists(path))
            {
                var lines = File.ReadAllLines(path);
                foreach (var line in lines)
                {
                    var parts = line.Split('|');
                    if (parts.Length == 3 && parts[1] == username)
                    {
                        MessageBox.Show("Пользователь с таким логином уже существует.");
                        return;
                    }
                }
            }

            string userData = $"{email}|{username}|{password}";
            File.AppendAllText(path, userData + Environment.NewLine);
            MessageBox.Show("Регистрация успешна!");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {  

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Pokazat_Click(object sender, EventArgs e)
        {
            PasswordReg.UseSystemPasswordChar = !PasswordReg.UseSystemPasswordChar;
            Pokazat.Text = PasswordReg.UseSystemPasswordChar ? "Показать" : "Скрыть";
        }
    }
    }

