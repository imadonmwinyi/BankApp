using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Data.DataBaseSQL.IDBProcessor;
using Microsoft.Data.SqlClient;

namespace Bank.Lib.Data.DataBaseSQL
{
    class DBCustomerQuery : IDBCustomer
    {
        private readonly IDBConnection _conn;

        public DBCustomerQuery(IDBConnection conn)
        {
            _conn = conn;
        }
        public void InsertCustomer(List<string> CustomerRecord)
        {
            var dbConn = _conn.Connect();
            string queryString = "INSERT INTO dbo.customer(custID, firstName,lastName,email,passwordSalt,passwordHash)" +
                                  "VALUES(@custID,@firstName,@lastName,@email,@passwordSalt,@passwordHash)";
            using (SqlCommand cmd = new SqlCommand(queryString, dbConn))
            {
                cmd.Parameters.Add("@custID", System.Data.SqlDbType.UniqueIdentifier,50).Value = new System.Data.SqlTypes.SqlGuid(CustomerRecord[1]);
                cmd.Parameters.Add("@firstName", System.Data.SqlDbType.NVarChar,50).Value = CustomerRecord[2];
                cmd.Parameters.Add("@lastName", System.Data.SqlDbType.NVarChar,50).Value = CustomerRecord[3];
                cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar,50).Value = CustomerRecord[0];
                cmd.Parameters.Add("@passwordSalt", System.Data.SqlDbType.Text).Value = CustomerRecord[5];
                cmd.Parameters.Add("@passwordHash", System.Data.SqlDbType.Text).Value = CustomerRecord[4];

                // open connection for inserting
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();
            }
        }

        public string[] RetrieveCustomer(string email)
        {
            string[] res = new string[6];
            var dbConn = _conn.Connect();
            string queryStr = "SELECT * FROM dbo.customer where email= @email";
            using (SqlCommand cmd = new SqlCommand(queryStr, dbConn))
            {
                cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = email;
                dbConn.Open();
                var reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        var id = reader.GetGuid(0);
                        res[1] = id.ToString();
                        res[2] = reader.GetString(1);
                        res[3] = reader.GetString(2);
                        res[0] = reader.GetString(3);
                        res[5]  = (string) reader.GetValue(4);
                        res[4]  = (string)reader.GetValue(5);
                    }
                }
                return res;
                
            }

        }
        public bool CheckCustomerExist(string email)
        {
            bool exist = false;
            var dbConn = _conn.Connect();
            string queryStr = "SELECT email FROM dbo.customer where email= @email";
            using (SqlCommand cmd = new SqlCommand(queryStr, dbConn))
            {
                cmd.Parameters.Add("@email", System.Data.SqlDbType.NVarChar).Value = email;
                dbConn.Open();
                var res = cmd.ExecuteScalar();
                if(res != null)
                    exist = true;

                dbConn.Close();
                
            }
            return exist;
        }
    }
}
