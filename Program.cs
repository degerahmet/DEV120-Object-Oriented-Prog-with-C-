

namespace DEV120 {
    class Fruit{
        public int Weight { get; set; }
        public string Name { get; set; }

        public Fruit(int weight, string name){
            Weight = weight;
            Name = name;
        }

        internal void PrintFruits(){
            Console.WriteLine($"Name: {Name}, Weight: {Weight}");
        }
    }
}