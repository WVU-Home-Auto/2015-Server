using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace EngineTester
{

    public partial class LightingTester : Form
    {
        public LightingTester()
        {
            InitializeComponent();
        }

        //Constructs a tester light
        private Lighting tester = new Lighting();

        //The light ID value
        private int LightID;

        /*
         * Submits the user inputted light ID and gets both the status and wattage of that light
         */
        private void SubmitIDButton_Click(object sender, EventArgs e)
        {

            LightID = Convert.ToInt32(LightIDTextbox.Text);

            if (tester.IsLightOn(LightID))
            {
                StatusLabel.Text = "Status: On";
            }
            else
            {
                StatusLabel.Text = "Status: Off";
            }

            WattageLabel.Text = "Wattage: " + Convert.ToString(tester.ViewWatts(LightID));
        }

        /*
         * Applies status and wattage changes to the desired light
         */
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            tester.SwitchLight(LightID, LightOnButton.Checked);
            tester.ChangeWatts(LightID, Convert.ToDouble(SetWattageTextbox.Text));

            if (tester.IsLightOn(LightID))
            {
                StatusLabel.Text = "Status: On";
            }
            else
            {
                StatusLabel.Text = "Status: Off";
            }

            WattageLabel.Text = "Wattage: " + Convert.ToString(tester.ViewWatts(LightID));
        }
    }
}
