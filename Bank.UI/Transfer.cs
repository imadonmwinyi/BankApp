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
        private readonly IAccountService _accountService;
        private readonly string _custID;
        public Transfer(IAccountService accountService, string custID)
        {
            _custID = custID;
            _accountService = accountService;
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
                _accountService.Transfer(arrStr[1],benAacct, amount,arrStr[0]);
                MessageBox.Show("Transfer Transaction Succcessful", "Success Message");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Input Error");
            }
        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            var list = _accountService.CustomerAccounts(_custID);
            foreach (var item in list)
            {
                AccountComBo.Items.Add(item);
            }
        }
    }
}
