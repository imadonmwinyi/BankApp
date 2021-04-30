using Bank.Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Data.InterfacesRepo
{
    public interface ITransactionRepo
    {
        List<string[]> RetrieveTransactions(string AcctNumber);
        void AddHistory(Transaction transaction);
    }
}
