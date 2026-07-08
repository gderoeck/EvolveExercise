using Exercise2_VehicleClassStructure.AbstractClasses;

namespace Exercise2_VehicleClassStructure
{
    public class LargeVehicle : Vehicle
    {
        public sealed override void ParkInGarage()
        {
            throw new ArgumentException("Large vehicles cannot park in the garage");
        }
    }
}
