using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TableWrapperTesting
{
    class TemperatureSensor
    {
        public int TemperatureSensorId { get; set; }
        public int HouseZoneId { get; set; }
        public double CurrentTemperature { get; set; }

        internal string _connectionString = "Data Source=DEVELOPMENT;Initial Catalog=test4_db;Integrated Security=True";

        public void LoadByPrimaryKey(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From TemperatureSensor Where TemperatureSensorId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.TemperatureSensorId = Convert.ToInt32(dt.Rows[0]["TemperatureSensorId"]);
                            this.HouseZoneId = Convert.ToInt32(dt.Rows[0]["HouseZoneId"]);
                            this.CurrentTemperature = Convert.ToDouble(dt.Rows[0]["CurrentTemperature"]);
                        }
                        conn.Close();
                    }
                }
            }
        }

        public void Save()
        {
            if (this.TemperatureSensorId == 0) // insert
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into TemperatureSensor (HouseZoneId, CurrentTemperature) Values(@HouseZoneId, @CurrentTemperature) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseZoneId", this.HouseZoneId);
                        cmd.Parameters.AddWithValue("@CurrentTemperature", this.CurrentTemperature);
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
                    using (SqlCommand cmd = new SqlCommand("Update TemperatureSensor Set TemperatureSensorId=@TemperatureSensorId , CurrentTemperature = @CurrentTemperature Where TemperatureSensorId=@TemperatureSensorId ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseZoneId", this.HouseZoneId);
                        cmd.Parameters.AddWithValue("@CurrentTemperature", this.CurrentTemperature);
                        cmd.Parameters.AddWithValue("@TemperatureSensorId", this.TemperatureSensorId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }

    }
}
