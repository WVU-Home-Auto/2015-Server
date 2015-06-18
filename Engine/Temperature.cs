using DatabaseWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Nathan's Work


namespace Engine
{
    public class Temperature 
    {
        public double CurrentTemp(int TemperatureSensorId)
        {
            TemperatureSensor temp = new TemperatureSensor();
            temp.LoadByPrimaryKey(TemperatureSensorId);

            if (temp.TemperatureSensorId == 0 || temp.TemperatureSensorId < 0 || temp.TemperatureSensorId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The sensor you are attempting to switch is invalid!");

            return temp.CurrentTemperature;

        }

        // should there be a method to alter the temperature? 

        public void ChangeTemp(int TemperatureSensorId, double change)
        {

            TemperatureSensor temp = new TemperatureSensor();
            temp.LoadByPrimaryKey(TemperatureSensorId);

            if (temp.TemperatureSensorId == 0 || temp.TemperatureSensorId < 0 || temp.TemperatureSensorId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The sensor you are attempting to switch is invalid!");

            double originalTemp = temp.CurrentTemperature;

            if (temp.CurrentTemperature < 0 || temp.CurrentTemperature > 100)
                throw new Exception("The temperature is invalid!");

            // Should the temperature have a maximum and minimum amount? ************
            // And if so, what should they be? ***********

            temp.CurrentTemperature = change;
            temp.Save();

            TemperatureSensorLog log = new TemperatureSensorLog();
            log.TimeStamp = DateTime.Now;

            log.Event = "Temperature was changed to " + change + " from " + originalTemp;
        }
    }
}
