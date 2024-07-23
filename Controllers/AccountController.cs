namespace ResilientBankingAPI.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    namespace ResilientBankingAPI.Controllers
    {
        [ApiController]
        [Route("[controller]")]
        public class AccountController : ControllerBase
        {
            private readonly IAccountService _accountService;

            public AccountController(IAccountService accountService)
            {
                _accountService = accountService;
            }

            [HttpGet("{id}")]
            public async Task<ActionResult<Account>> GetAccount(int id)
            {
                var account = await _accountService.GetAccountAsync(id);
                if (account == null)
                {
                    return NotFound();
                }
                return account;
            }

            [HttpPost]
            public async Task<ActionResult<Account>> CreateAccount(Account account)
            {
                var createdAccount = await _accountService.CreateAccountAsync(account);
                return CreatedAtAction(nameof(GetAccount), new { id = createdAccount.Id }, createdAccount);
            }
        }
    }
}
