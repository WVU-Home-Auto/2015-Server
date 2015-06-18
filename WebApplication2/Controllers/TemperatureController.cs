using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class TemperatureController : ApiController
    {
        static double[] States = new double[10];

        [HttpGet]
        [ActionName("GetTemperature")]
        public double GetTemperature(int id)
        {
            return (States[id]);
        }

        [HttpGet]
        [ActionName("ChangeTemperature")]
        public string SetLightState(int id, double temp)
        {
            States[id] = temp;
            return "Set light #" + id + " to " + temp;
        }

    }
}
