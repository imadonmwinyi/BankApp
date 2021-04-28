using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Commons;


namespace Bank.Lib.Model
{
   public  class SavingsAccount : Account
    {
        public override string AcctType { get => base.AcctType; set => base.AcctType = "Savings"; }
        //public override decimal MinBalance { get => base.MinBalance; set => base.MinBalance = 1000.00m; }
        public override decimal MinBalance { get; set; } = 1000.00m;

        public SavingsAccount()
        {
            AcctNumber = AccountNumGenerator.GenerateAcctNumber();
            this.AcctType = "Savings";
        }
        



        //public override decimal Withdraw(decimal amount)
        //{
        //    if (amount <= 0)
        //    {
        //        throw new ArgumentOutOfRangeException("Amount cannot be zero or less than zero");
        //    }
        //    if (base.AcctBalance - amount < base.MinBalance)
        //    {
        //        throw new InvalidOperationException(message: "Insufficient Funds");
        //    }



        //   this.AcctBalance -= amount;
        //    return this.AcctBalance;
        //}
        
    }
}
