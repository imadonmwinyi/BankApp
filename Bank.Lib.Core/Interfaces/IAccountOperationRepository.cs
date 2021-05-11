using Bank.Lib.Model;

namespace Bank.Lib.Core.Interfaces
{
    public interface IAccountOperationRepository
    {
        bool OpenAccount(Account account);
        bool Withdraw(string Account, decimal Amount);
        bool Transfer(string OwnerAcct, string BenAcct, decimal Amount);
    }
}
