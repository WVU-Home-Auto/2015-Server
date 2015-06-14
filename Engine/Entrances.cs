using DatabaseWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Entrances
    {

        public string getType(int HouseEntranceId)
        {
            HouseEntrance door = new HouseEntrance();
            door.LoadByPrimaryKey(HouseEntranceId);

            return door.EntranceType;
        }

        public bool IsDoorOpen(int HouseEntranceId)
        {

            HouseEntrance door = new HouseEntrance();
            door.LoadByPrimaryKey(HouseEntranceId);

            return door.Status;
        }

        public void ChangeStatus(int HouseEntranceId, bool value)
        {
            HouseEntrance door = new HouseEntrance();
            door.LoadByPrimaryKey(HouseEntranceId);

            if (door.HouseEntranceId == 0)
                throw new Exception("The entrance you are altering is invalid!");

            door.Status = value;

            door.Save();

            HouseEntranceLog log = new HouseEntranceLog();

            log.TimeStamp = DateTime.Now;

            if (value)
            {
                log.Event = "Entrance was opened.";
            }
            else
                log.Event = "Entrance was closed";
        }
    }
}
