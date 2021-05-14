using System;
using System.Windows.Forms;
using Bank.Lib.Core.Interfaces;


namespace Bank.UI
{
    public partial class OpenAcctLogin_Window : Form
    {
       
        private readonly ICustomerRepository _customer;
        private readonly IAccountRepository _account;
        private readonly ITransactRepository _transact;
        private readonly IAccountOperationRepository _savings;
        private readonly IAccountOperationRepository _current;
        private readonly IAuthRepository _auth;
       
        

        public OpenAcctLogin_Window(ICustomerRepository customer, IAccountRepository account, ITransactRepository transact, IAccountOperationRepository savings, IAccountOperationRepository current, IAuthRepository auth)
        {
            _customer = customer;
            _account = account;
            _transact = transact;
            _savings = savings;
            _current = current;
            _auth = auth;
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
            Login login = new Login(_auth,_account,_transact,_savings,_current) { TopLevel = false };
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
