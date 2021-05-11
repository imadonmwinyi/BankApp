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
    public partial class Transfer : Form
    {
        private readonly ITransactRepository _transact;
        private readonly IAccountRepository _acct;
        private readonly string _custID;
        private readonly IAccountOperationRepository _savings;
        private readonly IAccountOperationRepository _current;
        public Transfer(IAccountRepository acct, string custID, ITransactRepository transact, IAccountOperationRepository savings, IAccountOperationRepository current)
        {
            _transact = transact;
            _custID = custID;
            _acct = acct;
            _savings = savings;
            _current = current;
            InitializeComponent();
        }

        private void TransferBtn_Click(object sender, EventArgs e)
        {
            try
            {
                //if (AccountComBo.SelectedValue.ToString() == "Select Account")
                //throw new Exception("You have not Selected an Account");
                Validation.ValueNotEmpty(AmountBox.Text);
                Validation.ValueNotEmpty(BenAcctBox.Text);
                Validation.ValueNotEmpty(AccountComBo.SelectedItem.ToString());
                Validation.ValueNotEmpty(NoteBox.Text);
                var amount = decimal.Parse(AmountBox.Text);
                var note = NoteBox.Text;
                var account = AccountComBo.SelectedItem.ToString();
                var benAacct = BenAcctBox.Text;
                var arrStr = Seperators.TwoStringByDash(account);
                if(arrStr[0] =="Savings")
                    _savings.Transfer(arrStr[1], benAacct, amount);
                else
                    _current.Transfer(arrStr[1], benAacct, amount);

                List<string> details = new List<string>() { arrStr[1], amount.ToString(), note, "transfer" };
                _transact.AddTranHistory(details);
                MessageBox.Show("Transfer Transaction Succcessful", "Success Message");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error");
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            var list = _acct.CustomerAccounts(_custID);
            foreach (var item in list)
            {
                AccountComBo.Items.Add(item);
            }
        }
    }
}
