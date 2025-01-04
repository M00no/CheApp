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

namespace CheApp
{
    public partial class SettingsForm : UserControl
    {
        public SettingsForm()
        {
            InitializeComponent();
            updatBuildingListBox();
        }

        private void updatBuildingListBox()
        {
            buildingsListBox.Items.Clear();
            foreach (String building in Entities.buildings)
            {
                buildingsListBox.Items.Add(building);
            }
        }

        private void addBuildingButton_Click(object sender, EventArgs e)
        {

        }

        private void buildingsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void deleteBuildingButton_Click(object sender, EventArgs e)
        {
            string? selectedBuilding = buildingsListBox.GetItemText(buildingsListBox.SelectedItem);
            if(selectedBuilding != null)
            {
                Entities.buildings.Remove(selectedBuilding);

                dynamic config = Entities.readConfigFile();
                config["buildings"] = Entities.buildings;
                Entities.writeConfigFile(config);

                updatBuildingListBox();
            } 
        }
    }
}
