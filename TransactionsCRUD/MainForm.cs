﻿using System;
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
