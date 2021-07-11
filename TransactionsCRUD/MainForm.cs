using System;
using System.Windows.Forms;

namespace TransactionsCRUD
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void transactionCreateButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransactionCreateForm transactionCreateForm = new TransactionCreateForm();
            transactionCreateForm.Show();
        }
    }
}
