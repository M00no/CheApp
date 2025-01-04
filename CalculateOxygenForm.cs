using System.Reflection;

namespace CheApp
{
    public partial class CalculateOxygenForm : UserControl
    {
        public CalculateOxygenForm()
        {
            InitializeComponent();
            updateRoomListBox();
        }

        private void updateRoomListBox()
        {
            roomListBox.Items.Clear();
            foreach (KeyValuePair<string, Room> entry in Entities.rooms)
            {
                roomListBox.Items.Add(entry.Key);
            }
        }

        private void calculateOxygenButton_Click(object sender, EventArgs e)
        {
            if (roomListBox.SelectedIndex != -1)
            {
                string? selectedRoom = roomListBox.GetItemText(roomListBox.SelectedItem);
                if (selectedRoom != null)
                {
                    Room chosenRoom = Entities.rooms[selectedRoom];
                    String result = chosenRoom.CalculateUsedOxygen(
                    Convert.ToInt32(howManyPeopleNumeric.Value),
                    Convert.ToInt32(howLongInHoursNumeric.Value));

                    resultValueTextBox.Text = result;
                }
            }
        }

        private void roomListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomListBox.SelectedIndex != -1)
            {
                string? selectedRoom = roomListBox.GetItemText(roomListBox.SelectedItem);
                if (selectedRoom != null)
                {
                    Room chosenRoom = Entities.rooms[selectedRoom];

                    Type myType = chosenRoom.GetType();
                    List<PropertyInfo> properties = new List<PropertyInfo>(myType.GetProperties());

                    List<string> roomAttrs = [];

                    foreach (PropertyInfo prop in properties)
                    {
                        string prop_name = prop.Name;
                        var prop_value = prop.GetValue(chosenRoom, null);
                        roomAttrs.Add(string.Format($"{prop_name}: {prop_value}"));
                    }

                    string roomInfo = string.Join("\n", roomAttrs);

                    roomInfoValueTextBox.Text = roomInfo;
                }
            }
        }

        private void refreshRoomsButton_Click(object sender, EventArgs e)
        {
            updateRoomListBox();
        }
    }
}
