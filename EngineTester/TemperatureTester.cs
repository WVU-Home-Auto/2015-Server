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
    public partial class TemperatureTester : Form
    {
        public TemperatureTester()
        {
            InitializeComponent();
        }

        //Creates a tester temperature
        private Temperature tester = new Temperature();

        //The temperature sensor ID value
        private int TemperatureSensorID;

        /*
         * Submits the user inputted temperature sensor and gets the current temperature of that sensor
         */
        private void SubmitIDButton_Click(object sender, EventArgs e)
        {
            TemperatureSensorID = Convert.ToInt32(SensorIDTextbox.Text);
            CurrentTemperatureLabel.Text = "Current Temperature: " + tester.CurrentTemp(TemperatureSensorID);
        }

        /*
         * Applies temperature change to the desired sensor
         */
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            tester.ChangeTemp(TemperatureSensorID, Convert.ToDouble(SetTemperatureTextbox.Text));
            CurrentTemperatureLabel.Text = "Current Temperature: " + tester.CurrentTemp(TemperatureSensorID);
        }
    }
}
