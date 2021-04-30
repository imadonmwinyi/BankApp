using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Bank.Lib.Data.DataBaseSQL.IDBProcessor;

namespace Bank.Lib.Data.DataBaseSQL
{
   public class Connection:IDBConnection
    {
        public SqlConnection Connect()
        {
           var ConnectionString = "Data Source=.;Initial Catalog=Bank;Integrated Security=True";
            SqlConnection connection = new SqlConnection(ConnectionString);
            
            return connection;
        }
       
    }
}
