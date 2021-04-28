using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Model;

namespace Bank.Lib.Data.InterfacesRepo
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer customer);
        Customer RetrieveOneCustomer(string key);
        //string GetCustomerID();
         
    }
}