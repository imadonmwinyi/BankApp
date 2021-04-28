using System;
using System.Collections.Generic;
using System.Text;


namespace Bank.Lib.Data.InterfacesRepo
{
    public interface IAuthRepository
    {
        Tuple<bool, string,string> Login(string Email, string password);
    }
}
