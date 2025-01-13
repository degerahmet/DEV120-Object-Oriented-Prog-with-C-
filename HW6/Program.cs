using ClassLibraryVehicle;
using FerrariLibraryVehicle;
using MinivanLibraryVehicle;
using TruckLibraryVehicle;

Ferrari f = new Ferrari("Omologata");
SpeedUp(f, 150);
f.DisplayInfo();

Minivan m = new Minivan("Odyssey");
SpeedUp(m, 45);
m.DisplayInfo();

Truck t = new Truck("F150");
SpeedUp(t, 65);
t.DisplayInfo();

Console.WriteLine("");


SpeedUp(f, 100);
f.DisplayInfo();

SpeedUp(m, -20);
m.DisplayInfo();

SpeedUp(t, -10);
t.DisplayInfo();

void SpeedUp(IVehicle vehicle, int v)
{
    int currentSpeed = vehicle.CurrentSpeed;
    try {
        vehicle.SetThrottle(currentSpeed + v);
    } catch (Exception e) {
        Console.WriteLine("Error " + e.Message);
    }
}