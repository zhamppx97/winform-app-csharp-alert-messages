using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlertBox
{
    public partial class Tests : Form
    {
        readonly Alert _alert = new Alert();

        public Tests()
        {
            InitializeComponent();
        }

        private void ButtonSuccess_Click(object sender, EventArgs e)
        {
            _alert.Show("Success!", Alert.AlertType.Success);
        }

        private void ButtonInfo_Click(object sender, EventArgs e)
        {
            _alert.Show("Info!", Alert.AlertType.Info);
        }

        private void ButtonWarning_Click(object sender, EventArgs e)
        {
            _alert.Show("Warning!", Alert.AlertType.Warning);
        }

        private void ButtonError_Click(object sender, EventArgs e)
        {
            _alert.Show("Error!", Alert.AlertType.Error);
        }
    }
}
