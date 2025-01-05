using System.Configuration;
using System.Windows.Forms;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CheApp
{
    internal class Config
    {
        private static Config _instance;

        private string configFile = "../../../config/config.yaml";

        public Dictionary<string, Building> Buildings { get; }

        private Config()
        {
            dynamic config = readConfigFile();
            Buildings = getBuildings(config);
        }

        public static Config Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Config();
                }
                return _instance;
            }
        }

        private dynamic readConfigFile()
        {
            if (File.Exists(configFile))
            {
                string config_str = File.ReadAllText(configFile);

                var deserializer = new DeserializerBuilder().Build();
                return deserializer.Deserialize<dynamic>(config_str);
            }
            else
            {
                return new { };
            }
        }

        public void writeConfigFile()
        {
            var serializer = new SerializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();
            //string config_str = serializer.Serialize(config);

            //File.WriteAllText("./config.yaml", config_str);
        }

        private Dictionary<string, Building> getBuildings(dynamic config)
        {
            Dictionary<string, Building> buildings = [];

            foreach (KeyValuePair<string, dynamic> buildingAttrs in config["buildings"])
            {
                Building building = new Building(buildingAttrs.Key);

                foreach (dynamic roomAttrs in buildingAttrs.Value["rooms"])
                {
                    Room room = getRoom(building, roomAttrs.Value);
                    building.addRoom(room);
                }

                buildings.Add(buildingAttrs.Key, building);
            }

            return buildings;
        }

        private Room getRoom(Building building, dynamic roomConfig)
        {
            //string building = entry["building"];
            //string type = entry["type"];
            //string capacity = entry["capacity"];

            //entry["price"] = getPrice(config["pricing"], building, type, capacity);
            //entry["expense"] = getPrice(config["expenses"], building, type, capacity);
            //entry["discount"] = config["discount"];

            return new Room(
                roomConfig["name"],
                roomConfig["index"],
                roomConfig["building"],
                roomConfig["type"],
                Convert.ToInt32(roomConfig["volume"]),
                Convert.ToInt32(roomConfig["capacity"]),
                //Convert.ToInt32(roomConfig["price"]),
                //Convert.ToInt32(roomConfig["expense"]),
                //Convert.ToInt32(roomConfig["discount"])
                0, 0, 0
            );
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
    }
}
