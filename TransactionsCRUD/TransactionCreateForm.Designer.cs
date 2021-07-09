
namespace TransactionsCRUD
{
    partial class TransactionCreateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sumTextBox = new System.Windows.Forms.TextBox();
            this.EnterTheNameLabel = new System.Windows.Forms.Label();
            this.typeOfTransactionLabel = new System.Windows.Forms.Label();
            this.inRadioButton = new System.Windows.Forms.RadioButton();
            this.outRadioButton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sumTextBox
            // 
            this.sumTextBox.Location = new System.Drawing.Point(374, 130);
            this.sumTextBox.Name = "sumTextBox";
            this.sumTextBox.Size = new System.Drawing.Size(154, 22);
            this.sumTextBox.TabIndex = 1;
            // 
            // EnterTheNameLabel
            // 
            this.EnterTheNameLabel.AutoSize = true;
            this.EnterTheNameLabel.Location = new System.Drawing.Point(166, 133);
            this.EnterTheNameLabel.Name = "EnterTheNameLabel";
            this.EnterTheNameLabel.Size = new System.Drawing.Size(191, 17);
            this.EnterTheNameLabel.TabIndex = 2;
            this.EnterTheNameLabel.Text = "Введите сумму транзакции:";
            // 
            // typeOfTransactionLabel
            // 
            this.typeOfTransactionLabel.AutoSize = true;
            this.typeOfTransactionLabel.Location = new System.Drawing.Point(169, 219);
            this.typeOfTransactionLabel.Name = "typeOfTransactionLabel";
            this.typeOfTransactionLabel.Size = new System.Drawing.Size(186, 17);
            this.typeOfTransactionLabel.TabIndex = 3;
            this.typeOfTransactionLabel.Text = "Выберите тип транзакции:";
            // 
            // inRadioButton
            // 
            this.inRadioButton.AutoSize = true;
            this.inRadioButton.Location = new System.Drawing.Point(374, 217);
            this.inRadioButton.Name = "inRadioButton";
            this.inRadioButton.Size = new System.Drawing.Size(154, 21);
            this.inRadioButton.TabIndex = 4;
            this.inRadioButton.TabStop = true;
            this.inRadioButton.Text = "Входящий перевод";
            this.inRadioButton.UseVisualStyleBackColor = true;
            // 
            // outRadioButton
            // 
            this.outRadioButton.AutoSize = true;
            this.outRadioButton.Location = new System.Drawing.Point(374, 244);
            this.outRadioButton.Name = "outRadioButton";
            this.outRadioButton.Size = new System.Drawing.Size(162, 21);
            this.outRadioButton.TabIndex = 5;
            this.outRadioButton.TabStop = true;
            this.outRadioButton.Text = "Исходящий перевод";
            this.outRadioButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(270, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Создать транзакцию";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TransactionCreateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.outRadioButton);
            this.Controls.Add(this.inRadioButton);
            this.Controls.Add(this.typeOfTransactionLabel);
            this.Controls.Add(this.EnterTheNameLabel);
            this.Controls.Add(this.sumTextBox);
            this.Name = "TransactionCreateForm";
            this.Text = "TransactionCreateForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox sumTextBox;
        private System.Windows.Forms.Label EnterTheNameLabel;
        private System.Windows.Forms.Label typeOfTransactionLabel;
        private System.Windows.Forms.RadioButton inRadioButton;
        private System.Windows.Forms.RadioButton outRadioButton;
        private System.Windows.Forms.Button button1;
    }
}