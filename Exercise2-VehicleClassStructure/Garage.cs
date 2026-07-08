using Exercise2_VehicleClassStructure.AbstractClasses;
using Exercise2_VehicleClassStructure.Interfaces;

namespace Exercise2_VehicleClassStructure
{
    public class Garage : ParkingLocation, IGarage
    {
        public int NumberCompactSpaces { get; set; }
        public int NumberNormalSpaces { get; set; }

        public int GetCompactSpaces()
        {
            // Get and set the number of compact spaces
            NumberCompactSpaces = 10;
            TotalSpaces = NumberNormalSpaces + NumberCompactSpaces;
            return 10;
        }

        public int GetNormalSpaces()
        {
            // Get and set the number of normal spaces
            NumberNormalSpaces = 10;
            TotalSpaces = NumberNormalSpaces + NumberCompactSpaces;
            return 10;
        }

        public void UpdateCompactSpaces(int num)
        {
            NumberCompactSpaces += num;
            TotalSpaces = NumberNormalSpaces + NumberCompactSpaces;
        }

        public void UpdateNormalSpaces(int num)
        {
            NumberNormalSpaces += num;
            TotalSpaces = NumberNormalSpaces + NumberCompactSpaces;
        }
    }
}
