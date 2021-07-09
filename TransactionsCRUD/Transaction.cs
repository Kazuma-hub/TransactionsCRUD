using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransactionsCRUD
{
    class Transaction
    {
        private string TransactionId { get; set; }
        private int TransactionSum { get; set; }
        private string TransactionDirection { get; set; }
        private DateTime TransactionTime { get; set; }

        public Transaction(int sum, string direction)
        {
            //Здесь должна быть проверка на валидность

            TransactionSum = sum;
            TransactionDirection = direction;
            TransactionTime = DateTime.Now;
            TransactionId = new Guid().ToString();
            
        }

        public void Show()
        {
            Console.WriteLine($"ID: {TransactionId}/nСумма транзакции: {TransactionSum}/nВид транзакции: {TransactionDirection}/nДата транзакции: {TransactionTime}");
        }


    }
}
