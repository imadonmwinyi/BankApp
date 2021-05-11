using Bank.Lib.Core.Interfaces;
using Bank.Lib.Data;
using Bank.Lib.Model;
using System.Collections.Generic;
using System.Linq;

namespace Bank.Lib.Core.Repositories
{
    public class TransactRepository : ITransactRepository
    {
        private readonly  BankContext _bankContext;
        public TransactRepository(BankContext bankContext)
        {
            _bankContext = bankContext;
        }
        public bool AddTranHistory(List<string> details)
        {
            Transaction tran = new Transaction() 
            {AccountId = details[0], Amount=decimal.Parse(details[1]), Note=details[2],
              TransactionType = details[3]
            };
            // track transaction
            _bankContext.Transactions.Add(tran);
            var row =_bankContext.SaveChanges();
            if (row < 1)
                return false;
            return true;
        }

        public List<Transaction> GetTranHistory(string AcctNumber)
        {
           var transList = _bankContext.Transactions
                                       .Where(tran=>tran.AccountId==AcctNumber)
                                       .ToList();
           return transList;
        }
    }
}
