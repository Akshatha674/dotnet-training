namespace BankingWebApp.Models;

public class Account
{
    public int Id { get; set; }
    public string? AccountNumber { get; set; }
    public string? AccountName { get; set; } 
    public decimal Balance { get; set; }

}