using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheApp
{
    public partial class CalculatePriceAndExpensesForm : UserControl
    {
        public CalculatePriceAndExpensesForm()
        {
            InitializeComponent();
            init();
            updateRoomsListBox();
        }

        private void init()
        {
            beginDatePicker.MinDate = DateTime.Now;

            beginTimePicker.Format = DateTimePickerFormat.Custom;
            beginTimePicker.CustomFormat = "HH:00";
            beginTimePicker.ShowUpDown = true;
            beginTimePicker.MinDate = DateTime.Parse("8:00");
            beginTimePicker.MaxDate = DateTime.Parse("17:00");
            beginTimePicker.Value = DateTime.Parse("8:00");


            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "HH:00";
            endTimePicker.ShowUpDown = true;
            endTimePicker.MinDate = beginTimePicker.Value.AddHours(1);
            endTimePicker.MaxDate = DateTime.Parse("18:00");
            endTimePicker.Value = DateTime.Parse("10:00");
        }

        private void updateRoomsListBox()
        {
            roomsListBox.Items.Clear();
            foreach (KeyValuePair<string, Room> entry in Entities.rooms)
            {
                roomsListBox.Items.Add(entry.Key);
            }
        }

        private void beginDatePicker_ValueChanged(object sender, EventArgs e)
        {
            endDatePicker.MinDate = beginDatePicker.Value;
        }
        private void beginTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endTimePicker.MinDate = beginTimePicker.Value.AddHours(1);
        }

        private void roomsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (roomsListBox.SelectedIndex != -1)
            {
                string? selectedRoom = roomsListBox.GetItemText(roomsListBox.SelectedItem);
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
        private void calculateButton_Click(object sender, EventArgs e)
        {
            if (roomsListBox.SelectedIndex != -1)
            {
                DateOnly beginDate = DateOnly.FromDateTime(beginDatePicker.Value);
                DateOnly endDate = DateOnly.FromDateTime(endDatePicker.Value);
                TimeOnly beginTime = TimeOnly.FromDateTime(beginTimePicker.Value);
                TimeOnly endTime = TimeOnly.FromDateTime(endTimePicker.Value);

                string? selectedRoom = roomsListBox.GetItemText(roomsListBox.SelectedItem);
                if (selectedRoom != null)
                {
                    Room chosenRoom = Entities.rooms[selectedRoom];
                    float price = chosenRoom.calculatePrice(beginDate, endDate, beginTime, endTime);
                    float expenses = chosenRoom.calculateExpenses(beginDate, endDate, beginTime, endTime);

                    resultValueTextBox.Text = $"""
                    For rent request from {beginDate} to {endDate}
                    and with time from {beginTime} to {endTime} each day:
                    Price is {price} and Expenses are {expenses}
                    """;
                }
            }
            else
            {
                resultValueTextBox.Text = "Choose a room";
            }
        }
    }
}
