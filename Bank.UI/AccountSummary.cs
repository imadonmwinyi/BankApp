using Bank.Lib.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bank.UI
{
    public partial class AccountSummary : Form
    {
        private readonly IAccountRepository _acct;
        private readonly Tuple<string, string, string, string> _custInfo;
        public AccountSummary(IAccountRepository acct, Tuple<string, string, string, string> custInfo)
        {
            _acct = acct;
            _custInfo = custInfo;
            InitializeComponent();
        }

        private void AccountSummary_Load(object sender, EventArgs e)
        {
            nameLabel.Text += ": "+ _custInfo.Item4 + " " + _custInfo.Item3;
            // get the account information from service
            var accts = _acct.GetAccounts(_custInfo.Item1);
            foreach (var item in accts)
            {
                var acct = new ListViewItem(item);
                AccountList.Items.Add(acct);
            }

        }
    }
}
