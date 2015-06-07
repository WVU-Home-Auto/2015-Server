using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DatabaseWrapper
{
    public class HouseEntrance
    {
        public int HouseEntranceId { get; set; }
        public int HouseZoneId { get; set; }
        public string EntranceType { get; set; }
        public Boolean Status { get; set; }
        public double PictureXCoordinate { get; set; }
        public double PictureYCoordinate { get; set; }


        internal string _connectionString = "Data Source=DEVELOPMENT;Initial Catalog=test4_db;Integrated Security=True";

        public void LoadByPrimaryKey(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From HouseEntrance Where HouseEntranceId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.HouseEntranceId = Convert.ToInt32(dt.Rows[0]["HouseEntranceId"]);
                            this.HouseZoneId = Convert.ToInt32(dt.Rows[0]["HouseZoneId"]);
                            this.EntranceType = Convert.ToString(dt.Rows[0]["EntranceType"]);
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
            if (this.HouseEntranceId == 0) // insert
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into HouseEntrance " +
                        "(HouseZoneId, EntranceType, Status, PictureXCoordinate, PictureYCoordinate) " +
                        "Values(@HouseZoneId, @EntranceType, @Status, @PictureXCoordinate, @PictureYCoordinate) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseZoneId", this.HouseZoneId);
                        cmd.Parameters.AddWithValue("@EntranceType", this.EntranceType);
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
                    using (SqlCommand cmd = new SqlCommand("Update HouseEntrance Set " +
                        "HouseZoneId=@HouseZoneId , EntranceType = @EntranceType, Status= @Status, " +
                        "PictureXCoordinate=@PictureXCoordinate, PictureYCoordinate=@PictureYCoordinate " +
                        "Where HouseEntranceId=@HouseEntranceId ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseZoneId", this.HouseZoneId);
                        cmd.Parameters.AddWithValue("@EntranceType", this.EntranceType);
                        cmd.Parameters.AddWithValue("@Status", this.Status);
                        cmd.Parameters.AddWithValue("@PictureXCoordinate", this.PictureXCoordinate);
                        cmd.Parameters.AddWithValue("@PictureYCoordinate", this.PictureYCoordinate);
                        cmd.Parameters.AddWithValue("@HouseEntranceId", this.HouseEntranceId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }
    }
}
