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
    public partial class AuthenticationTester : Form
    {
        public AuthenticationTester()
        {
            InitializeComponent();
        }

        /*
         * Verifies if the user is valid given the login credentials
         */
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (Authentication.ValidUser(UsernameTextbox.Text, PasswordLabel.Text))
            {
                VerificationLabel.Text = "This user is valid!";
            }
            else 
            {
                VerificationLabel.Text = "This user is invalid!";
            }
        }
    }
}
