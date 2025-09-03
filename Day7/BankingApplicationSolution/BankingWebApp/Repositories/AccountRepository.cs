namespace BankingWebApp.Repositories;

using System.Collections.Generic;
using BankingWebApp.Models;


public class AccountRepository : IAccountRepository
{
    private readonly List<Account> _Account = new List<Account>();
    public AccountRepository()
    {
        _Account.Add(new Account { Id = 1, AccountNumber = "4354646", AccountName = "Account1", Balance = 10000.00M });
    }

    public IEnumerable<Account> GetAllAccounts()
    {

        return _Account;
    }

}
