using Microsoft.EntityFrameworkCore;
using ResilientBankingAPI.Models;


namespace ResilientBankingAPI.Data
{
    public class BankingContext : DbContext
    {
        public BankingContext(DbContextOptions<BankingContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
    }
}