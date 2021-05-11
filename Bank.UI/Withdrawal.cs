using System;
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
    public partial class Withdrawal : Form
    {
        private readonly ITransactRepository _transact;
        private readonly IAccountRepository _acct;
        private readonly string _custID;
        private readonly IAccountOperationRepository _savings;
        private readonly IAccountOperationRepository _current;
        public Withdrawal(IAccountRepository acct, string custID, ITransactRepository transact, IAccountOperationRepository savings, IAccountOperationRepository current)
        {
            _transact = transact;
            _custID = custID;
            _acct = acct;
            _savings = savings;
            _current = current;
            InitializeComponent();
        }

        private void WithdrawBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //if (AccountComBo.SelectedValue.ToString() == "Select Account")
                //throw new Exception("You have not Selected an Account");
                Validation.ValueNotEmpty(AmountBox.Text);
                Validation.ValueNotEmpty(AccountComBo.SelectedItem.ToString());
                Validation.ValueNotEmpty(NoteBox.Text);
                var amount = decimal.Parse(AmountBox.Text);
                var note = NoteBox.Text;
                var account = AccountComBo.SelectedItem.ToString();
                var arrStr = Seperators.TwoStringByDash(account);
                if (arrStr[0] == "Savings")
                    _savings.Withdraw(arrStr[1], amount);
                else
                    _current.Withdraw(arrStr[1], amount);
                List<string> details = new List<string>() { arrStr[1], amount.ToString(), note, "withdraw" };
                _transact.AddTranHistory(details);
                MessageBox.Show("Withdraw Transaction Succcessful", "Success Message");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error");
            }
        }

        private void Withdrawal_load(object sender, EventArgs e)
        {
            var list = _acct.CustomerAccounts(_custID);
            foreach (var item in list)
            {
                AccountComBo.Items.Add(item);
            }
        }
    }
}
