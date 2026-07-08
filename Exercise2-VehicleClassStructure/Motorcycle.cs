using Exercise2_VehicleClassStructure.AbstractClasses;
using Exercise2_VehicleClassStructure.Interfaces;

namespace Exercise2_VehicleClassStructure
{
    public class Motorcycle(IParkingLot parkingLot, IGarage garage) : Vehicle(parkingLot, garage)
    {
        public override void ParkInGarage()
        {
            base.ParkInGarage();
        }

        public override void ParkInLot()
        {
            base.ParkInLot();
        }
    }
}
