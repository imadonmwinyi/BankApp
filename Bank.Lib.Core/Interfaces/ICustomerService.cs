using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Model;

namespace Bank.Lib.Core.Interfaces
{
    public interface ICustomerService
    {
        Customer Register(Dictionary<string,string> CustomerInfo);
        Tuple<string,string,string,string> Login(string email, string password);
        bool Logout();
    }
}
