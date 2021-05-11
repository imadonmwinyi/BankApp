using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Bank.Lib.Model
{
    public abstract class Account
    {
        [Key]
        public string AcctNumber { get; set; }
        public decimal AcctBalance { get; set; }
        public virtual string AcctType { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime DateCreated { get; set; } = DateTime.Now;

        //reference navigation property with Customer 
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }

        //Collection navigation property with transaction 
        public ICollection<Transaction> Transactions { get; set; }


    }
}
