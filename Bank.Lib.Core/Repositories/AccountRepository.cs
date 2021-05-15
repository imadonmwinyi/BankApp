using System;
using System.Collections.Generic;
using System.Linq;
using Bank.Lib.Core.Interfaces;
using Bank.Lib.Data;


namespace Bank.Lib.Core.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankContext _bankContext;
        public AccountRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }

        public bool Deposit(string Acct, decimal Amount)
        {
            if (Amount < 0)
                throw new ArgumentOutOfRangeException(nameof(Amount), "Deposit amount must be positive");
            var res = _bankContext.Accounts.FirstOrDefault(acct => acct.AcctNumber.Equals(Acct));
            res.AcctBalance += Amount;
            var row = _bankContext.SaveChanges();
            if (row < 1)
                return false;
            return true;
        }
              
        public List<string> CustomerAccounts(string custID)
        {
            var acctList = _bankContext.Accounts.Where(acct => acct.CustomerId == custID)
                                 .Select(acct => $"{acct.AcctType}-{acct.AcctNumber}")
                                 .ToList();
            if (acctList == null)
                throw new Exception("No Account Record Yet, Kindly Open an Account");
            return acctList;
        }
            
                      
        public decimal GetBalance(string AcctNum)
        {
            var acctBal = _bankContext.Accounts.Single(acct => acct.AcctNumber == AcctNum);
                                 
            return acctBal.AcctBalance;
                                 
        }
        public List<string[]> GetAccounts(string CustId)
        {
           return  _bankContext.Accounts.Where(acct => acct.CustomerId == CustId)
                                 .Select(acct => new string[]
                                 {
                                     acct.AcctNumber,
                                     acct.AcctType,
                                     acct.AcctBalance.ToString()
                                 })
                                 .ToList();
        }
        internal static decimal AcctBalance(string AcctNum, BankContext ctx )
        {
            var acctBal = ctx.Accounts.Single(acct => acct.AcctNumber == AcctNum);

            return acctBal.AcctBalance;
        }

        public string GetAccountNumberByCustId(string custID)
        {
            var acctNumber = _bankContext.Accounts
                                         .Single(acct => acct.CustomerId == custID);


            return acctNumber.AcctNumber;
        }
        public string GetAccountNumberByCustId(string custID, string AcctType)
        {
            var acctNumber = _bankContext.Accounts
                                         .Single(acct => acct.CustomerId == custID && acct.AcctType==AcctType );
                                         
                                         
            return acctNumber.AcctNumber;
        }

    }
}
