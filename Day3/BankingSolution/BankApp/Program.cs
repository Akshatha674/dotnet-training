using Banking;
using Banking.Handlers;

Account acc123 = new Account();
acc123.Balance = 6700;
acc123.Withdraw(500);
acc123.Deposit(200);

Console.WriteLine($"Account Balance : {acc123.Balance}");

AccountOperation agent = new AccountOperation(AccountListener.BlockAccount);
agent();