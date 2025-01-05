using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheApp
{
    internal class Building
    {
        public string Name { get; }
        public Dictionary<string, Room> Rooms { get; }

        public Building(string name)
        {
            Name = name;
        }

        public void addRoom(Room room)
        {
            Rooms.Add(room.Name, room);
        }
    }
}