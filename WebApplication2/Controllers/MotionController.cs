using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class MotionController : ApiController
    {
        static bool[] States = new bool[10];
        static double[] XPos = new double[10];
        static double[] YPos = new double[10];

        [HttpGet]
        [ActionName("GetStatus")]
        public bool GetSensorState(int id)
        {
            return (States[id]);
        }

        [HttpGet]
        [ActionName("ChangeStatus")]
        public string SetSensorState(int id, bool state)
        {
            States[id] = state;
            return "Set sensor #" + id + " to " + state;
        }

        [HttpGet]
        [ActionName("ChangeStatus")]
        public string SwitchSensorState(int id)
        {
            States[id] = !States[id];
            return "Set sensor #" + id + " to " + States[id];
        }

        [HttpGet]
        [ActionName("SetSensor")]
        public string SetSensor(int id, bool state)
        {
            States[id] = state;
            return "Set sensor #" + id + " to " + state;
        }

        [HttpGet]
        [ActionName("GetSensorXPos")]
        public double GetXPosistion(int id)
        {
            return XPos[id];
        }

        [HttpGet]
        [ActionName("GetSensorYPos")]
        public double GetYPosistion(int id)
        {
            return YPos[id];
        }
    }
}