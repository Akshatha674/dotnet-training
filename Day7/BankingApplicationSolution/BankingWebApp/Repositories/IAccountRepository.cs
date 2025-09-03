namespace BankingWebApp.Repositories
{
    using BankingWebApp.Models;
    using System.Collections.Generic;

    public interface IAccountRepository
    {
        IEnumerable<Account> GetAllAccounts(); 
        
    }
}