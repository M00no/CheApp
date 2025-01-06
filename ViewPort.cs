using YamlDotNet.Serialization.NamingConventions;
using YamlDotNet.Serialization;

namespace CheApp
{
    public partial class ViewPort : Form
    {
        public ViewPort()
        {
            InitializeComponent();
        }

        private void calculateOxygenButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(oxygenTab);
        }

        private void calculatePriceAndExpensesButton_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(priceAndExpensesTab);
        }
    }
}
