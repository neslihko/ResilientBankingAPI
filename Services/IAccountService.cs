using ResilientBankingAPI.Models;

namespace ResilientBankingAPI.Services
{
    public class IAccountService
    {
        public interface IAccountService
        {
            Task<Account> GetAccountAsync(int id);
            Task<Account> CreateAccountAsync(Account account);
        }
    }
}
