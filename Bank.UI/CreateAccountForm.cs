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
    public partial class CreateAccountForm : Form
    {
        private string AcctType { get; set; }
        private readonly string _customerID;
        private readonly IAccountService _account;
        public CreateAccountForm(IAccountService account,string CustID)
        {
            InitializeComponent();
            _account = account;
            _customerID = CustID;
            SavingsRbtn.Checked = false;
            CurrentRBtn.Checked = false;
            //InitialDepositBox.Enabled = false;
        }

        private void CreateAccountBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Validation.ValueNotEmpty(AcctType);
                Validation.ValueNotEmpty(InitialDepositBox.Text);
                var initDeposit = decimal.Parse(InitialDepositBox.Text);
                _account.OpenAccount(_customerID, AcctType, initDeposit);
                MessageBox.Show("Account Successfully Created", "Accout Created");
                //this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Account Input Error");
            }

        }

        private void Savings_Checked(object sender, EventArgs e)
        {
            AcctType = SavingsRbtn.Text;
            //InitialDepositBox.Enabled = true;
        }

        private void CurrentRBtn_CheckedChanged(object sender, EventArgs e)
        {
            AcctType = CurrentRBtn.Text;
            //InitialDepositBox.Enabled = false;
        }
       
    }
}
