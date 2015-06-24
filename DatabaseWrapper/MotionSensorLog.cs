using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWrapper
{
    public class MotionSensorLog
    {
        public int MotionSensorLogId { get; set; }
        public int MotionSensorId { get; set; }
        public string Event { get; set; }
        public DateTime TimeStamp { get; set; }


        internal string _connectionString = Globals.connectionString;

        public void LoadByPrimaryKey(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From MotionSensorLog Where MotionSensorLogId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.MotionSensorLogId = Convert.ToInt32(dt.Rows[0]["MotionSensorLogId"]);
                            this.MotionSensorId = Convert.ToInt32(dt.Rows[0]["MotionSensorId"]);
                            this.Event = Convert.ToString(dt.Rows[0]["Event"]);
                            this.TimeStamp = Convert.ToDateTime(dt.Rows[0]["TimeStamp"]);
                        }
                        conn.Close();
                    }
                }
            }
        }

        public void Save()
        {
            if (this.MotionSensorLogId == 0) // insert
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into MotionSensorLog (MotionSensorId, Event, TimeStamp) " +
                        "Values(@MotionSensorId, @Event, @TimeStamp) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@MotionSensorId", this.MotionSensorId);
                        cmd.Parameters.AddWithValue("@Event", this.Event);
                        cmd.Parameters.AddWithValue("@TimeStamp", this.TimeStamp);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
            else // Update
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Update MotionSensorLog Set " +
                        "MotionSensorId=@MotionSensorId, Event= @Event, TimeStamp=@TimeStamp " +
                        "Where MotionSensorLogId=@MotionSensorLogId ", conn))
                    {
                        cmd.Parameters.AddWithValue("@MotionSensorId", this.MotionSensorId);
                        cmd.Parameters.AddWithValue("@Event", this.Event);
                        cmd.Parameters.AddWithValue("@TimeStamp", this.TimeStamp);
                        cmd.Parameters.AddWithValue("@MotionSensorLogId", this.MotionSensorLogId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }
    }
}
