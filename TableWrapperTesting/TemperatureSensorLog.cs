using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableWrapperTesting
{
    class TemperatureSensorLog
    {
        public int TemperatureSensorLogId { get; set; }
        public int TemperatureSensorId { get; set; }
        public string Event { get; set; }
        public DateTime TimeStamp { get; set; }

        internal string _connectionString = "Data Source=DEVELOPMENT;Initial Catalog=test4_db;Integrated Security=True";

        public void LoadByPrimaryKey(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From TemperatureSensorLog Where TemperatureSensorLogId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.TemperatureSensorLogId = Convert.ToInt32(dt.Rows[0]["TemperatureSensorLogId"]);
                            this.TemperatureSensorId = Convert.ToInt32(dt.Rows[0]["TemperatureSensorId"]);
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
            if (this.TemperatureSensorLogId == 0) // insert
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into TemperatureSensorLog (TemperatureSensorId, Event, TimeStamp) Values(@TemperatureSensorId, @Event, @TimeStamp) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@TemperatureSensorId", this.TemperatureSensorId);
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
                    using (SqlCommand cmd = new SqlCommand("Update TemperatureSensorLog Set TemperatureSensorId=@TemperatureSensorId , Event = @Event, TimeStamp= @TimeStamp Where TemperatureSensorLogId=@TemperatureSensorLogId ", conn))
                    {
                        cmd.Parameters.AddWithValue("@TemperatureSensorId", this.TemperatureSensorId);
                        cmd.Parameters.AddWithValue("@Event", this.Event);
                        cmd.Parameters.AddWithValue("@TimeStamp", this.TimeStamp);
                        cmd.Parameters.AddWithValue("@TemperatureSensorLogId", this.TemperatureSensorLogId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }
    }
}
