using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace EADFinanceApp
{
    public partial class PredictedReportForm : Form
    {
        public PredictedReportForm()
        {
            InitializeComponent();
        }

        private void button_generateReport_Click(object sender, EventArgs e)
        {
            GeneratePredictions();
        }

        void GeneratePredictions()
        {
            //Retrive no of days since first income transaction
            //Create the XmlDocument.
            XmlDocument incomeDoc = new XmlDocument();
            incomeDoc.Load(@"C:\Users\DELL\source\repos\EADFinanceApp\EADFinanceApp\Incomes.xml");

            //Retrive all the data inside Date tags.
            XmlNodeList incomeDateElemList = incomeDoc.GetElementsByTagName("date");
            List<string> incomeDateStrings = new List<string>();
            List<DateTime> dates = new List<DateTime>();
            

            foreach (XmlNode dateElem in incomeDateElemList)
            {
                incomeDateStrings.Add(dateElem.InnerText);

            }
            foreach (string dateStr in incomeDateStrings)
            {
                dates.Add(DateTime.Parse(dateStr));
            }

            //retrive no of days since first expense transaction
            XmlDocument expenseDoc = new XmlDocument();
            expenseDoc.Load(@"C:\Users\DELL\source\repos\EADFinanceApp\EADFinanceApp\Expenses.xml");
            //Retrive all the data inside Date tags.
            XmlNodeList expElemList = expenseDoc.GetElementsByTagName("date");
            List<string> ExpenseDateStrings = new List<string>();

            foreach (XmlNode dateElem in expElemList)
            {
                ExpenseDateStrings.Add(dateElem.InnerText);

            }
            foreach (string dateStr in ExpenseDateStrings)
            {
                dates.Add(DateTime.Parse(dateStr));
            }

            //get minimum date and current date
            DateTime minDate = dates.Min();
            DateTime currentDate = dateTimePicker1.Value.Date;

            //get time span between minimum and current date
            TimeSpan daysSinceFirstEntry = currentDate - minDate;
            float numOfDaysSinceFirstEntry = daysSinceFirstEntry.Days;


            //Retrieve total incomes
            XmlNodeList incomeElemList = incomeDoc.GetElementsByTagName("incomeAmount");
            List<float> incomeFloatList = new List<float>();
            //Add incomes from xml nodes to list
            foreach (XmlNode incomeElem in incomeElemList)
            {
                incomeFloatList.Add(float.Parse(incomeElem.InnerText));
            }
            float totalIncomes = incomeFloatList.Sum();

            //Retrieve total Expenses
            XmlNodeList expenseElemList = expenseDoc.GetElementsByTagName("expenseAmount");
            List<float> expenseFloatList = new List<float>();
            //Add expenses from xml to list
            foreach (XmlNode expenseElem in expenseElemList)
            {
                expenseFloatList.Add(float.Parse(expenseElem.InnerText));
            }
            float totalExpenses = expenseFloatList.Sum();

            //Calculating average net balance
            float AverageNetBalance = (totalIncomes - totalExpenses) / numOfDaysSinceFirstEntry;
            //average income
            float AverageIncome = totalIncomes / numOfDaysSinceFirstEntry;
            //average Expense
            float AverageExpense = totalExpenses / numOfDaysSinceFirstEntry;

            //Get no of days from current date to selected future date
            //Future date
            DateTime futureDate = dateTimePicker2.Value.Date;
            //difference between present and future date
            TimeSpan presentTillFutureSpan = futureDate - currentDate;
            float numOfDaysTillFutureDate = presentTillFutureSpan.Days;

            //Calculating predicted Net balance
            float predictedNetBalance = AverageNetBalance * numOfDaysTillFutureDate;
            //predicted incomes
            float predictedIncome = AverageIncome * numOfDaysTillFutureDate;
            //predicted expense
            float predictedExpense = AverageExpense * numOfDaysTillFutureDate;

            //generate finances on labels
            label_NetBalancePrediction.Text = predictedNetBalance.ToString();
            label_IncomePrediction.Text = predictedIncome.ToString();
            label_expensePrediction.Text = predictedExpense.ToString();

            for (int i =0; i<=(int)numOfDaysTillFutureDate; i++)
            {
                this.chart1.Series["Income"].Points.AddXY((double)i, (double)AverageIncome *i);
                this.chart1.Series["Expense"].Points.AddXY((double)i, (double)AverageExpense * i);
                this.chart1.Series["Net Balance"].Points.AddXY((double)i, (double)AverageNetBalance * i);
            }
            
        }
    }
}
