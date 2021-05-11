using System;
using System.Collections.Generic;
using Bank.Lib.Model;
using Bank.Lib.Commons;
using Bank.Lib.Core.Interfaces;
using Bank.Lib.Data;
using System.Linq;

namespace Bank.Lib.Core.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly BankContext _bankContext;    
        public CustomerRepository(BankContext bankContext)
        {
            // db context will come here
            _bankContext = bankContext;            
        }

        public bool Add(Customer CustomerInfo)
        {
            //check if customer already exist
            if (GetCustomer(CustomerInfo.Email) != null)
                throw new InvalidOperationException("Customer Already Exist");

            // implement efcore to add to database
            _bankContext.Customers.Add(CustomerInfo);
            var row = _bankContext.SaveChanges();
            if (row < 1)
                return false;
            return true;
        }
        public Customer GetCustomer(string Email)
        {
            var cust = _bankContext.Customers.SingleOrDefault(cust=>cust.Email==Email);
            return cust;
        }

    }
}
