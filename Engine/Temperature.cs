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

            return temp.CurrentTemperature;
        }

        // should there be a method to alter the temperature? 

        public void ChangeTemp(int TemperatureSensorId, double change)
        {

            TemperatureSensor temp = new TemperatureSensor();
            temp.LoadByPrimaryKey(TemperatureSensorId);

            double originalTemp = temp.CurrentTemperature;

            if (temp.CurrentTemperature < 0)
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
