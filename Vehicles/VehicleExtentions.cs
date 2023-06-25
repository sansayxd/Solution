namespace Vehicles
{
    public static class VehicleExtentions
    {
        public static void IncreaseCost(this Vehicle vehicle, int percent)
        {
            int newCost = vehicle.CostPerKilometer * (percent + 100) / 100;
            vehicle.CostPerKilometer = newCost;
        }
    }
}