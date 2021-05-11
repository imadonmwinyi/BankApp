using Bank.Lib.Model;
using Microsoft.EntityFrameworkCore;

namespace Bank.Lib.Data
{
    public class BankContext:DbContext
    {
        public BankContext()
        {
            this.Database.EnsureCreated();
        }

      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite(@"Data Source=C:\Users\hp\source\repos\Bank\Bank.Lib.Data\BankDB.db;");
            optionsBuilder.UseSqlite("Filename=./BankDB.db;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<CurrentAccount> CurrentAccount { get; set; }
        public DbSet<SavingsAccount> SavingsAccounts { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

    }
}
