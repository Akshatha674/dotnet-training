namespace Banking.Handlers;
public static class AccountListener
{
    public static void BlockAccount()
    {
        Console.WriteLine($"Account should be blocked");
    }
    
       public static void SendEmail(decimal amount)
    {
         Console.WriteLine($"Email sent");
    }
}