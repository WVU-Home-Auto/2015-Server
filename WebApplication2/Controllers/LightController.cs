using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class LightController : ApiController
    {
        static bool[] States = new bool[10];

        [HttpGet]
        [ActionName("GetState")]
        public bool GetLightState(int id){
            return (States[id]);
        }

        [HttpGet]
        [ActionName("Switch")]
        public string SetLightState(int id, bool state)
        {
            States[id] = state;
            return "Set light #" + id + " to " + state;
        }

        [HttpGet]
        [ActionName("Switch")]
        public string SwitchLightState(int id)
        {
            States[id] = !States[id];
            return "Set light #" + id + " to " + States[id];
        }
    }
}
