using Bank.Lib.Model;
using System.Collections.Generic;


namespace Bank.Lib.Core.Interfaces
{
    public interface ITransactRepository
    {
        bool AddTranHistory(List<string> details);
        List<Transaction> GetTranHistory(string acctNumber);
    }
}
