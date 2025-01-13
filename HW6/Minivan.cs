using ClassLibraryVehicle;

namespace MinivanLibraryVehicle
{
    public class Minivan : IVehicle
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 70;
        public string Name { get; set; }

        public Minivan(string name)
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
            Console.WriteLine("Max Speed: " + MaxSpeed);
        }
    }
}