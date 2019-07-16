namespace EADFinanceApp
{
    partial class CurrentReportForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_Income = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label_currentExpense = new System.Windows.Forms.Label();
            this.label_currentNetBalance = new System.Windows.Forms.Label();
            this.label_currentIncome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.label_currentIncome);
            this.groupBox2.Controls.Add(this.label_currentNetBalance);
            this.groupBox2.Controls.Add(this.label_currentExpense);
            this.groupBox2.Controls.Add(this.label_Income);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(777, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 203);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current Finances";
            // 
            // label_Income
            // 
            this.label_Income.AutoSize = true;
            this.label_Income.Location = new System.Drawing.Point(30, 48);
            this.label_Income.Name = "label_Income";
            this.label_Income.Size = new System.Drawing.Size(127, 23);
            this.label_Income.TabIndex = 5;
            this.label_Income.Text = "Current Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Current Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Current Net Balance";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(31, 82);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Income";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Net Balance";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Expense";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(697, 389);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            // 
            // label_currentExpense
            // 
            this.label_currentExpense.AutoSize = true;
            this.label_currentExpense.Location = new System.Drawing.Point(215, 89);
            this.label_currentExpense.Name = "label_currentExpense";
            this.label_currentExpense.Size = new System.Drawing.Size(16, 23);
            this.label_currentExpense.TabIndex = 9;
            this.label_currentExpense.Text = "-";
            // 
            // label_currentNetBalance
            // 
            this.label_currentNetBalance.AutoSize = true;
            this.label_currentNetBalance.Location = new System.Drawing.Point(215, 130);
            this.label_currentNetBalance.Name = "label_currentNetBalance";
            this.label_currentNetBalance.Size = new System.Drawing.Size(16, 23);
            this.label_currentNetBalance.TabIndex = 10;
            this.label_currentNetBalance.Text = "-";
            // 
            // label_currentIncome
            // 
            this.label_currentIncome.AutoSize = true;
            this.label_currentIncome.Location = new System.Drawing.Point(215, 48);
            this.label_currentIncome.Name = "label_currentIncome";
            this.label_currentIncome.Size = new System.Drawing.Size(16, 23);
            this.label_currentIncome.TabIndex = 11;
            this.label_currentIncome.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(411, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 29);
            this.label1.TabIndex = 16;
            this.label1.Text = "Current Finance Report";
            // 
            // CurrentReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1163, 483);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CurrentReportForm";
            this.Text = "CurrentReportForm";
            this.Load += new System.EventHandler(this.CurrentReportForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_Income;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label_currentIncome;
        private System.Windows.Forms.Label label_currentNetBalance;
        private System.Windows.Forms.Label label_currentExpense;
        private System.Windows.Forms.Label label1;
    }
}