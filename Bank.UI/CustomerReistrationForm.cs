﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bank.Lib.Core.Interfaces;
using Bank.Lib.Commons;

namespace Bank.UI
{
    public partial class CustomerReistrationForm : Form
    {
        private readonly ICustomerService _customer;
        //private IAccountRepository _savings;
        public CustomerReistrationForm(ICustomerService customer)
        {
            _customer = customer;
           // _savings = savings;
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                var firstName = Sanitize.Capitalize(FirstNameBox.Text);
                var lastName = Sanitize.Capitalize(LastNameBox.Text);
                Validation.EmailValidation(EmailBox.Text);
                var email = EmailBox.Text;
                var pwd = Password(PasswordBox.Text, ConPasswordBox.Text);
                // Create a dictionary of customer to pass to CreateCustomer
                Dictionary<string, string> customerReg = new Dictionary<string, string>()
                {{"Email",email},{"FirstName",firstName},{"LastName",lastName},{"Password",pwd} };
                _customer.Register(customerReg);
                //new CreateAccountForm(_savings, _customer).Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error in Input");
            }
            EmptyTextBox();

        }
        private string Password(string pwd, string cPwd)
        {
            if (!pwd.Equals(cPwd))
                throw new Exception("Password does not match");
            return pwd;
        }
        private void EmptyTextBox()
        {
            FirstNameBox.Clear();
            LastNameBox.Clear();
            EmailBox.Clear();
            PasswordBox.Clear();
            ConPasswordBox.Clear();
        }
    }
}
