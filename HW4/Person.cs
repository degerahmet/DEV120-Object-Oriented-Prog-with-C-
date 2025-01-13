namespace PersonClassLibrary {
    class Person{
        public string LName { get; set; }
        public string FName { get; set; }
        public double Balance { get; private set; } = 0;

        public Person(string Fname, string Lname){
            FName = Fname;
            LName = Lname;
        }

        public void DepositPerson(double amount) {
            Balance += amount;
        }

        public bool Withdraw(double amount) {
            if (Balance >= amount) {
                Balance -= amount;
                return true;
            }
            return false;
        }
    }
}