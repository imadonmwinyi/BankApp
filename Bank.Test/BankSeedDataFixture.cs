using Bank.Lib.Data;
using System;
using Bank.Lib.Model;
using Microsoft.EntityFrameworkCore;
using Bank.Lib.Commons;

namespace Bank.Test
{
    public class BankSeedDataFixture : IDisposable
    {
        public BankContext TestBankContext { get; set; }

        public BankSeedDataFixture()
        {
            var options = new DbContextOptionsBuilder<BankContext>()
                                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                                .Options;

            TestBankContext = new BankContext(options);
            // create seed customer data for testing
            var password = "1234";
            var pwdHashSalt = PasswordHash.GenerateHash(password);
            var PasswordH = pwdHashSalt[0];
            var PasswordS = pwdHashSalt[1];
            var customer = new Customer()
            {
                Id = "8958f787-1123-4294-8b2c-afcd530a97b4",
                Email = "promise@gmail.com",
                FirstName = "promise",
                LastName = "Imadonmwinyi",
                PasswordHash = PasswordH,
                PasswordSalt = PasswordS
            };
            TestBankContext.Customers.Add(customer);

            // create seed Savings Account data for testing
            var cust_id = "8958f787-1123-4294-8b2a-cfcd530a97b4";
            decimal InitialDeposit = 5000.00m;
            var acct = new SavingsAccount()
            {
                AcctNumber = "7486669202",
                AcctBalance = InitialDeposit,
                AcctType = "Savings",
                CustomerId = cust_id,
                DateCreated = DateTime.Now
            };
            TestBankContext.Accounts.Add(acct);
            // create seed Current Account data for testing
            var C_Id = "8958f787-1123-4294-8b2a-cfcd530a97b4";
            decimal Deposit = 1000.00m;
            var C_acct = new CurrentAccount()
            {
                AcctNumber = "7437514147",
                AcctBalance = Deposit,
                AcctType = "Current",
                CustomerId = C_Id,
                DateCreated = DateTime.Now
            };
            TestBankContext.Accounts.Add(C_acct);
            TestBankContext.SaveChanges();

        }
        public void Dispose()
        {
            TestBankContext.Database.EnsureDeleted();
            TestBankContext.Dispose();
        }
    }
}
