﻿using Bank.Lib.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bank.Lib.Commons;


namespace Bank.UI
{
    public partial class Login : Form
    {
        private readonly ICustomerService _customer;
        private readonly IAccountService _account;
        public Login(ICustomerService customer, IAccountService account)
        {
            _customer = customer;
            _account = account;
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                string email = "";
                Validation.EmailValidation(EmailLoginBox.Text);
                email = EmailLoginBox.Text;
                var pwd = PasswordLoginBox.Text;
                var loginCred = _customer.Login(email, pwd);
                MessageBox.Show(loginCred.Item1 +" "+ loginCred.Item2 + " " + loginCred.Item3, "Login");
                // initialize the dashboard here.
                Dashboard dashboard = new Dashboard(loginCred,_account);
                dashboard.Show();
                // hide the registration and login window
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, " Error Login");
            }
        }
    }
}