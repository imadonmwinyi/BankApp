using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Data.FileOperation;
using Bank.Lib.Model;
using Bank.Lib.Data.InterfacesRepo;

namespace Bank.Lib.Data.Repositories
{
    public class AccountsRepository:IAccountRepository
    {
        //private readonly ICustomerRepository cust;
        private readonly FileOpening _openfile;
        private readonly FileWriter _fileWriter;
        private readonly FileReader _fileReader;
        private Account _acct;
        public AccountsRepository()
        {
            
            _openfile = new FileOpening();
            _fileWriter = new FileWriter(_openfile);
            _fileReader = new FileReader(_openfile);
        }
        public void CreateAccount(Account acct)
        {
            
            // prepare data to write to file
            List<string> AccountRecord = new List<string>()
            { acct.CustomerID,acct.AcctNumber,acct.AcctBalance.ToString(),
              acct.AcctType,acct.DateCreated.ToString()
            };
            _fileWriter.FileWrite(AccountRecord, "Account.txt");
            
        }


        public decimal GetMiniBalance(string AcctType)
        {
            if (AcctType == "Savings")
                _acct = new SavingsAccount();
            if (AcctType == "Current")
                _acct = new CurrentAccount();
            return _acct.MinBalance;
        }

        public Account GetAccountByAccNum(string accNum)
        {
            throw new NotImplementedException();
        }

        public List<string> GetOwnerAccounts(string ownerId)
        {
            List<string> list = new List<string>();
            var lines = _fileReader.ReadMany(ownerId, "Account.txt");
            if (lines[0] != null)
            {
                foreach (var line in lines)
                {
                    list.Add($"{line[3]}-{line[1]}");
                }
            }
            return list;
        }

        public void MakeDeposit(string accNum, decimal amount)
        {
            var acctInfo = _fileReader.ReadOne(accNum, "Account.txt");
            var balance = decimal.Parse(acctInfo[2]) + amount;
            List<string> acct = new List<string>() { 
                acctInfo[0],acctInfo[1],balance.ToString(),acctInfo[3],acctInfo[4]
            };
            _fileWriter.FileUpdateLine(accNum, "Account.txt", acct);
        }

        public void MakeTransfer(string senderNumber, string receiverNumber, decimal amt, string type)
        {
            MakeDeposit(receiverNumber, amt);
            MakeWithdrawal(senderNumber, amt);
        }

        public void MakeWithdrawal(string accNum, decimal amt)
        {
            var acctInfo = _fileReader.ReadOne(accNum, "Account.txt");
            var balance = decimal.Parse(acctInfo[2]) - amt;
            List<string> acct = new List<string>() {
                acctInfo[0],acctInfo[1],balance.ToString(),acctInfo[3],acctInfo[4]
            };
            _fileWriter.FileUpdateLine(accNum, "Account.txt", acct);
        }
        public decimal GetBalance(string acct)
        {
            var acctInfo = _fileReader.ReadOne(acct, "Account.txt");
            var balance = decimal.Parse(acctInfo[2]);
            return balance;
        }


        
    }
}
