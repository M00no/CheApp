using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace CheApp
{
    public partial class ViewPort : Form
    {
        public ViewPort()
        {
            YAMLController.createRoomsYamlIfNotExists();

            InitializeComponent();
        }

        private void calculateOxygenButton_Click(object sender, EventArgs e)
        {
            calculateOxygenMenu1.Show();
        }
    }
}
