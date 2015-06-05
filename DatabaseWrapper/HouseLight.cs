using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseWrapper
{
    public class HouseLight
    {
        public int HouseLightId { get; set; }
        public int HouseZoneId { get; set; }
        public bool LightSet { get; set; }
        public double Wattage { get; set; }

        internal string _connectionString = "Data Source=DEVELOPMENT;Initial Catalog=test4_db;Integrated Security=True";

        public void LoadByPrimaryKey(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From HouseLight Where HouseLightId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.HouseLightId = Convert.ToInt32(dt.Rows[0]["HouseLightId"]);
                            this.HouseZoneId = Convert.ToInt32(dt.Rows[0]["HouseZoneId"]);
                            this.LightSet = Convert.ToBoolean(dt.Rows[0]["LightSet"]);
                            this.Wattage = Convert.ToDouble(dt.Rows[0]["Wattage"]);
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
                    using (SqlCommand cmd = new SqlCommand("Insert Into HouseLight (HouseZoneId, LightSet, Wattage) Values(@HouseZoneId, @LightSet, @Wattage) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseZoneId", this.HouseZoneId);
                        cmd.Parameters.AddWithValue("@LightSet", this.LightSet);
                        cmd.Parameters.AddWithValue("@Wattage", this.Wattage);
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
                    using (SqlCommand cmd = new SqlCommand("Update HouseLight Set HouseZoneId=@HouseZoneId , LightSet = @LightSet, Wattage= @Wattage Where HouseLightId=@HouseLightId ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseZoneId", this.HouseZoneId);
                        cmd.Parameters.AddWithValue("@LightSet", this.LightSet);
                        cmd.Parameters.AddWithValue("@Wattage", this.Wattage);
                        cmd.Parameters.AddWithValue("@HouseLightId", this.HouseLightId);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }

    }
}
