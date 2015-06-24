using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DatabaseWrapper
{
    public class HouseZone
    {
        public int HouseZoneId { get; set; }
        public string Name { get; set; }
        public string WireFramePictureURI { get; set; }
        public string PictureURI { get; set; }

        internal string _connectionString = Globals.connectionString;

        public void LoadByPrimaryKey(int id)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From HouseZone Where HouseZoneId = @id", conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.HouseZoneId = Convert.ToInt32(dt.Rows[0]["HouseZoneId"]);
                            this.Name = Convert.ToString(dt.Rows[0]["Name"]);
                            this.WireFramePictureURI = Convert.ToString(dt.Rows[0]["WireFramePictureUri"]);
                            this.PictureURI = Convert.ToString(dt.Rows[0]["PictureUri"]);
                        }
                        conn.Close();
                    }
                }
            }
        }

        public void Save()
        {
            if (this.HouseZoneId == 0) // insert
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into HouseZone (WireFramePictureUri, Name, PictureUri) Values(@WireFramePictureUri, @Name, @PictureUri) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@WireFramePictureUri", this.WireFramePictureURI);
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@PictureUri", this.PictureURI);
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
                    using (SqlCommand cmd = new SqlCommand("Update HouseZone Set WireFramePictureUri=@WireFramePictureUri , Name = @Name, PictureUri= @PictureUri Where HouseZoneId=@HouseZoneId ", conn))
                    {
                        cmd.Parameters.AddWithValue("@HouseZoneId", this.HouseZoneId);
                        cmd.Parameters.AddWithValue("@WireFramePictureUri", this.WireFramePictureURI);
                        cmd.Parameters.AddWithValue("@Name", this.Name);
                        cmd.Parameters.AddWithValue("@PictureUri", this.PictureURI);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }

    }
}

