using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace EADFinanceApp
{
    public partial class AddIncomeForm : Form
    {
        static int ChosenNumber;
        TextBox[] textBox_Amount;
        TextBox[] textBox_PayerName;
        

        public AddIncomeForm()
        {
            InitializeComponent();
        }

        private void button_AddIncome_Click(object sender, EventArgs e)
        {
            backgroundWorker_addIncome.RunWorkerAsync();
            
        }

        
        void UpdateIncomeXML()
        {

            List<Incomes> incomeList = new List<Incomes>();
            XDocument incomeXMLdoc = XDocument.Load(@"C:\Users\DELL\source\repos\EADFinanceApp\EADFinanceApp\Incomes.xml");

            var incomeElement = incomeXMLdoc.Root.Elements("Income");

            //If XML data exists, add xml data to list
            if (incomeElement != null)
            {
                incomeList = (
                   from eIncome in incomeElement
                   select new Incomes
                   {
                       incomeDate = (string)eIncome.Element("date"),
                       incomeAmount = (int)eIncome.Element("incomeAmount"),
                       payerName = (string)eIncome.Element("payerName")
                   }
                   ).ToList();
            }

            //Updating latest form inputs to list
            //converting some text from string to float before adding to list
            for (int i = 0; i<ChosenNumber; i++) {
                int convertedAmount;
                int.TryParse(textBox_Amount[i].Text, out convertedAmount);
                //Add submitted income details to list
                incomeList.Add(new Incomes()
                {
                    incomeDate = dateTimePicker1.Value.ToShortDateString(),
                    incomeAmount = convertedAmount,
                    payerName = textBox_PayerName[i].Text
                });
            }
            

            //adding data to xml from list

            var xEle = new XElement("Income",
                from incomes in incomeList
                select new XElement("Income",
                               new XElement("date", incomes.incomeDate),
                               new XElement("incomeAmount", incomes.incomeAmount),
                               new XElement("payerName", incomes.payerName)));

            xEle.Save(@"C:\Users\DELL\source\repos\EADFinanceApp\EADFinanceApp\Incomes.xml");


        }

        private void button_generateEntries_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox_ChosenEntries.Text, out ChosenNumber);
            textBox_Amount = new TextBox[ChosenNumber];
            textBox_PayerName = new TextBox[ChosenNumber];

            for (int i = 0; i < ChosenNumber; i++)
            {
                //Dynamically generating Income entry controls
                textBox_Amount[i] = new TextBox();
                this.Controls.Add(textBox_Amount[i]);
                textBox_Amount[i].Top = (i + 1) * 35;
                textBox_Amount[i].Left = 100;

              
                textBox_PayerName[i] = new TextBox();
                this.Controls.Add(textBox_PayerName[i]);
                textBox_PayerName[i].Top = (i + 1) * 35;
                textBox_PayerName[i].Left = 250;
            }
        }

        private void backgroundWorker_addIncome_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateIncomeXML();
        }

        

        private void backgroundWorker_addIncome_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Income successfully added");
            this.Dispose();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label_Payername_Click(object sender, EventArgs e)
        {

        }

        private void label_IncomeAmount_Click(object sender, EventArgs e)
        {

        }
    }
}
