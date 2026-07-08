using Exercise2_VehicleClassStructure.Interfaces;

namespace Exercise2_VehicleClassStructure.AbstractClasses
{
    public abstract class Vehicle(IParkingLot parkingLot, IGarage garage)
    {
        private readonly IParkingLot _parkingLot = parkingLot;
        private readonly IGarage _garage = garage;

        public string Make { get; set; } = null!;
        public string Model { get; set; } = null!;
        public int Length { get; set; }
        public int Weight { get; set; }
        public int MaxPassengers { get; set; }

        public virtual void ParkInGarage()
        {
            // Get spot
            if (_garage.GetCompactSpaces() > 0 && Weight < 1500)
            {
                // Park in compact space
                _garage.UpdateCompactSpaces(-1);
                return;
            }

            if (_garage.GetNormalSpaces() > 0)
            {
                _garage.UpdateNormalSpaces(-1);
                return;
            }

            throw new ArgumentException("There are no spaces in the garage to park.");
        }

        public virtual void ParkInLot()
        {
            // Get spot
            if (_parkingLot.GetOpenSpaces() > 0)
            {
                // Park
                _parkingLot.UpdateTotalSpaces(-1);
                return;
            }

            throw new ArgumentException("There are no spaces in the lot to park.");
        }
    }
}
