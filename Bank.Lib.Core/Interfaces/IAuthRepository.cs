using System;

namespace Bank.Lib.Core.Interfaces
{
    public interface IAuthRepository
    {
        Tuple<string, string, string, string> Login(string email, string password);
        Tuple<string, string, string, string> Logout();

    }
}
