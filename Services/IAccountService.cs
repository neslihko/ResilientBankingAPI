using ResilientBankingAPI.Models;

namespace ResilientBankingAPI.Services
{
    public interface IAccountService
    {
        Task<Account> GetAccountAsync(int id);
        Task<Account> CreateAccountAsync(Account account);
    }
}