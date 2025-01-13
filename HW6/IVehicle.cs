using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryVehicle 
{
    public interface IVehicle
    {
        int CurrentSpeed { get; set; }
        int MaxSpeed { get; set; }

        String Name { get; set; }

        void SetThrottle(int speed);
        void DisplayInfo();

    }

}