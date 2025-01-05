using System.Windows.Forms;
using YamlDotNet.Serialization;

namespace CheApp
{
    internal class Entities
    {
        public static Dictionary<string, Room> rooms = [];

        public static void init()
        {
            generateRoomList();
        }

        public static string getPrice(dynamic priceConfig, string building, string type, string capacity)
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

        public static void generateRoomList()
        {
            rooms = [];

            string config_file = "./config.yaml";

            if (!File.Exists(config_file))
            {
                File.WriteAllText(config_file, """
                pricing:
                expenses:
                rooms: []
                """);
            }

            string config_str = File.ReadAllText(config_file);

            var deserializer = new DeserializerBuilder().Build();
            var config = deserializer.Deserialize<dynamic>(config_str);

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
    }
}
