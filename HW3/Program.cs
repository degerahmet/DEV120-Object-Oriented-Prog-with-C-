
using BankClassLibrary;

MyBank jane = new MyBank("Jane", "Doe");
jane.PrintBalance();
jane.Deposit(100);
jane.PrintBalance();
jane.DisplayVaultBalance();


MyBank john = new MyBank("John", "Doe");
john.PrintBalance();    
john.Deposit(200);
john.PrintBalance();
john.DisplayVaultBalance();
john.Withdrawal(50);
john.PrintBalance();
john.DisplayVaultBalance();
