using Bank.Lib.Core.Interfaces;
using Bank.Lib.Data.InterfacesRepo;
using Bank.Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Core.Implementation
{
    public class TransactService : ITransactService
    {
        private readonly ITransactionRepo _repo;
        public TransactService(ITransactionRepo repo)
        {
            _repo = repo;
        }
        public void AddTranHistory(List<string> details)
        {
            Transaction tran = new Transaction() 
            {AcctNumber = details[0], Amount=decimal.Parse(details[1]), Note=details[2],
              TransactionType = details[3]
            };
            _repo.AddHistory(tran);
        }

        public List<string[]> GetTranHistory(string AcctNumber)
        {
           var transList = _repo.RetrieveTransactions(AcctNumber);
           return transList;
        }
    }
}
