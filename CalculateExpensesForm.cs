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
    public partial class CalculateExpensesForm : UserControl
    {
        public CalculateExpensesForm()
        {
            InitializeComponent();
            beginDateTimePicker.MinDate = DateTime.Now;
        }

        private void beginDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            endDateTimePicker.MinDate = beginDateTimePicker.Value;
        }
    }
}
