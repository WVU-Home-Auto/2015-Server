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

        string conn = Globals.connectionString;

        public string getType(int HouseEntranceId)
        {
            HouseEntrance door = new HouseEntrance();
            door.LoadByPrimaryKey(HouseEntranceId);

            if (door.HouseEntranceId == 0 || door.HouseEntranceId < 0 || door.HouseEntranceId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The entrance you are altering is invalid!");

            return door.EntranceType;
        }

        public bool IsDoorOpen(int HouseEntranceId)
        {

            HouseEntrance door = new HouseEntrance();
            door.LoadByPrimaryKey(HouseEntranceId);

            if (door.HouseEntranceId == 0 || door.HouseEntranceId < 0 || door.HouseEntranceId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The entrance you are altering is invalid!");

            return door.Status;
        }

        public void ChangeStatus(int HouseEntranceId, bool value)
        {
            HouseEntrance door = new HouseEntrance();
            door.LoadByPrimaryKey(HouseEntranceId);

            if (door.HouseEntranceId == 0 || door.HouseEntranceId < 0 || door.HouseEntranceId > 40)     // What should the max ID number be to throw exception?
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

        public double GetX(int HouseEntranceId)
        {
            HouseEntrance door = new HouseEntrance();
            door.LoadByPrimaryKey(HouseEntranceId);

            if (door.HouseEntranceId == 0 || door.HouseEntranceId < 0 || door.HouseEntranceId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The entrance you are altering is invalid!");

            return door.PictureXCoordinate;

        }

        public double GetY(int HouseEntranceId)
        {
            HouseEntrance door = new HouseEntrance();
            door.LoadByPrimaryKey(HouseEntranceId);

            if (door.HouseEntranceId == 0 || door.HouseEntranceId < 0 || door.HouseEntranceId > 40)     // What should the max ID number be to throw exception?
                throw new Exception("The entrance you are altering is invalid!");

            return door.PictureYCoordinate;

        }
    }
}
