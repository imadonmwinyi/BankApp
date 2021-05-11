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
    public partial class Deposit : Form
    {
        private readonly ITransactRepository _transact;
        private readonly IAccountRepository _acct;
        private readonly string _custID;
        
        public Deposit(IAccountRepository acct,string custID, ITransactRepository transact)
        {
            _transact = transact;
            _custID = custID;
            _acct = acct;
            InitializeComponent();
        }

        private void DepositBtn_Click(object sender, EventArgs e)
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
                _acct.Deposit(arrStr[1], amount);
                List<string> details = new List<string>() { arrStr[1], amount.ToString(), note, "deposit" };
                _transact.AddTranHistory(details);
                MessageBox.Show("Deposit Transaction Succcessful", "Success Message");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error");
            }
        }

        private void Deposit_OnLoad(object sender, EventArgs e)
        {
            try
            {
                var list = _acct.CustomerAccounts(_custID);
                foreach (var item in list)
                {
                    AccountComBo.Items.Add(item);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Operation Error");
            }
           
        }
    }
}
