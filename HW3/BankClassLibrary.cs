
namespace BankClassLibrary{
    class MyBank {
        public string FName { get; set; }
        public string LName { get; set; }
        public double Balance { get; private set; } = 0;

        public static double VaultBalance { get; private set; } = 0;

        public MyBank(string Fname, string Lname){
            FName = Fname;
            LName = Lname;
        }

        internal void Deposit(double amount){
            Balance += amount;
            VaultBalance += amount;
        }
        internal void Withdrawal(double amount){
            if (VaultBalance <= amount){
                Console.WriteLine("Fail - Insufficient funds in the vault");
                return;
            }
            if (Balance >= amount){
                Balance -= amount;
                VaultBalance -= amount;
                Console.WriteLine($"Success - Here's your $$$. You have {Balance:C} left");
            } else {
                Console.WriteLine("Fail - You are broke");
            }
        }

        internal void PrintBalance(){
            Console.WriteLine($"Your Balance: {Balance:C}");
        }

        public void DisplayVaultBalance(){            
            Console.WriteLine($"Vault Balance: {VaultBalance:C}");

        }

    }

}