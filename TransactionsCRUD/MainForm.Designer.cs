
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
            this.transactionCreateButton = new System.Windows.Forms.Button();
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.transactionCreateButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button transactionCreateButton;
    }
}

