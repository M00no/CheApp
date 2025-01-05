using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;
using YamlDotNet.Core;
using System.Configuration;

namespace CheApp
{
    public partial class SettingsForm : UserControl
    {
        public SettingsForm()
        {
            InitializeComponent();
            updateBuildingsListBox();
        }

        private void updateBuildingsListBox()
        {
            buildingsListBox.Items.Clear();
            Config config = Config.Instance;
            foreach (KeyValuePair<string, Building> building in config.Buildings)
            {
                buildingsListBox.Items.Add(building.Value.Name);
            }
        }

        private void updateRoomsListBox()
        {
            //roomsListBox.Items.Clear();
            //foreach (KeyValuePair<string, Room> entry in Config.rooms)
            //{
            //    roomsListBox.Items.Add(entry.Key);
            //}
        }

        private void addBuildingButton_Click(object sender, EventArgs e)
        {

        }

        private void buildingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteBuildingButton_Click(object sender, EventArgs e)
        {
            //string? selectedBuilding = buildingsListBox.GetItemText(buildingsListBox.SelectedItem);
            //if(selectedBuilding != null)
            //{
            //    Config.buildings.Remove(selectedBuilding);

            //    dynamic config = Config.readConfigFile();
            //    config["buildings"] = Config.buildings;
            //    Config.writeConfigFile(config);

            //    updateBuildingsListBox();
            //} 
        }
    }
}
