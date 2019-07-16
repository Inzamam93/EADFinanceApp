namespace EADFinanceApp
{
    partial class AddExpenseForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_entryDate = new System.Windows.Forms.Label();
            this.label_EntryNumber = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox_ChosenEntries = new System.Windows.Forms.TextBox();
            this.button_generateEntries = new System.Windows.Forms.Button();
            this.button_AddExpense = new System.Windows.Forms.Button();
            this.label_Payername = new System.Windows.Forms.Label();
            this.label_IncomeAmount = new System.Windows.Forms.Label();
            this.backgroundWorker_addExpense = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(214, 17);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox2.Size = new System.Drawing.Size(29, 648);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "||||||||||||||||||||||||||||||||";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.label_entryDate);
            this.groupBox1.Controls.Add(this.label_EntryNumber);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox_ChosenEntries);
            this.groupBox1.Controls.Add(this.button_generateEntries);
            this.groupBox1.Location = new System.Drawing.Point(514, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(489, 206);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label_entryDate
            // 
            this.label_entryDate.AutoSize = true;
            this.label_entryDate.Location = new System.Drawing.Point(24, 36);
            this.label_entryDate.Name = "label_entryDate";
            this.label_entryDate.Size = new System.Drawing.Size(90, 23);
            this.label_entryDate.TabIndex = 14;
            this.label_entryDate.Text = "Entry Date";
            // 
            // label_EntryNumber
            // 
            this.label_EntryNumber.AutoSize = true;
            this.label_EntryNumber.Location = new System.Drawing.Point(25, 118);
            this.label_EntryNumber.Name = "label_EntryNumber";
            this.label_EntryNumber.Size = new System.Drawing.Size(115, 23);
            this.label_EntryNumber.TabIndex = 18;
            this.label_EntryNumber.Text = "No. of Entries";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(132, 30);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 27);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // textBox_ChosenEntries
            // 
            this.textBox_ChosenEntries.Location = new System.Drawing.Point(177, 118);
            this.textBox_ChosenEntries.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.textBox_ChosenEntries.Name = "textBox_ChosenEntries";
            this.textBox_ChosenEntries.Size = new System.Drawing.Size(40, 27);
            this.textBox_ChosenEntries.TabIndex = 17;
            // 
            // button_generateEntries
            // 
            this.button_generateEntries.BackColor = System.Drawing.Color.Aqua;
            this.button_generateEntries.ForeColor = System.Drawing.Color.Black;
            this.button_generateEntries.Location = new System.Drawing.Point(262, 105);
            this.button_generateEntries.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button_generateEntries.Name = "button_generateEntries";
            this.button_generateEntries.Size = new System.Drawing.Size(170, 68);
            this.button_generateEntries.TabIndex = 16;
            this.button_generateEntries.Text = "Generate Entries";
            this.button_generateEntries.UseVisualStyleBackColor = false;
            this.button_generateEntries.Click += new System.EventHandler(this.button_generateEntries_Click);
            // 
            // button_AddExpense
            // 
            this.button_AddExpense.BackColor = System.Drawing.Color.Aqua;
            this.button_AddExpense.ForeColor = System.Drawing.Color.Black;
            this.button_AddExpense.Location = new System.Drawing.Point(776, 382);
            this.button_AddExpense.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.button_AddExpense.Name = "button_AddExpense";
            this.button_AddExpense.Size = new System.Drawing.Size(187, 68);
            this.button_AddExpense.TabIndex = 23;
            this.button_AddExpense.Text = "Submit Expense";
            this.button_AddExpense.UseVisualStyleBackColor = false;
            this.button_AddExpense.Click += new System.EventHandler(this.button_AddExpense_Click);
            // 
            // label_Payername
            // 
            this.label_Payername.AutoSize = true;
            this.label_Payername.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Payername.Location = new System.Drawing.Point(249, 9);
            this.label_Payername.Name = "label_Payername";
            this.label_Payername.Size = new System.Drawing.Size(104, 23);
            this.label_Payername.TabIndex = 22;
            this.label_Payername.Text = "Payer Name";
            // 
            // label_IncomeAmount
            // 
            this.label_IncomeAmount.AutoSize = true;
            this.label_IncomeAmount.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_IncomeAmount.Location = new System.Drawing.Point(83, 9);
            this.label_IncomeAmount.Name = "label_IncomeAmount";
            this.label_IncomeAmount.Size = new System.Drawing.Size(136, 23);
            this.label_IncomeAmount.TabIndex = 21;
            this.label_IncomeAmount.Text = "Income Amount";
            // 
            // backgroundWorker_addExpense
            // 
            this.backgroundWorker_addExpense.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_addExpense_DoWork);
            this.backgroundWorker_addExpense.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_addExpense_RunWorkerCompleted);
            // 
            // AddExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1031, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_AddExpense);
            this.Controls.Add(this.label_Payername);
            this.Controls.Add(this.label_IncomeAmount);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddExpenseForm";
            this.Text = "AddExpenseForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_entryDate;
        private System.Windows.Forms.Label label_EntryNumber;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox_ChosenEntries;
        private System.Windows.Forms.Button button_generateEntries;
        private System.Windows.Forms.Button button_AddExpense;
        private System.Windows.Forms.Label label_Payername;
        private System.Windows.Forms.Label label_IncomeAmount;
        private System.ComponentModel.BackgroundWorker backgroundWorker_addExpense;
    }
}