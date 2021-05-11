using Bank.Lib.Core.Interfaces;
using Bank.Lib.Data;
using System;
using Bank.Lib.Core.Repositories;

namespace Bank.Lib.Core
{
    public static class GlobalConfig
    {
        public static ICustomerRepository CustRepo { get; set; }
        public static IAccountRepository ActRepo { get; set; }
        public static ITransactRepository TRepo { get; set; }
        public static IAccountOperationRepository Savings { get; set; }
        public static IAccountOperationRepository Current { get; set; }
        public static IAuthRepository AuthRepo { get; set; }
        public static void AddInstance()
        {
            BankContext bankContext = new BankContext();
            CustRepo = new CustomerRepository(bankContext);

            ActRepo = new AccountRepository(bankContext);

            TRepo = new TransactRepository(bankContext);

            Savings = new SavingsAccountRepository(bankContext);

            Current = new CurrentAccountRepository(bankContext);

            AuthRepo= new AuthRepository(CustRepo);

        }
    }
}
