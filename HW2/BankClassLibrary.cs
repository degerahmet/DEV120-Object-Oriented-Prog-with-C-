
namespace BankClassLibrary{
    class MyBank {
        public string FName { get; set; }
        public string LName { get; set; }
        public double Balance { get; private set; } = 0;

        internal void Deposit(double amount){
            Balance += amount;
        }
        internal void Withdrawal(double amount){
            if (Balance >= amount){
                Balance -= amount;
                Console.WriteLine($"Success - Here's your $$$. You have {Balance} left");
            } else {
                Console.WriteLine("Fail - You are broke");
            }
        }

        internal void PrintBalance(){
            Console.WriteLine($"Your Balance: {Balance:C}");
        }

    }

}