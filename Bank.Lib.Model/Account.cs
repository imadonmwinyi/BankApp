using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Model
{
    public abstract class Account
    {
        
        public string AcctNumber { get; set; }
        public Decimal AcctBalance { get; set; }
        public virtual string AcctType { get; set; }
        public string CustomerID { get; set; }
        public virtual decimal MinBalance { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;

    }
}
