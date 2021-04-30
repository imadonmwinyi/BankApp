using Bank.Lib.Data.DataBaseSQL.IDBProcessor;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Data.DataBaseSQL
{
    class DbTransaction
    {
        IDBConnection _conn;
        public DbTransaction(IDBConnection conn)
        {
            _conn = conn;
        }
        public void InsertTansaction(string query)
        {
            var conn = _conn.Connect();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                var row = cmd.ExecuteNonQuery();
            }
        }
    }
}
