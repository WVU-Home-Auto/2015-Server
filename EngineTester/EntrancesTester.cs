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
    public partial class EntrancesTester : Form
    {
        public EntrancesTester()
        {
            InitializeComponent();
        }

        //Constructs a tester house entrance
        private Entrances tester = new Entrances();

        //The house entrance ID value
        private int EntranceID;

        /*
         * Submits the user inputted house entrance ID and gets the type, X-Coordinate, Y-Coordinate, and status of that house entrance
         */
        private void SubmitIDButton_Click(object sender, EventArgs e)
        {
            EntranceID = Convert.ToInt32(EntranceIDTextbox.Text);
            TypeLabel.Text = "Type: " + tester.getType(EntranceID);
            XLabel.Text = "X-Coordinate: " + Convert.ToString(tester.GetX(EntranceID));
            YLabel.Text = "Y-Coordinate: " + Convert.ToString(tester.GetY(EntranceID));
            if (tester.IsDoorOpen(EntranceID))
            {
                StatusLabel.Text = "Status: Open";
            }
            else
            {
                StatusLabel.Text = "Status: Closed";
            }
        }

        /*
         * Applies status change to the desired house entrance
         */
        private void ApplyButton_Click(object sender, EventArgs e)
        {
            tester.ChangeStatus(EntranceID, DoorOpenButton.Checked);
            if (tester.IsDoorOpen(EntranceID))
            {
                StatusLabel.Text = "Status: Open";
            }
            else
            {
                StatusLabel.Text = "Status: Closed";
            }
        }
    }
}
