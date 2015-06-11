using DatabaseWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Lighting
    {
        public void SwitchLight(int houseLightId, bool value)
        {

            HouseLight light = new HouseLight();
            light.LoadByPrimaryKey(houseLightId);
            if (light.HouseLightId == 0)
                throw new Exception("The light you are attempting to switch is invalid!");

            light.LightSet = value;
            light.Save();

            HouseLightLog log = new HouseLightLog();
            log.TimeStamp = DateTime.Now;
            if (value)
                log.Event = "Light was switched On";
            else
                log.Event = "Light was switched off";
            log.Save();

            // Physically switch light on

        }

        public bool IsLightOn(int houseLightId)
        {

            HouseLight light = new HouseLight();
            light.LoadByPrimaryKey(houseLightId);

            return light.LightSet;
        }


        // Nathan Started Here...

        // wattage

        public double ViewWatts(int houseLightId)
        {

            HouseLight light = new HouseLight();
            light.LoadByPrimaryKey(houseLightId);

            return light.Wattage;
        }

        // change wattage

        public void ChangeWatts(int houseLightId, double change)
        {

            HouseLight light = new HouseLight();
            light.LoadByPrimaryKey(houseLightId);

            double originalWatts = light.Wattage;

            if (light.Wattage < 0)
                throw new Exception("The wattage amount is invalid!");

            // Should the wattage have a maximum amount? ************
      
            light.Wattage = change;
            light.Save();

            HouseLightLog log = new HouseLightLog();
            log.TimeStamp = DateTime.Now;

            log.Event = "Wattage was changed to " + change + " from " + originalWatts;
        }
       

  
            // Should we implement something to maybe change the Zone ID of the light? 
    }
}
