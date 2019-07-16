namespace EADFinanceApp
{
    partial class PredictedReportForm
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label_CurrentDate = new System.Windows.Forms.Label();
            this.label_futuredate = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_IncomePrediction = new System.Windows.Forms.Label();
            this.label_expensePrediction = new System.Windows.Forms.Label();
            this.label_NetBalancePrediction = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_generateReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(34, 49);
            this.dateTimePicker1.MaxDate = new System.DateTime(2019, 7, 15, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2019, 7, 15, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(300, 27);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2019, 7, 15, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(483, 49);
            this.dateTimePicker2.MinDate = new System.DateTime(2019, 7, 15, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(300, 27);
            this.dateTimePicker2.TabIndex = 1;
            // 
            // label_CurrentDate
            // 
            this.label_CurrentDate.AutoSize = true;
            this.label_CurrentDate.Location = new System.Drawing.Point(30, 23);
            this.label_CurrentDate.Name = "label_CurrentDate";
            this.label_CurrentDate.Size = new System.Drawing.Size(107, 23);
            this.label_CurrentDate.TabIndex = 2;
            this.label_CurrentDate.Text = "Present Date";
            // 
            // label_futuredate
            // 
            this.label_futuredate.AutoSize = true;
            this.label_futuredate.Location = new System.Drawing.Point(479, 23);
            this.label_futuredate.Name = "label_futuredate";
            this.label_futuredate.Size = new System.Drawing.Size(151, 23);
            this.label_futuredate.TabIndex = 3;
            this.label_futuredate.Text = "Select Future Date";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(23, 270);
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
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Predicted Income";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Predicted Expense";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Predicted Net Balance";
            // 
            // label_IncomePrediction
            // 
            this.label_IncomePrediction.AutoSize = true;
            this.label_IncomePrediction.Location = new System.Drawing.Point(235, 48);
            this.label_IncomePrediction.Name = "label_IncomePrediction";
            this.label_IncomePrediction.Size = new System.Drawing.Size(16, 23);
            this.label_IncomePrediction.TabIndex = 8;
            this.label_IncomePrediction.Text = "-";
            // 
            // label_expensePrediction
            // 
            this.label_expensePrediction.AutoSize = true;
            this.label_expensePrediction.Location = new System.Drawing.Point(235, 89);
            this.label_expensePrediction.Name = "label_expensePrediction";
            this.label_expensePrediction.Size = new System.Drawing.Size(16, 23);
            this.label_expensePrediction.TabIndex = 9;
            this.label_expensePrediction.Text = "-";
            // 
            // label_NetBalancePrediction
            // 
            this.label_NetBalancePrediction.AutoSize = true;
            this.label_NetBalancePrediction.Location = new System.Drawing.Point(235, 130);
            this.label_NetBalancePrediction.Name = "label_NetBalancePrediction";
            this.label_NetBalancePrediction.Size = new System.Drawing.Size(16, 23);
            this.label_NetBalancePrediction.TabIndex = 10;
            this.label_NetBalancePrediction.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Azure;
            this.groupBox1.Controls.Add(this.button_generateReport);
            this.groupBox1.Controls.Add(this.label_CurrentDate);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.label_futuredate);
            this.groupBox1.Location = new System.Drawing.Point(151, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(844, 158);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // button_generateReport
            // 
            this.button_generateReport.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button_generateReport.Location = new System.Drawing.Point(602, 104);
            this.button_generateReport.Name = "button_generateReport";
            this.button_generateReport.Size = new System.Drawing.Size(181, 36);
            this.button_generateReport.TabIndex = 4;
            this.button_generateReport.Text = "Generate Report";
            this.button_generateReport.UseVisualStyleBackColor = false;
            this.button_generateReport.Click += new System.EventHandler(this.button_generateReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Azure;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label_NetBalancePrediction);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label_expensePrediction);
            this.groupBox2.Controls.Add(this.label_IncomePrediction);
            this.groupBox2.Location = new System.Drawing.Point(757, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 203);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Generated Results";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label4.Location = new System.Drawing.Point(441, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(301, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Predicted Finance Report";
            // 
            // PredictedReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(1143, 671);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PredictedReportForm";
            this.Text = "PredictedReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label_CurrentDate;
        private System.Windows.Forms.Label label_futuredate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_IncomePrediction;
        private System.Windows.Forms.Label label_expensePrediction;
        private System.Windows.Forms.Label label_NetBalancePrediction;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_generateReport;
        private System.Windows.Forms.Label label4;
    }
}