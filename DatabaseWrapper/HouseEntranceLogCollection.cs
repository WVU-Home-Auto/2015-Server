using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWrapper
{
    public class HouseEntranceLogCollection
    {
        public List<HouseEntranceLog> HouseEntranceLogList { get; set; }

        internal string _connectionString = "Data Source=DEVELOPMENT;Initial Catalog=test4_db;Integrated Security=True";

        public void LoadAll()
        {
            this.HouseEntranceLogList = new List<HouseEntranceLog>();

            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * From HouseEntranceLog", conn))
                {
                    
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        conn.Open();
                        da.Fill(dt);
                        foreach (DataRow row in dt.Rows)
                        {
                            HouseEntranceLog log = new HouseEntranceLog();
                            log.HouseEntranceLogId = Convert.ToInt32(row["HouseEntranceLogId"]);
                            log.HouseEntranceId = Convert.ToInt32(row["HouseEntranceId"]);
                            log.Event = Convert.ToString(row["Event"]);
                            log.TimeStamp = Convert.ToDateTime(row["TimeStamp"]);

                            this.HouseEntranceLogList.Add(log);
                        }
                        
                        conn.Close();
                    }
                }
            }
        }
    }
}
