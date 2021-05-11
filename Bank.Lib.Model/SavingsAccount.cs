using System.ComponentModel.DataAnnotations.Schema;
using Bank.Lib.Commons;


namespace Bank.Lib.Model
{
   public  class SavingsAccount : Account
    {
        public override string AcctType { get => base.AcctType; set => base.AcctType = "Savings"; }
        [NotMapped]
        public static decimal MinBalance { get; set; } = 1000.00m;

        public SavingsAccount()
        {
            AcctNumber = AccountNumGenerator.GenerateAcctNumber();
            this.AcctType = "Savings";
        }
    }
}
