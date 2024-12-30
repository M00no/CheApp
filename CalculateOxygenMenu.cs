namespace CheApp
{
    public partial class CalculateOxygenMenu : UserControl
    {
        public CalculateOxygenMenu()
        {
            InitializeComponent();
            updateRoomListBox();
        }

        private void updateRoomListBox()
        {
            roomListBox.Items.Clear();
            foreach (Room room in YAMLController.getListOfRooms())
            {
                roomListBox.Items.Add(room.Name + " " + room.Index);
            }
        }

        private void calculateOxygenButton_Click(object sender, EventArgs e)
        {
            if (roomListBox.SelectedIndex != -1)
            {
                Room chosenRoom = YAMLController.getListOfRooms()[roomListBox.SelectedIndex];
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
                Room chosenRoom = YAMLController.getListOfRooms()[roomListBox.SelectedIndex];

                string roomInfo = $"""
                    Name: {chosenRoom.Name}
                    Index: {chosenRoom.Index}
                    Building: {chosenRoom.Building}
                    Type: {chosenRoom.Type}
                    Volume: {chosenRoom.Volume}
                    Capacity: {chosenRoom.Capacity}
                    """;

                roomInfoValueTextBox.Text = roomInfo;
            }
        }
    }
}
