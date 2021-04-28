using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Model;

namespace Bank.Lib.Data.InterfacesRepo
{
    public interface IAccountRepository
    {
        List<string> GetOwnerAccounts(string ownerId);
        Account GetAccountByAccNum(string accNum);
        void CreateAccount(Account acct);
        void MakeDeposit(string accNum, decimal amt);
        void MakeWithdrawal(string accNum, decimal amt);
        void MakeTransfer(string senderNumber, string receiverNumber, decimal amt,string type);
        decimal GetBalance(string acct);
        decimal GetMiniBalance(string AcctType);
    }
}
