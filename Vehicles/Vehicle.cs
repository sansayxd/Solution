namespace Vehicles
{
    public class Vehicle : IComparable
    {
        public event Action<Vehicle>? AllSeatsOccupied;

        private int _occupiedSeats = 0;

        public VehicleType Type { get; set; } = VehicleType.None;
        public int AvarageSpeed { get; set; } = 0;
        public int CostPerKilometer { get; set; } = 0;
        public int Seats { get; set; } = 0;
        public int OccupiedSeats
        {
            get { return _occupiedSeats; }
            set
            {
                _occupiedSeats = value;
                if (_occupiedSeats >= Seats)
                    AllSeatsOccupied?.Invoke(this);
            }
        }

        public virtual string GetImage()
        {
            //return "Vehicle type: " + Type.ToString() + "; PassengerSeats: " + 

            return $"Vehicle type: {Type}; Avarage speed: {AvarageSpeed}; Cost per kilometer {CostPerKilometer}; Passenger seats {Seats}; OccupiedSeats {OccupiedSeats}; ";
        }

        public virtual int GetCost(int distanceInKilometers)
        {
            if (distanceInKilometers < 0)
                return 0;

            return distanceInKilometers * CostPerKilometer;
        }

        public int CompareTo(object? obj)
        {
            Vehicle? other = obj as Vehicle;

            if (other is null)
                throw new Exception();

            return Seats.CompareTo(other.Seats);
        }

        public static bool operator> (Vehicle vehicle1, Vehicle vehicle2)
        {
            return vehicle1.CompareTo(vehicle2) > 0;
        }

        public static bool operator>= (Vehicle vehicle1, Vehicle vehicle2)
        {
            return vehicle1.CompareTo(vehicle2) >= 0;
        }

        public static bool operator< (Vehicle vehicle1, Vehicle vehicle2)
        {
            return vehicle1.CompareTo(vehicle2) < 0;
        }

        public static bool operator<= (Vehicle vehicle1, Vehicle vehicle2)
        {
            return vehicle1.CompareTo(vehicle2) <= 0;
        }

        public static bool operator== (Vehicle vehicle1, Vehicle vehicle2)
        {
            return vehicle1.CompareTo(vehicle2) == 0;
        }

        public static bool operator!= (Vehicle vehicle1, Vehicle vehicle2)
        {
            return vehicle1.CompareTo(vehicle2) != 0;
        }
    }
}