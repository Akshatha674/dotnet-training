namespace BankingWebApp.Services
{
    using BankingWebApp.Models;
    using System.Collections.Generic;

    public interface IAccountService
    {
      IEnumerable<Account> GetAllAccounts();
      
    }
}