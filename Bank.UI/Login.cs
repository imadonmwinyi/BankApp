using Bank.Lib.Core.Interfaces;
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
        private readonly IAuthRepository _auth;
        private readonly IAccountRepository _account;
        private readonly ITransactRepository _transact;
        private readonly IAccountOperationRepository _savings;
        private readonly IAccountOperationRepository _current;
        public Login(IAuthRepository auth, IAccountRepository account,ITransactRepository transact,IAccountOperationRepository savings, IAccountOperationRepository current)
        {
            _auth = auth;
            _account = account;
            _transact = transact;
            _savings = savings;
            _transact = transact;
            _current = current;
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
                var loginCred = _auth.Login(email, pwd);
                MessageBox.Show(loginCred.Item1 +" "+ loginCred.Item2 + " " + loginCred.Item3, "Login");
                // initialize the dashboard here.
                Dashboard dashboard = new Dashboard(loginCred,_account,_transact,_savings,_current,_auth);
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
