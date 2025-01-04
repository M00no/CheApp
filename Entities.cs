using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CheApp
{
    internal class Entities
    {
        public static List<string> buildings = [];
        public static Dictionary<string, Room> rooms = [];

        public static void init()
        {
            generateRoomsDictionary();
            generateBuildingsList();
        }

        public static dynamic readConfigFile()
        {
            string configFile = "./config.yaml";

            if (!File.Exists(configFile))
            {
                File.WriteAllText(configFile, """
                pricing:
                expenses:
                buildings: []
                rooms: []
                """);
            }

            string config_str = File.ReadAllText(configFile);

            var deserializer = new DeserializerBuilder().Build();
            var config = deserializer.Deserialize<dynamic>(config_str);

            return config;
        }

        public static void writeConfigFile(dynamic config)
        {
            var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();
            string config_str = serializer.Serialize(config);

            File.WriteAllText("./config.yaml", config_str);
        }

        private static string getPrice(dynamic priceConfig, string building, string type, string capacity)
        {
            try
            {
                return priceConfig[building][type][capacity];
            }
            catch (KeyNotFoundException)
            {
                return priceConfig[building][type]["default"];
            }
        }

        private static void generateRoomsDictionary()
        {
            rooms = [];
            dynamic config = readConfigFile();

            foreach (dynamic entry in config["rooms"])
            {
                string building = entry["building"];
                string type = entry["type"];
                string capacity = entry["capacity"];

                entry["price"] = getPrice(config["pricing"], building, type, capacity);
                entry["expense"] = getPrice(config["expenses"], building, type, capacity);
                entry["discount"] = config["discount"];

                rooms.Add(
                    string.Format($"{entry["name"]} {entry["index"]}"),
                    new Room(
                        entry["name"],
                        entry["index"],
                        entry["building"],
                        entry["type"],
                        Convert.ToInt32(entry["volume"]),
                        Convert.ToInt32(entry["capacity"]),
                        Convert.ToInt32(entry["price"]),
                        Convert.ToInt32(entry["expense"]),
                        Convert.ToInt32(entry["discount"])
                    )
                );
            }
        }

        private static void generateBuildingsList()
        {
            buildings = [];
            dynamic config = readConfigFile();

            foreach (dynamic entry in config["buildings"])
            {
                buildings.Add(entry);
            }
        }
    }
}
