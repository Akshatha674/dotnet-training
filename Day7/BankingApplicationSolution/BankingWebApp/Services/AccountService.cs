namespace BankingWebApp.Services
{
    using BankingWebApp.Models;
    using BankingWebApp.Repositories;
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public IEnumerable<Account> GetAllAccounts()
        {
            return _accountRepository.GetAllAccounts();
        }

    }
}