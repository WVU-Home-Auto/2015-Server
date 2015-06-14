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

            return mot.PictureXCoordinate;

        }

        public double GetY(int MotionSensorId)
        {
            MotionSensor mot = new MotionSensor();
            mot.LoadByPrimaryKey(MotionSensorId);

            return mot.PictureYCoordinate;

        }

        public bool IsSensorOn(int MotionSensorId)
        {

            MotionSensor mot = new MotionSensor();
            mot.LoadByPrimaryKey(MotionSensorId);

            return mot.Status;
        }

        public void ChangeStatus(int MotionSensorId, bool value)
        {
            MotionSensor mot = new MotionSensor();
            mot.LoadByPrimaryKey(MotionSensorId);

            if (mot.MotionSensorId == 0 || mot.MotionSensorId < 0)
                throw new Exception("The Motion sensor you are altering is invalid!");

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
