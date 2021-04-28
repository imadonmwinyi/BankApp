using System;

namespace Bank.Lib.Model
{
    public class Transaction
    { 
        public string TransactionType { get; set; }
        public string TransactionID { get; set; }
        public string Note { get; set; }
        public DateTime TransactDate { get; set; }
        public string AcctNumber { get; set; }
        public string BeneficiaryAcct { get; set; }
        public Decimal Amount { get; set; }

        public Transaction()
        {
            this.TransactionID = new Guid().ToString();
        }

    }
}
