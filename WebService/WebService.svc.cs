using Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select WebService.svc or WebService.svc.cs at the Solution Explorer and start debugging.
    public class WebService : IWebService
    {
        public bool TurnLightOn(int houseLightId)
        {
            try
            {
                Lighting bl = new Lighting();
                bl.SwitchLight(houseLightId, true);
                return true;
            }
            catch 
            {
               return false;
            }
            

        }

        public bool TurnLightOff(int houseLightId)
        {
            try
            {
                Lighting bl = new Lighting();
                bl.SwitchLight(houseLightId, false);
                return true;
            }
            catch
            {
                return false;
            }


        }

        public bool IsLightOn(int houseLightId)
        {
            try
            {
                Lighting bl = new Lighting();
                return bl.IsLightOn(houseLightId);
                
            }
            catch
            {
                return false;
            }


        }
        

        //public CompositeType GetDataUsingDataContract(CompositeType composite)
        //{
        //    if (composite == null)
        //    {
        //        throw new ArgumentNullException("composite");
        //    }
        //    if (composite.BoolValue)
        //    {
        //        composite.StringValue += "Suffix";
        //    }
        //    return composite;
        //}
    }
}
