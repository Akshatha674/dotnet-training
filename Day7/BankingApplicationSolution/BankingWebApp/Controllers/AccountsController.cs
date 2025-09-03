using Microsoft.AspNetCore.Mvc;
using BankingWebApp.Models;
using BankingWebApp.Repositories;
using BankingWebApp.Services;
namespace BankingWebApp.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountsController : ControllerBase
{
    private readonly ILogger<AccountsController> _logger;

    public AccountsController(ILogger<AccountsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Account> Get()
    {

        IAccountRepository accountRepository = new AccountRepository();
        IAccountService accountService = new AccountService(accountRepository);
        return accountService.GetAllAccounts();

    }

}
