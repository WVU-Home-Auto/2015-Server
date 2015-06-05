using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableWrapperTesting
{
    class MotionSensor
    {
        public int MotionSensorId { get; set; }
        public int HouseZoneId { get; set; }
        public bool Status { get; set; }
        public double PictureXCoordinate { get; set; }
        public double PictureYCoordinate { get; set; }


        internal string _connectionString = "Data Source=DEVELOPMENT;Initial Catalog=test4_db;Integrated Security=True";

        public void LoadByPrimaryKey(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From MotionSensor Where MotionSensorId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.MotionSensorId = Convert.ToInt32(dt.Rows[0]["MotionSensorId"]);
                            this.HouseZoneId = Convert.ToInt32(dt.Rows[0]["HouseZoneId"]);
                            this.Status = Convert.ToBoolean(dt.Rows[0]["Status"]);
                            this.PictureXCoordinate = Convert.ToDouble(dt.Rows[0]["PictureXCoordinate"]);
                            this.PictureYCoordinate = Convert.ToDouble(dt.Rows[0]["PictureYCoordinate"]);
                        }
                        conn.Close();
                    }
                }
            }
        }

        public void Save()
        {
            if (this.MotionSensorId == 0) // insert
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into MotionSensor " +
                        "(HouseZoneId, Status, PictureXCoordinate, PictureYCoordinate) " +
                        "Values(@HouseZoneId, @Status, @PictureXCoordinate, @PictureYCoordinate) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseZoneId", this.HouseZoneId);
                        cmd.Parameters.AddWithValue("@Status", this.Status);
                        cmd.Parameters.AddWithValue("@PictureXCoordinate", this.PictureXCoordinate);
                        cmd.Parameters.AddWithValue("@PictureYCoordinate", this.PictureYCoordinate);
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
                    using (SqlCommand cmd = new SqlCommand("Update MotionSensor Set " +
                        "HouseZoneId=@HouseZoneId, Status= @Status, " +
                        "PictureXCoordinate=@PictureXCoordinate, PictureYCoordinate=@PictureYCoordinate " +
                        "Where MotionSensorId=@MotionSensorId ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseZoneId", this.HouseZoneId);
                        cmd.Parameters.AddWithValue("@Status", this.Status);
                        cmd.Parameters.AddWithValue("@PictureXCoordinate", this.PictureXCoordinate);
                        cmd.Parameters.AddWithValue("@PictureYCoordinate", this.PictureYCoordinate);
                        cmd.Parameters.AddWithValue("@MotionSensorId", this.MotionSensorId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }
    }
}