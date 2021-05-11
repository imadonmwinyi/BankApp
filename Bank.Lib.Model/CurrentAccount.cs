using System.ComponentModel.DataAnnotations.Schema;
using Bank.Lib.Commons;

namespace Bank.Lib.Model
{
    public class CurrentAccount:Account
    {
        public override string AcctType { get => base.AcctType; set => base.AcctType = "Current"; }
        [NotMapped]
        public static decimal MinBalance { get; set; } = 0.00m;

        public CurrentAccount()
        {
            AcctNumber = AccountNumGenerator.GenerateAcctNumber();
            this.AcctType = "Current";
        }
    }
}
