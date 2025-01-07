using System.Data;
using System.Windows.Forms;

namespace CheApp
{
    public partial class FindReservationForm : UserControl
    {
        public FindReservationForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            updateBuildingComboBox();
            updateFloorComboBox();

            datePicker.MinDate = DateTime.Now;

            timePicker.Format = DateTimePickerFormat.Custom;
            timePicker.CustomFormat = "HH:00";
            timePicker.ShowUpDown = true;
            timePicker.MinDate = DateTime.Parse("8:00");
            timePicker.MaxDate = DateTime.Parse("17:00");
        }

        private void updateBuildingComboBox()
        {
            foreach (KeyValuePair<string, Room> entry in Entities.rooms)
            {
                string building = entry.Value.Building;

                if (chooseBuildingComboBox.FindString(building) == -1)
                {
                    chooseBuildingComboBox.Items.Add(building);
                }
            }
        }

        private void updateFloorComboBox()
        {
            for (int i = 0; i < 3; i++)
            {
                chooseFloorComboBox.Items.Add(i.ToString());
            }
        }

        private void timePicker_ValueChanged(object sender, EventArgs e)
        {
            durationNumeric.Maximum = 18 - timePicker.Value.Hour;
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            Room? suitableRoom;
            if (chooseBuildingComboBox.SelectedIndex != -1 &&
                chooseFloorComboBox.SelectedIndex != -1 &&
                howManyPeopleNumeric.Value > 0)
            {
                string chosenBuilding = chooseBuildingComboBox.Text;
                int chosenFloor = chooseFloorComboBox.SelectedIndex;
                int totalPeople = (int)howManyPeopleNumeric.Value;

                DateOnly beginDate = DateOnly.FromDateTime(datePicker.Value);
                TimeOnly beginTime = TimeOnly.FromDateTime(timePicker.Value);
                DateTime beginReservation = new DateTime(beginDate, beginTime);
                DateTime endReservation = beginReservation.AddHours((int)durationNumeric.Value);

                suitableRoom = findRoom(chosenBuilding, chosenFloor, totalPeople, beginReservation, endReservation);

                if (suitableRoom == null)
                {
                    resultValueTextBox.Text = "There is no suitable room";
                }
                else
                {
                    resultValueTextBox.Text = $"""
                        The suitable room is: {suitableRoom.Name} {suitableRoom.Index}
                        Reservation is made for 
                        """;
                }
            }
            else
            {
                resultValueTextBox.Text = "You can not leave any field empty";
            }
        }

        private Room? findRoom(string building, int floor, int totalPeople, DateTime beginReservation, DateTime endReservation)
        {
            List<Room> suitableRooms = [];

            foreach (KeyValuePair<string, Room> entry in Entities.rooms)
            {
                Room room = entry.Value;
                if (building == room.Building &&
                    floor == room.Floor &&
                    totalPeople <= room.Capacity)
                {
                    suitableRooms.Add(room);
                }
            }

            if (suitableRooms.Count == 0)
            {
                return null;
            }
            else
            {
                foreach(Room suitableRoom in suitableRooms.OrderBy(room => room.Capacity))
                {
                    if (!ReservationController.reservations.Any(reservation => reservation.Room.Index == suitableRoom.Index))
                    {
                        ReservationController.reservations.Add(new Reservation(suitableRoom, beginReservation, endReservation));
                        return suitableRoom;
                    }
                    else
                    {
                        foreach(Reservation reservation in ReservationController.reservations)
                        {
                            if(reservation.Room.Index == suitableRoom.Index &&
                                !doEventsMeet(beginReservation, endReservation, reservation.BeginReservation, reservation.EndReservation))
                            {
                                ReservationController.reservations.Add(new Reservation(suitableRoom, beginReservation, endReservation));
                                return suitableRoom;
                            }
                        }
                    }
                }
                return null;
            }
        }

        private bool doEventsMeet(DateTime event1Begin, DateTime event1End, DateTime event2Begin, DateTime event2End)
        {
            return (event1Begin >= event2Begin && event1Begin < event2End) ||
                   (event1End > event2Begin && event1End <= event2End) ||
                   (event2Begin >= event1Begin && event2Begin < event1End) ||
                   (event2End > event1Begin && event2End <= event1End);
        }
    }
}
