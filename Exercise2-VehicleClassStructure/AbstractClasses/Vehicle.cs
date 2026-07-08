namespace Exercise2_VehicleClassStructure.AbstractClasses
{
    public abstract class Vehicle
    {
        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Length { get; set; }
        public int Weight { get; set; }
        public int MaxPassengers { get; set; }

        public virtual void ParkInLot()
        {
            // Functionality for updating/inserting a vehicle in the Parking lot
        }

        public virtual void ParkInGarage(string spotType)
        {
            // Functionality for updating/inserting a vehicle in the Garage
        }
    }


}
