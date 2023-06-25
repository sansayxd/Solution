using System.Linq;
using Vehicles;

public static class Program
{
    private static List<Vehicle> _vehicles = new List<Vehicle>();

    public static void Main()
    {
        AddVehiclesFromFile("indata.txt");

        //Демонстрація взаємодії об'єктів через подію
        foreach (var vehicle in _vehicles)
        {
            vehicle.AllSeatsOccupied += delegate { Console.WriteLine("All seats on this vehicle are occupied"); };
            vehicle.OccupiedSeats = vehicle.Seats;
        }

        AddVehicleFromConsole();
        SaveToFile("outdata.txt");

        Console.WriteLine("Vehicles: ");
        PrintVehicles();

        Console.WriteLine("Largest vehicle: ");
        PrintLargest();

        Console.WriteLine("Cheapest vehicle: ");
        PrintCheapest(1000);

        foreach (var vehicle in _vehicles)
        {
            PrintType(vehicle);
        }

        IncreaseCost(20);
        PrintVehicles();
    }

    public static void SaveToFile(string filePath)
    {
        VehicleSerializer.SerializeToFile(_vehicles.ToArray(), filePath);
    }

    public static void AddVehiclesFromFile(string filePath)
    {
        _vehicles.AddRange(VehicleSerializer.DeserializeFromFile(filePath));
    }

    public static void AddVehicleFromConsole()
    {
        int distanceRange = ReadInt("Choose distance range: 1. Short | 2. Long", 1, 2);
        int type = ReadInt("Choose type: 1. Car | 2. Bus | 3. Motorcycle | 4. Airplane | 5. Train", 1, 5);
        int avarageSpeed = ReadInt("Avarage speed: ", 1 , int.MaxValue);
        int costPerKilometer = ReadInt("Cost per minute: ", 0, int.MaxValue);
        int seats = ReadInt("Seats: ", 0, int.MaxValue);
        int occupiedSeats = ReadInt("Occupied seats: ", 0, seats);

        Vehicle vehicle;

        if (distanceRange == 1)
        {
            vehicle = new Vehicle
            {
                AvarageSpeed = avarageSpeed,
                CostPerKilometer = costPerKilometer,
                OccupiedSeats = occupiedSeats,
                Seats = seats,
                Type = (VehicleType)(type),
            };
        }
        else
        {
            int mealCost = ReadInt("Meal cost: ", 0, int.MaxValue);
            vehicle = new LongRangeVehicle
            {
                AvarageSpeed = avarageSpeed,
                CostPerKilometer = costPerKilometer,
                OccupiedSeats = occupiedSeats,
                Seats = seats,
                Type = (VehicleType)(type - 1),
                MealCost = mealCost,
            };
        }

        _vehicles.Add(vehicle);
    }

    public static void PrintVehicles()
    {
        foreach (Vehicle vehicle in _vehicles)
            Console.WriteLine(vehicle.GetImage());
    }

    public static void PrintLargest()
    {
        Console.WriteLine(_vehicles.Max()?.GetImage());
    }

    public static void PrintCheapest(int distanceInKilometers)
    {
        Console.WriteLine(_vehicles.MinBy(x => x.GetCost(distanceInKilometers))?.GetImage());
    }

    public static void PrintType(Vehicle vehicle)
    {
        Console.WriteLine(vehicle.GetType());
    }

    public static void IncreaseCost(int percent)
    {
        foreach (var vehicle in _vehicles)
        {
            vehicle.IncreaseCost(percent);
        }
    }

    private static int ReadInt(int min, int max)
    {
        int value;
        bool parsed = false;
        do
        {
            parsed = int.TryParse(Console.ReadLine(), out value);
        }
        while (parsed == false || value < min || value > max);

        return value;
    }

    private static int ReadInt(string message, int min, int max)
    {
        Console.WriteLine(message);
        return ReadInt(min, max);
    }
}