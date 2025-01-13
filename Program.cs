

namespace HW1 {
    class Fruit{
        public int Weight { get; set; }
        public string Color { get; set; }

        public Fruit(int weight, string name){
            Weight = weight;
            Color = name;
        }

        internal void PrintFruits(){
            Console.WriteLine($"Color: {Color}, Weight: {Weight}");
        }
    }
}