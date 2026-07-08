namespace Exercise2_VehicleClassStructure.Interfaces
{
    public interface IGarage
    {
        int GetCompactSpaces();
        int GetNormalSpaces();
        void UpdateCompactSpaces(int num);
        void UpdateNormalSpaces(int num);
    }
}
