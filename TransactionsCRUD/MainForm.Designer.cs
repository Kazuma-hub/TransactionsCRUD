
namespace TransactionsCRUD
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.transactionCreateButton = new System.Windows.Forms.Button();
            this.transactionsTable = new System.Windows.Forms.DataGridView();
            this.transactionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.transactionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RefreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // transactionCreateButton
            // 
            this.transactionCreateButton.Location = new System.Drawing.Point(59, 317);
            this.transactionCreateButton.Name = "transactionCreateButton";
            this.transactionCreateButton.Size = new System.Drawing.Size(124, 60);
            this.transactionCreateButton.TabIndex = 0;
            this.transactionCreateButton.Text = "Создать транзакцию";
            this.transactionCreateButton.UseVisualStyleBackColor = true;
            this.transactionCreateButton.Click += new System.EventHandler(this.transactionCreateButton_Click);
            // 
            // transactionsTable
            // 
            this.transactionsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsTable.Location = new System.Drawing.Point(59, 43);
            this.transactionsTable.Name = "transactionsTable";
            this.transactionsTable.RowHeadersWidth = 51;
            this.transactionsTable.RowTemplate.Height = 24;
            this.transactionsTable.Size = new System.Drawing.Size(553, 182);
            this.transactionsTable.TabIndex = 1;
            // 
            // transactionBindingSource1
            // 
            this.transactionBindingSource1.DataSource = typeof(TransactionsCRUD.Transaction);
            // 
            // transactionBindingSource
            // 
            this.transactionBindingSource.DataSource = typeof(TransactionsCRUD.Transaction);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(190, 317);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(117, 60);
            this.RefreshButton.TabIndex = 2;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.transactionsTable);
            this.Controls.Add(this.transactionCreateButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button transactionCreateButton;
        private System.Windows.Forms.DataGridView transactionsTable;
        private System.Windows.Forms.BindingSource transactionBindingSource1;
        private System.Windows.Forms.BindingSource transactionBindingSource;
        private System.Windows.Forms.Button RefreshButton;
    }
}

