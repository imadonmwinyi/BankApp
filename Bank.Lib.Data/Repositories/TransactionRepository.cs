using System;
using System.Collections.Generic;
using System.Text;
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
        public static void AddDepositHistory( string Acct, Decimal Amount, DateTime date, string Note)
        {
            Transaction transaction = new Transaction()
            {
                TransactionType = "Deposit",
                AcctNumber = Acct,
                Amount = Amount,
                TransactDate = date,
                Note = Note
            };
            //DataStore.TansactionDataStore.Add(transaction);
        }
        /// <summary>
        /// Adding Customer Withdrawal History to DataStore
        /// </summary>
        /// <param name="AcctHolderEmail"></param>
        /// <param name="Acct"></param>
        /// <param name="Amount"></param>
        /// <param name="date"></param>
        /// <param name="Note"></param>
        public static void AddWithdrawalHistory(string Acct, Decimal Amount, DateTime date, string Note)
        {
            Transaction transaction = new Transaction()
            {
                TransactionType = "Withdrawal",
                AcctNumber = Acct,
                Amount = Amount,
                TransactDate = date,
                Note = Note
            };
            //DataStore.TansactionDataStore.Add(transaction);
        }
       /// <summary>
       /// Adding Transfer History to DataStore
       /// </summary>
       /// <param name="AcctHolderEmail"></param>
       /// <param name="Acct"></param>
       /// <param name="Amount"></param>
       /// <param name="date"></param>
       /// <param name="Note"></param>
       /// <param name="benefiaryAcct"></param>
        public static void AddTransferHistory( string Acct, Decimal Amount, DateTime date, string Note, string benefiaryAcct)
        {
            Transaction transaction = new Transaction()
            {
                TransactionType = "Transfer",
                AcctNumber = Acct,
                Amount = Amount,
                TransactDate = date,
                Note = Note,
                BeneficiaryAcct = benefiaryAcct

            };
            //DataStore.TansactionDataStore.Add(transaction);
        }

        //public static List<Transaction> Retrieve()
        //{
        //     return DataStore.TansactionDataStore;
            
        //}

    }
}
