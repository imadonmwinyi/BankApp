using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Data.DataBaseSQL.IDBProcessor
{
   public interface IDBCustomer
    {
        void InsertCustomer(List<string> CustomeDetail);
        string[] RetrieveCustomer(string email);
        
        
    }
}
