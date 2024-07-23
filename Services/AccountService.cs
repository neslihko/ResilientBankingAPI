
using global::ResilientBankingAPI.Models;
using ResilientBankingAPI.Data;

namespace ResilientBankingAPI.Services
{
    public class AccountService : IAccountService
    {
        private readonly BankingContext _context;

        public AccountService(BankingContext context)
        {
            _context = context;
        }

        public async Task<Account> GetAccountAsync(int id)
        {
            return await _context.Accounts.FindAsync(id);
        }

        public async Task<Account> CreateAccountAsync(Account account)
        {
            _context.Accounts.Add(account);
            await _context.SaveChangesAsync();
            return account;
        }
    }
  