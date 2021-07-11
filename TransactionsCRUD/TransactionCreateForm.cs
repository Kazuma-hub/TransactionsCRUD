using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransactionsCRUD
{
    public partial class TransactionCreateForm : Form
    {
        public TransactionCreateForm()
        {
            InitializeComponent();
        }

        private string transactionDirection;

        
        private void createButton_Click(object sender, EventArgs e)
        {
            if (!(inRadioButton.Checked) && !(outRadioButton.Checked))
            {
                //Отобразить в лейбле информацию, что невыбран тип перевода.
            }
            else if (inRadioButton.Checked) transactionDirection = "Входящяя";
            else if (outRadioButton.Checked) transactionDirection = "Исходящяя";

            Transaction transaction = new Transaction(Convert.ToInt32(sumTextBox.Text), transactionDirection);
            BankTransactions.bankTransactions.Add(transaction);
            this.Close();

        } 
    }
}
