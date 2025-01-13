using ClassLibraryVehicle;

namespace TruckLibraryVehicle
{
    public class Truck : IVehicle
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 100;
        public string Name { get; set; }

        public Truck(string name)
        {
            Name = name;
        }

        public void SetThrottle(int speed)
        {
            if (speed > MaxSpeed)
            {
                CurrentSpeed = MaxSpeed;
                Console.WriteLine("You have reached the max speed of " + MaxSpeed);
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