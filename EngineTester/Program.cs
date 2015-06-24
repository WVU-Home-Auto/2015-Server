using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engine;

namespace EngineTester
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthenticationTester());
            Application.Run(new EntrancesTester());
            Application.Run(new LightingTester());
            Application.Run(new MotionDetectorTester());
            Application.Run(new TemperatureTester());
        }
    }
}
