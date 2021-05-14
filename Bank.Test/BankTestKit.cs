using Bank.Lib.Commons;
using Bank.Lib.Core.Repositories;
using Bank.Lib.Model;
using System;
using System.Collections.Generic;
using Xunit;

namespace Bank.Test
{
    public class CustomerTest
    {
        private readonly CustomerRepository _customer;
        private readonly AuthRepository _auth;
        private readonly SavingsAccountRepository _savings;
        private readonly CurrentAccountRepository _current;
        private readonly AccountRepository _acct;
        private readonly TransactRepository _trans;
        public CustomerTest()
        {
            var BankTest = new BankSeedDataFixture();
            var _ctx = BankTest.TestBankContext;
            _customer = new CustomerRepository(_ctx);
            _auth = new AuthRepository(_customer);
            _savings = new SavingsAccountRepository(_ctx);
            _current = new CurrentAccountRepository(_ctx);
            _acct = new AccountRepository(_ctx);
            _trans = new TransactRepository(_ctx); 
        }

        [Fact]
        public void ValidRegistrationTest()
        {
            //Arrange
            var password = "1234";
            var pwdHashSalt = PasswordHash.GenerateHash(password);
            var PasswordH = pwdHashSalt[0];
            var PasswordS = pwdHashSalt[1];
            var customer = new Customer()
            {
                Id = "8957f797-1123-4294-8b2c-afcd530a92b4",
                Email = "shalom@gmail.com",
                FirstName = "shalom",
                LastName = "Imadonmwinyi",
                PasswordHash = PasswordH,
                PasswordSalt = PasswordS
            };
            var expected = true;

            //Act 
            var actual = _customer.Add(customer);
            

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InValidRegistrationExceptionTest()
        {
            //Arrange
           var password = "1234";
            var pwdHashSalt = PasswordHash.GenerateHash(password);
            var PasswordH = pwdHashSalt[0];
            var PasswordS = pwdHashSalt[1];
            var customer = new Customer() {
                Id = "8958f787-1123-4294-8b2c-afcd530a97b4",
                Email = "promise@gmail.com", 
                FirstName = "promise", 
                LastName = "Imadonmwinyi",
                PasswordHash =PasswordH,
                PasswordSalt=PasswordS
            };

            //Act

            var ex = Record.Exception(() => _customer.Add(customer));

            //Assert
            Assert.NotNull(ex);
            Assert.IsType<InvalidOperationException>(ex);
        }

        [Fact]
        public void ValidRetrieveCustomerTest()
        {
            //Arrange
            string Email = "promise@gmail.com";

            //Act
            var actual = _customer.GetCustomer(Email);


            //Assert
            Assert.Equal(Email, actual.Email);


        }
        [Fact]
        public void InvalidRetrieveCustomerTest()
        {
            //Arrange
            string Email = "promie@gmail.com";

            // Act
            var actual = _customer.GetCustomer(Email);

            //Assert
            Assert.Null(actual);

        }
        [Fact]
        public void ValidLoginTest()
        {
            //Arrange

            var email = "promise@gmail.com";
            var password = "1234";

            //Act
            var auth_crend = _auth.Login(email, password);

            //Assert
            Assert.Equal("promise@gmail.com", auth_crend.Item2);

        }
        [Fact]
        public void InvalidLoginPassWordFailTest()
        {
            //Arrange
            var email = "promise@gmail.com";
            var password = "123";

            var ex = Record.Exception(() => _auth.Login(email, password));

            //Assert
            Assert.NotNull(ex);
            Assert.IsType<ArgumentException>(ex);

        }
        [Fact]
        public void InvalidLoginEmailFailTest()
        {
            //Arrange
            var email = "promis@gmail.com";
            var password = "123";

            var ex = Record.Exception(() => _auth.Login(email, password));

            //Assert
            Assert.NotNull(ex);
            Assert.IsType<InvalidOperationException>(ex);

        }
        // account opening
        [Fact]
        public void ValidSavingsAccountOpeningTest()
        {
            //Arrange
            var cust_id = "8957f797-1123-4294-8b2c-afcd530a92b4"; 
            decimal InitialDeposit = 2000.00m;
            var acct = new SavingsAccount()
            {
                AcctNumber = "7483469202",
                AcctBalance = InitialDeposit,
                AcctType = "Savings",
                CustomerId = cust_id,
                DateCreated = DateTime.Now
            };

            //Act
            var actual = _savings.OpenAccount(acct);
            var expected = true;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InValidSavingsAccountOpeningTest()
        {
            //Arrange
            var cust_id = "8958f787-1123-4294-8b2a-cfcd530a97b4";
            decimal InitialDeposit = 500.00m;
            var acct = new SavingsAccount()
            {
                AcctNumber = "7486669202",
                AcctBalance = InitialDeposit,
                AcctType = "Savings",
                CustomerId = cust_id,
                DateCreated = DateTime.Now
            };

            //Act
            var actual = _savings.OpenAccount(acct);
            var expected = false;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidCurrentAccountOpeningTest()
        {
            //Arrange
            var cust_id = "8957f797-1123-4294-8b2c-afcd530a92b4";
            decimal InitialDeposit = 1000.00m;
            var acct = new CurrentAccount()
            {
                AcctNumber = "7537519107",
                AcctBalance = InitialDeposit,
                AcctType = "Current",
                CustomerId = cust_id,
                DateCreated = DateTime.Now
            };

            //Act
            var actual = _current.OpenAccount(acct);
            var expected = true;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InValidCurrentAccountOpeningTest()
        {
            //Arrange
            var cust_id = "8958f787-1123-4294-8b2a-cfcd530a97b4";
            decimal InitialDeposit = -1000.00m;
            var acct = new SavingsAccount()
            {
                AcctNumber = "7437514147",
                AcctBalance = InitialDeposit,
                AcctType = "Current",
                CustomerId = cust_id,
                DateCreated = DateTime.Now
            };
            var expected = false;

            //Act
            var actual = _current.OpenAccount(acct);
            

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void ValidDepositToAccountTest()
        {
            //Arrange
            var acctNumber = "7437514147";
            decimal amt = 3000.00m;
            var expected = true;

            //Act
            var actual = _acct.Deposit(acctNumber, amt);
            

            //Assert
            
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InValidDepositToAccountTest()
        {
            //Arrange

            var acctNumber = "7425668978";
            decimal amt = -3000.00m;

            //Act
            var ex = Record.Exception(() => _acct.Deposit(acctNumber, amt));

            //Assert

            Assert.NotNull(ex);
            Assert.IsType<ArgumentOutOfRangeException>(ex);
        }
        [Fact]
        public void ValidSavingsWidthrawTest()
        {
            //Arrange
            var ValidWithdrawAmount = 1000.00m; //value less than balance - MinBalance
            var acctNumber = "7486669202";

            //Act
            var actual = _savings.Withdraw(acctNumber, ValidWithdrawAmount);
            var expected = true;

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void InValidSavingsWidthrawTest()
        {
            //Arrange
            var InValidWithdrawAmount = 7000.00m; //value greater than balance - MinBalance
            var acctNumber = "7486669202";

            //Act
            var ex = Record.Exception(() => _savings.Withdraw(acctNumber, InValidWithdrawAmount));

            //Assert
            Assert.NotNull(ex);
            Assert.IsType<InvalidOperationException>(ex);
        }

        [Fact]
        public void ValidWithdrawCurrentTest()
        {
            //Arrange
            var ValidWithdrawAmount = 1000.00m; //value greater than balance - MinBalance

            var acctNumber = "7437514147";

            //Act
            var actual = _current.Withdraw(acctNumber, ValidWithdrawAmount);
            var expected = true;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InValidWithdrawCurrentTest()
        {
            //Arrange
            var InValidWithdrawAmount = 10000.00m; //value greater than balance - MinBalance
            var acctNumber = "7437514147";

            //Act
            var ex = Record.Exception(() => _current.Withdraw(acctNumber, InValidWithdrawAmount));

            //Assert
            Assert.NotNull(ex);
            Assert.IsType<InvalidOperationException>(ex);

        }
        [Fact]
        public void ValidSavingsToCurrentTransferTest()
        {
            //Arrange
            var TransferAmount = 500.00m;
            var acctSav = "7486669202";
            var acctCurr = "7437514147";

            // Act
            var actual = _savings.Transfer(acctSav, acctCurr, TransferAmount);
            var expected = true;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void InValidSavingsToCurrentTransferTest()
        {
            //Arrange
            var TransferAmount = 7000.00m;// amount greater than the balance-minimum balance
            var acctSav = "7486669202";
            var acctCurr = "7437514147";

            //Act
            var ex = Record.Exception(() => _savings.Transfer(acctSav,acctCurr,TransferAmount));

            //Assert
            Assert.NotNull(ex);
            Assert.IsType<InvalidOperationException>(ex);
        }

        [Fact]
        public void AddTransactionTest()
        {
            //Arrange
            var TransferAmount = 500.00m;
            var Note = "Food";
            var acctNumber = "7460083969";
            var TranDetail = new List<string> {
               acctNumber,TransferAmount.ToString(),Note,"Transfer"
            };

            // Act
            var actual = _trans.AddTranHistory(TranDetail);
            var expected = true;

            //Assert

            Assert.Equal(expected, actual);

        }
    }
}
