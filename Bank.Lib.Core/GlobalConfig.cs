using Bank.Lib.Core.Implementation;
using Bank.Lib.Core.Interfaces;
using Bank.Lib.Data.InterfacesRepo;
using Bank.Lib.Data.Repositories;
using System;

namespace Bank.Lib.Core
{
    public static class GlobalConfig
    {
        public static ICustomerService CustomerService { get; set; }
        public static IAccountService AccountService { get; set; }
        public static void AddInstance()
        {
            ICustomerRepository customerRepository = new CustomerRepository();
            CustomerService = new CustomerService(customerRepository);
            
            
            IAccountRepository accountRepository = new AccountsRepository();
            AccountService = new AccountService(accountRepository);
        }
    }
}
