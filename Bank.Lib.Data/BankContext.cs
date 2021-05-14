using Bank.Lib.Model;
using Microsoft.EntityFrameworkCore;

namespace Bank.Lib.Data
{
    public class BankContext:DbContext
    {
        public BankContext(DbContextOptions<BankContext> options):base(options)
        {
            
        }

      
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CurrentAccount> CurrentAccount { get; set; }
        public DbSet<SavingsAccount> SavingsAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
