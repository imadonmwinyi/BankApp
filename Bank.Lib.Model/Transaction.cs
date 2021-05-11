using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bank.Lib.Model
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        [Required]
        public string TransactionType { get; set; }
        [Required]
        public string Note { get; set; }
        public DateTime TransactDate { get; set; } = DateTime.Now;
        public string BeneficiaryAcct { get; set; }
        public decimal Amount { get; set; }

        public string AccountId { get; set; }
        public Account Account { get; set; }

    }
}
