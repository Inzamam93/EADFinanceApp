using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EADFinanceApp
{
    public partial class AddExpenseForm : Form
    {
        static int ChosenNumber;
        TextBox[] textBox_Amount;
        TextBox[] textBox_PayeeName;

        public AddExpenseForm()
        {
            InitializeComponent();
        }

        private void button_generateEntries_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_ChosenEntries.Text, out ChosenNumber);
            textBox_Amount = new TextBox[ChosenNumber];
            textBox_PayeeName = new TextBox[ChosenNumber];

            for (int i = 0; i < ChosenNumber; i++)
            {
                textBox_Amount[i] = new TextBox();
                this.Controls.Add(textBox_Amount[i]);
                textBox_Amount[i].Top = (i + 1) * 35;
                textBox_Amount[i].Left = 100;

                textBox_PayeeName[i] = new TextBox();
                this.Controls.Add(textBox_PayeeName[i]);
                textBox_PayeeName[i].Top = (i + 1) * 35;
                textBox_PayeeName[i].Left = 250;
            }
        }

        private void button_AddExpense_Click(object sender, EventArgs e)
        {
            backgroundWorker_addExpense.RunWorkerAsync();
        }

        void UpdateExpenseXml()
        {
            List<Expenses> payerList = new List<Expenses>();
            XDocument expenseXMLdoc = XDocument.Load(@"C:\Users\DELL\source\repos\EADFinanceApp\EADFinanceApp\Expenses.xml");

            var PayeeElement = expenseXMLdoc.Root.Elements("Expense");

            //If XML data exists, add xml data to list
            if (PayeeElement != null)
            {
                payerList = (
                    from ePayer in PayeeElement
                    select new Expenses
                    {
                        expenseDate = (string)ePayer.Element("date"),
                        expenseAmount = (int)ePayer.Element("expenseAmount"),
                        payeeName = (string)ePayer.Element("payeeName")
                    }
                           ).ToList();
            }

            //Updating latest form inputs to list
            //converting some text from string to int before adding to list

            for (int i = 0; i < ChosenNumber; i++)
            {
                int convertedAmount;
                int.TryParse(textBox_Amount[i].Text, out convertedAmount);

                //Add submitted payer details to list
                payerList.Add(new Expenses()
                {
                    expenseDate = dateTimePicker1.Value.ToShortDateString(),
                    expenseAmount = convertedAmount,
                    payeeName = textBox_PayeeName[i].Text
                });


            }
            //adding data to xml from list

            var xEle = new XElement("Expense",
                from payers in payerList
                select new XElement("Expense",
                               new XElement("date", payers.expenseDate),
                               new XElement("expenseAmount", payers.expenseAmount),
                               new XElement("payeeName", payers.payeeName)));

            xEle.Save(@"C:\Users\DELL\source\repos\EADFinanceApp\EADFinanceApp\Expenses.xml");

        }

        private void backgroundWorker_addExpense_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateExpenseXml();
        }

        private void backgroundWorker_addExpense_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Expense(s) successfully added");
            this.Dispose();
            this.Close();
        }
    }
}
