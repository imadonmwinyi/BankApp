using Bank.Lib.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Data.DataBaseSQL.IDBProcessor
{
    public interface IDBTransact
    {
        void InsertTansaction(string query, Transaction transact);
        List<string[]> GetTransact(string query, string acct);
    }
}
