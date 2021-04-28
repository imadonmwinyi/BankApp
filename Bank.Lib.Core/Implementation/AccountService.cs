using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Core.Interfaces;
using Bank.Lib.Data.Repositories;
using Bank.Lib.Data.InterfacesRepo;
using Bank.Lib.Model;

namespace Bank.Lib.Core.Implementation
{
    class AccountService :IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        private Account _account;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public void Deposit(string Acct, decimal Amount)
        {
            if (Amount <= 0)
                throw new Exception("Can't Deposit Zero and Less Amount");
            _accountRepository.MakeDeposit(Acct, Amount);
        }

        public void OpenAccount(string custID, string AcctType, decimal initialDeposit)
        {
            
            if (AcctType == "Savings")
                _account = SavingsInstance(custID, initialDeposit);
            else
                _account = CurrentInstance(custID, initialDeposit);

            _accountRepository.CreateAccount(_account);
        }

        public List<string> CustomerAccounts(string custID)
        {
           var acctList = _accountRepository.GetOwnerAccounts(custID);
            if (acctList == null)
                throw new Exception("No Account Record Yet, Kindly Open an Account");
            return acctList;
        }

        public void Transfer(string OwnerAcct, string BenAcct, decimal Amount, string acctType)
        {
            Withdraw(OwnerAcct, Amount, acctType);
            Deposit(BenAcct, Amount);
        }

        public void Withdraw(string Account, decimal Amount, string acctType)
        {
            if(Amount <= 0)
                throw new Exception("Can't Withdraw Zero or Less Amount");
            if(acctType=="Savings" && (_accountRepository.GetBalance(Account)-Amount)<_accountRepository.GetMiniBalance(acctType))
                throw new Exception("Insufficient Fund");
            if(acctType =="Current" && (_accountRepository.GetBalance(Account)-Amount)< _accountRepository.GetMiniBalance(acctType))
                throw new Exception("Insufficient Fund");
            _accountRepository.MakeWithdrawal(Account, Amount);    
        }

        private Account SavingsInstance(string custID, decimal initialDeposit)
        {
            var savings = new SavingsAccount() { CustomerID = custID, AcctBalance = initialDeposit };
            if (initialDeposit < savings.MinBalance)
                throw new Exception("Deposit Amount for savings Account is from 1000");
            return savings;
        }
        private Account CurrentInstance(string custID, decimal initialDeposit)
        {
            var current = new CurrentAccount() { CustomerID = custID, AcctBalance = initialDeposit };
            if (initialDeposit < current.MinBalance)
                throw new Exception("Deposit Amount cannot be Negative");
            return current;
        }

    }
}
