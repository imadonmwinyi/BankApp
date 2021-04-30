using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Data.DataBaseSQL.IDBProcessor
{
    public interface IDBAccount
    {
        void InsertAccount(List<string> AccountRecord);
    }
}
