using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Model;

namespace Bank.Lib.Core.Interfaces
{
    public interface IAccountService
    {
        void OpenAccount(string custID, string AcctType, decimal intialDeposit);
        void Deposit(string Acct, decimal Amount);
        void Withdraw(string Account, decimal Amount, string acctType);
        void Transfer(string OwnerAcct, string BenAcct, decimal Amount,string AcctType);
        List<string> CustomerAccounts(string custID);
        List<string[]> GetAccounts(string custID);
    }
}
