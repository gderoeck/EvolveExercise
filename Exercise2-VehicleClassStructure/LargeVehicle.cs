using Exercise2_VehicleClassStructure.AbstractClasses;
using Exercise2_VehicleClassStructure.Interfaces;

namespace Exercise2_VehicleClassStructure
{
    public class LargeVehicle(IParkingLot parkingLot, IGarage garage) : Vehicle(parkingLot, garage)
    {
        public sealed override void ParkInGarage()
        {
            throw new ArgumentException("Large vehicles cannot park in the garage");
        }
    }
}
