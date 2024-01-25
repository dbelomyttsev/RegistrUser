using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrUser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RegistrValidation registrValidation = new RegistrValidation();
        UserRepository UserRepository = new UserRepository();
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (UserRepository.UserIsNotNull(textBox1.Text))
            {
                MessageBox.Show("Пользователь с таким логином уже зарегистрирован!");
            }
            else
            {
                bool isValid = registrValidation.ValidatePassword(textBox2.Text);
                if (isValid)
                {
                    UserRepository.SaveUser(new User { Login = textBox1.Text, Password = textBox2.Text });
                    MessageBox.Show("Вы успешно зарегистрированы!");
                }
                else
                {
                    MessageBox.Show(registrValidation.ErrorMessage);
                }
            }
            
        }
    }
}
