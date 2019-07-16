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
    public partial class CurrentReportForm : Form
    {
        public CurrentReportForm()
        {
            InitializeComponent();
        }

        private void CurrentReportForm_Load(object sender, EventArgs e)
        {
            GenerateReport();
        }

        void GenerateReport()
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
            DateTime latestDate = dates.Max();

            //get time span between minimum and current date
            TimeSpan daysSinceFirstEntry = latestDate - minDate;
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

            float NetBalance = totalIncomes - totalExpenses;

            //generate finances on labels
            label_currentNetBalance.Text = NetBalance.ToString();
            label_currentIncome.Text = totalIncomes.ToString();
            label_currentExpense.Text = totalExpenses.ToString();

            for (int i = 0; i <= (int)numOfDaysSinceFirstEntry; i++)
            {
                this.chart1.Series["Income"].Points.AddXY((double)i, (double)totalIncomes * i);
                this.chart1.Series["Expense"].Points.AddXY((double)i, (double)totalExpenses * i);
                this.chart1.Series["Net Balance"].Points.AddXY((double)i, (double)NetBalance * i);
            }

        }
    }
}
