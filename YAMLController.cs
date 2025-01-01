﻿using System.Text.Json;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace CheApp
{
    internal class YAMLController
    {
        public static void createRoomsYamlIfNotExists()
        {
            List<Room> rooms = new List<Room>();

            var serializer = new SerializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .Build();
            var yamlRooms = serializer.Serialize(rooms);

            File.WriteAllText("rooms.yaml", yamlRooms);
        }

        public static List<Room> getListOfRooms()
        {
            if (!File.Exists("rooms.yaml"))
            {
                createRoomsYamlIfNotExists();
            }

            string roomsYAMLString = File.ReadAllText("rooms.yaml");

            var deserializer = new DeserializerBuilder()
            .WithNamingConvention(CamelCaseNamingConvention.Instance)
            .Build();
            
            return deserializer.Deserialize<List<Room>>(roomsYAMLString);
        }

    }
}
