using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheApp
{
    internal class Reservation
    {
        public Room Room { get; set; }
        public DateTime BeginReservation { get; set; }
        public DateTime EndReservation { get; set; }
        public int TotalPeople { get; set; }

        public Reservation(Room room, DateTime beginReservation, DateTime endReservation, int totalPeople)
        {
            Room = room;
            BeginReservation = beginReservation;
            EndReservation = endReservation;
            TotalPeople = totalPeople;
        }
    }
}
