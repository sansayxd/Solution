using Vehicles;

public static class Program
{
    private delegate void func();

    public static void Main()
    {
        //Vehicle vehicle1 = new Vehicle()
        //{
        //    Type = VehicleType.Car,
        //    AvarageSpeed = 70,
        //    CostPerKilometer = 4,
        //    Seats = 4,
        //    OccupiedSeats = 1,
        //};

        //Vehicle vehicle2 = new Vehicle()
        //{
        //    Type = VehicleType.Bus,
        //    AvarageSpeed = 50,
        //    CostPerKilometer = 3,
        //    Seats = 26,
        //    OccupiedSeats = 18,
        //};

        //Vehicle vehicle3 = new Vehicle()
        //{
        //    Type = VehicleType.Motorcycle,
        //    AvarageSpeed = 60,
        //    CostPerKilometer = 2,
        //    Seats = 1,
        //    OccupiedSeats = 0,
        //};

        //Vehicle vehicle4 = new LongRangeVehicle()
        //{
        //    Type = VehicleType.Airplane,
        //    AvarageSpeed = 500,
        //    CostPerKilometer = 2,
        //    Seats = 150,
        //    OccupiedSeats = 112,
        //    MealCost = 150,
        //};

        //Vehicle vehicle5 = new LongRangeVehicle()
        //{
        //    Type = VehicleType.Train,
        //    AvarageSpeed = 90,
        //    CostPerKilometer = 1,
        //    Seats = 300,
        //    OccupiedSeats = 234,
        //    MealCost = 50,
        //};

        //var vehicles = new List<Vehicle>() { vehicle1, vehicle2, vehicle3, vehicle4, vehicle5 };

        //string path = "vehicles.json";
        //VehicleSerializer.SerializeToFile(vehicles.ToArray(), path);


        //Vehicle vehicle1 = new Vehicle() { Seats = 10 };
        //Vehicle vehicle2 = new Vehicle() { Seats = 20 };

        //Console.WriteLine(vehicle1 <= vehicle2);


        Vehicle vehicle = new Vehicle();

        vehicle.AllSeatsOccupied += Foo;
    }

    private static void Foo(Vehicle vehicle)
    {
        Console.WriteLine(vehicle.GetImage());
    }
}