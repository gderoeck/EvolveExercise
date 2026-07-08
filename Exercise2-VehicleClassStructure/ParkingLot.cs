using Exercise2_VehicleClassStructure.AbstractClasses;
using Exercise2_VehicleClassStructure.Interfaces;

namespace Exercise2_VehicleClassStructure
{
    public class ParkingLot : ParkingLocation, IParkingLot
    {
        public int GetOpenSpaces()
        {
            // Retrieve number of open spaces
            TotalSpaces = 20;
            return 20;
        }

        public void UpdateTotalSpaces(int num)
        {
            TotalSpaces += num;
        }
    }
}
