using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Data.FileOperation;
using Bank.Lib.Model;
using Bank.Lib.Data.InterfacesRepo;
using Bank.Lib.Data.DataBaseSQL.IDBProcessor;
using Bank.Lib.Data.DataBaseSQL;

namespace Bank.Lib.Data.Repositories
{
    public class AccountsRepository:IAccountRepository
    {
        //private readonly ICustomerRepository cust;
        private readonly FileOpening _openfile;
        private readonly FileWriter _fileWriter;
        private readonly FileReader _fileReader;
        private Account _acct;
        private DbAccountQuery _dBAccount;
        public AccountsRepository()
        {
            _dBAccount = new DbAccountQuery(new Connection());
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
            _dBAccount.InsertAccount(AccountRecord);
            
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
        public List<string[]> GetAccounts(string custID)
        {
           
            string query = "SELECT acctNumber, acctType, accountBalance FROM account WHERE customerID = @custID";
            var res = _dBAccount.Accounts(query, custID);
            return res;
            
        }

        public List<string> GetOwnerAccounts(string ownerId)
        {
            var list = _dBAccount.RetieveAccounts(ownerId);
            return list;
        }

        public void MakeDeposit(string accNum, decimal amount)
        {
            //var acctInfo = _fileReader.ReadOne(accNum, "Account.txt");
            //var balance = decimal.Parse(acctInfo[2]) + amount;
            //List<string> acct = new List<string>() { 
            //    acctInfo[0],acctInfo[1],balance.ToString(),acctInfo[3],acctInfo[4]
            //};
            //_fileWriter.FileUpdateLine(accNum, "Account.txt", acct);
            string queryStr = "UPDATE account SET accountBalance+=@Amount WHERE acctNumber=@acct";
             _dBAccount.UpdateBalance(queryStr,accNum, amount);
        }

        public void MakeTransfer(string senderNumber, string receiverNumber, decimal amt, string type)
        {
            //MakeDeposit(receiverNumber, amt);
            //MakeWithdrawal(senderNumber, amt);
            // db implementation
            string queryStr = "UPDATE account SET accountBalance+=@Amount WHERE acctNumber=@acct";
            string queryStr1 = "UPDATE account SET accountBalance-=@Amount WHERE acctNumber=@acct";
            _dBAccount.UpdateBalance(queryStr, receiverNumber, amt);
            _dBAccount.UpdateBalance(queryStr1, senderNumber, amt);
            
        }

        public void MakeWithdrawal(string accNum, decimal amt)
        {
            //var acctInfo = _fileReader.ReadOne(accNum, "Account.txt");
            //var balance = decimal.Parse(acctInfo[2]) - amt;
            //List<string> acct = new List<string>() {
            //    acctInfo[0],acctInfo[1],balance.ToString(),acctInfo[3],acctInfo[4]
            //};
            //_fileWriter.FileUpdateLine(accNum, "Account.txt", acct);
            string queryStr = "UPDATE account SET accountBalance-=@Amount WHERE acctNumber=@acct";
            _dBAccount.UpdateBalance(queryStr, accNum, amt);
        }
        public decimal GetBalance(string acct)
        {
            string query = "SELECT accountBalance FROM account where acctNumber=@acct";            
            return _dBAccount.RetrieveBalance(query, acct); ;
        }


        
    }
}
