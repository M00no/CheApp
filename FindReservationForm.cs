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
    public partial class FindReservationForm : UserControl
    {
        public FindReservationForm()
        {
            InitializeComponent();
            updateBuildingComboBox();
            updateFloorComboBox();
        }

        private void updateBuildingComboBox()
        {
            foreach(KeyValuePair<string, Room> entry in Entities.rooms)
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
            for(int i = 0; i < 3; i++)
            {
                chooseFloorComboBox.Items.Add(i.ToString());
            }
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

                suitableRoom = findRoom(chosenBuilding, chosenFloor, totalPeople);

                if(suitableRoom == null)
                {
                    resultValueTextBox.Text = "There is no suitable room";
                }
                else
                {
                    resultValueTextBox.Text = $"The suitable room is: {suitableRoom.Name} {suitableRoom.Index}";
                }
            }
            else
            {
                resultValueTextBox.Text = "You can not leave any field empty";
            }
        }

        private Room? findRoom(string building, int floor, int totalPeople)
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

            if(suitableRooms.Count == 0)
            {
                return null;
            } 
            else
            {
                return suitableRooms.OrderBy(room => room.Capacity).FirstOrDefault();
            }
        }
    }
}
