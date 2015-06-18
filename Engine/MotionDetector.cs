using DatabaseWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nathan Worked Here


namespace Engine
{
    public class MotionDetector
    {
        public double GetX(int MotionSensorId)
        {
            MotionSensor mot = new MotionSensor();
            mot.LoadByPrimaryKey(MotionSensorId);

            if (mot.MotionSensorId == 0 || mot.MotionSensorId < 0 || mot.MotionSensorId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The motion detector you are attempting to switch is invalid!");

            return mot.PictureXCoordinate;

        }

        public double GetY(int MotionSensorId)
        {
            MotionSensor mot = new MotionSensor();
            mot.LoadByPrimaryKey(MotionSensorId);

            if (mot.MotionSensorId == 0 || mot.MotionSensorId < 0 || mot.MotionSensorId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The motion detector you are attempting to switch is invalid!");

            return mot.PictureYCoordinate;

        }

        public bool IsSensorOn(int MotionSensorId)
        {

            MotionSensor mot = new MotionSensor();
            mot.LoadByPrimaryKey(MotionSensorId);

            if (mot.MotionSensorId == 0 || mot.MotionSensorId < 0 || mot.MotionSensorId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The motion detector you are attempting to switch is invalid!");

            return mot.Status;
        }

        public void ChangeStatus(int MotionSensorId, bool value)
        {
            MotionSensor mot = new MotionSensor();
            mot.LoadByPrimaryKey(MotionSensorId);

            if (mot.MotionSensorId == 0 || mot.MotionSensorId < 0 || mot.MotionSensorId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The motion detector you are attempting to switch is invalid!");

            mot.Status = value;

            mot.Save();

            MotionSensorLog log = new MotionSensorLog();

            log.TimeStamp = DateTime.Now;

            if (value)
            {
                log.Event = "Sensor was activated.";
            }
            else
                log.Event = "Sensor was deactivated";
        }
    }
}
