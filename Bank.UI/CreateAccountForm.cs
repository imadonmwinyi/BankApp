using Bank.Lib.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Bank.Lib.Commons;
using Bank.Lib.Model;

namespace Bank.UI
{
    public partial class CreateAccountForm : Form
    {
        private string AcctType { get; set; }
        private readonly string _customerID;
        private readonly IAccountOperationRepository _savings;
        private readonly IAccountOperationRepository _current;
        public CreateAccountForm(string CustID,IAccountOperationRepository savings, IAccountOperationRepository current)
        {
            InitializeComponent();
            _customerID = CustID;
            _savings = savings;
            _current = current;
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
                
                if (AcctType == "Savings")
                {
                    var savings = new SavingsAccount();
                    if (initDeposit < SavingsAccount.MinBalance)
                        throw new InvalidOperationException("Invalid Initial Deposit");
                    savings.AcctType = "Savings";
                    savings.CustomerId=_customerID;
                    savings.AcctBalance = initDeposit;
                    _savings.OpenAccount(savings);
                }
                else
                {
                    var current = new CurrentAccount();
                    if (initDeposit < CurrentAccount.MinBalance)
                        throw new InvalidOperationException("Invalid Initial Deposit");
                    current.AcctType = "Savings";
                    current.CustomerId = _customerID;
                    current.AcctBalance = initDeposit;
                    _savings.OpenAccount(current);
                }
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
