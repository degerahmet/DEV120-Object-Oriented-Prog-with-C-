using ClassLibraryVehicle;

namespace FerrariLibraryVehicle
{
    public class Ferrari : IVehicle
    {
        public int CurrentSpeed { get; set; }
        public int MaxSpeed { get; set; } = 200;
        public string Name { get; set; }

        public Ferrari(string name)
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
            Console.WriteLine("Max Speed: " + MaxSpeed);
        }
    }
}