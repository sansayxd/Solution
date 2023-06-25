namespace Vehicles
{
    public class LongRangeVehicle : Vehicle
    {
        public int MealCost { get; set; }
        private const int MealInterval = 6;

        public override string GetImage()
        {
            return base.GetImage() + "Meal cost: " + MealCost;
        }

        public override int GetCost(int distanceInKilometers)
        {
            int tripTime = distanceInKilometers / AvarageSpeed;
            int meals = tripTime / MealInterval;
            int allMealCost = meals * MealCost;

            return allMealCost + base.GetCost(distanceInKilometers);
        }
    }
}
