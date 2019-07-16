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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button_addIncome_Click(object sender, EventArgs e)
        {
            AddIncomeForm addIncome = new AddIncomeForm();
            addIncome.ShowDialog();
        }

        private void button_addExpense_Click(object sender, EventArgs e)
        {
            AddExpenseForm addExpense = new AddExpenseForm();
            addExpense.ShowDialog();
        }

        private void button_currentReport_Click(object sender, EventArgs e)
        {
            CurrentReportForm currentReport = new CurrentReportForm();
            currentReport.ShowDialog();
        }

        private void button_predictedReport_Click(object sender, EventArgs e)
        {
            PredictedReportForm predictedReport = new PredictedReportForm();
            predictedReport.ShowDialog();
        }
    }
}
