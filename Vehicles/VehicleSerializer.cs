using Newtonsoft.Json;

namespace Vehicles
{
    public static class VehicleSerializer
    {
        private static JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All,
        };

        public static string Serialize(Vehicle vehicle)
        {
            return JsonConvert.SerializeObject(vehicle, _settings);
        }
        
        public static Vehicle Deserialize(string text)
        {
            return JsonConvert.DeserializeObject<Vehicle>(text, _settings) ?? throw new Exception("Deserialization failed");
        }        

        public static void SerializeToFile(Vehicle[] vehicles, string path)
        {
            string[] strings = new string[vehicles.Length];

            for (int i = 0; i < vehicles.Length; i++)
                strings[i] = Serialize(vehicles[i]);

            File.WriteAllLines(path, strings);
        }

        public static Vehicle[] DeserializeFromFile(string path)
        {
            string[] strings = File.ReadAllLines(path);

            Vehicle[] vehicles = new Vehicle[strings.Length];
            
            for (int i = 0; i < strings.Length; i++)
                vehicles[i] = Deserialize(strings[i]);

            return vehicles;
        }
    }
}