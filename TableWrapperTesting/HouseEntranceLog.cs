using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace TableWrapperTesting
{
    class HouseEntranceLog
    {
        public int HouseEntranceLogId { get; set; }
        public int HouseEntranceId { get; set; }
        public string Event { get; set; }
        public DateTime TimeStamp { get; set; }

        internal string _connectionString = "Data Source=DEVELOPMENT;Initial Catalog=test4_db;Integrated Security=True";

        public void LoadByPrimaryKey(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From HouseEntranceLog Where HouseEntranceLogId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.HouseEntranceLogId = Convert.ToInt32(dt.Rows[0]["HouseEntranceLogId"]);
                            this.HouseEntranceId = Convert.ToInt32(dt.Rows[0]["HouseEntranceId"]);
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
            if (this.HouseEntranceLogId == 0) // insert
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into HouseEntranceLog (HouseEntranceId, Event, TimeStamp) Values(@HouseEntranceId, @Event, TimeStamp = @TimeStamp) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseEntranceId", this.HouseEntranceId);
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
                    using (SqlCommand cmd = new SqlCommand("Update HouseEntranceLog Set HouseEntranceId=@HouseEntranceId , Event = @Event , TimeStamp = @TimeStamp Where HouseEntranceLogId=@HouseEntranceLogId ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseEntranceId", this.HouseEntranceId);
                        cmd.Parameters.AddWithValue("@Event", this.Event);
                        cmd.Parameters.AddWithValue("@TimeStamp", this.TimeStamp);
                        cmd.Parameters.AddWithValue("@HouseEntranceLogId", this.HouseEntranceLogId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }

    }
}