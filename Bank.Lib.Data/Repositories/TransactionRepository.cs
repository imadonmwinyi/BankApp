using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Data.InterfacesRepo;
using Bank.Lib.Model;



namespace Bank.Repository
{
    public class TransactionRepository
    {
        /// <summary>
        /// Add Deposit History to Transaction DataStore
        /// </summary>
        /// <param name="AcctHolderEmail"></param>
        /// <param name="Acct"></param>
        /// <param name="Amount"></param>
        /// <param name="date"></param>
        /// <param name="Note"></param>
        //public void AddHistory( Transaction transaction)
        //{
        //    string query = "INSERT INTO transaction Values(@tranType,@acctN,@benAcct,@date,@note,@amt)";

        //    //DataStore.TansactionDataStore.Add(transaction);
        //}
        
        //public List<string[]> RetrieveTransactions(string AcctNumber)
        //{

        //}

    }
}
