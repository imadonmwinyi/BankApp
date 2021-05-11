using System.Collections.Generic;


namespace Bank.Lib.Core.Interfaces
{
    public interface IAccountRepository
    {

        decimal GetBalance(string AcctNum);
        List<string> CustomerAccounts(string custID);
        bool Deposit(string Acct, decimal Amount);
        List<string[]> GetAccounts(string CustId);
    }
}
