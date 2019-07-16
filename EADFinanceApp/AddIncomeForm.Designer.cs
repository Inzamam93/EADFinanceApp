namespace EADFinanceApp
{
    partial class AddIncomeForm
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
            this.label_IncomeAmount = new System.Windows.Forms.Label();
            this.label_Payername = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_entryDate = new System.Windows.Forms.Label();
            this.button_AddIncome = new System.Windows.Forms.Button();
            this.button_generateEntries = new System.Windows.Forms.Button();
            this.textBox_ChosenEntries = new System.Windows.Forms.TextBox();
            this.label_EntryNumber = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker_addIncome = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_IncomeAmount
            // 
            this.label_IncomeAmount.AutoSize = true;
            this.label_IncomeAmount.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IncomeAmount.Location = new System.Drawing.Point(80, 9);
            this.label_IncomeAmount.Name = "label_IncomeAmount";
            this.label_IncomeAmount.Size = new System.Drawing.Size(136, 23);
            this.label_IncomeAmount.TabIndex = 9;
            this.label_IncomeAmount.Text = "Income Amount";
            this.label_IncomeAmount.Click += new System.EventHandler(this.label_IncomeAmount_Click);
            // 
            // label_Payername
            // 
            this.label_Payername.AutoSize = true;
            this.label_Payername.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Payername.Location = new System.Drawing.Point(236, 9);
            this.label_Payername.Name = "label_Payername";
            this.label_Payername.Size = new System.Drawing.Size(104, 23);
            this.label_Payername.TabIndex = 10;
            this.label_Payername.Text = "Payer Name";
            this.label_Payername.Click += new System.EventHandler(this.label_Payername_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(118, 34);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(297, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // label_entryDate
            // 
            this.label_entryDate.AutoSize = true;
            this.label_entryDate.Location = new System.Drawing.Point(22, 38);
            this.label_entryDate.Name = "label_entryDate";
            this.label_entryDate.Size = new System.Drawing.Size(90, 23);
            this.label_entryDate.TabIndex = 14;
            this.label_entryDate.Text = "Entry Date";
            // 
            // button_AddIncome
            // 
            this.button_AddIncome.BackColor = System.Drawing.Color.Aqua;
            this.button_AddIncome.ForeColor = System.Drawing.Color.Black;
            this.button_AddIncome.Location = new System.Drawing.Point(703, 299);
            this.button_AddIncome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_AddIncome.Name = "button_AddIncome";
            this.button_AddIncome.Size = new System.Drawing.Size(166, 47);
            this.button_AddIncome.TabIndex = 15;
            this.button_AddIncome.Text = "Submit Income";
            this.button_AddIncome.UseVisualStyleBackColor = false;
            this.button_AddIncome.Click += new System.EventHandler(this.button_AddIncome_Click);
            // 
            // button_generateEntries
            // 
            this.button_generateEntries.BackColor = System.Drawing.Color.Aqua;
            this.button_generateEntries.ForeColor = System.Drawing.Color.Black;
            this.button_generateEntries.Location = new System.Drawing.Point(233, 97);
            this.button_generateEntries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_generateEntries.Name = "button_generateEntries";
            this.button_generateEntries.Size = new System.Drawing.Size(151, 47);
            this.button_generateEntries.TabIndex = 16;
            this.button_generateEntries.Text = "Generate Entries";
            this.button_generateEntries.UseVisualStyleBackColor = false;
            this.button_generateEntries.Click += new System.EventHandler(this.button_generateEntries_Click);
            // 
            // textBox_ChosenEntries
            // 
            this.textBox_ChosenEntries.Location = new System.Drawing.Point(157, 106);
            this.textBox_ChosenEntries.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_ChosenEntries.Name = "textBox_ChosenEntries";
            this.textBox_ChosenEntries.Size = new System.Drawing.Size(36, 27);
            this.textBox_ChosenEntries.TabIndex = 17;
            // 
            // label_EntryNumber
            // 
            this.label_EntryNumber.AutoSize = true;
            this.label_EntryNumber.Location = new System.Drawing.Point(22, 106);
            this.label_EntryNumber.Name = "label_EntryNumber";
            this.label_EntryNumber.Size = new System.Drawing.Size(115, 23);
            this.label_EntryNumber.TabIndex = 18;
            this.label_EntryNumber.Text = "No. of Entries";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.label_entryDate);
            this.groupBox1.Controls.Add(this.label_EntryNumber);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox_ChosenEntries);
            this.groupBox1.Controls.Add(this.button_generateEntries);
            this.groupBox1.Location = new System.Drawing.Point(470, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 170);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // backgroundWorker_addIncome
            // 
            this.backgroundWorker_addIncome.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_addIncome_DoWork);
            this.backgroundWorker_addIncome.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_addIncome_RunWorkerCompleted);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(213, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(26, 451);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "||||||||||||||||||||||||||||||||";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // AddIncomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(919, 409);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_AddIncome);
            this.Controls.Add(this.label_Payername);
            this.Controls.Add(this.label_IncomeAmount);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddIncomeForm";
            this.Text = "Add Income";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_IncomeAmount;
        private System.Windows.Forms.Label label_Payername;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_entryDate;
        private System.Windows.Forms.Button button_AddIncome;
        private System.Windows.Forms.Button button_generateEntries;
        private System.Windows.Forms.TextBox textBox_ChosenEntries;
        private System.Windows.Forms.Label label_EntryNumber;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker_addIncome;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}