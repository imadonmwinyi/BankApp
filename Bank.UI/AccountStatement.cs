using Bank.Lib.Commons;
using Bank.Lib.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bank.UI
{
    public partial class AccountStatement : Form
    {
        private readonly ITransactRepository _transact;
        private readonly IAccountRepository _acct;
        private readonly string _custID;
        public AccountStatement(IAccountRepository acct, string custID, ITransactRepository transact)
        {
            _acct = acct;
            _custID = custID;
            _transact = transact;
            InitializeComponent();
        }

        private void ViewStsBtn_Click(object sender, EventArgs e)
        {

            Validation.ValueNotEmpty(AccountComBo.SelectedItem.ToString());
            var account = AccountComBo.SelectedItem.ToString();
            var arrStr = Seperators.TwoStringByDash(account);
            var transact = _transact.GetTranHistory(arrStr[1]);
            var list = new List<string[]>();
            foreach (var item in transact)
            {
                list.Add(new string[] { item.TransactDate.ToString(), item.TransactionType, item.Amount.ToString(), item.Note });
            }
            foreach (var item in list)
            {
                var acct = new ListViewItem(item);
                StatementListView.Items.Add(acct);
            }
            
        }

        private void ViewStatement_Onload(object sender, EventArgs e)
        {
            try
            {
                var list = _acct.CustomerAccounts(_custID);
                foreach (var item in list)
                {
                    AccountComBo.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Operation Error");
            }
        }
    }
}
