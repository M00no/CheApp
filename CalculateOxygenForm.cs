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
            string resultText;
            if (roomListBox.SelectedIndex != -1)
            {
                string? roomName = roomListBox.GetItemText(roomListBox.SelectedItem);
                if (roomName != null)
                {
                    Room room = Entities.rooms[roomName];
                    (float? oxygenUsed, float? oxygenOver, string? error) result = room.calculateOxygen(
                        Convert.ToInt32(howManyPeopleNumeric.Value),
                        Convert.ToInt32(howLongInHoursNumeric.Value)
                    );
                    if (result.error == null)
                    {
                        resultText =
                            $"{result.oxygenUsed}L of oxygen will be used and {result.oxygenOver}L will be over in room {room.Index}";
                    }
                    else
                    {
                        Dictionary<string, string> errors = [];
                        errors.Add("TOO_MANY_PEOPLE", $"There are too many people for room {room.Index}");
                        errors.Add("NOT_ENOUGH_OXYGEN", $"There is not enough oxygen in room {room.Index}");
                        resultText = errors[result.error];
                    }
                    resultValueTextBox.Text = resultText;
                }
            }
            else
            {
                resultValueTextBox.Text = "Choose a room";
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
    }
}
