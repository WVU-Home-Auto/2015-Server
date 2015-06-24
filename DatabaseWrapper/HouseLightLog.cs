using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseWrapper
{
    public class HouseLightLog
    {
        public int HouseLightLogId { get; set; }
        public int HouseLightId { get; set; }
        public string Event { get; set; }
        public DateTime TimeStamp { get; set; }

        internal string _connectionString = Globals.connectionString;

        public void LoadByPrimaryKey(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From HouseLightLog Where HouseLightLogId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.HouseLightLogId = Convert.ToInt32(dt.Rows[0]["HouseLightLogId"]);
                            this.HouseLightId = Convert.ToInt32(dt.Rows[0]["HouseLightId"]);
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
            if (this.HouseLightId == 0) // insert
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into HouseLightLog (HouseLightId, Event, TimeStamp) Values(@HouseLightId, @Event, @TimeStamp) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseLightId", this.HouseLightId);
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
                    using (SqlCommand cmd = new SqlCommand("Update HouseLightLog Set HouseLightId=@HouseLightId , Event = @Event, TimeStamp= @TimeStamp Where HouseLightLogId=@HouseLightLogId ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseLightId", this.HouseLightId);
                        cmd.Parameters.AddWithValue("@Event", this.Event);
                        cmd.Parameters.AddWithValue("@TimeStamp", this.TimeStamp);
                        cmd.Parameters.AddWithValue("@HouseLightLogId", this.HouseLightLogId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }

    }
}
