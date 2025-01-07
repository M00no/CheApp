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
                howManyPeopleNumeric.Value > 0 &&
                durationNumeric.Value > 0)
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
                        The suitable room is: {suitableRoom.Name} {suitableRoom.Index}.
                        Reservation is made for you.
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
                    totalPeople <= room.Capacity &&
                    !ReservationController.reservations.Any(
                        reservation => reservation.Room.Index == room.Index &&
                        doReservationsMeet(beginReservation, endReservation, reservation.BeginReservation, reservation.EndReservation)))
                {
                    suitableRooms.Add(room);
                }
            }

            Room? suitableRoom = suitableRooms.OrderBy(room => room.Capacity).FirstOrDefault();
            if (suitableRoom != null)
            {
                ReservationController.reservations.Add(new Reservation(suitableRoom, beginReservation, endReservation, totalPeople));
            }
            return suitableRoom;
        }


        private bool doReservationsMeet(DateTime reservation1Begin, DateTime reservation1End, DateTime reservation2Begin, DateTime reservation2End)
        {
            bool boo = (reservation1Begin >= reservation2Begin && reservation1Begin < reservation2End) ||
                   (reservation1End > reservation2Begin && reservation1End <= reservation2End) ||
                   (reservation2Begin >= reservation1Begin && reservation2Begin < reservation1End) ||
                   (reservation2End > reservation1Begin && reservation2End <= reservation1End);

            string x = "";


            return (reservation1Begin >= reservation2Begin && reservation1Begin < reservation2End) ||
                   (reservation1End > reservation2Begin && reservation1End <= reservation2End) ||
                   (reservation2Begin >= reservation1Begin && reservation2Begin < reservation1End) ||
                   (reservation2End > reservation1Begin && reservation2End <= reservation1End);
        }
    }
}
