using System;
using Bank.Lib.Model;
using System.Collections.Generic;
using Bank.Lib.Data.FileOperation;
using Bank.Lib.Data.InterfacesRepo;




namespace Bank.Lib.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly FileOpening _openfile;
        private readonly FileWriter _fileWriter;
        private readonly FileReader _fileReader;
        public CustomerRepository()
        {
            _openfile = new FileOpening();
            _fileWriter = new FileWriter(_openfile);
            _fileReader = new FileReader(_openfile);
        }
      
        public void CreateCustomer(Customer customer)
        {
            // add customer to file and sqlDb
            
            List<string> customerDetial = new List<string>()
            {
                customer.Email,
                customer.CustomerID,
                customer.FirstName,
                customer.LastName,
                Convert.ToBase64String(customer.PasswordHash),
                Convert.ToBase64String(customer.PasswordSalt)
            };
            // file implementation
            if (_fileReader.Search(customer.Email, "Customer.txt"))
                throw new Exception(" Customer Already Exist");
            _fileWriter.FileWrite(customerDetial, "Customer.txt");//file Implementation

        }

        public Customer RetrieveOneCustomer(string Email)
        {
            // call filereader here to find one Customer
            var customer = _fileReader.ReadOne(Email, "Customer.txt");
            Customer newCustomer = new Customer()
            {
                Email = customer[0],
                CustomerID = customer[1],
                FirstName = customer[2],
                LastName = customer[3],
                PasswordHash = Convert.FromBase64String(customer[4]),
                PasswordSalt = Convert.FromBase64String(customer[5])
            };
            return newCustomer;
            
        }
        //public string GetCustomerID()
        //{
        //    return _cust.CustomerID;
        //}
        //public Dictionary<string, Dictionary<string, string>> RetrieveAll(string Email)
        //{
        //    //if(string.IsNullOrEmpty(Email))
        //    //    throw new Exception("Input is Empty")
        //    FileRecordsToDictionary fileRecordsToDictionary = new FileRecordsToDictionary(filename);
        //    var allCustomers = fileRecordsToDictionary.ReadFromFile(Email);
        //    return allCustomers;
        //}

    }
}
