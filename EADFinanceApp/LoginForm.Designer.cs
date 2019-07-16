namespace EADFinanceApp
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_username = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.label_NoAccount = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button_Login = new System.Windows.Forms.Button();
            this.label_loginErrorMessage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.Location = new System.Drawing.Point(40, 35);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(86, 23);
            this.label_username.TabIndex = 0;
            this.label_username.Text = "Username";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(45, 80);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(81, 23);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // label_NoAccount
            // 
            this.label_NoAccount.AutoSize = true;
            this.label_NoAccount.Location = new System.Drawing.Point(8, 45);
            this.label_NoAccount.Name = "label_NoAccount";
            this.label_NoAccount.Size = new System.Drawing.Size(106, 23);
            this.label_NoAccount.TabIndex = 2;
            this.label_NoAccount.Text = "No Account? ";
            // 
            // button_register
            // 
            this.button_register.Location = new System.Drawing.Point(120, 38);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(103, 36);
            this.button_register.TabIndex = 3;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = true;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(136, 35);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(136, 27);
            this.textBox_username.TabIndex = 4;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(136, 80);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(136, 27);
            this.textBox_password.TabIndex = 6;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // button_Login
            // 
            this.button_Login.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Login.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Login.ForeColor = System.Drawing.Color.Snow;
            this.button_Login.Location = new System.Drawing.Point(136, 119);
            this.button_Login.Name = "button_Login";
            this.button_Login.Size = new System.Drawing.Size(89, 41);
            this.button_Login.TabIndex = 7;
            this.button_Login.Text = "Login";
            this.button_Login.UseVisualStyleBackColor = false;
            this.button_Login.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // label_loginErrorMessage
            // 
            this.label_loginErrorMessage.AutoSize = true;
            this.label_loginErrorMessage.ForeColor = System.Drawing.Color.Firebrick;
            this.label_loginErrorMessage.Location = new System.Drawing.Point(109, 186);
            this.label_loginErrorMessage.Name = "label_loginErrorMessage";
            this.label_loginErrorMessage.Size = new System.Drawing.Size(0, 23);
            this.label_loginErrorMessage.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.textBox_username);
            this.groupBox1.Controls.Add(this.label_loginErrorMessage);
            this.groupBox1.Controls.Add(this.label_username);
            this.groupBox1.Controls.Add(this.button_Login);
            this.groupBox1.Controls.Add(this.label_Password);
            this.groupBox1.Controls.Add(this.textBox_password);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(108, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 236);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Login";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.groupBox2.Controls.Add(this.button_register);
            this.groupBox2.Controls.Add(this.label_NoAccount);
            this.groupBox2.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SaddleBrown;
            this.groupBox2.Location = new System.Drawing.Point(157, 295);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(232, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "User Registration";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(550, 427);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.Label label_NoAccount;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button_Login;
        private System.Windows.Forms.Label label_loginErrorMessage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

