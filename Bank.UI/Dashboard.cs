using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bank.Lib.Core.Interfaces;

namespace Bank.UI
{
    public partial class Dashboard : Form
    {
        private readonly ITransactRepository _transact;
        private readonly Tuple<string, string, string, string> _loggedIn;
        private readonly IAccountRepository _acct;
        private readonly IAccountOperationRepository _savings;
        private readonly IAccountOperationRepository _current;
        private readonly IAuthRepository _auth;


        
        public Dashboard(Tuple<string, string, string, string> loggedIn, IAccountRepository acct, ITransactRepository transact, IAccountOperationRepository savings, IAccountOperationRepository current, IAuthRepository auth)
        {
            _loggedIn = loggedIn;
            _acct = acct;
            _transact = transact;
            _savings = savings;
            _current = current;
            _auth = auth;
            InitializeComponent();
            this.welcome.Text = "Welcome " + " " + _loggedIn.Item3;
            
        }

        private void OpenAccountBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            CreateAccountForm acctForm = new CreateAccountForm(_loggedIn.Item1,_savings,_current) { TopLevel = false };
            this.MainPanel.Controls.Add(acctForm);
            acctForm.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            _auth.Logout();
        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Deposit deposit = new Deposit(_acct, _loggedIn.Item1,_transact) { TopLevel = false };
            this.MainPanel.Controls.Add(deposit);
            deposit.Show();
        }

        private void WithdrawalBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Withdrawal withdraw = new Withdrawal(_acct, _loggedIn.Item1,_transact,_savings,_current) { TopLevel = false };
            this.MainPanel.Controls.Add(withdraw);
            withdraw.Show();
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            try
            {
                CheckAccoutEmpty();
                MainPanel.Controls.Clear();
                _acct.CustomerAccounts(_loggedIn.Item1);
                Transfer transfer = new Transfer(_acct, _loggedIn.Item1,_transact,_savings,_current) { TopLevel = false };
                this.MainPanel.Controls.Add(transfer);
                transfer.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Operation Error");
            }
           
        }
        private void CheckAccoutEmpty()
        {
            if (_acct.CustomerAccounts(_loggedIn.Item1) == null)
                throw new Exception("No Account Record Yet");
        }

        private void DashBoard_OnLoad(object sender, EventArgs e)
        {
            try
            {
                if (_acct.CustomerAccounts(_loggedIn.Item1) == null)
                    throw new Exception("No Account Yet, Open Account");
                AccountSummary summary = new AccountSummary( _acct, _loggedIn) { TopLevel = false };

                MainPanel.Controls.Add(summary);
                summary.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Propmt");
            }
        }

        private void AccountStateBtn_Click(object sender, EventArgs e)
        {
            AccountSummary summary = new AccountSummary(_acct, _loggedIn) { TopLevel = false };

            MainPanel.Controls.Add(summary);
            summary.Show();
        }
    }
   
}
