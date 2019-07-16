using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity.Validation;


namespace EADFinanceApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button_register_Click(object sender, EventArgs e)
        {
            ValidateAndSubmitUserData();
        }
        void ValidateAndSubmitUserData()
        {
            User user = new User();

            user.FName = this.textBox_FName.Text;
            user.LName = this.textBox_LName.Text;
            user.Username = this.textBox_username.Text;

            if (textBox_createPassword.Text == textBox_confirmPassword.Text
                && (textBox_createPassword.Text != "" || textBox_confirmPassword.Text != "" || textBox_FName.Text != "" || textBox_LName.Text != "" || textBox_username.Text != ""))
            {

                user.Password = this.textBox_confirmPassword.Text;
                //Using an instance the database model which is stored in UserModel.Context.cs
                using (var dbModel = new UserModelContainer())
                {
                    dbModel.Users.Add(user);
                    try
                    { //Remove exception handling if issue does not persist
                        dbModel.SaveChanges();
                    }
                    catch (DbEntityValidationException ee)
                    {
                        Console.Write(ee);

                    }
                }

                this.Dispose();
                this.Close();
            }
            else if (textBox_createPassword.Text != textBox_confirmPassword.Text)
            {
                label_message.Text = "Passwords do not match. Please try again";
            }
            else if (textBox_FName.Text == "" || textBox_LName.Text == "" || textBox_username.Text == ""
                || textBox_createPassword.Text == "" || textBox_confirmPassword.Text == "")
            {
                label_message.Text = "Please fill out empty fields";
            }
        }
    }
}
