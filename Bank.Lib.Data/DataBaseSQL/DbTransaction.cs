using Bank.Lib.Data.DataBaseSQL.IDBProcessor;
using Bank.Lib.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Data.DataBaseSQL
{
   public class DbTransaction:IDBTransact
    {
        private readonly IDBConnection _conn;
        public DbTransaction(IDBConnection conn)
        {
            _conn = conn;
        }
        public void InsertTansaction(string query, Transaction transact )
        {
            
            var conn = _conn.Connect();
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.Add("@accountNumber", System.Data.SqlDbType.NVarChar, 20).Value =transact.AcctNumber;
                cmd.Parameters.Add("@amount", System.Data.SqlDbType.Decimal).Value = transact.Amount;
                cmd.Parameters.Add("@note", System.Data.SqlDbType.NVarChar, 50).Value = transact.Note;
                //cmd.Parameters.Add("@benefiaryAccout", System.Data.SqlDbType.NVarChar, 20).Value =transact.BeneficiaryAcct;
                cmd.Parameters.Add("@transationDate", System.Data.SqlDbType.DateTime).Value = transact.TransactDate;
                cmd.Parameters.Add("@transactType", System.Data.SqlDbType.NVarChar).Value = transact.TransactionType;

                conn.Open();
                var row = cmd.ExecuteNonQuery();
                conn.Close();
                
            }
        }
        public List<string[]> GetTransact(string query, string acct)
        {
            List<string[]> transact = new List<string[]>();
            var dbConn = _conn.Connect();
            using (SqlCommand cmd = new SqlCommand(query, dbConn))
            {
                cmd.Parameters.Add("@AcctNumber", System.Data.SqlDbType.NVarChar).Value = acct;
                dbConn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    transact.Add(new string[] { reader.GetString(0),reader.GetDecimal(1).ToString(),reader.GetString(2),reader.GetDateTime(3).ToString(), reader.GetString(4) });
                }

                dbConn.Close();
            }
            return transact;
        }
    }
}
