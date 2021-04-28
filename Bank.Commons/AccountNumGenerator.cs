using System;

namespace Bank.Lib.Commons
{
    public  class AccountNumGenerator
    {
        public static string GenerateAcctNumber()
        {
            Random random = new Random();
            return $"74{random.Next(1000, 9999)}{random.Next(1000, 9999)}";
        }
    }
}
