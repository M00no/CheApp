using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheApp
{
    public partial class CalculateOxygenMenu : UserControl
    {
        List<Room> rooms = new List<Room>();

        public CalculateOxygenMenu()
        {
            InitializeComponent();

            rooms.Add(new Room("TestRoom", "P", "room", 50, 60));
            rooms.Add(new Room("TestRoom2", "S", "room", 20, 20));
            rooms.Add(new Room("TestRoom3", "P", "room", 30, 40));

            updateRoomListBox();
        }

        private void updateRoomListBox()
        {
            roomListBox.Items.Clear();
            foreach (Room room in rooms)
            {
                roomListBox.Items.Add(room.Name + " " + room.Index);
            }
        }

        private void calculateOxygenButton_Click(object sender, EventArgs e)
        {
            if (roomListBox.SelectedIndex != -1)
            {
                Room chosenRoom = rooms[roomListBox.SelectedIndex];
                String result = chosenRoom.CalculateUsedOxygen(
                    Convert.ToInt32(howManyPeopleNumeric.Value),
                    Convert.ToInt32(howLongInHoursNumeric.Value));

                resultValueTextBox.Text = result;
            }
        }

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomListBox.SelectedIndex != -1)
            {
                Room chosenRoom = rooms[roomListBox.SelectedIndex];

                string roomInfo = $"""
                    Name: {chosenRoom.Name}
                    Index: {chosenRoom.Index}
                    Type: {chosenRoom.Type}
                    Volume: {chosenRoom.Volume}
                    Capacity: {chosenRoom.Capacity}
                    """;

                roomInfoValueTextBox.Text = roomInfo;
            }
        }
    }
}
