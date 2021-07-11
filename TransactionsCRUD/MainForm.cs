using System;
using System.Windows.Forms;

namespace TransactionsCRUD
{
    public partial class MainForm : Form
    {

        private BindingSource bindingSource1 = new BindingSource();
        public MainForm()
        {
            InitializeComponent();

            bindingSource1.DataSource = BankTransactions.bankTransactions;
            transactionsTable.DataSource = bindingSource1;
        }

        private void transactionCreateButton_Click(object sender, EventArgs e)
        {
            TransactionCreateForm transactionCreateForm = new TransactionCreateForm();
            transactionCreateForm.Show();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            transactionsTable.Refresh();
        }
    }
}
