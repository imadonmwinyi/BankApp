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
        //private readonly ICustomerService _customerService;
        private readonly Tuple<string, string, string, string> _loggedIn;
        private readonly IAccountService _acct;
        
        public Dashboard(Tuple<string, string, string, string> loggedIn,IAccountService acct)
        {
            _loggedIn = loggedIn;
            _acct = acct;
            InitializeComponent();
            this.welcome.Text = "Welcome " + " " + _loggedIn.Item3;
            
        }

        private void OpenAccountBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            CreateAccountForm acctForm = new CreateAccountForm(_acct,_loggedIn.Item1) { TopLevel = false };
            this.MainPanel.Controls.Add(acctForm);
            acctForm.Show();
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {

        }

        private void DepositBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Deposit deposit = new Deposit(_acct, _loggedIn.Item1) { TopLevel = false };
            this.MainPanel.Controls.Add(deposit);
            deposit.Show();
        }

        private void WithdrawalBtn_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Withdrawal withdraw = new Withdrawal(_acct, _loggedIn.Item1) { TopLevel = false };
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
                Transfer transfer = new Transfer(_acct, _loggedIn.Item1) { TopLevel = false };
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
    }
   
}
