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
    public partial class MotionDetectorTester : Form
    {
        public MotionDetectorTester()
        {
            InitializeComponent();
        }

        //Constructs a tester motion detector
        private MotionDetector tester = new MotionDetector();

        //The detector ID value
        private int DetectorID;

        /*
         * Submits the user inputted detector ID and gets the X-Coordinate, the Y-Coordinate, and the status of that detector
         */
        private void SubmitIDButton_Click(object sender, EventArgs e)
        {
            DetectorID = Convert.ToInt32(DetectorIDTextbox.Text);
            XLabel.Text = "X-Coordinate: " + Convert.ToString(tester.GetX(DetectorID));
            YLabel.Text = "Y-Coordinate: " + Convert.ToString(tester.GetY(DetectorID));
            if (tester.IsSensorOn(DetectorID))
            {
                StatusLabel.Text = "Status: On";
            }
            else
            {
                StatusLabel.Text = "Status: Off";
            }
        }

        /*
         * Applies status changes to the desired detector
         */
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            tester.ChangeStatus(DetectorID, DetectorOnButton.Checked);

            if (tester.IsSensorOn(DetectorID))
            {
                StatusLabel.Text = "Status: On";
            }
            else
            {
                StatusLabel.Text = "Status: Off";
            }
        }
    }
}
