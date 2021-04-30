using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Data.DataBaseSQL.IDBProcessor
{
    public interface IDBConnection
    {
        SqlConnection Connect();
        
    }
}
