using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bank.Lib.Core.Interfaces;


namespace Bank.UI
{
    public partial class OpenAcctLogin_Window : Form
    {
       
        private readonly ICustomerService _customer;
        private readonly IAccountService _account;
       
        

        public OpenAcctLogin_Window(ICustomerService customer, IAccountService account)
        {
            _customer = customer;
            _account = account;
            //_auth = auth;
            InitializeComponent();
            ShowCustomerRegForm();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            ShowCustomerRegForm();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            Login login = new Login(_customer,_account) { TopLevel = false };
            this.MainPanel.Controls.Add(login);
            login.Show();
        }
        private void ShowCustomerRegForm()
        {
            CustomerReistrationForm customerReistration = new CustomerReistrationForm(_customer) { TopLevel = false };
            this.MainPanel.Controls.Add(customerReistration);
            customerReistration.Show();
        }
    }
}
