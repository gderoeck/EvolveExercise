namespace Exercise2_VehicleClassStructure
{
    public class Bus : LargeVehicle
    {
        public override void ParkInLot()
        {
            base.ParkInLot();
            // Modify or add to logic.
        }

        // NOTE: Because this class inherits from LargeVehicle, and that class seals the "ParkInGarage" method, 
        // we're unable to override it here. Any attempt to use it will through the ArgumentError.
    }
}
