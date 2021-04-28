using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Commons;

namespace Bank.Lib.Model
{
    public class CurrentAccount:Account
    {
        public override string AcctType { get => base.AcctType; set => base.AcctType = "Current"; }
        public override decimal MinBalance { get => base.MinBalance; set => base.MinBalance = 0.00m; }

        public CurrentAccount()
        {
            AcctNumber = AccountNumGenerator.GenerateAcctNumber();
            this.AcctType = "Current";
        }


        //public override decimal Withdraw(decimal amount)
        //{
        //    if (amount <= 0)
        //    {
        //        throw new ArgumentOutOfRangeException("Amount cannot be zero or less than zero");
        //    }
        //    if (base.AcctBalance - amount < MinBalance)
        //    {
        //        throw new InvalidOperationException(message: "Insufficient Funds");
        //    }

        //    this.AcctBalance -= amount;
        //    return this.AcctBalance;
        //}
    }
}
