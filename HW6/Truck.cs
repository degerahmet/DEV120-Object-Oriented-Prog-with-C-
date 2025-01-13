using ClassLibraryVehicle;

namespace TruckLibraryVehicle
{
    public class Truck : IVehicle
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 80;
        public string Name { get; set; }

        public Truck(string name)
        {
            Name = name;
        }

        public void SetThrottle(int speed)
        {
            if (speed > MaxSpeed)
            {
                CurrentSpeed = 0;
                throw new Exception($"{Name} can go only up to {MaxSpeed} MPH");
            }
            else
            {
                CurrentSpeed = speed;
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Current Speed: " + CurrentSpeed);
            Console.WriteLine($"Max Speed: {MaxSpeed}\n");
        }
    }
}