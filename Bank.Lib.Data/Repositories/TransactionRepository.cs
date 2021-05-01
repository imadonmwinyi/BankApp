using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Data.DataBaseSQL.IDBProcessor;
using Bank.Lib.Data.InterfacesRepo;
using Bank.Lib.Model;





namespace Bank.Lib.Data.Repositories
{
    public class TransactionRepository:ITransactionRepo
    {
        private readonly IDBTransact _transact;
        public TransactionRepository(IDBTransact transact)
        {
            _transact = transact;

        }
        public void AddHistory(Transaction tran)
        {
            string query = "INSERT INTO dbo.acmbtransact(accountNumber,amount,note,transationDate,transactType)" +
                                  "VALUES(@accountNumber,@amount,@note,@transationDate,@transactType)";
            _transact.InsertTansaction(query, tran);
        }

        public List<string[]> RetrieveTransactions(string AcctNumber)
        {
            string query = "SELECT accountNumber,amount,note,transationDate,transactType FROM acmbtransact WHERE accountNumber=@AcctNumber";
            var result = _transact.GetTransact(query, AcctNumber);
            return result;
        }

    }
}
