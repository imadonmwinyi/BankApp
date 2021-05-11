using Bank.Lib.Model;
using System.Collections.Generic;

namespace Bank.Lib.Core.Interfaces
{
    public interface ICustomerRepository
    { 
        bool Add(Customer CustInfo);
        Customer GetCustomer(string Email);
    }
}
