using System;

namespace TransactionsCRUD
{
    class Transaction
    {
        public string TransactionId { get; set; }
        public int TransactionSum { get; set; }
        public string TransactionDirection { get; set; }
        public DateTime TransactionTime { get; set; }

        public Transaction(int sum, string direction)
        {
            //Здесь должна быть проверка на валидность

            TransactionSum = sum;
            TransactionDirection = direction;
            TransactionTime = DateTime.Now;
            TransactionId = new Guid().ToString();
            
            
        }


    }
}
