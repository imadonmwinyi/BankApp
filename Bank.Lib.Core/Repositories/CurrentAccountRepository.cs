using Bank.Lib.Commons;
using Bank.Lib.Core.Interfaces;
using Bank.Lib.Data;
using Bank.Lib.Model;
using System.Linq;
using System;


namespace Bank.Lib.Core.Repositories
{
    public class CurrentAccountRepository: IAccountOperationRepository
    {
        private readonly BankContext _bankContext;
        public CurrentAccountRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }
        

        public bool OpenAccount(Account acct)
        {
            if (acct.AcctBalance < CurrentAccount.MinBalance)
                return false;
            _bankContext.Accounts.Add(acct);
            _bankContext.SaveChanges();

            return true;
        }

        public bool Transfer(string OwnerAcct, string BenAcct, decimal Amount)
        {
            if (Amount < 0)
                throw new ArgumentOutOfRangeException(nameof(Amount), "Transfer amount must be positive");
            if (AccountRepository.AcctBalance(OwnerAcct, _bankContext) - Amount < CurrentAccount.MinBalance)
                throw new InvalidOperationException("Insufficient Fund");
            if (OwnerAcct == BenAcct)
                throw new InvalidOperationException("Can not transfer to the same account");
            var owner = _bankContext.Accounts.Single(acct => acct.AcctNumber == OwnerAcct);
            var ben = _bankContext.Accounts.Single(acct => acct.AcctNumber == BenAcct);
            if (ben == null)
                throw new InvalidOperationException("Beneficiary Account do not exist");

            owner.AcctBalance -= Amount;
            ben.AcctBalance += Amount;
            var row = _bankContext.SaveChanges();
            if (row < 0)
                return false;
            return true;
        }

        public bool Withdraw(string Account, decimal Amount)
        {
            if (Amount < 0)
                throw new ArgumentOutOfRangeException(nameof(Amount), "Withdraw amount must be positive");
            if (AccountRepository.AcctBalance(Account,_bankContext) - Amount < CurrentAccount.MinBalance)
                throw new InvalidOperationException("Insufficient Fund");
           var res = _bankContext.Accounts.Single(acct => acct.AcctNumber == Account && acct.AcctType=="Current");
           res.AcctBalance -= Amount;
           var row = _bankContext.SaveChanges();
            if (row < 1)
                return false;
            return true;
        }
        
    }
}
