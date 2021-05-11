using Bank.Lib.Commons;
using Bank.Lib.Core.Interfaces;
using System;


namespace Bank.Lib.Core.Repositories
{
    public class AuthRepository:IAuthRepository
    {
        public Tuple<string, string, string, string> LoginCredential;
        private readonly ICustomerRepository _customer;
        public AuthRepository(ICustomerRepository customer)
        {
            _customer = customer;
        }

       public Tuple<string, string, string, string> Login(string email, string password)
        {

            // first use email to retrieve user info;
            var customer = _customer.GetCustomer(email);
            if (customer == null)
                throw new InvalidOperationException("Customer Does not Exist");

            if (!PasswordHash.CompareHash(customer.PasswordSalt, customer.PasswordHash, password))
                throw new ArgumentException("Incorrect Password");
            LoginCredential = new Tuple<string, string, string, string>(customer.Id, customer.Email, customer.LastName, customer.FirstName);

            return LoginCredential;
        }

        public Tuple<string, string, string, string> Logout()
        {
            LoginCredential = null;
            return LoginCredential;
        }


    }
}
