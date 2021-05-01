using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Data.DataBaseSQL.IDBProcessor;
using Microsoft.Data.SqlClient;

namespace Bank.Lib.Data.DataBaseSQL
{
    class DbAccountQuery:IDBAccount
    {
        private readonly IDBConnection _conn;
        public DbAccountQuery(IDBConnection conn)
        {
            _conn = conn;
        }
        public void InsertAccount(List<string> AccountRecord)
        {
            var dbConn = _conn.Connect();
            string queryString = "INSERT INTO dbo.account(acctNumber,acctType,customerID,accountBalance,dateCreated)" +
                                  "VALUES(@acctNumber,@acctType,@customerID,@accountBalance,@dateCreated)";
            using (SqlCommand cmd = new SqlCommand(queryString, dbConn))
            {
                cmd.Parameters.Add("@acctNumber", System.Data.SqlDbType.NVarChar,20).Value =AccountRecord[1];
                cmd.Parameters.Add("@acctType", System.Data.SqlDbType.NVarChar, 20).Value = AccountRecord[3];
                cmd.Parameters.Add("@customerID", System.Data.SqlDbType.NVarChar, 50).Value = AccountRecord[0];
                cmd.Parameters.Add("@accountBalance", System.Data.SqlDbType.Decimal, 50).Value = AccountRecord[2];
                cmd.Parameters.Add("@dateCreated", System.Data.SqlDbType.DateTime).Value = AccountRecord[4];
                

                // open connection for inserting
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
            }

           
        }
        public List<string> RetieveAccounts(string CustID)
        {
            List<string> accounts = new List<string>();
            var dbConn = _conn.Connect();
            string queryStr = "SELECT acctType, acctNumber FROM account where customerID=@custId";
            using (SqlCommand cmd = new SqlCommand(queryStr, dbConn))
            {
                cmd.Parameters.Add("@custId", System.Data.SqlDbType.UniqueIdentifier).Value =new Guid(CustID);
                dbConn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accounts.Add($"{reader.GetString(0)}-{reader.GetString(1)}");
                }

                dbConn.Close();
            }
            return accounts;
        }
        public bool UpdateBalance(string stmt, string acct, decimal Amount)
        {
            var dbConn = _conn.Connect();
            using (SqlCommand cmd = new SqlCommand(stmt, dbConn))
            {
                cmd.Parameters.Add("@Amount", System.Data.SqlDbType.Decimal).Value = Amount;
                cmd.Parameters.Add("@acct", System.Data.SqlDbType.NVarChar).Value = acct;
                dbConn.Open();
                var num_row = cmd.ExecuteNonQuery();
                if (num_row == 1)
                    return true;
            }
            dbConn.Close();
            return false;
        }
        public decimal RetrieveBalance(string queryStr, string acct)
        {
            decimal balance = 0; 
            var dbConn = _conn.Connect();
            using (SqlCommand cmd = new SqlCommand(queryStr, dbConn))
            {
                cmd.Parameters.Add("@acct", System.Data.SqlDbType.NVarChar).Value = acct;
                dbConn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.Read())
                    balance = reader.GetDecimal(0);
                    
            }
            dbConn.Close();
            return balance;
        }
        public List<string[]> Accounts(string query, string CustID)
        {
            List<string[]> accounts = new List<string[]>();
            var dbConn = _conn.Connect();
            using (SqlCommand cmd = new SqlCommand(query, dbConn))
            {
                cmd.Parameters.Add("@custId", System.Data.SqlDbType.UniqueIdentifier).Value = new Guid(CustID);
                dbConn.Open();
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    accounts.Add(new string[] { reader.GetString(0),reader.GetString(1),reader.GetDecimal(2).ToString()});
                }

                dbConn.Close();
            }
            return accounts;
        }

    }
}
