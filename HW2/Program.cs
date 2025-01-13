using BankClassLibrary;

MyBank b = new MyBank();

b.FName = "John";
b.LName = "Doe";

Console.WriteLine($"Welcome {b.FName} {b.LName}");
b.PrintBalance();

b.Deposit(100);
b.PrintBalance();

b.Withdrawal(150);
b.PrintBalance();

b.Withdrawal(40);
b.PrintBalance();

