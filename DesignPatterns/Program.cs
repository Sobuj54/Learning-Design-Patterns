using DesignPatterns.src.OOP.Coupling;
using DesignPatterns.src.OOP.Encapsulation;

BadBankAccount badAccount = new BadBankAccount();
badAccount.Balance = 0;

BankAccount bankAccount = new BankAccount(100);
bankAccount.Deposit(50);

Console.WriteLine(badAccount.Balance);
Console.WriteLine(bankAccount.GetBalance());

// Decoupling notification service
//Order order = new Order(new SmsSender());
Order order = new Order(new EmailSender());
order.OrderSuccessNotification("Order Successfull.");
