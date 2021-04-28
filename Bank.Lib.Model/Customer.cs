using System;
using System.Collections.Generic;
using System.Text;

namespace Bank.Lib.Model
{
    public class Customer
    {
        public string CustomerID { get; set; } = Guid.NewGuid().ToString();
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        //public List<string> customerAccts { get; set; }
        //public string FullName { get; private set; }
        public Customer()
        {
           // customerAccts = new List<string>();
        }

    }

}
