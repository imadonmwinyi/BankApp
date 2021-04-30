
using System;
using System.Collections.Generic;
using System.Text;
using Bank.Lib.Model;
using Bank.Lib.Commons;
using Bank.Lib.Data.InterfacesRepo;
using Bank.Lib.Core.Interfaces;

namespace Bank.Lib.Core.Implementation
{
    class CustomerService : ICustomerService
    {
       // private readonly ICustomerRepository _repository;
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
            
        }

        public Tuple<string, string, string,string> Login(string email, string password)
        {
            
            // first use email to retrieve user info;
            var customer = _customerRepository.RetrieveOneCustomer(email);
            if (customer == null)
                throw new Exception("Customer Does not Exist");

            if (!PasswordHash.CompareHash(customer.PasswordSalt, customer.PasswordHash, password))
                throw new Exception("Incorrect Password");
            var LoginCredential = new Tuple<string, string, string, string>(customer.CustomerID, customer.Email, customer.LastName,customer.FirstName);
           
            return LoginCredential;
        }

        public bool Logout()
        {
            throw new NotImplementedException();
        }

        public Customer Register(Dictionary<string,string> CustomerInfo)
        {
            Customer newCust = new Customer
            {
                Email = CustomerInfo["Email"],
                FirstName = CustomerInfo["FirstName"],
                LastName = CustomerInfo["LastName"]
            };
            // process the password to password hash and salt
            var pwdHashSalt = PasswordHash.GenerateHash(CustomerInfo["Password"]);
            newCust.PasswordHash = pwdHashSalt[0];
            newCust.PasswordSalt = pwdHashSalt[1];
            // send to repository to create customer
            _customerRepository.CreateCustomer(newCust);
            return newCust;
        }

    }
}
