using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EADFinanceApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.ShowDialog();

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            ValidateAndSubmitLogin();
            
        }

        void ValidateAndSubmitLogin()
        {
            var dbModel = new UserModelContainer();

            {
                foreach (var user in dbModel.Users)
                {
                    if (textBox_password.Text != "" && textBox_username.Text != "" &&
                        user.Username == textBox_username.Text && user.Password == textBox_password.Text)
                    {
                        
                        label_loginErrorMessage.Text = "";

                        MainPage mainPage = new MainPage();
                        mainPage.Activate();
                        mainPage.ShowDialog();

                        this.Dispose();
                        this.Close();
                    }
                    else
                    {
                        label_loginErrorMessage.Text = "Invalid credentials!";
                    }
                }
            }
            
        }
    }
}
