using ResilientBankingAPI.Data;
using ResilientBankingAPI.Models;


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
            _ = _context.Accounts.Add(account);
            _ = await _context.SaveChangesAsync();
            return account;
        }
    }
}
