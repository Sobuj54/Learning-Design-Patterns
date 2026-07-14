using DesignPatterns.src.OOP.Encapsulation;

BadBankAccount badAccount = new BadBankAccount();
badAccount.Balance = 0;

BankAccount bankAccount = new BankAccount(100);
bankAccount.Deposit(50);

Console.WriteLine(badAccount.Balance);
Console.WriteLine(bankAccount.GetBalance());