namespace EADFinanceApp
{
    partial class RegistrationForm
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
            this.textBox_FName = new System.Windows.Forms.TextBox();
            this.textBox_LName = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_createPassword = new System.Windows.Forms.TextBox();
            this.textBox_confirmPassword = new System.Windows.Forms.TextBox();
            this.label_FName = new System.Windows.Forms.Label();
            this.label_LName = new System.Windows.Forms.Label();
            this.label_Username = new System.Windows.Forms.Label();
            this.label_createPassword = new System.Windows.Forms.Label();
            this.label_reEnterPassword = new System.Windows.Forms.Label();
            this.button_register = new System.Windows.Forms.Button();
            this.label_message = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_FName
            // 
            this.textBox_FName.Location = new System.Drawing.Point(203, 45);
            this.textBox_FName.Name = "textBox_FName";
            this.textBox_FName.Size = new System.Drawing.Size(100, 27);
            this.textBox_FName.TabIndex = 5;
            // 
            // textBox_LName
            // 
            this.textBox_LName.Location = new System.Drawing.Point(203, 89);
            this.textBox_LName.Name = "textBox_LName";
            this.textBox_LName.Size = new System.Drawing.Size(100, 27);
            this.textBox_LName.TabIndex = 6;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(203, 135);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 27);
            this.textBox_username.TabIndex = 7;
            // 
            // textBox_createPassword
            // 
            this.textBox_createPassword.Location = new System.Drawing.Point(203, 183);
            this.textBox_createPassword.Name = "textBox_createPassword";
            this.textBox_createPassword.Size = new System.Drawing.Size(100, 27);
            this.textBox_createPassword.TabIndex = 8;
            this.textBox_createPassword.UseSystemPasswordChar = true;
            // 
            // textBox_confirmPassword
            // 
            this.textBox_confirmPassword.Location = new System.Drawing.Point(203, 229);
            this.textBox_confirmPassword.Name = "textBox_confirmPassword";
            this.textBox_confirmPassword.Size = new System.Drawing.Size(100, 27);
            this.textBox_confirmPassword.TabIndex = 9;
            this.textBox_confirmPassword.UseSystemPasswordChar = true;
            // 
            // label_FName
            // 
            this.label_FName.AutoSize = true;
            this.label_FName.Location = new System.Drawing.Point(88, 45);
            this.label_FName.Name = "label_FName";
            this.label_FName.Size = new System.Drawing.Size(94, 23);
            this.label_FName.TabIndex = 10;
            this.label_FName.Text = "First Name";
            // 
            // label_LName
            // 
            this.label_LName.AutoSize = true;
            this.label_LName.Location = new System.Drawing.Point(88, 93);
            this.label_LName.Name = "label_LName";
            this.label_LName.Size = new System.Drawing.Size(91, 23);
            this.label_LName.TabIndex = 11;
            this.label_LName.Text = "Last Name";
            // 
            // label_Username
            // 
            this.label_Username.AutoSize = true;
            this.label_Username.Location = new System.Drawing.Point(37, 138);
            this.label_Username.Name = "label_Username";
            this.label_Username.Size = new System.Drawing.Size(142, 23);
            this.label_Username.TabIndex = 12;
            this.label_Username.Text = "Create Username";
            // 
            // label_createPassword
            // 
            this.label_createPassword.AutoSize = true;
            this.label_createPassword.Location = new System.Drawing.Point(42, 187);
            this.label_createPassword.Name = "label_createPassword";
            this.label_createPassword.Size = new System.Drawing.Size(137, 23);
            this.label_createPassword.TabIndex = 13;
            this.label_createPassword.Text = "Create Password";
            // 
            // label_reEnterPassword
            // 
            this.label_reEnterPassword.AutoSize = true;
            this.label_reEnterPassword.Location = new System.Drawing.Point(33, 233);
            this.label_reEnterPassword.Name = "label_reEnterPassword";
            this.label_reEnterPassword.Size = new System.Drawing.Size(146, 23);
            this.label_reEnterPassword.TabIndex = 14;
            this.label_reEnterPassword.Text = "Confirm Password";
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.DarkCyan;
            this.button_register.ForeColor = System.Drawing.Color.Snow;
            this.button_register.Location = new System.Drawing.Point(203, 274);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(100, 34);
            this.button_register.TabIndex = 15;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button_register_Click);
            // 
            // label_message
            // 
            this.label_message.AutoSize = true;
            this.label_message.ForeColor = System.Drawing.Color.Firebrick;
            this.label_message.Location = new System.Drawing.Point(107, 331);
            this.label_message.Name = "label_message";
            this.label_message.Size = new System.Drawing.Size(0, 23);
            this.label_message.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.label_FName);
            this.groupBox1.Controls.Add(this.label_message);
            this.groupBox1.Controls.Add(this.textBox_FName);
            this.groupBox1.Controls.Add(this.button_register);
            this.groupBox1.Controls.Add(this.textBox_LName);
            this.groupBox1.Controls.Add(this.label_reEnterPassword);
            this.groupBox1.Controls.Add(this.textBox_username);
            this.groupBox1.Controls.Add(this.label_createPassword);
            this.groupBox1.Controls.Add(this.textBox_createPassword);
            this.groupBox1.Controls.Add(this.label_Username);
            this.groupBox1.Controls.Add(this.textBox_confirmPassword);
            this.groupBox1.Controls.Add(this.label_LName);
            this.groupBox1.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(81, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 386);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create Account";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_FName;
        private System.Windows.Forms.TextBox textBox_LName;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_createPassword;
        private System.Windows.Forms.TextBox textBox_confirmPassword;
        private System.Windows.Forms.Label label_FName;
        private System.Windows.Forms.Label label_LName;
        private System.Windows.Forms.Label label_Username;
        private System.Windows.Forms.Label label_createPassword;
        private System.Windows.Forms.Label label_reEnterPassword;
        private System.Windows.Forms.Button button_register;
        private System.Windows.Forms.Label label_message;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}