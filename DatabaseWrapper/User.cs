using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWrapper
{
    public class User
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Access { get; set; }

        internal string _connectionString = "Data Source=DEVELOPMENT;Initial Catalog=test4_db;Integrated Security=True";

        public Boolean Authenticate(string username, string password)
        {
            bool isAuthenticated = false;

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From dbo.[User] Where UserName = @username and password = @password", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                            this.Password = Convert.ToString(dt.Rows[0]["Password"]);
                            this.Access = Convert.ToString(dt.Rows[0]["Access"]);

                            isAuthenticated = true;
                        }
                        conn.Close();
                    }
                }
            }

            return isAuthenticated;
        }

        public void LoadByPrimaryKey(string username)
        {
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From User Where UserName = @username", conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        if (dt.Rows.Count > 0)
                        {
                            this.UserName = Convert.ToString(dt.Rows[0]["UserName"]);
                            this.Password = Convert.ToString(dt.Rows[0]["Password"]);
                            this.Access = Convert.ToString(dt.Rows[0]["Access"]);
                        }
                        conn.Close();
                    }
                }
            }
        }

        public void Save()
        {
            if (this.UserName.Equals("Joshua")) // insert
            {
                using (SqlConnection conn = new SqlConnection(_connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("Insert Into User (Password, Access) Values(@Password, @Access) ", conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", this.Password);
                        cmd.Parameters.AddWithValue("@Access", this.Access);
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
                    using (SqlCommand cmd = new SqlCommand("Update User Set Password=@Password , Access = @Access Where UserName=@UserName ", conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", this.Password);
                        cmd.Parameters.AddWithValue("@Access", this.Access);
                        cmd.Parameters.AddWithValue("@UserName", this.UserName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();

                    }
                }
            }
        }
    }
}
