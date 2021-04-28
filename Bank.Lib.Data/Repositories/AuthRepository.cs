using System;
using System.Collections.Generic;
using System.Text;


namespace Bank.Lib.Data.Repositories
{
    
    public class AuthRepository
    {
        //private  ICustomerRepository _customer;



        //public bool AuthCustomer( string Email, string password)
        //{
            
        //    bool isAuth = false;
        //    if(_customer.RetrieveOneCustomer(Email) != null)
        //    {
        //        var cust = _customer.RetrieveOneCustomer(Email);
        //        if (cust.Password == password)
        //            isAuth = true;
        //    }
        //    return isAuth; 
        //}
        //public Tuple<bool,string,string> Login(string Email, string password)
        //{
        //    _customer = new CustomerRepository();
        //    if (string.IsNullOrEmpty(Email) && string.IsNullOrEmpty(password))
        //        throw new Exception("Login Input Cannot be Empty");
        //    if (!AuthCustomer(Email, password))
        //        throw new Exception("Invalid credentials");
        //    var cust = _customer.RetrieveOneCustomer(Email);
        //    Tuple<bool, string,string> LoggedIn = new Tuple<bool, string, string>(true, cust.CustomerID,cust.Email);

        //    return LoggedIn;
        //}
    }
}
