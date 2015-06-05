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
       
    }
}
