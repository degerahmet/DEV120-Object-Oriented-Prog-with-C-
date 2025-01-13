using PersonClassLibrary;

namespace BankClassLibrary{
    class MyBank: Person {

        public static double VaultBalance { get; private set; } = 0;

        public MyBank(string Fname, string Lname) : base(Fname, Lname) {
            Console.WriteLine($"Welcome {Fname} {Lname}");
        }
        internal void Withdrawal(double amount){
            if (VaultBalance < amount){
                Console.WriteLine("Fail - Insufficient funds in the vault");
                return;
            }
            if (base.Withdraw(amount)){
                VaultBalance -= amount;
                Console.WriteLine($"Success - Here's your $$$. You have {Balance:C} left");
            } else {
                Console.WriteLine("Fail - You are broke");
            }
        }

        internal void Deposit(double amount){
            base.DepositPerson(amount);
            VaultBalance += amount;
            Console.WriteLine($"Success - You have deposited {amount:C}. Your balance is {Balance:C}");
        }

        internal void PrintBalance(){
            Console.WriteLine($"Your Balance: {Balance:C}");
        }

        public void DisplayVaultBalance(){            
            Console.WriteLine($"Vault Balance: {VaultBalance:C}");

        }

    }

}