using Exercise2_VehicleClassStructure.Interfaces;

namespace Exercise2_VehicleClassStructure
{
    public class Bus(IParkingLot parkingLot, IGarage garage) : LargeVehicle(parkingLot, garage)
    {
        private readonly IParkingLot _parkingLot = parkingLot;

        public override void ParkInLot()
        {
            base.ParkInLot();
            // Modify or add to logic.
        }

        // NOTE: Because this class inherits from LargeVehicle, and that class seals the "ParkInGarage" method, 
        // we're preventing the ability to override it here. Any attempt to use it will throw the ArgumentError.
    }
}
