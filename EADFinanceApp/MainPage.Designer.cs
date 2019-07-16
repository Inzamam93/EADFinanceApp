namespace EADFinanceApp
{
    partial class MainPage
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
            this.button_addExpense = new System.Windows.Forms.Button();
            this.button_predictedReport = new System.Windows.Forms.Button();
            this.button_addIncome = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_currentReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_addExpense
            // 
            this.button_addExpense.BackColor = System.Drawing.Color.IndianRed;
            this.button_addExpense.ForeColor = System.Drawing.Color.White;
            this.button_addExpense.Location = new System.Drawing.Point(76, 224);
            this.button_addExpense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_addExpense.Name = "button_addExpense";
            this.button_addExpense.Size = new System.Drawing.Size(197, 62);
            this.button_addExpense.TabIndex = 6;
            this.button_addExpense.Text = "Add Expense";
            this.button_addExpense.UseVisualStyleBackColor = false;
            this.button_addExpense.Click += new System.EventHandler(this.button_addExpense_Click);
            // 
            // button_predictedReport
            // 
            this.button_predictedReport.BackColor = System.Drawing.Color.Cyan;
            this.button_predictedReport.Location = new System.Drawing.Point(59, 78);
            this.button_predictedReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_predictedReport.Name = "button_predictedReport";
            this.button_predictedReport.Size = new System.Drawing.Size(243, 62);
            this.button_predictedReport.TabIndex = 5;
            this.button_predictedReport.Text = "View Predicted Report";
            this.button_predictedReport.UseVisualStyleBackColor = false;
            this.button_predictedReport.Click += new System.EventHandler(this.button_predictedReport_Click);
            // 
            // button_addIncome
            // 
            this.button_addIncome.BackColor = System.Drawing.Color.Aquamarine;
            this.button_addIncome.Location = new System.Drawing.Point(76, 78);
            this.button_addIncome.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_addIncome.Name = "button_addIncome";
            this.button_addIncome.Size = new System.Drawing.Size(197, 62);
            this.button_addIncome.TabIndex = 4;
            this.button_addIncome.Text = "Add Income";
            this.button_addIncome.UseVisualStyleBackColor = false;
            this.button_addIncome.Click += new System.EventHandler(this.button_addIncome_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.button_addIncome);
            this.groupBox1.Controls.Add(this.button_addExpense);
            this.groupBox1.Location = new System.Drawing.Point(63, 99);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(358, 359);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Transactions";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.button_currentReport);
            this.groupBox2.Controls.Add(this.button_predictedReport);
            this.groupBox2.Location = new System.Drawing.Point(466, 99);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(358, 359);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finance Reports";
            // 
            // button_currentReport
            // 
            this.button_currentReport.BackColor = System.Drawing.Color.Plum;
            this.button_currentReport.Location = new System.Drawing.Point(59, 224);
            this.button_currentReport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_currentReport.Name = "button_currentReport";
            this.button_currentReport.Size = new System.Drawing.Size(243, 62);
            this.button_currentReport.TabIndex = 6;
            this.button_currentReport.Text = "View Current Report";
            this.button_currentReport.UseVisualStyleBackColor = false;
            this.button_currentReport.Click += new System.EventHandler(this.button_currentReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(338, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Finance Application";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(891, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_addExpense;
        private System.Windows.Forms.Button button_predictedReport;
        private System.Windows.Forms.Button button_addIncome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_currentReport;
        private System.Windows.Forms.Label label1;
    }
}